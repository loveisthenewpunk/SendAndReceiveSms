using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using SendAndReceiveSms.Models;


using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

using Twilio.TwiML;
using Twilio.AspNet.Mvc;

public class DayContainer
{


    double totalSpend, dayLimit, average;
    bool isGood, isBad;

    DayContainer()
    {
        totalSpend = 0.0;
        dayLimit = 0.0;
        average = 0.0;
        isGood = true;
        isBad = false;
    }
    void setTotalSpend(double ts)
    {
        totalSpend = ts;
    }
    double getTotalSpend()
    {
        return totalSpend;
    }
    void setDayLimit(double ds)
    {
        dayLimit = ds;
    }
    double getDayLimit()
    {

        return dayLimit;
    }
    void setAverage(double av)
    {
        average = av;
    }
    double getAverage()
    {
        return average;
    }
};


namespace SendAndReceiveSms.Controllers
{
    public class SmsController : Controller
    { 
   
        // GET: Sms
        public ActionResult Sendsms()
        {
            var accountSid = "AC40d7139daff50eab2f579d8b85962fc6";
            var authToken = "aefbe372fc7199226a4c52f5f4bf78c2";
            TwilioClient.Init(accountSid, authToken);

           // var status = "Green";
            var msg = "You spent close to your daily limit! You need to watch your spending!";
            /*
            status = color;

            if (status == "Green")  
            { msg = "You're on the right track!"; }
            if (status == "Yellow")
            {msg = "Take it easy"; }
            if (status == "Green")
            { msg = "Great work!"; }
            */



       // int i = 0;
       // double userInput, spendLimit, weekTotal = 0;

        //GET TRANSACTION ARRAY
        /*
        var customers = _customerRepository.GetCustomer();

        vector<double> Transaction = { 64.50, 55.89, 101, 68.75, 88.90 };


        DayContainer obj;

        cout << "How much do you want to spend for this week?\n"; // user inputs maximum spending amount
        cin >> spendLimit;
        obj.setDayLimit(spendLimit / 7);  // sets the day limit

        while (i < Transaction.size())
        {


            weekTotal += Transaction.at(i);            // total sum for the week
            obj.setTotalSpend(weekTotal);

            // giving warning to the user if they are getting closer to their daily limit
            if (obj.getDayLimit() - Transaction.at(i) <= 10.00 && obj.getDayLimit() - Transaction.at(i) != 0)
            {
                cout << "\nDay " << i + 1 << ":\nYOU SPENT $ " << Transaction.at(i)
                    << "! SO CLOSE TO YOUR DAILY LIMIT! YOU NEED TO MANAGE YOUR SPENDING!\n";
            }
            else if (Transaction.at(i) > obj.getDayLimit())
            {  // compare 
                cout << "\nDay " << i + 1 << ":\nWARNING!!" << Transaction.at(i) << " YOU EXCEEDED YOUR LIMIT!!\n";
                obj.setIsBad(false);
            }
            // if the user is managing their spending perfectly
            else
            {
                cout << "\nDay " << i + 1 << ":\nYou are perfectly using your credit!You saved $"
                    << setprecision(5) << obj.getDayLimit() - Transaction.at(i) << " today.\nKeep it up!\n ";
                obj.setIsGood(true);
            }

            i++;
        }

        // weekly summary 
        obj.setAverage(weekTotal / 7);
        cout << "\nYou have spent $" << weekTotal << " in this week.\n\nYou spent $ " << setprecision(5)
             << obj.getAverage() << " averagely per day while the daily spending limit was $ " << obj.getDayLimit() << endl;

    */

        //var msg = "This is a test message";

        var to = new PhoneNumber("+12022302368");
            var from = new PhoneNumber("+15712001543");
            var message = MessageResource.Create(
                to: to,
                from: from,
                body: msg);
            //Console.WriteLine(message.Sid);
            return Content(message.Sid);
        }
    }
}