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

namespace Shigapov_Autoservice_new
{
    /// <summary>
    /// Логика взаимодействия для ServicePage.xaml
    /// </summary>
    public partial class ServicePage : Page
    {
        public ServicePage()
        {
            InitializeComponent();
            var currentServices = masterEntities.GetContext().Service.ToList();
            ServiceListView.ItemsSource = currentServices;
        }

        private void Button_click(object sender, RoutedEventArgs e)
        {
                Manager.MainFrame.Navigate(new AddEditPage());
        }
    }
}
