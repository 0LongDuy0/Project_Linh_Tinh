using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utility;

namespace Entity.Sys.Tai_Khoan
{
    public class E_Sys_Tai_Khoan
    {
        private int m_intAuto_ID;
        private string m_strTen_Nguoi_Dung;
        private string m_strMat_Khau;
        private string m_strEmail;
        private string m_strDia_Chi;
        private string m_strSĐT;
        private string m_strCCCD;
        private string m_strGhi_Chu;
        private bool m_blndeleted;
        private DateTime? m_dtmCreated;
        private string m_strCreated_By;
        private DateTime? m_dtmLast_Updated;
        private string m_strLast_Updated_By;

        public E_Sys_Tai_Khoan()
        {
            ResetData();
        }
      
        public void ResetData()
        {
            m_intAuto_ID = U_Const.INT_VALUE_NULL;
            m_strTen_Nguoi_Dung = U_Const.STR_VALUE_NULL;
            m_strMat_Khau = U_Const.STR_VALUE_NULL;
            m_strEmail = U_Const.STR_VALUE_NULL;
            m_strDia_Chi = U_Const.STR_VALUE_NULL;
            m_strSĐT = U_Const.STR_VALUE_NULL;
            m_strCCCD = U_Const.STR_VALUE_NULL;
            m_strGhi_Chu = U_Const.STR_VALUE_NULL;
            m_blndeleted = U_Const.BL_VALUE_NULL;
            m_dtmCreated = U_Const.DTM_VALUE_NULL;
            m_strCreated_By = U_Const.STR_VALUE_NULL;
            m_dtmLast_Updated = U_Const.DTM_VALUE_NULL;
            m_strLast_Updated_By = U_Const.STR_VALUE_NULL;
        }

        public int Auto_ID
        {
            get
            {
                return m_intAuto_ID;
            }
            set
            {
                m_intAuto_ID = value;
            }
        }

        public string Ten_Nguoi_Dung
        {
            get
            {
                return m_strTen_Nguoi_Dung;
            }
            set
            {
                m_strTen_Nguoi_Dung = value.Trim();
            }
        }

        public string Mat_Khau
        {
            get
            {
                return m_strMat_Khau;
            }
            set
            {
                m_strMat_Khau = value.Trim();
            }
        }

        public string Email
        {
            get
            {
                return m_strEmail;
            }
            set
            {
                m_strEmail = value.Trim();
            }
        }

        public string Dia_Chi
        {
            get
            {
                return m_strDia_Chi;
            }
            set
            {
                m_strDia_Chi = value.Trim();
            }
        }

        public string SĐT
        {
            get
            {
                return m_strSĐT;
            }
            set
            {
                m_strSĐT = value.Trim();
            }
        }

        public string CCCD
        {
            get
            {
                return m_strCCCD;
            }
            set
            {
                m_strCCCD = value.Trim();
            }
        }

        public string Ghi_Chu
        {
            get
            {
                return m_strGhi_Chu;
            }
            set
            {
                m_strGhi_Chu = value.Trim();
            }
        }

        public bool deleted
        {
            get
            {
                return m_blndeleted;
            }
            set
            {
                m_blndeleted = value;
            }
        }

        public DateTime? Created
        {
            get
            {
                return m_dtmCreated;
            }
            set
            {
                m_dtmCreated = value;
            }
        }

        public string Created_By
        {
            get
            {
                return m_strCreated_By;
            }
            set
            {
                m_strCreated_By = value.Trim();
            }
        }

        public DateTime? Last_Updated
        {
            get
            {
                return m_dtmLast_Updated;
            }
            set
            {
                m_dtmLast_Updated = value;
            }
        }

        public string Last_Updated_By
        {
            get
            {
                return m_strLast_Updated_By;
            }
            set
            {
                m_strLast_Updated_By = value.Trim();
            }
        }

    }
}
