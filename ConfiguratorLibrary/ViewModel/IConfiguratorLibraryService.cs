using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ConfiguratorLibrary
{
    public interface IConfiguratorLibraryService
    {
        UserControl MainPage { get; }
        bool LoadResult { get;}
    }
}
