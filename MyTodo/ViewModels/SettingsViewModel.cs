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
    public class SettingsViewModel : BindableBase
    {
        public DelegateCommand<MenuBar> NavigateCommand { get; private set; }
        public IRegionManager RegionManager { get; private set; }
        public SettingsViewModel(IRegionManager regionManager)
        {
            this.menuBars = new ObservableCollection<MenuBar>();
            this.NavigateCommand = new DelegateCommand<MenuBar>(Navigate);
            RegionManager = regionManager;
            CreateMenuBar();
        }
        private ObservableCollection<MenuBar> menuBars;
        public ObservableCollection<MenuBar> MenuBars
        {
            get { return menuBars; }
            set { menuBars = value; RaisePropertyChanged(); }
        }
        private void Navigate(MenuBar obj)
        {
            if (obj != null && !string.IsNullOrWhiteSpace(obj.NameSpace))
                RegionManager.Regions[PrismManager.SettingsViewRegionName].RequestNavigate(obj.NameSpace);
        }
        void CreateMenuBar()
        {
            menuBars.Clear();
            menuBars.Add(new MenuBar { Icon = "Palette", Id = 1, NameSpace = "SkinView", Title = "个性化" });
            menuBars.Add(new MenuBar { Icon = "Cog", Id = 2, NameSpace = "", Title = "系统设置" });
            menuBars.Add(new MenuBar { Icon = "Information", Id = 3, NameSpace = "AboutView", Title = "关于更多" });
        }
    }
}
