using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace prueba2_JosueC_DanielT
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ValidadorCT" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ValidadorCT.svc o ValidadorCT.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ValidadorCT : IValidadorCT

    {

        public int Procesar(string ci)
        {
            int respuesta = Validar(ci);
            if (respuesta == 1)
            {
                char[] c = ci.ToCharArray();
                int[] vector = new int[9];
                vector[0] = Convert.ToInt32(c[0]);
                vector[1] = Convert.ToInt32(c[1]);
                vector[2] = Convert.ToInt32(c[2]);
                vector[3] = Convert.ToInt32(c[3]);
                vector[4] = Convert.ToInt32(c[4]);
                vector[5] = Convert.ToInt32(c[5]);
                vector[6] = Convert.ToInt32(c[6]);
                vector[7] = Convert.ToInt32(c[7]);
                vector[8] = Convert.ToInt32(c[8]);


                int suma_impares = 0;

                for (int i = 1; i <= 9; i = i + 2)
                {
                    vector[i] = 2 * vector[i];
                    if(vector[i] > 9)
                    {
                        vector[i]=vector[i]-9;
                    }
                    suma_impares = suma_impares + vector[1];
                    
                }


                int suma_pares = 0;

                for (int i = 0;i <= 9; i=i+2)
                {
                     suma_pares = suma_pares + vector[i];

                }

                int sumatotal = 0;
                sumatotal = suma_impares+suma_pares;


                int decena = 0;
                int ultimodigito = 0;

                if(sumatotal < 10)
                {
                    decena = 10;
                    ultimodigito = decena - sumatotal;

                }
                else if(sumatotal>10 && sumatotal<20)
                {
                    decena = 20;
                    ultimodigito = decena - sumatotal;
                }
                else if (sumatotal > 20 && sumatotal < 30)
                {
                    decena = 30;
                    ultimodigito = decena - sumatotal;
                }
                else if (sumatotal > 30 && sumatotal < 40)
                {
                    decena = 40;
                    ultimodigito = decena - sumatotal;
                }
                else if (sumatotal > 40 && sumatotal < 50)
                {
                    decena = 50;
                    ultimodigito = decena - sumatotal;
                }
                else if (sumatotal > 50 && sumatotal < 60)
                {
                    decena = 60;
                    ultimodigito = decena - sumatotal;
                }
                else if (sumatotal > 60 && sumatotal < 70)
                {
                    decena = 70;
                    ultimodigito = decena - sumatotal;
                }
                else if (sumatotal > 70 && sumatotal < 80)
                {
                    decena = 80;
                    ultimodigito = decena - sumatotal;
                }
                else if (sumatotal > 80 && sumatotal < 90)
                {
                    decena = 90;
                    ultimodigito = decena - sumatotal;
                }

                if(ultimodigito % 10 == 0)
                {
                    ultimodigito = 0;
                }




                return 0;


            }

            throw new NotImplementedException();
        }

        public string TransformarDigitoATexto(int digito)
        {
            throw new NotImplementedException();
        }

        public int Validar(string ci)
        {
            char[] c = ci.ToCharArray();

            if (c == null || c.Length != 10)
            {
                Console.WriteLine("No se ingreso valor correcto");
                return 0;
            }
            else 
            { return 1; }
                throw new NotImplementedException();
        }
    }
}
