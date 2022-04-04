Console.WriteLine("iki tane sayi giriniz");

int a;
int b;
bool x;



while(1<2)
{
    x=int.TryParse(Console.ReadLine(),out a);
    if(x != true){
        Console.WriteLine("Birinci sayiyi yanlis girdiniz tekrar deneyiniz");
    }
    else
    {
        break;
    }
}
Console.WriteLine("ikinci sayiyi giriniz");
while(1<2)
{
    x=int.TryParse(Console.ReadLine(),out b);
    if(x != true){
        Console.WriteLine("İkinci sayiyi yanlis girdiniz tekrar deneyiniz");
    }
    else
    {
        break;
    }
}
int[] dizi=new int[a];

Console.WriteLine("{0} adet pozitif sayi giriniz", a);

for(int i=0; i<a ; i++)
{
    while(1<2)
    {
        x=int.TryParse(Console.ReadLine(),out dizi[i]);
        if(x==false || dizi[i]<0)
        {
            Console.WriteLine("Girdiginiz deger yanlis tekrar deneyiniz");
        }
        else
        {
            break;
        }
    }
   
}

foreach(int y in dizi)
{
    if(y==b || y%b==0)
    {
        Console.Write("{0} ", y);
    }
    
   
}
Console.Read();