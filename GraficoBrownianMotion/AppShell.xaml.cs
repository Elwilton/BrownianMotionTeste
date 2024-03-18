namespace GraficoBrownianMotion;

public partial class AppShell : Shell
{
	public AppShell()
	{
        InitializeComponent();

        Routing.RegisterRoute(nameof(MainPage), typeof(MainPage));
    }

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }
}

