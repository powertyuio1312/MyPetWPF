using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
using MyPets.Models;
using MyPets.View;
using MyPets.ViewModels;

namespace MyPets
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<PET> pets = new List<PET>();
        DContext db;
        Repository repo;
        USER user;

        public MainWindow()
        {
            InitializeComponent();
            user = Repository.CurrUser;
            repo = new Repository();
            db = new DContext();
            pets = repo.LoadUsersPetsInto(Repository.CurrUser.userID).ToList();
            YourPetsCB.ItemsSource = pets.Select(u => u.petNAME);

            string path = "pack://application:,,,/Resources/Lang/Lang" +
                           Repository.lang +
                            ".xaml";
            this.Resources = new ResourceDictionary()
            {
                Source = new Uri(path)
            };
        }
        
        private void Button_Click_MAP(object sender, RoutedEventArgs e)
        {
            Map map = new Map();
            map.Show();
        }

       

        private void YourPetsCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (YourPetsCB.SelectedItem != null)
            {
                StackAcc.Visibility = Visibility.Visible;


                pets = repo.PetInfo(YourPetsCB.SelectedItem.ToString()).ToList();
                int kId = int.Parse(pets.Last().petKIND.ToString());


                acc.PetImg.Source = repo.ConvertByteArrayToImage(pets.Last().PHOTO);
                acc.Namepet.Text = pets.Last().petNAME;
                acc.Agepet.Text = "Возраст: " + pets.Last().petAGE.ToString() + " лет";
                acc.Kindpet.Text = "Порода: " + repo.GetKind(kId).petKIND;
                acc.Weightpet.Text = "Вес: " + pets.Last().petWEIGHT.ToString() + " кг";
            }
            else
                StackAcc.Visibility = Visibility.Hidden;
        }

        private void Button_Click_CreatePet(object sender, RoutedEventArgs e)
        {
            PetCreate c = new PetCreate(user);
            
            c.Show();
            this.Close();
        }


        private void Button_ClickPROGRESS(object sender, RoutedEventArgs e)
        {
            ProgressChart p = new ProgressChart();
            p.Show();

        }

        private void Button_ClickHealthNote(object sender, RoutedEventArgs e)
        {
            ProgressBlank blank = new ProgressBlank();
            blank.Show();
        }

        

        private void Button_ClickCARE(object sender, RoutedEventArgs e)
        {
            CareWin care = new CareWin();
            care.Show();
            this.Close();
        }
        

        private void Button_ClickDEL(object sender, RoutedEventArgs e)
        {
            if (YourPetsCB.SelectedItem != null)
            {
                repo.DeletePet(YourPetsCB.SelectedItem.ToString());
                YourPetsCB.SelectedItem = null;
            }
                        
        }

        
    }
}
