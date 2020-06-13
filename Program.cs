using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace AbstractClass
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nama\t\t: DHIMAS ALVI HIDAYAH");
            Console.WriteLine("NIM\t\t: 19.11.2805");
            Console.WriteLine("Kelas\t\t: 19 IF 04");


            Console.WriteLine();

            Console.WriteLine("^^^^ ANDROID ^^^^");

            Console.WriteLine();

            ACOperatingSystem android;

            android = new SAMSUNG();
            android.pendiri();
            android.platform();
            android.jenis();

            Console.WriteLine();

            android = new ASUS();
            android.pendiri();
            android.platform();
            android.jenis();


            Console.WriteLine();

            Console.WriteLine(" ^^^^ MAKANAN ^^^^");

            Console.WriteLine();

            Makanan makanan;

            makanan = new Cilok();
            makanan.Asal();
            makanan.jenis();

            Console.WriteLine();

            makanan = new Sosis();
            makanan.Asal();
            makanan.jenis();
        }
    }

    // Abstract Class 
    public abstract class ACOperatingSystem
    {
        public abstract void pendiri();
        public abstract void platform();
        public abstract void jenis();
    }

    public class SAMSUNG : ACOperatingSystem
    {
        public override void pendiri()
        {
            Console.WriteLine("Industri : SAMSUNG ");
        }

        public override void platform()
        {
            Console.WriteLine("Plaatform : Hight Cuality ");
        }

        public override void jenis()
        {
            Console.WriteLine("Jenis : SAMSUNG A10 ");
        }
    }

    public class ASUS : ACOperatingSystem
    {
        public override void pendiri()
        {
            Console.WriteLine("pendiri : ASUS ");
        }

        public override void platform()
        {
            Console.WriteLine("platform : Hight cuality ");
        }

        public override void jenis()
        {
            Console.WriteLine("Jenis : ASUS ROG PHONE ");
        }
    }

    // Interface Class Makanan

    public interface Makanan
    {
        void Asal();
        void jenis();
    }

    public class Cilok : Makanan
    {
        public void Asal()
        {
            Console.WriteLine(" Indonesia ");
        }

        public void jenis()
        {
            Console.WriteLine(" Jenis: Junk Food ");
        }

        public void asal()
        {
            throw new NotImplementedException();
        }
    }


    public class Sosis : Makanan
    {
        public void Asal()
        {
            Console.WriteLine(" IRAQ ");
        }
        public void jenis()
        {
            Console.WriteLine(" Jenis : Makanan Berat");
        }

        public void asal()
        {
            throw new NotImplementedException();
        }
    }

}