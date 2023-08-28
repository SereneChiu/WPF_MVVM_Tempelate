using System.Windows;
using ConfiguratorLibrary;

namespace ConfiguratorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IConfiguratorLibraryService mLibService = new ConfiguratorLibraryService();
        public MainWindow()
        {
            InitializeComponent();
            frame.Navigate(mLibService.MainPage);
        }
    }
}
