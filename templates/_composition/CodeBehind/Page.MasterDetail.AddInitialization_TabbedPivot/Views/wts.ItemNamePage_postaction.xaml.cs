using Windows.UI.Xaml;
namespace ItemNamespace.Views
{
    public sealed partial class wts.ItemNamePage : Page, INotifyPropertyChanged
    {
        public wts.ItemNamePage()
        {
            Loaded += OnLoaded;
            InitializeComponent();
        }

        //{[{
        private async void OnLoaded(object sender, RoutedEventArgs e)
        {
            await LoadDataAsync();
        }
        //}]}
    }
}