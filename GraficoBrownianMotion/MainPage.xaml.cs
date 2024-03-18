using GraficoBrownianMotion.ViewModel;
using SkiaSharp;
using SkiaSharp.Views.Maui;

namespace GraficoBrownianMotion;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
	}

    private void OnCanvasViewPaintSurface(object sender, SKPaintSurfaceEventArgs e)
    {
        var viewModel = (MainViewModel)BindingContext;
        var prices = viewModel.Prices;

        if (prices == null || prices.Length == 0)
            return;

        var surface = e.Surface;
        var canvas = surface.Canvas;

        canvas.Clear(SKColors.White);

    }

    public MainPage(MainViewModel viewModel)
    {
        BindingContext = viewModel;
    }

}


