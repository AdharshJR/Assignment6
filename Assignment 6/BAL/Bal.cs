using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace Assignment_6.BAL
{
    public class Bal
    {
        DAL.Dal objdal = new DAL.Dal();



        private int _did;
        private string _desg;
        private int _desgid;
        private string _deptname;


        public int DesgId
        {
            get
            {
                return _desgid;
            }
            set
            {
                _desgid = value;
            }
        }
        public int DepId
        {
            get
            {
                return _did;
            }
            set
            {
                _did = value;
            }
        }
        public string Desgination
        {
            get
            {
                return _desg;
            }
            set
            {
                _desg = value;
            }
        }
        public string Deptname
        {
            get
            {
                return _deptname;
            }
            set
            {
                _deptname = value ;
            }
        }

        public DataTable getdeprt()
        {
            return objdal.Getdeprt(this);
        }

        public int insertDesig()
        {
            return objdal.InsertDesig(this);
        }
        
        public int insertdept()
        {
            return objdal.Insertdept(this);
        }

        public DataTable viewdesign()
        {
            return objdal.desigview(this);
        }
        public int Desigupdate()
        {
            return objdal.desgUpdate(this);
        }
        public int deletedesig()
        {
            return objdal.Deletedesig(this);
        }
    }
}