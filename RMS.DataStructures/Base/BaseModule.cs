using Microsoft.Practices.Unity;
using Prism.Modularity;
using Prism.Regions;

namespace RMS.DataStructures.Base
{
    public abstract class BaseModule : IModule
    {
        protected BaseModule(IUnityContainer unityContainer, IRegionManager regionManager)
        {
            Container = unityContainer;
            RegionManager = regionManager;
        }

        public virtual void Initialize()
        {

        }

        //
        // Summary:
        //     The unity container
        protected IUnityContainer Container { get; }
        //
        // Summary:
        //     Gets the region manager.
        protected IRegionManager RegionManager { get; }
    }
}
