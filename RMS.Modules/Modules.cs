using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;
using RMS.DataStructures;
using RMS.DataStructures.Admin;
using RMS.DataStructures.Base;

namespace RMS.Modules
{
    [Module(ModuleName = ModuleNames.Modules)]
    [ModuleDependency(ModuleNames.AdminModule)]
    public class Modules : BaseModule, IModules
    {
        public Modules(IUnityContainer unityContainer, IRegionManager regionManager, IAdmin adminModule) 
            : base(unityContainer, regionManager)
        {
            this.AdminModule = adminModule;
        }

        public IAdmin AdminModule { get; }

        public void Clear()
        {

        }

        public override void Initialize()
        {
            Container.RegisterInstance<IModules>(this);
            Clear();
        }
    }
}
