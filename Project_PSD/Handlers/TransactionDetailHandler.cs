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

        public static bool checkTokenUnique(string token)
        {
            return TransactionDetailRepository.checkTokenUnique(token);
        }

        public static TransactionDetail GetTransactionDetailByToken(string token)
        {
            return TransactionDetailRepository.GetTransactionDetailByToken(token);
        }

        public static List<string> InsertTransactionDetail(int transactId, int qty)
        {
            List<string> tokens = new List<string>();

            for(int i = 0; i < qty; i++)
            {
                string token = CreateToken();
                tokens.Add(token);
                TransactionDetail newTd = TransactionDetailFactory.Create(transactId, token);
                TransactionDetailRepository.InsertTransactDetail(newTd);
            }
            return tokens;
        }
        public static List<TransactionDetail> getTransDetListByHeadId(int HeadId)
        {
            return TransactionDetailRepository.getTransDetListByHeadId(HeadId);
        }

        public static List<String> getUnUsedAndUsedTokenByHeadId(int HeadId, string get)
        {
            List<TransactionDetail> currTD = getTransDetListByHeadId(HeadId);
            List<String> UsedToken = new List<string>();
            List<String> UnUsed = new List<string>();

            for (int i = 0; i < currTD.Count(); i++)
            {
                if (currTD[i].StatusId == 1)
                    UnUsed.Add(currTD[i].Token);
                else
                    UsedToken.Add(currTD[i].Token);
            }

            if (get == "Unused")
                return UnUsed;
            
            return UsedToken;
        }

        public static bool UpdateStatus(TransactionDetail TD)
        {
            if (TD != null)
            {
                return TransactionDetailRepository.UpdateStatus(TD);
            }
            return false;
        }


    }
}