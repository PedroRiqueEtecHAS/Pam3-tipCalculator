namespace tipCalculator
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

        private void Button30percent_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonRoundUp_Clicked(object sender, EventArgs e)
        {

        }

        private void ButtonRoundDown_Clicked(object sender, EventArgs e)
        {

        }

        private void PercentageSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            TipPorcentagemLabel.Text = $"{PercentageSlider.Value.ToString()}%";
        }
    }

}
