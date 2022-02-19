using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DarinsDiceRoller.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreditPage : ContentPage
    {
        public CreditPage()
        {
            InitializeComponent();

            BoxView mySeperator = new BoxView {  Color=Color.Black, VerticalOptions=LayoutOptions.FillAndExpand, HeightRequest = 1};
        }
    }
}