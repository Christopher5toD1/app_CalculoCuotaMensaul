namespace columnas_texto
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }





        private void btnCalcular_Click(object sender, EventArgs e)
        {



            //Declaracion de variables 
            double TasaInteresMensual;
            double TasaInteresAnual;
            int Tiempo;
            double MontoPrestamo;
            double Cuotas;
            double Calculo;

            /*
             asignacion de las variables a las cajas de texto y sus respectivos 
            coversion 
             
             */

            TasaInteresAnual = Convert.ToDouble(TxTInteresAnual.Text);
            Tiempo = Convert.ToInt32(TxTTiempoMeses.Text);
            MontoPrestamo = Convert.ToDouble(TxTMontoPrestamo.Text);

            // Calculo de Interes Mesual 
            TasaInteresMensual = (TasaInteresAnual / 12) / 100;
            //asignar a la caja de texto y sus conversion
            TxTTasaInteresMesual.Text = TasaInteresMensual.ToString();
            // calculo de las cuotas
            Calculo = (1 - Math.Pow(1 + TasaInteresMensual, Tiempo * -1)) / TasaInteresMensual;
            // Calculos de Cuotas 
            Cuotas = MontoPrestamo / Calculo;
            // Asingar a la caja de texto a cuotas
            TxTPagoCuotas.Text = Cuotas.ToString();

            // Declaracion de variables



            double interes = 0;
            double tineres = 0;
            double tcuotas = 0;
            double saldoincial = 0;
            double saldofinal = MontoPrestamo;
            double abonocapital = 0;
            // crea un bucle for para hacer un recorrido y asignar las cuotas  y los intereses generados al pago del prestamo

            for (int i = 1; i < Tiempo + 1; i++)
            {
                // calculo de los interes aplicado al mes 
                interes = Math.Round(saldofinal * TasaInteresMensual, 2);
                // acumulacion de los intereses 
                tineres += interes;
                // saldo incial lo igualaremos a saldo final
                saldoincial = saldofinal;
                // calcular el capital a pagar 
                MontoPrestamo = Math.Round(Cuotas - interes, 2);
                abonocapital += MontoPrestamo;
                saldofinal -= MontoPrestamo;
                tcuotas += Cuotas;

               



                // agregar los  datos en el datagriview
                Cuadro.Rows.Add (i.ToString(),Cuotas,interes,saldoincial,saldofinal,MontoPrestamo);
              





            }

        }
    }
}
