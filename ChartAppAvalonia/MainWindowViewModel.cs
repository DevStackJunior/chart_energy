using LiveChartsCore;
using LiveChartsCore.Kernel.Sketches;
using LiveChartsCore.SkiaSharpView;
using OxyPlot;
using OxyPlot.Series;
using System;
using System.Collections.Generic;

namespace ChartAppAvalonia;

public class MainWindowViewModel
{
    public PlotModel MyModel { get; set; }

    public MainWindowViewModel()
    {
        MyModel = new PlotModel { Title = "Consommation �nerg�tique (exemple)" };
        var series = new LineSeries
        {
            Title = "�nergie (kWh)",
            MarkerType = MarkerType.Circle,
            MarkerSize = 4,
            MarkerStroke = OxyColors.White
        };

        // Donn�es simul�es
        for (int i = 0; i < 10; i++)
        {
            series.Points.Add(new DataPoint(i, 100 + 20 * Math.Sin(i)));
        }

        MyModel.Series.Add(series);
    }
        
        
}
