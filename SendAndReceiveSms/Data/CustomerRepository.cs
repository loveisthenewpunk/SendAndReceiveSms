using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using SendAndReceiveSms.Models;

namespace SendAndReceiveSms.Data
{
    public class CustomerRepository
    {
        private static Customer[] _customer = new Customer[]
        {
            new Customer()
            {
                customer_row_id =1,
                customer_id = 100110000,
                dob = "3/15/1968",
                gender = "Female",
                first_name = "Victoria",
                last_name = "Busch",
                email = "vbusch0@typepad.com",
                phone_number = "701-381-8430",
                address = "9 Johnson Crossing",
                state = "North Dakota",
                city = "Fargo",
                zipcode = 58122,
                country = "United States",
                is_married = false,
                credit_card_number = 6763445419793245335,
                is_primary = true,
            Transactions = new Transaction[]
                {
                    new Transaction() { transaction_row_id = 1, day = 1, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 41.29, zipcode = 34642, country = "United States", rewards_earned = 0.516125},
                    new Transaction() { transaction_row_id = 1, day = 2, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 64.50, zipcode = 34642, country = "United States", rewards_earned = 0.516125},
                    new Transaction() { transaction_row_id = 1, day = 3, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 55.89, zipcode = 34642, country = "United States", rewards_earned = 0.516125},
                    new Transaction() { transaction_row_id = 1, day = 4, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 101, zipcode = 34642, country = "United States", rewards_earned = 0.516125},
                    new Transaction() { transaction_row_id = 1, day = 5, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 68.75, zipcode = 34642, country = "United States", rewards_earned = 0.516125},
                }
                // {64.50, 55.89, 101, 68.75, 88.90};
            }
        ,
        new Customer()
        {
            customer_row_id = 2,
		customer_id = 100110011,
		dob = "7/05/1962",
		gender = "Male",
		first_name = "George",
		last_name = "Busch",
		email = "geobusch0@typepad.com",
		phone_number = "701-381-2994",
		address = "9 Johnson Crossing",
		state = "North Dakota",
		city = "Fargo",
		zipcode = 58122,
		country = "United States",
		is_married = true,
		credit_card_number = 6863245791793005033,
		is_primary = true,
		Transactions = new Transaction[]
    {
        new Transaction(){ transaction_row_id = 1, day = 1, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 41.29, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
        new Transaction(){ transaction_row_id = 1, day = 2, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 64.50, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
        new Transaction(){ transaction_row_id = 1, day = 3, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 55.89, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
        new Transaction(){ transaction_row_id = 1, day = 4, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 101, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
        new Transaction(){ transaction_row_id = 1, day = 5, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 68.75, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
    }
    // {64.50, 55.89, 101, 68.75, 88.90};
        },
	new Customer()
        {
            customer_row_id = 3,
        customer_id = 100101011,
        dob = "01/06/1991",
        gender = "Female",
        first_name = "Tammy",
        last_name = "Busch",
        email = "tamtambus@typepad.com",
        phone_number = "701-381-2278",
        address = "1986 N. 1212 W.",
        state = "Nevada",
        city = "Reno",
        zipcode = 89433,
        country = "United States",
        is_married = false,
        credit_card_number = 6763315413799215215,
        is_primary = false,
        Transactions = new Transaction[]
    {
        new Transaction(){ transaction_row_id = 1, day = 1, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 41.29, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
        new Transaction(){ transaction_row_id = 1, day = 2, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 64.50, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
        new Transaction(){ transaction_row_id = 1, day = 3, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 55.89, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
        new Transaction(){ transaction_row_id = 1, day = 4, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 101, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
        new Transaction(){ transaction_row_id = 1, day = 5, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 68.75, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
    }
    },
    // {64.50, 55.89, 101, 68.75, 88.90};
        

        new Customer()
        {
            customer_row_id = 4,
		customer_id = 100111001,
		dob = "11/13/1993",
		gender = "Male",
		first_name = "Mark",
		last_name = "Busch",
		email = "markeyranger93@typepad.com",
		phone_number = "701-381-1238",
		address = "9 Johnson Crossing",
		state = "North Dakota",
		city = "Fargo",
		zipcode = 58122,
		country = "United States",
		is_married = false,
		credit_card_number = 5743610413995255513,
		is_primary = false,
		Transactions = new Transaction[]
    {
        new Transaction(){ transaction_row_id = 1, day = 1, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 41.29, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
        new Transaction(){ transaction_row_id = 1, day = 2, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 64.50, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
        new Transaction(){ transaction_row_id = 1, day = 3, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 55.89, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
        new Transaction(){ transaction_row_id = 1, day = 4, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 101, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
        new Transaction(){ transaction_row_id = 1, day = 5, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 68.75, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
    }
        // {64.50, 55.89, 101, 68.75, 88.90};
        },

        new Customer()
        {
            customer_row_id = 4,
		customer_id = 101111011,
		dob = "12/12/1996",
		gender = "Male",
		first_name = "Steve",
		last_name = "Busch",
		email = "buschbuschstevesteve@typepad.com",
		phone_number = "701-381-0019",
		address = "9 Johnson Crossing",
		state = "North Dakota",
		city = "Fargo",
		zipcode = 58122,
		country = "United States",
		is_married = false,
		credit_card_number = 4461460817945359553,
		is_primary = false,
		Transactions = new Transaction[]
    {
        new Transaction(){ transaction_row_id = 1, day = 1, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 41.29, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
        new Transaction(){ transaction_row_id = 1, day = 2, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 64.50, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
        new Transaction(){ transaction_row_id = 1, day = 3, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 55.89, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
        new Transaction(){ transaction_row_id = 1, day = 4, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 101, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
        new Transaction(){ transaction_row_id = 1, day = 5, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 68.75, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
    }
        // {64.50, 55.89, 101, 68.75, 88.90};
        },

        new Customer()
        {
            customer_row_id = 5,
		customer_id = 100111111,
		dob = "06/03/1995",
		gender = "Female",
		first_name = "Alexa",
		last_name = "Busch",
		email = "flexielexie@typepad.com",
		phone_number = "701-381-1667",
		address = "9 Johnson Crossing",
		state = "North Dakota",
		city = "Fargo",
		zipcode = 58122,
		country = "United States",
		is_married = false,
		credit_card_number = 6040614419997116543,
		is_primary = false,
		Transactions = new Transaction[]
    {
        new Transaction(){ transaction_row_id = 1, day = 1, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 41.29, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
        new Transaction(){ transaction_row_id = 1, day = 2, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 64.50, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
        new Transaction(){ transaction_row_id = 1, day = 3, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 55.89, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
        new Transaction(){ transaction_row_id = 1, day = 4, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 101, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
        new Transaction(){ transaction_row_id = 1, day = 5, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 68.75, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
    }
        // {64.50, 55.89, 101, 68.75, 88.90};
        },

        new Customer()
        {
            customer_row_id = 6,
        customer_id = 100111111,
        dob = "06/03/1998",
        gender = "Female",
        first_name = "Stacie",
        last_name = "Busch",
        email = "staceee@typepad.com",
        phone_number = "701-381-7757",
        address = "9 Johnson Crossing",
        state = "North Dakota",
        city = "Fargo",
        zipcode = 58122,
        country = "United States",
        is_married = false,
        credit_card_number = 6111626449268156447,
        is_primary = false,
        Transactions = new Transaction[]
    {
        new Transaction(){ transaction_row_id = 1, day = 1, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 41.29, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
        new Transaction(){ transaction_row_id = 1, day = 2, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 64.50, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
        new Transaction(){ transaction_row_id = 1, day = 3, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 55.89, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
        new Transaction(){ transaction_row_id = 1, day = 4, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 101, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
        new Transaction(){ transaction_row_id = 1, day = 5, month = "October", year = 2017, merchant_name = "wal-mart check printng", amount = 68.75, zipcode = 34642, country = "United States", rewards_earned = 0.516125 },
    }
    }
        // {64.50, 55.89, 101, 68.75, 88.90};
        };

        //;

        public Customer[] GetCustomer()
        {
            return _customer;
        }

        public Customer GetCustomer(int id)
        {
            Customer customerToReturn = null;

            foreach (var customer in _customer)
            {
                if (customer.customer_row_id == id)
                {
                    customerToReturn = customer;

                    break;
                }
            }

            return customerToReturn;
        }
    }
}