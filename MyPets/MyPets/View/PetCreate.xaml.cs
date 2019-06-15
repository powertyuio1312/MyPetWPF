using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
using MyPets.Models;
using MyPets.Utils;
using MyPets.ViewModels;

namespace MyPets
{
    /// <summary>
    /// Логика взаимодействия для PetCreate.xaml
    /// </summary>
    public partial class PetCreate : Window
    {
        Repository repo;
        USER user;
        public PetCreate(USER user)
        {
            InitializeComponent();
            repo = new Repository();
            this.user = user;
            string path = "pack://application:,,,/Resources/Lang/Lang" +
                           Repository.lang +
                            ".xaml";
            this.Resources = new ResourceDictionary()
            {
                Source = new Uri(path)
            };
        }


        private void Button_Click_BACK(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
            this.Close();
        }

        private void Button_Click_Creating(object sender, RoutedEventArgs e)
        {
            if ((CatRadioButton.IsChecked == true || DogRadioButton.IsChecked == true) && !String.IsNullOrEmpty(NameTextBox.Text) && !String.IsNullOrEmpty(AgeTextBox.Text) && !String.IsNullOrEmpty(TextBoxWeight.Text) && !String.IsNullOrEmpty(KindCB.Text))
            {
                bool resultAgeWeight = Validator.ValidAgeWeight(AgeTextBox.Text, TextBoxWeight.Text);
                bool resultName = Validator.ValidName(NameTextBox.Text);

                bool flagMale = true;
                bool flagType = true;
                bool flagPhoto = true;

                if (MaleRadioButton.IsChecked == true)
                {
                    flagMale = false;
                }
                else
                {
                    flagMale = true;
                }

                if (CatRadioButton.IsChecked == true)
                {
                    flagType = false;

                }
                else
                {
                    flagType = true;
                }

                if (PhotoCheckBox.IsChecked == true)
                {
                    flagPhoto = true;
                }
                else
                {
                    flagPhoto = false;
                }

                if (resultName == true && resultAgeWeight == true)
                {
                    repo.CreateNewPet(NameTextBox.Text, KindCB.SelectedValue.ToString(), TextBoxWeight.Text, AgeTextBox.Text, flagMale, flagType, flagPhoto);
                    MessageBox.Show("Питомец создан!");

                    Maindf.SendMail(user.userLOGIN, "ПРИВЕТ ПАСТРИЖЫСЯ", "Поздравляем! вОВА ЛОХ НЕ ОТЧИСЛЕН!. Спасибо и до новых встреч!");

                    MainWindow mw = new MainWindow();
                    mw.Show();
                    this.Close();
                }
                else
                {
                    ValidLabel.Content = "";
                    ValidLabel.Content = "Проверьте введенные данные";
                }
            }
            else
            {
                ValidLabel.Content = "";
                ValidLabel.Content = "Все поля должны быть заполнены";
            }


        }



        private void DogRadioButton_Checked(object sender, RoutedEventArgs e)
        {

            KindCB.ItemsSource = repo.GetKinds(2);
            KindCB.SelectedValuePath = "id";
            KindCB.DisplayMemberPath = "petKIND";

        }

        private void CatRadioButton_Checked(object sender, RoutedEventArgs e)
        {

            KindCB.ItemsSource = repo.GetKinds(1);
            KindCB.SelectedValuePath = "id";
            KindCB.DisplayMemberPath = "petKIND";

        }



        private void MaleRadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void FemaleRadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}
