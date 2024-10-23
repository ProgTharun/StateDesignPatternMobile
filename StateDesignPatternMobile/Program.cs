using StateDesignPatternMobile.Model;

namespace StateDesignPatternMobile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MobileContext mobile = new MobileContext();

            mobile.PressPowerButton();
            mobile.PressPowerButton();
            mobile.PressPowerButton(); 
            mobile.PressPowerButton();
            Console.WriteLine();
            Console.WriteLine("================");
            mobile.DisplayStateHistory();
        }
    }
}
