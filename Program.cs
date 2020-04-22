using System;

namespace _net_core
{
    class Program
    {
        //se crea los valores del triangulo de pascal y luego se llena la matriz de 10 * 10.
        static void PascalTriangle(int n)
        {
            Program obj = new Program();
            int[,] MatrizTrianguloPascal = new int[10, 10];
            int filas = 0; int columnas = 0;
            for (int line = 1; line <= n; line++)
            {
                int c = 1;
                for (int i = 1; i <= line; i++)
                {
                    Console.WriteLine(c);
                    MatrizTrianguloPascal[filas, columnas] = c;
                    c = c * (line - i) / i;

                    columnas += 1;
                    if (i == line)
                    {
                        columnas = 0;
                        Console.WriteLine("\n");
                        if (line == n)
                        {
                            obj.showMatriz(MatrizTrianguloPascal, "--------Matriz de 10 por 10 tringulo de pascal!--------");
                        }
                    }
                }
                filas += 1;
            }

        }
        public void matrizNewRandon()
        {
            Program obj = new Program();
            int[,] matrizRandon = new int[10, 10];
            for (int filas = 0; filas <= 9; filas++)
            {
                for (int columnas = 0; columnas <= 9; columnas++)
                {
                    Random rnd = new Random();
                    var value = rnd.Next(10, 80);
                    matrizRandon[filas, columnas] = value;
                }

            }

            obj.showMatriz(matrizRandon, "--------Matriz aleatoria!--------");
            obj.sumaDiagonalesMatriz(matrizRandon);
        }



        public void sumaDiagonalesMatriz(int[,] matriz)
        {

            int[,] matrizDiagonalUno = new int[10, 10];
            int[,] matrizDiagonalDos = new int[10, 10];
            int sumaUno = 0;
            int sumaDos = 0;
            Program obj = new Program();
            int y = 9;
            for (int x = 0; x <= 9; x++)
            {
                matrizDiagonalUno[x, x] = matriz[x, x];
                matrizDiagonalUno[x, y] = matriz[x, y];
                sumaUno += matriz[x, x];
                sumaDos += matriz[x, y];
                y -= 1;
            }

            obj.showMatriz(matrizDiagonalUno, "--------Diagonales!--------");
            Console.WriteLine("suma-uno=" + sumaUno + "Suma-dos=" + sumaDos);

        }

        public void showMatriz(int[,] matriz, string title)
        {
            Console.WriteLine(title);
            Console.WriteLine("\n");
            for (int filas = 0; filas <= 9; filas++)
            {
                for (int columnas = 0; columnas <= 9; columnas++)
                {
                    Console.Write("|" + matriz[filas, columnas]);
                }
                Console.WriteLine("\n");
            }
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            PascalTriangle(10);
            obj.matrizNewRandon();
        }
    }
}
