using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using ConfiguratorLibrary.View.Topology;
using ConfiguratorLibrary.View.Parameter;
using ConfiguratorLibrary.View.Monitor;

namespace ConfiguratorLibrary
{
    public class MainViewModel : NavigationControlViewModelBase
    {
        private TpgPage mTpgPage = new TpgPage();
        private ParamPage mParamPage = new ParamPage();
        private MonitorPage mMonitorPage = new MonitorPage();
        public MainViewModel()
        {
            ChangePage = new RelayCommand<string>(param => TargetPageStr = param);
        }


        string TargetPageStr
        {
            set
            {
                switch(value)
                {
                    case "Tpg": CurrentPageViewModel = mTpgPage; break;
                    case "Param": CurrentPageViewModel = mParamPage; break;
                    case "Monitor": CurrentPageViewModel = mMonitorPage; break;
                    default: return;
                }
            }
        }


        public ICommand ChangePage { set; get; }
    }
}
