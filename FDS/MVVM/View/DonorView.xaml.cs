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
    /// Interaction logic for DonorView.xaml
    /// </summary>
    public partial class DonorView : UserControl
    {
        public DonorView()
        {
            InitializeComponent();
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            dname01.Visibility = Visibility.Collapsed;
            dname02.Visibility = Visibility.Visible;
            dad01.Visibility = Visibility.Collapsed;
            dad02.Visibility = Visibility.Visible;
            dno01.Visibility = Visibility.Collapsed;
            dno02.Visibility = Visibility.Visible;
            dcnic01.Visibility = Visibility.Collapsed;
            dcnic02.Visibility = Visibility.Visible;
            donerbtn01.Visibility = Visibility.Collapsed;
            donerbtn02.Visibility = Visibility.Visible;
        }

        private void dname01_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void dno01_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void donerbtn01_Click(object sender, RoutedEventArgs e)
        {
            string name = dname01.Text;
            string address = dad01.Text;
            
            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(dno01.Text) || string.IsNullOrEmpty( dcnic01.Text) || dno01.Text== "0" || dcnic01.Text =="0" )
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
            string name = dname02.Text;
            string address = dad02.Text;

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(address) || string.IsNullOrEmpty(dno02.Text) || string.IsNullOrEmpty(dcnic02.Text) || dno02.Text == "0" || dcnic02.Text == "0")
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
