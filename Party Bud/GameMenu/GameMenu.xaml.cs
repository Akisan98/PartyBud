using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Party_Bud.GameMenu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GameMenu : ContentPage
    {

        string[] headers = new string[] {
            "Jeg har aldri - Meny",
            "Hvem i rommet - Meny",
            "Vil du heller - Meny"
        };

        string[] gameName = new string[] {
            "Jeg har aldri ...",
            "Hvem i rommet er mest sannsynlig ...",
            "Vil du heller ..."
        };

        string[] description = new string[] {
            "Den eldste spilleren starter med et utsagn, hvis folk har gjort det drikker dem, om ingen har drikker personen som leste.",
            "Spill ved å sende rundt en objekt eller peke på personen du tror det er.",
            "Den yngste spilleren starter spillet og stiller spørsmålet til spilleren som står ved siden av ham og så videre..."
        };

        int gameID;

        public GameMenu(int gameID)
        {
            this.gameID = gameID;
            this.BindingContext = this;
            Title = headers[gameID];
            
            InitializeComponent();

            GameName.Text = gameName[gameID];
            GameDescription.Text = description[gameID];
        }

        async void Start_Game(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GameScreen.GameScreen(this.gameID));
        }
    }
}