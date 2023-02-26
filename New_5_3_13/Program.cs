using System.Xml;

namespace New_5_3_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = GetArrayFromConsole();
            SortArray(in arr, out int[] sorteddesc, out int[] sortedasc);
            
            Console.Write("Сортировка по убыванию: ");
            foreach (int i in sorteddesc)
            {
                Console.Write(i + " ");
            }
            
            Console.Write("\nСортировка по возрастанию: ");
            foreach (int i in sortedasc)
            {
                Console.Write(i + " ");
            }
        }
        static void SortArray(in int [] array, out int[] sorteddesc, out int[] sortedasc)
        {
            
            sortedasc = SortArrayAsc(array);
            sorteddesc = SortArrayDesc(array);
        }
        static int[] GetArrayFromConsole(int Num = 0)
        {
            Console.WriteLine("Введите количество чисел для сортировки: ");
            Num = int.Parse(Console.ReadLine());
            var result = new int[Num];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());

            }
            return result;
        }
        static int[] SortArrayAsc(int[] arr) //Сортировка по возрастанию
        {
            
            int num;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        num = arr[i];
                        arr[i] = arr[j];
                        arr[j] = num;
                    }
                }

            }
            return arr;

        }
        static int[] SortArrayDesc(int[] arr) // Сортировка по убыванию
        {
            
            int num;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        num = arr[i];
                        arr[i] = arr[j];
                        arr[j] = num;
                    }
                }

            }
            return arr;
        }
    }
}