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

namespace Priiil
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public void ShowNewWindow(Window window)
        {
            window.Show();
            this.Close();
        }

        private int id;
        private int idop(string dol)
        {
            if (dol == "admin")
                id = 1;
            else if (dol == "user")
                id = 2;
            return id;
        }

        private void doln_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Come_BN_Click(object sender, RoutedEventArgs e)
        {
            idop(doln.Text);
            var dir = from s in Manager.context.Aut
                      where s.login == logen.Text && s.password == passiword.Password && s.ID_Dolznosti == id
                      select new { logen = s.login, passiword = s.password, id = s.ID_Dolznosti };

            if (dir.Count() != 0)
            {
                if (id == 1)
                {
                    ShowNewWindow(new Admin.Admin());
                }

            }
            else MessageBox.Show("Данные введены неправильно");

            if (dir.Count() != 0)
            {
                if (id == 2)
                {
                    ShowNewWindow(new UserPages.User());
                }

            }
        }

        private void logen_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
