using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CreditCard
/// </summary>
public interface CreditCard
{
    string GetCardType();
    int GetCreditLimit();
    int GetAnnualCharge();
}