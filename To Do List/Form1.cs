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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace To_Do_List
{
    public partial class Form1: Form
    {
        string FilePath = "Tasks.txt";
        public Form1()
        {
            InitializeComponent();
            Load();
        }

        
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please add task first!", "Warning");
            }
            else if(textBox1.Text!="Add a new task")
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Text = "Add a new task";
                Save();
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="Add a new task")
            {
                textBox1.Text = "";                
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count!=0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                Save();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Save();
        }

        private void Save()
        {
            File.WriteAllLines(FilePath, listBox1.Items.Cast<string>());
        }
        private void Load()
        {
            if (File.Exists(FilePath))
            {
                listBox1.Items.AddRange(File.ReadAllLines(FilePath));
            }
        }
    }
}
