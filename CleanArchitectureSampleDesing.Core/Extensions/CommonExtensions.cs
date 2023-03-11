using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using LTMS.Core.GenericDataResponse;

namespace LTMS.Core.Extensions
{
    public static class CommonExtensions
    {
        public static DataResponse<IEnumerable<TResponse>> ToDataResponse<TResponse>(this IEnumerable<TResponse> lst)
        {
            var dataResponse = new DataResponse<IEnumerable<TResponse>>();
            try
            {
                dataResponse.Result = lst;
                return dataResponse;
            }
            catch (Exception e)
            {
                dataResponse.ErrorList = new List<ResponseError>();
                ResponseError error = new ResponseError(){ErrorCode = DataResponseErrorCode.InternalError,ErrorDescription = e.Message};
                return dataResponse;
            }
        }
        public static DataResponse<TResponse> ToDataResponse<TResponse>(this TResponse obj)
        {
            var dataResponse = new DataResponse<TResponse>();
            try
            {
                dataResponse.Result = obj;
                return dataResponse;
            }
            catch (Exception e)
            {
                dataResponse.ErrorList = new List<ResponseError>();
                ResponseError error = new ResponseError() { ErrorCode = DataResponseErrorCode.InternalError, ErrorDescription = e.Message };
                return dataResponse;
            }
        }
    }
}
