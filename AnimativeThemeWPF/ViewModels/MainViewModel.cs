using AnimativeThemeWPF.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimativeThemeWPF.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ObservableCollection<TestItemViewModel> TestItems { get; set; }

        public MainViewModel()
        {
            TestItems = new ObservableCollection<TestItemViewModel>();

            TestItems.Add(new TestItemViewModel() { ProductName = "Xbox One", ProductDescription = "This product is ok.", ProductPrice = 200.99 });
            TestItems.Add(new TestItemViewModel() { ProductName = "Playstation 4", ProductDescription = "a", ProductPrice = 250.99 });
            TestItems.Add(new TestItemViewModel() { ProductName = "PC", ProductDescription = "AMD, AMD, AMD, AMD, AMD and Samsung", ProductPrice = 749.99 });
            TestItems.Add(new TestItemViewModel() { ProductName = "Yacht", ProductDescription = "Fast", ProductPrice = 450000.99 });
            TestItems.Add(new TestItemViewModel() { ProductName = "Bob the builder's antimatter generator", ProductDescription = "Only uses 193.6 terajoules per second.", ProductPrice = 999999.99 });
            TestItems.Add(new TestItemViewModel() { ProductName = "Playstation 4", ProductDescription = "repeating because h", ProductPrice = 250.99 });

        }
    }
}
