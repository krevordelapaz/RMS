using Prism.Commands;
using Prism.Mvvm;
using RMS.DataStructures.Admin.Models;
using RMS.Structures;
using RMS.Structures.Interfaces;
using System;
using System.Collections.ObjectModel;

namespace RMS.Admin.ViewModels
{
    public class InventoryViewModel : BindableBase, ITabItem
    {
        public TabType TabType { get; set; }

        private string tabTitle;
        public string TabTitle
        {
            get
            {
                return tabTitle;
            }
            set
            {
                SetProperty(ref tabTitle, value);
            }
        }

        public ObservableCollection<Item> Items { get; }

        private DelegateCommand addItemCommand;

        public DelegateCommand AddItemCommand
        {
            get
            {
                if(addItemCommand == null)
                {
                    addItemCommand = new DelegateCommand(AddItemCommandExecute);
                }
                return addItemCommand;
            }
        }

        private DelegateCommand deleteItemCommand;

        public DelegateCommand DeleteItemCommand
        {
            get
            {
                if (deleteItemCommand == null)
                {
                    deleteItemCommand = new DelegateCommand(DeleteItemCommandExecute);
                }
                return deleteItemCommand;
            }
        }

        private Item selectedItem;

        public Item SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                SetProperty(ref selectedItem, value);
            }
        }


        public InventoryViewModel()
        {
            TabType = TabType.Inventory;
            TabTitle = "Inventory";
            Items = new ObservableCollection<Item>();
        }

        private void AddItemCommandExecute()
        {
            Items.Add(new Item()
            {
                Name = "New Item"
            });
        }

        private void DeleteItemCommandExecute()
        {
            if(SelectedItem != null)
            {
                Items.Remove(SelectedItem);
            }
        }
    }
}
