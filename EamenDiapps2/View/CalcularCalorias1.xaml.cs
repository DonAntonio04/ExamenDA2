using EamenDiapps2.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EamenDiapps2.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalcularCalorias1 : ContentPage
    {
        public CalcularCalorias1()
        {
            InitializeComponent();
            BindingContext = new VMCalorias(Navigation);
        }
    }
}