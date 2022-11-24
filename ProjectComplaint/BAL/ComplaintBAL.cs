using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjectComplaint.BAL
{
    public class ComplaintBAL
    {
        DAL.ComplaintDAL objreg = new DAL.ComplaintDAL();

        private string _name;
        private string _email;
        private string _phone;
        private string _username;
        private string _password;
        private string status;
        private string lid;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }
        public string phone
        {
            get
            {
                return _phone;
            }
            set
            {
                _phone = value;
            }
        }
        public string username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }
        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
        public string Lid
        {
            get
            {
                return lid;
            }
            set
            {
                lid = value;
            }
        }
        public string password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        public int userInsert()
        {
            return objreg.UserInsert(this);
        }
        public DataTable viewUser()
        {
            return objreg.ViewUser();
        }
        public DataTable viewUserDetails()
        {
            return objreg.ViewUserDetails();
        }
        public int User_confirm()
        {
            return objreg.user_confirm(this);
        }
        public DataTable checklogin()
        {
            return objreg.CheckLogin(this);
        }
        
        
    }
}