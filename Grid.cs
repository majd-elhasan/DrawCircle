using System;
 namespace CircleSpace 
 {
     public static class Grid
     {
        public static List<Point> points = new List<Point>();
        public static int boyut = 0;
        public static int input = -1; 
        public static void draw()
        {
            input = ConsoleProcessor.input();
            
            boyut = input *2 +1;
            
             
            for(int ey = -input ; ey< input+1; ey++)
            {
                for(int ex = -input ; ex< input+1; ex++)
                {
                Point point = new Point();
                point.y = ey;
                point.x = ex;
                points.Add(point);    
                }

            }
            
            
        }
    }
}
