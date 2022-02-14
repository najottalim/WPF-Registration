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

namespace WPFreg
{
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Interaction logic for MainWindow.xaml
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
            
        private void RegisterButton(object sender, RoutedEventArgs e)
        {
            string email = EmailBoxUI.Text;
            string password = PasswordBoxUI.Password;

            if (String.IsNullOrEmpty(email) || !email.Contains("@"))
                MessageBox.Show("Enter email");

            else if (String.IsNullOrEmpty(password))
                MessageBox.Show("Enter password");

            else
            {
                MessageBox.Show("Saved Successfully");
                EmailBoxUI.Clear();
                PasswordBoxUI.Clear();
            }
        }

        private void EyeButton(object sender, RoutedEventArgs e)
        {   

        }
    }
}