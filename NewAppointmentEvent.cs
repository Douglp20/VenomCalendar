/* Developed by Ertan Tike (ertan.tike@moreum.com) */

using System;

namespace Calendar
{
    public class NewAppointmentEventArgs : EventArgs
    {
        public NewAppointmentEventArgs (string title, DateTime start, DateTime end) {
            m_Title = title;
            m_StartDate = start;
            m_EndDate = end;
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
        private string m_Title;

        public string Title
        {
            get
            {
                return m_Title;
            }
        }

        private DateTime m_StartDate;

        public DateTime StartDate
        {
            get
            {
                return m_StartDate;
            }
        }

        private DateTime m_EndDate;

        public DateTime EndDate
        {
            get
            {
                return m_EndDate;
            }
        }
        private string m_SubContractor;
        public string SubContractor
        {
            get
            {
                return m_SubContractor;
            }
        }

        private string m_PostCode;
        public string PostCode
        {
            get
            {
                return m_PostCode;
            }
        }
    }

    public delegate void NewAppointmentEventHandler (object sender, NewAppointmentEventArgs args);
}
