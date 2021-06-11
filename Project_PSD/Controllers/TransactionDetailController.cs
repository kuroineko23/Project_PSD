using Project_PSD.Handler;
using Project_PSD.Handlers;
using Project_PSD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project_PSD.Controllers
{
    public class TransactionDetailController
    {
        public static List<String> InsertTransactionDetail(int transactId, int qty)
        {
            return TransactionDetailHandler.InsertTransactionDetail(transactId, qty);
        }
        public static List<TransactionDetail> getTransDetListByHeadId(int HeadId)
        {
            return TransactionDetailHandler.getTransDetListByHeadId(HeadId);
        }
        public static List<String> getUnUsedTokenByHeadId(int HeadId)
        {
            return TransactionDetailHandler.getUnUsedAndUsedTokenByHeadId(HeadId, "Unused");
        }
        public static List<String> getUsedTokenByHeadId(int HeadId)
        {
            return TransactionDetailHandler.getUnUsedAndUsedTokenByHeadId(HeadId, "Used");
        }
        public static TransactionDetail GetTransactionDetailByToken(string token)
        {
            return TransactionDetailHandler.GetTransactionDetailByToken(token);
        }
        public static string redeemToken(string token)
        {
            string response = "";

            if(token == "" || token.Count() != 6 || TransactionDetailHandler.checkTokenUnique(token))
            {
                response = "Token Invalid";
            }
            else
            {
                TransactionDetail currTD = TransactionDetailHandler.GetTransactionDetailByToken(token);
                if(currTD.StatusId == 2)
                {
                    response = "Used";
                }
                else
                {
                    TransactionHeader currTH = TransactionHeaderHandler.getTransHeadById(currTD.TransactionHeaderId);
                    DateTime currTime = DateTime.Now;

                    if(currTH.ShowTime < currTime)
                    {
                        response = "You missed the show. :(";
                    }
                    else
                    {
                        response = ShowHandler.GetShowById(currTH.ShowId).Url.ToString();
                    }

                    currTD.StatusId = 2;
                    TransactionDetailHandler.UpdateStatus(currTD);
                }
            }
            return response;
        }
    }
}