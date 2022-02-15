using MyTodo.Common.Models;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTodo.ViewModels
{
    public class IndexViewModel :BindableBase
    {
        public IndexViewModel()
        {
            TaskBars = new ObservableCollection<TaskBar>();
            CreateTaskBar();
        }

        private void CreateTaskBar()
        {
            TaskBars.Add(new TaskBar() { Color = "", Content = "", Icon = "", Target = "", Title = "" });
        }

        private ObservableCollection<TaskBar> taskBars;

        public ObservableCollection<TaskBar> TaskBars
        {
            get { return taskBars; }
            set { taskBars = value;RaisePropertyChanged(); }
        }

    }
}
