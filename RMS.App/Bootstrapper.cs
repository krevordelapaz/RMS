using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Unity;
using RMS.App.ViewModels;
using RMS.Structures.Interfaces;
using System;
using System.IO;
using System.Reflection;
using System.Windows;

namespace RMS.App
{
    public class Bootstrapper : UnityBootstrapper
    {
        private DependencyObject createdShell;
        private MainWindowViewModel shellViewModel;
        private IApplication application;

        protected override DependencyObject CreateShell()
        {
            createdShell = Container.Resolve<MainWindow>();
            return createdShell;
        }

        protected override void InitializeModules()
        {
            base.InitializeModules();
            createdShell.Dispatcher.BeginInvoke((Action)delegate
            {
                Application.Current.ShutdownMode = ShutdownMode.OnLastWindowClose;
                Application.Current.MainWindow = (MainWindow)createdShell;
                ((MainWindow)createdShell).Show();
                ((MainWindow)createdShell).Activate();
                ((MainWindow)createdShell).Focus();
            });
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new DirectoryModuleCatalog { ModulePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) };
        }


        protected override void ConfigureContainer()
        {
            base.ConfigureContainer();

            var defaultContainer = Container.Resolve<IModuleInitializer>();
            Container.RegisterInstance("defaultModuleInitializer", defaultContainer);
            //Container.RegisterType<IThemesSeeker, DllThemeSeeker>();
            Container.RegisterType<IApplication, RMSApplication>(new ContainerControlledLifetimeManager());
            Container.RegisterType<IModuleInitializer, ModulesInitializer>(new ContainerControlledLifetimeManager());
        }
    }
}
