using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS_11_Generics
{
    public class Comparable<T, U> : IComparable<Comparable<T, U>> where U : IComparable<T> where T : IComparable<U>
    {
        public T firstValue;
        public U secondValue;

        public Comparable(T firstValue, U secondValue)
        {
            this.firstValue = firstValue;
            this.secondValue = secondValue;
        }

        public int CompareTo(Comparable<T, U>? other)
        {
            if (other == null)
            {
                return 1;
            }
            int firstComparsion = firstValue.CompareTo(other.firstValue);
            if (firstComparsion != 0)
            {
                return firstComparsion;
            }
            return secondValue.CompareTo(other.secondValue);
        }
    }



}

