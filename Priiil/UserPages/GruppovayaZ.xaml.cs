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
using System.Windows.Shapes;

namespace Priiil.UserPages
{
    /// <summary>
    /// Логика взаимодействия для GruppovayaZ.xaml
    /// </summary>
    public partial class GruppovayaZ : Window
    {
        private GruppovayaZayavka _gruppvisitors = new GruppovayaZayavka();

        public GruppovayaZ(GruppovayaZayavka add)
        {
            InitializeComponent();
            if (add != null) _gruppvisitors = add;
            DataContext = _gruppvisitors;
        }

    private void Button_Click_1(object sender, RoutedEventArgs e)
        {
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            prilEntities5.GetContext().GruppovayaZayavka.Add(_gruppvisitors);
            try
            {
                //prilEntities5.GetContext().SaveChanges();
                MessageBox.Show("Сохранено");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void AddVisitor(object sender, RoutedEventArgs e)
        {
            prilEntities5.GetContext().GruppovayaZayavka.Add(_gruppvisitors);
            try
            {
                prilEntities5.GetContext().SaveChanges();
                MessageBox.Show("Сохранено");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
    }
}
