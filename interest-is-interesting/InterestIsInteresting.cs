using System;

static class SavingsAccount
{
    private static float interestRate;
    public static float InterestRate(decimal balance)
    {
        if (balance < 0)
        {
            interestRate = 3.213f;
        }
        else if (balance >= 0 && balance < 1000)
        {
            interestRate = 0.5f;
        }
        else if (balance >= 1000 && balance < 5000)
        {
            interestRate = 1.621f;
        }
        else if (balance >= 5000)
        {
            interestRate = 2.475f;
        }

        return interestRate;
    }

    public static decimal Interest(decimal balance)
    {
        return balance * (decimal)(InterestRate(balance)/100);
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int year = 0;

        while(balance < targetBalance)
        {
            balance = AnnualBalanceUpdate(balance);
            year++;
        }

        return year;
    }
}
