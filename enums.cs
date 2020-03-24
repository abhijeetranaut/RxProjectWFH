using System;  
public class EnumExample  
{  
    public enum Season { WINTER=10, SPRING, SUMMER }    
  
    public static void Main()  
    {  
        int x = (int)Season.WINTER;  
        int y = (int)Season.SPRING;
        int z = (int)Season.SUMMER;
        
        Console.WriteLine("WINTER = {0}", x);  
        Console.WriteLine("SPRING = {0}",y);
        Console.WriteLine("SUMMER = {0}", z);  
    }  
}  