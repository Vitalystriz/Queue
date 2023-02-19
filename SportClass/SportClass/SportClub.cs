using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportClass
{
    internal class SportClub
    {
        private int NumOfClasses;
        
        private string Name;
        private SportClass[] Arr;
        public SportClub( string name)
        {
            //Array b = new int[50] 
            NumOfClasses = 0;
            Name = name;
            this.Arr = new SportClass[50];
            for (int i = 0; i < 50; i++)
            {
                this.Arr[i] = null;
            }
        }
        public int CountClass(char day)
        {
            int count = 0;  
            for(int i = 0; i < this.NumOfClasses; i++)
            {
                if (this.Arr[i].GetDay() ==day)
                {
                    count++;
                }
            }
            return count;
        }
        public int isExist(SportClass S)
        {
            for(int i = 0; i < this.NumOfClasses; i++)
            {
                if (this.Arr[i].GetCode() == S.GetCode())
                {
                    return i;
                }
            }
            return -1;
        }
        public void AddClass(SportClass S)
        {
            if (this.NumOfClasses < this.Arr.Length)
            {
                if (isExist(S) == -1)
                {
                    this.NumOfClasses++;
                    this.Arr[this.NumOfClasses] = S;
                }
            }
                
        }
        public SportClass[] GetArr()
        {
            return this.Arr;
        }
        public int GetNumOfClass()
        {
            return this.NumOfClasses;
        }
        

    }
}
