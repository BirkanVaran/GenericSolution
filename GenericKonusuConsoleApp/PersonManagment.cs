using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKonusuConsoleApp
{
    public class PersonManagment<T> where T : class,new()
    {
        //// Default CTOR:
        //public PersonManagment ()
        //{

        //}

        // Eğer CTOR ezilirse bu durumda new() keyword'ü generic yapıya eklenmelidir.

        public T GetTip()
        {
            return new T();
        }
    }
}
