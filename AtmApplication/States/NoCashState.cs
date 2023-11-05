namespace AtmApplication;

public class NoCashState : AtmState
{
    private AtmMachine _context;
    public NoCashState(AtmMachine context)
        => _context = context;
    public override void InsertCard()
        => Console.WriteLine("Para yok kanki :)");

    public override void EjectCard()
        => Console.WriteLine("Para yok kanki :)");

    public override void InsertPin(int pin)
        => Console.WriteLine("Para yok kanki :)");

    public override void RequestCash(int castToWithdraw)
        => Console.WriteLine("Para yok kanki :)");
}