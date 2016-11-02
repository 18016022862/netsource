using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskRule.Models
{
    public class Act_Record
    {
        private int? _id;
        private int? _uid;
        private int? _actid;
        private DateTime? _sharetime;
        private string _stype;
        private string _code;
        private int? _status;
        public int? ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public int? Uid
        {
            get { return _uid; }
            set { _uid = value; }
        }
        public int? ActID
        {
            get { return _actid; }
            set { _actid = value; }
        }
        public DateTime? ShareTime
        {
            get { return _sharetime; }
            set { _sharetime = value; }
        }
        public string Stype
        {
            get { return _stype; }
            set { _stype = value; }
        }
        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }
        public int? Status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}