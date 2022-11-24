using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjectComplaint.BAL
{
    
    public class ComplaintBoxBAL
    {
        DAL.ComplaintBOXDAL objcom = new DAL.ComplaintBOXDAL();

        private int _lid;
        private int _pid;
        private string _desc;
        private int cid;
        private string _from;
        private string _to;


        public int Cid
        {
            get
            {
                return cid;
            }
            set
            {
                cid = value;
            }
        }
        public int Lid
        {
            get
            {
                return _lid;
            }
            set
            {
                _lid = value;
            }
        }
        public int Pid
        {
            get
            {
                return _pid;
            }
            set
            {
                _pid = value;
            }
        }
        public string Desc
        {
            get
            {
                return _desc;
            }
            set
            {
                _desc = value;
            }
        }
        public string From
        {
            get
            {
                return _from;
            }
            set
            {
                _from = value;
            }
        }
        public string To
        {
            get
            {
                return _to;
            }
            set
            {
                _to = value;
            }
        }
        public int compInsert()
        {
            return objcom.CompInsert(this);
        }
        public DataTable viewComplaint()
        {
            return objcom.ViewComplaint();
        }
        //public DataTable viewDateComplaint()
        //{
        //    return objcom.ViewDateComplaint(this);
        //}
        public DataTable viewPending()
        {
            return objcom.ViewPending();
        }
        public DataTable viewCompleted()
        {
            return objcom.ViewCompleted();
        }
        public DataTable viewUserComplaints()
        {
            return objcom.ViewUserComplaints(this);
        }
        public int complaintConfirm()
        {
            return objcom.ComplaintConfirm(this);
        }
        public int complaintComplete()
        {
            return objcom.ComplaintComplete(this);
        }
    }
}