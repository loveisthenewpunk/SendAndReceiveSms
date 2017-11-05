using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SendAndReceiveSms.Models
{
    public class Transaction
    {
        public int transaction_row_id = 1; //1,
        public int transaction_id = 100110001; //100110001,
        public int day; //9,
        public string month; //"October",
        public int year; //2017,
        public string merchant_name; //"wal-mart check printng",
        public double amount; //41.29,
        public int zipcode; //"34642",
        public string country; //"United States",
        public double rewards_earned; //0.516125
    }
}