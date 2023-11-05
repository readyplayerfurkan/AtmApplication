namespace AtmApplication;

public class AtmMachine
{
    private AtmState noCard;
    private AtmState hasCard;
    private AtmState hasPin;
    private AtmState noCash;
    
    private AtmState state;

    public AtmMachine()
    {
        noCard = new NoCardState(this);
        hasCard = new HasCardState(this);
        hasPin = new HasPinState(this);
        noCash = new NoCashState(this);
        state = noCard;
    }

    public void SetNoCard()
        => state = noCard;

    public void SetHasCard()
        => state = hasCard;

    public void SetHasPin()
        => state = hasPin;

    public void SetNoCash()
        => state = noCash;
    
    public AtmState State { set => state = value; }
    
    public int CashInMachine { get; set; } = 2000;
    public bool CorrectPinEntered { get; set; } = false;

    public void InsertCard()
        => state.InsertCard();
    public void EjectCard()
        => state.EjectCard();
    public void InsertPin(int pin)
        => state.InsertPin(pin);
    public void RequestCash(int castToWithdraw)
        => state.RequestCash(castToWithdraw);
}