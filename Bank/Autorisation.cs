﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Bank
{
    public partial class Autorisation : Form
    {
        public Autorisation()
        {
            InitializeComponent();

            this.PasswordField.AutoSize = false;
            this.PasswordField.Height = this.LoginField.Height;
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.BackColor = Color.Gray;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.BackColor = SystemColors.Control;
        }
        Point lastPoint;
        private void AutorisationTopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AutorisationTopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void AutorisationDownPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AutorisationDownPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        static Database rn = new Database();
        string[] logins = new string[rn.Length];
        private void AutorisationButton_Click(object sender, EventArgs e)
        {
            bool isRight = false;
            string loginUser = LoginField.Text;
            string passUser = PasswordField.Text;
            for (int j = 1; j < rn.Length; j++)
                logins[j] = rn[j].cardNumber;
            if (!logins.Contains(loginUser))
            {
                MessageBox.Show("Пользователя с такими данными не существует");
                LoginField.Clear();
                PasswordField.Clear();
            }
            else
            {
                for (int i = 1; i < rn.Length; i++)
                {
                    if (rn[i].cardNumber == loginUser && rn[i].password == passUser)
                    {
                        Hide();
                        new Main().ShowDialog();
                        Show();
                        isRight = true;
                        User user = new User(rn[i].cardNumber, rn[i].password, rn[i].name, rn[i].surname, rn[i].lastname, rn[i].balance, rn[i].history);
                    }
                }
                if (!isRight)
                {
                    MessageBox.Show("Вы неправильно ввели пароль");
                    PasswordField.Clear();
                }
            }
        }
    }
}