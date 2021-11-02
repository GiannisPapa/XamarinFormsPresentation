using StraightVanilla.Models;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace StraightVanilla.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PermissionsPage : ContentPage
    {
        public PermissionsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            MessagingCenter.Subscribe<PermissionItem, Exception>(this, nameof(PermissionException), async (p, ex) =>
                await DisplayAlert("Permission Error", ex.Message, "OK"));
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();

            MessagingCenter.Unsubscribe<PermissionItem, Exception>(this, nameof(PermissionException));
        }
    }
}