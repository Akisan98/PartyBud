using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Party_Bud.TruthOrDare
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TruthOrDare : ContentPage
    {
        private readonly Random _random = new Random();

        string[] dares;
        string[] truths;
        int counterD;
        int counterT;

        public TruthOrDare()
        {
            InitializeComponent();
            setup();
        }

        void setup()
        {
            var dare = new DareQuestionSet();
            dares = dare.Setup();
            counterD = 0;

            var truth = new TruthQuestionSet();
            truths = truth.Setup();
            counterT = 0;
        }

        async void DareQuestion(object sender, EventArgs e)
        {
            if (_random.Next(8) == 2)
            {
                await Navigation.PushAsync(new ToastScreen());
            }

            overskrift.Text = "Nødt";
            question_text.Text = dares[counterD];
            counterD++;
        }

        async void TruthQuestion(object sender, EventArgs e) 
        {
            if (_random.Next(8) == 2)
            {
                await Navigation.PushAsync(new ToastScreen());
            }

            overskrift.Text = "Sannhet";
            question_text.Text = truths[counterT];
            counterT++;
        }
    }
}