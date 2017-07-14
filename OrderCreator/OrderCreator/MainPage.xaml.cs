using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace OrderCreator
{
    public partial class MainPage : ContentPage
    {
        public ObservableRangeCollection<GroupedObservableCollection> Items { get; } = new ObservableRangeCollection<GroupedObservableCollection>();

        public MainPage()
        {
            InitializeComponent();

            BindingContext = this;

            try
            {
                var details = new GroupedObservableCollection("Details");
                var billing = new GroupedObservableCollection("Billing");
                var shipping = new GroupedObservableCollection("Shipping");
                var lineItems = new GroupedObservableCollection("Line Items");
                var totals = new GroupedObservableCollection("Totals");

                details.Add(new RowVm("Company", "ACME", details));
                billing.Add(new RowVm("Bill To", "1 Fake St.", billing));
                shipping.Add(new RowVm("Ship To", "3 Real St.", shipping));
                lineItems.Add(new RowVm("Line Item #1", "100$", lineItems));
                totals.Add(new RowVm("Subtotal", "100$", totals));

                Items.Add(details);
                Items.Add(billing);
                Items.Add(shipping);
                Items.Add(lineItems);
                Items.Add(totals);
            }
            catch (Exception ex)
            {
                Debugger.Break();
            }
        }
    }
}
