using System;

namespace ortalamahesap
{
    class Program
    {
        static void Main(string[] args)
        {      //notları al katsayı ile çarp topla geçermi kalır mı belirle 
            int vize, katılım, final;
            double ort;
            Console.WriteLine("Vize notu girin: ");
            vize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ders katılım notu girin: ");
            katılım = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final notu girin: ");
            final = Convert.ToInt32(Console.ReadLine());
            
            ort = (vize * 0.3) + (katılım * 0.1) + (final * 0.6);
            Console.WriteLine("Ortalamanız:" +ort);

            if (ort > 65 )
            {
                Console.WriteLine("GEÇTİNİZ");
            }
            else if (ort < 65 )
            {
                Console.WriteLine("KALDINIZ");
            }



        }
    }
}
