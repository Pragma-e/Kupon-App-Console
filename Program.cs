// See https://aka.ms/new-console-template for more information

using Microsoft.Data.SqlClient;

Console.WriteLine("====================================================== \n");
Console.WriteLine("       !! KUPON UYGULAMASINA HOŞGELİDNİZ !! \n");
Console.WriteLine("  Kupon kazanmak için lütfen bilgilerinizi giriniz. \n");
Console.WriteLine("====================================================== \n");



Console.Write("Adınız: ");
string ad  = Console.ReadLine();

Console.Write("Soyadınız: ");
string soyad  = Console.ReadLine();

Console.Write("Telefon Numarası: ");
string tnumara  = Console.ReadLine();

Console.Write("E-posta adresiniz: ");
string eposta  = Console.ReadLine();


if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(tnumara) ||
    string.IsNullOrEmpty(eposta))
{
    Console.Write("Lütfen bütün bilgilerinizi eksiksiz giriniz.\n");
    Console.ReadKey();
}




Random rnd = new Random();

int indirim = rnd.Next(200, 2000);


string kupon = "ASDFGHJKLQWERTYUIOPZXCVBNM123456789";
string kuponkodu = "";

for (int x = 0; x < 8; x++)
{
    kuponkodu += kupon[rnd.Next(0,34)];
}


DateTime OlusturmaZamani = DateTime.Now;




Console.WriteLine("================================================================0\n");
Console.WriteLine("                      !!!!!! TEBRİKLER !!!!!!! \n");   
Console.WriteLine($"           {indirim} TL TUTARINDA İNDİRİM KAZANDINIZ.\n");
Console.WriteLine("        İndirimden yararlanmak için kupon kodunuzu kullanınız.\n");
Console.WriteLine($"                  KUPON KODUNUZ:   {kuponkodu} \n");







string veritabaniBaglanti = "Server=localhost;Database=KuponKonsol ;User Id=sa;Password=ASD123asd123;TrustServerCertificate=true;";

SqlConnection baglanti = new SqlConnection(veritabaniBaglanti);
baglanti.Open();

string Komut = "INSERT INTO KuponKullanici (ad,soyad,tnumara,email,kuponkodu,indirim,OlusturmaZamani) VALUES (@ad, @soyad, @tnumara, @eposta, @kuponkodu, @indirim, @olusturmazamani )";

SqlCommand komut = new SqlCommand(Komut, baglanti);
komut.Parameters.AddWithValue("@ad", ad);
komut.Parameters.AddWithValue("@soyad", soyad);
komut.Parameters.AddWithValue("@tnumara", tnumara);
komut.Parameters.AddWithValue("@eposta", eposta);
komut.Parameters.AddWithValue("@kuponkodu", kuponkodu);
komut.Parameters.AddWithValue("@indirim", indirim);
komut.Parameters.AddWithValue("@olusturmazamani", OlusturmaZamani);

komut.ExecuteNonQuery();

baglanti.Close();



