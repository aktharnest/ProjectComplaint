using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ProjectComplaint.BAL
{
    public class QueryBAL
    {
        DAL.QueryDAL objcom = new DAL.QueryDAL();

        private int _lid;
        private int _pid;
        private string _desc;
        public string replay;
        private int qid;

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
        public int Qid
        {
            get
            {
                return qid;
            }
            set
            {
                qid = value;
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
        public string Replay
        {
            get
            {
                return replay;
            }
            set
            {
                replay=value;
            }
        }
        public int queryInsert()
        {
            return objcom.QueryInsert(this);
        }
        public DataTable viewQuery()
        {
            return objcom.ViewQuery();
        }
        public DataTable viewUserQuery()
        {
            return objcom.ViewUserQuery(this);
        }
        public int giveReplay()
        {
            return objcom.GiveReplay(this);
        }
    }
}
