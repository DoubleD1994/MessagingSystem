
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class Message
{
    

    public abstract int getMaxMessageLength();

    //return the number part of message ID
    public string getMessageID()
    {
        Random rnd = new Random();
        string messageID;

        //make the number a selection of 9 random digits
        int digit1 = rnd.Next(10);
        int digit2 = rnd.Next(10);
        int digit3 = rnd.Next(10);
        int digit4 = rnd.Next(10);
        int digit5 = rnd.Next(10);
        int digit6 = rnd.Next(10);
        int digit7 = rnd.Next(10);
        int digit8 = rnd.Next(10);
        int digit9 = rnd.Next(10);

        //concating the digits to a string
        messageID = digit1.ToString() + digit2.ToString() + digit3.ToString() + 
                    digit3.ToString() + digit5.ToString() + digit6.ToString() +
                    digit7.ToString() + digit8.ToString() + digit9.ToString() ;
        //returing the messageID
        return messageID;
    }



    

}


