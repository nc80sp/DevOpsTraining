using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class Training
    {
        public bool IsEven(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool IsLogin(string username, string password)
        {
            string[][] db =
            {
                new string[]{"jobi", "jobi" },
                new string[]{"student", "Yoshidajobi2023" },
            };
            foreach (string[] row in db)
            {
                if (row[0] == username && row[1] == password)
                {
                    return true;
                }
            }
            return false;
        }

        public int GetLongStrLen(string strA, string strB)
        {
            if (strA.Length > strB.Length)
            {
                return strA.Length;
            } else
            {
                return strB.Length;
            }
        }

        public string GetTaxPrice(int price)
        {
            return (price * 1.1f).ToString()+"円";
        }
    }
}
