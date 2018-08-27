using System.Collections.ObjectModel;
using Prism.Regions;
using SelecBo.Models;
using SelecBo.Servies;

namespace SelecBo.ViewModels
{
    public class PatchListViewModel : INavigationAware
    {
        #region Private Field

        private readonly IScriptService _scriptService;

        #endregion

        #region Ctor

        public PatchListViewModel(IScriptService scriptService)
        {
            // Injection
            _scriptService = scriptService;

            // Initialization
            PatchList = new ObservableCollection<PatchItem>();
        }

        #endregion

        #region Bindable Property

        public ObservableCollection<PatchItem> PatchList { get; set; }

        #endregion

        #region Method

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            refreshList();
        }

        private void refreshList()
        {
            _scriptService.Load();
            PatchList.Clear();
            PatchList.AddRange(_scriptService.Patches);
        }

        private void run()
        {
            _scriptService.Run();
        }

        #endregion
    }
}
