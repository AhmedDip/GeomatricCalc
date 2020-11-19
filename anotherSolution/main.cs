using System;

public class Shape {
    private double area;
    private double perimeter;

    //Constructors
    public Shape() {
    }

    //Getters and Setters by pairs

    public double getArea() {
        return area;
    }

    public void setArea(double area) {
        this.area = area;
    }

    public double getPerimeter() {
        return perimeter;
    }

    public void setPerimeter(double perimeter) {
        this.perimeter = perimeter;
    }
}


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("tringles Base: ");
            double basee = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("tringles Height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Tringles t= new Tringles(basee, height);
            t.tringlesArea();
            t.tringlesPerimeters();
            t.showDetails();
            
            Console.WriteLine("\n");
            Console.WriteLine("Rengtangles Length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Regtangles Breadth: ");
            double breadth= Convert.ToDouble(Console.ReadLine());
            Rectangles R = new Rectangles(length, breadth);
            R.rectanglesArea();
            R.rectanglesPrimeters();
            R.showReactanglesDetails();
            
            Console.WriteLine("\n");
            Console.WriteLine("Circles radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Circles C = new Circles(radius);
            C.circleArea();
            C.circlesPerimeters();
            C.showCirclesDetails();

        }

    }
class Tringles : Shape
    {
        private double basee;
        private double height;
        
        public double GetBasee()
        {
            return basee;
        }
        public void SetBasee(double basee)
        {
            this.basee = basee;
        }
        public double GetHeight()
        {
            return height;
        }
        public void SetHeight(double height)
        {
            this.height = height;
        }
        public Tringles(double basee, double height)
        {
            this.basee = basee;
            this.height = height;
        }
        public void tringlesArea()
        {
            double Area = 0.5 * basee * height;
            base.setArea(Area);
            
            
            
        }
        public void tringlesPerimeters()
        {
            double  perimeters = basee * (2 * height);
            base.setPerimeter(perimeters);
           
        }
        public void showDetails()
        {
            Console.WriteLine("Area:{0}", base.getArea());
            Console.WriteLine("Perimeters:{0}", base.getPerimeter());
        }
        
       
        
            
    }
class Rectangles : Shape
    {
        private double length;
        private double breadth;

        public double GetLength()
        {
            return length;
        }
        public void SetLength(double length)
        {
            this.length = length;
        }
        public double GetBreadth()
        {
            return breadth;
        }
        public void SetBreadth(double breadth)
        {
            this.breadth = breadth;
        }
        public Rectangles( double length,double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public void rectanglesArea()
        {
            double Area = length * breadth;
            base.setArea(Area);
            
        }
        public void rectanglesPrimeters()
        {
            double perimeters = 2 * (length + breadth);
            base.setPerimeter(perimeters);
            
        }
        public void showReactanglesDetails()
        {
            Console.WriteLine("Area of Rectangles:" + base.getArea());
            Console.WriteLine("Primeters of Rectangles:" + base.getPerimeter());
        }
       
    }
class Circles : Shape
    {
        private double radius;

        public const double pie = 3.1416;
        public double GetRadius()
        {
            return radius;
        }
        public void SetRadius(double radius)
        {
            this.radius = radius;
        }
        
       
        public Circles(double radius)
        {
            this.radius = radius;
            
        }
        public void circleArea()
        {
            double Area=  pie * radius*radius;
            base.setArea(Area);
            
        }
        public void circlesPerimeters()
        {
            double perimeters = 2 * pie * radius;
            base.setPerimeter(perimeters);
            
        }
        public void showCirclesDetails()
        {

            Console.WriteLine("Area for Circle:" + base.getArea());
            Console.WriteLine("Perimeters of Circle:" + base.getPerimeter());
        }
       }   
