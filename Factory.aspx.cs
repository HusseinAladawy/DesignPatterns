using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void PoorImplentation()
    {
        //Generally we will get the Card Type from UI.
        //Here we are hardcoded the card type
        string cardType = "MoneyBack";
        CreditCard cardDetails = null;
        //Based of the CreditCard Type we are creating the
        //appropriate type instance using if else condition
        if (cardType == "MoneyBack")
        {
            cardDetails = new MoneyBack();
        }
        else if (cardType == "Titanium")
        {
            cardDetails = new Titanium();
        }
        else if (cardType == "Platinum")
        {
            cardDetails = new Platinum();
        }
        if (cardDetails != null)
        {
            Response.Write("CardType : " + cardDetails.GetCardType());
            Response.Write("CreditLimit : " + cardDetails.GetCreditLimit());
            Response.Write("AnnualCharge :" + cardDetails.GetAnnualCharge());
        }
        else
        {
            Response.Write("Invalid Card Type");
        }
        /*
         The above code implementation introduces the following problems

First, the tight coupling between the client class (Program) and Product Class (MoneyBack, Titanium, and Platinum).
Secondly, if we add a new Credit Card, then also we need to modify the Main method by adding an extra if-else condition which not only overheads in the development but also in the testing process
         */

    }
    public void GoodImplentation()
    {
        CreditCard cardDetails = CreditCardFactory.GetCreditCard("Platinum");

        if (cardDetails != null)
        {
            Response.Write("CardType : " + cardDetails.GetCardType());
            Response.Write("CreditLimit : " + cardDetails.GetCreditLimit());
            Response.Write("AnnualCharge :" + cardDetails.GetAnnualCharge());
        }
        else
        {
            Response.Write("Invalid Card Type");
        }

    }
    public void FactoryMethod()
    {
        CreditCard creditCard = new PlatinumFactory().CreateProduct();
        if (creditCard != null)
        {
            Console.WriteLine("Card Type : " + creditCard.GetCardType());
            Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
            Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
        }
        else
        {
            Console.Write("Invalid Card Type");
        }
        Console.WriteLine("--------------");
        creditCard = new MoneyBackFactory().CreateProduct();
        if (creditCard != null)
        {
            Console.WriteLine("Card Type : " + creditCard.GetCardType());
            Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
            Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
        }
        else
        {
            Console.Write("Invalid Card Type");
        }
    }
}