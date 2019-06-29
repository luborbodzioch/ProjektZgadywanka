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

namespace GraZaDuzoZaMaloLB
{
    /// <summary>
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {

        int los = 0;
        int min = 0;
        int max = 0;
        int zgad = 0;
        Random random = new Random();


        public Window2()
        {

            InitializeComponent();
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (minWys.Text == "" || maxWys.Text == "")
            {
                MessageBox.Show("Uzupelnij pola min i max");
            }
            else
            {
                min = int.Parse(minWys.Text);
                max = int.Parse(maxWys.Text);

                los = random.Next(min, max + 1);
                zgadWys.Text = los.ToString();
            }
        }


        //za malo
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            min = los;
            los = random.Next(los+1, max + 1);
            zgadWys.Text = los.ToString();

        }

        //za duzo
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            max = los;
            los = random.Next(min, los);
            zgadWys.Text = los.ToString();
        }

        //dobrze
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hurrra");
            
        }
    }


}
