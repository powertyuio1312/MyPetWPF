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
using MyPets.View;
using MyPets.Utils;
using MyPets.ViewModels;



namespace MyPets.View
{
    /// <summary>
    /// Логика взаимодействия для CareWin.xaml
    /// </summary>
    public partial class CareWin : Window
    {
        
        Repository repo;
        public CareWin()
        {
            InitializeComponent();
            repo = new Repository();
            RunCare.Text = repo.GetCare().First();
            RunIlls.Text = repo.GetIlls().First();
            RunVacina.Text = repo.GetVacina().First();

            string path = "pack://application:,,,/Resources/Lang/Lang" +
                           Repository.lang +
                            ".xaml";
            this.Resources = new ResourceDictionary()
            {
                Source = new Uri(path)
            };
        }

        private void Button_Click_MAIN(object sender, RoutedEventArgs e)
        {
            MainWindow m = new MainWindow();
            m.Show();
            this.Close();
        }
    }
}
