using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStaticNonstatic.Model
{
    public class Kitchen
    {
        //Non-static feilds(instance feilds)
        //each kitchen object has its own value for this
        public string chefname;

        //static feild
        //there is only one copy of this,shared by all kitchen.
        public static string CommonReceipeBook = "Grandmas Recipes";

        //change from public to protected
        //how this method can only be accesse within this class and derived class

        protected void CookDish(string dishname)
        {
            //this method uses the specific chefname of this kitchen.
            Console.WriteLine("");
        }
    }
}
