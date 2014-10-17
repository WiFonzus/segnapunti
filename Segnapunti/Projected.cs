using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segnapunti
{
    public partial class Projected : Form
    {
        public Projected()
        {
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(1024 , 768);

            this.ControlBox = false;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
        }

        private void Projected_Load(object sender, EventArgs e)
        {
            ui_homegrid.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            ui_guestgrid.RowsDefaultCellStyle.SelectionForeColor = Color.Black;
            ui_homegrid.RowHeadersWidth = 4;
            ui_guestgrid.RowHeadersWidth = 4;
        }

        private void ui_guestcoach_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ui_home_Click(object sender, EventArgs e)
        {

        }

        private void ui_guestgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ui_guest_Click(object sender, EventArgs e)
        {

        }
    }
}
