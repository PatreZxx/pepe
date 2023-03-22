using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knihohlad
{
    public partial class Form1 : Form
    {
        //String stdDetail = "{0,-50}{1,-20}{2,-50}{3,-50}{4,-100}";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db_connect();
            
          

        }
        void db_connect()
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=pleasework;";
            string query = "SELECT * FROM knihy";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);


            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;


            try
            {
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                      
                        listBox1.Items.Add(reader.GetString("id") + " - " + reader.GetString("nazov") + " - " + reader.GetString("autor") + " - " + reader.GetString("kategoria"));
                    }
                }
                else
                {
                    Console.WriteLine("No rows found.");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string[] split = listBox1.SelectedItem.ToString().Split(' ');

                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=pleasework;";
                string query = "SELECT nazov, autor, informacie, obrazky FROM knihy WHERE id = \"" + split[0] + "\"";

                MySqlConnection databaseConnection = new MySqlConnection(connectionString);

                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);


                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;


                try
                {
                    databaseConnection.Open();

                    reader = commandDatabase.ExecuteReader();
                        
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Nazov.Text = reader.GetString("nazov");
                            Autor.Text = reader.GetString("autor");
                            Popis.Text = reader.GetString("informacie");


                           PictureBox1.Load(reader.GetString("obrazky"));
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }

            }
        }
        

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void VyhladavanieButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            string selectedColumn = VyhladavanieComboBox.SelectedItem.ToString();
            string searchText = VyhladavanieInput.Text;

            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=pleasework;";
            string query = "SELECT * FROM knihy WHERE " + selectedColumn + " LIKE '%" + searchText + "%'";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);

            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);

            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseConnection.Open();

                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listBox1.Items.Add(reader.GetString("id") + "\t" + reader.GetString("nazov"));
                    }
                }
                else
                {
                    MessageBox.Show("Žiadne výsledky.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void PridatButton_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=pleasework;";

            using (MySqlConnection databaseConnection = new MySqlConnection(connectionString))
            {
                databaseConnection.Open();

                using (MySqlCommand commandDatabase = databaseConnection.CreateCommand())
                {
                    commandDatabase.CommandText = "INSERT INTO knihy (nazov, autor, kategoria, cena, obrazky, informacie) VALUES (@nazov, @autor, @kategoria, @cena, @obrazky, @informacie)";

                    commandDatabase.Parameters.AddWithValue("@nazov", PridatNazov.Text);
                    commandDatabase.Parameters.AddWithValue("@autor", PridatAutor.Text);
                    commandDatabase.Parameters.AddWithValue("@kategoria", PridatKategoria.Text);
                    commandDatabase.Parameters.AddWithValue("@cena", PridatCena.Text);
                    commandDatabase.Parameters.AddWithValue("@obrazky", PridajURL.Text);
                    commandDatabase.Parameters.AddWithValue("@informacie", richTextBox1.Text);

                    try
                    {
                        commandDatabase.ExecuteNonQuery();
                        MessageBox.Show("Kniha úspešne pridaná do databázy.");

                        // Clear input fields
                        PridatNazov.Text = "";
                        PridatAutor.Text = "";
                        PridatKategoria.Text = "";
                        PridatCena.Text = "";
                        PridajURL.Text = "";
                        richTextBox1.Text = "";

                        // Refresh the list box with updated data
                        listBox1.Items.Clear();
                        db_connect();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Nastala chyba: " + ex.Message);
                    }
                }
            }
        }

        private void buttonOdstranit_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=pleasework;";
                string query = "DELETE FROM knihy WHERE nazov = \"" + Nazov.Text + "\"";
                MySqlConnection databaseConnection = new MySqlConnection(connectionString);
                databaseConnection.Open();
                MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                MySqlDataReader reader;
                reader = commandDatabase.ExecuteReader();
                while (reader.Read())
                {
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            listBox1.Items.Clear();
            db_connect();
        }
    }
}
