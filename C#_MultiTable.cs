using System;


namespace testConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter Number :");
            string a = Console.ReadLine();///입력은 무조건 string
            int a1 = Convert.to; ///int 값을 원하면 입력받은 string 은 항상 변환 


            if (a1 < 10)
            { ///입력한 a1의 값이 10 이하 일 때, 
                for (int b = 1; b < 10; b++) /// b의 값은 10 미만에서 1씩 ++ 
                {
                    Console.WriteLine($"{a1}단"); ///$를 사용해 절대 참조
                    Console.WriteLine($"{a1}*{b}={a1 * b}");

                }
            }
        }
    }
}



{
    class Program
    {
        static void Main(string[] args)

        {
            int a = 1; ///a의 값을 1로 지정 
            while (true) /// 값이 true 일 동안 해당문을 계속 반복
            {

                for (a = 1; ; a++) ///a는 10미만에서 1씩 증가 
                {
                    if (a >= 10) ///a가 10을 초과하는 경우 
                        Console.WriteLine("9단초과");
                        break; ///while 문을 멈춤
                    else
                    {
                        for (int b = 1; b < 10; b++) ///b는 1이라고 정의하고 9가 될때 까지 1씩 증가
                        {
                            Console.WriteLine($"{a}단"); ///절댓값 참조 출력
                            Console.WriteLine($"{a}*{b}={a * b}");
                            break;

                        }
                    }
                }

            }
        }
    }
}
