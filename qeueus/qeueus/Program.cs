using Node_home;
using Queues;
using System.Collections.Generic;

int Digits(Queue1<int> Q1)
{
    Queue1<int> Q = Q1.CopyQueue();
    int a = 0;
    Q.Reverse();
    while (!Q.IsEmpty())
    {
        a *= 10;
        a += Q.Remove();
        
    }
    return a;
}   
void Reverse(Queue1<int> Q)
{
    Queues.Stack<int> S = new Queues.Stack<int>();
    while (!Q.IsEmpty())
    {
        S.Push(Q.Remove());

    }
    while (!S.IsEmpty())
    {
        Q.Insert(S.Pop());
    }
    

}
Queue1<int> Reverse1(Queue1<int> Q)
{

    Queue1<int> Q1 = new Queue1<int>();
    Queues.Stack<int> S = new Queues.Stack<int>();
    while (!Q.IsEmpty())
    {
        S.Push(Q.Remove());

    }
    while (!S.IsEmpty())
    {
        Q1.Insert(S.Pop());
    }
    return Q1;


}
 Queue1<int> CopyQueue(Queue1<int> Q)
{
    Queues.Stack<int> S = new Queues.Stack<int>();
    Queues.Stack<int> S2 = new Queues.Stack<int>();
    while (!Q.IsEmpty())
    {
        S.Push(Q.Remove());

    }
    while (!S.IsEmpty())
    {
        S2.Push(S.Pop());

    }
    while (!S2.IsEmpty())
    {
        Q.Insert(S2.Pop());
    }
    return Q;

}
int Max( Node<Queue1<int>> L)

{
    Node<Queue1<int>> Lst = L;
    int a = 0;
    int k = 0; 
    while (Lst != null)
    {
        k = Digits(Lst.GetValue());
        Console.WriteLine(Lst.GetValue());
        
        if (k > a)
        {
            a = k;
        }
        Lst = Lst.GetNext();
    }
    return a;
}
bool IsElementOnlyOnce(Queue1<int> Q, int x)
{
    int tag = 0;
    Queue1<int> Q1 = Q.CopyQueue();
    //Console.WriteLine(Q1);
    while (!Q1.IsEmpty())
    {
        //Console.WriteLine(Q1.Head());
        if (x == Q1.Remove())
        {
            tag += 1;
        }
    }
    if(tag == 1)
    {
        return true;
    }
    return false;
}

Queue1<int> WithoutRepeated(Queue1<int> Q)
{
    Queue1<int> Q1 = Q.CopyQueue();
    Queue1<int> Q2 = new Queue1<int>();
    int k;
    while (!Q1.IsEmpty())
    {
        k = Q1.Remove();
        if (IsElementOnlyOnce(Q,k)==true)
        {
            Console.WriteLine(k);
            Q2.Insert(k);
        }
        Console.WriteLine(Q2);
    }
    return Q2;
}
int FindMin(Queue1<int> Q)
{
    int x = Q.Head();
    int k = 0;
    Queue1<int> Q1 = Q.CopyQueue();
    
    while (!Q1.IsEmpty())
    {
        k = Q1.Remove();
        if (x > k)
        {
            x = k;
        }
    }
    return x;
}

Queue1<int> RemoveValue(Queue1<int> Q, int k)
{
    int x = 0;
    Queue1<int> Q1 = Q.CopyQueue();
    Queue1<int> Q2 = new Queue1<int>();
    while (!Q1.IsEmpty())
    {
        x = Q1.Remove();
        if(x != k)
        {
            
            Q2.Insert(x);   
        }
    }
    return Q2;
    
}
Queue1<int> Sort(Queue1<int> Q) // проблема 
{
    Queue1<int> Q1 = Q.CopyQueue();
    
    int x = 0;
    Queue1<int> Q2 = new Queue1<int>();
    while (!Q1.IsEmpty())
    {
        x =FindMin(Q1);
        Q2.Insert(x);
        Q1 = RemoveValue(Q1,x);
    }
    return Q2;
}
int Quantety(Queue1<int> Q)
{
    Queue1<int> Q1 = Q.CopyQueue();
    int a = 0;
    while (!Q1.IsEmpty())
    {
        a++;
        Q1.Remove();
    }
    
    return a;
    
}
bool ComparingQueus(Queue1<int>Q, Queue1<int> Q2) // isequal
{
    while (!Q.IsEmpty())
    {
        if (Q.Head() != Q2.Head())
        {
            return false;
        }
        Q.Remove();
        Q2.Remove();
    }
    return true;
}
bool MoovingQueus(Queue1<int> Q, Queue1<int> Q2) // 5264 6452 true
{
    int a = 0;
    for (int i = 0; i < Quantety(Q); i++)
    {
        a = Q.Remove();
        Q.Insert(a);
        if(ComparingQueus(Q, Q2))
        {
            return true;
        }
    }
    return false;
}



Queue1<int> Q2 = new Queue1<int>();
Queue1 <int> Q = new Queue1<int>();
Q.Insert(6);
Q.Insert(9);
Q.Insert(1);
int r = 1;
Console.WriteLine(RemoveValue(Q,r));
//Q2.Insert(6);
//Q2.Insert(1);
//Q2.Insert(9);
//Console.WriteLine(ComparingQueus(Q, Q2));
//Console.WriteLine(WithoutRepeated(Q));
//Console.WriteLine(Digits(Q));
//Node<Queue1<int>> L = new Node<Queue1<int>>(Q);
//Console.WriteLine(CopyQueue(Q));
//Console.WriteLine(Q);
//Console.WriteLine(FindMin(Q));
//Console.WriteLine(Q);
//Console.WriteLine(Sort(Q));
//Console.WriteLine(IsElementOnlyOnce(Q, 6));
////Console.WriteLine(Q);
//Console.WriteLine(Quantety(Q));




