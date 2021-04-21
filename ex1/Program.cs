using System;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력해주세요");
            Console.WriteLine("1입력 : 구구단 출력 / 나머지 숫자 입력 : 원하는 곱셈연산 출력");

            string input0 = Console.ReadLine();
            int num0 = int.Parse(input0);
   

            if (num0 == 1)
            {
                Console.WriteLine("원하시는 단을 입력해주세요 ");


                string input3 = Console.ReadLine();
                int num3 = int.Parse(input3);
                //  입력 받은 숫자 확인
                Console.WriteLine("입력받은 숫자는 : " + num3 + "단");

                //y가 1부터 9까지 증가하는 반복문
                for (int y = 1; y <= 9; y++)
                {



                    //Console.WriteLine(num1 + "X" + y + " = " + num1 * y); // y : 1 ->9 증가
                    Console.WriteLine($"{num3} X {y} = {num3 * y}"); // num1을 받아오고 그 숫자에 1~9까지 곱한 반복문 출력
                }
            }

            else 
                     {
                Console.WriteLine("두개의 숫자를 입력해주세요");
                Console.Write("첫번째 숫자는 : ");


                string input = Console.ReadLine();
                Console.Write("두번째 숫자는 : ");
                string input1 = Console.ReadLine();
                //  입력 받은 숫자 확인
                int num1 = int.Parse(input);
                int num2 = int.Parse(input1);


                //string mathNum = "1111";
                //int intValue1 = int.Parse(mathNum);

                //  구구단 곱셈 연산 출력

                Console.WriteLine("두 숫자의 곱은" + $"{num1} X {num2} = {num1 * num2}" + "입니다. ");

            }

           





            // 구구단 곱셈 출력
            //Console.WriteLine("입력받은 숫자는 : " + num1 + "단");

            //[구구단 출력] 

            //for(int x = 1; x <= 9; x++)
            //{
            //Console.WriteLine($"2 X {x} = {2 * x}");
            //}

            // y가 1부터 9까지 증가하는 반복문
            //for (int y = 1; y <= 9; y++) 
            //{



            //    //Console.WriteLine(num1 + "X" + y + " = " + num1 * y); // y : 1 ->9 증가
            //    Console.WriteLine($"{num1} X {y} = {num1 * y}"); // num1을 받아오고 그 숫자에 1~9까지 곱한 반복문 출력
            //}








        }
    }
}
