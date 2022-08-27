class Program
{
    public static void Main()
    {
        //1. Trao doi gia tri cua 2 so neu so 1 lon hon so 2//
        Console.WriteLine("Trao doi gia tri cua 2 so");
        int k1, k2, o;
        Console.Write("Nhap vao so k1: ");
        k1 = int.Parse(Console.ReadLine());
        Console.Write("Nhap vao so k2: ");
        k2 = int.Parse(Console.ReadLine());
        o = k1 - k2;
        if ((k1 > k2) || (o > 0))
        {
            Console.WriteLine("Doi gia tri cua 2 so k1 va k2");
            k1 = k2;
            k2 = k2 + o;
            Console.WriteLine("Luc nay k1 la {0} va k2 la {1}", k1, k2);
        }
        else
        {
            Console.WriteLine("Khong co gi xay ra");
        }

        //2. Dau cua tich 3 so thuc ma khong tinh tich cua chung//
        Console.WriteLine("");
        Console.WriteLine("Dau cua tich 3 so thuc ma khong tinh tich cua chung");
        int k3, k4, k5;
        Console.Write("Nhap vao so k3: ");
        k3 = int.Parse(Console.ReadLine());
        Console.Write("Nhap vao so k4: ");
        k4 = int.Parse(Console.ReadLine());
        Console.Write("Nhap vao so k5: ");
        k5 = int.Parse(Console.ReadLine());
        if ((k3 > 0 && k4 > 0 && k5 > 0) || (k3 < 0 && k4 < 0 && k5 > 0) || (k3 < 0 && k4 > 0 && k5 < 0) || (k3 > 0 && k4 < 0 && k5 < 0))
        {
            Console.WriteLine("Tich 3 so duong");
        }
        else
            Console.WriteLine("Tich 3 so am");

        //3. Tim max 3 so voi if long nhau.
        Console.WriteLine("");
        Console.WriteLine("Tim max 3 so voi if long nhau");
        int k6, k7, k8;
        Console.Write("Nhap vao so k6: ");
        k6 = int.Parse(Console.ReadLine());
        Console.Write("Nhap vao so k7: ");
        k7 = int.Parse(Console.ReadLine());
        Console.Write("Nhap vao so k8: ");
        k8 = int.Parse(Console.ReadLine());

        if (k6 == k7 && k7 == k8)
        {
            Console.WriteLine("3 So bang nhau");
        }
        else
        {
            if (k6 >= k7)
                if (k6 > k8)
                {
                    Console.WriteLine("So lon nhat la: {0}", k6);
                }
                else
                {
                    Console.WriteLine("So lon nhat la: {0}", k8);
                }
            else
            {
                if (k7 >= k8)
                {
                    Console.WriteLine("So lon nhat la: " + k7);
                }
                else
                {
                    Console.WriteLine("So lon nhat la: " + k8);
                }
            }
        }

        //4. Viet ra chuoi 3 so thuc theo thu tu lon den be
        Console.WriteLine();
        Console.WriteLine("Viet ra chuoi 3 so thuc theo thu tu tu lon den be");
        Console.Write("Nhap vao so k9: ");
        double k9 = double.Parse(Console.ReadLine());
        Console.Write("Nhap vao so k10: ");
        double k10 = double.Parse(Console.ReadLine());
        Console.Write("Nhap vao so k11: ");
        double k11 = double.Parse(Console.ReadLine());
        Console.WriteLine("Chuoi thu tu tu lon den be la: ");
        if ((k9 > k10) && (k9 > k11))
        {
            if (k10 > k9)
            {
                Console.WriteLine("{0} {1} {2}", k9, k10, k11);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", k9, k11, k10);
            }
        }
        else if ((k10 > k9) && (k10 > k11))
        {
            if (k9 > k11)
            {
                Console.WriteLine("{0} {1} {2}", k10, k9, k11);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", k10, k11, k9);
            }
        }
        else if ((k11 > k9) && (k11 > k10))
        {
            if (k9 > k10)
            {
                Console.WriteLine("{0} {1} {2}", k11, k9, k10);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", k11, k10, k9);
            }
        }
        //5. Nhap vao 1 chu so tu 1 toi 9 de may tinh doc ra phat am//
        Console.WriteLine("") ;
        Console.WriteLine("Nhap vao 1 chu so tu 1 toi 9 de may tinh doc ra phat am: ");
        char k12;
        Console.Write("Nhap vao so k: ");
        k12 = Console.ReadKey().KeyChar;
        switch (k12)
        {
            case '0': Console.WriteLine("khong"); break;
            case '1': Console.WriteLine("mot"); break;
            case '2': Console.WriteLine("hai"); break;
            case '3': Console.WriteLine("ba"); break;
            case '4': Console.WriteLine("bon"); break;
            case '5': Console.WriteLine("nam"); break;
            case '6': Console.WriteLine("sau"); break;
            case '7': Console.WriteLine("bay"); break;
            case '8': Console.WriteLine("tam"); break;
            case '9': Console.WriteLine("chin"); break;
            default: Console.WriteLine("Error!"); break;
        }

        //6. Viet chuong trinh tim ra so lon nhat trong so 5 so duoc nhap vao//
        Console.WriteLine() ;
        Console.WriteLine("Viet chuong trinh tim ra so lon nhat trong so 5 so duoc nhap vao");
        int k13, k14, k15, k16, k17;
        Console.WriteLine("Nhap vao 5 so vao ben duoi: ");
        Console.Write("Nhap vao so k13: ");
        k13 = int.Parse(Console.ReadLine());
        Console.Write("Nhap vao so k14: ");
        k14 = int.Parse(Console.ReadLine());
        Console.Write("Nhap vao so k15: ");
        k15 = int.Parse(Console.ReadLine());
        Console.Write("Nhap vao so k16: ");
        k16 = int.Parse(Console.ReadLine());
        Console.Write("Nhap vao so k17: ");
        k17 = int.Parse(Console.ReadLine());
        if (k13 == k14 && k14 == k15 && k15 == k16 && k16 == k17)
        {
            Console.WriteLine("Khong co so lon nhat");
        }
        else
        {
            if ((k13 >= Math.Max(k14, k15)) && (k13 >= Math.Max(k16, k17)))
            {
                Console.WriteLine("So lon nhat la: " + k13);
            }
            else if ((k14 >= Math.Max(k13, k15)) && (k14 >= Math.Max(k16, k17)))
            {
                Console.WriteLine("So lon nhat la: " + k14);
            }
            else if ((k15 >= Math.Max(k13, k14)) && (k15 >= Math.Max(k16, k17)))
            {
                Console.WriteLine("So lon nhat la: " + k15);
            }
            else if ((k16 >= Math.Max(k13, k14)) && (k16 >= Math.Max(k15, k17)))
            {
                Console.WriteLine("So lon nhat la: " + k16);
            }
            else if ((k17 >= Math.Max(k13, k14)) && (k17 >= Math.Max(k15, k16)))
            {
                Console.WriteLine("So lon nhat la: " + k17);
            }
        }

        //7. Chuong trinh ap dung diem thuong cho diem trong pham vi 1-9//
        Console.WriteLine();
        Console.WriteLine("Chuong tri quy doi diem thuong");
        int k18;
        Console.Write("Nhap vao con so tu 1 toi 9: ");
        k18 = int.Parse(Console.ReadLine());
        switch (k18)
        {
            case 1:
            case 2:
            case 3:
                Console.WriteLine("So diem thuong la {0} ", k18 * 10);
                break;

            case 4:
            case 5:
            case 6:
                Console.WriteLine("So diem thuong la {0} ", k18 * 100);
                break;

            case 7:
            case 8:
            case 9:
                Console.WriteLine("So diem thuong la {0} ", k18 * 1000);
                break;

            default: Console.WriteLine("Khong phai la chu so"); break;

        }

        //8. Chuyen so sang mot chuoi tuong ung//
        Console.WriteLine();
        Console.Write("Nhap vao chu so bat ki tu 1 den 999: ");
        int n = int.Parse(Console.ReadLine());
        int k19 = n % 10;
        int k20 = (n / 10) % 10;
        int k21 = n / 100;
        if ((n < 1) || (n > 999))
        {
            Console.WriteLine("Nhap sai");
        }
        else
        {
            switch (k21)
            {
                case 0: Console.Write(""); break;
                case 1: Console.Write("Mot tram"); break;
                case 2: Console.Write("Hai tram"); break;
                case 3: Console.Write("Ba tram"); break;
                case 4: Console.Write("Bon tram"); break;
                case 5: Console.Write("Nam tram"); break;
                case 6: Console.Write("Sau tram"); break;
                case 7: Console.Write("Bay tram"); break;
                case 8: Console.Write("Tam tram"); break;
                case 9: Console.Write("Chin tram"); break;
            }
            if ((k20 % 10 == 0) && k19 != 0)
            {
                Console.Write(" le ");
            }
            else
            {
                switch (k20)
                {
                    case 1: Console.Write(" muoi "); break;
                    case 2: Console.Write(" hai muoi "); break;
                    case 3: Console.Write(" ba muoi "); break;
                    case 4: Console.Write(" bon muoi "); break;
                    case 5: Console.Write(" nam muoi "); break;
                    case 6: Console.Write(" sau muoi "); break;
                    case 7: Console.Write(" bay muoi "); break;
                    case 8: Console.Write(" tam muoi "); break;
                    case 9: Console.Write(" chin muoi "); break;
                }
            }
            switch (k19)
            {
                case 1: Console.Write("mot "); break;
                case 2: Console.Write("hai  "); break;
                case 3: Console.Write("ba  "); break;
                case 4: Console.Write("bon  "); break;
                case 5: Console.Write("nam  "); break;
                case 6: Console.Write("sau  "); break;
                case 7: Console.Write("bay  "); break;
                case 8: Console.Write("tam  "); break;
                case 9: Console.Write("chin  "); break;
            }

        }
    }
}




