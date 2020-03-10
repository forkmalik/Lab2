using System.Numerics;
using System;

namespace Lab2
{
    class Arr{
        protected int m;
        protected int n;
        public virtual void input(){

        }
    }
    class Matr : Arr{
        public override void input() {
            Console.Write("Введите размер матрици...");
            Console.WriteLine();
            n = int.Parse(Console.ReadLine());
            m = int.Parse(Console.ReadLine());
            int [,] matrix = new int [n, m];
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++){
                string enteredSt = Console.ReadLine();
                string [] stringArr = enteredSt.Split(new Char[] { ' ' });
                for(int j = 0; j < stringArr.Length; j++){
                    matrix[i, j] = int.Parse(stringArr[j]);
                }
            }
            // Console.Write("Matrix is...");
           // for(int i = 0; i < n; i++) {
             //   for(int j = 0; j < m; j++){
               //     Console.Write(matrix[i, j]);
                 //   Console.WriteLine();
                //}
            //}
        }

    }
    class Vect : Arr {
        public override void input () {
            
            int [] vectorik = new int [n];
            Console.Write("Введите вектор...");
            int i = 0;
            while(i < n) {
                vectorik [i] = int.Parse(Console.ReadLine());
                i++;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Matr a = new Matr();
            a.input();
            Vect b = new Vect();
            b.input();
        }
    }
}
