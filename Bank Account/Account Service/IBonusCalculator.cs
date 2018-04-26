namespace NET.S._2018.Haiduk._08.Account_Service
{
    public interface IBonusCalculator
    {
        double CalculateBonusPoints(decimal amount, BankAccount account);
    }
}
