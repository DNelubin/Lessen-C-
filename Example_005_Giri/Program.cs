int a = 3;
int b = 8;
int c = 5;
int d = 7;
int i = 9;
int max = a;
if (b>a)
{
    max = b;
}
else
{
    max = a;
}
if (c>b)
{
    max = c;
}
else
{
    max = b;
}
if (d>c)
{
    max = d;
}
else
{
    max = c;
}
if (i>d)
{
    max = i;
}
else
{
    max = d;
}
Console.Write (max);