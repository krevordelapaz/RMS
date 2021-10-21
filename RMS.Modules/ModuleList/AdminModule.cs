using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using RMS.Admin.ViewModels;
using RMS.DataStructures;

namespace RMS.Modules.ModuleList
{
    [Module(ModuleName = ModuleNames.AdminModule)]
    public class AdminModule : Admin.AdminModule
    {
        private AdminViewModel moduleViewModel;

        public AdminModule(IUnityContainer unityContainer, IRegionManager regionManager) : base(unityContainer, regionManager)
        {

        }

        protected override string RegionName => RegionNames.RMSAdminRegion;
    }
}
