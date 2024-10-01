namespace MauiTest
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            //this.BackgroundColor = null; // not working
            this.ClearValue(View.BackgroundColorProperty); //this works
            labelTest.ClearValue(Label.BackgroundColorProperty); //this DON'T work
            //labelTest.BackgroundColor = null; //this DON'T work either
        }
    }

}
