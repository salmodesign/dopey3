using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopeyWar
{
    public abstract class Scaling
    {
        static private List<IScaleable> _scaleableObjects = new List<IScaleable>();

        /// <summary>
        /// Adds the object so that scaling factors can be applied.
        /// </summary>
        /// <param name="obj">Objects that implements the IScaleable interface.</param>

        public static void Add(IScaleable obj)
        {
            _scaleableObjects.Add(obj);
        }

        public static void ApplyUserScaling(int xOrg, int xNew, int yOrg, int yNew)
        {
            double FactorX = xNew / (double)xOrg;   //Calculates the changes in form size as a factor for X 
            double FactorY = yNew / (double)yOrg;   //and the Y-axis

            foreach (IScaleable obj in _scaleableObjects)       //Apply changes to ALL scaleable objects
            {
                obj.PositionX = (int)(obj.PositionX * FactorX); //New values for X-axis by factor multiplying
                obj.PositionY = (int)(obj.PositionY * FactorY); //New values for Y-axis by factor multiplying
            }
        }
    }
}
