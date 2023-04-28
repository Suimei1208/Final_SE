using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Distributor_DTO
    {
        private string ID, Username, Password, Name, Phone, Email;
        public string _ID
        {
            get { return ID; }
            set { ID = value; }
        }

        public string _Username
        {
            get { return Username; }
            set { Username = value; }
        }
        public string _Password
        {
            get { return Password; }
            set { Password = value; }
        }
        public string _Name
        {
            get { return Name; }
            set
            {
                Name = value;
            }
        }
        public string _Phone
        {
            get { return Phone; }
            set
            {
                Phone = value;
            }
        }
        public string _Email
        {
            get { return Email; }
            set
            {
                Email = value;
            }
        }
        public Distributor_DTO(string ID, string Username, string Password, string Name, string Phone, string Email)
        {
            this._ID = ID;
            this._Username = Username;    
            this._Password = Password;
            this._Name = Name;
            this._Phone = Phone;
            this._Email = Email;
        }
    }
}
