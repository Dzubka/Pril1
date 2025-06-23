using Microsoft.Win32;
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
    /// Логика взаимодействия для LichnayaZ.xaml
    /// </summary>
    public partial class LichnayaZ : Window
    {
        private LichnayaZayavka _solovisitors = new LichnayaZayavka();

        public LichnayaZ(LichnayaZayavka add)
        {
            InitializeComponent();
            if (add != null) _solovisitors = add;
            DataContext = _solovisitors;    
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddVisitor(object sender, RoutedEventArgs e)
        {
            prilEntities5.GetContext().LichnayaZayavka.Add(_solovisitors);
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

        private void LoadPhoto(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG (*.jpeg)|*.jpeg|PNG (*.png)|*.png|JPG (*.jpg)|*.jpg";
            Nullable<bool> result = ofd.ShowDialog();
            if (result == true)
            {
                Photo.Source = new BitmapImage(new Uri(ofd.FileName));
            }
        }
    }
}
