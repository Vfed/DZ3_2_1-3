using System;

namespace DZ3_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool arrRangeCheck = false;
            int arrN = 0;
            do
            {
                Console.Write("Enter Array NxN size : ");
                arrRangeCheck = Int32.TryParse(Console.ReadLine(), out arrN);
                if (!arrRangeCheck)
                {
                    Console.WriteLine("Wrong Array enter; ");
                }
                if (arrN <= 0)
                {
                    arrRangeCheck = false;
                    Console.WriteLine("Wrong Array Size enter; ");
                }
            } while (!arrRangeCheck);

            int[,] array = new int[arrN, arrN];

            int chose = 0;
            bool choseCheck = false;
            do
            {
                Console.Write("Chose content (1 - t1/2 - t2 /3 - t3): ");
                choseCheck = Int32.TryParse(Console.ReadLine(), out chose);
                if (!choseCheck)
                {
                    Console.WriteLine("Wrong enter; ");
                }
                if (chose == 1 || chose == 2 || chose == 3)
                {
                    choseCheck = true;
                    Console.WriteLine("Wrong Chose enter; ");
                }
            } while (!choseCheck);

            switch (chose) {
                case 1: 
                    for (int i = 0; i < arrN; i++)
                    {
                        for (int j = 0; j < arrN; j++)
                        {
                            array[i, j] = 0;
                        }

                        int sum = 0;

                        if (i < (arrN / 2))
                            for (int j = 0 + i; j < arrN - i; j++)
                            {
                                array[i, j] = ++sum;
                            }
                        else
                        {
                            for (int j = (arrN - i -1); j <= i; j++)
                            {
                                array[i, j] = ++sum;
                            }
                        }
                    }
                    break;
                case 2:
                    for (int i = 0; i < arrN; i++)
                    {
                        for (int j = 0; j < arrN; j++)
                        {
                            if (i == 0 || j == 0 || i == (arrN - 1) || j == (arrN - 1))
                            {
                                array[i, j] = 1;
                            }
                            else
                            {
                                array[i, j] = 0;
                            }
                        }
                    }
                    break;
                case 3:
                    for (int i = 0; i < arrN; i++)
                    {
                        for (int j = 0; j < arrN; j++)
                        {
                            if (j == i || j == (arrN - i-1))
                            {
                                array[i, j] = 1;
                            }
                            else
                            {
                                array[i, j] = 0;
                            }
                        }
                    }
                    break;
                default:
                    break;
            }
            
            string tab = "-";
            for (int i = 0; i < arrN; i++)
            {
                tab += "--------";
            }

            Console.Clear();

            for (int i = 0; i < arrN; i++)
            {
                Console.WriteLine(tab);
                for (int j = 0; j < arrN; j++)
                {
                    Console.Write("|" + array[i, j] + "\t");
                }
                Console.WriteLine("|");
            }
            Console.WriteLine(tab);

            Console.ReadKey();


        }
    }
}
