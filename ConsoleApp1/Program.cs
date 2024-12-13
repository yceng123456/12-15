using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void MyHomeWork01()
        {
            int[] intArray = new int[10];  
            float[] floatArray = new float[8]; 
            double[] doubleArray = new double[4]; 
            string[] stringArray = new string[5]; 

            Console.WriteLine("請輸入10個整數:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"請輸入第{i + 1}個整數: ");
                intArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("整數陣列: " + string.Join(", ", intArray));
            Console.WriteLine("整數陣列平均值: " + (intArray.Sum() / (float)intArray.Length));

            Console.WriteLine("\n請輸入8個浮點數:");
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"請輸入第{i + 1}個浮點數: ");
                floatArray[i] = float.Parse(Console.ReadLine());
            }
            Console.WriteLine("浮點數陣列: " + string.Join(", ", floatArray));
            Console.WriteLine("浮點數陣列平均值: " + (floatArray.Average()));

            Console.WriteLine("\n請輸入4個倍精確度數:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"請輸入第{i + 1}個倍精確度數: ");
                doubleArray[i] = double.Parse(Console.ReadLine());
            }
            Console.WriteLine("倍精確度數陣列: " + string.Join(", ", doubleArray));
            Console.WriteLine("倍精確度數陣列平均值: " + (doubleArray.Average()));

            Console.WriteLine("\n請輸入5個字串:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"請輸入第{i + 1}個字串: ");
                stringArray[i] = Console.ReadLine();
            }
            Console.WriteLine("字串陣列: " + string.Join(", ", stringArray));
        }

        static void MyHomeWork02()
        {
            int[] intArray = { 1, 2, 3, 4, 5 }; 
            float[] floatArray = { 1.2f, 2.3f, 3.4f, 4.5f, 5.6f };  
            double[] doubleArray = { 1.22, 2.33, 3.44, 4.55, 5.66 }; 
            string[] stringArray = { "王小明", "陳大明", "李小英", "張小美", "陳不良" }; 

            Console.WriteLine("整數陣列: " + string.Join(", ", intArray));
            Console.WriteLine("整數陣列平均值: " + (intArray.Average()));

            Console.WriteLine("\n浮點數陣列: " + string.Join(", ", floatArray));
            Console.WriteLine("浮點數陣列平均值: " + (floatArray.Average()));

            Console.WriteLine("\n倍精確度數陣列: " + string.Join(", ", doubleArray));
            Console.WriteLine("倍精確度數陣列平均值: " + (doubleArray.Average()));

            Console.WriteLine("\n字串陣列: " + string.Join(", ", stringArray));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("請選擇執行第1,2題還是第3,4題 (輸入1或2): ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                MyHomeWork01(); 
            }
            else if (choice == "2")
            {
                MyHomeWork02(); 
            }
            else
            {
                Console.WriteLine("無效的選擇！");
            }
        }
    }
}
