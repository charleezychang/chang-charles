using System;

public class Functions
{
    static float MyFunctions(float x)
    {
        return(x/2);
    }

    public static void Main()
    {
        for(int x=0; x<10; x++)
        {
            Console.WriteLine("f(" + x + ") = " + MyFunctions(x));
        }
    }
}