using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using PropertyChanged;
using Xamarin.Forms;

namespace OrderCreator
{
    [AddINotifyPropertyChangedInterface]
    public class GroupedObservableCollection : ObservableCollection<RowVm>
    {
        public string LongGroupName { get; set; }
        public string ShortGroupName { get; set; }

        public ICommand CmdEditGroup { get; }
        public ICommand CmdEditComplete { get; }

        public bool EditMode { get; set; }
        public bool ReadMode { get; set; } = true;

        public GroupedObservableCollection(string groupName)
        {
            LongGroupName = groupName;
            ShortGroupName = groupName;

            CmdEditGroup = new Command(EditGroup);
            CmdEditComplete = new Command(EditComplete);
        }

        private void EditGroup(object obj)
        {
            EditMode = true;
            ReadMode = false;

            var items = this.ToList();
            Clear();

            foreach (var rowVm in items)
            {
                Add(rowVm);
                Add(rowVm);
                Add(rowVm);
            }
        }

        private void EditComplete(object obj)
        {
            EditMode = false;
            ReadMode = true;

            var items = this.ToList();
            Clear();

            Add(items[0]);
        }
    }
}
