using BaKaVO.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaKaVO.MVVM.ViewModel
{
    class MainViewModel : ObservableObject
    {
        public RelayCommand AnamnesisViewCommand { get; set; }
        public RelayCommand PatientListViewCommand { get; set; }
        public RelayCommand PatientViewCommand { get; set; }
        public RelayCommand SettingsViewCommand { get; set; }

        public AnamnesisViewModel AnamnesisVM { get; set; }
        public PatientListViewModel PatientListVM { get; set; }
        public PatientViewModel PatientVM { get; set; }
        public SettingsViewModel SettingsVM { get; set; }

        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { 
                _currentView = value; 
                OnPropertyChanged(); 
            }
        }

        public MainViewModel() 
        {
            AnamnesisVM = new AnamnesisViewModel();
            PatientListVM = new PatientListViewModel();
            PatientVM = new PatientViewModel();
            SettingsVM = new SettingsViewModel();

            CurrentView = PatientListVM;

            AnamnesisViewCommand = new RelayCommand(o =>
            {
                CurrentView = AnamnesisVM;
            });

            PatientListViewCommand = new RelayCommand(o =>
            {
                CurrentView = PatientListVM;
            });

            PatientViewCommand = new RelayCommand(o => 
            {
                CurrentView = PatientVM;
            });

            SettingsViewCommand = new RelayCommand(o =>
            {
                CurrentView = SettingsVM;
            });
        }
    }
}
