using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DB_lab7_8
{
    public partial class Form1 : Form
    {
        string sqlExpression;
        string connectionString;
        int old_label1_width;
        int old_label4_width;
        public Form1()
        {
            InitializeComponent();
        }

        public SqlConnection func()
        {
            connectionString = @"Data Source=DESKTOP-IJLLHI7\MSSQLSERVER1; " +
            "Database=PL1;User ID=" + textBox1.Text + ";Password=" + textBox2.Text;
            SqlConnection conn =
            new SqlConnection(connectionString);
            return conn;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                /*sqlExpression = @"Data Source=DESKTOP-IJLLHI7\MSSQLSERVER1; " +
                "Database=PL1;User ID=" + textBox1.Text + ";Password=" + textBox2.Text;
                SqlConnection conn =
                new SqlConnection(sqlExpression);*/
                SqlConnection conn = func();
                conn.Open();
                if (textBox1.Text.Contains("Student"))
                {
                    comboBox1.Text = "Выберите действие:";
                    textBox1.Hide();
                    textBox2.Hide();
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    button1.Hide();
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    dataGridView1.Show();
                    label4.Text = "Маэстро \"Студент\"";
                    label4_SizeChanged(sender, e);
                    comboBox1.Show();
                    button3.Show();
                    this.Text = "Маэстро \"Студент\"";
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("Посмотреть список текущих задолженностей студента");
                    comboBox1.Items.Add("Посмотреть список книг, взятых студентом за последний месяц");
                    comboBox1.Items.Add("Просмотреть личные данные студента");
                }
                if (textBox1.Text.Contains("Librarian"))
                {
                    comboBox1.Text = "Выберите действие:";
                    textBox1.Hide();
                    textBox2.Hide();
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    button1.Hide();
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    dataGridView1.Show();
                    label4.Text = "Маэстро \"Библиотекарь\"";
                    label4_SizeChanged(sender, e);
                    comboBox1.Show();
                    button3.Show();
                    this.Text = "Маэстро \"Библиотекарь\"";
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("Посмотреть список книг определенного автора"); //+
                    comboBox1.Items.Add("Посмотреть список книг определенной даты издательства"); //+
                    comboBox1.Items.Add("Найти книжного червя"); //+
                    comboBox1.Items.Add("Просмотреть личные данные студента"); //+
                    comboBox1.Items.Add("Посмотреть список книг, имеющихся на руках у определенной группы"); // +
                    comboBox1.Items.Add("Посмотреть список книг, имеющихся на руках у определенного факультета"); // +
                    comboBox1.Items.Add("Посмотреть список текущих задолженностей студента"); //+
                    comboBox1.Items.Add("Посмотреть список книг, взятых студентом за последний месяц"); //+
                    comboBox1.Items.Add("Добавить книгу"); // +
                    comboBox1.Items.Add("Удалить книгу"); // +
                    comboBox1.Items.Add("Изменить издательство книги"); // +
                    comboBox1.Items.Add("Добавить студента"); // +
                    comboBox1.Items.Add("Удалить студента"); // +
                    comboBox1.Items.Add("Изменить группу студента"); // +
                    comboBox1.Items.Add("Добавить связь"); // +
                    comboBox1.Items.Add("Удалить связь"); // +
                    comboBox1.Items.Add("Изменить дату возврата связи"); // +
                    comboBox1.Items.Add("Посмотреть текущие задолженности студентов"); // +
                    comboBox1.Items.Add("Посмотреть книги в наличии"); // +
                    comboBox1.Items.Add("Посмотреть всех студентов"); // +                      
                }

                if (textBox1.Text.Contains("Dekan"))
                {
                    comboBox1.Text = "Выберите действие:";
                    textBox1.Hide();
                    textBox2.Hide();
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    button1.Hide();
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    dataGridView1.Show();
                    label4.Text = "Маэстро \"Декан\"";
                    label4_SizeChanged(sender, e);
                    comboBox1.Show();
                    button3.Show();
                    this.Text = "Маэстро \"Декан\"";
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("Добавить группу"); // +
                    comboBox1.Items.Add("Изменить факультет группы"); // +
                    comboBox1.Items.Add("Удалить группу"); // +
                    comboBox1.Items.Add("Добавить факультет"); // +
                    comboBox1.Items.Add("Изменить декана факультета"); // +
                    comboBox1.Items.Add("Удалить факультет"); // +
                    comboBox1.Items.Add("Посмотреть список книг, имеющихся на руках у определенной группы"); // +
                    comboBox1.Items.Add("Посмотреть список книг, имеющихся на руках у определенного факультета"); // +
                    comboBox1.Items.Add("Посмотреть список текущих задолженностей студента"); //+
                    comboBox1.Items.Add("Посмотреть список книг, взятых студентом за последний месяц"); //+
                    comboBox1.Items.Add("Добавить студента"); // +
                    comboBox1.Items.Add("Удалить студента"); // +
                    comboBox1.Items.Add("Изменить группу студента"); // +
                }
                if (textBox1.Text.Contains("sa"))
                {
                    comboBox1.Text = "Выберите действие:";
                    textBox1.Hide();
                    textBox2.Hide();
                    label1.Hide();
                    label2.Hide();
                    label3.Hide();
                    button1.Hide();
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Clear();
                    dataGridView1.Show();
                    label4.Text = "Маэстро \"Админ\"";
                    label4_SizeChanged(sender, e);
                    comboBox1.Show();
                    button3.Show();
                    this.Text = "Маэстро \"Админ\"";
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("Добавить нового пользователя и присвоить ему роль"); // +
                    comboBox1.Items.Add("Переназначить пользователю роль"); // +
                    comboBox1.Items.Add("Удалить пользователя при условии, что он имеет заданную роль"); // +
                }
                textBox1.Text = "";
                textBox2.Text = "";
                //this.Hide();
                conn.Close();
            }
            catch
            {
                label1.Text = "Неверный логин или пароль!";
                label1_SizeChanged(sender, e);
                textBox2.Text = "";
            }
            finally
            {
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            old_label1_width = label1.Width;
            old_label4_width = label4.Width;
            button2.Hide();
            dataGridView1.Hide();
            comboBox1.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            button3.Hide();

        }

        private void label1_SizeChanged(object sender, EventArgs e)
        {
            label1.Left = label1.Left - (label1.Width - old_label1_width) / 2;
            old_label1_width = label1.Width;
        }

        private void label4_SizeChanged(object sender, EventArgs e)
        {
            label4.Left = label4.Left - (label4.Width - old_label4_width) / 2;
            old_label4_width = label4.Width;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Просмотреть личные данные студента")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("EXEC student_data " + textBox3.Text, connection);
                    try
                    {

                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));
                        dataGridView1.Columns.Add("a", reader.GetName(0));
                        dataGridView1.Columns.Add("b", reader.GetName(1));
                        dataGridView1.Columns.Add("c", reader.GetName(2));
                        dataGridView1.Columns.Add("d", reader.GetName(3));
                        dataGridView1.Columns.Add("f", reader.GetName(4));
                        if(reader.HasRows)
                        {
                            label11.Text = "Личные данные студента";
                            label11.Show();
                        }
                        while (reader.Read()) // построчно считываем данные
                        {
                            dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4));
                        }
                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            if (comboBox1.SelectedItem.ToString() == "Посмотреть список текущих задолженностей студента")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("EXEC books_on_students_hand " + textBox3.Text, connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));
                        dataGridView1.Columns.Add("a", reader.GetName(0));
                        dataGridView1.Columns.Add("b", reader.GetName(1));
                        dataGridView1.Columns.Add("c", reader.GetName(2));
                        if (reader.HasRows)
                        {
                            label11.Text = "Список текущих задолженностей студента";
                            label11.Show();
                        }
                        while (reader.Read()) // построчно считываем данные
                        {
                            dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2));
                        }
                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            if (comboBox1.SelectedItem.ToString() == "Посмотреть список книг, взятых студентом за последний месяц")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("EXEC last_month_student " + textBox3.Text, connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));
                        dataGridView1.Columns.Add("a", reader.GetName(0));
                        dataGridView1.Columns.Add("b", reader.GetName(1));
                        dataGridView1.Columns.Add("c", reader.GetName(2));
                        if (reader.HasRows)
                        {
                            label11.Text = "Список книг, взятых студентом за последний месяц";
                            label11.Show();
                        }

                        while (reader.Read()) // построчно считываем данные
                        {
                            dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2));
                        }
                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Посмотреть список книг определенного автора")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("EXEC search_books_by_author '" + textBox3.Text + "'", connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        
                        Console.WriteLine("{0}", reader.GetName(0));
                        dataGridView1.Columns.Add("a", reader.GetName(0));
                        if (reader.HasRows)
                        {
                            label11.Text = "Список книг определенного автора";
                            label11.Show();
                        }

                        while (reader.Read()) // построчно считываем данные
                        {
                            dataGridView1.Rows.Add(reader.GetValue(0));
                        }
                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Посмотреть список книг определенной даты издательства")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("EXEC search_books_by_date '" + textBox3.Text + "'", connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        Console.WriteLine("{0}", reader.GetName(0));
                        dataGridView1.Columns.Add("a", reader.GetName(0));
                        if (reader.HasRows)
                        {
                            label11.Text = "Список книг определенной даты издательства";
                            label11.Show();
                        }

                        while (reader.Read()) // построчно считываем данные
                        {
                            dataGridView1.Rows.Add(reader.GetValue(0));
                        }
                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Найти книжного червя")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("SELECT dbo.bookwyrm()", connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        Console.WriteLine("{0}", reader.GetName(0));
                        dataGridView1.Columns.Add("a", "Количество книг у книжного червя");
                        if (reader.HasRows)
                        {
                            label11.Text = "Книжный червь";
                            label11.Show();
                        }

                        while (reader.Read()) // построчно считываем данные
                        {
                            dataGridView1.Rows.Add(reader.GetValue(0));
                        }
                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            
            if (comboBox1.SelectedItem.ToString() == "Посмотреть список книг, имеющихся на руках у определенной группы")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("EXEC group_search " + textBox3.Text, connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));
                        dataGridView1.Columns.Add("a", reader.GetName(0));
                        dataGridView1.Columns.Add("b", reader.GetName(1));
                        dataGridView1.Columns.Add("c", reader.GetName(2));
                        dataGridView1.Columns.Add("d", reader.GetName(3));

                        if (reader.HasRows)
                        {
                            label11.Text = "Список книг, имеющихся на руках у определенной группы";
                            label11.Show();
                        }
                        while (reader.Read()) // построчно считываем данные
                        {
                            dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3));
                        }
                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            
            if (comboBox1.SelectedItem.ToString() == "Посмотреть список книг, имеющихся на руках у определенного факультета")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("EXEC faculty_search " + textBox3.Text, connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));
                        dataGridView1.Columns.Add("a", reader.GetName(0));
                        dataGridView1.Columns.Add("b", reader.GetName(1));
                        dataGridView1.Columns.Add("c", reader.GetName(2));
                        dataGridView1.Columns.Add("d", reader.GetName(3));

                        if (reader.HasRows)
                        {
                            label11.Text = "Список книг, имеющихся на руках у определенного факультета";
                            label11.Show();
                        }
                        while (reader.Read()) // построчно считываем данные
                        {
                            dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3));
                        }
                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            
            if (comboBox1.SelectedItem.ToString() == "Посмотреть текущие задолженности студентов")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM view_debtor", connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));
                        dataGridView1.Columns.Add("a", reader.GetName(0));
                        dataGridView1.Columns.Add("b", reader.GetName(1));
                        dataGridView1.Columns.Add("c", reader.GetName(2));
                        dataGridView1.Columns.Add("d", reader.GetName(3));
                        dataGridView1.Columns.Add("f", reader.GetName(4));

                        if (reader.HasRows)
                        {
                            label11.Text = "Текущие задолженности студентов";
                            label11.Show();
                        }
                        while (reader.Read()) // построчно считываем данные
                        {
                            dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4));
                        }
                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            
            if (comboBox1.SelectedItem.ToString() == "Посмотреть книги в наличии")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM view_books", connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));
                        dataGridView1.Columns.Add("a", reader.GetName(0));
                        dataGridView1.Columns.Add("b", reader.GetName(1));
                        dataGridView1.Columns.Add("c", reader.GetName(2));
                        dataGridView1.Columns.Add("d", reader.GetName(3));
                        dataGridView1.Columns.Add("f", reader.GetName(4));

                        if (reader.HasRows)
                        {
                            label11.Text = "Книги в наличии";
                            label11.Show();
                        }
                        while (reader.Read()) // построчно считываем данные
                        {
                            dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4));
                        }
                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            
            if (comboBox1.SelectedItem.ToString() == "Посмотреть всех студентов")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("SELECT * FROM view_students", connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        Console.WriteLine("{0}\t{1}\t{2}", reader.GetName(0), reader.GetName(1), reader.GetName(2));
                        dataGridView1.Columns.Add("a", reader.GetName(0));
                        dataGridView1.Columns.Add("b", reader.GetName(1));
                        dataGridView1.Columns.Add("c", reader.GetName(2));
                        dataGridView1.Columns.Add("d", reader.GetName(3));
                        dataGridView1.Columns.Add("f", reader.GetName(4));

                        if (reader.HasRows)
                        {
                            label11.Text = "Все студенты";
                            label11.Show();
                        }
                        while (reader.Read()) // построчно считываем данные
                        {
                            dataGridView1.Rows.Add(reader.GetValue(0), reader.GetValue(1), reader.GetValue(2), reader.GetValue(3), reader.GetValue(4));
                        }
                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            
            if (comboBox1.SelectedItem.ToString() == "Добавить книгу")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("EXEC add_book '" + textBox3.Text + "', '" + textBox4.Text
                        + "', '" + textBox5.Text + "', '" + textBox6.Text + "'", connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        command.ExecuteNonQuery();

                        dataGridView1.Columns.Add("a", "Уведомление");

                        dataGridView1.Rows.Add("Книга " + textBox3.Text + " успешно добавлена!");

                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Изменить издательство книги")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("EXEC update_book_izdat '" + textBox3.Text + "', '" + textBox4.Text + "'", connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        command.ExecuteNonQuery();

                        dataGridView1.Columns.Add("a", "Уведомление");

                        dataGridView1.Rows.Add("Издательство книги " + textBox3.Text + " успешно изменено на " + textBox4.Text + "!");

                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Удалить книгу")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("EXEC delete_book '" + textBox3.Text + "'", connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        command.ExecuteNonQuery();

                        dataGridView1.Columns.Add("a", "Уведомление");

                        dataGridView1.Rows.Add("Книга " + textBox3.Text + " успешно удалена!");

                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Добавить студента")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("EXEC add_student '" + textBox3.Text + "', '" + textBox4.Text
                        + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "'", connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        command.ExecuteNonQuery();

                        dataGridView1.Columns.Add("a", "Уведомление");

                        dataGridView1.Rows.Add("Студент " + textBox4.Text + " успешно добавлен!");

                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Удалить студента")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("EXEC delete_student '" + textBox3.Text + "'", connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        command.ExecuteNonQuery();

                        dataGridView1.Columns.Add("a", "Уведомление");

                        dataGridView1.Rows.Add("Студент с номером студенческого билета " + textBox3.Text + " успешно удален!");

                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Изменить группу студента")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("EXEC change_student_group '" + textBox3.Text + "', '" + textBox4.Text + "'", connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        command.ExecuteNonQuery();

                        dataGridView1.Columns.Add("a", "Уведомление");

                        dataGridView1.Rows.Add("Группа студента " + textBox3.Text + " успешно изменена на" + textBox4.Text + "!");

                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Добавить связь")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("EXEC add_connection '" + textBox3.Text + "', '" + textBox4.Text + "'", connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        command.ExecuteNonQuery();

                        dataGridView1.Columns.Add("a", "Уведомление");

                        dataGridView1.Rows.Add("Связь между книгой " + textBox3.Text + " и студентом " + textBox4.Text + " успешно добавлена!");

                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Изменить дату возврата связи")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("EXEC change_connection '" + textBox3.Text + "', '" + textBox4.Text + "'", connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        command.ExecuteNonQuery();

                        dataGridView1.Columns.Add("a", "Уведомление");

                        dataGridView1.Rows.Add("Дата связи между книгой " + textBox3.Text + " и студентом " + textBox4.Text + " успешно обновлена!");

                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Удалить связь")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("EXEC delete_connection '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "'", connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        command.ExecuteNonQuery();

                        dataGridView1.Columns.Add("a", "Уведомление");

                        dataGridView1.Rows.Add("Связь между книгой " + textBox3.Text + " и студентом " + textBox4.Text + " успешно удалена!");

                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Добавить группу")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("EXEC add_group '" + textBox3.Text + "', '" + textBox4.Text + "'", connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        command.ExecuteNonQuery();

                        dataGridView1.Columns.Add("a", "Уведомление");

                        dataGridView1.Rows.Add("Группа " + textBox3.Text + " успешно добавлена!");

                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Изменить факультет группы")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("EXEC change_faculty_of_group '" + textBox3.Text + "', '" + textBox4.Text + "'", connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        command.ExecuteNonQuery();

                        dataGridView1.Columns.Add("a", "Уведомление");

                        dataGridView1.Rows.Add("Факультет группы " + textBox3.Text + " успешно изменен на " + textBox4.Text + "!");

                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Удалить группу")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("EXEC delete_group '" + textBox3.Text + "'", connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        command.ExecuteNonQuery();

                        dataGridView1.Columns.Add("a", "Уведомление");

                        dataGridView1.Rows.Add("Группа " + textBox3.Text + " успешно удалена!");

                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Добавить факультет")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("EXEC add_faculty '" + textBox3.Text + "', '" + textBox4.Text + "'", connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        command.ExecuteNonQuery();

                        dataGridView1.Columns.Add("a", "Уведомление");

                        dataGridView1.Rows.Add("Факультет " + textBox3.Text + " успешно добавлен!");

                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Изменить декана факультета")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("EXEC change_faculty_dekan '" + textBox3.Text + "', '" + textBox4.Text + "'", connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        command.ExecuteNonQuery();

                        dataGridView1.Columns.Add("a", "Уведомление");

                        dataGridView1.Rows.Add("Декан факультета " + textBox3.Text + " успешно изменен на " + textBox4.Text + "!");

                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Удалить факультет")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("EXEC delete_faculty '" + textBox3.Text + "'", connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        command.ExecuteNonQuery();

                        dataGridView1.Columns.Add("a", "Уведомление");

                        dataGridView1.Rows.Add("Факультет " + textBox3.Text + " успешно удален!");

                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            
            if (comboBox1.SelectedItem.ToString() == "Добавить нового пользователя и присвоить ему роль")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("EXEC create_and_add_user '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "'", connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        command.ExecuteNonQuery();

                        dataGridView1.Columns.Add("a", "Уведомление");

                        dataGridView1.Rows.Add("В базу данных " + textBox7.Text + " успешно добавлен пользователь " + textBox3.Text + " с логином " + textBox5.Text + ", паролем " + textBox4.Text + " и ролью " + textBox6.Text);

                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Переназначить пользователю роль")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("EXEC change_role '" + textBox3.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "'", connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        command.ExecuteNonQuery();

                        dataGridView1.Columns.Add("a", "Уведомление");

                        dataGridView1.Rows.Add("Роль пользователя " + textBox3.Text + " успешно изменена со " + textBox4.Text + " на " + textBox5.Text + "!");

                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            if (comboBox1.SelectedItem.ToString() == "Удалить пользователя при условии, что он имеет заданную роль")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("EXEC delete_user '" + textBox3.Text + "', '" + textBox4.Text + "'", connection);
                    try
                    {
                        dataGridView1.Rows.Clear();
                        dataGridView1.Columns.Clear();
                        connection.Open();
                        command.ExecuteNonQuery();

                        dataGridView1.Columns.Add("a", "Уведомление");

                        dataGridView1.Rows.Add("Пользователь " + textBox3.Text + " с ролью " + textBox4.Text + " успешно удален!");

                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Посмотреть список книг, взятых студентом за последний месяц")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                label5.Text = "Номер студенческого билета";
                label5.Show();
                label6.Show();
                textBox3.Show();
                button2.Show();
            }
            if (comboBox1.SelectedItem.ToString() == "Посмотреть список текущих задолженностей студента")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                label5.Text = "Номер студенческого билета";
                label5.Show();
                label6.Show();
                textBox3.Show();
                button2.Show();
            }
            if (comboBox1.SelectedItem.ToString() == "Просмотреть личные данные студента")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                label5.Text = "Номер студенческого билета";
                label5.Show();
                label6.Show();
                textBox3.Show();
                button2.Show();
            }
            if (comboBox1.SelectedItem.ToString() == "Посмотреть список книг определенного автора")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                label5.Text = "Автор";
                label5.Show();
                label6.Show();
                textBox3.Show();
                button2.Show();
            }
            if (comboBox1.SelectedItem.ToString() == "Посмотреть список книг определенной даты издательства")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                label5.Text = "Дата издательства";
                label5.Show();
                label6.Show();
                textBox3.Show();
                button2.Show();
            }
            if (comboBox1.SelectedItem.ToString() == "Найти книжного червя")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                button2.Show();
            }
            
            if (comboBox1.SelectedItem.ToString() == "Посмотреть список книг, имеющихся на руках у определенной группы")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                label5.Text = "Название группы";
                label5.Show();
                label6.Show();
                textBox3.Show();
                button2.Show();
            }
            
            if (comboBox1.SelectedItem.ToString() == "Посмотреть список книг, имеющихся на руках у определенного факультета")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                label5.Text = "Название факультета";
                label5.Show();
                label6.Show();
                textBox3.Show();
                button2.Show();
            }
            
            if (comboBox1.SelectedItem.ToString() == "Посмотреть текущие задолженности студентов")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                button2.Show();
            }
            
            if (comboBox1.SelectedItem.ToString() == "Посмотреть книги в наличии")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                button2.Show();
            }
            
            if (comboBox1.SelectedItem.ToString() == "Посмотреть всех студентов")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                button2.Show();
            }
            
            if (comboBox1.SelectedItem.ToString() == "Добавить книгу")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                label5.Text = "Название";
                label7.Text = "Автор";
                label8.Text = "Год издания";
                label9.Text = "Издательство";
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                label10.Show();
                textBox3.Show();
                textBox4.Show();
                textBox5.Show();
                textBox6.Show();
                button2.Show();
            }
            
            if (comboBox1.SelectedItem.ToString() == "Изменить издательство книги")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                label5.Text = "Название";
                label7.Text = "Новое издательство";
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                textBox3.Show();
                textBox4.Show();
                button2.Show();
            }
            if (comboBox1.SelectedItem.ToString() == "Удалить книгу")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                label5.Text = "Название";
                label5.Show();
                label6.Show();
                label8.Show();
                textBox3.Show();
                button2.Show();
            }
            if (comboBox1.SelectedItem.ToString() == "Добавить студента")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                label5.Text = "Номер студенческого билета";
                label7.Text = "ФИО";
                label8.Text = "ID_группы";
                label9.Text = "Адрес";
                label10.Text = "Дата рождения";
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                label10.Show();
                textBox3.Show();
                textBox4.Show();
                textBox5.Show();
                textBox6.Show();
                textBox7.Show();
                button2.Show();
            }
            if (comboBox1.SelectedItem.ToString() == "Удалить студента")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                label5.Text = "Номер студенческого билета";
                label5.Show();
                label6.Show();
                textBox3.Show();
                button2.Show();
            }
            if (comboBox1.SelectedItem.ToString() == "Изменить группу студента")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                label5.Text = "Номер студенческого билета";
                label7.Text = "Группа";
                label5.Show();
                label7.Show();
                label6.Show();
                textBox3.Show();
                textBox4.Show();
                button2.Show();
            }
            if (comboBox1.SelectedItem.ToString() == "Добавить связь")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                label5.Text = "ID_книги";
                label7.Text = "Номер студенческого билета";
                label5.Show();
                label7.Show();
                label6.Show();
                textBox3.Show();
                textBox4.Show();
                button2.Show();
            }
            if (comboBox1.SelectedItem.ToString() == "Изменить дату возврата связи")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                label5.Text = "ID_книги";
                label7.Text = "Номер студенческого билета";
                label5.Show();
                label7.Show();
                label6.Show();
                textBox3.Show();
                textBox4.Show();
                button2.Show();
            }
            if (comboBox1.SelectedItem.ToString() == "Удалить связь")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                label5.Text = "ID_книги";
                label7.Text = "Номер студенческого билета";
                label8.Text = "Дата получения";
                label9.Text = "Дата возврата";
                label5.Show();
                label7.Show();
                label6.Show();
                label8.Show();
                label9.Show();
                textBox3.Show();
                textBox4.Show();
                textBox5.Show();
                textBox6.Show();
                button2.Show();
            }
            if (comboBox1.SelectedItem.ToString() == "Добавить группу")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                label5.Text = "Название группы";
                label7.Text = "ID_факультета";
                label5.Show();
                label7.Show();
                label6.Show();
                textBox3.Show();
                textBox4.Show();
                button2.Show();
            }
            if (comboBox1.SelectedItem.ToString() == "Изменить факультет группы")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                label5.Text = "Название группы";
                label7.Text = "ID_факультета";
                label5.Show();
                label7.Show();
                label6.Show();
                textBox3.Show();
                textBox4.Show();
                button2.Show();
            }
            if (comboBox1.SelectedItem.ToString() == "Удалить группу")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                label5.Text = "Название группы";
                label5.Show();
                label6.Show();
                textBox3.Show();
                button2.Show();
            }
            if (comboBox1.SelectedItem.ToString() == "Добавить факультет")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                label5.Text = "Название факультета";
                label7.Text = "Декан";
                label5.Show();
                label6.Show();
                label7.Show();
                textBox3.Show();
                textBox4.Show();
                button2.Show();
            }
            if (comboBox1.SelectedItem.ToString() == "Изменить декана факультета")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                label5.Text = "Название факультета";
                label7.Text = "Декан";
                label5.Show();
                label6.Show();
                label7.Show();
                textBox3.Show();
                textBox4.Show();
                button2.Show();
            }
            if (comboBox1.SelectedItem.ToString() == "Удалить факультет")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                label5.Text = "Название факультета";
                label5.Show();
                label6.Show();
                textBox3.Show();
                button2.Show();
            }
            
            if (comboBox1.SelectedItem.ToString() == "Добавить нового пользователя и присвоить ему роль")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                label5.Text = "Логин";
                label7.Text = "Пароль";
                label8.Text = "Имя пользователя";
                label9.Text = "Роль";
                label10.Text = "База данных";
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                label9.Show();
                label10.Show();
                textBox3.Show();
                textBox4.Show();
                textBox5.Show();
                textBox6.Show();
                textBox7.Show();
                button2.Show();
            }
            
            if (comboBox1.SelectedItem.ToString() == "Переназначить пользователю роль")
            {
                hideText();
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                label5.Text = "Имя пользователя";
                label7.Text = "Старая роль";
                label8.Text = "Новая роль";
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                textBox3.Show();
                textBox4.Show();
                textBox5.Show();
                button2.Show();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "Введите логин и пароль!";
            hideAll();
            label1.Show();
            label2.Show();
            label3.Show();
            label4.Text = "Маэстро \"Книжный червь\"";
            label4.Show();
            button1.Show();
            textBox1.Show();
            textBox2.Show();
        }

        private void hideAll()
        {
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            button1.Hide();
            button2.Hide();
            button3.Hide();
            textBox1.Hide();
            textBox2.Hide();
            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            dataGridView1.Hide();
            comboBox1.Hide();
        }

        private void hideText()
        {
            label11.Text = "";
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();

            textBox3.Hide();
            textBox4.Hide();
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
        }
    }
}
