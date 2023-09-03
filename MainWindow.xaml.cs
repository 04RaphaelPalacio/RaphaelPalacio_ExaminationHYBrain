using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Markup;

namespace RaphaelPalacio_ExaminationHYBrain
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)


        {
            

              try
            {
                
                string connectionString = @"Data Source=DESKTOP-AUTFJ4N\SQLEXPRESS;Initial Catalog=DatabaseCon;Integrated Security=True";
                SqlConnection con = new(connectionString);
                con.Open();

                string Query = "SELECT Count(1) FROM Tbl_Admin WHERE username = @username AND password= @password";
                SqlCommand Sqlcmd = new SqlCommand(Query, con);
                Sqlcmd.Parameters.AddWithValue("@username", TextBoxUname.Text);
                Sqlcmd.Parameters.AddWithValue("@password", TextBoxPwd.Password);

                int count = Convert.ToInt32(Sqlcmd.ExecuteScalar());
                Sqlcmd.ExecuteNonQuery();
                con.Close();

                if (TextBoxPwd.Password == string.Empty)
                {

                    MessageBox.Show("Password is empty!", "ERROR MESSAGE", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                if(TextBoxUname.Text == string.Empty) 
                {
                    MessageBox.Show("Username is empty!", "ERROR MESSAGE", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                
              
                if (count > 0)
                    {

                        SecondWindow secondary = new SecondWindow();
                        secondary.Show();

                }

                }
                
            
            catch (Exception error){ 
            
                MessageBox.Show(error.Message);

            
            }

        }
    }
}
