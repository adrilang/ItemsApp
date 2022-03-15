using System.ComponentModel;
using Xamarin.Forms;
using ItemsApp.ViewModels;

namespace ItemsApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}