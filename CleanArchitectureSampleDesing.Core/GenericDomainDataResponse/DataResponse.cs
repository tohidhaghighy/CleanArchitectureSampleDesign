using System.Collections.Generic;
using System.Linq;

namespace LTMS.Core.GenericDataResponse
{
    public class DataResponse<TResult>
    {
        public bool IsSuccess
        {
            get
            {
                if (ErrorList==null || !ErrorList.Any()) return true;
                return false;
            }
        }

        public List<ResponseError> ErrorList { get; set; }
        public TResult Result { get; set; }
    }
}
