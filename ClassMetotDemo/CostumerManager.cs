using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CostumerManager
    {

     
        public void Add(Costumer costumer)
        {
            Console.WriteLine("eklendi  : " + costumer.CostumerName + " " +costumer.CostumerLastName + " "+costumer.CostumerId );
        }  

        public void Delete(Costumer costumer)
        {
            Console.WriteLine("Silindi :" + costumer.CostumerName + " " + costumer.CostumerLastName + " " + costumer.CostumerId);
        }
        
        public void Listele(Costumer costumer)
        {
            
            Console.WriteLine(costumer.CostumerName);
            
        }
    }



    
}
