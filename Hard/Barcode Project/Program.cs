using IronBarCode;
using System;


Baslangic:
string path = "E:\\Github\\CSharp-General-Projects\\Hard\\Barcode Project\\Barcodes\\";
string date = $"{DateTime.Now.Year}-{DateTime.Now.Month}-{DateTime.Now.Day}-{DateTime.Now.Hour}-{DateTime.Now.Minute}-{DateTime.Now.Second}";
Console.WriteLine("\nYapmak istediğiniz işlemi seçin! \n 1.Barkod Üret \n 2.Barkod Oku \n 3.Çıkış Yap \n-----------------------------------");
switch (Console.ReadLine())
{
    case "1":
        Uret();
        break;
    case "2":
        Oku();
        break;
    case "3":
        Console.WriteLine("Oturum sonlandırıldı!");
        Environment.Exit(0);
        break;
    default:
        Console.WriteLine("Geçersiz seçim yaptınız! \n");
        goto Baslangic;
}

void Uret()
{
    try
    {
        Console.Write("Barkod üretmek için metni girin: ");
        var myBarcode = BarcodeWriter.CreateBarcode(Console.ReadLine(), BarcodeWriterEncoding.Code128, 1500, 1000);
        myBarcode.SaveAsImage($"{path}barcode-{date}.png");
        Console.WriteLine("Barkod üretildi!");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Geçersiz barkod formatı girdiniz! - Hata: " + ex);
    }
}

void Oku()
{
    try
    {
        Console.Write("Barkod ismini giriniz (Örn: barcode-2024-1-30-12-6-37.png): ");

        var resultFromFile = BarcodeReader.Read(path+Console.ReadLine());

        Console.WriteLine("Barkod okundu!:  " + resultFromFile[0].Text);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Geçersiz barkod formatı girdiniz! - Hata: " + ex);
    }
}

