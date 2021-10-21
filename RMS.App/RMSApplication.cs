using RMS.App.ViewModels;
using RMS.Structures.Interfaces;
using System;

namespace RMS.App
{
    public class RMSApplication : IApplication
    {
        public RMSApplication()
        {
            MainWindowViewModel = new MainWindowViewModel(this);
        }
        public IMainWindowViewModel MainWindowViewModel { get; set; }
    }
}
