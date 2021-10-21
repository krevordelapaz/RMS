using Prism.Mvvm;
using RMS.DataStructures.Admin.Models;
using RMS.Structures;
using RMS.Structures.Interfaces;
using System.Collections.ObjectModel;

namespace RMS.Admin.ViewModels
{
    public class StaffsViewModel : BindableBase, ITabItem
    {
        public TabType TabType { get; set; }
        public string TabTitle { get; set; }

        public StaffsViewModel()
        {
            TabType = TabType.Staff;
            TabTitle = "Staffs";
            Staffs = new ObservableCollection<Staff>();
        }

        public ObservableCollection<Staff> Staffs
        {
            get;
        }

    }
}
