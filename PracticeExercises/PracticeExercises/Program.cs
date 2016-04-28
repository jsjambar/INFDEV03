using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises
{

    class NumberVisitor : INumberVisitor
    {
        public void onMyFloat(MyFloat myfloat)
        {
            Console.WriteLine("Found float.");
        }

        public void onMyInt(MyInt myint)
        {
            Console.WriteLine("Found int.");
        }
    }

    class MyFloat : INumber
    {
        public void Visit(INumberVisitor visitor)
        {
            visitor.onMyFloat(this);
        }
    }

    class MyInt : INumber   
    {
        public void Visit(INumberVisitor visitor)
        {
            visitor.onMyInt(this);
        }
    }

    interface INumberVisitor
    {
        void onMyInt(MyInt myint);
        void onMyFloat(MyFloat myfloat);

    }

    interface INumber
    {
        void Visit(INumberVisitor visitor);
    }

    class Program
    {
        static void Main(string[] args)
        {
            NumberVisitor NumberVisitor = new NumberVisitor();
            NumberVisitor.onMyFloat(new MyFloat());
            NumberVisitor.onMyInt(new MyInt());

        }
    }
}
