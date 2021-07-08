using Party_Bud.IHaveNever;
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

        async void Open_Who_In_The_Room(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new WhoInTheRoom2());
        }

        async void Open_Truth_Or_Dare(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TruthOrDareMenu());
        }


        async void Open_Never_Have_I(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IHaveNeverMenu());
        }
    }
}
