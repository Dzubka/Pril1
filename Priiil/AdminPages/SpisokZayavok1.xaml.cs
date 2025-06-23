using Priiil.UserPages;
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

namespace Priiil.AdminPages
{
    /// <summary>
    /// Логика взаимодействия для SpisokZayavok1.xaml
    /// </summary>
    public partial class SpisokZayavok1 : UserControl
    {
        public SpisokZayavok1()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            ViborZayavki ADdAd = new ViborZayavki();
            ADdAd.Show();
        }
        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                prilEntities5.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                Zayavkis.ItemsSource = prilEntities5.GetContext().LichnayaZayavka.ToList();
            }
        }
    }
}
