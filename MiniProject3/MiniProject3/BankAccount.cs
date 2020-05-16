using System;
namespace MiniProject3
{
    public class BankAccount
    {
        private static ulong number = 1000000000;
        private float money;
        public ulong accountID { get; }
        public BankAccount()
        {
            accountID = number++;
            money = 0;
        }

        public BankAccount(float money)
        {
            this.money = money;
        }

        public float Deposit(float num)
        {
            money += num;
            return money;
        }

        public float Withdraw(float num)
        {
            if (num > money)
            {
                throw new Exception("Bank: You don't have enough money");
            }
            money -= num;
            return money;
        }

        public override string ToString()
        {
            return $"Account ID:{accountID} Money:{money}";
        }

    }
}
