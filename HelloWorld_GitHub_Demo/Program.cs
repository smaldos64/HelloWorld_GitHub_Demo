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

            My3DimensionPoint.X_Value = 4;
            My3DimensionPoint.Y_Value = 5;
            My3DimensionPoint.Z_Value = 6;
            Console.WriteLine("Punktets koordinater er : ({0} ; {1} ; {2})",
                My3DimensionPoint.X_Value, My3DimensionPoint.Y_Value, My3DimensionPoint.Z_Value);
            
            // Kommentar added in GitHub
            // Ny kommentar added i GitHub
            // Endnu en ny kommentar added i GitHub.
            // Og endnu en.
            // Og sørme en mere. Hvis jeg skal hente denne ændring ned i mit lokale Repository, skal jeg lave en pull
            // i mit VS projekt.
            // Bliver denne linje hentet ned med en Git-Fetch ??? Spændende at se. Det gjorde den ikke. Man skal bruge en Git-Pull.
        }
    }
}
