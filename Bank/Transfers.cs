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
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Bank
{
    public partial class Transfers : Form
    {
        public Transfers()
        {
            InitializeComponent();
            iHaveComboBox.Items.AddRange(new string[] { "RUB", "USD", "TNG" });
            iWillHaveComboBox.Items.AddRange(new string[] { "RUB", "USD", "TNG" });
            if (CurrencyAccount.boxValue == "RUB")
            {
                iHaveComboBox.SelectedItem = CurrencyAccount.boxValue;
            }
            if (CurrencyAccount.boxValue == "USD")
            {
                iHaveComboBox.SelectedItem = CurrencyAccount.boxValue;
            }
            if (CurrencyAccount.boxValue == "TNG")
            {
                iHaveComboBox.SelectedItem = CurrencyAccount.boxValue;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
            textBox2.Text = text1;
        }
        decimal value = 0;
        decimal conver = 0;
        bool isDesimal = false;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string? text = textBox1.Text;
            lblWatermark1.Visible = false;
            if (text == null)
            {
                text = "0";
                value = 0;
            }
            else
            {
                isDesimal = false;
                if (iHaveComboBox.SelectedItem == "RUB")
                {
                    if (iWillHaveComboBox.SelectedItem == "TNG")
                    {
                        conver = 5.55M;
                        if (decimal.TryParse(text, out value))
                        { value *= conver; isDesimal = true; }
                        else
                        {
                            value = 0;
                            text = "0";
                        }
                    }
                    if (iWillHaveComboBox.SelectedItem == "USD")
                    {
                        conver = 0.0123M;
                        if (decimal.TryParse(text, out value))
                        { value *= conver; isDesimal = true; }
                        else
                        {
                            value = 0;
                            text = "0";
                        }
                    }
                }
                if (iHaveComboBox.SelectedItem == "USD")
                {
                    if (iWillHaveComboBox.SelectedItem == "RUB")
                    {
                        conver = 80.80M;
                        if (decimal.TryParse(text, out value))
                        { value *= conver; isDesimal = true; }
                        else
                        {
                            value = 0;
                            text = "0";
                        }
                    }
                    if (iWillHaveComboBox.SelectedItem == "TNG")
                    {
                        conver = 450.49M;
                        if (decimal.TryParse(text, out value))
                        { value *= conver; isDesimal = true; }
                        else
                        {
                            value = 0;
                            text = "0";
                        }
                    }
                }
                if (iHaveComboBox.SelectedItem == "TNG")
                {
                    if (iWillHaveComboBox.SelectedItem == "RUB")
                    {
                        conver = 0.18M;
                        if (decimal.TryParse(text, out value))
                        { value *= conver; isDesimal = true; }
                        else
                        {
                            value = 0;
                            text = "0";
                        }
                    }
                    if (iWillHaveComboBox.SelectedItem == "USD")
                    {
                        conver = 0.0022M;
                        if (decimal.TryParse(text, out value))
                        { value *= conver; isDesimal = true; }
                        else
                        {
                            value = 0;
                            text = "0";
                        }
                    }
                }
            }
            text = Convert.ToString(value);
            textBox2.Text = text;
        }

        private void lblWatermark_Click(object sender, EventArgs e)
        {
            lblWatermark.Visible = false;
        }
        bool isTransferSuccsec = false;
        private void transferButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox2.Text != "0")
                {
                    if (iHaveComboBox.SelectedItem == "RUB")
                    {
                        if (Objects.user.rub.Balance - value > 0)
                        {
                            if (iWillHaveComboBox.SelectedItem == "TNG")
                            {
                                Operation add = new Operation(Convert.ToDecimal(textBox1.Text), false, "rub", "Другое", "Переводы", DateTime.Now);
                                Objects.user.rub.Balance -= Convert.ToDecimal(textBox1.Text);
                                Objects.user.rub.Add(add, true);
                                isTransferSuccsec = true;


                                add = new Operation(value, true, "tenge", "Другое", "Пополнение", DateTime.Now);
                                Objects.user.tenge.Balance += value;
                                Objects.user.tenge.Add(add, true);
                            }
                            if (iWillHaveComboBox.SelectedItem == "USD")
                            {
                                Operation add = new Operation(Convert.ToDecimal(textBox1.Text), false, "rub", "Другое", "Переводы", DateTime.Now);
                                Objects.user.rub.Balance -= Convert.ToDecimal(textBox1.Text);
                                Objects.user.rub.Add(add, true);
                                isTransferSuccsec = true;


                                add = new Operation(value, true, "USD", "Другое", "Пополнение", DateTime.Now);
                                Objects.user.usd.Balance += value;
                                Objects.user.usd.Add(add, true);
                            }
                        }
                        else
                        { MessageBox.Show("Недостаточно средств для выполнения операции", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    if (iHaveComboBox.SelectedItem == "USD")
                    {
                        if (Objects.user.usd.Balance - value > 0)
                        {
                            if (iWillHaveComboBox.SelectedItem == "RUB")
                            {

                                Operation add = new Operation(Convert.ToDecimal(textBox1.Text), false, "USD", "Другое", "Переводы", DateTime.Now);
                                Objects.user.usd.Balance -= Convert.ToDecimal(textBox1.Text);
                                Objects.user.usd.Add(add, true);
                                isTransferSuccsec = true;




                                add = new Operation(value, true, "rub", "Другое", "Пополнение", DateTime.Now);
                                Objects.user.rub.Balance += value;
                                Objects.user.rub.Add(add, true);
                            }
                            if (iWillHaveComboBox.SelectedItem == "TNG")
                            {

                                Operation add = new Operation(Convert.ToDecimal(textBox1.Text), false, "USD", "Другое", "Переводы", DateTime.Now);
                                Objects.user.usd.Balance -= Convert.ToDecimal(textBox1.Text);
                                Objects.user.usd.Add(add, true);
                                isTransferSuccsec = true;



                                add = new Operation(value, true, "tenge", "Другое", "Пополнение", DateTime.Now);
                                Objects.user.tenge.Balance += value;
                                Objects.user.tenge.Add(add, true);
                            }
                        }
                        else
                        { MessageBox.Show("Недостаточно средств для выполнения операции", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    if (iHaveComboBox.SelectedItem == "TNG")
                    {
                        if (Objects.user.tenge.Balance - value > 0)
                        {
                            if (iWillHaveComboBox.SelectedItem == "RUB")
                            {

                                Operation add = new Operation(Convert.ToDecimal(textBox1.Text), false, "tenge", "Другое", "Переводы", DateTime.Now);
                                Objects.user.tenge.Balance -= Convert.ToDecimal(textBox1.Text);
                                Objects.user.tenge.Add(add, true);
                                isTransferSuccsec = true;



                                add = new Operation(value, true, "rub", "Другое", "Пополнение", DateTime.Now);
                                Objects.user.rub.Balance += value;
                                Objects.user.rub.Add(add, true);

                            }
                            if (iWillHaveComboBox.SelectedItem == "USD")
                            {

                                Operation add = new Operation(Convert.ToDecimal(textBox1.Text), false, "tenge", "Другое", "Переводы", DateTime.Now);
                                Objects.user.tenge.Balance -= Convert.ToDecimal(textBox1.Text);
                                Objects.user.tenge.Add(add, true);
                                isTransferSuccsec = true;



                                add = new Operation(value, true, "USD", "Другое", "Пополнение", DateTime.Now);
                                Objects.user.usd.Balance += value;
                                Objects.user.usd.Add(add, true);
                            }
                        }
                        else
                        { MessageBox.Show("Недостаточно средств для выполнения операции", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }
            }
            else
            {
                MessageBox.Show("Данные введены некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (isDesimal != true)
            {
                MessageBox.Show("Данные введены некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (isTransferSuccsec == true)
                { MessageBox.Show("Перевод выполнен успешно", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); }
            }
        }
    }
}
