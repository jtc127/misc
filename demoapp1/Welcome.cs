using System;
namespace Welcome
{
    class LogoScreen
    {
        public void ShowLogo()
        {
            Console.Clear();
            Console.ForegroundColor=ConsoleColor.White;   

            Console.WriteLine(@"          ////\\\\\");
            Console.WriteLine(@"          || _ _ ||");
            Console.WriteLine(@"          \  + -  /");
            Console.WriteLine(@"          /   >   \");
            Console.WriteLine(@"          \  \_/  /");
            Console.WriteLine(@"           \_____/ ");
            Console.WriteLine(@"          W  | |   ");
            Console.WriteLine(@"          |-------|");
            Console.WriteLine(@"             |H|  M");
            Console.WriteLine(@"             |H|   ");
            Console.WriteLine(@"            /   \  ");
            Console.WriteLine(@"           _|   |_ ");
            Console.WriteLine(); 
            return ; 
        }
    }
}