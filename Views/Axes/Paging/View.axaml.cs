using Chart_Energy.ViewModelsSamples.Axes.Paging;

namespace Chart_Energy.Views.Axes.Paging
{
    public partial class View : Window
    {
        public View()
        {
            InitializeComponent();
            DataContext = new ViewModel();
        }
    }
}