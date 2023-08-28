using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ConfiguratorLibrary
{
    public class ConfiguratorLibraryService : IConfiguratorLibraryService
    {
        private bool mLoadResult = false;
        private UserControl1 mMainPage = new UserControl1();

        public UserControl MainPage 
        { 
            get 
            {
                mLoadResult = true;
                return mMainPage; 
            } 
        }
        public bool LoadResult { get { return mLoadResult; } }
    }
}
