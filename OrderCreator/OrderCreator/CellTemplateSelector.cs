using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OrderCreator
{
    public class CellTemplateSelector : DataTemplateSelector
    {
        public DataTemplate ReadTemplate { get; set; }
        public DataTemplate EditTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            var rowVm = (RowVm) item;

            if (rowVm.ParentGroup.EditMode)
                return EditTemplate;

            return ReadTemplate;
        }
    }
}
