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
            LoadTestData();
        }

        private void LoadTestData()
        {
            ToDoDtos = new ObservableCollection<ToDoDto>();
            memoDtos = new ObservableCollection<MemoDto>();

            for (int i = 0; i < 10; i++)
            {
                ToDoDtos.Add(new ToDoDto() { Content = "正在处理中...", Status = 1, Title = "代办" + i });
                memoDtos.Add(new MemoDto() { Content = "我的密码", Status = 1, Title = "备忘" + i });
            }

        }

        private void CreateTaskBar()
        {
            TaskBars.Add(new TaskBar() { Color = "#FF0CA0FF", Content = "9", Icon = "ClockFast", Target = "", Title = "汇总" });
            TaskBars.Add(new TaskBar() { Color = "#FF1ECA3A", Content = "9", Icon = "ClockCheckOutline", Target = "", Title = "已完成" });
            TaskBars.Add(new TaskBar() { Color = "#FF02C6DC", Content = "100%", Icon = "ChartLineVariant", Target = "", Title = "完成比例" });
            TaskBars.Add(new TaskBar() { Color = "#FFFFA000", Content = "19", Icon = "PlaylistStar", Target = "", Title = "备忘录" });
        }

        private ObservableCollection<TaskBar> taskBars;

        public ObservableCollection<TaskBar> TaskBars
        {
            get { return taskBars; }
            set { taskBars = value;RaisePropertyChanged(); }
        }

        private ObservableCollection<ToDoDto>  toDoDtos;

        public ObservableCollection<ToDoDto> ToDoDtos
        {
            get { return toDoDtos; }
            set { toDoDtos = value; RaisePropertyChanged(); }
        }

        private ObservableCollection<MemoDto>  memoDtos;

        public ObservableCollection<MemoDto> MemoDtos
        {
            get { return memoDtos; }
            set { memoDtos = value; RaisePropertyChanged(); }
        }

    }
}
