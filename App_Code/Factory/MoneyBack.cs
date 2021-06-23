using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MoneyBack
/// </summary>
public class MoneyBack: CreditCard
{
    public MoneyBack()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public int GetAnnualCharge()
    {
        return 500;
    }

    public string GetCardType()
    {
        return "MoneyBack";
    }

    public int GetCreditLimit()
    {
        return 150000;
    }
}