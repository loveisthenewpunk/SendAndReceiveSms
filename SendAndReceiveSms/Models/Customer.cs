using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SendAndReceiveSms.Models
{
    public class Customer
    {
        
	    public int customer_row_id;
        public int customer_id;
        public string dob; //"3/15/1968"
        public string gender; // "Female",
        public string first_name; //"Victoria",
        public string last_name; //"Busch",
        public string email; //"vbusch0@typepad.com",
        public string phone_number; //"701 - 381 - 8430",
        public string address; //"9 Johnson Crossing",
        public string state; //"North Dakota",
        public string city; //"Fargo",
        public int zipcode;//"58122",
        public string country; //"United States",
        public bool is_married;//false,
        public long credit_card_number; //"6763445419793245335",
        public bool is_primary; //true,

        public Transaction[] Transactions;
    }
}