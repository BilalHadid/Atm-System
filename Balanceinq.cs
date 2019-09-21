
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
	public partial class Balanceinq
	{
		public Balanceinq()
		{
			InitializeComponent();
		}
		System.Data.OleDb.OleDbCommand cmd = new System.Data.OleDb.OleDbCommand();
		System.Data.OleDb.OleDbDataAdapter da = new System.Data.OleDb.OleDbDataAdapter();
		DataSet ds = new DataSet();
		System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection();
		string sql;
		
		public void Balanceinq_Load(System.Object sender, System.EventArgs e)
		{
			Label2.Text = DateTime.Now.ToString();
			
			
		}
		
		public void Button1_Click(System.Object sender, System.EventArgs e)
		{
			string sql = default(string);
			DataTable Log_in = new DataTable();
			try
			{
				if (txtpin.Text == "")
				{
					MessageBox.Show("Pls Enter Your Pin");
					
				}
				else
				{
					con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\ATMsystem.accdb";
					sql = "SELECT * FROM tblinfo where  pin_code = " + txtpin.Text + "";
					
					cmd.Connection = con;
					cmd.CommandText = sql;
					da.SelectCommand = cmd;
					da.Fill(Log_in);
					if (Log_in.Rows.Count > 0)
					{
						string balance = default(string);
						
						balance = (string) (Log_in.Rows[0]["balance"]);
						
						Receipt.Default.Show();
						//Receipt.lblaccno.Text = lblaccno.Text
						Receipt.Default.lblbal.Text = balance;
						Receipt.Default.Label4.Hide();
						Receipt.Default.Label3.Hide();
						Receipt.Default.lbldep.Hide();
						Receipt.Default.lblwith.Hide();
						Receipt.Default.Label6.Hide();
						Receipt.Default.lblnewbal.Hide();
						
						this.Hide();
						
						
					}
					else
					{
						MessageBox.Show("Pincode is incorrect");
						
					}
					
					
					
					
				}
				
			}
			catch (Exception ex)
			{
				
				MessageBox.Show(ex.Message);
			}
			
			
			txtpin.Text = "";
		}
	}
}
