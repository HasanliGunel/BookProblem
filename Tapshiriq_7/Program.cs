using System;

namespace Tapshiriq_7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            for(; ; )
            {
                Console.Clear();
                Console.WriteLine("Kitab daxil etmek uchun '1'-i basin.\nKitab siyahisini gormek uchun '2'-ye basin\nSiyahidan kitab silmek uchun '3'-e basin\nSiyahini yenilemek uchun '4'-e basin\nProqramdan cixish ucun '0'-a basin");
                int t = Convert.ToInt32(Console.ReadLine());
                if (t == 0)
                    break;
                switch (t)
                {
                    case 1:
                        Console.WriteLine("Daxil olunacaq kitablarin sayi:");
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= n; i++)
                        {
                            Method.Append();
                        }
                        break;
                    case 2:
                        Method.Show();
                        break;
                    case 3:
                        Method.Remove();
                        break;
                    case 4:
                        Method.Update();
                        break;
                    default:
                        Console.WriteLine("Yuxarida verilimish menyudan istifade edin!");
                        break;

                }
                char c = Console.ReadKey().KeyChar;
            }
            
        }
    }
}
