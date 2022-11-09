class Masa
{
    public int id;
    public string renk;
    public int tip;
    public int w;
    public int h;
    public int d;
    public double r;
    public string tipi;
    public double masa_alan;
    public double masa_hacim;
    public double pi = Math.PI;
}
class Program
{
    static void Main(string[] args)
    {
        Masa masa1 = new Masa();
        Console.Write("id= ");
        masa1.id = Convert.ToInt16(Console.ReadLine());

        Console.Write("renk= ");
        masa1.renk = Convert.ToString(Console.ReadLine());

        Console.Write("yuvarlak ise 1 kare ise 0 ");
        masa1.tip = Convert.ToInt16(Console.ReadLine());
        if (masa1.tip == 0)
        {
            Console.Write("d=");
            masa1.w = Convert.ToInt16(Console.ReadLine());
            Console.Write("w=");
            masa1.h = Convert.ToInt16(Console.ReadLine());
            Console.Write("h=");
            masa1.d = Convert.ToInt16(Console.ReadLine());
            masa1.tipi = "kare";
            masa1.masa_alan = masa1.w * masa1.h;
            masa1.masa_hacim = masa1.masa_alan * masa1.d;
        }
        else if (masa1.tip == 1)
        {
            Console.Write("r=");
            masa1.r = Convert.ToInt16(Console.ReadLine());
            Console.Write("h=");
            masa1.d = Convert.ToInt16(Console.ReadLine());
            masa1.masa_alan = masa1.r * masa1.r * masa1.pi;
            masa1.masa_hacim = masa1.masa_alan * masa1.d;
            masa1.tipi = "yuvarlak";
        }
        else
        {
            Console.WriteLine("1 ya da 0 gir");
        }
        Console.WriteLine(masa1.id + " " + masa1.tipi + " " + masa1.renk + " masa " + " alan= " + masa1.masa_alan + " hacim= " + masa1.masa_hacim);
        Console.WriteLine("");
        Console.WriteLine("");
    }
}
