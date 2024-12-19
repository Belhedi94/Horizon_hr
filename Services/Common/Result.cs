namespace Horizon_HR.Services.Common
{
    public class Result<T>
    {
        public T? Data { get; set; }

        public bool IsSuccess { get; set; }

        public string Message { get; set; }

        //public static Result<T> Success(T data) => new Result<T> { Data = data, IsSuccess = true};

        //public static Result<T> Failure(string errorMessage) => new Result<T> { ErrorMessage = errorMessage, IsSuccess = false};
    }
}
