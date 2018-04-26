using System;
using NET.S._2018.Haiduk._08.Account_Service;

namespace NET.S._2018.Haiduk._08
{
    /// <summary>
    /// Class that describes Bank Account and contains methods for working with it
    /// </summary>
    public abstract class BankAccount
    {
        #region Fields

        protected readonly int accountNumber;

        protected readonly Client owner;

        protected decimal amount;

        public bool Closed;

        #endregion

        /// <summary>
        /// Constructor without parameters
        /// </summary>
        public BankAccount()
        {
        }

        /// <summary>
        /// Constructor for creating new Bank account
        /// </summary>
        /// <param name="client">Information about account owner</param>
        /// <param name="startAmount">Value of star amount</param>
        public BankAccount(Client client, decimal startAmount)
        {
            this.accountNumber = SetAccountNumber();
            this.owner = client;
            this.amount = startAmount;
            Closed = false;
            BonusPoints = 0;
        }

        #region Properties

        /// <summary>
        /// The ID number of Bank Account
        /// </summary>
        public int AccountNumber => accountNumber;

        /// <summary>
        /// Firstname of the owner of Bank Account
        /// </summary>
        public string OwnerInfo => owner.ToString();

        /// <summary>
        /// The owner of Bank Account
        /// </summary>
        public Client Client => owner;

        /// <summary>
        /// Amount of Bank Account
        /// </summary>
        public decimal Amount
        {
            get => amount;
            set
            {
                amount = value;
            }
        }

        /// <summary>
        /// Bonus Points that add or substarct while working with amount
        /// </summary>
        public double BonusPoints { get; internal set; }

        #endregion

        /// <summary>
        /// Method for calculating Bonus points
        /// </summary>
        /// <param name="amount">Amount of money for deposit or withdraw</param>
        /// <param name="bonusCalculator">Instance of Bonus calculator to determine type of bonus points calculation</param>
        /// <param name="bankAccount">Account for calculating bonus points</param>
        /// <returns>Value of bonus points after money operations with account</returns>
        public double CalculateBonusPoints(decimal amount, IBonusCalculator bonusCalculator, BankAccount bankAccount) => bonusCalculator.CalculateBonusPoints(amount, bankAccount);

        /// <summary>
        /// Method for determining whether withdraw operation is valid with given account
        /// </summary>
        /// <param name="account">Given account</param>
        /// <param name="amount">Amount of money for withdraw</param>
        /// <returns>True if account is valid for withdraw; otherwise, false</returns>
        public abstract bool IsValidBalance(BankAccount account, decimal amount);

        protected int SetAccountNumber()
        {
            Random random = new Random();
            return random.Next(1, 1000);
        }
    }
}