using Avalonia.Controls;
using Chart_Energy.Views.Axes.Paging;

namespace Chart_Energy;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        // Ouvre View comme une nouvelle fenêtre
        var viewWindow = new View();
        viewWindow.Show();
    }
}
