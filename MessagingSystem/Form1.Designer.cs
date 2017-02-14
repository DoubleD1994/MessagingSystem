namespace MessagingSystem
{
    partial class frmSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnValidate = new System.Windows.Forms.Button();
            this.lblSender = new System.Windows.Forms.Label();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.RichTextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.lblMessageID = new System.Windows.Forms.Label();
            this.txtMessageID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHashTags = new System.Windows.Forms.RichTextBox();
            this.txtMentions = new System.Windows.Forms.RichTextBox();
            this.lblHashTag = new System.Windows.Forms.Label();
            this.lblMentions = new System.Windows.Forms.Label();
            this.btnTweetlists = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnQuarintine = new System.Windows.Forms.Button();
            this.txtQuarintinedURLs = new System.Windows.Forms.RichTextBox();
            this.lblQuarintine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnValidate
            // 
            this.btnValidate.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValidate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnValidate.Location = new System.Drawing.Point(385, 80);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(167, 29);
            this.btnValidate.TabIndex = 0;
            this.btnValidate.Text = "Validate Sender";
            this.btnValidate.UseVisualStyleBackColor = false;
            this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSender.Location = new System.Drawing.Point(381, 14);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(165, 24);
            this.lblSender.TabIndex = 1;
            this.lblSender.Text = "Input Sender Here";
            // 
            // txtSender
            // 
            this.txtSender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSender.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSender.Location = new System.Drawing.Point(552, 14);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(167, 24);
            this.txtSender.TabIndex = 2;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(381, 147);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(355, 24);
            this.lblSubject.TabIndex = 3;
            this.lblSubject.Text = "Input Subject Here (Max Characters = 20)";
            this.lblSubject.Visible = false;
            // 
            // txtSubject
            // 
            this.txtSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubject.Location = new System.Drawing.Point(385, 174);
            this.txtSubject.MaxLength = 20;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(918, 24);
            this.txtSubject.TabIndex = 4;
            this.txtSubject.Visible = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(381, 211);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(821, 24);
            this.lblMessage.TabIndex = 5;
            this.lblMessage.Text = "Input Message Body Here(SMS and Tweet Max Characters = 140. E-Mail Max Characters" +
    " = 1028)";
            this.lblMessage.Visible = false;
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Location = new System.Drawing.Point(385, 238);
            this.txtMessage.MaxLength = 0;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(918, 151);
            this.txtMessage.TabIndex = 6;
            this.txtMessage.Text = "";
            this.txtMessage.Visible = false;
            // 
            // btnWrite
            // 
            this.btnWrite.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnWrite.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite.ForeColor = System.Drawing.Color.White;
            this.btnWrite.Location = new System.Drawing.Point(385, 395);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(149, 61);
            this.btnWrite.TabIndex = 7;
            this.btnWrite.Text = "Write To File";
            this.btnWrite.UseVisualStyleBackColor = false;
            this.btnWrite.Visible = false;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // lblMessageID
            // 
            this.lblMessageID.AutoSize = true;
            this.lblMessageID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageID.Location = new System.Drawing.Point(941, 14);
            this.lblMessageID.Name = "lblMessageID";
            this.lblMessageID.Size = new System.Drawing.Size(109, 24);
            this.lblMessageID.TabIndex = 8;
            this.lblMessageID.Text = "Message ID";
            // 
            // txtMessageID
            // 
            this.txtMessageID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessageID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageID.Location = new System.Drawing.Point(1056, 16);
            this.txtMessageID.Name = "txtMessageID";
            this.txtMessageID.ReadOnly = true;
            this.txtMessageID.Size = new System.Drawing.Size(197, 24);
            this.txtMessageID.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(381, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Click Button To Validate Sender";
            // 
            // txtHashTags
            // 
            this.txtHashTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHashTags.Location = new System.Drawing.Point(1338, 41);
            this.txtHashTags.Name = "txtHashTags";
            this.txtHashTags.ReadOnly = true;
            this.txtHashTags.Size = new System.Drawing.Size(134, 157);
            this.txtHashTags.TabIndex = 11;
            this.txtHashTags.Text = "";
            this.txtHashTags.Visible = false;
            // 
            // txtMentions
            // 
            this.txtMentions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMentions.Location = new System.Drawing.Point(1338, 238);
            this.txtMentions.Name = "txtMentions";
            this.txtMentions.ReadOnly = true;
            this.txtMentions.Size = new System.Drawing.Size(134, 151);
            this.txtMentions.TabIndex = 12;
            this.txtMentions.Text = "";
            this.txtMentions.Visible = false;
            // 
            // lblHashTag
            // 
            this.lblHashTag.AutoSize = true;
            this.lblHashTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHashTag.Location = new System.Drawing.Point(1334, 11);
            this.lblHashTag.Name = "lblHashTag";
            this.lblHashTag.Size = new System.Drawing.Size(132, 24);
            this.lblHashTag.TabIndex = 13;
            this.lblHashTag.Text = "Trending List";
            this.lblHashTag.Visible = false;
            // 
            // lblMentions
            // 
            this.lblMentions.AutoSize = true;
            this.lblMentions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMentions.Location = new System.Drawing.Point(1334, 211);
            this.lblMentions.Name = "lblMentions";
            this.lblMentions.Size = new System.Drawing.Size(132, 24);
            this.lblMentions.TabIndex = 14;
            this.lblMentions.Text = "Mentions List";
            this.lblMentions.Visible = false;
            // 
            // btnTweetlists
            // 
            this.btnTweetlists.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnTweetlists.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTweetlists.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnTweetlists.Location = new System.Drawing.Point(1338, 395);
            this.btnTweetlists.Name = "btnTweetlists";
            this.btnTweetlists.Size = new System.Drawing.Size(134, 60);
            this.btnTweetlists.TabIndex = 15;
            this.btnTweetlists.Text = "Add to Tweet list";
            this.btnTweetlists.UseVisualStyleBackColor = false;
            this.btnTweetlists.Visible = false;
            this.btnTweetlists.Click += new System.EventHandler(this.btnTweetlists_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1170, 395);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 61);
            this.button1.TabIndex = 16;
            this.button1.Text = "Expand Abbreviations";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnQuarintine
            // 
            this.btnQuarintine.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnQuarintine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuarintine.ForeColor = System.Drawing.Color.White;
            this.btnQuarintine.Location = new System.Drawing.Point(12, 395);
            this.btnQuarintine.Name = "btnQuarintine";
            this.btnQuarintine.Size = new System.Drawing.Size(140, 60);
            this.btnQuarintine.TabIndex = 17;
            this.btnQuarintine.Text = "Quarintine";
            this.btnQuarintine.UseVisualStyleBackColor = false;
            this.btnQuarintine.Visible = false;
            this.btnQuarintine.Click += new System.EventHandler(this.btnQuarintine_Click);
            // 
            // txtQuarintinedURLs
            // 
            this.txtQuarintinedURLs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuarintinedURLs.Location = new System.Drawing.Point(12, 41);
            this.txtQuarintinedURLs.Name = "txtQuarintinedURLs";
            this.txtQuarintinedURLs.ReadOnly = true;
            this.txtQuarintinedURLs.Size = new System.Drawing.Size(363, 348);
            this.txtQuarintinedURLs.TabIndex = 18;
            this.txtQuarintinedURLs.Text = "";
            this.txtQuarintinedURLs.Visible = false;
            // 
            // lblQuarintine
            // 
            this.lblQuarintine.AutoSize = true;
            this.lblQuarintine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuarintine.Location = new System.Drawing.Point(8, 14);
            this.lblQuarintine.Name = "lblQuarintine";
            this.lblQuarintine.Size = new System.Drawing.Size(144, 24);
            this.lblQuarintine.TabIndex = 19;
            this.lblQuarintine.Text = "Quarintine List";
            this.lblQuarintine.Visible = false;
            // 
            // frmSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1487, 468);
            this.Controls.Add(this.lblQuarintine);
            this.Controls.Add(this.txtQuarintinedURLs);
            this.Controls.Add(this.btnQuarintine);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTweetlists);
            this.Controls.Add(this.lblMentions);
            this.Controls.Add(this.lblHashTag);
            this.Controls.Add(this.txtMentions);
            this.Controls.Add(this.txtHashTags);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMessageID);
            this.Controls.Add(this.lblMessageID);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.txtSender);
            this.Controls.Add(this.lblSender);
            this.Controls.Add(this.btnValidate);
            this.Name = "frmSystem";
            this.Text = "Messaging System";
            this.Load += new System.EventHandler(this.frmSystem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValidate;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.RichTextBox txtMessage;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Label lblMessageID;
        private System.Windows.Forms.TextBox txtMessageID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox txtHashTags;
        private System.Windows.Forms.RichTextBox txtMentions;
        private System.Windows.Forms.Label lblHashTag;
        private System.Windows.Forms.Label lblMentions;
        private System.Windows.Forms.Button btnTweetlists;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnQuarintine;
        private System.Windows.Forms.RichTextBox txtQuarintinedURLs;
        private System.Windows.Forms.Label lblQuarintine;
    }
}

