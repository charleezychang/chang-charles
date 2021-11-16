public class MyIfElseProgram
{
    public static void Main() 
    {
        int n;
        for (n=0; n<21; n++)
        {
            if(n == 0)
            {
                Console.WriteLine("First one: " + n);
            }
            else if(n < 5)
            {
                Console.WriteLine("Less than five: " + n);
            }
            else if(n==10 || n==11)
            {
                Console.WriteLine("Ten or Eleven: " + n);
            }
            else if(n>12 && n<19)
            {
                Console.WriteLine("Yehey!");
            }
            else
            {
                Console.WriteLine("NOT less than five: " + n);
            }
        }
    }
}