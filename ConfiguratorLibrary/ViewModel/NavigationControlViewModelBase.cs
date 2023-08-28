using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfiguratorLibrary
{
    public class NavigationControlViewModelBase : ViewModelBase
    {
        private object currentPageViewModel;
        public object CurrentPageViewModel
        {
            get
            {
                return currentPageViewModel;
            }
            set
            {
                currentPageViewModel = value;
                OnPropertyChanged("");
            }
        }
    }
}
