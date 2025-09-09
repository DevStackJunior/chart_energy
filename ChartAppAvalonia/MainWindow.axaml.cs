using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ChartAppAvalonia
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Associer le ViewModel
            DataContext = new MainWindowViewModel();
        }
    }
}
