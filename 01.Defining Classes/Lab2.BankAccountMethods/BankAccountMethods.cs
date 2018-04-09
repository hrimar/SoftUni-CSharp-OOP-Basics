using System;

public class BankAccountMethods
{
    static void Main()
    {
        var account = new BankAccount();

        account.Id = 1;
        account.Deposit(15);
        account.Withdraw(10);

        Console.WriteLine(account);
    }
}
