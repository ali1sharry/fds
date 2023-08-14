using FDS.Core;
using FDS.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FDS.MVVM.ViewModel
{
    class DonorViewModel : INotifyPropertyChanged
    {
        private  FDSEntities userentities;
        public event PropertyChangedEventHandler PropertyChanged;
        private Donor _adddonor = new Donor(); 
        public Donor Adddonor
        {
            get { return _adddonor; }
            set
            {
                _adddonor = value;
                OnPropertyChanged(nameof(Adddonor));
            }
        }
        private Donor _selectdon = new Donor();
        public Donor Selectdon
        {
            get { return _selectdon; }
            set
            {
                _selectdon = value;
                OnPropertyChanged(nameof(Selectdon));
            }
        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public DonorViewModel()
        {
            
            userentities = new FDSEntities();
            LoadDon();
            AddDonCommand = new RelayCommand(AddDon, (s) => true);
            DeleteCommand = new RelayCommand(Delete, (s) => true);
            UpdateCommand = new RelayCommand(Update, (s) => true);
            UpdateDonCommand = new RelayCommand(UpdateBen, (s) => true);
        }

        private void UpdateBen(object obj)
        {
            var d = new MessageBoxNew("Are you sure to update donor?", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
            if (d == true)
            {
                try
                {
                    userentities.SaveChanges();
                    Selectdon = new Donor();
                    LoadDon();
                }
                catch (Exception ex)
                {
                    new MessageBoxNew("Sorry!" + ex, MessageType.Error, MessageButtons.Ok).ShowDialog();
                }
                new MessageBoxNew("Donor updated successfully", MessageType.Success, MessageButtons.Ok).ShowDialog();
            }
        }

        private void Update(object obj)
        {
            new MessageBoxNew("Now you can update...", MessageType.Info, MessageButtons.Ok).ShowDialog();
            Selectdon = obj as Donor;
        }

        private void Delete(object obj)
        {
            var d = new MessageBoxNew("Do you want to delete Donor?", MessageType.Warning, MessageButtons.YesNo).ShowDialog();
            if (d == true)
            {
                try {
                    var don = obj as Donor;
                    userentities.Donors.Remove(don);
                    userentities.SaveChanges();
                    LoadDon();
                }
                catch (Exception ex)
                {
                    new MessageBoxNew("Sorry! " + ex, MessageType.Error, MessageButtons.Ok).ShowDialog();
                }
                new MessageBoxNew("Donor deleted successfully", MessageType.Success, MessageButtons.Ok).ShowDialog();
            }
        }

        private ObservableCollection<Donor> _donorrload;

        public ObservableCollection<Donor> DonorrLoad
        {
            get { return _donorrload; }
            set
            {
                _donorrload = value;
                OnPropertyChanged(nameof(DonorrLoad));
            }
        }
        private void LoadDon()
        {
            DonorrLoad = new ObservableCollection<Donor>(userentities.Donors);
            
        }

        private void AddDon(object obj)
           {
            var d = new MessageBoxNew("Do you want to Add New donor", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
            if (d != false)
            {
                try {
                    Adddonor.CreatedBy = 1;
                    
                    userentities.Donors.Add(Adddonor);
                    userentities.SaveChanges();
                    Adddonor = new Donor();
                    LoadDon();
                }
                catch (Exception ex) { new MessageBoxNew("Sorry!" + ex, MessageType.Success, MessageButtons.Ok).ShowDialog(); }
                new MessageBoxNew("New donor added successfuly", MessageType.Success, MessageButtons.Ok).ShowDialog();
            }
        }

        public ICommand AddDonCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand UpdateDonCommand { get; set; }
    }
}
