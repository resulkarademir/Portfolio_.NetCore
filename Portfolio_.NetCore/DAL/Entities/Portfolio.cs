namespace Portfolio_.NetCore.DAL.Entities
{
    public class Portfolio
    {
        public int PortfolioId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string SmallImageUrl { get; set; }
        public string BigImageUrl { get; set; }
        public string HomeTitle { get; set; }       
        public string HomeSubTitle { get; set; }
        public string HomeDescription { get; set; }

    }
}
