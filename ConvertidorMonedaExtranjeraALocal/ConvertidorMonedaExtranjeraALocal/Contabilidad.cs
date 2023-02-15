using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertidorMonedaExtranjeraALocal
{
    internal class Contabilidad
    {
        private string _DolarGananciaEstimada = "";
        private string _DolarBlue = "";
        private string _ValorRealChile = "";
        private string _ValorLimteChile = "";
        public string DolarGananciaEstimada
        {
            get { return _DolarGananciaEstimada; }
            set { _DolarGananciaEstimada = value; }
        }
        public string DolarBlue
        {
            get { return _DolarBlue; }
            set { _DolarBlue = value; }
        }
        public string ValorRealChile
        {
            get { return _ValorRealChile; }
            set { _ValorRealChile = value; }
        }
        public string ValorLimteChile
        {
            get { return _ValorLimteChile; }
            set { _ValorLimteChile = value; }
        }

        public void MostrarEnPantalla()
        {

            float dolarGE = float.Parse(DolarGananciaEstimada);
            float dolarBlue = float.Parse(DolarBlue);
            float valorRealChile = float.Parse(ValorRealChile);
            float valorLimiteChile = float.Parse(ValorLimteChile);

            float resultadoP = (valorLimiteChile * 100) / valorRealChile;
            float resultadoD = (resultadoP / 100) * dolarGE;
            resultadoP = resultadoD * dolarBlue;

            string respuesta = "Valor de Dolares a recibir reales: " + resultadoD + " USD \n\n" +
                "Valor de Dolares Reales convertidos a Pesos: " + resultadoP + " ARS";

            MessageBox.Show(respuesta);
        }

    }
}
