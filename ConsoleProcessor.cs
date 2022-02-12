using System;
 namespace CircleSpace 
 {
     public static class ConsoleProcessor
     {
        static Exception e = new Exception("lütfen console penceresi büyük olmadığı için 44'den küçük bir sayı giriniz. ");
        public static int input()
        {
            
            int yariçap =-1;
            Console.WriteLine("lütfen daire yarıçap uzunluğunu giriniz.");
            convert();
            void convert(){
                try
                {
                yariçap = Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("lütfen bir sayı giriniz.");
                    convert();
                }
                if (yariçap > 43){
                    Console.WriteLine(e.Message);
                    convert();
                }
            }
            return yariçap;
        }
     }
 }