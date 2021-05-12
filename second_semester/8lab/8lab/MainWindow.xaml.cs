using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Media.Imaging;

namespace _8lab
{
    public partial class MainWindow : Window
    {
        SqlConnection thisConnection = new SqlConnection(Strings.Connect_DB);

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Undo(object sender, RoutedEventArgs e)
        {
            content.Undo();
        }
        private void Redo(object sender, RoutedEventArgs e)
        {
            content.Redo();
        }
        
        private void Connect(object sender, RoutedEventArgs e)
        {
            thisConnection.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from _STUDENT", thisConnection);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "Students");
            foreach (DataRow row in dataSet.Tables["Students"].Rows)
            {
                img.Source = BitmapFrame.Create(new Uri(row[2].ToString(), UriKind.Relative));
                break;
            }
            MessageBox.Show("Подключение выполнено!");
        }

        private void Disconnect(object sender, RoutedEventArgs e)
        {
            thisConnection.Close();
            MessageBox.Show("Подключение окончено!");
        }

        private void View_db(object sender, RoutedEventArgs e)//изменить!  row2 -- пикча
        {
            using (SqlConnection connection = new SqlConnection(Strings.Connect_DB))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(Strings.View_DB, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Students");
                content.Text = "";
                foreach (DataRow row in dataSet.Tables["Students"].Rows)
                {
                    content.Text += "ID: " + row[0] + "  Age: " + row[1] + "  Name: " + row[3] + "  City: " + row[6] + "\r\n";
                }
            }
        }

        private void Add_db(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Strings.Connect_DB))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();


                SqlCommand command = connection.CreateCommand();
                command.Transaction = transaction;
                try
                {
                    command.CommandText = Strings.Add_toDB();
                    command.ExecuteNonQuery();
                 
                    transaction.Commit();

                    content.Text = "Success! Elements were added\n";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                }
            }
        }

        private void Edit_db(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Strings.Connect_DB))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Strings.Edit_DB, connection);
                command.ExecuteNonQuery();
                content.Text = "Success! DB was edited\n";
            }
        }

        private void Delete_db(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Strings.Connect_DB))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(Strings.Del_fromDB, connection);
                command.ExecuteNonQuery();
                content.Text = "Success! Elements were deleted\n";
            }
        }

        private void Sort_db(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Strings.Connect_DB))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(Strings.Sort_DB, connection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet, "Students");
                content.Text = "Sorting results:\n"; 
                foreach (DataRow row in dataSet.Tables["Students"].Rows)
                {
                    content.Text += "ID: " + row[0] + "  Age: " + row[1] + "  Name: " + row[3] + "  City: " + row[6] + "\r\n";
                }
            }
        }

        private void Transact(object sender, RoutedEventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Strings.Connect_DB))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                SqlCommand command = connection.CreateCommand();
                command.Transaction = transaction;

                try
                {
                    command.CommandText = " insert into товары(name, prise, quantity, foto) select 'груша', 3, 450, BulkColumn FROM Openrowset(Bulk 'E:/учеба/Новая папка/6/лр8/бананы.jpg', Single_Blob) as image";
                    command.ExecuteNonQuery();
                    command.CommandText = " insert into товары(name, prise, quantity, foto) select'арбуз', 6, 250, BulkColumn FROM Openrowset(Bulk 'E:/учеба/Новая папка/6/лр8/конфеты.jpg', Single_Blob) as image";
                    command.ExecuteNonQuery();

                    transaction.Commit();
                    content.Text = content.Text + "Данные добавлены в базу данных\n";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                }
            }

        }

    }
}
