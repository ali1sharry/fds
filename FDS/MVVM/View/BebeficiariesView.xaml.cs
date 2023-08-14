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
    /// Interaction logic for BebeficiariesView.xaml
    /// </summary>
    public partial class BebeficiariesView : UserControl
    {
        public BebeficiariesView()
        {
           

          InitializeComponent();
        }
        public void Changes()
        {
            
            
            
        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            benreg.Visibility = Visibility.Collapsed;
            benupdate.Visibility = Visibility.Visible;
            FN01.Visibility = Visibility.Collapsed;
            UPFN01.Visibility = Visibility.Visible;
            CNIC01.Visibility = Visibility.Collapsed;
            UPCNIC01.Visibility = Visibility.Visible;
            NO01.Visibility = Visibility.Collapsed;
            UPN01.Visibility = Visibility.Visible;
            TPCOM01.Visibility = Visibility.Collapsed;
            UPTPCOM01.Visibility = Visibility.Visible;
            benad01.Visibility = Visibility.Collapsed;
            upbenad01.Visibility = Visibility.Visible;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void CNIC01_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void FN01_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void benreg_Click(object sender, RoutedEventArgs e)
        {
            long cnic = Convert.ToInt64(CNIC01.Text);
            long no = Convert.ToInt64( NO01.Text);
            if (string.IsNullOrEmpty(FN01.Text) || string.IsNullOrEmpty(benad01.Text) || TPCOM01.SelectedItem == null || cnic == 0 || no == 0)
            {
               
                new MessageBoxNew("Sorry! Some field is missing...", MessageType.Error, MessageButtons.Ok).ShowDialog();
                benreg.SetBinding(Button.CommandProperty, new Binding("ErrorBind"));

            }
            else
            {

                benreg.SetBinding(Button.CommandProperty, new Binding("AddBenCommand"));
            }

        }

        private void benupdate_Click(object sender, RoutedEventArgs e)
        {
            long cnic =Convert.ToInt32( UPCNIC01.Text);
            long no = Convert.ToInt32(UPN01.Text);
            if (string.IsNullOrEmpty(UPFN01.Text) ||string.IsNullOrEmpty(upbenad01.Text)|| UPTPCOM01.Text == null || cnic == 0 || no == 0)
            {
                new MessageBoxNew("Sorry! Some field is missing...", MessageType.Error, MessageButtons.Ok).ShowDialog();
                benreg.SetBinding(Button.CommandProperty, new Binding("ErrorBind"));
            }
            else
            {
                benreg.SetBinding(Button.CommandProperty, new Binding("UpdateBenCommand"));
            }
        }
    }
}
