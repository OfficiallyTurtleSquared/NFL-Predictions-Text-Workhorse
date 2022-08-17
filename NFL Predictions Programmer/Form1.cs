using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;


namespace NFL_Predictions_Programmer
{
    public partial class Form1 : Form
    {
        StringBuilder agregator = new StringBuilder();

        public Form1()
        {
            InitializeComponent();
        }

        public float numberparser(string input)
        {
            float output;
            float.TryParse(input, out output);
            return output;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("NFL Serializer INIT");
            resetButton.PerformClick();
            Console.WriteLine("TempRefresh - Successful");
        }

        #region teambuttonclickcommands
        private void ariButton_Click(object sender, EventArgs e)
        {
            ariClicked = true;
            ariButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"ARI @ ");
            }
            else
            {
                agregator.Append($"ARI: \n");
                addButton.PerformClick();
            }

        }

        private void atlButton_Click(object sender, EventArgs e)
        {
            atlClicked = true;
            atlButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"ATL @ ");
            }
            else
            {
                agregator.Append($"ATL: \n");
                addButton.PerformClick();
            }

        }

        private void carButton_Click(object sender, EventArgs e)
        {
            carClicked = true;
            carButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"CAR @ ");
            }
            else
            {
                agregator.Append($"CAR: \n");
                addButton.PerformClick();
            }

        }

        private void chiButton_Click(object sender, EventArgs e)
        {
            chiClicked = true;
            chiButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"CHI @ ");
            }
            else
            {
                agregator.Append($"CHI: \n");
                addButton.PerformClick();
            }

        }

        private void dalButton_Click(object sender, EventArgs e)
        {
            dalClicked = true;
            dalButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"DAL @ ");
            }
            else
            {
                agregator.Append($"DAL: \n");
                addButton.PerformClick();
            }

        }

        private void detButton_Click(object sender, EventArgs e)
        {
            detClicked = true;
            detButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"DET @ ");
            }
            else
            {
                agregator.Append($"DET: \n");
                addButton.PerformClick();
            }

        }

        private void gbButton_Click(object sender, EventArgs e)
        {
            gbpClicked = true;
            gbButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"GB  @ ");
            }
            else
            {
                agregator.Append($" GB: \n");
                addButton.PerformClick();
            }

        }

        private void larButton_Click(object sender, EventArgs e)
        {
            larClicked = true;
            larButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"LAR @ ");
            }
            else
            {
                agregator.Append($"LAR: \n");
                addButton.PerformClick();
            }

        }

        private void minButton_Click(object sender, EventArgs e)
        {
            minClicked = true;
            minButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"MIN @ ");
            }
            else
            {
                agregator.Append($"MIN: \n");
                addButton.PerformClick();
            }

        }

        private void nosButton_Click(object sender, EventArgs e)
        {
            nosClicked = true;
            nosButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"NO  @ ");
            }
            else
            {
                agregator.Append($" NO: \n");
                addButton.PerformClick();
            }

        }

        private void nygButton_Click(object sender, EventArgs e)
        {
            nygClicked = true;
            nygButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"NYG @ ");
            }
            else
            {
                agregator.Append($"NYG: \n");
                addButton.PerformClick();
            }

        }

        private void phlButton_Click(object sender, EventArgs e)
        {
            phlClicked = true;
            phlButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"PHL @ ");
            }
            else
            {
                agregator.Append($"PHL: \n");
                addButton.PerformClick();
            }

        }

        private void sfoButton_Click(object sender, EventArgs e)
        {
            sfoClicked = true;
            sfoButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"SFO @ ");
            }
            else
            {
                agregator.Append($"SFO: \n");
                addButton.PerformClick();
            }

        }

        private void seaButton_Click(object sender, EventArgs e)
        {
            seaClicked = true;
            seaButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"SEA @ ");
            }
            else
            {
                agregator.Append($"SEA: \n");
                addButton.PerformClick();
            }

        }

        private void tbbButton_Click(object sender, EventArgs e)
        {
            tbbClicked = true;
            tbbButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"TB  @ ");
            }
            else
            {
                agregator.Append($" TB: \n");
                addButton.PerformClick();
            }

        }

        private void wftButton_Click(object sender, EventArgs e)
        {
            wftClicked = true;
            wftButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"WFT @ ");
            }
            else
            {
                agregator.Append($"WFT: \n");
                addButton.PerformClick();
            }

        }

        private void balButton_Click(object sender, EventArgs e)
        {
            balClicked = true;
            balButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"BAL @ ");
            }
            else
            {
                agregator.Append($"BAL: \n");
                addButton.PerformClick();
            }

        }

        private void bufButton_Click(object sender, EventArgs e)
        {
            bufClicked = true;
            bufButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"BUF @ ");
            }
            else
            {
                agregator.Append($"BUF: \n");
                addButton.PerformClick();
            }

        }

        private void cinButton_Click(object sender, EventArgs e)
        {
            cinClicked = true;
            cinButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"CIN @ ");
            }
            else
            {
                agregator.Append($"CIN: \n");
                addButton.PerformClick();
            }

        }

        private void cleButton_Click(object sender, EventArgs e)
        {
            cleClicked = true;
            cleButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"CLE @ ");
            }
            else
            {
                agregator.Append($"CLE: \n");
                addButton.PerformClick();
            }

        }

        private void denButton_Click(object sender, EventArgs e)
        {
            denClicked = true;
            denButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"DEN @ ");
            }
            else
            {
                agregator.Append($"DEN: \n");
                addButton.PerformClick();
            }

        }

        private void texButton_Click(object sender, EventArgs e)
        {
            texClicked = true;
            texButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"TEX @ ");
            }
            else
            {
                agregator.Append($"TEX: \n");
                addButton.PerformClick();
            }

        }

        private void indButton_Click(object sender, EventArgs e)
        {
            indClicked = true;
            indButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"IND @ ");
            }
            else
            {
                agregator.Append($"IND: \n");
                addButton.PerformClick();
            }

        }

        private void jaxButton_Click(object sender, EventArgs e)
        {
            jaxClicked = true;
            jaxButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"JAX @ ");
            }
            else
            {
                agregator.Append($"JAX: \n");
                addButton.PerformClick();
            }

        }

        private void kccButton_Click(object sender, EventArgs e)
        {
            kccClicked = true;
            kccButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"KC  @ ");
            }
            else
            {
                agregator.Append($" KC: \n");
                addButton.PerformClick();
            }

        }

        private void lvrButton_Click(object sender, EventArgs e)
        {
            lvrClicked = true;
            lvrButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"LVR @ ");
            }
            else
            {
                agregator.Append($"LVR: \n");
                addButton.PerformClick();
            }

        }

        private void lacButton_Click(object sender, EventArgs e)
        {
            lacClicked = true;
            lacButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"LAC @ ");
            }
            else
            {
                agregator.Append($"LAC: \n");
                addButton.PerformClick();
            }

        }

        private void miaButton_Click(object sender, EventArgs e)
        {
            miaClicked = true;
            miaButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"MIA @ ");
            }
            else
            {
                agregator.Append($"MIA: \n");
                addButton.PerformClick();
            }

        }

        private void nepButton_Click(object sender, EventArgs e)
        {
            nepClicked = true;
            nepButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"NE  @ ");
            }
            else
            {
                agregator.Append($" NE: \n");
                addButton.PerformClick();
            }

        }

        private void nyjButton_Click(object sender, EventArgs e)
        {
            nyjClicked = true;
            nyjButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"NYJ @ ");
            }
            else
            {
                agregator.Append($"NYJ: \n");
                addButton.PerformClick();
            }

        }

        private void pitButton_Click(object sender, EventArgs e)
        {
            pitClicked = true;
            pitButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"PIT @ ");
            }
            else
            {
                agregator.Append($"PIT: \n");
                addButton.PerformClick();
            }

        }

        private void tenButton_Click(object sender, EventArgs e)
        {
            tenClicked = true;
            tenButton.BackColor = Color.FromArgb(114, 137, 218);
            if (agregator.Length == 0)
            {
                agregator.Append($"TEN @ ");
            }
            else
            {
                agregator.Append($"TEN: \n");
                addButton.PerformClick();
            }

        }

        #endregion

        #region managementcontrols
        private void addButton_Click(object sender, EventArgs e)
        {
            textboxHold = "";
            textboxHold = bigListbox.Text;
            bigListbox.AppendText(agregator.ToString());
            resetButton.PerformClick();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            ariClicked = false;
            atlClicked = false;
            carClicked = false;
            chiClicked = false;
            dalClicked = false;
            detClicked = false;
            gbpClicked = false;
            larClicked = false;
            minClicked = false;
            nosClicked = false;
            nygClicked = false;
            phlClicked = false;
            sfoClicked = false;
            seaClicked = false;
            tbbClicked = false;
            wftClicked = false;
            balClicked = false;
            bufClicked = false;
            cinClicked = false;
            cleClicked = false;
            denClicked = false;
            texClicked = false;
            indClicked = false;
            jaxClicked = false;
            kccClicked = false;
            lvrClicked = false;
            lacClicked = false;
            miaClicked = false;
            nepClicked = false;
            nyjClicked = false;
            pitClicked = false;
            tenClicked = false;
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.FromArgb(153, 170, 181);
                }
                else
                {
                    //donothing
                }
            }
            agregator.Clear();
        }

        private void dumpButton_Click(object sender, EventArgs e)
        {
            bigListbox.Clear();
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            try
            {
                bigListbox.Text = textboxHold;
            }
            catch
            {
                MessageBox.Show("either the bool is broke, or the box didnt have previous content.");
            }
        }

        #endregion

        #region teambools
        public bool ariClicked;
        public bool atlClicked;
        public bool carClicked;
        public bool chiClicked;
        public bool dalClicked;
        public bool detClicked;
        public bool gbpClicked;
        public bool larClicked;
        public bool minClicked;
        public bool nosClicked;
        public bool nygClicked;
        public bool phlClicked;
        public bool sfoClicked;
        public bool seaClicked;
        public bool tbbClicked;
        public bool wftClicked;
        public bool balClicked;
        public bool bufClicked;
        public bool cinClicked;
        public bool cleClicked;
        public bool denClicked;
        public bool texClicked;
        public bool indClicked;
        public bool jaxClicked;
        public bool kccClicked;
        public bool lvrClicked;
        public bool lacClicked;
        public bool miaClicked;
        public bool nepClicked;
        public bool nyjClicked;
        public bool pitClicked;
        public bool tenClicked;
        public string textboxHold;
        #endregion

        #region statsmanagement

        private void statButton_Click(object sender, EventArgs e)
        {
            Form stat = new statForm();
            stat.Show();
        }

        #endregion




    }
}
