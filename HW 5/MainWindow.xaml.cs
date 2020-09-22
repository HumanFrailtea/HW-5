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

namespace HW_5
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


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int x, y;
            double n, m;
            String Mortgage = one.Text;
            String Balance = two.Text;
            x = Int32.Parse(Mortgage);
            y = Int32.Parse(Balance);

            n = ((1200 * x) / (7.49 + 24));
            m = n / 50;
            double interest = x - m;
            MessageBox.Show("Your interest is : " + interest + "your principal is: " + m);
        }
    }
}

