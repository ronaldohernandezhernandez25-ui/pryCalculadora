using System;
using System.Collections.Generic;
using System.Text;

namespace pryCalculadora
{
    internal class clsCalculadora
    {
        //atributos de entrada
        private float numero1;
        private float numero2;
        private string mensaje = "no hace nada";
        private string mensaje2 = "no hace nada 2";
        private string mensaje3 = "no hace nada 3";

        //atributo de salida
        private float Resultado;

        public float Numero1 { get => numero1; set => numero1 = value; }
        public float Numero2 { get => numero2; set => numero2 = value; }

        //uso de propiedades

        //metodos
        public float Sumar()
        {
            Resultado = Numero1 + Numero2;
            return Resultado;
        }
        
    }
}
