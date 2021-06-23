using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Titanium
/// </summary>
public class Titanium:CreditCard
{
    public Titanium()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public string GetCardType()
    {
        return "Titanium Edge";
    }
    public int GetCreditLimit()
    {
        return 25000;
    }
    public int GetAnnualCharge()
    {
        return 1500;
    }
}