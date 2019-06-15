using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
using MyPets.Models;
using MyPets.ViewModels;
namespace MyPets
{
    /// <summary>
    /// Логика взаимодействия для Authentification.xaml
    /// </summary>
    public partial class Authentification : Window
    {
        string lang;
        Repository repo;
        public Authentification()
        {
            InitializeComponent();
            repo = new Repository();
            ComboBoxLang.ItemsSource = new List<string>() { "US", "RU" };
        }



        private void Button_Click_REGIST(object sender, RoutedEventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Close();
        }
        

        private void Button_Click_MAIN(object sender, RoutedEventArgs e)
        {
            MD5 hasher = MD5.Create();

            var user = repo.GetUser(LoginTextBox.Text, md5Hasher.GetMd5Hash(hasher, PassBox.Password));

            if (user != null)
            {
                Repository.CurrUser = user;
                MainWindow mw =new MainWindow();

                mw.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Пользователь не найден. Пожалуйста, зарегистрируйтесь.");
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Repository.lang = ComboBoxLang.SelectedItem as string;
            string path = "pack://application:,,,/Resources/Lang/Lang" +
               ComboBoxLang.SelectedItem +
                ".xaml";
            this.Resources = new ResourceDictionary()
            {
                Source = new Uri(path)
            };
        }
    }
}
