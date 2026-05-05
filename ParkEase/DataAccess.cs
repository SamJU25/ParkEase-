using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkEase
{
    public class DataAccess
    {
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return this.sqlcon; }
            set { this.sqlcon = value; }
        }

        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return this.sqlcom; }
            set { this.sqlcom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return this.sda; }
            set { this.sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return this.ds; }
            set { this.ds = value; }
        }


        public DataAccess()
        {
            try
            {
                // connect to sql database
                this.Sqlcon = new SqlConnection(@"Data Source=TENDA\SQLEXPRESS;Initial Catalog=ParkEaseDB;Integrated Security=True");
                Sqlcon.Open(); // open connection
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
        }

        private void QueryText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
        }

        public DataSet ExecuteQuery(string sql)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);//this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds;
        }

        public DataTable ExecuteQueryTable(string sql)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);//this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds); // fetch data
            return Ds.Tables[0]; // return first table
        }

        public int ExecuteDMLQuery(string sql)
        {
            this.Sqlcom = new SqlCommand(sql, this.Sqlcon);//this.QueryText(sql);
            int u = this.Sqlcom.ExecuteNonQuery(); // run insert/update/delete
            return u; // return rows affected
        }
    }
}