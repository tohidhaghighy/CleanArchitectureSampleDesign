namespace LTMS.Core.GenericDataResponse
{
    public class ResponseError
    {
        public ResponseError(DataResponseErrorCode errorCode,string errorDescription)
        {
            ErrorCode = errorCode;
            ErrorDescription = errorDescription;
        }

        public ResponseError()
        {
            
        }
        public DataResponseErrorCode ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
    }
}