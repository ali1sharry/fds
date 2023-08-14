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
    class DistributionViewModel : INotifyPropertyChanged
    {
        private FDSEntities userentities;
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private ObservableCollection<Beneficiary> _loadben; 
        public ObservableCollection<Beneficiary> Loadben
        {
            get { return _loadben; }
            set
             {
                _loadben = value;
                OnPropertyChanged(nameof(Loadben));
            }
        }
        private FoodDistribution disadd = new FoodDistribution();

        public FoodDistribution Disadd
        {
            get { return disadd; }
            set
            {
                disadd = value;
                OnPropertyChanged(nameof(Disadd));
            }
        }
        public DistributionViewModel()
        {
            userentities = new FDSEntities();
            BenLoad();
            AddDisCommmand = new RelayCommand(AddDis, (s) => true);
            ListCommand = new RelayCommand(ListDon, (s) => true);
            DeleteCommand = new RelayCommand(Delete, (s) => true);
            UpdateCommand = new RelayCommand(Update, (s) => true);
            UpdateDonCommand = new RelayCommand(UpdateBen, (s) => true);
        }
        private FoodDistribution _selectdon = new FoodDistribution();
        public FoodDistribution Selectdon
        {
            get { return _selectdon; }
            set
            {
                _selectdon = value;
                OnPropertyChanged(nameof(Selectdon));
            }
        }
        private int? def;
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
                        Selectdon.DisQuantity = Selectdon.DisQuantity * 5;
                    }
                    if (def == Selectdon.DisQuantity)
                    {
                        userentities.SaveChanges();
                        Selectdon = new FoodDistribution();
                        ListDon(obj);
                    }
                    else
                    {
                        def = Selectdon.DisQuantity - def;
                        var availstore = userentities.FoodStores.Find(Selectdon.StoreId);
                        {
                            if (availstore != null)
                            {
                                availstore.Available = availstore.Available + def;
                                userentities.SaveChanges();
                                Selectdon = new FoodDistribution();
                                ListDon(obj);
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
            Selectdon = obj as FoodDistribution;
            def = Selectdon.DisQuantity;

        }
        private ObservableCollection<FoodDistribution> _listdon;
        public ObservableCollection<FoodDistribution> Listdon
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
            Listdon = new ObservableCollection<FoodDistribution>(userentities.FoodDistributions.Where(o => o.BenId == Disadd.BenId));


        }
        private void Delete(object obj)
        {
            var d = new MessageBoxNew("Do you want to delete Record?", MessageType.Warning, MessageButtons.YesNo).ShowDialog();
            if (d == true)
            {
                try
                {
                    var dona = obj as FoodDistribution;

                    var availablestore = userentities.FoodStores.Find(dona.StoreId);
                    {
                        if (availablestore != null)

                        {
                            availablestore.Available = availablestore.Available - dona.DisQuantity;
                            dona = userentities.FoodDistributions.Remove(dona);

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
        private ObservableCollection<FoodStore> _fodstore;
        public ObservableCollection<FoodStore> Fodstore
        {
            get { return _fodstore; }
            set
            {
                _fodstore = value;
                OnPropertyChanged(nameof(Fodstore));
            }
        }
        private void BenLoad()
        {
            Loadben = new ObservableCollection<Beneficiary>(userentities.Beneficiaries);
            Fodstore = new ObservableCollection<FoodStore>(userentities.FoodStores);
        }
        private void AddDis(object obj)
        {
            var d = new MessageBoxNew("Do you want to Add New Record", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
            if (d != false)
            {
                try
                {

                    Disadd.FoodItem = Disadd.FoodItem.Substring(37); 

                    var addavailable = userentities.FoodStores.Find(Disadd.StoreId);
                    {
                        if (addavailable != null)
                        {
                            if (addavailable.Available <= addavailable.StoreCapacity)
                            {
                                if (Disadd.FoodItem == " Donation Box 5KG")
                                {
                                    Disadd.DisQuantity = Disadd.DisQuantity * 5;
                                }
                                addavailable.Available = addavailable.Available + Disadd.DisQuantity;
                                
                                userentities.FoodDistributions.Add(Disadd);
                                userentities.SaveChanges();
                            }
                            else
                            {
                                new MessageBoxNew("Sorry!" + addavailable.StoreName + " is empty ", MessageType.Success, MessageButtons.Ok).ShowDialog();
                            }
                        }
                    }
                    
            Disadd = new FoodDistribution();
                }
                catch (Exception ex) { new MessageBoxNew("Sorry!" + ex, MessageType.Success, MessageButtons.Ok).ShowDialog(); }
                new MessageBoxNew("New Record added successfuly", MessageType.Success, MessageButtons.Ok).ShowDialog();
            }
        }

        public ICommand AddDisCommmand { get; set; }
        public ICommand ListCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand UpdateDonCommand { get; set; }
    }
}
