using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimPhanTuLonNhatTrongMang2Chieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Khởi tạo mảng 2 chiều với số dòng + cột và giá trị các phần từ cố định

            /* int[,] mang2chieu =
            {
                {4,5,12,4},
                {9,42,24,1},
                {11,5,23,32}
            }; */

            //Khởi tạo mảng 2 chiều với số dòng và cột được nhập từ bàn phím
            /*Console.Write("Nhap so dong: ");
            int sodong = int.Parse(Console.ReadLine());

            Console.Write("Nhap so cot: ");
            int socot = int.Parse(Console.ReadLine());

            Console.WriteLine(); */
            int sodong, socot;

            do
            {

                Console.Write("Nhap so dong: ");
                sodong = int.Parse(Console.ReadLine());
                if (sodong > 5)
                {
                    Console.WriteLine("So khong duoc vuot qua 5");
                }
               Console.WriteLine();
            }
            while ( sodong > 5);

            do
            {

                Console.Write("Nhap so cot: ");
                socot = int.Parse(Console.ReadLine());
                if (socot > 5)
                {
                    Console.WriteLine("So khong duoc vuot qua 5");
                }
                Console.WriteLine();
            }
            while (socot > 5);




            //nhập giá trị cho các phần tử từ bàn phím
            int[,] mang2chieu = new int[sodong, socot];
            for (int m = 0;  m < socot; m++)
            {
                for (int n = 0; n < sodong; n++)
                {
                    Console.Write("Nhap phan tu dong {0} cot {1}: ",(n + 1),(m + 1));
                    mang2chieu[n,m]=long.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }

            //In ra mảng 2 chiều vừa khởi tạo
            Console.WriteLine("Mang 2 chieu vua khoi tao: ");
            for (int m = 0;m < socot; m++)
            {
                for (int n = 0;n < sodong; n++)
                {
                    Console.Write(mang2chieu[n,m] + " ");
                }
                Console.WriteLine() ;
            }

           
            int solonnhat=mang2chieu[0,0];
            int vitridong = 1;
            int vitricot = 1;

            //dùng 2 vòng lặp for để truy xuất đến các phần tử (cột => dòng)
            for (int i = 0; i < mang2chieu.GetLength(0); i++)
            {
                for (int j = 0; j < mang2chieu.GetLength(1); j++)
                    {
                    if (mang2chieu[i, j] > solonnhat) //code giống mảng 1 chiều nhưng thay mang[i] => mang2chieu[i,j]
                    {
                        solonnhat = mang2chieu[i, j];
                        vitridong = i + 1;
                        vitricot = j + 1;
                    }
                }
            }

            Console.WriteLine("\n Gia tri lon nhat trong mang 2 chieu la {0}, o vi tri dong {1} cot {2}", solonnhat, vitricot, vitridong);

            Console.ReadKey();
        }
    }
}
