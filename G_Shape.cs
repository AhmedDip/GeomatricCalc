using System; 

//Reference baseclass 

public abstract class Shape {
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

    //Customized Methods
    public abstract double calculatePerimeter();
    public abstract double calculateArea();
    public abstract void showData();
}

//Reference subclass 1
class Circle : Shape {

    //Atributes
    private double radius;

    //Constructors
    public Circle() : base() {
    }

    public Circle(double radius) {
        this.radius = radius;
        base.setArea(calculateArea());
        base.setPerimeter(calculatePerimeter());
    }

    //Getters and setters by pairs
    public double getRadius() {
        return radius;
    }

    public void setRadius(double radius) {
        this.radius = radius;
    }

    //Customiezed methods
    public override double calculatePerimeter() {
        double circlePerimeter = 2*getRadius() * Math.PI;
        base.setPerimeter(circlePerimeter);
        return circlePerimeter;
    }

    public override double calculateArea() {
        double circleArea = Math.PI * Math.Pow(getRadius(), 2);
        base.setArea(circleArea);
        return circleArea;
    }
    
    public override void showData(){
        Console.WriteLine("Circle's radius: "+ Math.Round(getRadius())+ " cms.");
        Console.WriteLine("Perimeter: "+ String.Format("{0:.##}", getPerimeter()) + " cms.");
        Console.WriteLine("Area: " + String.Format("{0:.##}", getArea()) + " sq. cms.");
    }
}

// //Reference subclass 2
class Triangle : Shape {

    //Atributes
    private double height;
    private double basee;
    //Constructors


    public Triangle(double height, double basee) : base() {
        this.height = height;
        this.basee = basee;
        base.setArea(calculateArea());
        base.setPerimeter(calculatePerimeter());
    }
    
    //Getters and setters by pairs
    
    
    public double getHeight() {
        return height;
    }

    public void setHeight(double height) {
        this.height = height;
    }

    public double getBase() {
        return basee;
    }

    public void setBase(double basee) {
        this.basee = basee;
    }

    //Customized methods
    
    public override double calculatePerimeter() {
        double perimeter = (2*getHeight()) + getBase();
        base.setPerimeter(perimeter);
        return perimeter;
    }

    public override double calculateArea(){
        double area = 0;
        area = (getBase()*getHeight())/2;
        setArea(area);
        return area;
    } 
    
    public override void showData(){
        Console.WriteLine("Triangle's height: "+ getHeight() + " cms.");
        Console.WriteLine("Triangle's base: "+ getBase() + " cms.");
        Console.WriteLine("Triangle's Perimeter: "+ String.Format("{0:.##}", getPerimeter()) + " cms.");
        Console.WriteLine("Triangle's Area: " + String.Format("{0:.##}", getArea()) + " sq. cms.");
    }
}

// //Reference subclass 3
class Rectangle : Shape {

    //Atributes
    private double breadth;
    private double length;
    //Constructors


    public Rectangle(double breadth, double length) : base() {
        this.breadth = breadth;
        this.length = length;
        base.setArea(calculateArea());
        base.setPerimeter(calculatePerimeter());
    }
    
    //Getters and setters by pairs
    
    
    public double getBreadth() {
        return breadth;
    }

    public void setBreadth(double breadth) {
        this.breadth = breadth;
    }

    public double getLength() {
        return length;
    }

    public void setLength(double length) {
        this.length = length;
    }

    //Customized methods
    
    public override double calculatePerimeter() {
        double perimeter = 2*(getBreadth() + getLength());
        base.setPerimeter(perimeter);
        return perimeter;
    }

    public override double calculateArea(){
        double area = 0;
        area = (getLength()*getBreadth());
        setArea(area);
        return area;
    } 
    
    public override void showData(){
        Console.WriteLine("Rectangle's breadth: "+ getBreadth() + " cms.");
        Console.WriteLine("Rectangle's length: "+ getLength() + " cms.");
        Console.WriteLine("Rectangle's Perimeter: "+ String.Format("{0:.##}", getPerimeter()) + " cms.");
        Console.WriteLine("Rectangle's Area: " + String.Format("{0:.##}", getArea()) + " sq. cms.");
    }
}

// Main class

class Executor {
    static void Main(String[] args) {

        Circle circle = new Circle();
        Console.WriteLine("Enter circle's radius: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        circle.setRadius(radius);
        circle.calculateArea();
        circle.calculatePerimeter();
        circle.showData();
        
        Console.WriteLine("\n");
        
        Console.WriteLine("Enter triangle's base: ");
        double basee = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter triangle's height: ");
        double height = Convert.ToDouble(Console.ReadLine());
        Triangle triangle = new Triangle(height, basee);
        triangle.showData();
        
        Console.WriteLine("\n");
        
        Console.WriteLine("Enter rectangle's breadth: ");
        double breadth = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter rectangle's length: ");
        double length = Convert.ToDouble(Console.ReadLine());
        Rectangle rectangle = new Rectangle(breadth, length);
        rectangle.showData();
        
    }
}
