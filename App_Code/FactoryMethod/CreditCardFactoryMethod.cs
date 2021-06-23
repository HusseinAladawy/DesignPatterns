using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CreditCardFactoryMethod
/// </summary>
public abstract class CreditCardFactoryMethod
{
    protected abstract CreditCard MakeProduct();
    public CreditCard CreateProduct()
    {
        return this.MakeProduct();
    }
}
