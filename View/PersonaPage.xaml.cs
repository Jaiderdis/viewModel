using practicahoy.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace practicahoy.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonaPage : ContentPage
    {
        PersonaViewModel ViewModel=new PersonaViewModel();
        public PersonaPage()
        {
            InitializeComponent();
            BindingContext = ViewModel;
            
        }
    }
}