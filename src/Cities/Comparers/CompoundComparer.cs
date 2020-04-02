using System;
using System.Collections.Generic;
using System.Text;

namespace Cities.Comparers
{
    public class CompoundComparer : IComparer<City>
    {
        //BONUS MISSION- TO SORT FIRST BY STATE AND THEN BY POPULATION

        public IList<IComparer<City>> Comparers = new List<IComparer<City>>();
        public int Compare(City x, City y)
        {
            int result = 0;
            foreach (IComparer<City> comp in Comparers)
            {
                result = comp.Compare(x, y);
                if (result != 0)
                {
                    break;
                }
            }
                return result;
        }
    }
}
