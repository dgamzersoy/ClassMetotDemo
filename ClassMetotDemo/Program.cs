using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Costumer costumer2 = new Costumer();
            costumer2.CostumerName = "Gamze";
            costumer2.CostumerLastName = "Ersoy";
            costumer2.CostumerId = 1;

            Costumer costumer3 = new Costumer();
            costumer3.CostumerName = "Samet";
            costumer3.CostumerLastName = "Özdemir";
            costumer3.CostumerId = 2;


            Costumer costumer4 = new Costumer();
            costumer3.CostumerName = "Buse";
            costumer3.CostumerLastName = "Ersoy";
            costumer3.CostumerId = 3;

            Costumer costumer5 = new Costumer();
            costumer5.CostumerName = "Emrullah";
            costumer5.CostumerLastName = "Özdemir";
            costumer5.CostumerId = 5;


            CostumerManager costumerManager = new CostumerManager();

          
            
            costumerManager.Add(costumer2);
            costumerManager.Delete(costumer3);
            costumerManager.Listele(costumer5);
           
          

        }



    }
}
