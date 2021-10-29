using System;

using Xamarin.Forms;

namespace XamarinFormsNavigation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            NavigationManager.Initialize(Navigation);

            Title = "Main Page";
            Button toCommonPageBtn = new Button
            {
                Text = "На обычную страницу",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            toCommonPageBtn.Clicked += ToCommonPage;

            Button toModalPageBtn = new Button
            {
                Text = "На модальную страницу",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            toModalPageBtn.Clicked += ToModalPage;

            Button forwardButton = new Button { Text = "Вперед" };
            forwardButton.Clicked += GoToForward;
            Label stackLabel = new Label();

            Content = new StackLayout { Children = { forwardButton, stackLabel, toCommonPageBtn, toModalPageBtn } };
        }

        private void ToModalPage(object sender, EventArgs e)
        {
            var page = NavigationManager.Pages[PagesList.ModalPage];
            NavigationManager.Push(page, true);
        }
        private void ToCommonPage(object sender, EventArgs e)
        {
            var page = NavigationManager.Pages[PagesList.CommonPage];
            NavigationManager.Push(page);
        }

        private void GoToForward(object sender, EventArgs e)
        {
            var page = NavigationManager.Pages[PagesList.Page2];
            NavigationManager.Push(page, true);
        }
    }
}