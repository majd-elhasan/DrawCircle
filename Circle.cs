using System;
 namespace CircleSpace 
 {
     public static class Circle
     {
        public static void draw()
        {
            int input = Grid.input;
            int Merkez = input ;
            Console.WriteLine(Grid.boyut + " X "+ Grid.boyut + " pixel square");
            foreach (var item in Grid.points)
            {
                float leftSide = item.x*item.x + item.y*item.y;
                float RightSide = input*input;
                if(Math.Round(leftSide/(input*2.5f)) == Math.Round(RightSide/(input*2.5f)))
                {
                    item.symbol = 'o';
                }
            }
            Console.WriteLine();
            for(int i = -input ; i <= input ; i++)
            {
                for(int j = -input; j <= input ; j++)
                {
                    foreach(var item in Grid.points)
                    {
                        if(item.x == i && item.y == j)
                        {
                            Console.Write(item.symbol);
                            Console.Write(item.symbol);
                        }
                    }
                }
                Console.WriteLine();
            }
        }
     }
 }
