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
        for (int y = length; y>=starty; y=y-1)
        {
            if(y%2!=0)
            {
                int NoOfY = (y/2) % 2 == 0 ?  (y/2) - 1 : (y/2); 
                int yValueStarts=  (y - NoOfY) /2 + 1;
                int yValueEnd= yValueStarts-1 + NoOfY;   
                for (int x=1; x<=y; x++)
                {
                    if (x >= yValueStarts &&  x <=yValueEnd)
                    {
                        DrawCharacter((x+startx-1), y, 'Y');
                    }
                    else 
                    {
                        DrawCharacter((x+startx-1), y, 'X');
                    }
                } 
                startx++;
            }
            else
            {
                DrawCharacter(startx-1, y, '/');
                DrawCharacter(10, y, '|');
                DrawCharacter(y+startx-1, y, '\\');
            }
        }       
    }

    static void Message(int startx, int starty, string msg)
    {
        int j=0;
        int numOfChar = msg.Length;
        for (int i=startx; i <= (startx+numOfChar-1); i++)
        {   
                DrawCharacter(i, starty, msg[j]);
                j++;
        }
    }

    public static void Main()
    {
        Console.Clear();
        DrawLine(1, 1, 19);
        Message(20, 10, "Meri Kurismasu!");
        Console.ReadLine();
    }
}

        // int z = 0;
        // for (int y = 19; y>=1; y=y-1)
        // {
        //     if(y%2!=0)
        //     {
        //         int NoOfY = (y/2) % 2 == 0 ?  (y/2) - 1 : (y/2); 
        //         int yValueStarts=  (y - NoOfY) /2 + 1;
        //         int yValueEnd= yValueStarts-1 + NoOfY;   
        //         for (int x=1; x<=y; x++)
        //         {
        //             if (x >= yValueStarts &&  x <=yValueEnd)
        //             {
        //                 DrawCharacter((x+z), y, 'Y');
        //             }
        //             else 
        //             {
        //                 DrawCharacter((x+z), y, 'X');
        //             }
        //         } 
        //         z++;
        //     }
        //     else
        //     {
        //         DrawCharacter(z, y, '/');
        //         DrawCharacter(10, y, '|');
        //         DrawCharacter(y+z, y, '\\');
        //     }
        // }
