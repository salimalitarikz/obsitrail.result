namespace Obsitrail.Result
{
    public sealed class Result<T>
    {
        public bool IsSuccess { get; }
        public T Value { get; }
        public Error Error { get; }

        private Result(T value)
        {
            IsSuccess = true;
            Value = value;
            Error = null!;
        }   

        private Result(Error error)
        {
            IsSuccess = false;
            Value = default!;
            Error = error;
        }

        public static Result<T> Success(T value) => new(value);
        public static Result<T> Failure(string message) => new(new Error(message));
    }
}
