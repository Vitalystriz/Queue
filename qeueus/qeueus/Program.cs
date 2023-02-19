using Node_home;
using Queues;
using System.Collections.Generic;
using System.Formats.Asn1;

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
//int  IsElementOnlyOnce(Queue1<int> Q, int x)
//{
//    int tag = 0;
//    Queue1<int> Q1 = Q.CopyQueue();
//    //Console.WriteLine(Q1);
//    while (!Q1.IsEmpty())
//    {
//        //Console.WriteLine(Q1.Head());
//        if (x == Q1.Remove())
//        {
//            tag += 1;
//        }
//    }
//    return tag;
//}

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
string CountOfAppears(Queue1<int> Q) // the bigggest count of appears 111221111133 1;5
{
    int countmax = 0;
    int x = Q.Head();
    int count = 0;
    int set = 0;
    while (!Q.IsEmpty())
    {
        int y = Q.Remove();
        if (y != x)
        {
            if(count > countmax)
            {
                countmax = count;
                set = x;
            }
            x = y;
        }
        else
        {
            count++;

        }
    }
    if (count > countmax)
    {
        countmax = count;
        set = x;
    }

    return "count "+countmax.ToString()+" degit "+set.ToString();
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
Queue1<int> Delete (Queue1<int> Q, int k)
{
    Queue1<int> Q2 = new Queue1<int>();
    while (!Q.IsEmpty())
    {
        if (Q.Head() == k)
        {
            Q.Remove();
        }
        else
        {
            Q2.Insert(Q.Remove());
        }
    }
    return Q2;
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
bool Sumofthirds(Queue1<int> Q)
{
    Queue1<int> Q1 = Q.CopyQueue();
    int i=0;
    int count = 0;
    for(int j=0; j<Quantety(Q)/3; j++)
    {
        count += Q.Remove();
    }
    int sum = 0;
    while (!Q.IsEmpty())
    {
        if (i == Quantety(Q1) / 3)
        {
            if(sum != count)
            {
                return false;
                sum = 0;
            }
        }
        sum += Q.Remove();

        i++;
    }
    return true;
}
bool IsMagic(Queue1<int> Q)
{
    Queue1<int> Q1 = Q.CopyQueue();
    if (Quantety(Q1)%3!=0)
    {
        return false;
    }
    if (Sumofthirds(Q1)!=true)
    {
        return false;
    }
}





Queue1 <int> Q = new Queue1<int>();
Q.Insert(6);
Q.Insert(6);
Q.Insert(1);

Q.Insert(7);
Q.Insert(7);
Q.Insert(7);

Console.WriteLine(Rep(Q));
//Console.WriteLine(WithoutRepeating1(Q));
//int r = 1;
//Console.WriteLine(RemoveValue(Q,r));
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
//Console.WriteLine(MoovingQueus(Q,Q2));




























