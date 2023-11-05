namespace AtmApplication;

public class HasCardState : AtmState
{
    private AtmMachine _context;
    public HasCardState(AtmMachine context)
        => _context = context;
    
    public override void InsertCard() 
        => Console.WriteLine("Birden fazla kart takamazsınız.");

    public override void EjectCard()
    {
        Console.WriteLine("Kart çıkartılmıştır.");
        _context.SetNoCard();
    }

    public override void InsertPin(int pin)
    {
        if (pin == 123)
        {
            Console.WriteLine("Pin doğrulandı!");
            _context.CorrectPinEntered = true;
            _context.SetHasPin();
        }
        else
        {
            Console.WriteLine("Geçersiz pin girildi!");
            _context.CorrectPinEntered = false;
            Console.WriteLine("Kartınız çıkartılmıştır.");
            _context.SetNoCard();
        }
    }

    public override void RequestCash(int castToWithdraw) 
        => Console.WriteLine("Lütfen önce pini giriniz.");
}