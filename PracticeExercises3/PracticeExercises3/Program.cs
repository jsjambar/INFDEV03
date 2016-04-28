using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises3
{

    class Bag<T>
    {
        T content;

        public U inspect<U>(Func<T,U> inspect)
        {
            return inspect(content);
        }

        public Y define<Y>(Func <T, Y> define)
        {
            return define(content);
        }
     }

    /* interface IOption<T>
    {
        U Visit<U>(IOptionVisitor optionvisitor);
    }

    interface IOptionVisitor<T, U>
    {
        U onNone(T value);
        U onSome();
    }

    class Some : IOption<T>
    {
        public U Visit<U>(IOptionVisitor<T> optionvisitor)
        {
            throw new NotImplementedException();
        }
    }
    */

    class Program
    {
      
        static void Main(string[] args)
        {

            Bag<int> myBag = new Bag<int>();
            int res = myBag.inspect<int>(content => content+1);
            string res2 = myBag.inspect<string>(content => content.ToString());

            myBag.define<bool>(content => true);

        }
    }
}
