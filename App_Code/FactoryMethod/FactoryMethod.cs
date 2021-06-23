using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for FactoryMethod
/// </summary>
public class MoneyBackFactory : CreditCardFactoryMethod
{
    protected override CreditCard MakeProduct()
    {
        CreditCard product = new MoneyBack();
        return product;
    }
}
public class PlatinumFactory : CreditCardFactoryMethod
{
    protected override CreditCard MakeProduct()
    {
        CreditCard product = new Platinum();
        return product;
    }
}
public class TitaniumFactory : CreditCardFactoryMethod
{
    protected override CreditCard MakeProduct()
    {
        CreditCard product = new Titanium();
        return product;
    }
}

