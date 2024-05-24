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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для balans.xaml
    /// </summary>
    public partial class balans : Window
    {
        public balans()
        {
            InitializeComponent();
            Loaded += Balans_Loaded;
        }

        private void Balans_Loaded(object sender, RoutedEventArgs e)
        {
            BalanceTextBox.Focus();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
