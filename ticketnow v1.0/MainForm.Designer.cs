namespace TicketNow_v1._0
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.lblUpdates = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.cmboLocation = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtDetailsL = new System.Windows.Forms.TextBox();
            this.txtDetailsS = new System.Windows.Forms.TextBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.cmboCategory = new System.Windows.Forms.ComboBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmboDetails = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.lblDebugHeader = new System.Windows.Forms.Label();
            this.lblHardwareID = new System.Windows.Forms.Label();
            this.btnDebug = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDebugBody = new System.Windows.Forms.Label();
            this.nameError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).BeginInit();
            this.SuspendLayout();
            // 
            // imgLogo
            // 
            this.imgLogo.Location = new System.Drawing.Point(12, 12);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(260, 47);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // lblUpdates
            // 
            this.lblUpdates.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblUpdates.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdates.Location = new System.Drawing.Point(12, 66);
            this.lblUpdates.Name = "lblUpdates";
            this.lblUpdates.Size = new System.Drawing.Size(260, 74);
            this.lblUpdates.TabIndex = 0;
            this.lblUpdates.Text = "1\r\n2\r\n3\r\n4";
            this.lblUpdates.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(779, 451);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 7;
            this.lineShape2.X2 = 275;
            this.lineShape2.Y1 = 140;
            this.lineShape2.Y2 = 140;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 8;
            this.lineShape1.X2 = 276;
            this.lineShape1.Y1 = 63;
            this.lineShape1.Y2 = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(19, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Location:";
            // 
            // txtLocation
            // 
            this.txtLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLocation.Location = new System.Drawing.Point(210, 176);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(62, 26);
            this.txtLocation.TabIndex = 3;
            // 
            // cmboLocation
            // 
            this.cmboLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmboLocation.FormattingEnabled = true;
            this.cmboLocation.Items.AddRange(new object[] {
            "Store",
            "Head Office",
            "DC",
            "Other"});
            this.cmboLocation.Location = new System.Drawing.Point(99, 175);
            this.cmboLocation.Name = "cmboLocation";
            this.cmboLocation.Size = new System.Drawing.Size(102, 28);
            this.cmboLocation.TabIndex = 2;
            this.cmboLocation.SelectedIndexChanged += new System.EventHandler(this.cmboLocation_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCategory.Location = new System.Drawing.Point(16, 213);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(77, 20);
            this.lblCategory.TabIndex = 8;
            this.lblCategory.Text = "Category:";
            // 
            // txtDetailsL
            // 
            this.txtDetailsL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDetailsL.Location = new System.Drawing.Point(99, 244);
            this.txtDetailsL.Name = "txtDetailsL";
            this.txtDetailsL.Size = new System.Drawing.Size(173, 26);
            this.txtDetailsL.TabIndex = 6;
            // 
            // txtDetailsS
            // 
            this.txtDetailsS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDetailsS.Location = new System.Drawing.Point(210, 255);
            this.txtDetailsS.Name = "txtDetailsS";
            this.txtDetailsS.Size = new System.Drawing.Size(62, 26);
            this.txtDetailsS.TabIndex = 6;
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDesc.Location = new System.Drawing.Point(11, 284);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(176, 20);
            this.lblDesc.TabIndex = 0;
            this.lblDesc.Text = "What can we help with?";
            // 
            // cmboCategory
            // 
            this.cmboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmboCategory.FormattingEnabled = true;
            this.cmboCategory.Items.AddRange(new object[] {
            "Account Maintenance",
            "Email",
            "Hardware Fault",
            "Merret",
            "Retail Java (Tills)",
            "Request",
            "Phones",
            "PoS/Store Systems",
            "Software Issue"});
            this.cmboCategory.Location = new System.Drawing.Point(99, 210);
            this.cmboCategory.Name = "cmboCategory";
            this.cmboCategory.Size = new System.Drawing.Size(173, 28);
            this.cmboCategory.TabIndex = 4;
            this.cmboCategory.SelectedIndexChanged += new System.EventHandler(this.cmboCategory_SelectedIndexChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUsername.Location = new System.Drawing.Point(6, 248);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(87, 20);
            this.lblUsername.TabIndex = 13;
            this.lblUsername.Text = "Username:";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblCopyright.Location = new System.Drawing.Point(12, 432);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(116, 13);
            this.lblCopyright.TabIndex = 15;
            this.lblCopyright.Text = "© Chris Edwicker 2016";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSubmit.Location = new System.Drawing.Point(197, 410);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 35);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmboDetails
            // 
            this.cmboDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmboDetails.FormattingEnabled = true;
            this.cmboDetails.Items.AddRange(new object[] {
            "Desktop",
            "Laptop",
            "Mac",
            "Till",
            "RF Gun",
            "Other"});
            this.cmboDetails.Location = new System.Drawing.Point(99, 253);
            this.cmboDetails.Name = "cmboDetails";
            this.cmboDetails.Size = new System.Drawing.Size(102, 28);
            this.cmboDetails.TabIndex = 6;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblName.Location = new System.Drawing.Point(38, 147);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "Name:";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUsername.Location = new System.Drawing.Point(99, 144);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(173, 26);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(12, 307);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(260, 97);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.Text = "";
            // 
            // lblDebugHeader
            // 
            this.lblDebugHeader.AutoSize = true;
            this.lblDebugHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDebugHeader.Location = new System.Drawing.Point(312, 42);
            this.lblDebugHeader.Name = "lblDebugHeader";
            this.lblDebugHeader.Size = new System.Drawing.Size(93, 17);
            this.lblDebugHeader.TabIndex = 19;
            this.lblDebugHeader.Text = "Email Subject";
            // 
            // lblHardwareID
            // 
            this.lblHardwareID.AutoSize = true;
            this.lblHardwareID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblHardwareID.Location = new System.Drawing.Point(16, 244);
            this.lblHardwareID.Name = "lblHardwareID";
            this.lblHardwareID.Size = new System.Drawing.Size(28, 20);
            this.lblHardwareID.TabIndex = 20;
            this.lblHardwareID.Text = "Fill";
            this.lblHardwareID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDebug
            // 
            this.btnDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDebug.Location = new System.Drawing.Point(692, 404);
            this.btnDebug.Name = "btnDebug";
            this.btnDebug.Size = new System.Drawing.Size(75, 35);
            this.btnDebug.TabIndex = 21;
            this.btnDebug.Text = "Debug";
            this.btnDebug.UseVisualStyleBackColor = true;
            this.btnDebug.Click += new System.EventHandler(this.btnDebug_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Email From";
            // 
            // lblDebugBody
            // 
            this.lblDebugBody.AutoSize = true;
            this.lblDebugBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDebugBody.Location = new System.Drawing.Point(311, 66);
            this.lblDebugBody.Name = "lblDebugBody";
            this.lblDebugBody.Size = new System.Drawing.Size(78, 17);
            this.lblDebugBody.TabIndex = 23;
            this.lblDebugBody.Text = "Email Body";
            // 
            // nameError
            // 
            this.nameError.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(779, 451);
            this.Controls.Add(this.lblDebugBody);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDebug);
            this.Controls.Add(this.lblHardwareID);
            this.Controls.Add(this.lblDebugHeader);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmboDetails);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.cmboCategory);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.txtDetailsS);
            this.Controls.Add(this.txtDetailsL);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmboLocation);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.imgLogo);
            this.Controls.Add(this.lblUpdates);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "TicketNow 1.0";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogo;
        private System.Windows.Forms.Label lblUpdates;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmboLocation;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtDetailsL;
        private System.Windows.Forms.TextBox txtDetailsS;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.ComboBox cmboCategory;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmboDetails;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RichTextBox txtDescription;
        public System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblDebugHeader;
        private System.Windows.Forms.Label lblHardwareID;
        private System.Windows.Forms.Button btnDebug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDebugBody;
        public System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.ErrorProvider nameError;
    }
}

