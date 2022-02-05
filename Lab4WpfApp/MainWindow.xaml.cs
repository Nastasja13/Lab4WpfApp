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

namespace Lab4WpfApp
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble = rateDollar * sumDollar;
            resSum.Text = resDouble.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(rate2.Text);
            double sumEuro = Convert.ToDouble(sum2.Text);
            double resEuro = rateEuro * sumEuro;
            resSum2.Text = resEuro.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateHryvnia = Convert.ToDouble(rate3.Text);
            double sumHryvnia = Convert.ToDouble(sum3.Text);
            double resHryvnia = rateHryvnia * sumHryvnia;
            resSum3.Text = resHryvnia.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDram = Convert.ToDouble(rate4.Text);
            double sumDram = Convert.ToDouble(sum4.Text);
            double resDram = rateDram * sumDram;
            resSum4.Text = resDram.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            //дюймы
            double xInch = Convert.ToDouble(x.Text);
            double resConvert = xInch * 0.0254;
            z.Text = resConvert.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            //футы
            double xFoot = Convert.ToDouble(x2.Text);
            double resConvert = xFoot * 0.3048;
            z2.Text = resConvert.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            //мили
            double xMiles = Convert.ToDouble(x3.Text);
            double resConvert = xMiles * 1609.34;
            z3.Text = resConvert.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            //версты
            double xVerst = Convert.ToDouble(x4.Text);
            double resConvert = xVerst * 1066.8;
            z4.Text = resConvert.ToString();
        }
    }
}
