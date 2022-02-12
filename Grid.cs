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
            
             
            for(int ey = 0 ; ey< boyut; ey++)
            {
                for(int ex = 0 ; ex< boyut; ex++)
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
