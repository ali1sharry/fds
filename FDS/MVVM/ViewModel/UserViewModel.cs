using FDS.MVVM.Model;
using FDS.Core;
using FDS.MVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FDS.MVVM.ViewModel
{

    public class UserViewModel : INotifyPropertyChanged
    {



        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private string r;
        private User _user;

        public User User
        {
            get { return _user; }
            set { _user = value;
                OnPropertyChanged(nameof(User));
            }
        }

        private ObservableCollection<User> _firstuser;

        public ObservableCollection<User> FirstUser
        {
            get { return _firstuser; }
            set
            {
                _firstuser = value;
                OnPropertyChanged(nameof(FirstUser));
            }
        }
        private User _selecteduser;
        public User SelectedUser
        {
            get { return _selecteduser; }
            set
            {
                _selecteduser = value;
                OnPropertyChanged(nameof(SelectedUser));
            }

        }
        private User _newuser = new User();
        public User NewUser
        {
            get { return _newuser; }
            set
            {
                _newuser = value;
                OnPropertyChanged(nameof(NewUser));
            }
        }
        private FDSEntities userentities;
        public UserViewModel()
        {

            userentities = new FDSEntities();
            LoadUsers();
            DeleteCommand = new RelayCommand(Delete, (s) => true);
            UpdateCommand = new RelayCommand(Updateusers, (s) => true);
            UpdateUserCommand = new RelayCommand(Update, (s) => true);
            AddUserCommand = new RelayCommand(Adduser, (s) => true);
        }

        public void Adduser(object obj)
        {

            if (string.IsNullOrEmpty(NewUser.Address) || string.IsNullOrEmpty(NewUser.FullName)|| NewUser.Cellphone==0 || NewUser.Cellphone == null || string.IsNullOrEmpty(NewUser.Email) || NewUser.Role == null || string.IsNullOrEmpty(NewUser.Password))
            {

                new MessageBoxNew("Sorry! some field is missing...", MessageType.Error, MessageButtons.Ok).ShowDialog();

            }
            else
            {


                int i = 0;
                while (i < FirstUser.Count)
                {
                    if (FirstUser[i].Username == NewUser.Username)
                    {

                        obj = NewUser.Username;
                        i = 0;
                        break;
                    }
                    i++;


                }

                if (obj != null)
                {
                    new MessageBoxNew("Username already exist", MessageType.Error, MessageButtons.Ok).ShowDialog();

                }
                else
                {

                    var d = new MessageBoxNew("Do you want to Add New user", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
                    if (d != false)
                    {
                        try
                        {

                            int? r = Session.type;
                            NewUser.Createdby = Convert.ToInt32(r);
                            userentities.Users.Add(NewUser);
                            userentities.SaveChanges();
                            LoadUsers();
                            NewUser = new User();
                        }
                        catch (Exception ex)
                        {
                            new MessageBoxNew("Sorry!" + ex, MessageType.Error, MessageButtons.Ok).ShowDialog();
                        }
                        new MessageBoxNew("New user added successfuly", MessageType.Success, MessageButtons.Ok).ShowDialog();
                    }
                }
            }
        }

        private void Update(object obj)
        {
            if (string.IsNullOrEmpty(SelectedUser.Address) || string.IsNullOrEmpty(SelectedUser.FullName)|| SelectedUser.Cellphone ==0 || SelectedUser.Cellphone==null|| string.IsNullOrEmpty(SelectedUser.Email) || SelectedUser.Role == null || string.IsNullOrEmpty(SelectedUser.Password))
            {
                new MessageBoxNew("Sorry! some field is missing...", MessageType.Error, MessageButtons.Ok).ShowDialog();
            }
            else { 
            var d = new MessageBoxNew("Are you sure to update user?", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
            if (d == true)
            {
                try {
                    userentities.SaveChanges();
                    SelectedUser = new User();
                    LoadUsers();
                } catch (Exception ex)
                {
                    new MessageBoxNew("Sorry!" + ex, MessageType.Error, MessageButtons.Ok).ShowDialog();
                }
                new MessageBoxNew("User updated successfully", MessageType.Success, MessageButtons.Ok).ShowDialog();
            }
        }
    }
        private void Updateusers(object obj)
        {
            new MessageBoxNew("Please Click on Update Tab for Update", MessageType.Info, MessageButtons.Ok).ShowDialog();
            SelectedUser = obj as User;
            
        
            }
     

        private void Delete(object obj)
        {
            var d = new MessageBoxNew("Do you want to delete user?", MessageType.Warning, MessageButtons.YesNo).ShowDialog();
            if (d == true)
            {
                var usr = obj as User;
                try
                {
                    userentities.Users.Remove(usr);
                    userentities.SaveChanges();
                    LoadUsers();
                }
                catch (Exception ex)
                {
                    new MessageBoxNew("Sorry! " + ex, MessageType.Error, MessageButtons.Ok).ShowDialog();
                }
                new MessageBoxNew("User deleted successfully", MessageType.Success, MessageButtons.Ok).ShowDialog();
            }
        }

       
        private void LoadUsers()
        {
             
            FirstUser = new ObservableCollection<User>(userentities.Users);
            int i = 0;
            while (i < FirstUser.Count)
            {
                if(FirstUser[i].Role == 0)
                {
                    r = "Administrator";

                }
                else
                {
                    r = "Employee";
                }
                i++;
            }
        }
        public ICommand DeleteCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand UpdateUserCommand { get; set;}
        public ICommand AddUserCommand { get; set; }
    }

    
}
