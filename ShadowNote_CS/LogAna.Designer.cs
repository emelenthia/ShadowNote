namespace ShadowNote_CS
{
	partial class LogAna
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.dataGridView_Main = new System.Windows.Forms.DataGridView();
			this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_VS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_FirstWin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_FirstLose = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_FirstPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_SecondWin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_SecondLose = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_SecondPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_AllWin = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_AllLose = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_AllPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.comboBox_Mydec = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox_Enedec = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox_Eneclass = new System.Windows.Forms.ComboBox();
			this.checkBox_Mydec = new System.Windows.Forms.CheckBox();
			this.checkBox_Enedec = new System.Windows.Forms.CheckBox();
			this.checkBox_Eneclass = new System.Windows.Forms.CheckBox();
			this.button_Ana = new System.Windows.Forms.Button();
			this.tabControl_Main = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.dataGridView_Rank = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Main)).BeginInit();
			this.tabControl_Main.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rank)).BeginInit();
			this.SuspendLayout();
			// 
			// chart1
			// 
			chartArea3.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea3);
			legend3.Name = "Legend1";
			this.chart1.Legends.Add(legend3);
			this.chart1.Location = new System.Drawing.Point(995, 32);
			this.chart1.Name = "chart1";
			series3.ChartArea = "ChartArea1";
			series3.Legend = "Legend1";
			series3.Name = "Series1";
			this.chart1.Series.Add(series3);
			this.chart1.Size = new System.Drawing.Size(260, 238);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// dataGridView_Main
			// 
			this.dataGridView_Main.AllowUserToAddRows = false;
			this.dataGridView_Main.AllowUserToDeleteRows = false;
			this.dataGridView_Main.AllowUserToResizeColumns = false;
			this.dataGridView_Main.AllowUserToResizeRows = false;
			this.dataGridView_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Main.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ID,
            this.Column_VS,
            this.Column_FirstWin,
            this.Column_FirstLose,
            this.Column_FirstPer,
            this.Column_SecondWin,
            this.Column_SecondLose,
            this.Column_SecondPer,
            this.Column_AllWin,
            this.Column_AllLose,
            this.Column_AllPer});
			this.dataGridView_Main.Location = new System.Drawing.Point(0, 0);
			this.dataGridView_Main.Name = "dataGridView_Main";
			this.dataGridView_Main.RowHeadersVisible = false;
			this.dataGridView_Main.RowTemplate.Height = 21;
			this.dataGridView_Main.Size = new System.Drawing.Size(811, 190);
			this.dataGridView_Main.TabIndex = 1;
			// 
			// Column_ID
			// 
			this.Column_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column_ID.HeaderText = "ID";
			this.Column_ID.Name = "Column_ID";
			this.Column_ID.ReadOnly = true;
			this.Column_ID.Width = 41;
			// 
			// Column_VS
			// 
			this.Column_VS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column_VS.HeaderText = "VS";
			this.Column_VS.Name = "Column_VS";
			this.Column_VS.ReadOnly = true;
			this.Column_VS.Width = 45;
			// 
			// Column_FirstWin
			// 
			this.Column_FirstWin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column_FirstWin.HeaderText = "先攻勝数";
			this.Column_FirstWin.Name = "Column_FirstWin";
			this.Column_FirstWin.ReadOnly = true;
			this.Column_FirstWin.Width = 78;
			// 
			// Column_FirstLose
			// 
			this.Column_FirstLose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column_FirstLose.HeaderText = "先攻敗数";
			this.Column_FirstLose.Name = "Column_FirstLose";
			this.Column_FirstLose.ReadOnly = true;
			this.Column_FirstLose.Width = 78;
			// 
			// Column_FirstPer
			// 
			this.Column_FirstPer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column_FirstPer.HeaderText = "先攻勝率(%)";
			this.Column_FirstPer.Name = "Column_FirstPer";
			this.Column_FirstPer.ReadOnly = true;
			this.Column_FirstPer.Width = 92;
			// 
			// Column_SecondWin
			// 
			this.Column_SecondWin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column_SecondWin.HeaderText = "後攻勝数";
			this.Column_SecondWin.Name = "Column_SecondWin";
			this.Column_SecondWin.ReadOnly = true;
			this.Column_SecondWin.Width = 78;
			// 
			// Column_SecondLose
			// 
			this.Column_SecondLose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column_SecondLose.HeaderText = "後攻敗数";
			this.Column_SecondLose.Name = "Column_SecondLose";
			this.Column_SecondLose.ReadOnly = true;
			this.Column_SecondLose.Width = 78;
			// 
			// Column_SecondPer
			// 
			this.Column_SecondPer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column_SecondPer.HeaderText = "後攻勝率(%)";
			this.Column_SecondPer.Name = "Column_SecondPer";
			this.Column_SecondPer.ReadOnly = true;
			this.Column_SecondPer.Width = 92;
			// 
			// Column_AllWin
			// 
			this.Column_AllWin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column_AllWin.HeaderText = "勝数計";
			this.Column_AllWin.Name = "Column_AllWin";
			this.Column_AllWin.ReadOnly = true;
			this.Column_AllWin.Width = 66;
			// 
			// Column_AllLose
			// 
			this.Column_AllLose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column_AllLose.HeaderText = "敗数計";
			this.Column_AllLose.Name = "Column_AllLose";
			this.Column_AllLose.ReadOnly = true;
			this.Column_AllLose.Width = 66;
			// 
			// Column_AllPer
			// 
			this.Column_AllPer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.Column_AllPer.HeaderText = "勝率(%)";
			this.Column_AllPer.Name = "Column_AllPer";
			this.Column_AllPer.ReadOnly = true;
			this.Column_AllPer.Width = 68;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1013, 357);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "text/table";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// comboBox_Mydec
			// 
			this.comboBox_Mydec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Mydec.FormattingEnabled = true;
			this.comboBox_Mydec.Location = new System.Drawing.Point(31, 193);
			this.comboBox_Mydec.Name = "comboBox_Mydec";
			this.comboBox_Mydec.Size = new System.Drawing.Size(121, 20);
			this.comboBox_Mydec.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 175);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 12);
			this.label1.TabIndex = 4;
			this.label1.Text = "自デッキ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(32, 289);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 12);
			this.label2.TabIndex = 6;
			this.label2.Text = "相手デッキ";
			// 
			// comboBox_Enedec
			// 
			this.comboBox_Enedec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Enedec.FormattingEnabled = true;
			this.comboBox_Enedec.Location = new System.Drawing.Point(31, 307);
			this.comboBox_Enedec.Name = "comboBox_Enedec";
			this.comboBox_Enedec.Size = new System.Drawing.Size(121, 20);
			this.comboBox_Enedec.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(32, 232);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(54, 12);
			this.label3.TabIndex = 8;
			this.label3.Text = "相手クラス";
			// 
			// comboBox_Eneclass
			// 
			this.comboBox_Eneclass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Eneclass.FormattingEnabled = true;
			this.comboBox_Eneclass.Location = new System.Drawing.Point(31, 250);
			this.comboBox_Eneclass.Name = "comboBox_Eneclass";
			this.comboBox_Eneclass.Size = new System.Drawing.Size(121, 20);
			this.comboBox_Eneclass.TabIndex = 7;
			this.comboBox_Eneclass.SelectedIndexChanged += new System.EventHandler(this.comboBox_Eneclass_SelectedIndexChanged);
			// 
			// checkBox_Mydec
			// 
			this.checkBox_Mydec.AutoSize = true;
			this.checkBox_Mydec.Location = new System.Drawing.Point(10, 196);
			this.checkBox_Mydec.Name = "checkBox_Mydec";
			this.checkBox_Mydec.Size = new System.Drawing.Size(15, 14);
			this.checkBox_Mydec.TabIndex = 9;
			this.checkBox_Mydec.UseVisualStyleBackColor = true;
			// 
			// checkBox_Enedec
			// 
			this.checkBox_Enedec.AutoSize = true;
			this.checkBox_Enedec.Location = new System.Drawing.Point(10, 310);
			this.checkBox_Enedec.Name = "checkBox_Enedec";
			this.checkBox_Enedec.Size = new System.Drawing.Size(15, 14);
			this.checkBox_Enedec.TabIndex = 10;
			this.checkBox_Enedec.UseVisualStyleBackColor = true;
			// 
			// checkBox_Eneclass
			// 
			this.checkBox_Eneclass.AutoSize = true;
			this.checkBox_Eneclass.Location = new System.Drawing.Point(10, 250);
			this.checkBox_Eneclass.Name = "checkBox_Eneclass";
			this.checkBox_Eneclass.Size = new System.Drawing.Size(15, 14);
			this.checkBox_Eneclass.TabIndex = 11;
			this.checkBox_Eneclass.UseVisualStyleBackColor = true;
			// 
			// button_Ana
			// 
			this.button_Ana.Location = new System.Drawing.Point(34, 448);
			this.button_Ana.Name = "button_Ana";
			this.button_Ana.Size = new System.Drawing.Size(75, 23);
			this.button_Ana.TabIndex = 12;
			this.button_Ana.Text = "表示";
			this.button_Ana.UseVisualStyleBackColor = true;
			this.button_Ana.Click += new System.EventHandler(this.button_Ana_Click);
			// 
			// tabControl_Main
			// 
			this.tabControl_Main.Controls.Add(this.tabPage1);
			this.tabControl_Main.Controls.Add(this.tabPage2);
			this.tabControl_Main.Controls.Add(this.tabPage3);
			this.tabControl_Main.Location = new System.Drawing.Point(158, 32);
			this.tabControl_Main.Name = "tabControl_Main";
			this.tabControl_Main.SelectedIndex = 0;
			this.tabControl_Main.Size = new System.Drawing.Size(822, 212);
			this.tabControl_Main.TabIndex = 13;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dataGridView_Main);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(814, 186);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Class";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dataGridView_Rank);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(814, 186);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Rank";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tabPage3
			// 
			this.tabPage3.Location = new System.Drawing.Point(4, 22);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(814, 186);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Deck";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// dataGridView_Rank
			// 
			this.dataGridView_Rank.AllowUserToAddRows = false;
			this.dataGridView_Rank.AllowUserToDeleteRows = false;
			this.dataGridView_Rank.AllowUserToResizeColumns = false;
			this.dataGridView_Rank.AllowUserToResizeRows = false;
			this.dataGridView_Rank.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_Rank.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11});
			this.dataGridView_Rank.Location = new System.Drawing.Point(0, 0);
			this.dataGridView_Rank.Name = "dataGridView_Rank";
			this.dataGridView_Rank.RowHeadersVisible = false;
			this.dataGridView_Rank.RowTemplate.Height = 21;
			this.dataGridView_Rank.Size = new System.Drawing.Size(811, 190);
			this.dataGridView_Rank.TabIndex = 14;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 41;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn2.HeaderText = "VS";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Width = 45;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn3.HeaderText = "先攻勝数";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Width = 78;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn4.HeaderText = "先攻敗数";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Width = 78;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn5.HeaderText = "先攻勝率(%)";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Width = 92;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn6.HeaderText = "後攻勝数";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			this.dataGridViewTextBoxColumn6.Width = 78;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn7.HeaderText = "後攻敗数";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			this.dataGridViewTextBoxColumn7.Width = 78;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn8.HeaderText = "後攻勝率(%)";
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.ReadOnly = true;
			this.dataGridViewTextBoxColumn8.Width = 92;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn9.HeaderText = "勝数計";
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.ReadOnly = true;
			this.dataGridViewTextBoxColumn9.Width = 66;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn10.HeaderText = "敗数計";
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.ReadOnly = true;
			this.dataGridViewTextBoxColumn10.Width = 66;
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.dataGridViewTextBoxColumn11.HeaderText = "勝率(%)";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.ReadOnly = true;
			this.dataGridViewTextBoxColumn11.Width = 68;
			// 
			// LogAna
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1256, 594);
			this.Controls.Add(this.tabControl_Main);
			this.Controls.Add(this.button_Ana);
			this.Controls.Add(this.checkBox_Eneclass);
			this.Controls.Add(this.checkBox_Enedec);
			this.Controls.Add(this.checkBox_Mydec);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox_Eneclass);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBox_Enedec);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox_Mydec);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.chart1);
			this.Name = "LogAna";
			this.Text = "LogAna";
			this.Load += new System.EventHandler(this.LogAna_Load);
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Main)).EndInit();
			this.tabControl_Main.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_Rank)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.DataGridView dataGridView_Main;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_VS;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_FirstWin;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_FirstLose;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_FirstPer;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_SecondWin;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_SecondLose;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_SecondPer;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_AllWin;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_AllLose;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_AllPer;
		private System.Windows.Forms.ComboBox comboBox_Mydec;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox_Enedec;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox_Eneclass;
		private System.Windows.Forms.CheckBox checkBox_Mydec;
		private System.Windows.Forms.CheckBox checkBox_Enedec;
		private System.Windows.Forms.CheckBox checkBox_Eneclass;
		private System.Windows.Forms.Button button_Ana;
		private System.Windows.Forms.TabControl tabControl_Main;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.DataGridView dataGridView_Rank;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
	}
}