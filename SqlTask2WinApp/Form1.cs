using SqlTask2WinApp.Classes;
using System.Data.SqlClient;

namespace SqlTask2WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }




        private void ConnectToLibrary()
        {
            string connectionString = "Server=HONOR-MAGICBOOK\\SQLEXPRESS;Database=LibraryUniser;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            string cmdText = @"Select
                              Id ID,
                              BookName BookName,
                              Price Price,
                              InStock InStock
                              from Books";
            SqlCommand cmd = new SqlCommand(cmdText, connection);
            var data = cmd.ExecuteReader();
            List<Books> booksList = new List<Books>();

            while (data.Read())
            {
                Books books = new Books()
                {
                    Id = (int)data["Id"],
                    BookName = data["BookName"].ToString(),
                    Price = (int)data["Price"],
                    InStock = (int)data["InStock"]
                };

                booksList.Add(books);
            }

            dataGridView1.DataSource = booksList;
            connection.Close();

        }

        private void SearchBook()
        {
            string connectionString = "Server=HONOR-MAGICBOOK\\SQLEXPRESS;Database=LibraryUniser;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string seacrhBook = @"SELECT * FROM Books where bookName=@BookName";

            SqlCommand command = new SqlCommand(seacrhBook, connection);


            command.Parameters.AddWithValue("@BookName", txt_BookName.Text);
            int rowAffect = command.ExecuteNonQuery();
            MessageBox.Show($"1 row affected!");

            var dataBook = command.ExecuteReader();
            List<Books> booksList = new List<Books>();

            while (dataBook.Read())
            {
                Books books = new Books()
                {
                    Id = (int)dataBook["Id"],
                    BookName = dataBook["BookName"].ToString(),
                    Price = (int)dataBook["Price"],
                    InStock = (int)dataBook["InStock"]
                };

                booksList.Add(books);
            }

            dataGridView1.DataSource = booksList;
            connection.Close();

        }

        private void DeleteBooks(int id)
        {
            string connectionString = "Server=HONOR-MAGICBOOK\\SQLEXPRESS;Database=LibraryUniser;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string delete = @"DELETE FROM Books where Id=@Id";
            SqlCommand command = new SqlCommand(delete, connection);

            command.Parameters.AddWithValue("@Id", id);

            int rowAffect = command.ExecuteNonQuery();
            MessageBox.Show($"Deleted");

            connection.Close();



        }
        int i = 0;
        private void UpdateBooks()
        {
            string connectionString = "Server=HONOR-MAGICBOOK\\SQLEXPRESS;Database=LibraryUniser;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string update = @"Update Books set bookName=@BookName,Price=@Price,Instock=@Instock where Id=@Id";
            SqlCommand command = new SqlCommand(update, connection);

            command.Parameters.AddWithValue("@BookName", txt_BookName.Text);
            command.Parameters.AddWithValue("@Price", txt_Price.Text);
            command.Parameters.AddWithValue("@InStock", txt_InStock.Text);
            command.Parameters.AddWithValue("Id", dataGridView1.Rows[i].Cells[0].Value);

            int rowAffect = command.ExecuteNonQuery();
            MessageBox.Show($"Updated!");
            connection.Close();
            ConnectToLibrary();


        }
        private void button1_Click(object sender, EventArgs e)
        {

            string connectionString = "Server=HONOR-MAGICBOOK\\SQLEXPRESS;Database=LibraryUniser;Trusted_Connection=True;";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string insertBook = @"INSERT INTO Books
                                 (BookName,Price,InStock)
                                  VALUES (@BookName,@Price,@InStock)";
            SqlCommand command = new SqlCommand(insertBook, connection);




            command.Parameters.AddWithValue("@BookName", txt_BookName.Text);
            command.Parameters.AddWithValue("@Price", txt_Price.Text);
            command.Parameters.AddWithValue("@InStock", txt_InStock.Text);

            int rowAffect = command.ExecuteNonQuery();

            MessageBox.Show($"{rowAffect} row affected!");
            ConnectToLibrary();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            SearchBook();

        }


        private void Delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                DeleteBooks(id);
                ConnectToLibrary();
            }
        }
        private void Update_Click(object sender, EventArgs e)
        {
            UpdateBooks();

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            ConnectToLibrary();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            i = e.RowIndex;
            txt_BookName.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txt_Price.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txt_InStock.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
        }
    }
}
