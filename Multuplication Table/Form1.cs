using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
				stringBuild += i.ToString("n0").PadLeft(9, ' ');
			}
			lblRowHeading.Text = stringBuild;  
			stringBuild = "";
			for (i = colStart; i <= (colStart + 9); i++)
			{
				stringBuild += i.ToString("n0") + "\n";
			}
			lblColumnHeadings.Text = stringBuild;
			stringBuild = "";
			for (j = rowStart; j <= (rowStart + 9); j++)
			{
				stringBuild += i.ToString("").PadRight(9, ' ');
			}
		}
	}
}
