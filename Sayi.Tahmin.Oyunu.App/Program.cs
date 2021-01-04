using System;

namespace Sayi.Bilme.Oyunu
{
    class Program
    {
        static void Main(string[] args)
        {

            Random biron = new Random();
            int randomon = biron.Next(10);

            Random biryirmi = new Random();
            int randomyirmi = biryirmi.Next(20);

            Random birotuz = new Random();
            int randomotuz = birotuz.Next(30);

        tekrar:
            Console.Clear();
            Console.WriteLine("Zorluk Seviyeleri\n-Kolay\n-Orta\n-Zor");
            Console.Write("Zorluk Seviyesi Seçiniz:");
            string level = Console.ReadLine().ToLower();


            if (level == "kolay")
            {
                Console.WriteLine("KOLAY SEVİYE(1 İLE 10 ARASINDA RANDOM SAYIYI TAHMİN ET (5 HAKKINIZ VAR))");
                byte kalanhak5 = 5;
                for (int i = 0; i < 5; i++)
                {
                    byte hit5 = byte.Parse(Console.ReadLine());
                    if (hit5 == randomon)
                    {
                        Console.WriteLine("Doğru bildiniz");

                        int dogrubil = 1;
                        {
                            if (dogrubil == 1)
                                Console.WriteLine("Sayıyı bildiniz tekrar oynamak için bir tuşa basınız");
                            Console.ReadKey();
                            goto tekrar;

                        }



                    }
                    else if (i == 4)
                    {
                        Console.WriteLine("Hakkınız kalmadı");
                        int yanlisbil = 1;
                        if (yanlisbil == 1)
                        {
                            Console.WriteLine("Sayıyı bilemediniz tekrar oynamak için bir tuşa basınız");
                            Console.ReadKey();
                            goto tekrar;

                        }


                    }
                    else
                    {
                        kalanhak5--;
                        Console.WriteLine("Tekrar deneyin.. kalan hakkınız:");
                        Console.WriteLine(kalanhak5);
                    }
                }
            }
            else if (level == "orta")
            {
                Console.WriteLine("ORTA SEVİYE(1 İLE 20 ARASINDA RANDOM SAYIYI TAHMİN ET (8 HAKKINIZ VAR))");
                byte kalanhak8 = 8;
                for (int i = 0; i < 8; i++)
                {
                    byte hit8 = byte.Parse(Console.ReadLine());
                    if (hit8 == randomyirmi)
                    {
                        Console.WriteLine("Doğru bildiniz");
                        int dogrubil = 1;
                        {
                            if (dogrubil == 1)
                                Console.WriteLine("Sayıyı bildiniz tekrar oynamak için bir tuşa basınız");
                            Console.ReadKey();
                            goto tekrar;

                        }

                    }
                    else if (i == 7)
                    {
                        Console.WriteLine("Hakkınız kalmadı");
                        int yanlisbil = 1;
                        if (yanlisbil == 1)
                        {
                            Console.WriteLine("Sayıyı bilemediniz tekrar oynamak için bir tuşa basınız");
                            Console.ReadKey();
                            goto tekrar;

                        }
                    }
                    else
                    {
                        kalanhak8--;
                        Console.WriteLine("Tekrar deneyin.. kalan hakkınız:");
                        Console.WriteLine(kalanhak8);
                    }
                }
            }
            else if (level == "zor")
            {
                Console.WriteLine("ZOR SEVİYE(1 İLE 30 ARASINDA RANDOM SAYIYI TAHMİN ET (10 HAKKINIZ VAR))");
                byte kalanhak10 = 10;
                for (int i = 0; i < 10; i++)
                {
                    byte hit10 = byte.Parse(Console.ReadLine());
                    if (hit10 == randomotuz)
                    {
                        Console.WriteLine("Doğru bildiniz");
                        int dogrubil = 1;
                        if (dogrubil == 1)
                        {
                            Console.WriteLine("Sayıyı bildiniz tekrar oynamak için bir tuşa basınız");
                            Console.ReadKey();
                            goto tekrar;

                        }
                    }
                    else if (i == 9)
                    {
                        Console.WriteLine("Hakkınız kalmadı");
                        int yanlisbil = 1;
                        if (yanlisbil == 1)
                        {
                            Console.WriteLine("Sayıyı bilemediniz tekrar oynamak için bir tuşa basınız");
                            Console.ReadKey();
                            goto tekrar;

                        }
                    }
                    else
                    {
                        kalanhak10--;
                        Console.WriteLine("Tekrar deneyin.. kalan hakkınız:");
                        Console.WriteLine(kalanhak10);
                    }
                }
            }



        }
    }
}











