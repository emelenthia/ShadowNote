using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadowNote_CS
{
	public partial class DeckDel : Form
	{
		private Common m_com;

		public DeckDel()
		{
			InitializeComponent();
			m_com = new Common();
		}

		private void button_OK_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void DeckDel_Load(object sender, EventArgs e)
		{
			m_com.SetClassList(comboBox_ClassName);
			SetPlayer();
		}

		private void SetPlayer()
		{
			comboBox_Player.Items.Add("自分");
			comboBox_Player.Items.Add("相手");
			comboBox_Player.SelectedIndex = 0;
			comboBox_Player.Update();
		}

		private void SetDeckList()
		{
			//ConboBox初期化時にも呼ばれてしまうので、両方共準備が整っている場合だけ先に進めるようにする
			if(comboBox_Player.SelectedIndex == -1 || comboBox_ClassName.SelectedIndex == -1)
			{
				return;
			}

			comboBox_deck.Items.Clear();
			using (StreamReader sr = new StreamReader("DeckList.txt"))
			{
				String[] readstr;
				while (sr.EndOfStream == false)
				{
					readstr = sr.ReadLine().Split(',');
					if (readstr[0] == (comboBox_Player.SelectedIndex == 0 ? "m" : "e"))
					{
						int classnumber = comboBox_ClassName.SelectedIndex;
						if (readstr[1] == m_com.ChangeClassOneName(classnumber))
						{
							comboBox_deck.Items.Add(readstr[2]);
						}
						
					}
				}
			}

			//最後に、リストの選択を一番上にする
			if (comboBox_deck.Items.Count > 0)
			{
				comboBox_deck.SelectedIndex = 0;
			}
			comboBox_deck.Update();
		}

		private void comboBox_Player_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetDeckList();
		}

		private void comboBox_ClassName_SelectedIndexChanged(object sender, EventArgs e)
		{
			SetDeckList();
		}

		private void button_del_Click(object sender, EventArgs e)
		{
			if(
			MessageBox.Show("削除します。よろしいですか?","確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2)
			== DialogResult.OK)
			{
				using (StreamReader sr = new StreamReader("DeckList.txt"))
				{
						//比較しやすいように文字列を作る
						string temp_str = comboBox_Player.SelectedIndex == 0 ? "m" : "e";
						temp_str += ",";
						temp_str += m_com.ChangeClassOneName(comboBox_ClassName.SelectedIndex);
						temp_str += ",";
						temp_str += (string)comboBox_deck.SelectedItem;

					//特定行のみを除いたファイルを別に作る
					using (StreamWriter sw = new StreamWriter("DeckList2.txt"))
					{
						string readstr;
						while (sr.EndOfStream == false)
						{
							readstr = sr.ReadLine();
							if(readstr != temp_str)
							{
								sw.Write(readstr + "\n");
							}
						}
					}
				}

				//その後、元あったファイルを削除し、新人が成り代わる
				File.Delete("DeckList.txt");
				File.Move("DeckList2.txt", "DeckList.txt");

				SetDeckList();
			}
		}

		private void button_ren_Click(object sender, EventArgs e)
		{
			using (StreamReader sr = new StreamReader("DeckList.txt"))
			{
				//比較しやすいように文字列を作る
				string temp_str = comboBox_Player.SelectedIndex == 0 ? "m" : "e";
				temp_str += ",";
				temp_str += m_com.ChangeClassOneName(comboBox_ClassName.SelectedIndex);
				temp_str += ",";
				temp_str += (string)comboBox_deck.SelectedItem;

				//特定行の場合に新たな名前にしたファイルを別に作る
				using (StreamWriter sw = new StreamWriter("DeckList2.txt"))
				{
					string readstr;
					while (sr.EndOfStream == false)
					{
						readstr = sr.ReadLine();
						if (readstr != temp_str)
						{
							sw.Write(readstr + "\n");
						}
						else
						{
							string temp_wstr = comboBox_Player.SelectedIndex == 0 ? "m" : "e";
							temp_wstr += ",";
							temp_wstr += m_com.ChangeClassOneName(comboBox_ClassName.SelectedIndex);
							temp_wstr += ",";
							temp_wstr += textBox_DeckName.Text;
							sw.Write(temp_wstr + "\n");
						}
					}
				}
			}

			//その後、元あったファイルを削除し、新人が成り代わる
			File.Delete("DeckList.txt");
			File.Move("DeckList2.txt", "DeckList.txt");

			SetDeckList();
		}
	}
}
