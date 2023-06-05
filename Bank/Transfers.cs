using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Transfers : Form
    {
        public Transfers()
        {
            InitializeComponent();
            //Условия первого комбобокса
            if (iWillHaveComboBox.SelectedItem == null)
            {
                iHaveComboBox.Items.Clear();
                iHaveComboBox.Items.AddRange(new string[] { "RUB", "USD", "TNG" });
            }

            //Условия второго комбобокса
            if (iHaveComboBox.SelectedItem == null)
            {
                iWillHaveComboBox.Items.Clear();
                iWillHaveComboBox.Items.AddRange(new string[] { "RUB", "USD", "TNG" });
            }
        }

        private void Transfers_Load(object sender, EventArgs e)
        {
            lblWatermark.Text = "У меня есть";
            lblWatermark.ForeColor = Color.Gray;
            lblWatermark.Location = new Point(textBox1.Left + 3, textBox1.Top + 2);
            lblWatermark.AutoSize = true;
            lblWatermark.Cursor = Cursors.IBeam;
            lblWatermark.BringToFront();
            lblWatermark1.Text = "Я получу";
            lblWatermark1.ForeColor = Color.Gray;
            lblWatermark1.Location = new Point(textBox2.Left + 3, textBox2.Top + 2);
            lblWatermark1.AutoSize = true;
            lblWatermark1.Cursor = Cursors.IBeam;
            lblWatermark1.BringToFront();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                lblWatermark.Visible = false;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                lblWatermark.Visible = true;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                lblWatermark1.Visible = false;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
                lblWatermark1.Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CurrencyAccount().ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new CurrencyAccount().ShowDialog();
            this.Close();
        }
        private void iHaveComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {   
                string value2 = iWillHaveComboBox.SelectedItem as string;
                if (iHaveComboBox.SelectedItem.ToString() == "RUB")
                {
                    iWillHaveComboBox.Items.Clear();
                    iWillHaveComboBox.Items.AddRange(new string[] { "USD", "TNG" });
                    iWillHaveComboBox.SelectedItem = value2;
                }
                if (iHaveComboBox.SelectedItem.ToString() == "USD")
                {
                    iWillHaveComboBox.Items.Clear();
                    iWillHaveComboBox.Items.AddRange(new string[] { "RUB", "TNG" });
                    iWillHaveComboBox.SelectedItem = value2;
                }
                if (iHaveComboBox.SelectedItem.ToString() == "TNG")
                {
                    iWillHaveComboBox.Items.Clear();
                    iWillHaveComboBox.Items.AddRange(new string[] { "RUB", "USD" });
                    iWillHaveComboBox.SelectedItem = value2;
                }
            
        }

        private void iWillHaveComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
                string value1 = iHaveComboBox.SelectedItem as string;
            if (iHaveComboBox.SelectedItem.ToString() != "USD" && iHaveComboBox.SelectedItem.ToString() != "TNG")
            {
                if (iWillHaveComboBox.SelectedItem.ToString() == "RUB")
                {
                iHaveComboBox.Items.Clear();
                iHaveComboBox.Items.AddRange(new string[] { "USD", "TNG" });
                iHaveComboBox.SelectedItem = value1;
                }
            }
            if (iHaveComboBox.SelectedItem.ToString() != "RUB" && iHaveComboBox.SelectedItem.ToString() != "TNG")
            {
                if (iWillHaveComboBox.SelectedItem.ToString() == "USD")
                {
                iHaveComboBox.Items.Clear();
                iHaveComboBox.Items.AddRange(new string[] { "RUB", "TNG" });
                iHaveComboBox.SelectedItem = value1;
                }
            }
            if (iWillHaveComboBox.SelectedItem.ToString() == "TNG")
            {
                if (iHaveComboBox.SelectedItem.ToString() != "RUB" && iHaveComboBox.SelectedItem.ToString() != "USD")
                {
                iHaveComboBox.Items.Clear();
                iHaveComboBox.Items.AddRange(new string[] { "RUB", "USD", });
                iHaveComboBox.SelectedItem = value1;
                }
            }
            
        }
    }
}
