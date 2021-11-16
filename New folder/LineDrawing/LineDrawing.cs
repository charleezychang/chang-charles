using System;
public static class LineDrawing
{
    static void DrawCharacter(int x, int y, char c)
    {
        Console.SetCursorPosition(x,y);
        Console.Write(c);
    }


    static void DrawLine(int startx, int starty, int length)
    {

    }  

    public static void Main()
    {
        Console.Clear();
        // for (int y = 1; y<=19; y=y+2)
        // {
        //     for (int x = 1; x<=10; x++)
        //     {
        //         float z = y/2 + 1;
        //         if (x<=z)
        //         {   
        //             // Console.SetCursorPosition(x,y);
        //             if (x<=(y/4+1))
        //             {
        //                 DrawCharacter(x, y, 'X');
        //             }
        //             else
        //             {
        //                 DrawCharacter(x, y, 'Y');
        //             }
        //         }
        //     } 
        // }
        
    int z=1;
    int w=19;
            for (int y = 19; y>=1; y=y-2)
            {

                    for (int x=z; x<=w; x++)
                    {
                        DrawCharacter(x, y, 'X');
                    } 
                        z++;
                        w--;
            }


    
    int a=18;
    int b=1;
        for (int y = 18; y>=1; y=y-2)
        {
            for(int x=b; x<=b; x++)
            {
                DrawCharacter(x, y, '/');
            }
                b++;
                a--;
        }
    

    int c=19;
    int d=1;
        for (int y = 18; y>=1; y=y-2)
        {
                DrawCharacter(c, y, '\\');
                d++;
                c--;
        }

    int e=10;
    for (int y = 18; y>=1; y=y-2)
        {
                DrawCharacter(e, y, '|');
        }


    int f=1;
    int g=19;
            for (int y = 19; y>=1; y=y-2)
            {

                    for (int x=z; x<=w; x++)
                    {
                        DrawCharacter(x, y, 'Y');
                    } 
                        f++;
                        g--;
            }
    Console.ReadLine();
    }

    
}