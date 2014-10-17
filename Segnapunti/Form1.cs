using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Segnapunti
{
    public partial class Form1 : Form
    {

        List<Squadra> home = new List<Squadra>();
        List<Squadra> guest = new List<Squadra>();
        Squadra casa = new Squadra();
        Squadra ospite = new Squadra();
        public Projected project = (Projected)Application.OpenForms["Projected"];
        public int oraset = 1;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            homegrid.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;
            guestgrid.RowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.Transparent;

        }

        private void btn_Click(object sender, EventArgs e)
        {
            

            if (txt_homeatleta.Text != null && txt_homeid.Text != null) {

                if (txt_homeid.Text == "*") { casa.allenatore = true; project.ui_homecoach.Text = txt_homeatleta.Text; }

                else
                {
                    casa.numero = txt_homeid.Text;
                    casa.atleta = txt_homeatleta.Text.ToUpper();
                   
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(this.homegrid, casa.numero, casa.atleta);
                    DataGridViewRow ui_row = new DataGridViewRow();
                    ui_row.CreateCells(project.ui_homegrid, casa.numero, casa.atleta);
                    row.MinimumHeight = 30;
                    ui_row.MinimumHeight = 30;
                    if (casa.atleta.Contains("(L)")) { ui_row.DefaultCellStyle.ForeColor = Color.Yellow; }
                    
                    this.homegrid.Rows.Add(row);
                    project.ui_homegrid.Rows.Add(ui_row);
                    
                }
                txt_homeid.Text = null;
                txt_homeatleta.Text = null;
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_guestatleta.Text != null && txt_guestid.Text != null)
            {

                if (txt_guestid.Text == "*") { ospite.allenatore = true; project.ui_guestcoach.Text = txt_guestatleta.Text; }

                else
                {
                    this.guestgrid.IsAccessible = false;
                    project.ui_guestgrid.IsAccessible = false;
                    ospite.numero = txt_guestid.Text;
                    ospite.atleta = txt_guestatleta.Text.ToUpper();
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewRow ui_row = new DataGridViewRow();
                    row.CreateCells(this.guestgrid, ospite.numero, ospite.atleta); 
                    ui_row.CreateCells(project.ui_guestgrid, ospite.numero, ospite.atleta);
                    row.MinimumHeight = 30;
                    ui_row.MinimumHeight = 30;
                    this.guestgrid.Rows.Add(row);
                    project.ui_guestgrid.Rows.Add(ui_row);

                }
                txt_guestid.Text = null;
                txt_guestatleta.Text = null;
            }
        }

        private void homeaddto_Click(object sender, EventArgs e)
        {
            hometolabel.Text = (Int32.Parse(hometolabel.Text) + 1).ToString();
            project.ui_hometo.Text = hometolabel.Text;
        }

        private void homeremoveto_Click(object sender, EventArgs e)
        {
            hometolabel.Text = (Int32.Parse(hometolabel.Text) - 1).ToString();
            project.ui_hometo.Text = hometolabel.Text;
        }

        private void homeremovec_Click(object sender, EventArgs e)
        {
            homeclabel.Text = (Int32.Parse(homeclabel.Text) - 1).ToString();
            project.ui_homec.Text = homeclabel.Text;
        }

        private void homeaddc_Click(object sender, EventArgs e)
        {
            homeclabel.Text = (Int32.Parse(homeclabel.Text) + 1).ToString();
            project.ui_homec.Text = homeclabel.Text;
        }

        private void homeremovept_Click(object sender, EventArgs e)
        {
            homeptlabel.Text = (Int32.Parse(homeptlabel.Text) - 1).ToString();
            project.ui_homescore.Text = homeptlabel.Text;
        }

        private void homeaddpt_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(homeptlabel.Text) >= 25 && Int32.Parse(homeptlabel.Text) - Int32.Parse(guestptlabel.Text) > 1)  
            {
             
                switch (oraset)
                {
                    case 1:
                        project.set1.Text = homeptlabel.Text + "-" + guestptlabel.Text;
                        break;
                    case 2:
                        project.set2.Text = homeptlabel.Text + "-" + guestptlabel.Text;
                        break;
                    case 3:
                        project.set3.Text = homeptlabel.Text + "-" + guestptlabel.Text;
                        break;
                    case 4:
                        project.set4.Text = homeptlabel.Text + "-" + guestptlabel.Text;
                        break;
                    case 5:
                        break;
                }
                ResetLabels();
                homesetvinti.Text = (Int32.Parse(homesetvinti.Text) + 1).ToString();
                project.ui_homeset.Text = homesetvinti.Text;
                oraset++;
                project.ui_currentset.Text = oraset.ToString();
            }
            else
            {
                homeptlabel.Text = (Int32.Parse(homeptlabel.Text) + 1).ToString();
                project.ui_homescore.Text = homeptlabel.Text;
                guestdot.ForeColor = Color.Black;
                guestdot.BackColor = Color.Black;
                project.ui_guestdot.Visible = false;
                homedot.ForeColor = Color.Yellow;
                homedot.BackColor = Color.Yellow;
                project.ui_homedot.Visible = true;
            }
        }

        private void guestremoveto_Click(object sender, EventArgs e)
        {
            guesttolabel.Text = (Int32.Parse(guesttolabel.Text) - 1).ToString();
            project.ui_guestto.Text = guesttolabel.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            guesttolabel.Text = (Int32.Parse(guesttolabel.Text) + 1).ToString();
            project.ui_guestto.Text = guesttolabel.Text;
        }

        private void guestremovec_Click(object sender, EventArgs e)
        {
            guestclabel.Text = (Int32.Parse(guestclabel.Text) - 1).ToString();
            project.ui_guestc.Text = guestclabel.Text;
        }

        private void guestaddc_Click(object sender, EventArgs e)
        {
            guestclabel.Text = (Int32.Parse(guestclabel.Text) + 1).ToString();
            project.ui_guestc.Text = guestclabel.Text;
        }

        private void guestaddpt_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(guestptlabel.Text) >= 25 && Int32.Parse(guestptlabel.Text) - Int32.Parse(homeptlabel.Text) > 1) //TODO: Reimpostare il punteggio
            {
             
                switch (oraset)
                {
                    case 1:
                        project.set1.Text = homeptlabel.Text + "-" + guestptlabel.Text;
                        break;
                    case 2:
                        project.set2.Text = homeptlabel.Text + "-" + guestptlabel.Text;
                        break;
                    case 3:
                        project.set3.Text = homeptlabel.Text + "-" + guestptlabel.Text;
                        break;
                    case 4:
                        project.set4.Text = homeptlabel.Text + "-" + guestptlabel.Text;
                        break;
                    case 5:
                        break;
                }
                ResetLabels();
                guestsetvinti.Text = (Int32.Parse(guestsetvinti.Text) + 1).ToString();
                project.ui_guestset.Text = guestsetvinti.Text;
                oraset++;
                project.ui_currentset.Text = oraset.ToString();
            }
            else
            {
                guestptlabel.Text = (Int32.Parse(guestptlabel.Text) + 1).ToString();
                project.ui_guestscore.Text = guestptlabel.Text;
                homedot.ForeColor = Color.Black;
                homedot.BackColor = Color.Black;
                project.ui_homedot.Visible = false;
                guestdot.ForeColor = Color.Yellow;
                guestdot.BackColor = Color.Yellow;
                project.ui_guestdot.Visible = true;

            }
        }

        private void guestremovept_Click(object sender, EventArgs e)
        {
            guestptlabel.Text = (Int32.Parse(guestptlabel.Text) - 1).ToString();
            project.ui_guestscore.Text = guestptlabel.Text;
        }

        private void homenamebtn_Click(object sender, EventArgs e)
        {
            project.ui_home.Text = this.homenametxt.Text.ToUpper();
            this.homenametxt.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            project.ui_guest.Text = this.guestnametxt.Text.ToUpper();
            this.guestnametxt.Text = "";
        }

        private void homedot_Click(object sender, EventArgs e)
        {
            guestdot.ForeColor = Color.Black;
            guestdot.BackColor = Color.Black;
            project.ui_guestdot.Visible = false;
            homedot.ForeColor = Color.Yellow;
            homedot.BackColor = Color.Yellow;
            project.ui_homedot.Visible = true;
        }

        private void guestdot_Click(object sender, EventArgs e)
        {
            homedot.ForeColor = Color.Black;
            homedot.BackColor = Color.Black;
            project.ui_homedot.Visible = false;
            guestdot.ForeColor = Color.Yellow;
            guestdot.BackColor = Color.Yellow;
            project.ui_guestdot.Visible = true;
        }

        private void button1_DoubleClick(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://alfonsomarzano.it/");
            Process.Start(sInfo);
        }

        private void homegrid_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void help_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("http://alfonsomarzano.it/segnapunti");
            Process.Start(sInfo);
        }

        private void VolleyScore_notif_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        public void ResetLabels() 
        {
            homeptlabel.Text = "0";
            guestptlabel.Text = "0";
            hometolabel.Text = "0";
            guesttolabel.Text = "0";
            homeclabel.Text = "0";
            guestclabel.Text = "0";
            project.ui_homec.Text = "0";
            project.ui_guestc.Text = "0";
            project.ui_hometo.Text = "0";
            project.ui_guestto.Text = "0";
            project.ui_homescore.Text = "0";
            project.ui_guestscore.Text = "0";
        }

    }
}
