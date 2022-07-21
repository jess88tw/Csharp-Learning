using System.Data.SqlClient;
namespace SQLDB
{
    public partial class Form1 : Form
    {
        // string connstr = @"Server=10.0.1.200; Database=db00; UID=Test; PWD=1234";
        string connstr = (@"data source = localhost; initial catalog = sql_tutorial; Integrated Security = SSPI");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(connstr);
            cn.Open();
            cn.Close();
            MessageBox.Show("連線成功");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(connstr);
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = @"INSERT INTO dbo.Product
                                (prdt_id, prdt_name, price)
                                VALUES
                                (@id, @name, @price)";

            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@price", txtPrice.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("新增成功");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(connstr);
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = @"UPDATE dbo.Product
                                SET prdt_name=@name, price=@price
                                WHERE prdt_id=@id";
            
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@price", txtPrice.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("修改成功");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(connstr);
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = @"DELETE FROM dbo.Product
                                WHERE prdt_id=@id";
            
            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
            txtName.Clear();
            txtPrice.Clear();
            MessageBox.Show("刪除成功");
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(connstr);
            SqlCommand cmd = cn.CreateCommand();
            cmd.CommandText = @"SELECT * FROM dbo.Product
                                WHERE prdt_id=@id";

            cmd.Parameters.AddWithValue("@id", txtId.Text);
            cn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                txtName.Text = dr["prdt_name"].ToString();
                txtPrice.Text = dr["price"].ToString();
            }
            else
            {
                txtName.Clear();
                txtPrice.Clear();
            }
            cn.Close();
        }
    }
}