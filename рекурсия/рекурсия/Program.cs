using System.Reflection.Metadata.Ecma335;

static bool Ex17(int[] Arr, int i)
{
    if (i ==0)
    {
        return true;
    }
    if (Arr[i] < Arr[i - 1])
    {
        return false;
    }
    return Ex17(Arr, i - 1);

}

//Console.WriteLine(Ex17(a, a.Length - 1));
static int Ex16(int[] Arr, int i, int x)
{
    if (i == Arr.Length)
    {
        return -1;
    }
    if (Arr[i] == x)
    {
        return i;
    }
    return Ex16(Arr, i +
        1, x);
}
//Console.WriteLine(Ex16(a, a.Length, 4));
static string Ex28(int a, int d, int n)
{
    if (n == 1)
    {
        return a.ToString();
    }
    else
    {
         return Ex28(a, d, n - 1) + " " + (a+d*(n-1)).ToString();
    }
}
Console.WriteLine(Ex28(2, 3, 5));
Console.WriteLine(Ex28_1(2, 3, 5));
static string Ex28_1(int a, int d, int n)
{
    if (n == 1)
    {
        return a.ToString();
    }
    else
    {
        return a.ToString() + " " + Ex28(a+d, d, n - 1);
    }
}
/*Console.WriteLine(Ex28(2,3,5))*/;
static int Ex291(int a, int n)
{
    if (n == 0)
    {
        return a;

    }
    else
    {
        return n + Ex291(a, n - 1);
    }

}
static string Ex29(int a, int n)
{
    if (n == 0)
    {
        return a.ToString();
    }
    else
    {
        return Ex291(a,n).ToString()+ " " + Ex29(a, n - 1);
    }
}
//Console.WriteLine(Ex29(1,  6));
 static int Ex32(int[] Arr, int i, int x)
{
    if (i == -1)
    {
        return x;
    }
    if (Arr[i] < x)
    {
        x = Arr[i];
    }
    return Ex32(Arr, i - 1, x);
}
int[] a = { 1, 7, 85, 99 };

//static void Main(string [] args)
//{
    
//    Console.WriteLine(Ex32(a, a.Length - 1, 30000));
//}


