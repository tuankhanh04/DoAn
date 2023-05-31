using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryExample

{
    class Cylinder
    {
        private double radius;
        private double height;
        private double baseArea;
        private double lateralArea;
        private double totalArea;
        private double volume;

        public Cylinder(double radius, double height)
        {
            this.radius = radius;
            this.height = height;
        }

        public void Process()
        {
            baseArea = Math.PI * radius *radius;
            lateralArea = 2 * Math.PI * radius *height;
            totalArea = 2 * Math.PI * radius *(height + radius);
            volume = Math.PI *  radius * radius * height;

            Result(baseArea, lateralArea, totalArea, volume);
        }

        public void Result(double baseArea, double lateralArea, double totalArea, double volume)
        {
            Console.WriteLine("\n Cylinder Characteristics:");
            Console.WriteLine($"Radius: {radius:F2}, Height: {height:F2}");
            Console.WriteLine($"Base: {baseArea:F2} | Lateral: {lateralArea:F2} | Total: {totalArea:F2} | Volume: {volume:F2}");
        }
    }
}