using System;
using System.Collections.Generic;

public class TestClient
{
    static void Main()  // 100/100
    {
        var accounts = new Dictionary<int, BankAccount>();

        var bankAccount = new BankAccount();

        string input;
        while ((input = Console.ReadLine()) != "End")
        {
            var inputDetails = input.Split();
            var command = inputDetails[0];
            int id = int.Parse(inputDetails[1]);

            switch (command)
            {
                case "Create":
                    CreateAccount(accounts, id);
                    break;
                case "Deposit":
                    DepositAccount(accounts, inputDetails);
                    break;
                case "Withdraw":
                    WithdrawAccount(accounts, inputDetails);
                    break;
                case "Print":
                    PrintAccount(accounts, id);
                    break;
            }
        }
    }

    private static void PrintAccount(Dictionary<int, BankAccount> accounts, int id)
    {
        if (accounts.ContainsKey(id))
        {
            Console.WriteLine(accounts[id]);
        }
        else
        {
            Console.WriteLine("Account does not exist");
        }

    }

    private static void WithdrawAccount(Dictionary<int, BankAccount> accounts, string[] inputDetails)
    {
        var command = inputDetails[0];
        int id = int.Parse(inputDetails[1]);
        int amount = int.Parse(inputDetails[2]);

        if (IsExistingId(accounts, id, amount))
        {
            if (accounts[id].Balance >= amount)
            {
                accounts[id].Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Insufficient balance");
            }

        }
    }

    private static void CreateAccount(Dictionary<int, BankAccount> accounts, int id)
    {
        if (accounts.ContainsKey(id))
        {
            Console.WriteLine($"Account already exists");
        }
        else
        {
            var newAccount = new BankAccount();
            newAccount.Id = id;
            accounts[id] = newAccount;
        }
    }


    private static void DepositAccount(Dictionary<int, BankAccount> accounts, string[] inputDetails)
    {
        var command = inputDetails[0];
        int id = int.Parse(inputDetails[1]);
        int amount = int.Parse(inputDetails[2]);

        if (IsExistingId(accounts, id, amount))
        {
            accounts[id].Deposit(amount);
        }
    }

    private static bool IsExistingId(Dictionary<int, BankAccount> accounts, int id, int amount)
    {
        if (!accounts.ContainsKey(id))
        {
            Console.WriteLine($"Account does not exist");
            return false;
        }
        else
        {
            return true;
        }
    }
}

