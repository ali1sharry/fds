using FDS.MVVM.Model;
using FDS.MVVM.ViewModel;
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
    /// Interaction logic for UserView.xaml
    /// </summary>
    public partial class UserView : UserControl
    {
        public User _User;

        public UserView()
        {
            InitializeComponent();
            DataContext = new UserViewModel();

        }

        private void FN01_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]+");
            e.Handled = regex.IsMatch(e.Text);

        }

        private void CP01_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);



        }


        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(email))
                return false;

            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string email = E01.Text;
            bool isValid = IsValidEmail(email);
            if (isValid != true)
            {
                new MessageBoxNew("Incorrect Email", MessageType.Error, MessageButtons.Ok).ShowDialog();
                btnsb01.SetBinding(Button.CommandProperty, new Binding("ErrorBind"));
                E01.Focus();
            }
            else
            {
                btnsb01.SetBinding(Button.CommandProperty, new Binding("AddUserCommand"));
            }
        }

        private void UpdateUser_Click(object sender, RoutedEventArgs e)
        {
            string email = E02.Text;
            bool isValid = IsValidEmail(email);
            if(isValid!=true)
            {
                new MessageBoxNew("Incorrect Email", MessageType.Error, MessageButtons.Ok).ShowDialog();
                UpdateUser.SetBinding(Button.CommandProperty, new Binding("ErrorBind"));
                E02.Focus();
            }
            else
            {
                UpdateUser.SetBinding(Button.CommandProperty, new Binding("UpdateUserCommand"));
            }

        }
    }
}

