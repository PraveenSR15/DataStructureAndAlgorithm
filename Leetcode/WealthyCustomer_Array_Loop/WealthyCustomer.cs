using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.WealthyCustomer_Array_Loop
{
    public class WealthyCustomer
    {
        public int MaximumWealth(int[][] accounts)
        {
            var noOfCustomers = accounts.Length;
            int maxWealth = 0;
            for (int i = 0; i< noOfCustomers; i++)
            {
                var wealthSize = accounts[i].Length;
                int customerWealth = 0;
                for(int j = 0;j<wealthSize;j++)
                {
                    customerWealth += accounts[i][j];
                }
                if(customerWealth > maxWealth)
                    maxWealth = customerWealth;
            }
            return maxWealth;
        }
    }
}
