using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oceantecsa.Infrastructure.DTOS.SP
{
    public class Sp_UsersSelectParamsDto
    {
        public Sp_UsersSelectParamsDto()
        { }

        #region Private Variables
        private Int32 _USERID;
        private String _USERNAME;
        private String _PASSWORD;
        private Int32 _STATUSID;
        private Int32 _GROUPID;
        private Nullable<DateTime> _LASTLOGINTIME;
        private Int32 _KADIID;
        private Int32 _UIG_ID;
        private Nullable<Double> _USERPREPAID;
        private Nullable<Double> _USERDISCOUNT;
        private Int32 _EmployeeID;
        private Int32 _BranchID;
        private Boolean _Play;
        private Boolean _NotPlay;
        private String _FullName;
        private Int32 _Lang;
        private Boolean _IsDeleted;
        private Boolean _NotIsDeleted;
        private Int32 _TopX;
        #endregion

        #region Public Properties
        public Int32 USERID
        {
            get
            {
                return _USERID;
            }
            set
            {
                _USERID = value;
            }
        }
        public String USERNAME
        {
            get
            {
                return _USERNAME;
            }
            set
            {
                _USERNAME = value;
            }
        }
        public String PASSWORD
        {
            get
            {
                return _PASSWORD;
            }
            set
            {
                _PASSWORD = value;
            }
        }
        public Int32 STATUSID
        {
            get
            {
                return _STATUSID;
            }
            set
            {
                _STATUSID = value;
            }
        }
        public Int32 GROUPID
        {
            get
            {
                return _GROUPID;
            }
            set
            {
                _GROUPID = value;
            }
        }
        public Nullable<DateTime> LASTLOGINTIME
        {
            get
            {
                return _LASTLOGINTIME;
            }
            set
            {
                _LASTLOGINTIME = value;
            }
        }
        public Int32 KADIID
        {
            get
            {
                return _KADIID;
            }
            set
            {
                _KADIID = value;
            }
        }
        public Int32 UIG_ID
        {
            get
            {
                return _UIG_ID;
            }
            set
            {
                _UIG_ID = value;
            }
        }
        public Nullable<Double> USERPREPAID
        {
            get
            {
                return _USERPREPAID;
            }
            set
            {
                _USERPREPAID = value;
            }
        }
        public Nullable<Double> USERDISCOUNT
        {
            get
            {
                return _USERDISCOUNT;
            }
            set
            {
                _USERDISCOUNT = value;
            }
        }
        public Int32 EmployeeID
        {
            get
            {
                return _EmployeeID;
            }
            set
            {
                _EmployeeID = value;
            }
        }
        public Int32 BranchID
        {
            get
            {
                return _BranchID;
            }
            set
            {
                _BranchID = value;
            }
        }
        public Boolean Play
        {
            get
            {
                return _Play;
            }
            set
            {
                _Play = value;
            }
        }
        public Boolean NotPlay
        {
            get
            {
                return _NotPlay;
            }
            set
            {
                _NotPlay = value;
            }
        }
        public String FullName
        {
            get
            {
                return _FullName;
            }
            set
            {
                _FullName = value;
            }
        }
        public Int32 Lang
        {
            get
            {
                return _Lang;
            }
            set
            {
                _Lang = value;
            }
        }
        public Boolean IsDeleted
        {
            get
            {
                return _IsDeleted;
            }
            set
            {
                _IsDeleted = value;
            }
        }
        public Boolean NotIsDeleted
        {
            get
            {
                return _NotIsDeleted;
            }
            set
            {
                _NotIsDeleted = value;
            }
        }
        public Int32 TopX
        {
            get
            {
                return _TopX;
            }
            set
            {
                _TopX = value;
            }
        }
        #endregion
    }
}
