namespace ShadowNote_CS
{
	partial class DeckDel
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
			this.button_OK = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox_Player = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.comboBox_ClassName = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox_DeckName = new System.Windows.Forms.TextBox();
			this.button_del = new System.Windows.Forms.Button();
			this.button_ren = new System.Windows.Forms.Button();
			this.comboBox_deck = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button_OK
			// 
			this.button_OK.Location = new System.Drawing.Point(272, 197);
			this.button_OK.Name = "button_OK";
			this.button_OK.Size = new System.Drawing.Size(75, 23);
			this.button_OK.TabIndex = 7;
			this.button_OK.Text = "OK";
			this.button_OK.UseVisualStyleBackColor = true;
			this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(29, 26);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(43, 12);
			this.label3.TabIndex = 8;
			this.label3.Text = "使用者:";
			// 
			// comboBox_Player
			// 
			this.comboBox_Player.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_Player.FormattingEnabled = true;
			this.comboBox_Player.Location = new System.Drawing.Point(97, 23);
			this.comboBox_Player.Name = "comboBox_Player";
			this.comboBox_Player.Size = new System.Drawing.Size(121, 20);
			this.comboBox_Player.TabIndex = 9;
			this.comboBox_Player.SelectedIndexChanged += new System.EventHandler(this.comboBox_Player_SelectedIndexChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(29, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(32, 12);
			this.label2.TabIndex = 10;
			this.label2.Text = "クラス:";
			// 
			// comboBox_ClassName
			// 
			this.comboBox_ClassName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_ClassName.FormattingEnabled = true;
			this.comboBox_ClassName.Location = new System.Drawing.Point(97, 65);
			this.comboBox_ClassName.Name = "comboBox_ClassName";
			this.comboBox_ClassName.Size = new System.Drawing.Size(121, 20);
			this.comboBox_ClassName.TabIndex = 11;
			this.comboBox_ClassName.SelectedIndexChanged += new System.EventHandler(this.comboBox_ClassName_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 152);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 12);
			this.label1.TabIndex = 12;
			this.label1.Text = "変更後のデッキ名:";
			// 
			// textBox_DeckName
			// 
			this.textBox_DeckName.Location = new System.Drawing.Point(119, 149);
			this.textBox_DeckName.Name = "textBox_DeckName";
			this.textBox_DeckName.Size = new System.Drawing.Size(152, 19);
			this.textBox_DeckName.TabIndex = 13;
			// 
			// button_del
			// 
			this.button_del.Location = new System.Drawing.Point(143, 197);
			this.button_del.Name = "button_del";
			this.button_del.Size = new System.Drawing.Size(75, 23);
			this.button_del.TabIndex = 14;
			this.button_del.Text = "削除";
			this.button_del.UseVisualStyleBackColor = true;
			this.button_del.Click += new System.EventHandler(this.button_del_Click);
			// 
			// button_ren
			// 
			this.button_ren.Location = new System.Drawing.Point(31, 197);
			this.button_ren.Name = "button_ren";
			this.button_ren.Size = new System.Drawing.Size(75, 23);
			this.button_ren.TabIndex = 15;
			this.button_ren.Text = "リネーム";
			this.button_ren.UseVisualStyleBackColor = true;
			this.button_ren.Click += new System.EventHandler(this.button_ren_Click);
			// 
			// comboBox_deck
			// 
			this.comboBox_deck.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox_deck.FormattingEnabled = true;
			this.comboBox_deck.Location = new System.Drawing.Point(97, 109);
			this.comboBox_deck.Name = "comboBox_deck";
			this.comboBox_deck.Size = new System.Drawing.Size(121, 20);
			this.comboBox_deck.TabIndex = 17;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(29, 112);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(34, 12);
			this.label4.TabIndex = 16;
			this.label4.Text = "デッキ:";
			// 
			// DeckDel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(359, 242);
			this.Controls.Add(this.comboBox_deck);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button_ren);
			this.Controls.Add(this.button_del);
			this.Controls.Add(this.textBox_DeckName);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox_ClassName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.comboBox_Player);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button_OK);
			this.Name = "DeckDel";
			this.Text = "DeckDel";
			this.Load += new System.EventHandler(this.DeckDel_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button_OK;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox_Player;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboBox_ClassName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox_DeckName;
		private System.Windows.Forms.Button button_del;
		private System.Windows.Forms.Button button_ren;
		private System.Windows.Forms.ComboBox comboBox_deck;
		private System.Windows.Forms.Label label4;
	}
}