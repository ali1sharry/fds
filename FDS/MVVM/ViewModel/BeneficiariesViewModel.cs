using FDS.Core;
using FDS.MVVM.Model;
using FDS.MVVM.View;
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
    class BeneficiariesViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private Beneficiary _benuser = new Beneficiary();
        public Beneficiary BenUser
        {
            get { return _benuser; }
            set
            {
                _benuser = value;
                OnPropertyChanged(nameof(BenUser));
            }
        }
        private Beneficiary _selectedben;
        public Beneficiary SelectedBen
        {
            get { return _selectedben; }
            set
            {
                _selectedben = value;
                OnPropertyChanged(nameof(SelectedBen));
            }

        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private FDSEntities userentities;
        public BeneficiariesViewModel()
        {
            userentities = new FDSEntities();
            LoadBen();
            AddBenCommand = new RelayCommand(Addben, (s) => true);
            DeleteCommand = new RelayCommand(Delete, (s) => true);
            UpdateCommand = new RelayCommand(Update, (s) => true);
            UpdateBenCommand = new RelayCommand(UpdateBen, (s) => true);

        }

        private void UpdateBen(object obj)
        {
            var d = new MessageBoxNew("Are you sure to update beneficiary?", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
            if (d == true)
            {
                try
                {
                    SelectedBen.BenType = SelectedBen.BenType.Substring(37);
                    userentities.SaveChanges();
                    SelectedBen = new Beneficiary();
                    LoadBen();
                }
                catch (Exception ex)
                {
                    new MessageBoxNew("Sorry!" + ex.Message, MessageType.Error, MessageButtons.Ok).ShowDialog();
                }
                new MessageBoxNew("Beneficiary updated successfully", MessageType.Success, MessageButtons.Ok).ShowDialog();
            }
             
        }

        private void Update(object obj)
        {
            new MessageBoxNew("Now you can update...", MessageType.Info, MessageButtons.Ok).ShowDialog();
            SelectedBen = obj as Beneficiary;
            
        }

        private void Delete(object obj)
        {
            var d = new MessageBoxNew("Do you want to delete beneficiary?", MessageType.Warning, MessageButtons.YesNo).ShowDialog();
            if (d == true)
            {
                try {
                    var ben = obj as Beneficiary;
                    userentities.Beneficiaries.Remove(ben);
                    userentities.SaveChanges();
                    LoadBen();
                }
                catch (Exception ex)
                {
                    new MessageBoxNew("Sorry! " + ex.Message, MessageType.Error, MessageButtons.Ok).ShowDialog();
                }
                new MessageBoxNew("Beneficiary deleted successfully", MessageType.Success, MessageButtons.Ok).ShowDialog();
            }
        }

        private void LoadBen()
        {
            BenLoad = new ObservableCollection<Beneficiary>(userentities.Beneficiaries);
           
        }
        private void Addben(object obj)
        {
            var d = new MessageBoxNew("Do you want to Add New beneficiary", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
            if (d != false)
            {
                try {
                    BenUser.CreatedDate = DateTime.Today;
                    BenUser.BenType = BenUser.BenType.Substring(37);
                    userentities.Beneficiaries.Add(BenUser);
                    userentities.SaveChanges();
                    LoadBen();
                    BenUser = new Beneficiary();
                }catch (Exception ex) { new MessageBoxNew("Sorry!" + ex.Message, MessageType.Success, MessageButtons.Ok).ShowDialog(); }
                new MessageBoxNew("New beneficiary added successfuly", MessageType.Success, MessageButtons.Ok).ShowDialog();
            }
        }
        private ObservableCollection<Beneficiary> _benload;

        public ObservableCollection<Beneficiary> BenLoad
        {
            get { return _benload; }
            set
            {
                _benload = value;
                OnPropertyChanged(nameof(BenLoad));
            }
        }
        public ICommand AddBenCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand UpdateBenCommand { get; set; }
    }
}
