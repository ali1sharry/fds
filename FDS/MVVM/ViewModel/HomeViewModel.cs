using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using FDS.MVVM.Model;

namespace FDS.MVVM.ViewModel
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        private FDSEntities userentities;
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        private List<int> _list;
        public List<int> List
        {
            get
            {
                return _list;
            }
            set
            {
                _list = value;
                OnPropertyChanged(nameof(List));
            }
        }
       public HomeViewModel()
        {
            userentities = new FDSEntities();
            Load();
        }
        public void Load()
        {
            List = new List<int>();
        List.Add(userentities.Beneficiaries.Count());
           List.Add(  userentities.Beneficiaries.Where(o => o.BenType == " Indivual").Count());
           List.Add( userentities.Beneficiaries.Where(o => o.BenType == " Family").Count());
            List.Add(userentities.FoodStores.Count());
            List.Add(userentities.FoodStores.Sum(o => o.StoreCapacity));
            List.Add(userentities.Donors.Count());
            List.Add(userentities.Donations.Sum(o => o.Quantity));
            List.Add(Convert.ToInt32( userentities.FoodDistributions.Sum(o => o.DisQuantity)));
            List.Add(Convert.ToInt32(userentities.FoodStores.Sum(o => o.Available)));
        }
    }
}
