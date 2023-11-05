namespace AtmApplication;

public class HasPinState : AtmState
{
    private AtmMachine _context;
    public HasPinState(AtmMachine context)
        => _context = context;
    
    public override void InsertCard()
        => Console.WriteLine("Birden fazla kart takamazsınız.");

    public override void EjectCard()
    {
        Console.WriteLine("Kartınız çıkartılmıştır.");
        _context.SetNoCard();
    }

    public override void InsertPin(int pin)
        => Console.WriteLine("Doğrulanmış bir zaten girilmiştir.");

    public override void RequestCash(int castToWithdraw)
    {
        if (castToWithdraw > _context.CashInMachine)
        {
            Console.WriteLine("Çekmek istenilen tutar adil bedeli aşmaktadır.");
            Console.WriteLine("Kart çıkartılmıştır.");
            _context.SetNoCard();
        }
        else
        {
            Console.WriteLine($"{castToWithdraw} tutarında para çekilmiştir.");
            _context.CashInMachine -= castToWithdraw;
            Console.WriteLine("Kart çıkartılmıştır.");
            _context.SetNoCard();
            Console.WriteLine($"ATM'de kalan para : {_context.CashInMachine}");

            if (_context.CashInMachine <= 0)
                _context.SetNoCash();
        }
    }
}