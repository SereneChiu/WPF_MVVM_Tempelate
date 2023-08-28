using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ConfiguratorLibrary
{
    class ConfiguratorLibraryService : IConfiguratorLibraryService
    {
        private UserControl1 mMainPage = new UserControl1();
        public UserControl MainPage { get { return mMainPage; } }
    }
}
