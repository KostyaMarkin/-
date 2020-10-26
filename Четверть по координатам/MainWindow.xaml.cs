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

namespace Четверть_по_координатам
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void Check_Enabled()
        {
            if (txtKoefA.Text.Length <= 0 || txtKoefB.Text.Length <= 0 ||
                txtKoefC.Text.Length <= 0)
            {
                btnCalculate.IsEnabled = false;
            }
            else
            {
                btnCalculate.IsEnabled = true;
            }
        }

            private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            double koefA = Convert.ToDouble(txtKoefA.Text);
            double koefB = Convert.ToDouble(txtKoefB.Text);
            double koefC = Convert.ToDouble(txtKoefC.Text);
            double Diskriminant = Math.Pow(koefB, 2) - 4 * koefA * koefC;
            if (Diskriminant < 0) MessageBox.Show( "корней уравнения нет", "Ошибка", MessageBoxButton.OK);
            else if (Diskriminant == 0)
            {
                double korenX1 = (-1 * (Math.Sqrt(Diskriminant)) + koefB) / (koefA * 2);
                lbnItog.Content = (" x1=" + String.Format("{0:0.###}", korenX1));
            }
            else
            {
                double korenX1 = ((Math.Sqrt(Diskriminant)) - koefB) / (koefA * 2);
                double korenX2 = (-(Math.Sqrt(Diskriminant)) - koefB) / (koefA * 2);
                lbnItog.Content = (" x1="+ String.Format("{0:0.###}",korenX1)+
                    " x2=" + String.Format("{0:0.###}", korenX2));
            }
        }

        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtKoefC_TextChanged(object sender, TextChangedEventArgs e)
        {
            Check_Enabled();
        }

        private void txtKoefB_TextChanged(object sender, TextChangedEventArgs e)
        {
            Check_Enabled();
        }

        private void txtKoefA_TextChanged(object sender, TextChangedEventArgs e)
        {
            Check_Enabled();
        }
    }
}
