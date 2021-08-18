namespace Application.Core
{
    public class AppException
    {
        /// <summary>
        /// App exception
        /// {Testing summary}
        /// </summary>
        /// <param name="statusCodePrm">statusCode</param>
        /// <param name="messagePrm">message</param>
        /// <param name="detailsPrm">details</param>
        public AppException(int statusCodePrm, string messagePrm, string detailsPrm = "")
        {
            StatusCode = statusCodePrm;
            Message = messagePrm;
            Details = detailsPrm;
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Details { get; set; }
    }
}