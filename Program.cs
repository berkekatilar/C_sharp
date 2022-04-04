// See https://aka.ms/new-console-template for more information
Console.WriteLine("Pozitif bir sayi giriniz");

bool x;
int a;

while(1<2){
    x=int.TryParse(Console.ReadLine(), out a);
    if (x==false || a<1)
    {
        Console.WriteLine("Yanlis deger girdiniz tekrar deneyin");
    }
    else
    {
        break;
    }
}

Console.WriteLine("{0} adet kelime giriniz", a);

string[] dizi=new string[a];

for(int i=0 ; i<a ; i++)
{
    while(1<2)
    {
        dizi[i]=Convert.ToString(Console.ReadLine());
        if(dizi[i].Any(char.IsDigit))
        {
            Console.WriteLine("Yanlis girdiniz tekrar giriniz.");
        }
        else{
           break; 
            }
    }

}

Array.Reverse(dizi);

foreach(var y in dizi)
{
    Console.Write("{0} ", y);
}
Console.Read();