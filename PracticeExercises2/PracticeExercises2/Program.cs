using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeExercises2
{

    interface IMusicLibraryVisitor
    {
        void onHeavyMetal(HeavyMetal heavymetal);
        void onJazz(Jazz jazz);
    }

    interface ISong
    {
        void Visit(IMusicLibraryVisitor musiclibraryvisitor);
    }

    class Jazz : ISong
    {
        public void Visit(IMusicLibraryVisitor musiclibraryvisitor)
        {
            musiclibraryvisitor.onJazz(this);
        }
    }

    class HeavyMetal : ISong
    {
        public void Visit(IMusicLibraryVisitor musiclibraryvisitor)
        {
            musiclibraryvisitor.onHeavyMetal(this);
        }
    }

    class MusicLibraryVisitor : IMusicLibraryVisitor
    {
        List<Jazz> jazzList = new List<Jazz>();
        List<HeavyMetal> hmList = new List<HeavyMetal>();

        public MusicLibraryVisitor(List<Jazz> jazzList, List<HeavyMetal> hmList)
        {
            this.jazzList = jazzList;
            this.hmList = hmList;
        }

        public void onHeavyMetal(HeavyMetal heavymetal)
        {
            Console.WriteLine(hmList.Count);
        }

        public void onJazz(Jazz jazz)
        {
            Console.WriteLine(jazzList.Count);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Jazz> jazzL = new List<Jazz>();
            List<HeavyMetal> hmL = new List<HeavyMetal>();

            jazzL.Add(new Jazz());
            jazzL.Add(new Jazz());
            jazzL.Add(new Jazz());

            hmL.Add(new HeavyMetal());
            hmL.Add(new HeavyMetal());
            hmL.Add(new HeavyMetal());
            hmL.Add(new HeavyMetal());
            hmL.Add(new HeavyMetal());
            hmL.Add(new HeavyMetal());
            hmL.Add(new HeavyMetal());

            MusicLibraryVisitor visitor = new MusicLibraryVisitor(jazzL, hmL);

            visitor.onJazz(new Jazz());
            visitor.onHeavyMetal(new HeavyMetal());

            Console.Read();
        }
    }
}
