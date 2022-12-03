using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._0_dsa_exams.Summer_2021_A._3rd_question
{
    public class Shipping
    {
        private string address;
        public object[] arr;

        public double sum()
        {
            int i = 0;
            double output = 0;
            for(; i < arr.Length; i++)
            {
                if (arr[i].GetType() == typeof(Book))
                    output += ((Book)arr[i]).GetPrice();
                else
                    output += ((Clothes)arr[i]).GetPrice();
            }
            return output;
        }
    }
}
