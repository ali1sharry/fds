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
    /// Interaction logic for DonationView.xaml
    /// </summary>
    public partial class DonationView : UserControl
    {
        public DonationView()
        {
            InitializeComponent();
        }

     

        private void donoridcom1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            link01.Visibility = Visibility.Visible;

        }

        private void docnicd01_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

        }

        private void donoridcom1_Selected(object sender, RoutedEventArgs e)
        {
            danamecop01.Visibility = Visibility.Collapsed;
            danamecop02.Visibility = Visibility.Visible;
            donoridcom1.Visibility = Visibility.Collapsed;
            donoridcom2.Visibility = Visibility.Visible;
            daqty01.Visibility = Visibility.Collapsed;
            daqty02.Visibility = Visibility.Visible;
            donerbtn01.Visibility = Visibility.Collapsed;
            donerbtn02.Visibility = Visibility.Visible;
            link01.Visibility = Visibility.Visible;
            fsidcom01.Visibility = Visibility.Collapsed;
            fsidcom2.Visibility = Visibility.Visible;
        }

        private void daqty01_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void donerbtn01_Click(object sender, RoutedEventArgs e)
        {
            if(danamecop01.SelectedItem == null || donoridcom1.SelectedItem == null || string.IsNullOrEmpty(daqty01.Text)|| fsidcom01.SelectedItem == null)
            {
                new MessageBoxNew("Sorry! Some field is missing...", MessageType.Error, MessageButtons.Ok).ShowDialog();
                donerbtn01.SetBinding(Button.CommandProperty, new Binding("ErrorBind"));
            }
            else
            {
                donerbtn01.SetBinding(Button.CommandProperty, new Binding("AddDonCommand"));
            }
        }

        private void donerbtn02_Click(object sender, RoutedEventArgs e)
        {
            if (danamecop02.SelectedItem == null || donoridcom2.SelectedItem == null || string.IsNullOrEmpty(daqty02.Text) || fsidcom2.SelectedItem == null)
            {
                new MessageBoxNew("Sorry! Some field is missing...", MessageType.Error, MessageButtons.Ok).ShowDialog();
                donerbtn02.SetBinding(Button.CommandProperty, new Binding("ErrorBind"));
            }
            else
            {
                donerbtn02.SetBinding(Button.CommandProperty, new Binding("UpdateDonCommand"));
            }
        }
    }
}
