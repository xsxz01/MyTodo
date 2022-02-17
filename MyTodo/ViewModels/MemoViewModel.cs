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
    public class MemoViewModel :BindableBase
    {
        public DelegateCommand AddCommand { get; private set; }
        private bool isRightDrawerOpen;
        public bool IsRightDrawerOpen
        {
            get { return isRightDrawerOpen; }
            set { isRightDrawerOpen = value; RaisePropertyChanged(); }
        }
        private ObservableCollection<MemoDto> memoDtos;

        public ObservableCollection<MemoDto> MemoDtos
        {
            get { return memoDtos; }
            set { memoDtos = value;RaisePropertyChanged(); }
        }

        public MemoViewModel()
        {
            memoDtos = new ObservableCollection<MemoDto>();
            AddCommand = new DelegateCommand(Add);
            createData();
        }

        private void Add()
        {
            IsRightDrawerOpen = true;
        }

        private void createData()
        {
            for (int i = 0; i < 10; i++)
            {
                memoDtos.Add(new MemoDto() { Content = "测试内容", Title = "标题"+i });
            }
        }
    }
}
