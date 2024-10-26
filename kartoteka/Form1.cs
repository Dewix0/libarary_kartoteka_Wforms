using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Reflection;

namespace kartoteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<book> books = new List<book>();
        string bukva;
        string link;
        private void Form1_Load(object sender, EventArgs e)
        {
            button_back.Hide();
            comboBox1.Hide();
            label3.Hide();
            linkLabel1.Hide(); 
            dataGridView1.Hide();
            SQLiteConnection connection = new SQLiteConnection("Integrated Security = SSPI; Data Source = kartoteka.db");
            connection.Open();
            var command = connection.CreateCommand();
            command.CommandText = @"SELECT  Id, Name, Description, Link, Avaliability FROM Kartoteka";
            using (var rd1 = command.ExecuteReader())
            {
                
                while (rd1.Read())
                {
                    books.Add(new book(rd1.GetInt32(0), rd1.GetString(1), rd1.GetString(2), rd1.GetString(3), rd1.GetString(4)));
                    
                }
            }
            connection.Close();
            
        }
        public void zapolnenie(List<book> check_latter)
        {
            
            for (int i = 0; i < check_latter.ToArray().Length; i++)
            {

                comboBox1.Items.Add(check_latter[i].Name.ToString());
            }
        }
        public void check_tolabel(List<book> check_latter)
        {
            
            
            check_latter.ToArray();
            /*if (comboBox1.Items.Count>check_latter.Count)
            {
                comboBox1.Items.Clear();
            }*/
            for (int i = 0; i < check_latter.ToArray().Length; i++) 
            {
                
                
                if (comboBox1.SelectedIndex == i )
                {
                    
                    linkLabel1.Text = check_latter[i].Name.ToString();
                    linkLabel1.Show();
                    link= check_latter[i].Link.ToString();
                }
                
            }

        }
        public void ButtonHide(string bukva)
        {
            comboBox1.Items.Clear(); //отчистка combobox от старых букв

            button_back.Show();
            
            button_А.Hide(); button_Б.Hide();
                button_В.Hide(); button_Г.Hide();
                button_Д.Hide(); button_Е.Hide();
                button_Ё.Hide(); button_Ж.Hide();
                button_З.Hide(); button_И.Hide();
                button_Й.Hide(); button_К.Hide();
                button_Л.Hide(); button_М.Hide();
                button_Н.Hide(); button_О.Hide();
                button_П.Hide(); button_Р.Hide();
                button_С.Hide(); button_Т.Hide();
                button_У.Hide(); button_Ф.Hide();
                button_Х.Hide(); button_Ц.Hide();
                button_Ч.Hide(); button_Ш.Hide();
                button_Щ.Hide(); button_Э.Hide();
                button_Ю.Hide(); button_Я.Hide();
            
            label2.Hide();
            dataGridView1.Show();

            bukva.ToCharArray();                                                          //Проверка на выбранную букву
            IEnumerable<book> check_latter = books.Where(n => n.Name[0] == bukva[0]);
            this.dataGridView1.DataSource = check_latter.ToArray();

            label3.Show();
            dataGridView1.Show();
            comboBox1.Show();
            
            zapolnenie(check_latter.ToList());

            
        }

        public void ButtonShow()
        {

            button_А.Show(); button_Б.Show();
            button_В.Show(); button_Г.Show();
            button_Д.Show(); button_Е.Show();
            button_Ё.Show(); button_Ж.Show();
            button_З.Show(); button_И.Show();
            button_Й.Show(); button_К.Show();
            button_Л.Show(); button_М.Show();
            button_Н.Show(); button_О.Show();
            button_П.Show(); button_Р.Show();
            button_С.Show(); button_Т.Show();
            button_У.Show(); button_Ф.Show();
            button_Х.Show(); button_Ц.Show();
            button_Ч.Show(); button_Ш.Show();
            button_Щ.Show(); button_Э.Show();
            button_Ю.Show(); button_Я.Show();
            button_back.Hide();
            dataGridView1.Hide();
            label3.Hide();
            comboBox1.Hide();
            linkLabel1.Hide();

        }
        private void button_А_Click(object sender, EventArgs e)
        {
            bukva = "А";
            ButtonHide(bukva);
        }

        private void button_Б_Click(object sender, EventArgs e)
        {
            bukva = "Б";
            ButtonHide(bukva);
        }

        private void button_В_Click(object sender, EventArgs e)
        {
            bukva = "В";
            ButtonHide(bukva);
        }

        private void button_Г_Click(object sender, EventArgs e)
        {
            bukva = "Г";
            ButtonHide(bukva);
        }

        private void button_Д_Click(object sender, EventArgs e)
        {
            bukva = "Д";
            ButtonHide(bukva);
        }

        private void button_Е_Click(object sender, EventArgs e)
        {
            bukva = "Е";
            ButtonHide(bukva);
        }

        private void button_Ё_Click(object sender, EventArgs e)
        {
            bukva = "Ё";
            ButtonHide(bukva);
        }

        private void button_Ж_Click(object sender, EventArgs e)
        {
            bukva = "Ж";
            ButtonHide(bukva);
        }

        private void button_З_Click(object sender, EventArgs e)
        {
            bukva = "З";
            ButtonHide(bukva);
        }

        private void button_И_Click(object sender, EventArgs e)
        {
            bukva = "И";
            ButtonHide(bukva);
        }

        private void button_Й_Click(object sender, EventArgs e)
        {
            bukva = "Й";
            ButtonHide(bukva);
        }

        private void button_К_Click(object sender, EventArgs e)
        {
            bukva = "К";
            ButtonHide(bukva);
        }

        private void button_Л_Click(object sender, EventArgs e)
        {
            bukva = "Л";
            ButtonHide(bukva);
        }

        private void button_М_Click(object sender, EventArgs e)
        {
            bukva = "М";
            ButtonHide(bukva);
        }

        private void button_Н_Click(object sender, EventArgs e)
        {
            bukva = "Н";
            ButtonHide(bukva);
        }

        private void button_О_Click(object sender, EventArgs e)
        {
            bukva = "О";
            ButtonHide(bukva);
        }

        private void button_П_Click(object sender, EventArgs e)
        {
            bukva = "Л";
            ButtonHide(bukva);
        }

        private void button_Р_Click(object sender, EventArgs e)
        {
            bukva = "Р";
            ButtonHide(bukva);
        }

        private void button_С_Click(object sender, EventArgs e)
        {
            bukva = "С";
            ButtonHide(bukva);
        }

        private void button_Т_Click(object sender, EventArgs e)
        {
            bukva = "Т";
            ButtonHide(bukva);
        }

        private void button_У_Click(object sender, EventArgs e)
        {
            bukva = "У";
            ButtonHide(bukva);
        }

        private void button_Ф_Click(object sender, EventArgs e)
        {
            bukva = "Ф";
            ButtonHide(bukva);
        }

        private void button_Х_Click(object sender, EventArgs e)
        {
            bukva = "Х";
            ButtonHide(bukva);
        }

        private void button_Ц_Click(object sender, EventArgs e)
        {
            bukva = "Ц";
            ButtonHide(bukva);
        }

        private void button_Ч_Click(object sender, EventArgs e)
        {
            bukva = "Ч";
            ButtonHide(bukva);
        }

        private void button_Ш_Click(object sender, EventArgs e)
        {
            bukva = "Ш";
            ButtonHide(bukva);
        }

        private void button_Щ_Click(object sender, EventArgs e)
        {
            bukva = "Щ";
            ButtonHide(bukva);
        }

        private void button_Э_Click(object sender, EventArgs e)
        {
            bukva = "Э";
            ButtonHide(bukva);
        }

        private void button_Ю_Click(object sender, EventArgs e)
        {
            bukva = "Ю";
            ButtonHide(bukva);
        }

        private void button_Я_Click(object sender, EventArgs e)
        {
            bukva = "Я";
            ButtonHide(bukva);
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            ButtonShow();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            bukva.ToCharArray();                                                          
            IEnumerable<book> check_latter = books.Where(n => n.Name[0] == bukva[0]);
            check_tolabel(check_latter.ToList());

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start(link);
        }
    }
}
