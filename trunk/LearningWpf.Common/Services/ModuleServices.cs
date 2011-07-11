using LearningWpf.Common.Interfaces;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;

namespace LearningWpf.Common.Services
{
    public class ModuleServices : IModuleServices
    {
        #region Fields

        // Member variables
        private readonly IUnityContainer m_Container;

        #endregion

        #region Constructor

        public ModuleServices(IUnityContainer container)
        {
            m_Container = container;
        }

        #endregion

        /// <summary>
        /// Activates a named view.
        /// </summary>
        public void ActivateView(string viewName)
        {
            // Initialize
            var regionManager = m_Container.Resolve<IRegionManager>();

            // Deactivate current view
            IRegion workspaceRegion = regionManager.Regions["WorkspaceRegion"];
            var views = workspaceRegion.Views;
            foreach (var view in views)
            {
                workspaceRegion.Deactivate(view);
            }

            // Activate named view
            var viewToActivate = regionManager.Regions["WorkspaceRegion"].GetView(viewName);
            regionManager.Regions["WorkspaceRegion"].Activate(viewToActivate);
        }
    }
}
