int SumStack(Stack<int> S)
{
    int sum = 0;
    Stack<int> TempS = new Stack<int>();
    while (!S.)
    {
        sum += S.Top();
        TempS.Push(S.Pop());
    }
    while (!TempS.IsEmpty())
    {
        S.Push(TempS.Pop());
    }
    return sum;
}
Stack<int> RemoveTheElement(Stack<int> S, int x)
{
    Stack<int> TempS = new Stack<int>();
    Stack<int> Res = new Stack<int>();
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
int FindTheMinimum(Stack<int> S)
{

    int X = S.Top();
    while (!S.IsEmpty())
    {
        if (S.Top() < X)
        {
            X = S.Top;
        }
        S.Pop();
    }
    return X;
}
int CountOFValue(Stack<int> S)
{
    int X = 0;
    while (!S.IsEmpty())
    {
        if (S.Top() == X)
        {
            X++;
        }
        S.Pop();
    }
    return X;

}
Stack<int> SortStck(Stack<int> S)
{
    Stack<int> TempS = new Stack<int>();
    while (!S.IsEmpty())
    {
        int x = FindTheMinimum(S);
        TempS.Push(x);
        S = RemoveTheElement(S, x);

    }
    return TempS;
}
 bool IsExist(Stack<int> S, int X)
{

    while (!S.IsEmpty())
    {
        if (X == S.Top())
        {
            return true;
        }
        S.Pop(S.Top());


    }
    return false;
}



Stack<int> CopyStack(Stack<int> S)
{
    Stack<int> TempS = new Stack<int>();
    Stack<int> CopyS = new Stack<int>();
    while (!S.IsEmpty())
    {
        TempS.Push(S.Pop());
    }
    while (!S.IsEmpty())
    {
        S.Push(TempS.Pop());
        CopyS.Push(S.Pop());
    }
    return CopyS;
}
 int CountValueInStuck(Stack<int> S)
{
    int count = 0;
    Stack<int> TempS = CopyStack(S); //why we can't write S?
    while (TempS.IsEmpty())
    {
        count++;
        TempS.Pop();
    }
    return count;
}
Stack<int> S1 = new Stack<int>();
S1.Push(1);
S1.Push(27);
S1.Push(23);
S1.Push(90);
S1.Push(100);
Console.WriteLine(S1.ToString());
Stack<int> S2 = S1.CopySt();
Console.WriteLine(S2);