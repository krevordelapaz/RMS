using Prism.Mvvm;
using RMS.Structures;
using RMS.Structures.Interfaces;

namespace RMS.Admin.ViewModels
{
    public class MenuViewModel : BindableBase, ITabItem
    {
        public TabType TabType { get; set; }
        public string TabTitle { get; set; }

        public MenuViewModel()
        {
            TabType = TabType.Menu;
            TabTitle = "Menu Items";
        }
    }
}
