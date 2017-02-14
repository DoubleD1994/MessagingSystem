using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Tweet : Message
{
    public ArrayList addToTrendingList(string message)
    {
        string[] seperator = new string[] { " " };
        string[] temp;

        temp = message.Split(seperator, StringSplitOptions.None);

        ArrayList hashtags = new ArrayList();
        foreach (string s in temp)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(s, @"^([#][\w\d]{1,})*$"))
            {
                hashtags.Add(s);
            }
        }

        return hashtags;
    }

    public ArrayList addToMentionsList(string message)
    {
        string[] seperator = new string[] {" "};
        string[] temp;

        temp = message.Split(seperator, StringSplitOptions.None);

        ArrayList mentions = new ArrayList();

        foreach(string s in temp)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(s, @"^([@][\w\d]{1,})*$"))
            {
                mentions.Add(s);
            }
        }
        
        return mentions;
    }


	//return the message length for if sender type is tweet 
    public override int getMaxMessageLength()
    {
        return 140;
    }

}

