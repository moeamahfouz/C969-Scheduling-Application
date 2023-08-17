using System;
using System.Globalization;
using MySql.Data.MySqlClient;


namespace C969_Scheduling_Application
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            UserRegion(CultureInfo.CurrentUICulture.LCID); //Uses UserRegion method to check region of user on application start
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        public string LoginError = "The username or password you entered is incorrect, please try again";

        private void UserRegion(int LCID) //If LCID matches 1040 (Italy), translates all text to Italian 
        {
            if (LCID == 1040)
            {
                this.Text = "Agenda appuntamenti";
                LoginLabel.Text = "Registrazione";
                UserLabel.Text = "Nome utente";
                PassLabel.Text = "Parola d'ordine";
                LoginButton.Text = "Accedere";
                LoginCancel.Text = "Annulla";
                LoginError = "Il nome utente o la password inseriti non sono corretti, riprova";
            }
        }

        public static int VerifyLogin(string username, string password) //Verifies that the user login information matches that in the database.
        {
            MySqlConnection s = new MySqlConnection(AppDatabase.dbConnection);
            s.Open();
            MySqlCommand command =
                new MySqlCommand($"SELECT userId FROM user WHERE userName = '{username}' AND password = '{password}'",
                    s);
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                AppDatabase.SetUserID(Convert.ToInt32(reader[0]));
                AppDatabase.SetUserName(username);
                reader.Close();
                s.Close();

                return AppDatabase.GetUserID();
            }

            return 0;
        }

        private void LoginButton_Click(object sender, EventArgs e) //Opens Homepage upon successful login and generates a log with user information
        {
            if (VerifyLogin(UserBox.Text, PassBox.Text) != 0)
            {
                this.Hide();
                HomeForm homeForm = new HomeForm();
                homeForm.loginForm = this;
                ActivityLog.TrackUserLogin(AppDatabase.GetUserID());
                homeForm.Show();
            }
            else
            {
                MessageBox.Show(LoginError, "Error");
                PassBox.Text = "";
            }
        }

        private void LoginCancel_Click(object sender, EventArgs e)
        {
            Close();
        }



 

    }
}