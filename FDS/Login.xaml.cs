using FDS.Core;
using FDS.MVVM.Model;
using FDS.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace FDS
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login: INotifyPropertyChanged
    {
        FDSEntities con;
        public Login()
        {
            InitializeComponent();
            con = new FDSEntities();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private ObservableCollection< User> _User;

        public ObservableCollection< User> Usr
        {
            get { return _User; }
            set { _User = value;
                OnPropertyChanged(nameof(Usr));

            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            var usr = username01.Text;
            var pwd = pwd01.Password;
            int type;

            
                if (username01.Text.Length == 0)
                {
                    username01.Focus();
                }
                else if(pwd01.Password.Length == 0)
                    {
                    pwd01.Focus();
                }
            else { 
            using (FDSEntities con = new FDSEntities())
            {
                try
                {

                    Usr = new ObservableCollection<User>(con.Users.Where(User => User.Username == usr && User.Password == pwd));

                    if (Usr[0].Username == usr && Usr[0].Password == pwd)
                    {


                        Session.Role(Usr);
                        MainWindow mainwin = new MainWindow();
                        Close();
                        MainViewModel home = new MainViewModel();
                        mainwin.Show();


                    }
                    else
                    {
                        new MessageBoxNew("Sorry... Incorrect username or password", MessageType.Error, MessageButtons.Ok).ShowDialog();

                    }

                }
                catch (Exception ex) { new MessageBoxNew("Incorrect username or password" , MessageType.Error, MessageButtons.Ok).ShowDialog(); }
            }
            }
        }
        private ICommand showLongCommand;
        public ICommand ShowLoginCommand
        {
            get { if (this.showLongCommand == null) { this.showLongCommand = new RelayCommand(i => this.CheckLogin(), null); }
                return this.showLongCommand;
            }

        }

        private void CheckLogin()
        {
            //var user = con.Users.Where(i => _User.Username == this.username01.Text).FirstOrDefault();
            //if (user != null)
            //{
            //    if (user.Username == username01.Text && user.Password == pwd01.Password)
            //    {
            //        MainWindow mainwin = new MainWindow();
            //        Close();

            //        mainwin.Show();
            //    }
            //}
        }

        private void PackIconMaterial_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Close();

        }
    }
}
