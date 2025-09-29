using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.Kernel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace Chart_Energy.ViewModelsSamples.Axes.Paging;

public partial class ViewModel
{
    public ISeries[] Series { get; set; } =
    {
        new LineSeries<double>
        {
            Values = new double[] { 3, 1, 4, 5, 2, 4, 3, 7, 2, 8, 5, 9, 4, 6, 3, 7, 2, 8, 5, 9 }
        }
    };

    public Axis[] XAxes { get; set; } =
    {
        new Axis 
        { 
            Name = "X Axis",
            MinLimit = 0,
            MaxLimit = 5
        }
    };

    public Axis[] YAxes { get; set; } =
    {
        new Axis { Name = "Y Axis" }
    };

    public ICommand GoToPage1Command { get; }
    public ICommand GoToPage2Command { get; }
    public ICommand GoToPage3Command { get; }
    public ICommand SeeAllCommand { get; }

    public ViewModel()
    {
        GoToPage1Command = new RelayCommand(GoToPage1);
        GoToPage2Command = new RelayCommand(GoToPage2);
        GoToPage3Command = new RelayCommand(GoToPage3);
        SeeAllCommand = new RelayCommand(SeeAll);
    }

    private void GoToPage1()
    {
        XAxes[0].MinLimit = 0;
        XAxes[0].MaxLimit = 5;
    }

    private void GoToPage2()
    {
        XAxes[0].MinLimit = 5;
        XAxes[0].MaxLimit = 10;
    }

    private void GoToPage3()
    {
        XAxes[0].MinLimit = 10;
        XAxes[0].MaxLimit = 15;
    }

    private void SeeAll()
    {
        XAxes[0].MinLimit = null;
        XAxes[0].MaxLimit = null;
    }
}