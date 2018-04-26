namespace NET.S._2018.Haiduk._08
{
    public interface IRepository
    {
        void Create(Client client, decimal startAmount);

        BankAccount Read(Client client);

        void Update();

        void Delete(int accountNumber);
    }
}
