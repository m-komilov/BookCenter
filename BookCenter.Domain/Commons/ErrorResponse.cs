namespace BookCenter.Domain.Commons
{
    public class ErrorResponse
    {
        #pragma warning disable
        public ErrorResponse(int? code = null, string message = null)
        {
            Code = code;
            Message = message;
        }
        public int? Code { get; set; }
        public string Message { get; set; }
    }
}
