using SportClass;
using System.Runtime.CompilerServices;

void PrintTheNameClass(SportClub SC,char Day)
{
    for (int i = 0; i < SC.GetNumOfClass(); i++)
    {
        if (SC.GetArr()[i].GetDay() == Day && SC.GetArr()[i].Getprice() == 0) 
        {
            Console.WriteLine(SC.GetArr()[i].ToString);
        }
    }
}