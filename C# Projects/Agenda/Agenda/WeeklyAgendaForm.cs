using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class WeeklyAgendaForm : Form
    {
        public WeeklyAgendaForm()
        {
            InitializeComponent();
            // TODO: Populate cbDay, cbStartDay and cbEndDay
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            // TODO: Add an appointment to the backing collection and display it in the list.
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // TODO: Search for appointments dependent on cbStartDay and cbEndDay.
        }
    }
}
