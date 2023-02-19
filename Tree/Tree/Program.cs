using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using Tree;

 void PrintPreOrder<T>(BinNode<T> BinT)
{
    if (BinT != null)
    {
        Console.WriteLine(BinT.GetValue() + "  ");
        PrintPreOrder(BinT.GetLeft());
        PrintPreOrder(BinT.GetRight());
    }
}
void DividePrintPreOrder(BinNode<int> BinT)
{
    if (BinT != null)
    {
        if (BinT.GetValue()%2==0)
        {
            Console.WriteLine(BinT.GetValue() + "  ");
        }
        if (BinT.hasLeft())
        {
            DividePrintPreOrder(BinT.GetLeft());
            DividePrintPreOrder(BinT.GetRight());
        }
        
    }
}
/*void HaveTheLeftEnd(BinNode<int> BinT)*/ //если есть левый корень
//{
//    if (BinT != null)
//    {
//        if (BinT.GetLeft().hasLeft() == false && BinT.GetLeft().hasRight()==false && BinT.hasRight())
//        {
//            Console.WriteLine(BinT.GetLeft().GetValue() + "  ");
//        }


//        PrintPreOrder(BinT.GetLeft());
//        PrintPreOrder(BinT.GetRight());
//    }
//}
static bool IsLeaf(BinNode<int> BinT) //если есть левый корень
{
    if (BinT.GetRight()==null  && BinT.GetLeft()==null )
    {
        return true;
    }
    return false;

}
static bool IsLeaf2(BinNode<RAnge1> BinT) //если есть левый корень
{
    if (BinT.GetRight() == null && BinT.GetLeft() == null)
    {
        return true;
    }
    return false;
}
static bool IsLeafforstring(BinNode<string> BinT) //если есть левый корень
{
    if (BinT.GetRight() == null && BinT.GetLeft() == null)
    {
        return true;
    }
    return false;
}
//bool IsLeafforRAnge(BinNode<T> BinT) //если есть левый корень
//{
//    if (BinT.GetRight() == null && BinT.GetLeft() == null)
//    {
//        return true;
//    }
//    return false;

//}
void PrintTheLeftEnd(BinNode<int> BinT) //если есть левый корень
    {
        if (BinT != null)
        {
            if (BinT.hasLeft() == true && IsLeaf(BinT.GetLeft()))
            {
                Console.WriteLine(BinT.GetLeft().GetValue());
            }

            PrintTheLeftEnd(BinT.GetLeft());
            PrintTheLeftEnd(BinT.GetRight());

        }
    }
    BinNode<int> AddSiblings(BinNode<int> BinT)
    {
        if (BinT != null)
        {
            if (BinT.hasLeft() == false && BinT.hasRight() == true)
            {
                BinNode<int> treei = new BinNode<int>(BinT.GetRight().GetValue());

                BinT.SetLeft(treei);
            }
            if (BinT.hasRight() == false && BinT.hasLeft() == true)
            {
                BinNode<int> treei = new BinNode<int>(BinT.GetLeft().GetValue());

                BinT.SetRight(treei);
            }
            AddSiblings(BinT.GetLeft());
            AddSiblings(BinT.GetRight());
        }
        return BinT;
    }
    void PrintTheGrandChildren(BinNode<int> BinT)
    {
        if (BinT != null)
        {
            if (!IsLeaf(BinT.GetRight()) && BinT.GetRight() != null)
            {
                if (BinT.GetRight().GetRight() != null)
                {
                    Console.WriteLine(BinT.GetRight().GetRight().GetValue());
                }
                if (BinT.GetRight().GetLeft() != null)
                {
                    Console.WriteLine(BinT.GetRight().GetLeft().GetValue());
                }


            }
            if (!IsLeaf(BinT.GetLeft()) && BinT.GetLeft() != null)
            {
                if (BinT.GetLeft().GetLeft() != null)
                {
                    Console.WriteLine(BinT.GetLeft().GetLeft().GetValue());
                }
                if (!IsLeaf(BinT.GetLeft()) && BinT.GetRight() != null)
                {
                    Console.WriteLine(BinT.GetLeft().GetRight().GetValue());
                }


            }
            PrintTheGrandChildren(BinT.GetLeft());

            PrintTheGrandChildren(BinT.GetRight());





        }
    }
    void PrintWhatsmorethanfather(BinNode<int> BinT)
    {
        if (BinT != null)
        {
            if (BinT.GetValue() > BinT.GetLeft().GetValue() || BinT.GetValue() > BinT.GetRight().GetValue())
            {
                Console.WriteLine(BinT);
            }

            PrintWhatsmorethanfather(BinT.GetLeft());
            PrintWhatsmorethanfather(BinT.GetRight());




        }
    }
    int Count(BinNode<int> BinT)
    {
        if (BinT != null)
        {

            return Count(BinT.GetLeft()) + Count(BinT.GetRight()) + 1;
        }
        return 0;
    }
    int Summ(BinNode<int> BinT)
    {
        if (BinT != null)
        {

            return Summ(BinT.GetLeft()) + Summ(BinT.GetRight()) + BinT.GetValue();
        }
        return 0;
    }
    int SumOfIven(BinNode<int> BinT)
    {
        int flag = 0;
        if (BinT != null)
        {
            if (BinT.GetValue() % 2 == 0)
            {
                flag = BinT.GetValue();
            }
            else { flag = 0; }
            return SumOfIven(BinT.GetLeft()) + SumOfIven(BinT.GetRight()) + flag;
        }
        return 0;
    }
    bool IsExist(BinNode<int> T, int x)
    {
        if (T.GetValue() == x)
        {
            return true;
        }
        return IsExist(T.GetLeft(), x) || IsExist(T.GetRight(), x);
        if (T == null)
        {
            return false;
        }
    }
    // чекнуть oreder деревьев и логов
    bool IfAllIven(BinNode<int> T)
    {
        if (T == null)
        {
            return true;
        }
        else
        {
            if (T.GetValue() % 2 != 0)
            {
                return false;
            }
            return IfAllIven(T.GetLeft()) && IfAllIven(T.GetLeft());
        }
    }
    // функция получает дерево, проверить если сумма листочков равна значению родителя (не только для детей, но и для внуков
    //int Count1(BinNode<int> BinT) будет ошибка, посокльку он выведет только первый ретурн, а иначе только 1 путь к ретутрну
    //{
    //    int count = 0;
    //    if (BinT != null)
    //    {
    //        count++;
    //        Count1(BinT.GetLeft());
    //        Count1(BinT.GetRight());
    //    }
    //    else
    //    {
    //        return count;
    //    }
    //}

    void PrintInOrder<T>(BinNode<T> BinT)
    {
        if (BinT != null)
        {
            PrintInOrder(BinT.GetLeft());
            Console.Write(BinT.GetValue() + "  ");
            PrintInOrder(BinT.GetRight());
        }
    }
    void PrintPostOrder<T>(BinNode<T> BinT)
    {
        if (BinT != null)
        {
            PrintPostOrder(BinT.GetLeft());
            PrintPostOrder(BinT.GetRight());
            Console.Write(BinT.GetValue() + "  ");
        }
    }
    bool IfSumOfLEvels(BinNode<int> BinT) //если сумма корня равна сумме всего остального дерева
    {
        if (BinT == null)
        {
            return true;
        }
        int sum = 0;
        if (BinT.GetLeft() != null)
        {
            sum += BinT.GetLeft().GetValue();
        }
        if (BinT.GetRight() != null)
        {
            sum += BinT.GetRight().GetValue();
        }

        return IfSumOfLEvels(BinT.GetLeft()) && IfSumOfLEvels(BinT.GetRight()) && sum == BinT.GetValue(); //из-за условия суммы не нужно писать false

    }
    bool IfSum(BinNode<int> BinT)
    {
        if (IsLeaf(BinT))
        {
            return true;
        }
        if (BinT.GetValue() != Summ(BinT.GetLeft()) + Summ(BinT.GetRight()))
        {
            return false;

        }
        return IfSum(BinT.GetLeft()) && IfSum(BinT.GetRight());
    }
    bool ifHaveSons(BinNode<int> T)
    {
        if (IsLeaf(T))
        {
            return true;
        }
        else if (!T.hasLeft() || !T.hasRight())
        {
            return false;
        }
        return ifHaveSons(T.GetLeft()) && ifHaveSons(T.GetRight());
    }
    bool ifFatherBiggerThanSun(BinNode<int> T)
    {
        if (IsLeaf(T))
        {
            return true;
        }
        else
        {
            if (T.hasRight() && !T.hasLeft() && T.GetValue() > T.GetRight().GetValue())
            {
                return ifFatherBiggerThanSun(T.GetRight());
            }

            if (!T.hasRight() && T.hasLeft() && T.GetValue() > T.GetRight().GetValue())
            {
                return ifFatherBiggerThanSun(T.GetLeft());
            }
            return false;
        }

    }
    bool IfOneEmptyAndOtherTree(BinNode<int> T)
    {
        if (IsLeaf(T))
        {
            return true;
        }
        if (T.hasLeft() && !T.GetLeft().hasLeft() && !T.GetLeft().hasRight())
        {
            if (T.hasRight() && T.GetRight().hasRight() && T.GetRight().hasRight())
            {
                return IfOneEmptyAndOtherTree(T.GetRight());

            }

        }
        return false;
    }
    bool IsExistElement(BinNode<int> T, int x)
    {
        if (T == null)
        {
            return false;
        }
        if (T.GetValue() == x)
        {
            return true;
        }
        return IsExistElement(T.GetRight(), x) || IsExistElement(T.GetLeft(), x);


    }
    // 2 trees 
    // return 
    List<int> CommonElements(BinNode<int> T1, BinNode<int> T2)
    {
        List<int> commonElements = new List<int>();
        BuildList(T1, T2, commonElements);
        return commonElements;


    }
    List<int> BuildList(BinNode<int> T1, BinNode<int> T2, List<int> L)
    {
        if (T1 != null)
        {
            if (IsExistElement(T2, T1.GetValue()))
            {
                L.Add(T1.GetValue());
            }
            BuildList(T1.GetLeft(), T2, L);

            BuildList(T1.GetRight(), T2, L);
        }
        return L;
    }




    bool IsElementOnce(int[] Arr, int x)
    {
        int Count = 0;
        for (int i = 0; i < Arr.Length; i++)

        {
            if (Arr[i] == x)
            {
                Count++;
            }
        }
        if (Count == 1)
        {
            return true;
        }
        else return false;
    }
    //из багрута 
    bool IfPerfect(int[] Arr)
    {
        int count = Arr.Length;
        int i = 0;

        while (Arr[i] != 0 && count != 0)
        {
            i = Arr[i];
            if (!IsElementOnce(Arr, Arr[i]))
            {
                return false;
            }

            count--;


        }
        return true;
    }
    int TheMin(BinNode<int> T)
    {
        int x = T.GetValue();
        return TheMin1(T, x);
    }
    int TheMin1(BinNode<int> T, int x)
    {
        if (T == null)
        {
            return x;
        }
        if (T.GetValue() < x)
        {
            x = T.GetValue();
        }
        //x = TheMax1(T.GetRight(), x); //тоже самое 
        //x = TheMax1(T.GetLeft(), x);
        //return x;
        if (TheMin1(T.GetRight(), x) < TheMin1(T.GetLeft(), x))
        {
            return TheMin1(T.GetRight(), x);
        }
        else
        {
            return TheMin1(T.GetLeft(), x);
        }

    }

bool IsInterval(BinNode<RAnge1> BinT)
    {
        if (IsLeaf2(BinT))
        {
            return true;
        }
        if (BinT.hasLeft() && !BinT.hasRight())
        {
            if ((BinT.GetValue().Low() != BinT.GetLeft().GetValue().Low()) || (BinT.GetValue().Hight() < BinT.GetLeft().GetValue().Hight()))
            {
                return false;
            }
        }
        if (!BinT.hasLeft() && BinT.hasRight())
        {
            if ((BinT.GetValue().Hight() != BinT.GetRight().GetValue().Hight()) || (BinT.GetValue().Low() > BinT.GetRight().GetValue().Low()))
            {
                return false;
            }
        }
        if (BinT.hasLeft() && BinT.hasRight())
        {
            if (BinT.GetValue().Hight() != BinT.GetRight().GetValue().Hight() || BinT.GetValue().Low() != BinT.GetLeft().GetValue().Low())
            {
                return false;
            }
        }
        IsInterval(BinT.GetLeft());
        IsInterval(BinT.GetRight());
        return true;
    }
bool IsLess(BinNode<int> T, BinNode<int> T2)
{
    if (TheMin(T) < T2.GetValue())
    {
        return false;
    }
    IsLess(T, T2.GetRight());
    IsLess(T, T2.GetLeft());
    if (T == null)
    {
        return true;
    }

    return true; 
        

}
int CountOfLeaf(BinNode<int> T)
    {
        if (IsLeaf(T))
        {
            return 1;
        }
   
        
        return CountOfLeaf(T.GetLeft())+CountOfLeaf(T.GetRight());
        
    }
void Print(BinNode<int> T,string s)
{
    if (T != null)
    {
        if (IsLeaf(T))
        {
            Console.WriteLine(s + T.GetValue());
        }
        s += T.GetValue();
        Print(T.GetLeft(),s);
        Print(T.GetRight(),s);


    }    

}
bool IslogicalTree(BinNode<string>T)
{
    if (IsLeafforstring(T))
    {
        if (T.GetValue() == "T")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    if (T.GetValue() == "OR")
    {
        if (IslogicalTree(T.GetLeft()) || IslogicalTree(T.GetRight()) == true) {

            return true;
        }
        else { return false; }

    }
    else
    {
        if (IslogicalTree(T.GetLeft()) && IslogicalTree(T.GetRight()) == true)
        {

            return true;
        }
        else { return false; }

    }

}
bool FromLowestToHighest(BinNode<int> T, int x)
{
    if (T == null)
    {
        return true ;
    }
    if(T.GetValue() < x)
    {
        return false;
    }
    FromLowestToHighest(T.GetRight(), T.GetValue());
    FromLowestToHighest(T.GetLeft(), T.GetValue());
    return true;
}
bool ReturnFromLowesttoHightest(BinNode<int> T)
{
    return FromLowestToHighest(T, T.GetValue());
}






//RAnge1 rg = new RAnge1(5,10);
//RAnge1 rg2 = new RAnge1(8, 10);
//RAnge1 rg3= new RAnge1(5, 6);
//BinNode<RAnge1> I = new BinNode<RAnge1>(rg);
//I.SetLeft(new BinNode<RAnge1>(rg3));
//I.SetRight(new BinNode<RAnge1>(rg2));
//Console.WriteLine(IsInterval(I));
BinNode<int> tree2 = new BinNode<int>(9);
tree2.SetRight(new BinNode<int>(2));
tree2.SetLeft(new BinNode<int>(6));
BinNode<int> tree3 = new BinNode<int>(9);
tree3.SetRight(new BinNode<int>(4));




tree3.SetLeft(tree2);
//BinNode<int> tree4 = new BinNode<int>(31);
//tree4.SetRight(new BinNode<int>(22));
//tree4.SetLeft(new BinNode<int>(6));
//BinNode<int> tree5 = new BinNode<int>(1);
//tree5.SetRight(new BinNode<int>(2));
//tree5.SetLeft(new BinNode<int>(6));
//BinNode<int> tree6 = new BinNode<int>(tree4, 101, tree5);
//BinNode<int> t3 = new BinNode<int>(tree2, 41, tree3);
//BinNode<int> t2 = new BinNode<int>(tree4, 7, tree5);
//BinNode<int> t1 = new BinNode<int>(t2, 7, t3);

//t1.GetLeft().SetLeft(tree6);
Console.WriteLine("Tree");
PrintPreOrder(tree2);
Console.WriteLine("Results");
Print(tree2,"");
//Console.WriteLine(SumOfIven(tree2));
//Console.WriteLine(IsExist(tree2, 6));
//PrintWhatsmorethanfather(t1);

