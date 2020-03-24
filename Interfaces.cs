using System;  
public interface Shape  
{  
    void draw();  
}  
public class Rectangle : Shape  
{  
    public void draw()  
    {  
        Console.WriteLine("drawing rectangle...");  
    }  
}  
public class Circle : Shape  
{  
    public void draw()  
    {  
        Console.WriteLine("drawing circle...");  
    }  
}  
public class MainClass
{  
    public static void Main()  
    {  
       Shape s;  
        s = new Rectangle();  
        s.draw();  
        s = new Circle();  
        s.draw();  
    }  
}  