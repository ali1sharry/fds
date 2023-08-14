using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FDS.Core;
using FDS.MVVM.Model;

namespace FDS.MVVM.ViewModel
{
    class MainViewModel : ObserableObjects
    {
        public RelayCommand FoodstoreViewCommand { get; set; }
        public RelayCommand DonationViewCommand { get; set; }
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand UserViewCommand { get; set; }
        public RelayCommand BeneficiariesViewCommand { get; set; }
        public RelayCommand DonorViewCommand { get; set; }
        public RelayCommand DistributionViewCommand { get; set; }
        public RelayCommand ReportViewCommand { get; set; }
        public FoodstoreViewModel FoodstoreVm { get; set; }
        public HomeViewModel HomeVm { get; set; }
        public UserViewModel UserVm { get; set; }
        public BeneficiariesViewModel BeneficiariesVm { get; set; }
        public DonorViewModel DonorVm { get; set; }
        public DonationViewModel DonaVm { get; set; }
        public DistributionViewModel DisVm { get; set; }
        public ReportViewModel RpVm { get; set; }
        private object _CurrentView;
        
        public object CurrentView
        {
            get { return _CurrentView; }
            set { _CurrentView = value;
                   OnPropertyChanged();}
        }

        public MainViewModel(User data)
        {
            User session = data;
        }
        public MainViewModel()
        {
            HomeVm = new HomeViewModel();
            UserVm = new UserViewModel();
            BeneficiariesVm = new BeneficiariesViewModel();
            DonorVm = new DonorViewModel();
            FoodstoreVm = new FoodstoreViewModel();
            DonaVm = new DonationViewModel();
            DisVm = new DistributionViewModel();
            RpVm = new ReportViewModel();
            CurrentView = HomeVm;
            HomeViewCommand = new RelayCommand( o =>
                {
                    CurrentView = HomeVm;
                });
            
                UserViewCommand = new RelayCommand(o =>
                {
                    if (Session.type == 0)
                    {
                        CurrentView = UserVm;
                    }
                    else
                    {
                        new MessageBoxNew("Only administrator access users", MessageType.Error, MessageButtons.Ok).ShowDialog();
                    }
                });
            

            BeneficiariesViewCommand = new RelayCommand(o =>
            {
                CurrentView = BeneficiariesVm;
            });
            DonorViewCommand = new RelayCommand(o =>
            {
                CurrentView = DonorVm;
            });
            FoodstoreViewCommand = new RelayCommand(o =>
           {
               CurrentView = FoodstoreVm;
           });
            DonationViewCommand = new RelayCommand(o =>
            {
                CurrentView = DonaVm;
            });
            DistributionViewCommand = new RelayCommand(o => 
            {
                CurrentView = DisVm;
            });
            ReportViewCommand = new RelayCommand(o =>
            {
                if (Session.type == 0)
                {
                    CurrentView = RpVm;
                }
                else
                {
                    new MessageBoxNew("Only administrator access reports", MessageType.Error, MessageButtons.Ok).ShowDialog();
                }
            });

        }
    }
}
