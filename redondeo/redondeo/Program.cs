using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace redondeo
{
    class Program
    {

        //static void Main(string[] args)
        //{
        //    segundaFuncion();

        //}

        static void Main(string[] args)
        {

            //int p = 0;
            
            int a = 1, valor2;
            string valor = "";
            Int32 unidad = 1000;
            string misCeros = "1";
            int restaLongitud = 1;
            while (a != -1)
            {
                
                try
                {
                    Console.Write("Introduzca un número2: ");
                    a = Convert.ToInt32(Console.ReadLine()  + "\n");
                    int longitud = Convert.ToString(a).Length;
                    valor = Convert.ToString(a).Substring(1, a.ToString ().Length -1);                                    

/*
                    valor2 = Convert.ToInt32(Convert.ToString(a).Substring(longitud - 3, 1));
                    Console.WriteLine("digito leido = " + valor2.ToString());
                    */

                    switch (longitud) {     
                        //case 1:
                        //case 2: unidad = -1; break;
                        //case 3: unidad = 100; break;
                        //case 4:
                        //case 5: unidad = 1000; break;
                        //case 6:
                        //case 7: unidad = 10000; break;
                        //case 8: unidad = 100000; break;
                        //case 9: 
                        //default: unidad = 1; break;


                        case 1:
                        case 2: unidad = -1; break;
                        case 3: unidad = 100; valor = Convert.ToString(a).Substring(1, 1); break;
                        case 4: unidad = 100; valor = Convert.ToString(a).Substring(2, 1); break;
                        case 5: unidad = 1000; valor = Convert.ToString(a).Substring(2, 1); break;
                        case 6: unidad = 10000; valor = Convert.ToString(a).Substring(2, 1); break;
                        case 7: unidad = 100000; valor = Convert.ToString(a).Substring(2, 1); break;
                        case 8: unidad = 100000; valor = Convert.ToString(a).Substring(3, 1); break;
                        default: unidad = 1; break;
                    }

                    // Convert.ToString(a).Substring(2,1); Substring(a,b); a posicion del digito b cantida de digitos apartir de la posicion

                    if (unidad != -1 && a > 0)
                    {
                        //Console.WriteLine("Nuevo valor MRound =  " + (Math.Round((a * 1d / unidad), 1) * unidad).ToString());

                        if (Convert.ToInt32(valor) >= 5)
                        {
                            int b = (int)Math.Ceiling(a / (unidad * 1d)) * unidad;

                            Console.WriteLine("redondeo arriba: " + b + "\n");
                        }
                        else
                        {

                            int c = (int)Math.Floor(a / (unidad * 1d)) * unidad;

                            Console.WriteLine("redondeo abajo: " + c + "\n");
                        }

                        //continue;
                    }
                    else {
                        Console.WriteLine("Introduzca numero positivos mayor a 2 digitos:  \n");
                    }

      

                    /*
                    if (valor2 >= 5)
                    {
                        int b = (int)Math.Ceiling(a / (unidad * 1d)) * unidad;

                        Console.WriteLine("redondeo arriba: " + b + "\n");
                    }
                    else
                    {

                        int c = (int)Math.Floor(a / (unidad * 1d)) * unidad;

                        Console.WriteLine("redondeo abajo: " + c + "\n");
                    }

                    continue; 

                    ////
                    int bA = (int)Math.Ceiling(a / (100000 * 1d)) * 100000;

                    Console.WriteLine("redondeo arriba: " + bA + "\n");
                    continue;

                    if( (longitud == 4 ) || (longitud == 5)) {
                        restaLongitud = 4;
                        valor2 = Convert.ToInt32(Convert.ToString(a).Substring(1, 1));
                    }
                    else {
                        restaLongitud = longitud-1;
                        valor2 = Convert.ToInt32(Convert.ToString(valor).Substring(1, 1));
                    }

                    unidad = Convert.ToInt32(misCeros.PadRight(restaLongitud, '0').ToString());

                    //if (longitud <= 4)
                    //{
                    
                        //valor2 = Convert.ToInt32(valor);
                    Console.WriteLine("digito leido = " + valor2.ToString());
                        if (valor2 >= 5)
                        {
                            int b = (int)Math.Ceiling(a / (unidad * 1d)) * unidad;

                            Console.WriteLine("redondeo arriba: " + b + "\n");
                        }
                        else
                        {

                            int c = (int)Math.Floor(a / (unidad * 1d)) * unidad;

                            Console.WriteLine("redondeo abajo: " + c + "\n");
                        }

                    */

                    //}
                    //else {
                    //    Console.WriteLine("No entro en el ciclo if: " + longitud + "\n");
                    //}
                    
                    
                    //else if (longitud == 3 && Convert.ToInt32(valor) > 4)
                    //{

                    //    int b = (int)Math.Ceiling(a / 1000d) * 10000;

                    //    Console.WriteLine("redondeo arriba: " + b + "\n");

                    //}
                    //else if ((longitud == 5) && (Convert.ToInt32(valor) < 5))
                    //{

                    //    int c = (int)Math.Floor(a / 10000d) * 1000;

                    //    Console.WriteLine("redondeo abajo: " + c + "\n");

                    //}
                    //else if ((longitud == 5) && (Convert.ToInt32(valor) > 4))
                    //{

                    //    int b = (int)Math.Ceiling(a / 10000d) * 10000;

                    //    Console.WriteLine("redondeo arriba: " + b + "\n");

                    //}
                    //else if ((longitud == 6) && (Convert.ToInt32(valor) <= 5))
                    //{

                    //    int c = (int)Math.Floor(a / 100000d) * 1000;

                    //    Console.WriteLine("redondeo abajo #6: " + c + "\n");

                    //}
                    //else if ((longitud == 6) && (Convert.ToInt32(valor) >= 4))
                    //{

                    //    int b = (int)Math.Ceiling(a / 100000d) * 10000;

                    //    Console.WriteLine("redondeo arriba #6: " + b + "\n");

                    //}
                    //else if ((longitud == 7) && (Convert.ToInt32(valor) < 5))
                    //{

                    //    int c = (int)Math.Floor(a / 1000000d) * 1000;

                    //    Console.WriteLine("redondeo abajo: " + c + "\n");

                    //}
                    //else if ((longitud == 7) && (Convert.ToInt32(valor) > 4))
                    //{

                    //    int b = (int)Math.Ceiling(a / 1000000d) * 10000;

                    //    Console.WriteLine("redondeo arriba: " + b + "\n");

                    //}
                    //else if ((longitud == 8) && (Convert.ToInt32(valor) < 5))
                    //{

                    //    int c = (int)Math.Floor(a / 10000000d) * 1000;

                    //    Console.WriteLine("redondeo abajo: " + c + "\n");

                    //}
                    //else if ((longitud == 8) && (Convert.ToInt32(valor) > 4))
                    //{

                    //    int b = (int)Math.Ceiling(a / 10000000d) * 10000;

                    //    Console.WriteLine("redondeo arriba: " + b + "\n");

                    //}

                    

                }
                catch (Exception ex)
                {

                }
            }


        }
    }
}
