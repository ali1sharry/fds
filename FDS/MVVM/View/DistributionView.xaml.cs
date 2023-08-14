using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace FDS.MVVM.View
{
    /// <summary>
    /// Interaction logic for DistributionView.xaml
    /// </summary>
    public partial class DistributionView : UserControl
    {
        public DistributionView()
        {
            InitializeComponent();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            danamecop01.Visibility = Visibility.Collapsed;
            danamecop02.Visibility = Visibility.Visible;
            donoridcom1.Visibility = Visibility.Collapsed;
            donoridcom2.Visibility = Visibility.Visible;
            daqty01.Visibility = Visibility.Collapsed;
            daqty02.Visibility = Visibility.Visible;
            datepick01.Visibility = Visibility.Collapsed;
            datepick02.Visibility = Visibility.Visible;
            donerbtn01.Visibility = Visibility.Collapsed;
            donerbtn02.Visibility = Visibility.Visible;
            fsidcom1.Visibility = Visibility.Collapsed;
            fsidcom2.Visibility = Visibility.Visible;
        }

        private void daqty01_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
