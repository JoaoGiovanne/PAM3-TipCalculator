namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button15Percent_Clicked(object sender, EventArgs e)
        {

        }

        private void Button30Percent_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonRoundUp_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonRoundDowm_Clicked(object sender, EventArgs e)
        {

        }

        private void PorcentageSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            TipPorcentagemLabel.Text = $"{PorcentageSlider.Value.ToString()}%";
        }
    }

}
