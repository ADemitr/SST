using Prism.Commands;
using Prism.Mvvm;
using System.Collections.ObjectModel;

namespace TestTask.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "SST Test Task";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private ObservableCollection<string> _items = new ()
        {
            "Till Lindemann",
            "Richard Kruspe",
            "Paul Landers",
            "Oliver Riedel",
            "Christoph Schneider",
            "Christian Lorenz"
        };

        public ObservableCollection<string> Items
        {
            get { return _items; }
            set { _items = value; }
        }

        private DelegateCommand<object> _delete;
        public DelegateCommand<object> Delete =>
            _delete ?? (_delete = new DelegateCommand<object>(ExecuteDelete));

        void ExecuteDelete(object index)
        {
            try
            {
                int i = (int)index;
                Items.RemoveAt(i);
            }
            catch { }
        }

        public MainWindowViewModel() { }
    }
}
