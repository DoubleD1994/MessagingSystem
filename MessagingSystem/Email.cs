
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public class Email : Message
{
    protected string emailType;
    protected string subject;

    public ArrayList addQuarintineURLsToList(string message)
    {
        string[] seperator = new string[] { " " };
        string[] temp;

        temp = message.Split(seperator, StringSplitOptions.None);

        ArrayList quarintines = new ArrayList();

        foreach (string s in temp)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(s, @"^(www.+[\w\d]{1,}.(com|co\.uk|net))$"))
            {
                quarintines.Add(s);
            }
        }

        return quarintines;
    }

    public String removeQuarintineURLs(ArrayList URLs, string message)
    {
        foreach (string s in URLs)
        {
            if (message.Contains(s))
            {
                message = message.Replace(s, "<URL Quarintined>");
            }
        }

        return message;
    }

    public Boolean isSIR(string subject)
    {
        if (System.Text.RegularExpressions.Regex.IsMatch(subject, @"^((SIR)\s([123]0|[012][1-9]|31)\/(0[1-9]|1[012])\/([0-9]{2}))$"))
        {
            return true;
        }

        return false;
    }

    public String formatSIRMessage(string ID, string email, string subject, string message)
    {
        string sortCode = null;
        string noi = null;

        string[] seperator = new string[] { " " };
        string[] temp;

        temp = message.Split(seperator, StringSplitOptions.None);

        int counter = 0;

        foreach (string s in temp)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(s, @"^(([0-9]{2})\-([0-9]{2})\-([0-9]{2}))$") && counter == 0)
            {
                sortCode = s;
                message = message.Replace(s,"");
            }
            counter++;
        }

        counter = 0;

        foreach (string s in temp)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(s, @"^(Theft|Staff Attack|ATM Theft|Raid|Customer Attack|Staff Abuse|Bomb Threat|Terrorism|Suspicious Incident|Intelligence|Cash Loss)$") && counter == 1)
            {
                noi = s;
                message = message.Replace(s, "");
            }
            counter++;
        }

        if (sortCode != null && noi != null)
        {
            return " Message ID: " + ID +
                   "\n Sender: " + email +
                   "\n Subject: " + subject +
                   "\n Sort Code: " + sortCode +
                   "\n Nature Of Incedent: " + noi +
                   "\n Message: " + message;
        }
        else 
        {
            return " Message ID: " + ID +
                   "\n Sender: " + email +
                   "\n Subject: " + subject +
                   "\n SIR missing Sort Code or Nature Of Incodent";
        }
    }

    //getters and setters for the email type
    public string getEmailType()
    {
        return this.emailType;
    }

    public void setEmailType(string emailType)
    {
        this.emailType = emailType;
    }

    //return message length for if sender type is email
    public override int getMaxMessageLength()
    {
        return 1024;
    }
}

