using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Party_Bud.GameScreen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GameScreen : ContentPage
    {
        private readonly Random _random = new Random();

        int gameID;
        string[] questions;
        int counter;

        string[] gameName = new string[] {
            "Jeg har aldri...",
            "Hvem",
            "Vil du heller"
        };

        string[] headers = new string[] {
            "Jeg har aldri",
            "Hvem i rommet",
            "Vil du heller"
        };

        public GameScreen(int gameID)
        {
            this.gameID = gameID;
            this.BindingContext = this;
            Title = headers[gameID];
            InitializeComponent();

            GameName.Text = gameName[gameID];

            switch (gameID)
            {
                case 0:
                    var never = new NeverHaveIQuestionSet();
                    questions = never.Setup();
                    break;
                case 1:
                    var who = new WhoIsQuestionSet();
                    questions = who.Setup();
                    break;
                case 2:
                    var would = new WouldYouRatherQuestionSet();
                    questions = would.Setup();
                    break;
            }

            question_text.Text = questions[0];
            counter = 1;
        }

        async void Next_Question(object sender, EventArgs e)
        {
            if (_random.Next(6) == 2)
            {
                await Navigation.PushAsync(new ToastScreen());
            }

            question_text.Text = questions[counter];
            counter++;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}