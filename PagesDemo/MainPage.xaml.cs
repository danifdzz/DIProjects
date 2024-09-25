namespace PagesDemo
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContentPageDemo());
        }

        private void Button_Clicked_atras(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }

}
