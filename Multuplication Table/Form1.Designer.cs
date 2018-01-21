namespace Multuplication_Table
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtRowStart = new System.Windows.Forms.TextBox();
			this.txtLeftStart = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnBuildTable = new System.Windows.Forms.Button();
			this.lstTable = new System.Windows.Forms.ListBox();
			this.lblColumnHeadings = new System.Windows.Forms.Label();
			this.lblRowHeading = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Top Row Start:";
			// 
			// txtRowStart
			// 
			this.txtRowStart.Location = new System.Drawing.Point(97, 20);
			this.txtRowStart.Name = "txtRowStart";
			this.txtRowStart.Size = new System.Drawing.Size(62, 20);
			this.txtRowStart.TabIndex = 1;
			// 
			// txtLeftStart
			// 
			this.txtLeftStart.Location = new System.Drawing.Point(276, 20);
			this.txtLeftStart.Name = "txtLeftStart";
			this.txtLeftStart.Size = new System.Drawing.Size(62, 20);
			this.txtLeftStart.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(191, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Left Row Start:";
			// 
			// btnBuildTable
			// 
			this.btnBuildTable.Location = new System.Drawing.Point(427, 20);
			this.btnBuildTable.Name = "btnBuildTable";
			this.btnBuildTable.Size = new System.Drawing.Size(150, 43);
			this.btnBuildTable.TabIndex = 4;
			this.btnBuildTable.Text = "Build Table";
			this.btnBuildTable.UseVisualStyleBackColor = true;
			this.btnBuildTable.Click += new System.EventHandler(this.btnBuildTable_Click);
			// 
			// lstTable
			// 
			this.lstTable.FormattingEnabled = true;
			this.lstTable.Location = new System.Drawing.Point(62, 130);
			this.lstTable.Name = "lstTable";
			this.lstTable.Size = new System.Drawing.Size(686, 264);
			this.lstTable.TabIndex = 5;
			// 
			// lblColumnHeadings
			// 
			this.lblColumnHeadings.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblColumnHeadings.Location = new System.Drawing.Point(62, 111);
			this.lblColumnHeadings.Name = "lblColumnHeadings";
			this.lblColumnHeadings.Size = new System.Drawing.Size(686, 19);
			this.lblColumnHeadings.TabIndex = 6;
			// 
			// lblRowHeading
			// 
			this.lblRowHeading.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblRowHeading.Location = new System.Drawing.Point(48, 130);
			this.lblRowHeading.Name = "lblRowHeading";
			this.lblRowHeading.Size = new System.Drawing.Size(17, 264);
			this.lblRowHeading.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(760, 541);
			this.Controls.Add(this.lblRowHeading);
			this.Controls.Add(this.lblColumnHeadings);
			this.Controls.Add(this.lstTable);
			this.Controls.Add(this.btnBuildTable);
			this.Controls.Add(this.txtLeftStart);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtRowStart);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtRowStart;
		private System.Windows.Forms.TextBox txtLeftStart;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBuildTable;
		private System.Windows.Forms.ListBox lstTable;
		private System.Windows.Forms.Label lblColumnHeadings;
		private System.Windows.Forms.Label lblRowHeading;
	}
}

