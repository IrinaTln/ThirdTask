using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Student
    {
        private string FirstName;
        private string LastName;
        private string GroupeName;
        private List<int> Rate;

        public Student(string firstName, string lastName, string groupeName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.GroupeName = groupeName;
            this.Rate = new List<int>();
        }

        public string getFirstName()
        {
            return this.FirstName;
        }

        public string getLastName()
        {
            return this.LastName;
        }

        public string getGroupeName()
        {
            return this.GroupeName;
        }
        public void addRate(int rate)
        {
            this.Rate.Add(rate);
        }
        
        public bool validationRate()
        {
            foreach (int itemRate in this.Rate)
            {
                if (itemRate < 4)
                {
                    return false;
                }
            }

            return true;
        }

        public void generatRandomRating()
        {
            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                this.addRate(random.Next(2, 5));
            }
        }
        
        public string showRate()
        {
            string strDating = "";

            foreach (int itemRate in this.Rate)
            {
                strDating += Convert.ToString(itemRate) + " ";
            }

            return strDating;
        }
    }
}
