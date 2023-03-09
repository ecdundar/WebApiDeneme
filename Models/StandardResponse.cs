namespace BurulasWebApi.Models
{
    public abstract class BaseResponse
    {
        protected BaseResponse()
        {
            Status = false;
        }
        public Boolean Status { get; set; }
        public String ErrorCode { get; set; }
        public String Message { get; set; }
        public String ErrorMessage { get; set; }
        public String RequestMessage { get; set; }
        //public Exception Error { get; set; }
    }

    public class StandardResponse<T> : BaseResponse
    {
        public T Data { get; set; }
    }

    public class StandardResponse : BaseResponse
    { }


    public class ListResponse<T> : BaseResponse
    {
        public List<T> Data { get; set; }
    }

    public class ListResponse : BaseResponse
    { }
}
