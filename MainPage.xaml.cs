using Microsoft.Maui.Graphics.Platform;
using Microsoft.Maui.Layouts;

namespace Reproduce.PlatformStringSizeService;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();

		var service = new PlatformStringSizeService();
		var font = new Microsoft.Maui.Graphics.Font("OpenSansRegular");
		var focusHeight = service.GetStringSize("01", font, 14).Height;
		var otherHeight = service.GetStringSize("01-01", font, 8).Height;
		label.Text = ((1.2 * (focusHeight + otherHeight)) + 2).ToString();
	}
}

