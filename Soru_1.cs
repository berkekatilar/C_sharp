int a;
bool b;
int c;

Console.WriteLine("Bir sayi giriniz");


while(1<2){
    b=int.TryParse(Console.ReadLine(), out a);
    if (b != true || a<1)
    {
        Console.WriteLine("Yanlis girdiniz tekrar deneyin");
    }
    else
    {
        break;
    }
}

int[] dizi=new int[a];

for(int i=0 ; i<a ; i++)
{
    b=int.TryParse(Console.ReadLine(), out c);
    while(1<2)
    {
        if (b != true)
    {
        Console.WriteLine("Yanlis girdiniz tekrar deneyin");
    }
    else
    {
        break;
    }
    }
    dizi[i]=c;
}
Console.Write("Dizideki cift sayilar");
foreach(int d in dizi)
{
    if (d%2==0)
    {
        Console.Write(" [{0}] ", d );
    }    
}

Console.Read();