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
using System.Windows.Shapes;

namespace Priiil.Admin
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        public Admin()
        {
            InitializeComponent();
            gridenko.Children.Add(new AdMain());
            CurDol.Visibility = Visibility.Hidden;
            //CurTov.Visibility = Visibility.Hidden;
            //CurBrands.Visibility = Visibility.Hidden;
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
        private void InfoSistem_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Информационная система - кулинарная книга, " +
                "создателем является Роженцов Сергей.",
                "Информация о системе");
        }
        private void Contact_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Номер Максима: 89129703586" + "\nНомер Светы : 89995474616" +
            "\nПочта Максима: Koroliov_maxz@mail.ru" + "\nПочта Светы: Lob.cve@yandex.com",
            "Контакты");
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
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
        private void Button_Click(object sender, MouseButtonEventArgs e)
        {
            Label button = (Label)sender;
            int id = Convert.ToInt32(button.Uid);
            Cursors(id);
            switch (id)
            {
                case 0:
                    gridenko.Children.Clear();
                    gridenko.Children.Add(new AdMain());
                    break;
                case 1:
                    gridenko.Children.Clear();
                    gridenko.Children.Add(new SpisokZayavok());
                    break;
                case 2:
                    gridenko.Children.Clear();
                    gridenko.Children.Add(new SpisokGruppovihZayavok());
                    break;
            }
        }
    }
}
