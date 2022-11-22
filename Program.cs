namespace NthFibNum
{
    class Primary
    {
        public static void Main()
        {
            
            Working work = new Working();
            
            Console.WriteLine(work.NthNum(10));
            Console.WriteLine(work.NthNum(20));
            Console.WriteLine(work.NthNum(30));
            Console.WriteLine(work.NthNum(40));
            Console.WriteLine(work.NthNum(50));
            Console.WriteLine(work.NthNum(60));

        }
    }
}
