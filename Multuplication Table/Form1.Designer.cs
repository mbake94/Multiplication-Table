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
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Top Row Start:";
            // 
            // txtRowStart
            // 
            this.txtRowStart.Location = new System.Drawing.Point(129, 25);
            this.txtRowStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRowStart.Name = "txtRowStart";
            this.txtRowStart.Size = new System.Drawing.Size(81, 22);
            this.txtRowStart.TabIndex = 1;
            // 
            // txtLeftStart
            // 
            this.txtLeftStart.Location = new System.Drawing.Point(368, 25);
            this.txtLeftStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLeftStart.Name = "txtLeftStart";
            this.txtLeftStart.Size = new System.Drawing.Size(81, 22);
            this.txtLeftStart.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Left Row Start:";
            // 
            // btnBuildTable
            // 
            this.btnBuildTable.Location = new System.Drawing.Point(569, 25);
            this.btnBuildTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuildTable.Name = "btnBuildTable";
            this.btnBuildTable.Size = new System.Drawing.Size(200, 53);
            this.btnBuildTable.TabIndex = 4;
            this.btnBuildTable.Text = "Build Table";
            this.btnBuildTable.UseVisualStyleBackColor = true;
            this.btnBuildTable.Click += new System.EventHandler(this.btnBuildTable_Click);
            // 
            // lstTable
            // 
            this.lstTable.FormattingEnabled = true;
            this.lstTable.HorizontalExtent = 1000;
            this.lstTable.HorizontalScrollbar = true;
            this.lstTable.ItemHeight = 16;
            this.lstTable.Location = new System.Drawing.Point(83, 160);
            this.lstTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstTable.Name = "lstTable";
            this.lstTable.Size = new System.Drawing.Size(913, 324);
            this.lstTable.TabIndex = 5;
            // 
            // lblColumnHeadings
            // 
            this.lblColumnHeadings.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnHeadings.Location = new System.Drawing.Point(83, 137);
            this.lblColumnHeadings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColumnHeadings.Name = "lblColumnHeadings";
            this.lblColumnHeadings.Size = new System.Drawing.Size(915, 23);
            this.lblColumnHeadings.TabIndex = 6;
            // 
            // lblRowHeading
            // 
            this.lblRowHeading.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRowHeading.Location = new System.Drawing.Point(1, 160);
            this.lblRowHeading.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRowHeading.Name = "lblRowHeading";
            this.lblRowHeading.Size = new System.Drawing.Size(86, 325);
            this.lblRowHeading.TabIndex = 7;
            this.lblRowHeading.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 666);
            this.Controls.Add(this.lblRowHeading);
            this.Controls.Add(this.lblColumnHeadings);
            this.Controls.Add(this.lstTable);
            this.Controls.Add(this.btnBuildTable);
            this.Controls.Add(this.txtLeftStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRowStart);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
		private System.Windows.Forms.Label lblColumnHeadings;
		private System.Windows.Forms.Label lblRowHeading;
        public System.Windows.Forms.ListBox lstTable;
    }
}

