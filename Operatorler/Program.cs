using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("*****Atama ve İşlemli Atama");
            // Atama ve İşlemli Atama

            int x = 3;
            int y = 3;
            y = y + 2;

            Console.WriteLine(y);
            y += 2; //y+2'nin 
            Console.WriteLine(y);
            y/=1;   //y/1'in karşılığı
            Console.WriteLine(y);
            x *= 2; //x*2'nin karşılığı
            Console.WriteLine(x);

            Console.WriteLine("*****Mantıksal Operatörler");

            //Mantıksal Operatörler
            // ||, &&, !

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                Console.WriteLine("Perfect!");
            
            if(isSuccess || isCompleted)
                Console.WriteLine("Great!");
            
            if(isSuccess && !isCompleted)
                Console.WriteLine("Fine!");

            Console.WriteLine("*****İlişkisel Operatörler");
            //İlişkisel Operatörler
            // <, >, <=, >=, ==, !=

            int a= 3;
            int b= 4;

            bool sonuc= a<b;
            
            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a<=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);

            Console.WriteLine("*****Aritmetik Operatörler");
            // /, *, +, - 

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 = sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 =sayi1++ ;
            Console.WriteLine(sayi1);

            // %: Mod almak için kullanılır.

            int sonuc2 = 20%3;
            Console.WriteLine(sonuc2);




        }
    }
}
