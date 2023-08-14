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
    class FoodstoreViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private FoodStore fs;
        private FDSEntities userentities = new FDSEntities();
        
        private FoodStore _selectedfs;
        public FoodStore SelectedFs
        {
            get { return _selectedfs; }
            set
            {
                _selectedfs = value;
                OnPropertyChanged(nameof(SelectedFs));
            }

        }
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public FoodstoreViewModel()
        {
            fs =  new FoodStore();
           
            LoadFS();
            AddCommand = new RelayCommand(Add, (s) => true);
            DeleteCommand = new RelayCommand(Delete, (s) => true);
            UpdateCommand = new RelayCommand(Update, (s) => true);
            UpdateFsCommand = new RelayCommand(UpdateFs, (s) => true);
        }


        private void LoadFS()
        {
            fsLoad = new ObservableCollection<FoodStore>(userentities.FoodStores);
            
                
           
        }
        private ObservableCollection<FoodStore> _fsload;
        private void Add(object obj)
        {
            var d = new MessageBoxNew("Do you want to add new store", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
            if (d != false)
            {
                try
                {
                    Fodstore.Available = Fodstore.StoreCapacity;
                    Fodstore.CreateBy = Convert.ToInt32(Session.type);
                   
                    userentities.FoodStores.Add(Fodstore);
                    userentities.SaveChanges();
                    LoadFS();
                    Fodstore = new FoodStore();
                }
                catch (Exception ex) { new MessageBoxNew("Sorry!" + ex, MessageType.Success, MessageButtons.Ok).ShowDialog(); }
                new MessageBoxNew("New store added successfuly", MessageType.Success, MessageButtons.Ok).ShowDialog();
            }
        }

        private void Update(object obj)
        {
            new MessageBoxNew("Now you can update...", MessageType.Info, MessageButtons.Ok).ShowDialog();
            SelectedFs = obj as FoodStore;

        }
        private void UpdateFs(object obj)
        {
            var d = new MessageBoxNew("Are you sure to update store?", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
            if (d == true)
            {
                try
                {
                    userentities.SaveChanges();
                    SelectedFs = new FoodStore();
                    LoadFS();
                }
                catch (Exception ex)
                {
                    new MessageBoxNew("Sorry!" + ex, MessageType.Error, MessageButtons.Ok).ShowDialog();
                }
                new MessageBoxNew("Store updated successfully", MessageType.Success, MessageButtons.Ok).ShowDialog();
            }
        }

        private void Delete(object obj)
        {
            var d = new MessageBoxNew("Do you want to delete store?", MessageType.Warning, MessageButtons.YesNo).ShowDialog();
            if (d == true)
            {
                try
                {
                    var fod = obj as FoodStore;
                    userentities.FoodStores.Remove(fod);
                    userentities.SaveChanges();
                    LoadFS();
                }
                catch (Exception ex)
                {
                    new MessageBoxNew("Sorry! " + ex, MessageType.Error, MessageButtons.Ok).ShowDialog();
                }
                new MessageBoxNew("Store deleted successfully", MessageType.Success, MessageButtons.Ok).ShowDialog();
            }
        }
        public ObservableCollection<FoodStore> fsLoad
        {
            get { return _fsload; }
            set
            {
                _fsload = value;
                OnPropertyChanged(nameof(fsLoad));
            }
        }
 
        
        public FoodStore Fodstore
        {
            get { return fs; }
            set
            {
                fs = value;
                OnPropertyChanged(nameof(Fodstore));
            }
        }
        public ICommand AddCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand UpdateCommand { get; set; }
        public ICommand UpdateFsCommand { get; set; }
    }
    
}
