int x = 5;
int y = 10;
int sonuc;
y = y+5;

y += 2;
x *= 2;
x /= 1 ;
//aritmetik işlemler
sonuc = x+y;
Console.WriteLine(sonuc);

sonuc = x-y;
Console.WriteLine(sonuc);

sonuc = x*y;
Console.WriteLine(sonuc);

sonuc = x/y;
Console.WriteLine(sonuc);

sonuc = x%3; // mod alma
Console.WriteLine(sonuc);

//mantıksal işlemler
bool issuc = true;
bool isntsuc = false;

if (issuc && isntsuc)
{
Console.WriteLine("complated");
}
if (issuc||isntsuc)
{
Console.WriteLine("not complated");
}
if (issuc&&!isntsuc)
{
Console.WriteLine("nice");
}

//ilişkisel işlemler
bool sonuc1;

sonuc1 = x<=y;
Console.WriteLine(sonuc);

sonuc1 = x>=y;
Console.WriteLine(sonuc);

sonuc1 = x==y;
Console.WriteLine(sonuc);

sonuc1 = x!=y;
Console.WriteLine(sonuc);