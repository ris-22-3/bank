namespace Bank
{
    public partial class Autorisation : Form
    {
        public static int clientNumber;
        public Autorisation()
        {
            InitializeComponent();
            this.PasswordField.AutoSize = false;
            this.PasswordField.Height = this.LoginField.Height;
        }

        Point lastPoint;


        private void AutorisationButton_Click_1(object sender, EventArgs e)
        {
            bool isRight = false;
            string loginUser = LoginField.Text;
            string passUser = PasswordField.Text;
            Database d = new Database();
            if (!Database.logins.Contains(loginUser))
            {
                MessageBox.Show("Пользователя с такими данными не существует");
                LoginField.Clear();
                PasswordField.Clear();
            }
            else
            {
                for (int i = 0; i < Database.arr.Count; i++)
                {
                    if (Database.arr[i].cardNumber == loginUser && Database.arr[i].password == passUser)
                    {
                        this.Hide();
                        isRight = true;
                        Objects.user = Database.arr[i];
                        Objects.current = Objects.user.rub;
                        clientNumber = Objects.user.clientNumber;
                        d.Read();
                        WelcomeForm welcomeForm = new WelcomeForm();
                        welcomeForm.ShowDialog();
                        this.Close();
                    }
                }
                if (!isRight)
                {
                    MessageBox.Show("Вы неправильно ввели пароль");
                    PasswordField.Clear();
                }
            }
        }

        private void AutorisationDownPanel_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void AutorisationDownPanel_MouseDown_1(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void AutorisationTopPanel_MouseDown_1(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void AutorisationTopPanel_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}