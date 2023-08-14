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
    class DonationViewModel : INotifyPropertyChanged
    {
        private FDSEntities userentities;
        private Donation adddona = new Donation();
        public Donation Adddona
        {
            get { return adddona; }
            set { adddona = value;
                OnPropertyChanged(nameof(Adddona));
            }
        }
        private Donation _selectdon = new Donation();
        public Donation Selectdon
        {
            get { return _selectdon; }
            set
            {
                _selectdon = value;
                OnPropertyChanged(nameof(Selectdon));
            }
        }
        private ObservableCollection<Donation> _donfetch;

        public ObservableCollection<Donation> _Donfetch
        {
            get { return _donfetch; }
            set { _donfetch = value;
                OnPropertyChanged(nameof(_Donfetch));

            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public DonationViewModel()
        {
            userentities = new FDSEntities();
            LoadDonor();
            AddDonCommand = new RelayCommand(AddDon, (s) => true);
            FetchCommand = new RelayCommand(FetchDono, (s) => true);
            ListCommand = new RelayCommand(ListDon, (s) => true);
            DeleteCommand = new RelayCommand(Delete, (s) => true);
            UpdateCommand = new RelayCommand(Update, (s) => true);
            UpdateDonCommand = new RelayCommand(UpdateBen, (s) => true);

        }
        private int def;
        private void UpdateBen(object obj)
        {
            var d = new MessageBoxNew("Are you sure to update record?", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
            if (d == true)
            {
                try
                {
                    Selectdon.FoodItem = Selectdon.FoodItem.Substring(37);
                    if (Selectdon.FoodItem == " Donation Box 5KG")
                    {
                        Selectdon.Quantity = Selectdon.Quantity * 5;
                    }
                    

                    if(def == Selectdon.Quantity)
                    {
                        userentities.SaveChanges();
                        Selectdon = new Donation();
                        ListDon(obj);
                    }
                    else
                    {
                        def = Selectdon.Quantity - def;
                        var availstore = userentities.FoodStores.Find(Selectdon.StoreId);
                            {
                            if(availstore!=null)
                            {
                                
                                availstore.Available = availstore.Available - def;
                                userentities.SaveChanges();
                                Selectdon = new Donation();
                                ListDon(obj);
                                LoadDonor();
                                
                            }

                        }

                    }
                    
                    
                }
                catch (Exception ex)
                {
                    new MessageBoxNew("Sorry!" + ex, MessageType.Error, MessageButtons.Ok).ShowDialog();
                }
                new MessageBoxNew("Record updated successfully", MessageType.Success, MessageButtons.Ok).ShowDialog();
            }
        }

        private void Update(object obj)
        {
            new MessageBoxNew("Now you can update...", MessageType.Info, MessageButtons.Ok).ShowDialog();
            
            Selectdon = obj as Donation;
            def = Selectdon.Quantity;
        }

        private void Delete(object obj)
        {
            var d = new MessageBoxNew("Do you want to delete Record?", MessageType.Warning, MessageButtons.YesNo).ShowDialog();
            if (d == true)
            {
                try
                {
                    var dona = obj as Donation;
                    var availablestore = userentities.FoodStores.Find(dona.StoreId);
                    {
                        if (availablestore != null)

                        {
                            availablestore.Available = availablestore.Available  + dona.Quantity;
                            dona = userentities.Donations.Remove(dona);

                            userentities.SaveChanges();

                        }
                    }

                }
                catch (Exception ex)
                {
                    new MessageBoxNew("Sorry! " + ex, MessageType.Error, MessageButtons.Ok).ShowDialog();
                }
                new MessageBoxNew("Record deleted successfully", MessageType.Success, MessageButtons.Ok).ShowDialog();

                ListDon(obj);
            }
        }

        private ObservableCollection<Donation> _listdon;
        public ObservableCollection<Donation> Listdon
        {
            get { return _listdon; }
            set
            {
                _listdon = value;
                OnPropertyChanged(nameof(Listdon));
            }
        }
        public void ListDon(object obj)
        {
            Listdon = new ObservableCollection<Donation>(userentities.Donations.Where(o => o.DonorId == Adddona.DonorId));
           

        }

        private void FetchDono(object obj)
        {
            _Donfetch = new ObservableCollection<Donation>(userentities.Donations);
            for (int i = 0; i <= _Donfetch.Count; i++)
            {
                if (_Donfetch[i].DonorId == Adddona.DonorId)
                {
                    LoadDonor();
                }
            }
        }


        private void AddDon(object obj)
        {
            var d = new MessageBoxNew("Do you want to Add New Record", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
            if (d != false)
            {
                try
                {
                    
                    Adddona.FoodItem = Adddona.FoodItem.Substring(37);
                    Adddona.CreatedDate = System.DateTime.Today;
                    userentities.Donations.Add(Adddona);
                    var addavailable = userentities.FoodStores.Find(Adddona.StoreId);
                        {
                        if (addavailable != null)
                        {
                            if (addavailable.Available != 0)
                            {
                                if (Adddona.FoodItem == " Donation Box 5KG")
                                {
                                    Adddona.Quantity = Adddona.Quantity * 5;
                                }
                                addavailable.Available = addavailable.Available - Adddona.Quantity;
                                userentities.SaveChanges();
                            }
                            else
                            {
                                new MessageBoxNew("Sorry!" + addavailable.StoreName + " is Full ", MessageType.Success, MessageButtons.Ok).ShowDialog();
                            }
                        }
                        }
                    
                    Adddona = new Donation();
                }
                catch (Exception ex) { new MessageBoxNew("Sorry!" + ex, MessageType.Success, MessageButtons.Ok).ShowDialog(); }
                new MessageBoxNew("New Record added successfuly", MessageType.Success, MessageButtons.Ok).ShowDialog();
            }
        }
        private ObservableCollection<Donor> _donorrload;
        private ObservableCollection<Donation> _donaload;
        public ObservableCollection<Donation> DonaLoad
        {
            get { return _donaload; }
            set
            {
                _donaload = value;
                OnPropertyChanged(nameof(DonaLoad));
            }
        }

        public ObservableCollection<Donor> DonorrLoad
        {
            get { return _donorrload; }
            set
            {
                _donorrload = value;
                OnPropertyChanged(nameof(DonorrLoad));
            }
        }
        private ObservableCollection<FoodStore> _fodstore;
        public ObservableCollection<FoodStore> Fodstore
        {
            get { return _fodstore; }
            set { _fodstore = value;
                OnPropertyChanged(nameof(Fodstore));
                }
        }
            public void LoadDonor()
        {
            DonorrLoad = new ObservableCollection<Donor>(userentities.Donors);
            DonaLoad = new ObservableCollection<Donation>(userentities.Donations);
            Fodstore = new ObservableCollection<FoodStore>(userentities.FoodStores);
        }
        public ICommand AddDonCommand { get; set; }
        public ICommand FetchCommand { get; set; }
        public ICommand ListCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand UpdateDonCommand { get; set; }

    }
}
