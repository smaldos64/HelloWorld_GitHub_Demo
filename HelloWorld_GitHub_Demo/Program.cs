using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_GitHub_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3Dimension My3DimensionPoint = new Point3Dimension();
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("5");

            My3DimensionPoint.X_Value = 1;
            My3DimensionPoint.Y_Value = 2;
            My3DimensionPoint.Z_Value = 3;
            Console.WriteLine("Punktets koordinater er : ({0} ; {1} ; {2})",
                My3DimensionPoint.X_Value, My3DimensionPoint.Y_Value, My3DimensionPoint.Z_Value);
        }
    }
}
