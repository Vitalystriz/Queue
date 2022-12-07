using Stack_pro;

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

Stack1<int> RemoveTheElement(Stack1<int> S1, int x)
{
    Stack1<int> S = CopyStack(S1);
    Stack1<int> TempS = new Stack1<int>();
    Stack1<int> Res = new Stack1<int>();
    while (!S.IsEmpty())
    {
        if (S.Top() != x)
        {
            TempS.Push(S.Pop());
        }
        else { S.Pop(); }
    }
    while (!TempS.IsEmpty())
    {
        Res.Push(TempS.Pop());
    }
    return Res;
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
        
        S = RemoveTheElement(S, x);

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
Stack1<int> S1 = new Stack1<int>();


S1.Push(1);
S1.Push(27);
S1.Push(27);
S1.Push(90);
S1.Push(100);
//Console.WriteLine(S1.Top());
//Console.WriteLine(S1.ToString());


//Console.WriteLine(SumStack(S1));
//Console.WriteLine(FindTheMinimum(S1));

//Console.WriteLine(CountValueInStuck(S1));
//Console.WriteLine(RemoveTheElement(S1,23));
Console.WriteLine(SortStck(S1));