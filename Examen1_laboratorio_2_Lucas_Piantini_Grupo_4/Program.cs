using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_laboratorio_2_Lucas_Piantini_Grupo_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string opcion2;
            int camisas = 0;
            int descuento = 0;
            double precio_con_descuento = 0;
            try {
                    do
                    {
                        Console.WriteLine("Camisas PRADBIT - ventas minoristas y mayoristas");
                        Console.WriteLine("____________________________________________________________");
                        Console.WriteLine("1- Añadir camisa al carro de compras");
                        Console.WriteLine("2- Eliminar camisa del carro de compras");
                        Console.WriteLine("3- Salir");
                        Console.WriteLine("____________________________________________________________ ");
                        Console.WriteLine("- Cantidad de camisas en el carro de compras: " + camisas);
                        Console.WriteLine("- Precio unitario: $1000");
                        double precio_sin_descuento = camisas * 1000;
                        Console.WriteLine("- Precio total sin descuento:" + precio_sin_descuento);

                        Console.WriteLine("- Tipo de descuento aplicado:" + descuento + "%");

                        Console.WriteLine("- Precio final con descuento:" + precio_con_descuento);
                        Console.WriteLine("______________________________________________________________");
                        Console.WriteLine("Ingrese una opción del menú");

                        opcion = Convert.ToInt32(Console.ReadLine());

                        switch (opcion)
                        {
                            case 1:
                                camisas = camisas + 1;
                                break;

                            case 2:
                                camisas = camisas - 1;
                                break;
                            case 3:
                            Console.WriteLine("“¿Está seguro que desea salir? S/N”.");
                            opcion2 = Convert.ToString(Console.ReadLine());
                            if (opcion2 == "s")
                            {
                                break;
                            }
                            else {
                                opcion = 4;
                            }
                            break;
                        default:
                                Console.WriteLine("Usted eligio una opcion invalida");
                                break;
                        }
                        if (camisas >= 3 && camisas <= 5)
                        {
                            descuento = 10;
                            double cuenta_descuento = precio_sin_descuento * 0.10;
                            precio_con_descuento = precio_sin_descuento - cuenta_descuento;
                        }
                        if (camisas > 5)
                        {
                            descuento = 20;
                            double cuenta_descuento = precio_sin_descuento * 0.20;
                            precio_con_descuento = precio_sin_descuento - cuenta_descuento;
                        }
                        Console.Clear();
                    }
                   
                    while (opcion != 3);
              
            }
            catch(Exception error) { 
             
            Console.WriteLine("Ocurrio un error inesperado : " + error.Message);
                Console.ReadKey();
        }
            }
        
    }
}

            
            
        
    
