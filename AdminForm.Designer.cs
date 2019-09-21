// VBConversions Note: VB project level imports
using System.Diagnostics;
using System;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.Linq;
// End of VB project level imports


namespace atmsystem
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class AdminForm : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}
		
		//Required by the Windows Form Designer
		private System.ComponentModel.Container components = null;
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.Button4 = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Button5 = new System.Windows.Forms.Button();
            this.lblhide = new System.Windows.Forms.Label();
            this.Button1 = new System.Windows.Forms.Button();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbday = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.btnunblock = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtaddr = new System.Windows.Forms.TextBox();
            this.btnblock = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtcontact = new System.Windows.Forms.TextBox();
            this.txtlnme = new System.Windows.Forms.TextBox();
            this.txtfnme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.txtPincode = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtAcctNo = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(7, 25);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(101, 20);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "First Name:";
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.btnok);
            this.GroupBox1.Controls.Add(this.txtlname);
            this.GroupBox1.Controls.Add(this.Button4);
            this.GroupBox1.Controls.Add(this.btnedit);
            this.GroupBox1.Controls.Add(this.txtfname);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(446, 26);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(503, 168);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Admin";
            this.GroupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(7, 62);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 20);
            this.Label2.TabIndex = 7;
            this.Label2.Text = "Last Name:";
            this.Label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // btnok
            // 
            this.btnok.BackColor = System.Drawing.Color.White;
            this.btnok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.ForeColor = System.Drawing.Color.Navy;
            this.btnok.Location = new System.Drawing.Point(190, 114);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(138, 31);
            this.btnok.TabIndex = 5;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = false;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // txtlname
            // 
            this.txtlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlname.Location = new System.Drawing.Point(113, 59);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(197, 26);
            this.txtlname.TabIndex = 5;
            // 
            // Button4
            // 
            this.Button4.BackColor = System.Drawing.Color.White;
            this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.ForeColor = System.Drawing.Color.Navy;
            this.Button4.Location = new System.Drawing.Point(348, 56);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(138, 31);
            this.Button4.TabIndex = 4;
            this.Button4.Text = "Search";
            this.Button4.UseVisualStyleBackColor = false;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.White;
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.Navy;
            this.btnedit.Location = new System.Drawing.Point(348, 19);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(138, 31);
            this.btnedit.TabIndex = 4;
            this.btnedit.Text = "Edit";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // txtfname
            // 
            this.txtfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfname.Location = new System.Drawing.Point(114, 22);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(196, 26);
            this.txtfname.TabIndex = 2;
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(452, 256);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(493, 171);
            this.DataGridView1.TabIndex = 3;
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.White;
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.Color.Navy;
            this.Button5.Location = new System.Drawing.Point(452, 219);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(138, 31);
            this.Button5.TabIndex = 5;
            this.Button5.Text = "Load All";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // lblhide
            // 
            this.lblhide.AutoSize = true;
            this.lblhide.Location = new System.Drawing.Point(655, 444);
            this.lblhide.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhide.Name = "lblhide";
            this.lblhide.Size = new System.Drawing.Size(0, 13);
            this.lblhide.TabIndex = 4;
            this.lblhide.Visible = false;
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.White;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.Navy;
            this.Button1.Location = new System.Drawing.Point(780, 219);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(138, 31);
            this.Button1.TabIndex = 8;
            this.Button1.Text = "Logout";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.txtbday);
            this.GroupBox2.Controls.Add(this.Label8);
            this.GroupBox2.Controls.Add(this.Label11);
            this.GroupBox2.Controls.Add(this.btnunblock);
            this.GroupBox2.Controls.Add(this.btncancel);
            this.GroupBox2.Controls.Add(this.btnupdate);
            this.GroupBox2.Controls.Add(this.cbGender);
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.txtaddr);
            this.GroupBox2.Controls.Add(this.btnblock);
            this.GroupBox2.Controls.Add(this.Label7);
            this.GroupBox2.Controls.Add(this.txtcontact);
            this.GroupBox2.Controls.Add(this.txtlnme);
            this.GroupBox2.Controls.Add(this.txtfnme);
            this.GroupBox2.Controls.Add(this.label5);
            this.GroupBox2.Controls.Add(this.Label9);
            this.GroupBox2.Controls.Add(this.Label10);
            this.GroupBox2.Controls.Add(this.txtPincode);
            this.GroupBox2.Controls.Add(this.Label6);
            this.GroupBox2.Controls.Add(this.txtAcctNo);
            this.GroupBox2.Controls.Add(this.Label3);
            this.GroupBox2.Location = new System.Drawing.Point(12, 26);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(419, 401);
            this.GroupBox2.TabIndex = 9;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "AccountInfo";
            // 
            // txtbday
            // 
            this.txtbday.Location = new System.Drawing.Point(261, 259);
            this.txtbday.Name = "txtbday";
            this.txtbday.Size = new System.Drawing.Size(121, 20);
            this.txtbday.TabIndex = 36;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(195, 257);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(60, 20);
            this.Label8.TabIndex = 35;
            this.Label8.Text = "B-day:";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label11.Location = new System.Drawing.Point(228, 366);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(37, 15);
            this.Label11.TabIndex = 34;
            this.Label11.Text = "Date";
            // 
            // btnunblock
            // 
            this.btnunblock.BackColor = System.Drawing.Color.White;
            this.btnunblock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnunblock.ForeColor = System.Drawing.Color.Navy;
            this.btnunblock.Location = new System.Drawing.Point(24, 350);
            this.btnunblock.Name = "btnunblock";
            this.btnunblock.Size = new System.Drawing.Size(138, 31);
            this.btnunblock.TabIndex = 3;
            this.btnunblock.Text = "Unblock";
            this.btnunblock.UseVisualStyleBackColor = false;
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.White;
            this.btncancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.ForeColor = System.Drawing.Color.Navy;
            this.btncancel.Location = new System.Drawing.Point(301, 307);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(92, 36);
            this.btncancel.TabIndex = 24;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = false;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.White;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.Navy;
            this.btnupdate.Location = new System.Drawing.Point(189, 307);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(92, 36);
            this.btnupdate.TabIndex = 23;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbGender.Location = new System.Drawing.Point(103, 256);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(70, 21);
            this.cbGender.TabIndex = 29;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(23, 257);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(74, 20);
            this.Label4.TabIndex = 28;
            this.Label4.Text = "Gender:";
            // 
            // txtaddr
            // 
            this.txtaddr.Location = new System.Drawing.Point(179, 180);
            this.txtaddr.Name = "txtaddr";
            this.txtaddr.Size = new System.Drawing.Size(178, 20);
            this.txtaddr.TabIndex = 27;
            // 
            // btnblock
            // 
            this.btnblock.BackColor = System.Drawing.Color.White;
            this.btnblock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnblock.ForeColor = System.Drawing.Color.Navy;
            this.btnblock.Location = new System.Drawing.Point(24, 311);
            this.btnblock.Name = "btnblock";
            this.btnblock.Size = new System.Drawing.Size(138, 31);
            this.btnblock.TabIndex = 0;
            this.btnblock.Text = "Block";
            this.btnblock.UseVisualStyleBackColor = false;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(20, 217);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(104, 20);
            this.Label7.TabIndex = 26;
            this.Label7.Text = "Contact No:";
            // 
            // txtcontact
            // 
            this.txtcontact.Location = new System.Drawing.Point(179, 217);
            this.txtcontact.Name = "txtcontact";
            this.txtcontact.Size = new System.Drawing.Size(178, 20);
            this.txtcontact.TabIndex = 25;
            // 
            // txtlnme
            // 
            this.txtlnme.Location = new System.Drawing.Point(179, 142);
            this.txtlnme.Name = "txtlnme";
            this.txtlnme.Size = new System.Drawing.Size(178, 20);
            this.txtlnme.TabIndex = 22;
            // 
            // txtfnme
            // 
            this.txtfnme.Location = new System.Drawing.Point(179, 104);
            this.txtfnme.Name = "txtfnme";
            this.txtfnme.Size = new System.Drawing.Size(178, 20);
            this.txtfnme.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Last Name:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(20, 180);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(80, 20);
            this.Label9.TabIndex = 19;
            this.Label9.Text = "Address:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(20, 104);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(101, 20);
            this.Label10.TabIndex = 18;
            this.Label10.Text = "First Name:";
            // 
            // txtPincode
            // 
            this.txtPincode.Location = new System.Drawing.Point(179, 65);
            this.txtPincode.Name = "txtPincode";
            this.txtPincode.Size = new System.Drawing.Size(178, 20);
            this.txtPincode.TabIndex = 6;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(20, 63);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(86, 20);
            this.Label6.TabIndex = 5;
            this.Label6.Text = "Pin Code:";
            // 
            // txtAcctNo
            // 
            this.txtAcctNo.Location = new System.Drawing.Point(179, 26);
            this.txtAcctNo.Name = "txtAcctNo";
            this.txtAcctNo.Size = new System.Drawing.Size(178, 20);
            this.txtAcctNo.TabIndex = 3;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(20, 26);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(147, 20);
            this.Label3.TabIndex = 1;
            this.Label3.Text = "Account Number:";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(993, 466);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.lblhide);
            this.Name = "AdminForm";
            this.Text = "ATM System";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.DataGridView DataGridView1;
		internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtlname;
		internal System.Windows.Forms.Button Button4;
		internal System.Windows.Forms.Button btnedit;
		internal System.Windows.Forms.TextBox txtfname;
		internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Label lblhide;
		internal System.Windows.Forms.Button Button1;
        private GroupBox GroupBox2;
        private TextBox txtbday;
        private Label Label8;
        private Label Label11;
        internal Button btnunblock;
        private Button btncancel;
        private Button btnupdate;
        internal ComboBox cbGender;
        private Label Label4;
        private TextBox txtaddr;
        internal Button btnblock;
        private Label Label7;
        private TextBox txtcontact;
        private TextBox txtlnme;
        private TextBox txtfnme;
        private Label label5;
        private Label Label9;
        private Label Label10;
        private TextBox txtPincode;
        private Label Label6;
        private TextBox txtAcctNo;
        private Label Label3;
	}
	
}
