using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace ShadowNote_CS
{
	public partial class DeckAdd : Form
	{
		private Timer m_timer;
		public DeckAdd()
		{
			InitializeComponent();
		}

		private void button_OK_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void DeckAdd_Load(object sender, EventArgs e)
		{
			Common com = new Common();
			com.SetClassList(comboBox_ClassName);
			SetPlayer();
			com = null;
		}

		private void SetPlayer()
		{
			comboBox_Player.Items.Add("自分");
			comboBox_Player.Items.Add("相手");
			comboBox_Player.SelectedIndex = 0;
			comboBox_Player.Update();
        }

		private void button_Add_Click(object sender, EventArgs e)
		{
			using (StreamWriter sw = new StreamWriter("DeckList.txt", true)) //trueだと追加書き込み
			{
				String writestr;
				Common com = new Common();

				//書き込む文字列の作成
				//自分か相手か,クラス,デッキ名
				writestr = comboBox_Player.Text == "自分" ? "m" : "e";
				writestr += ","+ com.ChangeClassName(comboBox_ClassName.Text); //もっとヘッダみたいに簡単に使えないのか
				writestr += "," + textBox_DeckName.Text;

				//ファイルに書き込む
				sw.Write(writestr + "\n");
				com = null;
				statusStrip1.Items.Add(writestr + "を保存しました");
				m_timer = new Timer();
				m_timer.Tick += new EventHandler(TimeCount);
				m_timer.Interval = 2000;
				m_timer.Start();
			}
		}


		private void TimeCount(object sender, EventArgs e)
		{
			m_timer.Stop();
			statusStrip1.Items.Clear();
		}

	}
}
