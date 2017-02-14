using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessagingSystem
{
    class determineSender
    {
        private string sender;
        private int maxCharLength;
        private string IDletter;
        private string messageType;

        private Boolean subjectView;
        private Boolean fieldsVisible;
        private Boolean tweetFieldsVisible;
        private Boolean ExpandAbrevsVisible;
        

        Message m;

         

        //get sender class returns the message ID
        public string getSender()
        {
            //if statement to determine what type sender is using regex
            //first if checks for sender being a international number
            if (System.Text.RegularExpressions.Regex.IsMatch(this.sender, @"^([+][\d]{8,15})*$"))
            {
                //setting message type to SMS
                m = new SMS();

                //setting ID letter to 'S'
                IDletter = "S";

                //set lengtht for message field
                setMaxCharLength(m.getMaxMessageLength());

                //set message fields to visible
                setFieldsVisible(true);

                //set expand abbreviations button to visible
                setExpandAbrevsVisible(true);

                //set message type to sms
                setMessageType("SMS");

            }
            //else if the sender matches email format
            else if (System.Text.RegularExpressions.Regex.IsMatch(this.sender, @"^[a-zA-Z0-9.-_]{1,20}@[a-zA-Z0-9]{1,20}[.](com|co\.uk)"))
            {
                //set message type to email
                m = new Email();

                //setting ID letter to 'E'
                IDletter = "E";

                //set lengtht for message field
                setMaxCharLength(m.getMaxMessageLength());

                //setting the subject field to visible since type is of email
                setSubjectVisible(true);

                //set message fields to visible
                setFieldsVisible(true);

                //set message type to e-mail
                setMessageType("Email");
            }      
            //else if sender matches twitter ID
            else if (System.Text.RegularExpressions.Regex.IsMatch(this.sender, @"^([@][\w\d]{1,})*$"))
            {
                //set message type to tweet
                m = new Tweet();

                //setting ID letter to 'T'
                IDletter = "T";

                //set lengtht for message field
                setMaxCharLength(m.getMaxMessageLength());

                //set message fields to visible
                setFieldsVisible(true);

                //set tweet fields to visible
                setTweetVisible(true);

                //set expand abbreviations button to visible
                setExpandAbrevsVisible(true);

                //set message type to tweet
                setMessageType("Tweet");
            }
            else
            {
                //return invalid sender if the sender field is not a SMS number, Email, or twitter ID
                return "Invalid Sender";

                //set message type to null
            }

            //returning the ID
            return IDletter + m.getMessageID();
        }

        //getting and setting the max length for the message field
        public int getMaxCharLength()
        {
            return this.maxCharLength;
        }

        public void setMaxCharLength(int mcl)
        {
            this.maxCharLength = mcl;
        }

        //setting the sender
        public void setSender(string sender)
        {
            this.sender = sender;
        }

        //getters and setter to determine if the expand abbreviations button should be visible or not
        public Boolean getExpandAbrevsVisible()
        {
            return this.ExpandAbrevsVisible;
        }

        public void setExpandAbrevsVisible(Boolean sv)
        {
            this.ExpandAbrevsVisible = sv;
        }

        //getters and setter to determine if the subject field should be visible or not
        public Boolean getSubjectVisible()
        {
            return this.subjectView;
        }

        public void setSubjectVisible(Boolean sv)
        {
            this.subjectView = sv;
        }

        //getters and setter to determine if the message body fields and write to button should be visible or not
        public Boolean getFieldsVisible()
        {
            return this.fieldsVisible;
        }

        public void setFieldsVisible(Boolean fv)
        {
            this.fieldsVisible = fv;
        }

        //getters and setter to determine if the twitter fields should be visible or not
        public Boolean getTweetVisible()
        {
            return this.tweetFieldsVisible;
        }

        public void setTweetVisible(Boolean tv)
        {
            this.tweetFieldsVisible = tv;
        }

        //getters and setters for message type
        public string getMessageType()
        {
            return this.messageType;
        }

        public void setMessageType(string mt)
        {
            this.messageType = mt;
        }
    }
}
