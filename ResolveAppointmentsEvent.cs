/* Developed by Ertan Tike (ertan.tike@moreum.com) */

using System;
using System.Collections.Generic;

namespace Calendar
{
    public class ResolveAppointmentsEventArgs : EventArgs
    {
        public ResolveAppointmentsEventArgs (DateTime start, DateTime end) {
            m_StartDate = start;
            m_EndDate = end;
            m_Appointments = new List<Appointment>();
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
            }
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
            }
        }

        private List<Appointment> m_Appointments;

        public List<Appointment> Appointments
        {
            get
            {
                return m_Appointments;
            }
            set
            {
                m_Appointments = value;
            }
        }
    }

    public delegate void ResolveAppointmentsEventHandler (object sender, ResolveAppointmentsEventArgs args);
}
