using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using MVVMFilterExample.DAL;
using MVVMFilterExample.Models;

namespace MVVMFilterExample.ViewModels
{
    class FilteredListViewModel : INotifyPropertyChanged
    {

        public FilteredListViewModel()
        {
            StudentDataStore = new StudentDataStore();
        }

        private StudentDataStore _studentData;
        public StudentDataStore StudentDataStore
        {
            get => _studentData;
            set { _studentData = value; OnPropertyChanged(); }
        }

        private string _studentCodeFilter;
        public string StudentCodeFilter
        {
            get => _studentCodeFilter;
            set { _studentCodeFilter = value; OnPropertyChanged(); }
        }
        private string _nameFilter;
        public string NameFilter
        {
            get => _nameFilter;
            set { _nameFilter = value; OnPropertyChanged(); }
        }
        private string _surnameFilter;
        public string SurnameFilter
        {
            get => _surnameFilter;
            set { _surnameFilter = value; OnPropertyChanged(); }
        }

        public Predicate<object> StudentFilterPredicate => item => ((Student)item).Name.IndexOf(_nameFilter ?? "", StringComparison.InvariantCultureIgnoreCase) > -1 && ((Student)item).Surname.IndexOf(_surnameFilter ?? "", StringComparison.InvariantCultureIgnoreCase) > -1 && ((Student)item).StudentCode.IndexOf(_studentCodeFilter ?? "", StringComparison.InvariantCultureIgnoreCase) > -1;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
