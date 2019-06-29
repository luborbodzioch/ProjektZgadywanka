
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

namespace GraZaDuzoZaMaloLB
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {

        int los = 0;
        int min = 0;
        int max = 0;
        int zgad = 0;


        public Window1()
        {

            InitializeComponent();
        }

        private void Aply_Click(object sender, RoutedEventArgs e)
        {
            if (minWys.Text == "" || maxWys.Text == "")
            {
                MessageBox.Show("Uzupelnij pola min i max");
            }
            else
            {
                min = int.Parse(minWys.Text);
                max = int.Parse(maxWys.Text);
                Random random = new Random();
                los = random.Next(min, max + 1);

                losowa.Text = los.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (zgadWys.Text == "")
            {
                MessageBox.Show("Uzupelnij pole z twoim typem");
            }
            else
            {

                zgad = int.Parse(zgadWys.Text);
                if (zgad > los)
                {
                    wynikWys.Text = "za duzo";
                }
                else if (zgad < los)
                {
                    wynikWys.Text = "za malo";
                }
                else if (zgad == los)
                {
                    wynikWys.Text = "Dobrze";
                }
            }
        }
    }


}
