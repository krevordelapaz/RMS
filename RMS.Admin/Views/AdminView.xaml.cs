using RMS.Admin.ViewModels;
using System.Windows.Controls;

namespace RMS.Admin.Views
{
    /// <summary>
    /// Interaction logic for AdminView.xaml
    /// </summary>
    public partial class AdminView : UserControl
    {
        public AdminView()
        {
            InitializeComponent();
        }

        public AdminView(AdminViewModel viewModel) : this()
        {
            DataContext = viewModel;
        }
    }
}
