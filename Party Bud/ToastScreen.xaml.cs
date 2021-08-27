using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Party_Bud
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToastScreen : ContentPage
    {
        private readonly Random _random = new Random();

        public ToastScreen()
        {
            InitializeComponent();

            emoji_to_display.Text = FindEmoji();
            call_to_action.Text = TextToDisplay();
            Title = "Skål";
        }

        /// <summary>
        /// Short Method for Randomly Generating A Emoji as a String for Displaying.
        /// </summary>
        /// <returns>Emoji as a String</returns>
        private string FindEmoji()
        {
            int num = _random.Next(5);
            
            switch (num) { 
                case 0:
                    return "🍻";
                case 1:
                    return "🥂";
                case 2:
                    return "🍷";
                case 3:
                    return "🍹";
                case 4:
                    return "🍸";
            }

            return string.Empty;
        }

        /// <summary>
        /// Short Method for Randomly Generating Text describing what to do for Displaying.
        /// </summary>
        /// <returns>Call to Action Text</returns>
        private string TextToDisplay()
        {
            int num = _random.Next(8);

            switch (num)
            {
                case 0:
                    return "Waterfall";
                case 1:
                    return "Alle tar en slurk";
                case 2:
                    return "Gutta tar en slurk";
                case 3:
                    return "Damene tar en slurk";
                case 4:
                    return "Alle med sort klesplagg tar en slurk";
                case 5:
                    return "Alle som ikke drikker øl tar en slurk";
                case 6:
                    return "Alle som øl tar en slurk";
                case 7:
                    return "Petter må drikke, om Petter ikke er med må alle drikke";
            }

            return string.Empty;
        }

        void GoBack(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}