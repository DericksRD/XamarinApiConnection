using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinApiConnection.ViewModels;

namespace XamarinApiConnection.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApiInformationPage : ContentPage
    {
        public ApiInformationPage()
        {
            InitializeComponent();
            BindingContext = new ApiInformationViewModel();
        }
    }
}