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
using System.Threading;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using MyPets.ViewModels;
using MyPets.Models;

namespace MyPets
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {

        public Registration()
        {
            InitializeComponent();
            string path = "pack://application:,,,/Resources/Lang/Lang" +
                           Repository.lang +
                            ".xaml";
            this.Resources = new ResourceDictionary()
            {
                Source = new Uri(path)
            };
        }

        private void Button_Click_NewReg(object sender, RoutedEventArgs e)
        {
            string loginResult = Validator.ValidLogin(LoginTextBox.Text);
            bool passResult = Validator.ValidPass(PassBox.Password);


            if(String.IsNullOrEmpty(loginResult))
            {
                if (passResult)
                {

                    Repository repo = new Repository();
                    USER user = new USER();
                    user.userLOGIN = LoginTextBox.Text;
                    user.userPASSWORD = PassBox.Password;
                    repo.CreateNewUser(user);
                   
                    MessageBox.Show("Регистрация прошла успешно!");

                    MainWindow mw = new MainWindow();
                    mw.Show();
                    this.Close();
                }
                else
                {
                    LabelValidP.Content = "Пароль должен содержать 6 символов (прописные, строчные и цифры)";
                }
            }
            else
            {
                LabelValidL.Content = loginResult;
            }
        }

        private void Button_Click_BACK(object sender, RoutedEventArgs e)
        {
            Authentification auth = new Authentification();
            auth.Show();
            this.Close();

        }
    }
}
