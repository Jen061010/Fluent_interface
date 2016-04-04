using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fluent_interface
{
    public class Foo
    {
        //private string _fields;
        //private string _where;
        public Foo Select() //string fields){
        {
            //_fields=fields
            return this; 
        }
        public Foo Where() 
        {
            //_where=where;
            return this;
        }/* 
          * public string Execute()
          * {
          *     return "Select "+""+_fields+""+_where;
          * }*/

    }
}
