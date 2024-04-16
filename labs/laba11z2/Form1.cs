using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba11z2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        struct Marsh
        {
            public string startDestination;
            public string endDestination;
            public int routeNumber;
        }

        private void generateButton_Click_Click(object sender, EventArgs e)
        {

                List<Marsh> marshList = new List<Marsh>();
                Random rnd = new Random();

                for (int i = 0; i < 10; i++)
                {
                    Marsh newMarsh;
                    newMarsh.startDestination = "Начало" + rnd.Next(1, 6).ToString();
                    newMarsh.endDestination = "Конец" + rnd.Next(1, 6).ToString();
                    newMarsh.routeNumber = rnd.Next(100, 1000);
                    marshList.Add(newMarsh);
                }

                using (StreamWriter writer = new StreamWriter("marshData.txt"))
                {
                    foreach (Marsh marsh in marshList)
                    {
                        writer.WriteLine(marsh.startDestination + "," + marsh.endDestination + "," + marsh.routeNumber);
                    }
                }

                MessageBox.Show("Пути созданы и сохранены.");
        }

        private void readButton_Click_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            using (StreamReader reader = new StreamReader("marshData.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    string info = "Начало: " + parts[0] + ", Конец: " + parts[1] + ", Путь: " + parts[2];
                    listBox1.Items.Add(info);
                }
            }
        }

        private void searchButton_Click_Click(object sender, EventArgs e)
        {
            string searchDestination = searchTextBox.Text;
            bool found = false;

            listBox1.Items.Clear();

            using (StreamReader reader = new StreamReader("marshData.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    if (parts[0] == searchDestination || parts[1] == searchDestination)
                    {
                        string info = "Начало: " + parts[0] + ", Конец: " + parts[1] + ", Путь: " + parts[2];
                        listBox1.Items.Add(info);
                        found = true;
                    }
                }
            }

            if (!found)
            {
                MessageBox.Show("Нет начала или конца пути с таким названием.");
            }
        }
    }
}
