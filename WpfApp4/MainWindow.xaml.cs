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

namespace WpfApp4
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
            MessageBox.Show("кнопка нажата");
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if (check.IsChecked == true)
                MessageBox.Show("Ischecked == true");
        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Состояние кнопки: " + (sender as System.Windows.Controls.Primitives.ToggleButton).IsChecked);
        }

        private void R1_Checked(object sender, RoutedEventArgs e)
        {

            MessageBox.Show(R1.Content.ToString());
        }

        private void R2_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(R2.Content.ToString());
        }

        private void R3_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(R3.Content.ToString());
        }
    }
}
