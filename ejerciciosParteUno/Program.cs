using System;

namespace ejerciciosParteUno
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("1-) Ingresar por teclado 3 (tres) números. El primero y el último número serán el");
            Console.WriteLine("inicio y fin de un intervalo, dependiendo de cuál es mayor/menor. Finalmente, indicar");
            Console.WriteLine("si el segundo número se encuentra en ese rango determinado.");
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.Write("Ingrese el primer número: ");
            int unoPrimerNumero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int unoSegundoNumero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el tercer número: ");
            int unoTercerNumero = Convert.ToInt32(Console.ReadLine());

            if (unoTercerNumero > unoPrimerNumero)
            {
                Console.WriteLine("Intervalo del {0} al {1}", unoPrimerNumero, unoTercerNumero);
                if ((unoSegundoNumero >= unoPrimerNumero) && (unoSegundoNumero <= unoTercerNumero))
                {
                    Console.WriteLine("El número {0} se encuentra en ese rango", unoSegundoNumero);
                }
                else
                {
                    Console.WriteLine("El número {0} no se encuentra en ese rango", unoSegundoNumero);
                }
            }
            else
            {
                Console.WriteLine("Intervalo del {0} al {1}", unoTercerNumero, unoPrimerNumero);
                if ((unoSegundoNumero >= unoTercerNumero) && (unoSegundoNumero <= unoPrimerNumero))
                {
                    Console.WriteLine("El número {0} se encuentra en ese rango", unoSegundoNumero);
                }
                else
                {
                    Console.WriteLine("El número {0} no se encuentra en ese rango", unoSegundoNumero);
                }
            }
            // Fin Ejercicio 1
            Console.WriteLine("Siguiente ejercicio");
            Console.ReadLine();

            // Ejercicio 2
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("2-) Escribir un programa que tome un numero, pregunte si es en centímetros o en pulgadas");
            Console.WriteLine("y que realice la conversión a pulgadas, si es centímetro o viceversa.");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Conversión de medidas");
            Console.WriteLine("1- Centímetros a pulgadas");
            Console.WriteLine("2- Pulgadas a centímetros");
            Console.WriteLine("0- Salir");
            Console.WriteLine("");
            Console.Write("Eliga una opción: ");
            int dosOpcion = Convert.ToInt32(Console.ReadLine());
            while (dosOpcion != 0)
            {
                if (dosOpcion == 1)
                {
                    Console.WriteLine("Centímetros a pulgadas");
                    Console.Write("Ingrese el numero a convertir: ");
                    double numeroIngresado = Convert.ToDouble(Console.ReadLine());
                    double numeroConvertido = numeroIngresado / 2.54;
                    Console.WriteLine("{0} cm convertido a pulgadas es igual a {1} pulgadas", numeroIngresado, Math.Round(numeroConvertido, 4));
                    dosOpcion = 0;
                }
                else if (dosOpcion == 2)
                {
                    Console.WriteLine("Pulgadas a centímetros");
                    Console.Write("Ingrese el numero a convertir: ");
                    double numeroIngresado = Convert.ToDouble(Console.ReadLine());
                    double numeroConvertido = numeroIngresado * 2.54;
                    Console.WriteLine("{0} pulgadas convertido a centímetros es igual a {1} cm", numeroIngresado, Math.Round(numeroConvertido, 4));
                    Console.WriteLine(numeroConvertido);
                    dosOpcion = 0;
                }
                else
                {
                    Console.WriteLine("Opción no válida");
                    Console.Write("Eliga una opción: ");
                    dosOpcion = Convert.ToInt32(Console.ReadLine());
                }
            }
            // Fin Ejercicio 2
            Console.WriteLine("Siguiente ejercicio");
            Console.ReadLine();

            // Ejercicio 3
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("3-) Escribir un programa, parecido al anterior, pero que muestre la equivalencia entre al menos");
            Console.WriteLine("dos monedas extranjeras y el guaraní paraguayo. Lo dicho, se debe cargar un monto x por teclado en guaraníes");
            Console.WriteLine("y mostrar la equivalencia en las demás monedas que se haya seleccionado.");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Conversión de moneda");
            Console.WriteLine("1- Guaraníes a dolares");
            Console.WriteLine("2- Guaraníes a euros");
            Console.WriteLine("0- Salir");
            Console.WriteLine("");
            Console.Write("Eliga una opción: ");
            int tresOpcion = Convert.ToInt32(Console.ReadLine());
            while (tresOpcion != 0)
            {
                if (tresOpcion == 1)
                {
                    Console.WriteLine("Guaraníes a dolares");
                    Console.Write("Ingrese la cantidad de guaraníes: ");
                    double numeroIngresado = Convert.ToDouble(Console.ReadLine());
                    double numeroConvertido = numeroIngresado * 0.00015;
                    Console.WriteLine("{0} guaraníes equivale a {1} dolares", numeroIngresado, Math.Round(numeroConvertido, 4));
                    tresOpcion = 0;
                }
                else if (tresOpcion == 2)
                {
                    Console.WriteLine("Guaraníes a euros");
                    Console.Write("Ingrese la cantidad de guaraníes: ");
                    double numeroIngresado = Convert.ToDouble(Console.ReadLine());
                    double numeroConvertido = numeroIngresado * 0.00012;
                    Console.WriteLine("{0} guaraníes equivale a {1} euros", numeroIngresado, Math.Round(numeroConvertido, 4));
                    Console.WriteLine(numeroConvertido);
                    tresOpcion = 0;
                }
                else
                {
                    Console.WriteLine("Opción no válida");
                    Console.Write("Eliga una opción: ");
                    tresOpcion = Convert.ToInt32(Console.ReadLine());
                }
            }
            // Fin Ejercicio 3
            Console.WriteLine("Siguiente ejercicio");
            Console.ReadLine();

            // Ejercicio 4
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("4-) Ingresar una oración/frase de al menos 20 caracteres e indicar cuántas vocales hay.");
            Console.WriteLine("---------------------------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Ingrese una frase de al menos 20 caracteres: ");
            string cuatroFrase = Console.ReadLine();
            int cuatroContadorVocales = 0;
            while (cuatroFrase.Length < 20)
            {
                Console.WriteLine("La frase tiene menos de 20 caracteres");
                Console.WriteLine("Ingrese una frase de al menos 20 caracteres: ");
                cuatroFrase = Console.ReadLine();
            }

            for (int i = 0; i < cuatroFrase.Length; i++)
            {
                string caracter = cuatroFrase.Substring(i, 1);
                caracter = caracter.ToLower();
                if (caracter != " ")
                {
                    if (caracter == "a" || caracter == "e" || caracter == "i" || caracter == "o" || caracter == "u")
                    {
                        cuatroContadorVocales++;
                    }
                }
            }

            Console.WriteLine("Esta frase contiene {0} vocales", cuatroContadorVocales);

            // Fin Ejercicio 4
            Console.WriteLine("Siguiente ejercicio");
            Console.ReadLine();

            // Ejercicio 5
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("5-) Al ejercicio anterior agregarle el conteo de consonantes.");
            Console.WriteLine("Indicando además la cantidad total de caracteres que tiene la frase.");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Ingrese una frase: ");
            string cincoFrase = Console.ReadLine();
            int cincoContadorVocales = 0;
            int cincoContadorConsonantes = 0;
            int cincoCaracteres = 0;

            for (int i = 0; i < cincoFrase.Length; i++)
            {
                string caracter = cincoFrase.Substring(i, 1);
                caracter = caracter.ToLower();
                if (caracter != " ")
                {
                    if (caracter == "a" || caracter == "e" || caracter == "i" || caracter == "o" || caracter == "u")
                    {
                        cincoContadorVocales++;
                        cincoCaracteres++;
                    } else
                    {
                        cincoContadorConsonantes++;
                        cincoCaracteres++;
                    }
                }
            }

            Console.WriteLine("Esta frase contiene {0} vocales", cincoContadorVocales);
            Console.WriteLine("Esta frase contiene {0} consonantes", cincoContadorConsonantes);
            Console.WriteLine("Esta frase contiene {0} caracteres", cincoCaracteres);
            // Fin Ejercicio 5
            Console.ReadLine();
        }
    }
}
