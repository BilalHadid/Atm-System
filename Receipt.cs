
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
	public partial class Receipt
	{
		public Receipt()
		{
			InitializeComponent();
			
		
		}
		
#region Default Instance
		
		private static Receipt defaultInstance;
		
		
		public static Receipt Default
		{
			get
			{
				if (defaultInstance == null)
				{
					defaultInstance = new Receipt();
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
		System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter();
		System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
		DataTable dt = new DataTable();
		string sql;
		System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
		
		public void Receipt_Load(System.Object sender, System.EventArgs e)
		{
			
			
			con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\ATMsystem.accdb";
			lbldate.Text = DateTime.Now.ToString();
			
		}
		
		public void Button1_Click(System.Object sender, System.EventArgs e)
		{
			if (lblnewbal.Text == "")
			{
				
				
			}
			else
			{
				
				con.Open();
				
				int total = int.Parse(lblnewbal.Text);
				System.Data.OleDb.OleDbDataAdapter ad = new System.Data.OleDb.OleDbDataAdapter("select * from tblinfo", con);
				
				sql = "UPDATE tblinfo SET balance=\'" + total.ToString() + "\'" + " Where Firstname=\'" + lblname.Text + "\'";
				cmd.CommandText = sql;
				cmd.Connection = con;
				cmd.ExecuteNonQuery();
				cmd.Dispose();
				
				con.Close();
				
				
				
				
			}
			
			if (MessageBox.Show("Do You Want to Continue Your transaction??", "Continue", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
			{
				Mainmenu.Default.Show();
			}
			else
			{
				MessageBox.Show("Thank You Come Again");
				
				Login_frm.Default.Show();
				
			}
			this.Close();
		}
	}
}
