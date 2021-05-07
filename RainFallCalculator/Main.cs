using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Custom
using System.IO;

namespace RainFallCalculator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void Browse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Select a file to be read.";

            openFileDialog1.Filter = "Valid document types (*.txt)| *.txt;";

            openFileDialog1.FilterIndex = 1;

            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (openFileDialog1.CheckFileExists)
                    {
                        labelPath.Text = Path.GetFullPath(openFileDialog1.FileName);
                    }
                }
                else
                {
                    MessageBox.Show("Open a valid document.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (labelPath.Text == null)
                {
                    MessageBox.Show("Open a valid document.");
                }
                else
                {
                    //readingFile1(fileName);
                    readingFile2();

                    // Positive Numbers
                    int countGoodNumbers = GoodNumbers.Any() ? GoodNumbers.Count() : 0;
                    textBoxGood.Text = countGoodNumbers.ToString();

                    // Negative Numbers
                    int countBadNumbers = BadNumbers.Any() ? BadNumbers.Count() : 0 ;
                    textBoxBad.Text = countBadNumbers.ToString();

                    // Count and display the rows
                    textBoxTotalRows.Text = (countGoodNumbers + countBadNumbers).ToString();

                    // the min and max values found
                    decimal minValue = GoodNumbers.Any() ? GoodNumbers.Min() : 0;
                    textBoxMin.Text = minValue.ToString();

                    decimal maxValue = GoodNumbers.Any() ? GoodNumbers.Max() : 0;
                    textBoxMax.Text = maxValue.ToString();

                    // and the average values
                    decimal averageValue = GoodNumbers.Average();
                    textBoxAverage.Text = averageValue.ToString();

                    // create a second file names rainfall2.txt and will only have the values selected for processing
                    writeResults();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(String.Format("Error: {0}", ex.Message));
            }
        }
        public void writeResults()
        {
            string dirPath = Path.GetDirectoryName(labelPath.Text);
            string fullPath = dirPath + "/rainfall2.txt";

            File.WriteAllLines(fullPath, GoodNumbers.Select(x => string.Join("\n", x)));
        }

        private List<decimal> _goodNumbers = new List<decimal>();
        public List<decimal> GoodNumbers { get => this._goodNumbers; set { this._goodNumbers = value; }  }

        private List<decimal> _badNumbers = new List<decimal>();
        public List<decimal> BadNumbers { get =>  this._badNumbers; set { this._badNumbers = value; }  }
        
        public void readingFile2()
        {
            List<decimal> goodDecimals = new List<decimal>();
            List<decimal> badDecimals = new List<decimal>();

            // Read the file path
            string fileName = Path.GetFullPath(labelPath.Text);

            // read all the lines
            string[] lines = File.ReadAllLines(fileName, Encoding.UTF8);

            foreach (string line in lines)
            {
                // the last value will be 99999 (sentinel value) or until the end of the file
                if (line == "99999")
                {
                    break;
                }
                else
                {
                    decimal.TryParse(line, out decimal cvLine);

                    if (cvLine >= 0) // Is this a positive number?
                    {
                        this._goodNumbers.Add(cvLine);
                    }
                    else // the line is negative
                    {
                        this._badNumbers.Add(cvLine);
                    }
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
