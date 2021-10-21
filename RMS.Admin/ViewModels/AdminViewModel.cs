using Prism.Commands;
using Prism.Mvvm;
using System.Linq;
using RMS.Structures;
using RMS.Structures.Interfaces;
using System.Collections.ObjectModel;

namespace RMS.Admin.ViewModels
{
    public class AdminViewModel : BindableBase
    {
        public ObservableCollection<ITabItem> TabItems { get; private set; }

        public AdminViewModel()
        {
            TabItems = new ObservableCollection<ITabItem>();
        }

        private DelegateCommand<object> openTabCommand;

        public DelegateCommand<object> OpenTabCommand
        {
            get
            {
                if(openTabCommand == null)
                {
                    openTabCommand = new DelegateCommand<object>(OpenTabExecute);
                }
                return openTabCommand;
            }
        }

        private DelegateCommand<object> closeTabCommand;

        public DelegateCommand<object> CloseTabCommand
        {
            get
            {
                if(closeTabCommand == null)
                {
                    closeTabCommand = new DelegateCommand<object>(CloseTabExecute);
                }
                return closeTabCommand;
            }
        }

        private ITabItem selectedTab;
        public ITabItem SelectedTab
        {
            get
            {
                return selectedTab;
            }
            set
            {
                SetProperty(ref selectedTab, value);
            }
        }


        private void OpenTabExecute(object tabType)
        {
            if(tabType != null)
            {
                TabType type = (TabType)tabType;

                if (type == TabType.Inventory && !TabItems.Any(item => item.TabType == TabType.Inventory))
                {
                    ITabItem newTab = new InventoryViewModel();
                    TabItems.Add(newTab);
                    SelectedTab = newTab;
                }

                if (type == TabType.Menu && !TabItems.Any(item => item.TabType == TabType.Menu))
                {
                    ITabItem newTab = new MenuViewModel();
                    TabItems.Add(newTab);
                    SelectedTab = newTab;
                }

                if (type == TabType.Staff && !TabItems.Any(item => item.TabType == TabType.Staff))
                {
                    ITabItem newTab = new StaffsViewModel();
                    TabItems.Add(newTab);
                    SelectedTab = newTab;
                }
            }
        }

        private void CloseTabExecute(object tabToDelete)
        {
            if (tabToDelete != null)
            {
                TabItems.Remove((ITabItem)tabToDelete);
            }
        }
    }
}
