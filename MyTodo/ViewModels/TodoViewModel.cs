using MyTodo.Common.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTodo.ViewModels
{
    public class TodoViewModel : BindableBase
    {
        public DelegateCommand AddCommand { get; private set; }
        private bool isRightDrawerOpen;

        public bool IsRightDrawerOpen
        {
            get { return isRightDrawerOpen; }
            set { isRightDrawerOpen = value;RaisePropertyChanged(); }
        }

        public TodoViewModel()
        {
            toDoDtos = new ObservableCollection<ToDoDto>();
            createData();
            AddCommand = new DelegateCommand(Add);
        }

        private void Add()
        {
            IsRightDrawerOpen = true;
        }

        private void createData()
        {
            for (int i = 0; i < 10; i++)
            {
                toDoDtos.Add(new ToDoDto() { Content = "测试内容", Title = "标题" + i });
            }
        }

        private ObservableCollection<ToDoDto> toDoDtos;

        public ObservableCollection<ToDoDto> ToDoDtos
        {
            get { return toDoDtos; }
            set { toDoDtos = value;RaisePropertyChanged(); }
        }

    }
}
