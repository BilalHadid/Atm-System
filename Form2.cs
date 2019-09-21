
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



namespace atmsystem
{
	public partial class Regs_frm
	{
		public Regs_frm()
		{
	
			constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\ATMsystem.accdb";
			conn = new System.Data.OleDb.OleDbConnection(constr);
			
			InitializeComponent();
			

		}
		
#region Default Instance
		
		private static Regs_frm defaultInstance;
		
		
		public static Regs_frm Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new Regs_frm();
					defaultInstance.FormClosed += new FormClosedEventHandler(defaultInstance_FormClosed);
				}
				
				return defaultInstance;
			}
		}
		
		static void defaultInstance_FormClosed(object sender, FormClosedEventArgs e)
		{
			defaultInstance = null;
		}
		
#endregion
		string constr; 
		System.Data.OleDb.OleDbDataAdapter adapt;
		System.Data.OleDb.OleDbDataAdapter adapt1 = new System.Data.OleDb.OleDbDataAdapter();
		System.Data.OleDb.OleDbConnection conn;
		DataSet dset = new DataSet();
		
		
		public void btnRegister_Click(System.Object sender, System.EventArgs e)
		{
			if (txtAcctNo.Text == "" && txtPincode.Text == "" && txtcontact.Text == "" && txtfname.Text == "" && txtlname.Text == "" && txtaddr.Text == "" && txtcontact.Text == "" && cbGender.Text == "" && cbday.Text == "" && cbmonth.Text == "" && cbyear.Text == "")
			{
				MessageBox.Show("Enter All Fields");
				
			}
			else if (txtAcctNo.Text == "" || txtPincode.Text == "" || txtcontact.Text == "" || txtfname.Text == "" || txtlname.Text == "" || txtaddr.Text == "" || txtcontact.Text == "" || cbGender.Text == "" || cbday.Text == "" || cbmonth.Text == "" || cbyear.Text == "")
			{
				MessageBox.Show("Pls Complete all Fields");
				
			}
			else
			{
				System.Data.OleDb.OleDbDataAdapter adapt1 = new System.Data.OleDb.OleDbDataAdapter("select * from tblinfo where Firstname=\'" + txtfname.Text + "\'", conn);
				DataSet dset1 = new DataSet();
				adapt1.Fill(dset1);
				if (dset1.Tables[0].Rows.Count != 0)
				{
					MessageBox.Show("Account name already exist");
				}
				else
				{
					string dbcommand = "INSERT into tblinfo (account_no, Firstname, Lastname, Address, Contact_no, Gender, Birthday, pin_code , type, balance)" + " VALUES (\'" + (txtAcctNo.Text + "\',\'") + txtfname.Text + "\',\'" + txtlname.Text + "\',\'" + txtaddr.Text + "\',\'" + txtcontact.Text + "\',\'" + cbGender.Text + "\',\'" + (cbmonth.Text + cbday.Text + cbyear.Text) + "\',\'" + txtPincode.Text + "\',\'" + "Active" + "\',\'" + "1000" + "\')";
					System.Data.OleDb.OleDbDataAdapter adapt = new System.Data.OleDb.OleDbDataAdapter(dbcommand, conn);
					DataSet dset = new DataSet();
					adapt.Fill(dset);
					MessageBox.Show("You Have Succesfully Registered!");
					this.Hide();
					Login_frm.Default.Show();
				}
			}
		}
		
		public void Regs_frm_Load(System.Object sender, System.EventArgs e)
		{
			lbldate.Text = DateTime.Now.ToString();
			
			conn.ConnectionString = constr;
			conn.Open();
		}
		
		public void Button1_Click(System.Object sender, System.EventArgs e)
		{
			this.Close();
			Login_frm.Default.Show();
		}
	}
}
