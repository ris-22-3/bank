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
        private void AutorisationButton_Click(object sender, EventArgs e)
        {
            bool isRight = false;
            string loginUser = LoginField.Text;
            string passUser = PasswordField.Text;
            Database d = new Database();
            clientNumber = Objects.user.clientNumber;
            if (!Database.logins.Contains(loginUser))
            {
                MessageBox.Show("Пользователя с такими данными не существует");
                LoginField.Clear();
                PasswordField.Clear();
            }
            else
            {
                for (int i = 1; i < Database.arr.Count; i++)
                {
                    if (Database.arr[i].cardNumber == loginUser && Database.arr[i].password == passUser)
                    {
                        this.Hide();
                        isRight = true;
                        Objects.user = Database.arr[i];
                        Objects.current = Objects.user.rub;
                        clientNumber = Objects.user.clientNumber;
                        d.Read();
                        new WelcomeForm().ShowDialog();
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
    }
}