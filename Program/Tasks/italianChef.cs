using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Tasks   // Inheriting functionality and attributes from a class into another class
{
    internal class ItalianChef : Chef       //So instead of copy/pasta, like below, we can type :Chef here. making this chef inherit all the things the normal chef can
    {
        /*public void MakeChicken()
       {
           Console.WriteLine("The Chef makes chicken");
       }

       public void MakeSalad()
       {
           Console.WriteLine("The Chef makes salad");
       }

       public virtual void MakeSpecialDish()
       {
           Console.WriteLine("The Cheft makes bbq ribs"); 
       } */

        public void MakePasta()
        {
            Console.Write("The Chef makes pasta");
        }

        public override void MakeSpecialDish()  //Again Virtual means this can be overriden in any sub classes, so we change from Virtual here to override and can change the text under in WriteLine so can make something else.
        {
            Console.WriteLine("The Cheft makes chicken parm");
        }
    }
}
