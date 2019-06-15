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
using MyPets.Models;
using MyPets.ViewModels;

namespace MyPets
{
    /// <summary>
    /// Логика взаимодействия для ProgressBlank.xaml
    /// </summary>
    public partial class ProgressBlank : Window
    {
        List<PET> pets = new List<PET>();
        Repository repo;

        public ProgressBlank()
        {
            InitializeComponent();

            repo = new Repository();
            pets = repo.LoadUsersPetsInto(Repository.CurrUser.userID).ToList();
            CurrentPetCB.ItemsSource = pets.Select(u => u.petNAME);

            string path = "pack://application:,,,/Resources/Lang/Lang" +
                           Repository.lang +
                            ".xaml";
            this.Resources = new ResourceDictionary()
            {
                Source = new Uri(path)
            };
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_Save(object sender, RoutedEventArgs e)
        {
            bool weightValid = Validator.ValidAgeWeight(WeightTB.Text);
            if(weightValid)
            {
                PETSPROGRESS progress = new PETSPROGRESS();
                progress.ACTIVITY = ActivityCB.Text;
                progress.APET = ApetCB.Text;
                progress.WEIGHTcur = Convert.ToDouble(WeightTB.Text);
                progress.HEAR = HearCB.Text;
                progress.DATEcurr = DatePic.SelectedDate.Value;

                //var p = db.PETS.FirstOrDefault(v => v.petNAME.Equals(CurrentPetCB.Text));
                var p = repo.PetInfo(CurrentPetCB.Text).FirstOrDefault();
                if (p != null)
                {
                    progress.petID = p.petID;
                }

                repo.AddProgress(progress);

                this.Close();
            }
            else
            {
                ValidLabel.Content = "Вес указывается в формате х,х .";
            }
        }
    }
}
