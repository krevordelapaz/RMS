using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using RMS.Admin.ViewModels;
using RMS.Admin.Views;
using RMS.DataStructures.Admin;
using RMS.DataStructures.Base;

namespace RMS.Admin
{
    [Module(OnDemand = true)]
    public abstract class AdminModule : BaseModule, IAdmin
    {
        private AdminViewModel moduleViewModel;

        public AdminModule(IUnityContainer unityContainer, IRegionManager regionManager) : base(unityContainer, regionManager)
        {

        }

        public override void Initialize()
        {
            Container.RegisterInstance<IAdmin>(this);
            moduleViewModel = CreateViewModel();
            RegionManager.RegisterViewWithRegion(RegionName, () => CreateView(moduleViewModel));
        }

        private AdminView CreateView(AdminViewModel viewModel)
        {
            return new AdminView(viewModel);
        }

        protected virtual AdminViewModel CreateViewModel()
        {
            return Container.Resolve<AdminViewModel>();
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        protected abstract string RegionName { get; }
    }
}
