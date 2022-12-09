using System;   //using宣言

namespace CCharpStudentStudy    //名前空間
{
    /// <summary>
    /// エントリポイントとなるクラス
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// エントリポイントメソッド
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //HelloWorld!   これはコメントです
            Console.WriteLine("HelloWorld");   //文


            //===================================================
            //ここから各チャプターのプログラムを書いていこう！
            //===================================================
            Chapter1Introduction chapter1 = new Chapter1Introduction();
            chapter1.Main();
        }
    }
}