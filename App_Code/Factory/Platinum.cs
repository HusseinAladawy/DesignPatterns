using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Platinum
/// </summary>
public class Platinum: CreditCard
{
    public Platinum()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public string GetCardType()
    {
        return "Platinum Plus";
    }
    public int GetCreditLimit()
    {
        return 35000;
    }
    public int GetAnnualCharge()
    {
        return 2000;
    }
}