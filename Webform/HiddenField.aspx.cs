using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webform
{
    public partial class HiddenField : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadEmployee();
            }
        }

        private void LoadEmployee()
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using(SqlConnection con = new SqlConnection(cs))
            {
                string sql = "select Id, Name, Gender, DeptName from Employee where Id=1";
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                using(SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        txtName.Text = dr["Name"].ToString();
                        txtGender.Text = dr["Gender"].ToString();
                        txtDeptName.Text = dr["DeptName"].ToString();
                        ID.Value = dr["Id"].ToString();
                    }
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using(SqlConnection con = new SqlConnection(cs))
            {
                string sql = "update Employee set Name=@Name, Gender=@Gender, DeptName=@DeptName where Id=@Id";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Gender", txtGender.Text);
                cmd.Parameters.AddWithValue("@DeptName", txtDeptName.Text);
                cmd.Parameters.AddWithValue("@Id", ID.Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                txtDeptName.Text = string.Empty;
                txtGender.Text = string.Empty;
                txtName.Text = string.Empty;
            }
        }

        protected void btnLoad_Click(object sender, EventArgs e)
        {
            LoadEmployee();
        }
    }
}