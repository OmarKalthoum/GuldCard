using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GuldKort
{
    public partial class skapaEttKonto : Form
    {

        public skapaEttKonto()
        {
            InitializeComponent();
            txtAnv.ForeColor = SystemColors.GrayText;
            txtAnv.Text = "T.ex: A1234567";

            txtNamn.ForeColor = SystemColors.GrayText;
            txtNamn.Text = "T.ex: Omar Kalthoum";

            txtOrt.ForeColor = SystemColors.GrayText;
            txtOrt.Text = "T.ex: Malmö";
            timer2.Start();

        }

        private void txtAnv_Enter(object sender, EventArgs e)
        {
            if (txtAnv.Text == "T.ex: A1234567")
            {
                txtAnv.Text = "";
                txtAnv.ForeColor = Color.Black;
            }
        }
        private void txtAnv_Leave(object sender, EventArgs e)
        {
            if (txtAnv.Text == "")

            {
                txtAnv.Text = "T.ex: A1234567";
                txtAnv.ForeColor = Color.Gray;

            }

        }

        private void txtNamn_Enter(object sender, EventArgs e)
        {
            if (txtNamn.Text == "T.ex: Omar Kalthoum")
            {
                txtNamn.Text = "";
                txtNamn.ForeColor = Color.Black;
            }
        }

        private void txtNamn_Leave(object sender, EventArgs e)
        {
            if (txtNamn.Text == "")

            {
                txtNamn.Text = "T.ex: Omar Kalthoum";
                txtNamn.ForeColor = Color.Gray;

            }
        }

        private void txtOrt_Enter(object sender, EventArgs e)
        {
            if (txtOrt.Text == "T.ex: Malmö")
            {
                txtOrt.Text = "";
                txtOrt.ForeColor = Color.Black;
            }
        }

        private void txtOrt_Leave(object sender, EventArgs e)
        {
            if (txtOrt.Text == "")

            {
                txtOrt.Text = "T.ex: Malmö";
                txtOrt.ForeColor = Color.Gray;

            }

        }

        private void skapaEttKonto_Load(object sender, EventArgs e)
        {
            this.ActiveControl = skaffaBtn;

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timeNow.Text = DateTime.Now.ToString("hh:mm:ss");
            timer2.Start();

        }

        private void skaffaBtn_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("kundlista.txt", append: true))  // append: true uses if i want to write in the end of the file.txt
            {

                if (txtAnv.Text.Length > 0 && txtAnv.Text != "T.ex: A1234567" && txtOrt.Text.Length > 0 && txtNamn.Text != "T.ex: Omar Kalthoum" && txtOrt.Text.Length > 0 && txtOrt.Text != "T.ex: Malmö")
                {
                    writer.Write(txtAnv.Text);
                    writer.Write("###");
                    writer.Write(txtNamn.Text);
                    writer.Write("###");
                    writer.WriteLine(txtOrt.Text);
                    writer.Close();
                    MessageBox.Show("Välkommen " + txtNamn.Text + "!\n" + "Nu kan du logga in och kolla om du har vunnit eller inte, Lycka till!");
                    this.Close();
                    writer.Close();
                }
                else
                {
                    MessageBox.Show("Någonting gick fel.\n" + "Följ instruktioner sedan försök igen!");
                    txtAnv.ForeColor = SystemColors.GrayText;
                    txtAnv.Text = "T.ex: A1234567";

                    txtNamn.ForeColor = SystemColors.GrayText;
                    txtNamn.Text = "T.ex: Omar Kalthoum";

                    txtOrt.ForeColor = SystemColors.GrayText;
                    txtOrt.Text = "T.ex: Malmö";
                }

            }
        }
    }
}
