using MyTodo.Common.Models;
using MyTodo.Extentions;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTodo.ViewModels
{
    public class MainViewModel : BindableBase
    {
        public DelegateCommand<MenuBar> NavigateCommand { get; private set; }
        public DelegateCommand GoBackCommand { get; private set; }
        public DelegateCommand GoForwardCommand { get; private set; }
        public IRegionManager RegionManager { get; private set; }
        private IRegionNavigationJournal regionNavigationJournal;
        public MainViewModel( IRegionManager regionManager)
        {
            this.menuBars = new ObservableCollection<MenuBar>();
            CreateMenuBar();
            this.NavigateCommand = new DelegateCommand<MenuBar>(Navigate);
            RegionManager = regionManager;
            GoBackCommand = new DelegateCommand(() =>
            {
                if (regionNavigationJournal != null && regionNavigationJournal.CanGoBack)
                {
                    regionNavigationJournal.GoBack();
                }
            });
            GoForwardCommand = new DelegateCommand(() =>
            {
                if (regionNavigationJournal!= null && regionNavigationJournal.CanGoForward)
                {
                    regionNavigationJournal.GoForward();
                }
            });
        }


        
        private void Navigate(MenuBar obj)
        {
            if (obj != null && !string.IsNullOrWhiteSpace(obj.NameSpace))
                RegionManager.Regions[PrismManager.MainViewRegionName].RequestNavigate(obj.NameSpace,back =>
                {
                    regionNavigationJournal = back.Context.NavigationService.Journal;
                });
        }

        private ObservableCollection<MenuBar> menuBars;
        public ObservableCollection<MenuBar> MenuBars
        {
            get { return menuBars; }
            set { menuBars = value;RaisePropertyChanged(); }
        }
        void CreateMenuBar()
        {
            menuBars.Clear();
            menuBars.Add(new MenuBar { Icon = "Home", Id = 1, NameSpace = "IndexView", Title = "首页" });
            menuBars.Add(new MenuBar { Icon = "NotebookOutline", Id = 2, NameSpace = "TodoView", Title = "待办事项" });
            menuBars.Add(new MenuBar { Icon = "Notebook", Id = 3, NameSpace = "MemoView", Title = "备忘录" });
            menuBars.Add(new MenuBar { Icon = "Cog", Id = 4, NameSpace = "SettingsView", Title = "设置" });
        }
    }
}
