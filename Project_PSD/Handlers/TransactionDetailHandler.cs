using Project_PSD.Factories;
using Project_PSD.Models;
using Project_PSD.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace Project_PSD.Handlers
{
    public class TransactionDetailHandler
    {
        public static string CreateToken()
        {
            Random r = new Random();
            bool unique = false;
            string token = "";
            while (!unique)
            {
                token = "";
                for (int i = 0; i < 6; i++)
                {
                    char newChar = (char)r.Next(97, 122);
                    token += newChar.ToString();
                }
                unique = TransactionDetailRepository.checkTokenUnique(token);
            }

            return token;
        }
        public static List<string> InsertTransactionDetail(int transactId, int qty)
        {
            List<string> tokens = new List<string>();

            for(int i = 0; i < qty; i++)
            {
                string token = CreateToken();
                tokens.Add(token);
                TransactionDetail newTd = TransactionDetailFactory.Create(transactId, token);
                //Console.WriteLine("HELOOOOOOOOOOOO");
                TransactionDetailRepository.InsertTransactDetail(newTd);
            }
            return tokens;
        }

        

       

    }
}