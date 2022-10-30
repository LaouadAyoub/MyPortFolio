using Core.Entities;

namespace Web.ViewModels
{
    public class HomeViewModel
    {
        public Owner Owner { get; set; }
        public Email Email { get; set; }
        public List<PortfolioItem> PortfolioItems { get; set; }
    }
}
