// See https://aka.ms/new-console-template for more information
using Node_home;
using static System.Collections.Specialized.BitVector32;

class Program
{
    public static Node<int> AddtoLast(int N)
    {
        Node<int> First = null;
        Node<int> Last = null;
        for (int i = 0; i < N; i++)
        {
            Console.WriteLine("Enter Num");
            int Num = int.Parse(Console.ReadLine());
            if (First == null)
            {
                First = new Node<int>(Num);
                Last = First;
            }
            else
            {
                Last.SetNext(new Node<int>(Num));
                Last = Last.GetNext();
            }
        }
        return First;
    }
    //הדפסת הערכים של שרשרת החוליות
    //
    public static void PrintList(Node<int> L)
    {
        Node<int> PoseL = L;
        while (PoseL != null)
        {
            Console.Write(PoseL + "   ");
            PoseL = PoseL.GetNext();
        }
    }
    //הפעולה מחזירה סכום איברי החוליה
    public static int ListSum(Node<int> L)
    {
        int Sum = 0;
        while (L != null)
        {
            Sum = Sum + L.GetValue();
            L = L.GetNext();
        }
        return Sum;
    }
    //האם השרשרת ממוינת בסדר עולה
    public static bool HighList(Node<int> L)
    {
        while (L != null && L.GetNext() != null)
        {
            if (L.GetValue() < L.GetNext().GetValue())
                return true;
            if (L.GetValue() > L.GetNext().GetValue())
                return false;
            L = L.GetNext();
        }
        return true;
    }
    //האם השרשרת ממוינת בסדר עולה
    //דרך 2
    public static bool IsSorted(Node<int> L)
    {
        Node<int> PosL = L;
        if (L == null)
            return false;
        while (PosL.GetNext() != null)
        {
            if (PosL.GetValue() > PosL.GetNext().GetValue())
                return false;
            PosL = PosL.GetNext();
        }
        return true;
    }
    //public static int SortList(Node<int> L,int k)
    //{
    //    if(HighList(L)==true)
    //    {
    //    }
    //}
    //
    //
    //public static bool IsRemoveFirstElement(Node<int> L,int N)
    //{
    //    Node<int> PosL = L;
    //    while (PosL.GetValue() != N && PosL.GetNext() != null)
    //    {
    //        PosL = PosL.GetNext();
    //    }
    //    if(PosL.GetValue()==N)
    //    {
    //        return true;
    //    }
    //    else
    //        return false;
    //}
    public static bool IsExist(Node<int> L, int X)
    {
        Node<int> PosL = L;
        while (PosL != null)
        {
            if (PosL.GetValue() == X)
                return true;
            PosL = PosL.GetNext();
        }
        return false;
    }
    public static bool IsFirstRemoved(Node<int> L, int N)
    {
        Node<int> PosL = L;
        if (PosL.GetValue() == N)
        {
            while (PosL != null)
            {
                PosL.SetValue(PosL.GetNext().GetValue());
                PosL.SetNext(PosL.GetNext().GetNext());
                PosL = PosL.GetNext();
            }
            return true;
        }
        return false;
    }
    //כתוב פעולה שמקבלת שרשרת חוליות ומחזירה כמה חוליות יש בשרשרת
    //
    public static int HowManyNodes(Node<int> L)
    {
        int Count = 0;
        Node<int> PosL = L;
        while (PosL != null)
        {
            PosL = PosL.GetNext();
            Count++;
        }
        return Count;
    }
    //טענת כניסה : הפעולה מקבלת שרשרת חוליות ומספר 
    //טענת יציאה : הפעולה מחזירה אמת אם המספר נמצא בשרשרת אחרת שקר
    public static bool IsNumInNode(Node<int> L, int N)
    {
        Node<int> PosL = L;
        while (PosL != null)
        {
            if (PosL.GetValue() == N)
                return true;
            else
                PosL = PosL.GetNext();
        }
        return false;
    }
    //טענת כניסה : פעולה מקבלת 2 שרשראות של מספרים שלמים
    //טענת יציאה : הפעולה מחזירה שרשרת חוליות של המספרים המשותפים ללא חזרות
    public static Node<int> NewNodeFrom2(Node<int> L1, Node<int> L2)
    {
        Node<int> L3 = null;//מצביע לחוליה הראשונה
        Node<int> PosL3 = null;
        Node<int> PosL1 = L1;
        while (PosL1 != null)
        {
            if (IsExist(L2, PosL1.GetValue()) && !IsExist(L3, PosL1.GetValue()))
            {
                if (L3 == null)
                {
                    L3 = new Node<int>(PosL1.GetValue());
                    PosL3 = L3;
                }
                else
                {
                    PosL3.SetNext(new Node<int>(PosL1.GetValue()));
                    PosL3 = PosL3.GetNext();
                }
            }
            PosL1 = PosL1.GetNext();
        }
        return L3;
    }
    //פעולה גנרית להדפסת שרשרת חוליות
    //
    public static void PrintTheAllType<T>(Node<T> L)
    {
        Node<T> Pos = L;
        while (Pos != null)
        {
            Console.Write(Pos + "  ");
            Pos = Pos.GetNext();
        }
        Console.WriteLine();
    }
    public static bool TwoPointers(Node<int> L)
    {
        int Count = HowManyNodes(L);
        if (L == null || Count % 3 != 0)
            return false;
        Node<int> PosL1 = L;
        Node<int> PosL2 = L;
        for (int i = 0; i < Count / 3; i++)
        {
            PosL2 = PosL2.GetNext();
        }
        while (PosL2 != null)
        {
            if (PosL1.GetValue() != PosL2.GetValue())
                return false;
            PosL1 = PosL1.GetNext();
            PosL2 = PosL2.GetNext();
        }
        return true;
    }
    //טענת כניסה : הפעולה מקבלת שרשרת חוליות  של מספרים שלמים ומקבלת מספר שלם ממוינת ומספר 
    //טענת יציאה : הפעולה מחזירה את אותה השרשרת עם המספר הנוסף כך המיון נשאר
    public static Node<int> InsertNum(Node<int> L, int Num)
    {
        if (L == null || Num < L.GetValue())
        {
            L = new Node<int>(Num, L);
            return L;
        }
        Node<int> PosL = L;
        while (PosL.hasNext() && Num > PosL.GetNext().GetValue())
        {
            PosL = PosL.GetNext();
        }
        PosL.SetNext(new Node<int>(Num, PosL.GetNext()));
        return L;
    }
    //טענת כניסה : הפעולה מקבלת שרשרת לא ממוינת של מספרים שלמים
    //טענת יציאה : הפעולה מחזירה שרשרת חדשה עם אותם מספרים שקיבלנו ממוינת
    public static Node<int> SortList(Node<int> L)
    {
        Node<int> NewListSorted = null;
        Node<int> PosL = L;
        while (PosL != null)
        {
            NewListSorted = InsertNum(NewListSorted, PosL.GetValue());
            PosL = PosL.GetNext();
        }
        return NewListSorted;
    }
    //טענת כניסה : שרשרת חוליות של שלמים ומספר שלם שרוצים למחוק
    //טענת יציאה : השרשרת ללא המספר
    public static Node<int> DeleteAllNode(Node<int> L, int Num)
    {
        Node<int> PosL = L;
        Node<int> PrevPosL = null;
        while (PosL != null)
        {
            if (PosL.GetValue() == Num)
            {
                if (PrevPosL == null)
                {
                    PosL = PosL.GetNext();
                    L = L.GetNext();
                }
                else
                {
                    PrevPosL.SetNext(PosL.GetNext());
                    PosL = PosL.GetNext();
                }
            }
            else
            {
                PrevPosL = PosL;
                PosL = PosL.GetNext();
            }
        }
        return L;
    }
    //בחינת בגרות שנת 2010 שאלה 2
    //
    //
    public static Node<Range> CreateRangeList(Node<int> List)
    {
        Node<int> PosL = List;
        Node<Range> RangeList = null;
        Node<Range> PosRangeList = null;
        if (List == null)
            return null;
        Range R;
        int from = PosL.GetValue();
        while (PosL.GetNext() != null)
        {
            if (PosL.GetValue() + 1 != PosL.GetNext().GetValue())
            {
                R = new Range(from, PosL.GetValue());
                if (RangeList == null)
                {
                    RangeList = new Node<Range>(R);
                    PosRangeList = RangeList;
                }
                else
                {
                    PosRangeList.SetNext(new Node<Range>(R));
                    PosRangeList = PosRangeList.GetNext();
                }
                from = PosL.GetNext().GetValue();
            }
            PosL = PosL.GetNext();
        }
        R = new Range(from, PosL.GetValue());
        if (RangeList == null)
            RangeList = new Node<Range>(R);
        else
            PosRangeList.SetNext(new Node<Range>(R));
        return RangeList;
    }
    //Summ of all values of stack
   
  
    static void Main(string[] args)
    {
        //Console.WriteLine("Enter Length");
        //int O = int.Parse(Console.ReadLine());
        //Node<int> PosL = AddtoLast(O);
        //PrintList(L);
        //Console.WriteLine(ListSum(L));
        //Console.WriteLine(HighList(L));
        //Console.WriteLine(IsFirstRemoved(PosL, 7));
        //Console.WriteLine(HowManyNodes(PosL));
        //Console.WriteLine(IsNumInNode(PosL,5));
        //Node<int> L1 = new Node<int>(3);
        //Node<int> Pos1 = L1;
        //Pos1.SetNext(new Node<int>(4));
        //Pos1 = Pos1.GetNext();
        //Pos1.SetNext(new Node<int>(-9));
        //Pos1 = Pos1.GetNext();
        //Pos1.SetNext(new Node<int>(2));
        //Pos1 = Pos1.GetNext();
        //Pos1.SetNext(new Node<int>(9));
        //Pos1 = Pos1.GetNext();
        //Pos1.SetNext(new Node<int>(2));
        //Pos1 = Pos1.GetNext();
        //Pos1.SetNext(new Node<int>(-9));
        //Pos1 = Pos1.GetNext();
        //Pos1.SetNext(new Node<int>(9));
        //Pos1 = Pos1.GetNext();
        //Pos1.SetNext(new Node<int>(0));
        //Pos1 = Pos1.GetNext();
        //Console.WriteLine(DeleteAllNode(Pos1));
        //Console.WriteLine(TwoPointers(L1));
        //PrintTheAllType<int>(L1);
        //PrintList(L1);
        //Console.WriteLine();
        //Console.WriteLine("**********************");
        //
        //Node<int> L2 = new Node<int>(1);
        //Node<int> Pos2 = L2;
        //Pos2.SetNext(new Node<int>(14));
        //Pos2 = Pos2.GetNext();
        //Pos2.SetNext(new Node<int>(-9));
        //Pos2 = Pos2.GetNext();
        //Pos2.SetNext(new Node<int>(12));
        //Pos2 = Pos2.GetNext();
        //Pos2.SetNext(new Node<int>(9));
        //Pos2 = Pos2.GetNext();
        //Pos2.SetNext(new Node<int>(2));
        //Pos2 = Pos2.GetNext();
        //Pos2.SetNext(new Node<int>(-9));
        //Pos2 = Pos2.GetNext();
        //Pos2.SetNext(new Node<int>(9));
        //Pos2 = Pos2.GetNext();
        //Pos2.SetNext(new Node<int>(0));
        //Pos2 = Pos2.GetNext();
        //Pos2.SetNext(new Node<int>(-9));
        //Pos2 = Pos2.GetNext();
        //PrintList(L2);
        //Console.WriteLine();
        //Console.WriteLine("************************");
        //Node<int> L3 = NewNodeFrom2(L1, L2);
        //PrintList(L3);
        //Console.WriteLine();
        //Console.WriteLine("***********************");
        //Node<int> L = new Node<int>(3);
        //Node<int> PosL = L;
        //PosL.SetNext(new Node<int>(4));
        //PosL = PosL.GetNext();
        //PosL.SetNext(new Node<int>(5));
        //PosL = PosL.GetNext();
        //PosL.SetNext(new Node<int>(12));
        //PosL = PosL.GetNext();
        //PosL.SetNext(new Node<int>(19));
        //PosL = PosL.GetNext();
        //PosL.SetNext(new Node<int>(20));
        //PosL = PosL.GetNext();
        //PosL.SetNext(new Node<int>(100));
        //PosL = PosL.GetNext();
        //PosL.SetNext(new Node<int>(101));
        //PosL = PosL.GetNext();
        //PosL.SetNext(new Node<int>(102));
        //PosL = PosL.GetNext();
        //PosL.SetNext(new Node<int>(103));
        //PosL = PosL.GetNext();
        //PosL.SetNext(new Node<int>(104));
        //PosL = PosL.GetNext();
        //PosL.SetNext(new Node<int>(200));
        //PosL = PosL.GetNext();
        //PosL.SetNext(new Node<int>(201));
        //PosL = PosL.GetNext();
        //PrintTheAllType<int>(L);
        //PrintTheAllType<Range>(CreateRangeList(L));


        //Contact C1 = new Contact("rbg9rwbjrw", "045");
        //Contact C2 = new Contact("porg[e0or", "098");
        //Contact C3 = new Contact("rbgwdqd", "0432");
        //Contact C4 = new Contact("ceafqefqw", "123");
        //PhoneBook PB1 = new PhoneBook();
        //PB1.AddFirst(C1);
        //PB1.AddLast(C2);
        //PB1.AddLast(C3);
        //PB1.AddLast(C4);
        //PB1.Remove(C3);
        ////Console.WriteLine(PB1);
        //Station S1 = new Station(0, 2);
        //Station S2 = new Station(1, 4);
        //Station S3 = new Station(5, 4);
        //Station S4 = new Station(3, 1);
        //Station S5 = new Station(5, 0);
        //BusRoute BR1 = new BusRoute(S1, S2);
        //BR1.AddStation(S3);
        //BR1.AddStation(S4);
        //BR1.AddStation(S5);
        //Console.WriteLine(BR1.RouteLength());
    }
}


