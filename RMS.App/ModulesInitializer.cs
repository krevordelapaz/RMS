using Microsoft.Practices.Unity;
using Prism.Modularity;
using System.Collections.Generic;
using System.Linq;

namespace RMS.App
{
    public class ModulesInitializer : IModuleInitializer
    {
        bool initialModuleLoadCompleted;
        private readonly IModuleInitializer defaultInitializer;
        private readonly IModuleCatalog defaultCatalog;
        List<ModuleInfo> modules = new List<ModuleInfo>();

        public ModulesInitializer(IUnityContainer container)
        {
            defaultInitializer = container.Resolve<IModuleInitializer>("defaultModuleInitializer");
            defaultCatalog = container.Resolve<IModuleCatalog>();
        }

        public void Initialize(ModuleInfo moduleInfo)
        {
            if (initialModuleLoadCompleted)
            {
                //Module loaded on demand after application startup - use the default initializer
                defaultInitializer.Initialize(moduleInfo);
                return;
            }

            modules.Add(moduleInfo);

            if (AllModulesLoaded())
            {
                foreach (var module in modules)
                {
                    defaultInitializer.Initialize(module);
                }
                modules = null;
                initialModuleLoadCompleted = true;
            }
        }

        private bool AllModulesLoaded()
        {
            return defaultCatalog.Modules.Count() <= modules.Count;

        }
    }
}
