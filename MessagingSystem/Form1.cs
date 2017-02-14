using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessagingSystem
{
    public partial class frmSystem : Form
    {
        public frmSystem()
        {
            InitializeComponent();          
        }

        Message m;

        //button to make sure sender is valid
        private void btnValidate_Click(object sender, EventArgs e)
        {
            determineSender ds = new determineSender();

            //passes in the sender to determine the type of message
            ds.setSender(txtSender.Text);

            //sets the message ID
            txtMessageID.Text = ds.getSender();

            //sets the max lengtht of the message body
            txtMessage.MaxLength = ds.getMaxCharLength();

            //if the sender is valid, make message fields and write button visible
            lblMessage.Visible = ds.getFieldsVisible();
            txtMessage.Visible = ds.getFieldsVisible();
            btnWrite.Visible = ds.getFieldsVisible();

            //if the sender is a SMS or tweet message then set the Expand Abbreviatins button to visible
            button1.Visible = ds.getExpandAbrevsVisible();

            //if the sender is an email then allow the user to input a subject and to view the quartintine URL options
            lblSubject.Visible = ds.getSubjectVisible();
            lblQuarintine.Visible = ds.getSubjectVisible();
            txtSubject.Visible = ds.getSubjectVisible();
            txtQuarintinedURLs.Visible = ds.getSubjectVisible();
            btnQuarintine.Visible = ds.getSubjectVisible();

            //if sender is tweet make hashtag and mentions list visible
            lblHashTag.Visible = ds.getTweetVisible();
            lblMentions.Visible = ds.getTweetVisible();
            txtHashTags.Visible = ds.getTweetVisible();
            txtMentions.Visible = ds.getTweetVisible();
            btnTweetlists.Visible = ds.getTweetVisible();

        }

        WriteToFile wtf = new WriteToFile();
        ArrayList output = new ArrayList();
        ArrayList sirOutput = new ArrayList();
        //button to write the messages to a file 
        private void btnWrite_Click(object sender, EventArgs e)
        {
            string message;
            
            message = " Message ID: " + txtMessageID.Text +
                    "\n Sender: " + txtSender.Text +
                    "\n Subject: " + txtSubject.Text +
                    "\n Message: " + txtMessage.Text;

            output.Add(message);

            Email m = new Email();
            if (m.isSIR(txtSubject.Text))
            {
                sirOutput.Add(message);
                output.Remove(message);
                message = m.formatSIRMessage(txtMessageID.Text, txtSender.Text, txtSubject.Text, txtMessage.Text);
            }

            MessageBox.Show(message);

            wtf.performWrite(output);
            wtf.performSirWrite(sirOutput);
            
            //clear all the fields so that a new message can be entered
            txtSender.Clear();
            txtMessageID.Clear();
            txtSubject.Clear();
            txtMessage.Clear();

            //if the subject field was made visible, make it invisible again
            lblSubject.Visible = false;
            txtSubject.Visible = false;

            //if the quarintine object were set visible, then make visible false again
            lblQuarintine.Visible = false;
            txtQuarintinedURLs.Visible = false;
            btnQuarintine.Visible = false;

            //if message was tweet, set hashtags and mentions list tpo invisible again
            lblHashTag.Visible = false;
            txtHashTags.Visible = false;
            lblMentions.Visible = false;
            txtMentions.Visible = false;
            btnTweetlists.Visible = false;

            //set fields invisble again
            lblMessage.Visible = false;
            txtMessage.Visible = false;
            btnWrite.Visible = false;

            //if the expand abbreviations visible was set to true then set to false
            button1.Visible = false;
        }

        private void btnTweetlists_Click(object sender, EventArgs e)
        {
            ArrayList mentions;
            ArrayList hashtags;

            string messageBody = txtMessage.Text;

            Tweet t = new Tweet();
            mentions = t.addToMentionsList(messageBody);
            hashtags = t.addToTrendingList(messageBody);

            foreach (String s in hashtags)
            {               
                txtHashTags.AppendText(s + "\n");
            } 

            foreach (String s in mentions)
            {
                txtMentions.AppendText(s + "\n");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //once button is clicked, will expand any abbreviation in the text field
            //although says SMS, can be used for tweets aswell
            SMS s = new SMS();

            String messageBody = txtMessage.Text;

            messageBody = s.textSpeakAbbrevations(messageBody);

            txtMessage.Text = messageBody;                                                                    
        }

        private void btnQuarintine_Click(object sender, EventArgs e)
        {
            Email em = new Email();

            String messageBody = txtMessage.Text;

            ArrayList quarintineList;

            quarintineList = em.addQuarintineURLsToList(messageBody);

            foreach (String s in quarintineList)
            {
                txtQuarintinedURLs.AppendText(s + "\n");
            }

            messageBody = em.removeQuarintineURLs(quarintineList, messageBody);

            txtMessage.Text = messageBody;

        }

        private void frmSystem_Load(object sender, EventArgs e)
        {
            Console.Write("Running Program...");
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            MessageBox.Show("HashTags: \n" + txtHashTags.Text);
            MessageBox.Show("Mentions: \n" + txtMentions.Text);
            MessageBox.Show("Quarintine List: \n" +  txtQuarintinedURLs.Text);
        }
    }
}
