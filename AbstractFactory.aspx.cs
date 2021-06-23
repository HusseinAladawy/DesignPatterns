using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AbstractFactory : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
       
       

        // Create the Sea Factory object by passing the factory type as Sea
        AnimalFactory animalFactory = animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
        Response.Write("Animal Factory type : " + animalFactory.GetType().Name);
        Response.Write("<br>");

        Animal animal = animalFactory.GetAnimal("Octopus");
        Response.Write("Animal Type : " + animal.GetType().Name);
        Response.Write("<br>");
        string  speakSound = animal.speak();
        Response.Write(animal.GetType().Name + " Speak : " + speakSound);
        Response.Write("<br>");


        Response.Write("--------------------------");
        Response.Write("<br>");
        // Create Land Factory object by passing the factory type as Land
        animalFactory = AnimalFactory.CreateAnimalFactory("Land");
        Response.Write("Animal Factory type : " + animalFactory.GetType().Name);
        Response.Write("<br>");

        // Get Lion Animal object by passing the animal type as Lion
        animal = animalFactory.GetAnimal("Lion");
        Response.Write("Animal Type : " + animal.GetType().Name);
        Response.Write("<br>");
        speakSound = animal.speak();
        Response.Write(animal.GetType().Name + " Speak : " + speakSound);
        Response.Write("<br>");


    }
}