using System.Collections.ObjectModel;
using CommonHelpers.Common;
using CommonHelpers.Models;
using CommonHelpers.Services;

namespace MyApp.Portable
{
    public class MainViewModel : ViewModelBase
    {
        private Person selectedContact;

        public MainViewModel()
        {
            Contacts = new ObservableCollection<Person>(SampleDataService.Current.GeneratePeopleData(true));
        }

        public ObservableCollection<Person> Contacts { get; set; }

        public Person SelectedContact
        {
            get => selectedContact;
            set => SetProperty(ref selectedContact, value);
        }
    }
}