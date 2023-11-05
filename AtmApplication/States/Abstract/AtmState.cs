namespace AtmApplication;

public abstract class AtmState
{
    public abstract void InsertCard();
    public abstract void EjectCard();
    public abstract void InsertPin(int pin);
    public abstract void RequestCash(int castToWithdraw);
}