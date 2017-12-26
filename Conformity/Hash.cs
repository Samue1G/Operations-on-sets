using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conformity
{
    class Hash : IComparable<Hash>
    {
        public string v1 { get; set; }
        public string v2 { get; set; }
        public Hash(string val1, string val2)
        {


            this.v1 = val1;
            this.v2 = val2;
        }

        public int CompareTo(Hash other)
        {
             if(this.v1 != other.v1 && this.v2 != other.v2)
            {
                return -1;
            }
            return 1;
        }
    }
}
