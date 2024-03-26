
namespace tipCalculator
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
        double valor = 0;
        double ValorRef = 0;
        double ValorTotal = 0;
        double porcentagem = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void Button15Percent_Clicked(object sender, EventArgs e)
        {
            PercentageSlider.Value = 15;
        }

        private void Button30percent_Clicked(object sender, EventArgs e)
        {
            PercentageSlider.Value = 30;
        }

        private void ButtonRoundUp_Clicked(object sender, EventArgs e)
        {
           double Calcular = CalculateTip();
            Calcular = Math.Ceiling(Calcular); 
            TipLabel.Text = Calcular.ToString();
            double valorRefeicao = Calcular + Convert.ToDouble(ValueEntry.Text);
            //chamar o método que calcula a gorjeta
            //armazenar esse valor em uma variável
            //exibir o valor da gorjeta arredondado para cima
            // exibir o valor total da refeição 
            valorTotal.Text = valorRefeicao.ToString();
            
        }

        private void ButtonRoundDown_Clicked(object sender, EventArgs e)
        {
            //exibir o valor da gorjeta arredondado para baixo
            
        }
        private double CalculateTip()
        {
            ValorRef = Convert.ToDouble(ValueEntry.Text);  
            porcentagem = Convert.ToDouble(PercentageSlider.Value);
            ValorTotal = ValorRef * (porcentagem/100);
            return ValorTotal;
            

        //pegar o valor da refeição
        //armazenar esse valor em uma variável
        // pegar o valor da porcentagem que o usuáio definiu no slider
        // calcular o valor da gorjeta


        }

        private void PercentageSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            TipPorcentagemLabel.Text = $"{PercentageSlider.Value.ToString()}%";
        }
    }

}
