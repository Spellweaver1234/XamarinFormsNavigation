using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3()
        {
            Title = "Page 3";
            Button backBtn = new Button { Text = "Назад" };
            backBtn.Clicked += GoToBack;

            Label stackLabel = new Label();
            Content = new StackLayout { Children = { backBtn, stackLabel } };
        }

        private void GoToBack(object sender, EventArgs e)
        {
            NavigationManager.Pop(true);
        }
    }
}