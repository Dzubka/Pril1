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

namespace Priiil.UserPages
{
    /// <summary>
    /// Логика взаимодействия для SpisokZayavok.xaml
    /// </summary>
    public partial class SpisokZayavok : UserControl
    {
        public SpisokZayavok()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViborZayavki ADdAd = new ViborZayavki();
            ADdAd.Show();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            //LichnayaZ lookWorker = new LichnayaZ((sender as Button).DataContext as LichnayaZayavka);
            //lookWorker.Show();
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            var foremove = Zayavkis.SelectedItems.Cast<LichnayaZayavka>().ToList();
            if (foremove.Count == 0)
            {
                MessageBox.Show("Выделите нужную запись для удаления");
            }
            else
                if (MessageBox.Show($"Вы точно хотите удалить следующие {foremove.Count()} элементов?", "Внимание", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    prilEntities5.GetContext().LichnayaZayavka.RemoveRange(foremove);
                    prilEntities5.GetContext().SaveChanges();
                    Zayavkis.ItemsSource = prilEntities5.GetContext().Aut.ToList();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }

            }
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
