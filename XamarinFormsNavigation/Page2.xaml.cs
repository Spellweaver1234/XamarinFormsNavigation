using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            Title = "Page 2";
            Button forwardBtn = new Button { Text = "Вперед" };
            forwardBtn.Clicked += GoToForward;

            Button backBtn = new Button { Text = "Назад" };
            backBtn.Clicked += GoToBack;

            Label stackLabel = new Label();
            Content = new StackLayout { Children = { forwardBtn, backBtn, stackLabel } };
        }
        private void GoToForward(object sender, EventArgs e)
        {
            var page = NavigationManager.Pages[PagesList.Page3];
            NavigationManager.Push(page, true);
        }

        private void GoToBack(object sender, EventArgs e)
        {
            NavigationManager.Pop(true);
        }
    }
}