using System.Collections.ObjectModel;
using CommonHelpers.Common;
using CommonHelpers.Models;
using CommonHelpers.Services;

namespace MyApp.Portable
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            People = new ObservableCollection<Person>(SampleDataService.Current.GeneratePeopleData(true));
        }

        public ObservableCollection<Person> People { get; set; }
    }
}