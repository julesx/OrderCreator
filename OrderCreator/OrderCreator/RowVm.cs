using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCreator
{
    public class RowVm
    {
        public string Header { get; set; }
        public string Value { get; set; }
        public GroupedObservableCollection ParentGroup { get; set; }

        public RowVm(string header, string value, GroupedObservableCollection parentGroup)
        {
            Header = header;
            Value = value;
            ParentGroup = parentGroup;
        }
    }
}
