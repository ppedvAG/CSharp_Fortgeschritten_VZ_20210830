using System;
using System.Collections.Generic;

namespace _003_Polymorphiesmus_Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 3.0, h = 5.0;
            Circle c = new Circle(r);



            Sphere s = new Sphere(r);
            Cylinder l = new Cylinder(r, h);

            IList<Shape> geoCollection = new List<Shape>();

            geoCollection.Add(s);
            geoCollection.Add(l);
            geoCollection.Add(c);


            foreach (Shape item in geoCollection)
            {
                if(item is Circle circle)
                {
                    //komplette circle Instanz
                }

                if (item is Sphere sphere)
                {
                    //komplette circle Instanz
                }
            }


            // Display results.
            Console.WriteLine("Area of Circle   = {0:F2}", c.Area());
            Console.WriteLine("Area of Sphere   = {0:F2}", s.Area());
            Console.WriteLine("Area of Cylinder = {0:F2}", l.Area());



            Rectangle rectangle = new Rectangle(10, 15);
            double rectangleAreaSize = rectangle.Area();

            Console.WriteLine(rectangle.ToString());

        }
    }




    #region Geometrie
    public class Shape
    {
        public const double PI = Math.PI;
        protected double x, y;

        public Shape()
        {
        }

        public Shape(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual double Area()
        {
            return x * y;
        }

        
    }

    public class Rectangle : Shape
    {
        //Hie müssen wir nichts überschreiben (x*y) reicht komplett aus für eine Rechtseckberechnung

        public Rectangle(double x, double y)
            :base(x, y)
        {

        }
        
    }

    public class Quatrat : Shape
    {

        public Quatrat(double x, double y)
           : base(x, y)
        {

        }

        public override double Area()
        {

            //Spezialisierung ist, dass ich validieren muss dass X un Y gleich sind. 
            if (x != y)
                throw new ArgumentException("x ist nicht gleich y");

            return base.Area();
        }
    }

    public class Circle : Shape
    {
        public Circle(double r) : base(r, 0)
        {
        }

        public override double Area()
        {
            return PI * x * x;
        }
    }

    class Sphere : Shape
    {
        public Sphere(double r) : base(r, 0)
        {
        }

        public override double Area()
        {
            return 4 * PI * x * x;
        }
    }

    class Cylinder : Shape
    {
        public Cylinder(double r, double h) : base(r, h)
        {
        }

        public override double Area()
        {
            return 2 * PI * x * x + 2 * PI * x * y;
        }
    }
    #endregion



    class MyBaseClass
    {
        // virtual auto-implemented property. Overrides can only
        // provide specialized behavior if they implement get and set accessors.
        public virtual string Name { get; set; }

        // ordinary virtual property with backing field
        private int num;
        public virtual int Number
        {
            get { return num; }
            set { num = value; }
        }
    }

    class MyDerivedClass : MyBaseClass
    {
        private string name;

        // Override auto-implemented property with ordinary property
        // to provide specialized accessor behavior.
        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    name = "Unknown";
                }
            }
        }
    }
}
