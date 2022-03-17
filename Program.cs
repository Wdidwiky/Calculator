Console.Title = "Aplikasi Calculator";

Console.Write("Pilih menu calculator: ");
Console.WriteLine();
Console.WriteLine("1. Penjumlahan");
Console.WriteLine("2. Pengurangan");
Console.WriteLine("3. Perkalian");
Console.WriteLine("4. Pembagian");
Console.WriteLine();
Console.Write("Input nomor menu [1..4]: ");
int pilihan = int.Parse(Console.ReadLine());
Console.WriteLine();
switch (pilihan)
{
    case 1:
        Console.Write("Inputkan nilai a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Inputkan nilai b = ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Hasil penambahan " + a + " + " + b + " = " + Method.Penambahan(a, b));
        break;
    case 2:
        Console.Write("Inputkan nilai a = ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Inputkan nilai b = ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Method.pengurangan(a, b));
        break;
    case 3:
        Console.Write("Inputkan nilai a = ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Inputkan nilai b = ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Hasil perkalian {0} * {1} = {2}", a, b, Method.Perkalian(a, b));
        break;
    case 4:
        Console.Write("Inputkan nilai a = ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Inputkan nilai b = ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Method.Pembagian(a, b));
        break;
    default:
        Console.WriteLine("Maaf menu yang Anda pilih tidak tersedia");
        break;
}
Console.WriteLine();
Console.WriteLine("Tekan sembarang key untuk keluar");
Console.ReadKey();
