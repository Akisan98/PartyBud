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
    public partial class IHaveNeverMenu : ContentPage
    {
        public IHaveNeverMenu()
        {
            InitializeComponent();
        }
        async void Start_Game(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new IHaveNever());
        }
    }
}