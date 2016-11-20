using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopeyWar
{
    public sealed class Scaling
    {
        private List<IScaleable> _scaleableObjects;
        private double _factorX;
        private double _factorY;

        private static Scaling instance = null;

        public double FactorX { get { return _factorX; } }
        public double FactorY { get { return _factorY; } }

        //Singleton pattern...Only one instance, created inside the class
        private Scaling()
        {
            _factorX = 1;
            _factorY = 1;
            _scaleableObjects = new List<IScaleable>(); //Holds all scaleable objects
        }

        public static Scaling GetInstance()
        {
            if (instance == null)
            {
                instance = new Scaling();
            }

            return instance;
        }

        /// <summary>
        /// Adds the object so that scaling factors can be applied.
        /// </summary>
        /// <param name="obj">Objects that implements the IScaleable interface.</param>
        public void Add(IScaleable obj)
        {
            _scaleableObjects.Add(obj);
        }

        public void ApplyUserScaling(int xOrg, int xNew, int yOrg, int yNew)
        {
            double initialFactorX = _factorX; //Used to calculate the original X position for each object
            double initialFactorY = _factorY; //Used to calculate the original Y position for each object

            _factorX = xNew / (double)xOrg;   //Calculates the changes in form size as a factor for X 
            _factorY = yNew / (double)yOrg;   //and the Y-axis

            foreach (IScaleable obj in _scaleableObjects)       //Apply changes to ALL scaleable objects
            {
                int initialPosX = (int)(obj.PosX / initialFactorX + 0.5); 
                int initialPosY = (int)(obj.PosY / initialFactorY + 0.5);
                obj.PosX = (int)(initialPosX * _factorX); //New values for X-axis by factor multiplying
                obj.PosY = (int)(initialPosY * _factorY); //New values for Y-axis by factor multiplying
            }
        }

        public List<IScaleable> AllScalebleObjects ()
        {
            return _scaleableObjects;
        }
    }
}
