using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RaphaelPalacio_ExaminationHYBrain
{
 
    public partial class SecondWindow : Window
    {
        public SecondWindow()
        {
            InitializeComponent();
            GridResult();
        }
        public void GridResult() {
            // Why does it not work?

            /* SqlCommand cmd = new SqlCommand("SELECT * FROM Tbl_AddUsers", sqlCon);
             DataTable dt = new DataTable();
             sqlCon.Open();
             SqlDataReader dr = cmd.ExecuteReader();
             dt.Load(dr);
             sqlCon.Close();*/

            SqlConnection sqlCon = new SqlConnection(@"Data Source=DESKTOP-AUTFJ4N\SQLEXPRESS;Initial Catalog=DatabaseCon;Integrated Security=True");
            sqlCon.Open();
            string Query = "SELECT * FROM Tbl_AddUsers";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, sqlCon);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            GridView.DataContext = dt;
            sqlCon.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            try {

                string connectionString = @"Data Source=DESKTOP-AUTFJ4N\SQLEXPRESS;Initial Catalog=DatabaseCon;Integrated Security=True";
                SqlConnection con = new(connectionString);
                con.Open();

                string Query = "INSERT INTO Tbl_AddUsers (EmployeeID,CompleteName,UName,Pwd,ConfirmPwd) VALUES (@EmployeeID,@CompleteName,@Uname,@Pwd,@ConfirmPwd)";
                SqlCommand Sqlcmd = new SqlCommand(Query, con);
                Sqlcmd.Parameters.AddWithValue("@EmployeeID", TextBoxEmpID.Text);
                Sqlcmd.Parameters.AddWithValue("@CompleteName", TextBoxCompleteName.Text);
                Sqlcmd.Parameters.AddWithValue("@Uname", TextBoxUsername.Text);
                Sqlcmd.Parameters.AddWithValue("@Pwd", TextBoxPass.Text);
                Sqlcmd.Parameters.AddWithValue("@ConfirmPwd", TextBoxConfirmPass.Text);

                Sqlcmd.ExecuteNonQuery();
                con.Close();
                

                MessageBox.Show("User Successfully Added!");

            }catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            TextBoxEmpID.Clear();
            TextBoxCompleteName.Clear();
            TextBoxUsername.Clear();
            TextBoxPass.Clear();
            TextBoxConfirmPass.Clear();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var Session_End = new MainWindow();
            Session_End.Show();
           this.Close();
        }
    }
}
