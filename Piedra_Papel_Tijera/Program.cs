using System;

namespace Piedra_Papel_Tijera
{
    class Program
    {
        static long puntos_Player1 = 0;
        static long puntos_Player2 = 0;
        static string Opcion_Maquina;
        static string Opcion_Jugador;
        static int intentos = 3;
        static string[] opciones;
        static string opcion;
        static void Main(string[] args)
        {
            Console.WriteLine("========Pierdra==Papel==Tigera============");
            Console.WriteLine("Piedra = pi // Papel = pe // Tiegra = ti");

            juego();
        }

        static void juego()
        {
            opciones = new string[] { "pi", "pa", "ti"};
            Random random = new Random();

            do
            {
                for (int i = 0; i < intentos; i++)
                {
                    Console.WriteLine("Jugaror1 : {0} <> Jugador2 : {1}", puntos_Player1, puntos_Player2);
                    Console.WriteLine("Selcione su jugada!!");
                    Opcion_Jugador = Console.ReadLine();

                    int aleatorio = random.Next(opciones.Length);
                    Opcion_Maquina = opciones[aleatorio];

                    Console.Clear();

                    Console.WriteLine("Jugador1 = {0}, Jugador2 = {1}", Opcion_Jugador, Opcion_Maquina);
                    if (Opcion_Jugador == Opcion_Maquina)
                    {
                        Console.WriteLine("Empate");
                        i -= 1;
                    }
                    else if (Opcion_Jugador == "pi" && Opcion_Maquina == "ti" ||
                             Opcion_Jugador == "ti" && Opcion_Maquina == "pa" ||
                             Opcion_Jugador == "pa" && Opcion_Maquina == "pi")
                    {
                        Console.WriteLine("Gano Jugador 1");
                        puntos_Player1 += 1;
                    }
                    else
                    {
                        Console.WriteLine("Gano Jugador 2");
                        puntos_Player2 += 1;
                    }
                }

                if (puntos_Player1 > puntos_Player2)
                {
                    Console.WriteLine("Jugador1 ES EL GANADOR!!, Puntuacion : {0} - {1}", puntos_Player1, puntos_Player2);
                }
                else if (puntos_Player1 == puntos_Player2)
                {
                    Console.WriteLine("A SIDO UN EMPATE!!!");
                }
                else
                {
                    Console.WriteLine("Jugador2 ES EL GANADOR!!, Puntuacion : {0} - {1}", puntos_Player2, puntos_Player1);
                }

                Console.WriteLine("Volver a jugar: si / no");
                opcion = Console.ReadLine();
            } while (opcion == "si");
        }
    }
}
