using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCustomer
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek customer
        static List<Customer> daftarCustomer = new List<Customer>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahCustomer();

                        break;

                    case 2:
                        HapusCustomer();
                        break;

                    case 3:
                        TampilCustomer();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            Console.WriteLine("Pilih Menu Aplikasi: ");
            Console.WriteLine("\n1. Tambah Customer\n2. Hapus Customer\n3. Tampilkan Customer\n4. Keluar");

        }

        static void TambahCustomer()
        {
            Console.Clear();

            Customer custom = new Customer();

            Console.WriteLine("Tambah Data Customer");
            Console.Write("Kode Customer: ");
            custom.KodeCustomer = Console.ReadLine();
            Console.Write("Nama Customer: ");
            custom.Nama = Console.ReadLine();
            Console.Write("Total Piutang: ");
            custom.Piutang = Console.ReadLine();

            daftarCustomer.Add(custom);
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusCustomer()
        {
            Console.Clear();

            Console.WriteLine("Hapus Data Customer");
            Console.Write("Kode Customer: ");
            string Kode = Console.ReadLine();

            List<int> found = new List<int>();
            int index = 0;
            foreach (Customer caricust in daftarCustomer)
            {
                if (caricust.KodeCustomer == Kode)
                {
                    found.Add(index);
                }
                index++;
            }
            if (found.Count == 0)
            {
                Console.WriteLine("\nKode Customer tidak ditemukan");
            }
            else
            {
                for (int i = found.Count; i > 0; i--)
                {
                    daftarCustomer.RemoveAt(found[i - 1]);
                }

                Console.WriteLine("\nData Customer berhasil dihapus");
                }
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
                Console.ReadKey();

            }
        

        static void TampilCustomer()
        {
            Console.Clear();
            Console.WriteLine("Data Customer\n");
            
            int index = 0;
            foreach (Customer custom in daftarCustomer)
            {
            Console.WriteLine("{0}. {1}, {2}, {3}", index+1, custom.KodeCustomer, custom.Nama, custom.Piutang);
            index++;
            }

                Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
