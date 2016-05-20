using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class Vector:IComparable,IComparer<Vector>
    {
        public int Ax { get; private set; }
        public int Ay { get; private set; }
        public int Bx { get; private set; }
        public int By { get; private set; }
        public int Xa { get; private set; }
        public int Ya { get; private set; }
        public string Name { get; private set; }
        public double Lenght { get; private set; }

        public Vector(char one,char two,int ax, int ay,int bx, int by)
        {
            Ax = ax;
            Ay = ay;
            Bx = bx;
            By = by;
            Xa = Bx - Ax;
            Ya = By - Ay;
            Name = one.ToString() + two.ToString();
            Lenght = Math.Sqrt(Math.Pow(Xa,2) + Math.Pow(Ya,2));
        }
      
        public int CompareTo(object obj)
        {
            if (!(obj is Vector)) return -1;
            else
            {
                var tempVector = obj as Vector;
                if (Lenght == tempVector.Lenght) return 0;
                if (Lenght > tempVector.Lenght) return 1;
                if (Lenght < tempVector.Lenght) return -1;
                
            }
            return 0;

        }

        public int Compare(Vector one, Vector two)
        {
            if (one.Lenght == two.Lenght) return 0;
            if (one.Lenght > two.Lenght) return 1;
            if (one.Lenght < two.Lenght) return -1;
            return 0;

        }

        public override string ToString()
        {
            return string.Format("{0}({1},{2})",Name,Xa,Ya);
        }

        public override int GetHashCode()
        {
            return (Ax*111 - Bx*111 + Bx*By%2);
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Vector)) return false;
            else
            {
                var tempVector = obj as Vector;
                return Lenght == tempVector.Lenght ? true : false;
            }
        }

    }
}
