namespace TeduMicroservices.IDP.Infrastructure.Common
{
    public class Pagination<T>
    {
        public List<T> Items { get; set; }

        public int TotalRecords { get; set; }
    }
}
