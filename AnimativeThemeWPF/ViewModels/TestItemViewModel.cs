using AnimativeThemeWPF.Utilities;

namespace AnimativeThemeWPF.ViewModels
{
    public class TestItemViewModel : BaseViewModel
    {
        private string _productName;
        public string ProductName
        {
            get => _productName;
            set => RaisePropertyChanged(ref _productName, value);
        }

        private string _productDescription;
        public string ProductDescription
        {
            get => _productDescription;
            set => RaisePropertyChanged(ref _productDescription, value);
        }

        private double _productPrice;
        public double ProductPrice
        {
            get => _productPrice;
            set => RaisePropertyChanged(ref _productPrice, value);
        }
    }
}
