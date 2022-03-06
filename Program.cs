
byte by = 10;        //1byte
sbyte by1 = -10;     //1byte

short s = 654;       //2byte
ushort s1 = 4321;    //2byte

int i = 16;         //4byte
Int16 i1 = 16;      //2byte
Int32 i2 = 32;      //4byte
Int64 i3 = 64;      //8byte

uint i4 = 64;       //8byte
long l = 987987;    //8byte 
ulong l1 = 654654;   //8byte

float f = 45;     //4byte
double d = 4.5;
decimal dc = 55;


char c = 'a';
string str = "Patika.dev";


bool b2 = true;
bool b3 = false;
bool b4 = 10>5;

DateTime dt = DateTime.Now;
Console.WriteLine(dt);

object o = 'a';
object o1 = "patika.dev";
object o2 = 1;
object o3 = 13.2;
object o4 = DateTime.Now;

string str1 = string.Empty;
string str2 = null;
string str3 = "";

string ad, soyad;
ad = "berke";
soyad = "katılar";
Console.WriteLine(ad + " " + soyad);


int int1 = 1;
int int2 = 2;
int int3 = int1 + int2;


string str4 = "123";
int int4 = 20;

string deger = int4 + str4.ToString();

Console.WriteLine(deger);

int deger2 = int4 + Convert.ToInt16(str4);

Console.WriteLine(deger2);

deger2 = int4 + int.Parse(str4);

string dt1 = DateTime.Now.ToString("dd-MM-yyy");
Console.WriteLine(dt1);

dt1 = DateTime.Now.ToString("HH:mm");
Console.WriteLine(dt1);