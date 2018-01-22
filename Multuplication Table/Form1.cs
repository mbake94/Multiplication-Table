using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Multuplication_Table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuildTable_Click(object sender, EventArgs e)
        {
            int rowStart, colStart, i, j;
            rowStart = int.Parse(txtRowStart.Text);
            colStart = int.Parse(txtLeftStart.Text);
            String stringBuild = "";
            lstTable.Items.Clear();

            for (i = rowStart; i <= (rowStart + 9); i++)
            {
                stringBuild += i.ToString("n0") + "\n";
            }
            lblRowHeading.Text = stringBuild;
            stringBuild = "";
            for (i = colStart; i <= (colStart + 9); i++)
            {
                stringBuild += i.ToString("n0").PadRight(7, ' ');
            }
            lblColumnHeadings.Text = stringBuild;
            stringBuild = "";
            for (j = rowStart; j <= (rowStart + 9); j++)
            {
                stringBuild += i.ToString("").PadRight(9, ' ');
            }

            List<string> list = new List<string>();
            string tempList = "";
            int tempNum = 0;
            for (i = rowStart; i <= rowStart + 9; i++)
            {
                for (j = colStart; j <= colStart + 9; j++)
                {
                    tempNum = i * j;
                    tempList += tempNum + "   \t";

                }
                list.Add(tempList);
                lstTable.Items.Add(list[list.Count - 1]);
                tempList = "";

            }
        }
    }
}
