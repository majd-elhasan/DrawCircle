using System;
 namespace CircleSpace 
 {
     public static class Circle
     {
        public static void draw()
        {
            int input = Grid.input;
            int Merkez = input ;
            foreach (var item in Grid.points)
            {
             Console.WriteLine(" X  : " + item.x+ "     Y  : " + item.y);       
    
            }
            Console.WriteLine(Grid.points.Count);
            foreach (var item in Grid.points)
            {
                float leftSide = item.x*item.x + item.y*item.y;
                float RightSide = input*input;
                if(Math.Round(leftSide/10) == Math.Round(RightSide/10))
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
                            Console.Write(' ');
                        }
                    }
                }
                Console.WriteLine();
            }
        }
     }
 }
