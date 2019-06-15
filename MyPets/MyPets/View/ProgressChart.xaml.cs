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
using System.Windows.Controls.DataVisualization.Charting;
using MyPets.ViewModels;
using MyPets.Models;

namespace MyPets
{
    /// <summary>
    /// Логика взаимодействия для Progress.xaml
    /// </summary>
    public partial class ProgressChart : Window
    {
        List<PET> pets = new List<PET>();
        List<PETSPROGRESS> progress = new List<PETSPROGRESS>();
        Repository repo;

        public ProgressChart()
        {
            InitializeComponent();
            repo = new Repository();
            pets = repo.LoadUsersPetsInto(Repository.CurrUser.userID).ToList();
            PetsComboBox.ItemsSource = pets.Select(u => u.petNAME);

            string path = "pack://application:,,,/Resources/Lang/Lang" +
                           Repository.lang +
                            ".xaml";
            this.Resources = new ResourceDictionary()
            {
                Source = new Uri(path)
            };
        }


        private void YourPetsCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            pets = repo.PetInfo(PetsComboBox.SelectedItem.ToString()).ToList();
            PET pet = pets[0];
            if (pets != null)
            {
                LAbelMaxVal.Content = "";
                LAbelMinVal.Content = "";
                
                progress = pet.PETSPROGRESSes.ToList();

                KeyValuePair<DateTime, double>[] singleKeyVal = new KeyValuePair<DateTime, double>[progress.Count];
                for (int i = 0; i < progress.Count; i++)
                {
                    singleKeyVal[i] = new KeyValuePair<DateTime, double>(progress[i].DATEcurr.Value, progress[i].WEIGHTcur.Value);
                }
                LineSeries series = new LineSeries();
                series.Title = PetsComboBox.SelectedItem.ToString();
                series.IndependentValueBinding = new Binding("Key");
                series.DependentValueBinding = new Binding("Value");
                series.ItemsSource = singleKeyVal;
                mcChart.Series.Add(series);

                mcChart.Visibility = Visibility.Visible;

                
                LAbelMaxVal.Content = progress.Max(max => max.WEIGHTcur);
                LAbelMinVal.Content = progress.Min(max => max.WEIGHTcur);
            }
        }
    }

}
