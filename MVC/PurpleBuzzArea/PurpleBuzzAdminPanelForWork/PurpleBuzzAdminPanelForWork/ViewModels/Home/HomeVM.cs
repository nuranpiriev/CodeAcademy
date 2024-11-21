using PurpleBuzzAdminPanelForWork.Models;

namespace PurpleBuzzAdminPanelForWork.ViewModels.Home
{
    public class HomeVM
    {
        public IEnumerable<Service> Services { get; set; }
        public IEnumerable<Work> Works { get; set; }
    }
}
