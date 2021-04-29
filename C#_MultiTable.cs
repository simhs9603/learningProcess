
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
