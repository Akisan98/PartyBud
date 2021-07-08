using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Party_Bud
{
    public partial class Who_in_The_Room : ContentPage
    {
        string[] questions;
        int counter;

        public Who_in_The_Room()
        {
            InitializeComponent();
            var n = new WhoIsQuestionSet();
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