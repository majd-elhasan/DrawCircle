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
                if(item.x == 0 && item.y == 2)
                {
                    item.symbol = 'o';
                }
            }
            Console.WriteLine();
            for(int i = 0 ; i < Grid.boyut ; i++)
            {
                for(int j = 0; j < Grid.boyut ; j++)
                {
                    foreach(var item in Grid.points)
                    {
                        if(item.x == i && item.y == j)
                        {
                            Console.Write(item.symbol);
                        }
                    }
                }
                Console.WriteLine();
            }
        }
     }
 }
