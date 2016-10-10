using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroundHopping
{
    class miscClass
    {
        public miscClass()
        {

        }

        /*
         * Prüfen ob neuer string im string Array schon enthalten ist
         */
        public bool isNotInList(string[] inList, string newValue)
        {
            bool returnValue = true;

            for (int i = 0; i < inList.Length; i++)
            {
                if (newValue == inList[i])
                {
                    returnValue = false;
                }
            }
            return returnValue;
        }
    }
}
