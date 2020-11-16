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

namespace LastIf
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
                double x = double.Parse(X.Text);
                double y = double.Parse(Y.Text);
                double b;
                if (x / y > 0)
                {
                    b = Math.Log10(Math.Sinh(x)) + Math.Pow(Math.Sinh(x) * Math.Sinh(x) + y, 3);
                }
                else if (x / y < 0)
                {
                    b = Math.Log10(Math.Abs(Math.Sinh(x) / y)) + Math.Pow(Math.Sinh(x) + y, 3);
                }
                else if (x == 0)
                {
                    b = Math.Pow(Math.Sinh(x) * Math.Sinh(x) + y, 3);
                }
                else if (y == 0)
                {
                    b = 0;
                }
                Result.Text = String.Format("b={0:F2} x={1} y={2}", b, x, y);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}