using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathematical_vectors
{
    public class VectorMathFunc
    {
        private readonly double xa, xb, yb, zb, ya, za;
        public VectorMathFunc(double XA, double YA, double ZA, double XB, double YB, double ZB) {
            try
            {
                xa = XA;
                ya = YA;
                za = ZA;
                zb = ZB;
                xb = XB;
                yb = YB;
            }
            catch (Exception)
            {
                throw new Exception("incorrect data");
            }
        }
        public VectorMathFunc()
        {
                xa = 1;
                ya = 2;
                za = 3;
                zb = 4;
                xb = 5;
                yb = 6;
        }
        public VectorMathFunc(double XA, double YA, double ZA)
        {
            try
            {
                xa = XA;
                ya = YA;
                za = ZA;
                zb = 4;
                xb = 5;
                yb = 6;
            }
            catch (Exception)
            {
                throw new Exception("incorrect data");
            }
        }
        public double[] Plus()
        {
            double[] result = new double[3];
            result[0] = xa + xb;
            result[1] = ya + yb;
            result[2] = za + zb;
            return result;
        }

        public double[] Minus()
        {
            double[] result = new double[3];
            result[0] = xa - xb;
            result[1] = ya - yb;
            result[2] = za - zb;
            return result;
        }

        public double Scalar() { 
            return xa* xb + ya* yb + za* zb;
        }

        public double[] Length()
        {
            double[] result = new double[3];
            result[0] = Math.Sqrt(Math.Pow(xa,2)+ Math.Pow(ya, 2) + Math.Pow(za, 2));
            result[1] = Math.Sqrt(Math.Pow(xb, 2) + Math.Pow(yb, 2) + Math.Pow(zb, 2));
            result[2] = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
            return result;
        }
    }
}
