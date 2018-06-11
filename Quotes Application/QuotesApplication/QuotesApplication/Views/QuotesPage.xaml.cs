using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CommonServiceLocator;
using Newtonsoft.Json;
using QuotesApplication.Models;
using QuotesApplication.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuotesApplication.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        public QuotesPage()
        {
            InitializeComponent();
            BindingContext = ServiceLocator.Current.GetInstance(typeof(QuotesViewModel));
        }

       
    }
}