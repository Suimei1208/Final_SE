namespace DTO
{
    public class Accountants_DTO
    {
        private string accountant_id, accountant_name, username, password;
        public string _accountant_id
        {
            get { return accountant_id; }
            set { accountant_id = value; }
        }

        public string _accountant_name
        {
            get { return accountant_name; }
            set { accountant_name = value; }
        }

        public string _username
        {
            get { return username; }
            set { username = value; }
        }

        public string _password
        {
            get { return password; }
            set { password = value; }
        }
        public Accountants_DTO(string accountant_id, string accountant_name, string username, string password) { 
            this.accountant_id = accountant_id;
            this.accountant_name = accountant_name;
            this.username = username;
            this.password = password;
        }
    }
}