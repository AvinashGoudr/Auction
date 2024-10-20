namespace Auction.Domain.Modeles
{
    public class ApiResponseModel<T>
    {
        public int Code { get; set; }

        public T? Data { get; set; }

        public int TotalCount { get; set; }

        public bool RequestStatus { get; set; }
    }
}
