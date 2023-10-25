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

namespace Mathematical_vectors
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
            try
            {
                double XVA = double.Parse(this.XVA.Text);
                double YVA = double.Parse(this.YVA.Text);
                double ZVA = double.Parse(this.ZVA.Text);
                double XVB = double.Parse(this.XVB.Text);
                double YVB = double.Parse(this.YVB.Text);
                double ZVB = double.Parse(this.ZVB.Text);
                var VMF = new VectorMathFunc(XVA, YVA, ZVA, XVB, YVB, ZVB);
                addition.Content = "("+VMF.Plus()[0] + ";" + VMF.Plus()[1] + ";" + VMF.Plus()[2] +")";
                subtraction.Content = "(" + VMF.Minus()[0] + ";" + VMF.Minus()[1] + ";" + VMF.Minus()[2] + ")";
                Scalar.Content = Math.Round(VMF.Scalar(),3);
                LengthA.Content = Math.Round(VMF.Length()[0],3);
                LengthB.Content = Math.Round(VMF.Length()[1],3);
                LengthAB.Content = Math.Round(VMF.Length()[2],3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
