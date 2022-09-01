using Plugin.Maui.Audio;

namespace MauiPluginAudioSample;

public partial class MainPage : ContentPage
{
	private readonly IAudioManager audioManager;
	int count = 0;

	public MainPage(IAudioManager audioManager)
	{
		InitializeComponent();
		this.audioManager = audioManager;
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		var player = audioManager.CreatePlayer(await FileSystem.OpenAppPackageFileAsync("mysound.wav"));

		player.Play();
    }
}

