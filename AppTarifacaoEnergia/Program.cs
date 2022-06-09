using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTarifacaoEnergia
{
    class Program
    {
        static double bandeiraVerde = 0;
        static double bandeiraAmarela = 0.01874;
        static double bandeiraVermelha = 0.03971;
        static double bandeiraVermelha2 = 0.09492;
        static double bandeiraEscHidrica = 0.14200;

        static void Main(string[] args)
        {
            double consumo = 0;
            int opMenu = 1;
            while (opMenu != 0)
            {
                Console.WriteLine("Informe o nome do componente/aparelho:");
                Console.WriteLine("1-Chuveiro");
                Console.WriteLine("2-Liquidificador");
                Console.WriteLine("3-Geladeira");
                Console.WriteLine("4-Lavadora");
                Console.WriteLine("5-Cafeteira");
                Console.WriteLine("6-Sair");
                opMenu = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Informe o consumo do componente/aparelho em quilowatt-hora, KWh:");
                opMenu = consumo(Console.ReadLine());

                Console.WriteLine("Informe a quantidade de horas diárias de uso do componente/aparelho:");
                opMenu = Int32.Parse(Console.ReadLine());

                Console.Clear();
                Console.WriteLine("Escolha uma opção de bandeira para calcular");
                Console.WriteLine("1-Verde");
                Console.WriteLine("2-Amarela");
                Console.WriteLine("3-Vermelha");
                Console.WriteLine("4-Vermelha2");
                Console.WriteLine("5-Escassez");
                Console.WriteLine("6-Sair");
                opMenu = Int32.Parse(Console.ReadLine());

                switch (opMenu)
                {
                    case 0:
                        break;
                    case 1:
                        consumo = Verde(consumo);
                        break;
                    case 2:
                        consumo = Amarela(consumo);
                        break;
                    case 3:
                        consumo = Vermelha(consumo);
                        break;
                    case 4:
                        consumo = Vermelha2(consumo);
                        break;
                    case 5:
                        consumo = Escassez(consumo);
                        break;
                    default:
                        Console.WriteLine("Opção Inválida");
                        Console.ReadKey();
                        break;
                }

                if (opMenu == 1)
                {
                    Console.WriteLine("O seu consumo total foi: " + consumo * bandeiraVerde);
                    Console.ReadKey();
                    return consumo;
                }
                else if (opMenu == 2)
                {
                    Console.WriteLine("O seu consumo total foi: " + consumo * bandeiraAmarela);
                    Console.ReadKey();
                    return consumo;
                }
                else if (opMenu == 3)
                {
                    Console.WriteLine("O seu consumo total foi: " + consumo * bandeiraVermelha);
                    Console.ReadKey();
                    return consumo;
                }
                else if (opMenu == 4)
                {
                    Console.WriteLine("O seu consumo total foi: " + consumo * bandeiraVermelha2);
                    Console.ReadKey();
                    return consumo;
                }
                else if (opMenu == 5)
                {
                    Console.WriteLine("O seu consumo total foi: " + consumo * bandeiraEscHidrica);
                    Console.ReadKey();
                    return consumo;
                }
                else if (opMenu == 0)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Opção Inválida");
                }


            

            }
        }
    }
}
