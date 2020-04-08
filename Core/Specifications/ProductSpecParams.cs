namespace Core.Specifications
{
    public class ProductSpecParams
    {
        private const int MaxpageSize = 50;
        public int PageIndex { get; set; } = 1;
        public int _pageSize = 6;
        public int PageSize { 
            get => _pageSize;
            set => _pageSize = (value > MaxpageSize) ? MaxpageSize : value;
        }
        public int? BrandId { get; set; }
        public int? TypeId { get; set; }
        public string Sort { get; set; }
        private string _seach;
        public string Search
        {
            get => _seach;
            set => _seach = value.ToLower();
        }
    }
}