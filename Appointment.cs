/* Developed by Ertan Tike (ertan.tike@moreum.com) */

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Calendar
{
    public class Appointment
    {
        public Appointment()
        {
            color = Color.White;
            m_BorderColor = Color.Blue;
            m_Title = "New Appointment";
            m_JobNo = "";
            m_SubContractor = "";
        }

        private DateTime m_StartDate;

        public DateTime StartDate
        {
            get
            {
                return m_StartDate;
            }
            set
            {
                m_StartDate = value;
                OnStartDateChanged();

            }
        }
        protected virtual void OnStartDateChanged()
        {
        }

        private DateTime m_EndDate;

        public DateTime EndDate
        {
            get
            {
                return m_EndDate;
            }
            set
            {
                m_EndDate = value;
                OnEndDateChanged();
            }
        }

        private string m_SubContractor;
        public string SubContractor
        {
            get  {return m_SubContractor;}
            set { m_SubContractor = value;}
        }
         private string m_PostCode;
        public string PostCode
        {
            get  {return m_PostCode; }
            set { m_PostCode = value;}
        }
        private string m_Priority;
        public string Priority
        {
            get { return m_Priority; }
            set { m_Priority = value; }
        }
        private string m_JobNo;
        public string JobNo
        {
            get { return m_JobNo; }
            set { m_JobNo = value; }
        }

        protected virtual void OnEndDateChanged()
        {
        }

        private bool m_Locked = false;

        [System.ComponentModel.DefaultValue(false)]
        public bool Locked
        {
            get { return m_Locked; }
            set
            {
                m_Locked = value;
                OnLockedChanged();
            }
        }

        protected virtual void OnLockedChanged()
        {
        }

        private Color color = Color.White;

        public Color Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        private Color textColor = Color.White;

        public Color TextColor
        {
            get { return textColor; }
            set { textColor = value; }
        }

        private int m_ID = 0;

        public int ID
        {
            get
            {
                return m_ID;
            }
            set
            {
                m_ID = value;
            }
        }
        private int m_OrderID = 0;
      
        public int OrderID
        {
            get
            {
                return m_OrderID;
            }
            set
            {
                m_OrderID = value;
            }
        }
        private Color m_BorderColor = Color.Blue;

        public Color BorderColor
        {
            get
            {
                return m_BorderColor;
            }
            set
            {
                m_BorderColor = value;
            }
        }

        private string m_Title = "";

        [System.ComponentModel.DefaultValue("")]
        public string Title
        {
            get
            {
                return m_Title;
            }
            set
            {
                m_Title = value;
                OnTitleChanged();
            }
        }
        protected virtual void OnTitleChanged()
        {
        }

        internal int m_ConflictCount;
    }
}
