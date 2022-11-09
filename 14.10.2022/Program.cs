/*

int sayi1 = 15;
object obj1 = sayi1;
//obj1 = obj1 * 3; çarpılmıyor
int unbox = (int)obj1;
unbox = unbox * 3;

////////////////////////

string metin = "ilker şatur";
object obj2 = metin;
string str = (string)obj2;
str.Split(' ');


///////////////////////

// OBJELERİ ÇARPMA

int id = 15;

object masa_genislik =120;
object masa_yukseklik= 100;

int d = (int)masa_genislik;

int h = (int)masa_yukseklik;

int alan = d * h;

Console.WriteLine("ID= "+ id+" alan "+alan); */

Console.Write("tahta genişlik ");
object tahta_genislik = /*int.Parse(Console.ReadLine());*/  Convert.ToInt16(Console.ReadLine());
Console.Write("tahta yükseklik ");
object tahta_yukseklik = int.Parse(Console.ReadLine());


int alan = (int)tahta_genislik * (int)tahta_yukseklik; ;

///////////////

Console.Write("genişlik ");
object genislik = int.Parse(Console.ReadLine());
Console.Write("yükseklik ");
object yukseklik = int.Parse(Console.ReadLine());


int alan2 = (int)genislik * (int)yukseklik;

///////////////

Console.WriteLine("siyah alan " + (alan - alan2));
