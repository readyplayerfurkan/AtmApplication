namespace AtmApplication
{
    class Program
    {
        static void Main()
        {
            AtmMachine atm = new();
            
            atm.InsertCard();
            atm.EjectCard();
            Console.WriteLine("**************");
            
            atm.InsertCard();
            atm.InsertPin(123);
            atm.RequestCash(1500);
            atm.RequestCash(100);
            Console.WriteLine("***************");
            
            atm.InsertCard();
            atm.InsertPin(123);
            atm.RequestCash(100);
            Console.WriteLine("***************");
            
            atm.InsertCard();
            atm.InsertPin(123);
            atm.RequestCash(300);
            Console.WriteLine("****************");
            
            atm.InsertCard();
            atm.InsertPin(123);
            atm.RequestCash(100);
            Console.WriteLine("*****************");
            
            atm.InsertCard();
            atm.InsertPin(123);
            atm.RequestCash(100);
        }
    }
}