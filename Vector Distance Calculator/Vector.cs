using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vector_Distance
{
    public class Vector
    {
        public double x { get; set; }
        public double y { get; set; }
        public double z { get; set; }     

        public static double Distance(Vector A, Vector B)
        {
            return Math.Sqrt((Math.Pow(B.x - A.x, 2) + (Math.Pow(B.y - A.y, 2)) + (Math.Pow(B.z - A.z, 2))));
        }
        // this only overloaded method in Vector class creates a random 2d or 3d vector depending on one or 2 parameters.

        // To provide redundency for the random number generator I created it using the Random class and the current Ticks % 100 as a seed

        public static Vector RandomVector(int twoDvec)
        {
            Vector vector = new Vector();
            int x = new Random((int)DateTime.Now.Ticks % 100 + twoDvec).Next(1000);
            int y = new Random((int)DateTime.Now.Ticks % 100 - twoDvec).Next(1000);
            vector.x = x;
            vector.y = y;
            return vector;
        }

        public static Vector RandomVector(int twoDvec, int threeDvec)
        {
            Vector vector = new Vector();
            int x = new Random((int)DateTime.Now.Ticks % 100 + twoDvec).Next(1000);
            int y = new Random((int)DateTime.Now.Ticks % 100 - twoDvec).Next(1000);
            int z = new Random((int)DateTime.Now.Ticks % 100 + threeDvec).Next(1000);
            vector.x = x;
            vector.y = y;
            vector.z = z;        
            return vector;
        }
        // This method finds the shortest distance between two vectors given a list of Vectors as a parameter

        public static Vector[] ShortestDist(List<Vector> vectorList)
        {
            // Initializing a variable to hold the lowest distance between two points, starting with the first two vectors in the list
            double lowest = Distance(vectorList[0], vectorList[1]);
            // creating an array to hold the answer in the end
            Vector[] result = new Vector[2];
            // iterating through the two lists to compare each Vector with the next Vector

            for (int i = 0; i < vectorList.Count; i++)
            {
                for (int j = i + 1; j < vectorList.Count; j++)
                {
                    double dist = Distance(vectorList[i], vectorList[j]);

                    if (dist < lowest)
                    {
                        // save the lowest distance value and the two vectors that produced it in their respective variables

                        lowest = dist;

                        result[0] = vectorList[i];

                        result[1] = vectorList[j];
                    }
                }
            }
            return result;
        }
    }
}
