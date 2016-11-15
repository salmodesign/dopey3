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
        static private double _factorX;
        static private double _factorY;

        static public double FactorX { get { return _factorX; } }
        static public double FactorY { get { return _factorY; } }

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
            _factorX = xNew / (double)xOrg;   //Calculates the changes in form size as a factor for X 
            _factorY = yNew / (double)yOrg;   //and the Y-axis

            foreach (IScaleable obj in _scaleableObjects)       //Apply changes to ALL scaleable objects
            {
                obj.PositionX = (int)(obj.PositionX * _factorX); //New values for X-axis by factor multiplying
                obj.PositionY = (int)(obj.PositionY * _factorY); //New values for Y-axis by factor multiplying
            }
        }
    }
}
