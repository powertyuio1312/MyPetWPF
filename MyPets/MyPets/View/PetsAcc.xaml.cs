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
using MyPets.ViewModels;
using MyPets.Models;

namespace MyPets
{
    /// <summary>
    /// Логика взаимодействия для PetsAcc.xaml
    /// </summary>
    public partial class PetsAcc : UserControl
    {
        List<PET> pets = new List<PET>();
        Repository repo;
        public PetsAcc()
        {
            InitializeComponent();
            repo = new Repository();
            pets = repo.LoadUsersPetsInto(Repository.CurrUser.userID).ToList();
            

        }

        public ImageSource petImg
        {
            get { return PetImg.Source; }
            set { PetImg.Source = value; }
        }
        
    }
}
