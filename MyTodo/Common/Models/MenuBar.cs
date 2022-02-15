using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTodo.Common.Models
{
    public class MenuBar : BindableBase
    {
        public int Id { get; set; }
        /// <summary>
        /// 图标
        /// </summary>
        private string icon;
        public string Icon
        {
            get { return icon; }
            set { SetProperty(ref icon, value); }
        }
        /// <summary>
        /// 菜单名称
        /// </summary>
        private string title;
        public string Title
        {
            get { return title; }
            set { SetProperty(ref title, value); }
        }
        /// <summary>
        /// 菜单命名空间
        /// </summary>
        private string nameSpace;
        public string NameSpace
        {
            get { return nameSpace; }
            set { SetProperty(ref nameSpace, value); }
        }

    }
}
