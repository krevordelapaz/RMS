using RMS.Admin.ViewModels;
using System.Windows;
using System.Windows.Controls;

namespace RMS.Sdmin
{
    public class AdminDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate InventoryDataTemplate
        {
            get;
            set;
        }

        public DataTemplate MenuDataTemplate
        {
            get;
            set;
        }

        public DataTemplate StaffsDataTemplate
        {
            get;
            set;
        }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            if (item is InventoryViewModel)
                return InventoryDataTemplate;

            if (item is MenuViewModel)
                return MenuDataTemplate;

            if (item is StaffsViewModel)
                return StaffsDataTemplate;

            return null;
        }
    }
}
