using Stack_pro;
using System.Security.Cryptography.X509Certificates;

int SumStack(Stack1<int> S1)
{
    int sum = 0;
    Stack1<int> TempS = new Stack1<int>();
    while (!S1.IsEmpty())
    {
        sum += S1.Top();
       
        TempS.Push(S1.Pop());
    }
    while (!TempS.IsEmpty())
    {
        S1.Push(TempS.Pop());
    }
    
    return sum;
}

void RemoveTheElement(Stack1<int> S, int x)
{
    //Stack1<int> S = CopyStack(S1);
    Stack1<int> TempS = new Stack1<int>();
    // Stack1<int> Res = new Stack1<int>();
    while (!S.IsEmpty())
    {
        TempS.Push(S.Pop());
    }
    while (!TempS.IsEmpty())
    {
        if (TempS.Top() != x)
        {
            S.Push(TempS.Top());
        }
        TempS.Pop();
    }

    //while (!TempS.IsEmpty())
    //{
    //    Res.Push(TempS.Pop());
    //}
    //return Res;
}

int RemoveTheLast(Stack1<int> S)
{
    //Stack1<int> S = CopyStack(S1);
    Stack1<int> TempS = new Stack1<int>();
    // Stack1<int> Res = new Stack1<int>();
    while (!S.IsEmpty())
    {
        TempS.Push(S.Pop());
    }
    int x = TempS.Pop();
    while (!TempS.IsEmpty())
    {
        S.Push(TempS.Top());
        TempS.Pop();
    }
    return x;
}

int FindTheMinimum(Stack1<int> S)
{
    Stack1<int> S1 = CopyStack(S);
    int X = S1.Top();
    while (!S1.IsEmpty())
    {
        if (S1.Top() < X)
        {
            X = S1.Top();
        }
        S1.Pop();
    }
    return X;
}

int CountOFValue(Stack1<int> S1,int X)
{
    int Count = 0;
    Stack1<int> S = CopyStack(S1);
    while (!S.IsEmpty())
    {
        if (S.Top() == X)
        {
            Count++;
        }
        S.Pop();
    }
    return Count;

        

}

Stack1<int> SortStck(Stack1<int> S1)
{
    Stack1<int> S = CopyStack(S1);
    Stack1<int> TempS = new Stack1<int>();
    Stack1<int> Res = new Stack1<int>();

    while (!S.IsEmpty())
    {
        int x = FindTheMinimum(S);
        int y = CountOFValue(S, x);
        
        for (int i = 0; i < y; i++)
        {
            TempS.Push(x);
        }
       RemoveTheElement(S, x);
    }
    while (!TempS.IsEmpty())
    {
        Res.Push(TempS.Pop());
    }
    return Res;
}

bool IsExist(Stack1<int> S, int X)
{

    while (!S.IsEmpty())
    {
        if (X == S.Top())
        {
            return true;
        }
        S.Pop();


    }
    return false;
}

Stack1<int> CopyStack(Stack1<int> S)
{
    Stack1<int> TempS = new Stack1<int>();
    Stack1<int> CopyS = new Stack1<int>();
    while (!S.IsEmpty())
    {
        TempS.Push(S.Pop());
    }
    while (!TempS.IsEmpty())
    {
        int x =TempS.Pop();
        S.Push(x);
        CopyS.Push(x);
    }
   
    return CopyS;
}

int CountValueInStuck(Stack1<int> S)
{
    int count = 0;
    Stack1<int> TempS = CopyStack(S); //why we can't write S?
    while (!TempS.IsEmpty())
    { 
        TempS.Pop();
        count++;
    }
    return count;
}
Stack1<int> WithoutReturned(Stack1<int> S1)
{
    Stack1<int> S = CopyStack(S1);
    Stack1<int> Res = new Stack1<int>();
    int y = 0;
    int x = S.Pop();
    int count = 1; 

    while (!S.IsEmpty())
    {


        if (S.Top() != x)
        {
            if(count == 1)
            {
                Res.Push(x);
            }
            count = 1;
        }
        else
        {
            count++;
        }
        x = S.Pop();

    }
    if(count == 1)
    {
        S.Push(x);
    }
    return Res;
}

bool CkeckDigit(Stack1<int> S1,int x)
{
    Stack1<int> S = CopyStack(S1);
    while (!S.IsEmpty())
    {
        if(S.Pop()%10 == x)
        {
            return true;
        }
    }
    return false;
}
bool Check_Stack(Stack1<int> S1)
{
    Stack1<int> S = CopyStack(S1);
    Stack1<int> TS = CopyStack(S1);
    while (!S.IsEmpty())
        
    {
        int left = LastDigit(S.Pop());
        if (!CkeckDigit(TS,left )){
            return false;
        }
    }
    return true;
}
int LastDigit(int x)
{
    while (x > 9)
    {
        x = x/10;
    }
    return x;
}
int TheClosest(Stack1<int> S1, Stack1<int> S2)
{
    Stack1<int> S3 = CopyStack(S1);
    Stack1<int> S4 = CopyStack(S2);



    int max2 = 0;
    while (CountValueInStuck(S4)>1)
    {
        int y = S4.Pop();
        if (y + S4.Top() > max2)
        {
            max2 = y+S4.Top();
        }
    }
    Console.WriteLine(max2);
    while (CountValueInStuck(S3) > 1)
    {
        int y = S3.Pop();
        if(y+S3.Top()> max2)
        {
            return y + S3.Top();
        }
    }
    return 0;
}
Stack1<TempItem> Pair(Stack1<int> S1)
{
    Stack1<int> S = CopyStack(S1);
    Stack1<TempItem> Temp = new Stack1<TempItem>(); 
    while (!S.IsEmpty())

    {
        Console.WriteLine(S.Top());
        
        TempItem item = new TempItem(S.Top(),RemoveTheLast(S));
        Temp.Push(item);
        if (!S.IsEmpty())
        {
            S.Pop();
        }
        
    }
    return Temp ;
}
Stack1<int> AddCouple(Stack1<int> S1)
{
    Stack1<int> S = CopyStack(S1);
    Stack1<int> Res = new Stack1<int>();
    int tag = 0;
    int s = 0;
    tag = S.Pop();
    Res.Push(tag);

    while (!S.IsEmpty())
    {
        if (tag == S.Top())
        {
            tag = S.Pop();
        }
        else
        {   
            s = S.Pop();
            tag = s;
            Res.Push(s);
        }
    }
    
    while (!Res.IsEmpty())
    {
        S.Push(Res.Pop());
    }
    return S;



}



Stack1<int> S1 = new Stack1<int>();
Stack1<int> S2 = new Stack1<int>();
S1.Push(9);
S1.Push(9);
S1.Push(4);
S1.Push(4);
//S2.Push(5);
//S2.Push(19);


//Console.WriteLine(S1.Top());
Console.WriteLine(S1.ToString());
//Console.WriteLine(TheClosest(S1,S2));
Console.WriteLine(AddCouple(S1));
//Console.WriteLine(Pair(S1).ToString());

//Console.WriteLine(RemoveTheLast(S1));

//Console.WriteLine(SumStack(S1));
//Console.WriteLine(FindTheMinimum(S1));

//Console.WriteLine(CountValueInStuck(S1));
//Console.WriteLine(RemoveTheElement(S1,23));
//Console.WriteLine(SortStck(S1));