using Priiil.Admin;
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
    /// Логика взаимодействия для ViborZayavki.xaml
    /// </summary>
    public partial class ViborZayavki : Window
    {
        public ViborZayavki()
        {
            InitializeComponent();
          
        }
        public void ShowNewWindow(Window window)
        {
            window.Show();
            this.Close();
        }
        #region Прочее
        private void Cursors(int id)
        {
            CurMain.Visibility = Visibility.Hidden;
            CurDol.Visibility = Visibility.Hidden;
            //CurTov.Visibility = Visibility.Hidden;
            //CurBrands.Visibility = Visibility.Hidden;
            switch (id)
            {
                case 0:
                    CurMain.Visibility = Visibility.Visible;
                    break;
                case 1:
                    CurDol.Visibility = Visibility.Visible;
                    break;
                    //case 2:
                    //    CurTov.Visibility = Visibility.Visible;
                    //    break;
                    //case 3:
                    //    CurBrands.Visibility = Visibility.Visible;
                    //    break;
            }
        }

        private void Label_MouseEnter(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;
            label.Background = Brushes.SkyBlue;
        }

        private void Label_MouseLeave(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;
            label.Background = null;
        }
        #endregion
        private void Button_Click_1(object sender, MouseButtonEventArgs e)
        {
            ShowNewWindow(new GruppovayaZ(null));
            //Label button = (Label)sender;
            //int id = Convert.ToInt32(button.Uid);
            //Cursors(id);
            //switch (id)
            //{
            //    case 0:
            //        gridenko.Children.Clear();
            //        gridenko.Children.Add(new AdMain());
            //        break;
            //    case 1:
            //        gridenko.Children.Clear();
            //        gridenko.Children.Add(new SpisokZayavok());
            //        break;
            //case 2:
            //    gridenko.Children.Clear();
            //    gridenko.Children.Add(new AdminPages.LookTovar());
            //    break;
        }
        private void Button_Click_2(object sender, MouseButtonEventArgs e)
        {
            ShowNewWindow( new LichnayaZ(null));
        }
    }
}
