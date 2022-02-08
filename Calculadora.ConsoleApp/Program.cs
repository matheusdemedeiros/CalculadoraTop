using System;

namespace Calculadora.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Top 1.0 - Não lembro a versao que era...");
            string option, optionRepeat = "";
            decimal result;
            do
            {
                //Exibição do menu principal
                Console.WriteLine("\n===============================");
                Console.WriteLine("Escolha uma das opcoes abaixo:");
                Console.WriteLine("Digite 1 para somar;");
                Console.WriteLine("Digite 2 para subtrair;");
                Console.WriteLine("Digite 3 para multiplicar;");
                Console.WriteLine("Digite 4 para dividir;");
                Console.WriteLine("Digite s para sair;");
                Console.Write("Sua escolha: ");
                option = Console.ReadLine();
                if (option == "1" || option == "2" || option == "3" || option == "4" || option == "s" || option == "S")
                {
                    optionRepeat = "valid";
                }
                else
                {
                    Console.WriteLine("Opcao invalida, escolha uma das opcoes!!");
                    continue;

                }

                if (option == "s" || option == "S")
                {
                    Console.WriteLine("\nVoce escolheu sair, a calc!!");
                    break;
                }
                else
                {
                    optionRepeat = "valid";
                    Console.WriteLine("\n===============================");
                    Console.Write("\nInforme o primeiro valor: ");

                    string strValue1 = Console.ReadLine();
                    bool isNumeric = decimal.TryParse($"{strValue1}", out decimal v1);

                    if (isNumeric == false)
                    {
                        Console.WriteLine("\nEntrada invalida!!");
                        //v1 = decimal.Parse(Console.ReadLine());
                        continue;
                    }
                    Console.Write("\nInforme o segundo valor: ");
                    string strValue2 = Console.ReadLine();
                    isNumeric = decimal.TryParse($"{strValue2}", out decimal v2);
                    if (isNumeric == false)
                    {
                        Console.WriteLine("\nEntrada invalida!!");
                        continue;
                    }
                    if (option == "1")
                    {
                        optionRepeat = "valid";

                        result = v1 + v2;
                        Console.WriteLine("\nSOMA: " + result);
                    }
                    else if (option == "2")
                    {
                        optionRepeat = "\nvalid";
                        result = v1 - v2;
                        Console.WriteLine("\nSUBTRACAO: " + result);
                    }
                    else if (option == "3")
                    {
                        optionRepeat = "valid";
                        result = v1 * v2;
                        Console.WriteLine("\nMULTIPLICACAO: " + result);
                    }
                    else if (option == "4")
                    {
                        optionRepeat = "valid";
                        if (v2 != 0)
                        {
                            result = v1 / v2;
                            Console.WriteLine("\nDIVISAO: " + Math.Round(result, 2));
                        }
                        else
                        {
                            Console.WriteLine("\nNAO PODEMOS REALIZAR DIVISOES POR ZERO!!");
                            continue;
                        }
                    }
                }
            } while (optionRepeat != "invalid");
        }
    }
}
