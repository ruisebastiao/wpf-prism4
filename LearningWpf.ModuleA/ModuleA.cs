﻿using System;
using LearningWpf.ModuleA.Views;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.ServiceLocation;
using Microsoft.Practices.Unity;

namespace LearningWpf.ModuleA
{
    /// <summary>
    /// Initializer class for Module A of the Prism 4 Demo.
    /// </summary>
    public class ModuleA : IModule
    {
        #region IModule Members

        /// <summary>
        /// Initializes the module.
        /// </summary>
        public void Initialize()
        {
            /* We register always-available controls with the Prism Region Manager, and on-demand 
             * controls with the DI container. On-demand controls will be loaded when we invoke
             * IRegionManager.RequestNavigate() to load the controls. */

            // Register task button with Prism Region
            var regionManager = ServiceLocator.Current.GetInstance<IRegionManager>();
            regionManager.RegisterViewWithRegion("TaskButtonRegion", typeof(ModuleATaskButton));

            /* View objects have to be registered with Unity using the overload shown below. By
             * default, Unity resolves view objects as type System.Object, which this overload 
             * maps to the correct view type. See "Developer's Guide to Microsoft Prism" (Ver 4), 
             * p. 120. */

            // Register other view objects with DI Container (Unity)
            var container = ServiceLocator.Current.GetInstance<IUnityContainer>();
            container.RegisterType<Object, ModuleARibbonTab>("ModuleARibbonTab");
            container.RegisterType<Object, ModuleANavigator>("ModuleANavigator");
            container.RegisterType<Object, ModuleAWorkspace>("ModuleAWorkspace");
        }

        #endregion
    }
}
