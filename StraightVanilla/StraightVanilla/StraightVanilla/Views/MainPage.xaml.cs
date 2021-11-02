using StraightVanilla.Models;
using System;
using Xamarin.Forms;

namespace StraightVanilla.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnSampleTapped(object sender, ItemTappedEventArgs e)
        {
            SampleItem item = e.Item as SampleItem;
            if (item == null)
                return;

            await Navigation.PushAsync((Page)Activator.CreateInstance(item.PageType));

            // deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
