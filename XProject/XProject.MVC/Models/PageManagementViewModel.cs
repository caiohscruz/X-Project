namespace XProject.MVC.Models
{
    public class PageManagementViewModel
    {
        public List<string> Pages =>
                new List<string>()
                {
                    "Home",
                    "Privacy",
                    "Random Page",
                    "Page Management"
                };
    }
}