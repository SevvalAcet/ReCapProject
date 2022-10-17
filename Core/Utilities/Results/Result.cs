namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool ısSuccess, string message):this(ısSuccess)
        {
            Message = message;
        }
        public Result(bool ısSuccess)
        {
            ısSuccess = ısSuccess;
        }


        public bool IsSuccess { get; }

        public string Message { get; }

    }
}
