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
    public partial class TruthOrDareMenu : ContentPage
    {
        public TruthOrDareMenu()
        {
            InitializeComponent();
        }

        async void Start_Game(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TruthOrDare());
        }
    }
}