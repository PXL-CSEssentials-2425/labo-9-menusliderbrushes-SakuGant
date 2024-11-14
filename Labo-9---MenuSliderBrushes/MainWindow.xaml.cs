using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Labo_9___MenuSliderBrushes
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

        private void closeMenu_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are You sure?", "Aflsuiten",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question) == MessageBoxResult.Yes)
            
            {
                this.Close();
            }

        }

        private void eersteSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            eersteGetaltextBox.Text = ((int)eersteSlider.Value).ToString();
        }

        private void tweedeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            tweedegetaltextBox.Text = ((int)tweedeSlider.Value).ToString();
        }

    }
}