using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinFormsNavigation
{
    static class NavigationManager
    {
        private static INavigation _navigation;

        public static Dictionary<PagesList, Page> Pages { get; set; }

        public static void Initialize(INavigation navigation)
        {
            _navigation = navigation;
            Pages = new Dictionary<PagesList, Page>();
            Pages.Add(PagesList.CommonPage, new CommonPage());
            Pages.Add(PagesList.ModalPage, new ModalPage());
            Pages.Add(PagesList.Page2, new Page2());
            Pages.Add(PagesList.Page3, new Page3());
        }

        public static async void Push(Page page, bool isModal = false, bool animated = true)
        {
            if (isModal)
                await _navigation.PushModalAsync(page, animated);
            else
                await _navigation.PushAsync(page, animated);
        }

        public static async void Pop(bool isModal = false)
        {
            if (isModal)
                await _navigation.PopModalAsync();
            else
                await _navigation.PopAsync();
        }
    }

    public enum PagesList
    {
        ModalPage,
        CommonPage,
        Page2,
        Page3,
    }
}