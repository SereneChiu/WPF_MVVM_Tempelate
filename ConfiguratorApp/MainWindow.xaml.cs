using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ConfiguratorLibrary;

namespace ConfiguratorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private UserControl1 mMainPage = null;

        public UserControl1 MainPage 
        {
            get { return mMainPage; }
            set { mMainPage = value; }
        }
        public MainWindow()
        {
            InitializeComponent();
            frame.Navigate(new UserControl1());
        }
    }
}
