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

        void DareQuestion(object sender, EventArgs e)
        {
            overskrift.Text = "Nødt";
            question_text.Text = dares[counterD];
            counterD++;
        }

        void TruthQuestion(object sender, EventArgs e) 
        {
            overskrift.Text = "Sannhet";
            question_text.Text = truths[counterT];
            counterT++;
        }
    }
}