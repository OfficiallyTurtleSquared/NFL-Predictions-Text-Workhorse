using ClosedXML.Excel;
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

namespace NFL_Predictions_Programmer
{
    public partial class statForm : Form
    {
        public statForm()
        {
            InitializeComponent();
        }

        public float numberparser(string input)
        {
            float output;
            float.TryParse(input, out output);
            return output;
        }

        private void statForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine("STATFORM INIT");
            readButton.PerformClick();
            Console.WriteLine("Stats Faking - Successful");
        }

        #region statsmanagement

        private void percentClearButton_Click_1(object sender, EventArgs e)
        {
            leadBox.Clear();
            followBox.Clear();
            resultBox.Clear();
        }

        private void followBox_TextChanged_1(object sender, EventArgs e)
        {
            if (followBox.TextLength > 0)
            {
                float result = numberparser(leadBox.Text) / numberparser(followBox.Text);
                resultBox.Text = result.ToString();
            }
            else
            {
                //donothing
            }
        }

        private void readButton_Click_1(object sender, EventArgs e)
        {
            var statBookURL = $@"{Directory.GetCurrentDirectory().ToString()}\stats.xlsx";

            if (File.Exists(statBookURL))
            {
                var stats = new XLWorkbook($@"{Directory.GetCurrentDirectory().ToString()}\stats.xlsx");
                var defaultSheet = stats.Worksheets.First();


                float correct1 = numberparser(defaultSheet.Cell("B2").Value.ToString());
                float total1 = numberparser(defaultSheet.Cell("C2").Value.ToString());
                float correct2 = numberparser(defaultSheet.Cell("B3").Value.ToString());
                float total2 = numberparser(defaultSheet.Cell("C3").Value.ToString());

                turtleCorrect.Text = correct1.ToString();
                turtleTotal.Text = total1.ToString();
                turtlePercentage.Text = (correct1 / total1).ToString();

                tomCorrect.Text = correct2.ToString();
                tomTotal.Text = total2.ToString();
                tomPercentage.Text = (correct2 / total2).ToString();
            }
            else
            {
                var newBookHandler = new XLWorkbook();
                newBookHandler.AddWorksheet();
                newBookHandler.SaveAs(statBookURL);
                var stats = new XLWorkbook($@"{Directory.GetCurrentDirectory().ToString()}\stats.xlsx");
                var defaultSheet = stats.Worksheets.First();


                float correct1 = numberparser(defaultSheet.Cell("B2").Value.ToString());
                float total1 = numberparser(defaultSheet.Cell("C2").Value.ToString());
                float correct2 = numberparser(defaultSheet.Cell("B3").Value.ToString());
                float total2 = numberparser(defaultSheet.Cell("C3").Value.ToString());

                turtleCorrect.Text = correct1.ToString();
                turtleTotal.Text = total1.ToString();
                turtlePercentage.Text = (correct1 / total1).ToString();

                tomCorrect.Text = correct2.ToString();
                tomTotal.Text = total2.ToString();
                tomPercentage.Text = (correct2 / total2).ToString();
            }
        }

        private void writeButton_Click_1(object sender, EventArgs e)
        {
            var stats = new XLWorkbook($@"{Directory.GetCurrentDirectory().ToString()}\stats.xlsx");
            var defaultSheet = stats.Worksheets.First();

            float correct1 = numberparser(turtleCorrect.Text);
            float total1 = numberparser(turtleTotal.Text);
            float correct2 = numberparser(tomCorrect.Text);
            float total2 = numberparser(tomTotal.Text);

            defaultSheet.Cell("B2").Value = correct1;
            defaultSheet.Cell("C2").Value = total1;
            defaultSheet.Cell("B3").Value = correct2;
            defaultSheet.Cell("C3").Value = total2;

            stats.SaveAs($@"{Directory.GetCurrentDirectory().ToString()}\stats.xlsx");

            System.Threading.Thread.Sleep(50);

            readButton.PerformClick();
        }

        #endregion
    }
}
