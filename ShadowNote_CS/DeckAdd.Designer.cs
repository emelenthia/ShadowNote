namespace ShadowNote_CS
{
	partial class DeckAdd
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
			this.textBox_DeckName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox_ClassName = new System.Windows.Forms.ComboBox();
			this.comboBox_Player = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.button_OK = new System.Windows.Forms.Button();
			this.button_Add = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// textBox_DeckName
			// 
			this.textBox_DeckName.Location = new System.Drawing.Point(102, 38);
			this.textBox_DeckName.Name = "textBox_DeckName";
			this.textBox_DeckName.Size = new System.Drawing.Size(152, 19);
			this.textBox_DeckName.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(45, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "デッキ名:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(45, 87);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 2;
			this.label2.Text = "クラス:";
			// 
			// comboBox_ClassName
			// 
			this.comboBox_ClassName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_ClassName.FormattingEnabled = true;
			this.comboBox_ClassName.Location = new System.Drawing.Point(102, 84);
			this.comboBox_ClassName.Name = "comboBox_ClassName";
			this.comboBox_ClassName.Size = new System.Drawing.Size(121, 20);
			this.comboBox_ClassName.TabIndex = 3;
			// 
			// comboBox_Player
			// 
			this.comboBox_Player.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Player.FormattingEnabled = true;
			this.comboBox_Player.Location = new System.Drawing.Point(102, 127);
			this.comboBox_Player.Name = "comboBox_Player";
			this.comboBox_Player.Size = new System.Drawing.Size(121, 20);
			this.comboBox_Player.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(45, 130);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 12);
			this.label3.TabIndex = 4;
			this.label3.Text = "使用者:";
			// 
			// button_OK
			// 
			this.button_OK.Location = new System.Drawing.Point(269, 171);
			this.button_OK.Name = "button_OK";
			this.button_OK.Size = new System.Drawing.Size(75, 23);
			this.button_OK.TabIndex = 6;
			this.button_OK.Text = "OK";
			this.button_OK.UseVisualStyleBackColor = true;
			this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
			// 
			// button_Add
			// 
			this.button_Add.Location = new System.Drawing.Point(269, 81);
			this.button_Add.Name = "button_Add";
			this.button_Add.Size = new System.Drawing.Size(75, 23);
			this.button_Add.TabIndex = 7;
			this.button_Add.Text = "追加";
			this.button_Add.UseVisualStyleBackColor = true;
			this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
			this.statusStrip1.Location = new System.Drawing.Point(0, 204);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(358, 22);
			this.statusStrip1.TabIndex = 8;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabel1
			// 
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
			// 
			// DeckAdd
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(358, 226);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.button_Add);
			this.Controls.Add(this.button_OK);
			this.Controls.Add(this.comboBox_Player);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.comboBox_ClassName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox_DeckName);
			this.Name = "DeckAdd";
			this.Text = "DeckAdd";
			this.Load += new System.EventHandler(this.DeckAdd_Load);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox_DeckName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox_ClassName;
		private System.Windows.Forms.ComboBox comboBox_Player;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button_OK;
		private System.Windows.Forms.Button button_Add;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
	}
}