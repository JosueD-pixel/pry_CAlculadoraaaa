using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace pry_CAlculadoraaaa
{
    internal class clsCalculadoracs
    {
        //datos de entrada
        private float Numero1;
        private float Numero2;

        //datos de salida
        private float resultado;

        //Constructor
        public clsCalculadoracs(float N1, float N2)
        {
            this.Numero1 = N1;
            this.Numero2 = N2;  
        }

        //metodo para sumar
        public float sumar()
        {
            resultado = Numero1 + Numero2;
            return resultado;
        }
        //metodo para restar
        public float restar()
        {
            resultado = Numero1 - Numero2;
            return resultado;
        }
        //metodo para multiplicar
        public float multiplicar()
        {
            resultado = Numero1 * Numero2;
            return resultado;
        }
        //metodo para dividir
        public float dividir()
        {
            resultado = Numero1 / Numero2;
            return resultado;
        }
    }
}
