﻿using System.Diagnostics;
using System.Windows;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using SelecBo.Misc;
using SelecBo.Servies;
using SelecBo.Views;

namespace SelecBo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register views
            containerRegistry.RegisterSingleton<Shell>();
            containerRegistry.RegisterForNavigation<PatchListView>(NavigationNames.PatchList);

            // Register types
            //containerRegistry.RegisterSingleton<IScriptService, ScriptService>();
            containerRegistry.RegisterSingleton<IScriptService, TestScriptService>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);

            //moduleCatalog.AddModule<ContentModule>();
        }

        protected override void InitializeShell(Window shell)
        {
            base.InitializeShell(shell);
            Container.Resolve<IRegionManager>().RequestNavigate(RegionNames.ShellMainRegion, NavigationNames.PatchList);
        }
    }
}
