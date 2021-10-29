using System;

using Xamarin.Forms;

namespace XamarinFormsNavigation
{
    public class CommonPage : ContentPage
    {
        public CommonPage()
        {
            Title = "Common Page";
            Button backButton = new Button
            {
                Text = "Назад",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
            backButton.Clicked += BackButton_Click;
            Content = backButton;
        }
        private async void BackButton_Click(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}