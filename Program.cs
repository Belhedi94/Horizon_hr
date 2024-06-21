using Horizon_HR.AppDataContext;
using Horizon_HR.Interfaces;
using Horizon_HR.Middleware;
using Horizon_HR.Models;
using Horizon_HR.Services;
using Serilog;

Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()  // Log to console
            .WriteTo.File("logs/log_.txt", rollingInterval: RollingInterval.Day)  // Log to file, daily rolling
            .CreateLogger();

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<DbSettings>(builder.Configuration.GetSection("DbSettings"));
builder.Services.AddSingleton<DataBaseContext>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();
builder.Services.AddLogging();
builder.Services.AddScoped<IUserServices, UserServices>();
builder.Services.AddScoped<IFileStorageService, FileStorageService>();
builder.Host.UseSerilog();

var app = builder.Build();

{
    using var scope = app.Services.CreateScope();
    var context = scope.ServiceProvider;
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();
else
    app.UseExceptionHandler("/error");


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseStaticFiles();


app.Run();
