using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
  class Program
  {
    // deklarasi objek collection untuk menampung mahasiswa
    static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

    static void Main(string[] args)
    {
      Console.Title = "Responsi UAS Matakuliah Pemrograman";

      while (true)
      {
        TampilMenu();

        Console.Write("\nNomor Menu [1..4] : ");
        int nomorMenu = Convert.ToInt32(Console.ReadLine());

        switch (nomorMenu)
        {
          case 1:
            TambahMahasiswa();
            break;
          case 2:
            HapusMahasiswa();
            break;
          case 3:
            TampilMahasiswa();
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
      // PERINTAH: lengkapi kode untuk menampilkan menu

      Console.WriteLine("Pilih Menu Aplikasi\n");
      Console.WriteLine("1. Tambah Mahasiswa ");
      Console.WriteLine("2. Hapus Mahasiswa ");
      Console.WriteLine("3. Tampilkan Mahasiswa ");
      Console.WriteLine("4. Keluar");
    }

    static void TambahMahasiswa()
    {
      Console.Clear();
      // PERINTAH: lengkapi kode untuk menambahkan produk ke dalam collection

      Produk produk = new Produk();
      Console.WriteLine("Tambah Mahasiswa \n");
      Console.Write("NIM : ");
      mahasiswa.NIM = Console.ReadLine();
      Console.Write("Nama Mahasiswa : ");
      mahasiswa.Nama = Console.ReadLine();
      Console.Write("Jenis Kelamin  : ");
      mahasiswa.kelamin = double.Parse(Console.ReadLine());
      Console.Write("IPK  : ");
      mahasiswa.IPK = double.Parse(Console.ReadLine());
      daftarProduk.Add(produk);

      Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
      Console.ReadKey();
    }

    static void HapusMahasiswa()
    {
      Console.Clear();
      // PERINTAH: lengkapi kode untuk menghapus produk dari dalam collection

      int nomor = -1, hapus = -1;
      Console.WriteLine();
      Console.WriteLine("Hapus Data Mahasiswa\n");
      Console.Write("NIM : ");
      string kodeP = Console.ReadLine();
      foreach (Mahasiswa in daftarMahasiswa)
      {
        nomor++;
        if (Mahasiswa.NiM == NIMP)
        {
          hapus = nomor;
        }
      }
      if (hapus!=-1)
      {
        daftarProduk.RemoveAt(hapus);
        Console.Write("\nData Mahasiswa dengan Nim Mahasiswa : ");
        Console.Write(kodeP);
        Console.WriteLine(" Data Mahasiswa berhasil di hapus");
      }
      else
      {
        Console.WriteLine("\nNIM tidak ditemukan ");
      }

      Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
      Console.ReadKey();
    }

    static void TampilProduk()
    {
      Console.Clear();
      // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection

      int urutan = 0;
      Console.WriteLine("Data Mahasiswa\n");
      foreach (Mahasiswa in daftarMahasiswa)
      {
        urutan++;
        Console.WriteLine("{0}. NIM  : {1} \n   Nama Mahasiswa  : {2} \n   jenis kelamin   : {3} \n   IPK   : {4}", urutan, Mahasiswa.NIM, Mahasiswa.Nama, Mahasiswa.kelamin, Mahasiswa.IPK);
      }
      if (urutan<1)
      {
        Console.WriteLine("\nData Mahasiswa \n");
      }

      Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
      Console.ReadKey();
    }
  }
}
