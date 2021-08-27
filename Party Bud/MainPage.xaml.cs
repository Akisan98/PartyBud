using Party_Bud.TruthOrDare;
using System;
using Xamarin.Forms;


namespace Party_Bud
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
        }

        //TODO: Ny Knapper på Hjemskjermen med bakgrunnsbilde

        async void Open_Who_In_The_Room(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GameMenu.GameMenu(1));
        }

        async void Open_Truth_Or_Dare(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TruthOrDareMenu());
        }

        async void Open_Never_Have_I(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GameMenu.GameMenu(0));
        }

        async void Open_Would_You_Rather(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GameMenu.GameMenu(2));
        }
    }
}
