namespace ICM_AGS
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
            double peso = Convert.ToDouble(inputPeso.Text);
            double altura = Convert.ToDouble(inputAltura.Text);
            double imc = peso/Math.Pow(altura,2);
            
            if (double.IsNaN(imc))
            {
                lbICM.Text = "Ha ingresado mal los datos";
                return;
            }

            if(imc < 18.5)
            {
                lbICM.Text = "Está desnutrido";
                return;
            }

            if (imc >= 18.5 && imc < 25)
            {
                lbICM.Text = "Su IMC es normal";
                return;
            }

            if (imc >= 25 && imc < 30)
            {
                lbICM.Text = "Tiene sobre peso";
                return;
            }

            if (imc >= 30)
            {
                lbICM.Text = "Está obeso";
                return;
            }
        }
    }

}
