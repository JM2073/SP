using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Week2Ex2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private double TotalPaid = 0;
        private double LeftToPay = 0;
        private void btnConfrim_Click(object sender, RoutedEventArgs e)
        {
            TotalPaid = 0;
            lblTotalPaid.Content = TotalPaid;

            //works out how long they will be staying for
            int durOfStay = int.Parse(TxtDurationOfStay.Text);
            DateTime stayUntill = DateTime.Now.AddHours(durOfStay);

            lblCurrentTime.Content = DateTime.Now.ToString();
            lblStayDuration.Content = stayUntill.ToString();

            //works out the cost of the stay
            switch (durOfStay)
            {
                case 1:
                    lblCostToStay.Content = "1.50";
                    LeftToPay = 1.50;
                    break;
                case 2:
                    lblCostToStay.Content = "2.50";
                    LeftToPay = 2.50;
                    break;
                case 4:
                    lblCostToStay.Content = "4.00";
                    LeftToPay = 4.00;
                    break;
                default:
                    break;
            }

            lblLeftToPay.Content = LeftToPay;

        }

        private void btnTwoPounds_Click(object sender, RoutedEventArgs e)
        {
            TotalPaid += 2.00;
            LeftToPay -= 2.00;

            lblTotalPaid.Content = TotalPaid;
            lblLeftToPay.Content = LeftToPay;
        
        }

        private void btnOnePound_Click(object sender, RoutedEventArgs e)
        {
            TotalPaid += 1.00;
            LeftToPay -= 1.00;

            lblTotalPaid.Content = TotalPaid;
            lblLeftToPay.Content = LeftToPay;
        }

        private void btnFiftyPence_Click(object sender, RoutedEventArgs e)
        {
            TotalPaid += 0.50;
            LeftToPay -= 0.50;

            lblTotalPaid.Content = TotalPaid;
            lblLeftToPay.Content = LeftToPay;
        }

        private void TimeSetter(object sender, EventArgs e)
        {
            lblCurrentTime.Content = DateTime.Now.ToString();
        }
    }
}
