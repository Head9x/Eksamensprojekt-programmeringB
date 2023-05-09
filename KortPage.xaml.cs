using System.Timers;

namespace Eksamensprojekt;

public partial class KortPage : ContentPage
{
    public KortPage(string lokale = "none")
    {
        InitializeComponent();

        if (lokale == "none")
        {
            var timer = new System.Timers.Timer(1000);
            timer.Elapsed += new ElapsedEventHandler(RedrawClock);
            timer.Start();

        }
    }

    public void DrawClock(object source, ElapsedEventArgs e)
    {
        var graphicsView = this.ClockGraphicsView;

        graphicsView.Invalidate();
    }

    public void RedrawClock(object source, ElapsedEventArgs e)
    {
        var graphicsView = this.ClockGraphicsView;

        graphicsView.Invalidate();
    }
}

