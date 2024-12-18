using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temp99
{
    class Algoritm
    {
        public static Random random = new Random();

        public static void FisherYatesShuffle(int[] intArr)
        {
            //셔플 알고리즘
            for (int i = intArr.Length - 1; i > 0; i--)
                //인덱스 역순
            {
                int j = random.Next(0, i);

                int temp = intArr[i]; //i번째꺼 임시로 temp에 담고
                intArr[i] = intArr[j];//j꺼를 i에 넣고
                intArr[j] = temp;//temp를 j에 넣고
            }
        }
        
        public static void BubbleSort(int[] array)
        {
            //배열을 반복하면서 인접한 두 값을 비교한다.
            //두 값이 크기순서에 맞지 않으면 위치를 스왑한다.
            //배열 끝까지 비교를 마치고, 위 과정을 반복합니다.
            
            for (int i=0; i<array.Length-1; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] >  array[j+1])
                    {
                        int temp = array[j];
                        array[j] = array[j+1];
                        array[j+1] = temp;
                    }
                }
            }
        }
        public static void SelectionSort(int[] array)
        {
            //선택정렬
            //매 단계마다 배열에서 가장 작은거 찾아서
            //배열 맨 앞에 가져다 두는 식으로 작동
            for(int i = 0; i < array.Length -1; i++)
            {
                int minIndx = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minIndx]) //최소보다 작으면
                    {
                        minIndx = j; //인덱스 스왑
                    }
                }
                int temp = array[minIndx];
                array[minIndx] = array[i];
                array[i] = temp;
            }
        }          
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 1, 2, 3, 4, 5,6,7,8,9,10,11,12 };
            
            //foreach (var a in numbers)
            //{
            //    Console.Write(a+"  ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
            //Algoritm.FisherYatesShuffle(numbers);
            //foreach (var a in numbers)
            //{
            //    Console.Write(a+"  ");
            //}

            Stopwatch watch = new Stopwatch();
            int[] ints = new int[1000];

            for(int i = 0; i < ints.Length;i++)
            {
                ints[i] = Algoritm.random.Next();
            }
            watch.Start();
            
            Algoritm.SelectionSort(ints);

            Console.WriteLine(watch.ElapsedMilliseconds+"여기있어요");
            watch.Stop();
            for (int i = 0; i < ints.Length; i++)
            {
                Console.WriteLine(ints[i]);
            }

        }
    }
}

