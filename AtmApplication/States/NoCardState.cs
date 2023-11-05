namespace AtmApplication;

public class NoCardState : AtmState
{
    private AtmMachine _context;

    public NoCardState(AtmMachine context)
        => _context = context;
    
    public override void InsertCard() 
    {
        Console.WriteLine("Lütfen pini giriniz.");
        _context.SetHasCard();
    }
    
    public override void EjectCard() 
        => Console.WriteLine("Lütfen önce kartı takınız.");

    public override void InsertPin(int pin)
        => Console.WriteLine("Lütfen önce kartı takınız.");
    
    public override void RequestCash(int castToWithdraw) 
        => Console.WriteLine("Lütfen önce kartı takınız");
}