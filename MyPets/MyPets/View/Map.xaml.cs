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

namespace MyPets
{
    /// <summary>
    /// Логика взаимодействия для Map.xaml
    /// </summary>
    public partial class Map : Window
    {
        public Map()
        {
            InitializeComponent();
            Wb.Navigate("https://www.google.com/maps/dir//53.8913847,27.5592104/@53.8908151,27.5572328,17.79z/data=!4m2!4m1!3e0");
        }

        public Map(string width, string height)
        {
            InitializeComponent();
            string a = "https://www.google.com/maps/dir//" + width + "," + height + "/@" + width + "," + height + "z/data=!4m2!4m1!3e0";
            Wb.Navigate(a);
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
