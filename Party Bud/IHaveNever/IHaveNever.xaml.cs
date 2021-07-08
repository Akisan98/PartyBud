using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Party_Bud.IHaveNever
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IHaveNever : ContentPage
    {

        string[] questions;
        int counter;

        public IHaveNever()
        {
            InitializeComponent();

            var n = new NeverHaveIQuestionSet();
            questions = n.Setup();

            question_text.Text = questions[0];
            counter = 1;
        }

        void New_Question(object sender, EventArgs e)
        {
            question_text.Text = questions[counter];
            counter++;
        }

    }
}