namespace ShadowNote_CS
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.comboBox_MyDec = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox_EneClass = new System.Windows.Forms.ComboBox();
			this.button_Add = new System.Windows.Forms.Button();
			this.comboBox_EneDec = new System.Windows.Forms.ComboBox();
			this.comboBox_FirstSecond = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.comboBox_Rank = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.comboBox_Winlose = new System.Windows.Forms.ComboBox();
			this.button_DeckAdd = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.button_LogAna = new System.Windows.Forms.Button();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// comboBox_MyDec
			// 
			this.comboBox_MyDec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_MyDec.FormattingEnabled = true;
			this.comboBox_MyDec.Location = new System.Drawing.Point(50, 16);
			this.comboBox_MyDec.Name = "comboBox_MyDec";
			this.comboBox_MyDec.Size = new System.Drawing.Size(121, 20);
			this.comboBox_MyDec.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "自分:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "相手:";
			// 
			// comboBox_EneClass
			// 
			this.comboBox_EneClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_EneClass.FormattingEnabled = true;
			this.comboBox_EneClass.Location = new System.Drawing.Point(50, 53);
			this.comboBox_EneClass.Name = "comboBox_EneClass";
			this.comboBox_EneClass.Size = new System.Drawing.Size(92, 20);
			this.comboBox_EneClass.TabIndex = 3;
			this.comboBox_EneClass.SelectedIndexChanged += new System.EventHandler(this.comboBox_EneClass_SelectedIndexChanged);
			// 
			// button_Add
			// 
			this.button_Add.Location = new System.Drawing.Point(213, 12);
			this.button_Add.Name = "button_Add";
			this.button_Add.Size = new System.Drawing.Size(75, 23);
			this.button_Add.TabIndex = 4;
			this.button_Add.Text = "記録";
			this.button_Add.UseVisualStyleBackColor = true;
			this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
			// 
			// comboBox_EneDec
			// 
			this.comboBox_EneDec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_EneDec.FormattingEnabled = true;
			this.comboBox_EneDec.Location = new System.Drawing.Point(194, 56);
			this.comboBox_EneDec.Name = "comboBox_EneDec";
			this.comboBox_EneDec.Size = new System.Drawing.Size(133, 20);
			this.comboBox_EneDec.TabIndex = 5;
			// 
			// comboBox_FirstSecond
			// 
			this.comboBox_FirstSecond.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_FirstSecond.FormattingEnabled = true;
			this.comboBox_FirstSecond.Location = new System.Drawing.Point(50, 97);
			this.comboBox_FirstSecond.Name = "comboBox_FirstSecond";
			this.comboBox_FirstSecond.Size = new System.Drawing.Size(59, 20);
			this.comboBox_FirstSecond.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 100);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(31, 12);
			this.label3.TabIndex = 7;
			this.label3.Text = "先後:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(156, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(32, 12);
			this.label4.TabIndex = 9;
			this.label4.Text = "ランク:";
			// 
			// comboBox_Rank
			// 
			this.comboBox_Rank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Rank.FormattingEnabled = true;
			this.comboBox_Rank.Location = new System.Drawing.Point(194, 97);
			this.comboBox_Rank.Name = "comboBox_Rank";
			this.comboBox_Rank.Size = new System.Drawing.Size(94, 20);
			this.comboBox_Rank.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(310, 103);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 12);
			this.label5.TabIndex = 11;
			this.label5.Text = "勝敗:";
			// 
			// comboBox_Winlose
			// 
			this.comboBox_Winlose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Winlose.FormattingEnabled = true;
			this.comboBox_Winlose.Location = new System.Drawing.Point(348, 100);
			this.comboBox_Winlose.Name = "comboBox_Winlose";
			this.comboBox_Winlose.Size = new System.Drawing.Size(59, 20);
			this.comboBox_Winlose.TabIndex = 10;
			// 
			// button_DeckAdd
			// 
			this.button_DeckAdd.Location = new System.Drawing.Point(50, 147);
			this.button_DeckAdd.Name = "button_DeckAdd";
			this.button_DeckAdd.Size = new System.Drawing.Size(75, 23);
			this.button_DeckAdd.TabIndex = 12;
			this.button_DeckAdd.Text = "デッキ追加";
			this.button_DeckAdd.UseVisualStyleBackColor = true;
			this.button_DeckAdd.Click += new System.EventHandler(this.button_DeckAdd_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 294);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(501, 22);
			this.statusStrip1.TabIndex = 13;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
			// 
			// button_LogAna
			// 
			this.button_LogAna.Location = new System.Drawing.Point(184, 147);
			this.button_LogAna.Name = "button_LogAna";
			this.button_LogAna.Size = new System.Drawing.Size(75, 23);
			this.button_LogAna.TabIndex = 14;
			this.button_LogAna.Text = "戦績表示";
			this.button_LogAna.UseVisualStyleBackColor = true;
			this.button_LogAna.Click += new System.EventHandler(this.button_LogAna_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(501, 316);
			this.Controls.Add(this.button_LogAna);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.button_DeckAdd);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.comboBox_Winlose);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBox_Rank);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox_FirstSecond);
			this.Controls.Add(this.comboBox_EneDec);
			this.Controls.Add(this.button_Add);
			this.Controls.Add(this.comboBox_EneClass);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox_MyDec);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox comboBox_MyDec;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox_EneClass;
		private System.Windows.Forms.Button button_Add;
		private System.Windows.Forms.ComboBox comboBox_EneDec;
		private System.Windows.Forms.ComboBox comboBox_FirstSecond;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox comboBox_Rank;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox comboBox_Winlose;
		private System.Windows.Forms.Button button_DeckAdd;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.Button button_LogAna;
	}
}

