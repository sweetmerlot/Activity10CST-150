using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Activity10CodeCorrection
{
    class Set
    {
        private List<int> elements;


        public Set()
        {
            elements = new List<int>();
        }

        public bool addElement(int val)
        {
            if (containsElement(val)) return false;
            else
            {
                elements.Add(val);
                return true;
            }

        }
        private bool containsElement(int val)
        {

            for (int i = 0; i < elements.Count; i++)
            {
                if (val == elements[i])
                    return true;
               /* else
                    return false;*/
            }
            return false;
        }

        public override string ToString()
        {
            string str = "";
            foreach (int i in elements)
            {
                str += i + " ";
            }
            return str;
        }

        public void clearSet()
        {
            elements.Clear();
        }

        public Set union(Set rhs)
        {
            Set union = new Set();
            
 
            for (int i = 0; i < rhs.elements.Count; i++)
            {
                union.addElement(rhs.elements[i]);
            }
            for (int x = 0; x < this.elements.Count; x++)
            {
                union.addElement(this.elements[x]);
            }
            return union;

        }
    }
}
