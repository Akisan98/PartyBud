using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Party_Bud
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WhoInTheRoom2 : ContentPage
    {
        public WhoInTheRoom2()
        {
            InitializeComponent();
        }

        async void Start_Game(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Who_in_The_Room());
        }
    }
}