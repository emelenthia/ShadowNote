using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections; //ArrayList用
using System.Windows.Forms;


namespace ShadowNote_CS
{
	public partial class LogAna : Form
	{
		private Common m_com;
		ArrayList m_numwinfirst;
		ArrayList m_numlosefirst;
		ArrayList m_numwinsecond;
		ArrayList m_numlosesecond;
		private ArrayList[] m_ene_decklist;
		private ArrayList m_mydeckclass; //自分の各デッキに対応するクラスを保存


		public LogAna()
		{
			InitializeComponent();
		}


		private void LogAna_Load(object sender, EventArgs e)
		{
			m_com = new Common();
			ComboBox comboBox_dummy = new ComboBox();
			m_ene_decklist = new ArrayList[Common.numclass];
			for (int i = 0; i < Common.numclass; i++)
			{
				m_ene_decklist[i] = new ArrayList();
			}
			m_mydeckclass = new ArrayList();
			comboBox_Time.Items.Add("Today");
			comboBox_Time.Items.Add("Week");
			comboBox_Time.Items.Add("Month");
			comboBox_Time.Items.Add("Season");
			comboBox_Time.SelectedIndex = 0;
			comboBox_Time.Update();

			Analysising(0);
			Analysising(1);
			Analysising(2);

			m_com.DeckListLoad(comboBox_Mydec, comboBox_dummy, m_ene_decklist, m_mydeckclass);
			m_com.SetClassList(comboBox_Myclass);

			comboBox_dummy = null;
		}


		public AnaData MakeAnaData(String name, int classnumber)
		{
			AnaData ret_anadata = new AnaData(name, classnumber);
			return ret_anadata;
		}


		public int IndexOfAnaData(ArrayList array, AnaData _object)
		{
			int numinarray = array.Count;
			int ret = -1;
			for (int i = 0; i < numinarray; i++)
			{
				//((AnaData)array[i]).Equals(_object)
				//と
				//AnaDataEquals((AnaData)array[i],_object)
				//な感じにするのとどっちが良いんだろう
				if (((AnaData)array[i]).Equals(_object))
				{
					ret = i;
					break;
				}
			}
			return ret;
		}


		private void button1_Click(object sender, EventArgs e)
		{
			if (dataGridView_Main.Visible == false)
			{
				dataGridView_Main.Visible = true;
			}
			else
			{
				dataGridView_Main.Visible = false;
			}
		}


		private void button_Ana_Click(object sender, EventArgs e)
		{
			Analysising(0);
			Analysising(1);
			Analysising(2);
		}


		private void Analysising(int mode) //0…class毎、1…Rank毎、2…deck毎、3…全部
		{
			m_numwinfirst = new ArrayList();
			m_numlosefirst = new ArrayList();
			m_numwinsecond = new ArrayList();
			m_numlosesecond = new ArrayList();


			//数えるための配列を作る
			m_numwinfirst.Clear();
			switch (mode)
			{
			case 0:
				{
					for (int i = 0; i < Common.numclass; i++)
					{
						//このMakeAnaData()、最初は1つ作ってそれを4つに入れようとしていたが、それはポインタを渡しているだけなので、4つのうち1つのカウントが変更されると他の3つも変更されるようになってしまっていた
						string temp_str = m_com.GetClassNameList()[i];
						m_numwinfirst.Add(MakeAnaData(temp_str, i));
						m_numlosefirst.Add(MakeAnaData(temp_str, i));
						m_numwinsecond.Add(MakeAnaData(temp_str, i));
						m_numlosesecond.Add(MakeAnaData(temp_str, i));
					}
				}
				break;
			case 1:
				{
					int numranks = m_com.GetRankListRoughly().Count();
					for (int i = 0; i < numranks; i++)
					{
						string temp_str = m_com.GetRankListRoughly()[i];
						m_numwinfirst.Add(MakeAnaData(temp_str, -1));
						m_numwinsecond.Add(MakeAnaData(temp_str, -1));
						m_numlosefirst.Add(MakeAnaData(temp_str, -1));
						m_numlosesecond.Add(MakeAnaData(temp_str, -1));
					}
				}
				break;
			case 2:
				{
					using (StreamReader sr = new StreamReader("DeckList.txt")) //デッキリスト2回ロードしてるし何か無駄だよなあ
					{
						String[] readstr;
						while (sr.EndOfStream == false)
						{
							readstr = sr.ReadLine().Split(',');
							if (readstr[0] == "e")
							{
								m_numwinfirst.Add(MakeAnaData(readstr[2], m_com.GetClassNumber(readstr[1])));
								m_numwinsecond.Add(MakeAnaData(readstr[2], m_com.GetClassNumber(readstr[1])));
								m_numlosefirst.Add(MakeAnaData(readstr[2], m_com.GetClassNumber(readstr[1])));
								m_numlosesecond.Add(MakeAnaData(readstr[2], m_com.GetClassNumber(readstr[1])));
							}
						}
					}
				}
				break;
			}

			//読み込んで数を数える
			using (StreamReader sr = new StreamReader("BattleLog.log"))
			{
				String[] readstr;
				bool bNotCount = false;

				while (sr.EndOfStream == false) //EOFならtrueっぽいよ
				{
					readstr = sr.ReadLine().Split(',');

					//チェックボックスの状態によってはカウントしないフラグを立てる
					//もっと綺麗な方法があるかな?

					bNotCount = false;
					if (checkBox_Mydec.Checked)
					{
						if (readstr[1] != (string)comboBox_Mydec.SelectedItem) //選択されていたデッキと同じじゃないなら
						{
							bNotCount = true;
						}
					}
					if (checkBox_Myclass.Checked)
					{
						if (readstr[0] != (string)comboBox_Mydec.SelectedItem)
						{
							bNotCount = true;
						}
					}
					if (checkBox_Eneclass.Checked)
					{
						if (readstr[2] != (string)comboBox_Eneclass.SelectedItem)
						{
							bNotCount = true;
						}
					}
					if (checkBox_Time.Checked)
					{
						DateTime dt = DateTime.Now;
						DateTime read_dt = m_com.MakeDateTime(readstr[7], readstr[8]);

						//判定は全部Near(直近24時間とかそんなの)
						TimeSpan ts = dt - read_dt;

						switch ((string)comboBox_Time.SelectedItem)
						{
						case "Today":
							{
								if (ts.Days != 0)
								{
									bNotCount = true;
								}
							}
							break;
						case "Week":
							{
								if (ts.Days > 6)
								{
									bNotCount = true;
								}
							}
							break;
						case "Month":
							{
								if (ts.Days > 29)
								{
									bNotCount = true;
								}
							}
							break;
						case "Season":
							{
								if (dt.Month != read_dt.Month)
								{
									bNotCount = true;
								}
							}
							break;
						}
					}
					if (checkBox_TimeDesign.Checked)
					{

					}

					if (!bNotCount)
					{
						if (readstr[4] == "w")
						{
							if (readstr[5] == "f")
							{
								WinLoseCount(m_numwinfirst, readstr, mode);
							}
							else
							{
								WinLoseCount(m_numwinsecond, readstr, mode);
							}
						}
						else
						{
							if (readstr[5] == "f")
							{
								WinLoseCount(m_numlosefirst, readstr, mode);
							}
							else
							{
								WinLoseCount(m_numlosesecond, readstr, mode);
							}
						}
					}

				}
			}

			//それをDataGridViewに入れる
			int numfirst = 0;
			int numsecond = 0;
			double firstper = 0; //四捨五入する為に
			double secondper = 0;
			double allper = 0;
			int num_numwinfirst = 0;
			int num_numlosefirst = 0;
			int num_numwinsecond = 0;
			int num_numlosesecond = 0;
			int num_add = 1;

			int array_num = m_numwinfirst.Count;

			//入れる処理を使いまわす
			DataGridView pDGV;
			switch (mode)
			{
			case 0:
				pDGV = dataGridView_Main;
				break;
			case 1:
				pDGV = dataGridView_Rank;
				break;
			case 2:
				pDGV = dataGridView_Deck;
				break;
			default:
				pDGV = dataGridView_Main;
				break;
			}

			pDGV.Rows.Clear();
			for (int i = 0; i < array_num; i++)
			{
				//表示の簡略化
				int winfirst_now = ((AnaData)m_numwinfirst[i]).GetCount();
				int losefirst_now = ((AnaData)m_numlosefirst[i]).GetCount();
				int winsecond_now = ((AnaData)m_numwinsecond[i]).GetCount();
				int losesecond_now = ((AnaData)m_numlosesecond[i]).GetCount();
				string name_now = ((AnaData)m_numwinfirst[i]).GetName();

				//先攻後攻の勝負数を計算して、0回の場合は0除算を回避する
				numfirst = winfirst_now + losefirst_now;
				numsecond = winsecond_now + losesecond_now;

				//ID,クラス名,先攻勝数,先攻敗数,先攻勝率,後攻勝数,後攻敗数,後攻勝率,,
				if (numfirst != 0 && numsecond != 0) //両方0回でない場合
				{
					firstper = Math.Round(winfirst_now * 100.0 / numfirst, 2, MidpointRounding.AwayFromZero);
					secondper = Math.Round((winsecond_now * 100.0 / numsecond), 2, MidpointRounding.AwayFromZero);
					allper = Math.Round(((winfirst_now + winsecond_now) * 100.0 / (numfirst + numsecond)), 2, MidpointRounding.AwayFromZero);

					pDGV.Rows.Add(num_add, name_now, winfirst_now, losefirst_now, firstper
						, winsecond_now, losesecond_now, secondper, winfirst_now + winsecond_now, losefirst_now + losesecond_now, allper);
				}
				else if (numfirst + numsecond == 0) //両方0回の場合
				{
					if (mode != 2) //デッキ毎モードでは、両方0回の時は登録しない
					{
						pDGV.Rows.Add(num_add, name_now, 0, 0, 0.0, 0, 0, 0.0, 0, 0, 0.0);
					}
					else
					{
						num_add--; //IDはこれでごまかす
					}
				}
				else if (numfirst == 0) //先攻0回の場合
				{
					secondper = Math.Round((winsecond_now * 100.0 / numsecond), 2, MidpointRounding.AwayFromZero);
					pDGV.Rows.Add(num_add, name_now, 0, 0, 0.0
						   , winsecond_now, losesecond_now, secondper, winsecond_now, losesecond_now, secondper);

				}
				else //後攻0回の場合
				{
					firstper = Math.Round(winfirst_now * 100.0 / numfirst, 2, MidpointRounding.AwayFromZero);
					pDGV.Rows.Add(num_add, name_now, winfirst_now, losefirst_now, firstper
						, 0, 0, 0.0, winfirst_now, losefirst_now, firstper);
				}

				//クラスによって色を変える処理
				if (mode == 0 ||  mode == 2)
				{
					if (numfirst + numsecond != 0) //合計が0の時は表示しないので塗らない
					{
						Color tempcolor = Color.White;
						switch (m_com.GetClassNameList()[((AnaData)m_numwinfirst[i]).GetClassNumber()])
						{
						case "エルフ":
							tempcolor = Color.LightGreen;
							break;
						case "ロイヤル":
							tempcolor = Color.LightGoldenrodYellow;
							break;
						case "ウィッチ":
							tempcolor = Color.Aqua;
							break;
						case "ドラゴン":
							tempcolor = Color.Orange;
							break;
						case "ネクロマンサー":
							tempcolor = Color.Violet;
							break;
						case "ヴァンパイア":
							tempcolor = Color.Red;
							break;
						case "ビショップ":
							tempcolor = Color.Gray;
							break;
						default:
							break;
						}

						for (int ci = 0; ci < pDGV.ColumnCount; ci++)
						{
							pDGV[ci, num_add - 1].Style.BackColor = tempcolor;
						}
					}
				}

				//合計を出す
				num_numwinfirst += winfirst_now;
				num_numlosefirst += losefirst_now;
				num_numwinsecond += winsecond_now;
				num_numlosesecond += losesecond_now;
				num_add++;


			}

			//上手く合計出せないのかな
			numfirst = num_numwinfirst + num_numlosefirst;
			if (numfirst != 0)
			{
				firstper = Math.Round(num_numwinfirst * 100.0 / numfirst, 2, MidpointRounding.AwayFromZero);
			}
			else
			{
				firstper = 0;
			}

			numsecond = num_numwinsecond + num_numlosesecond;
			if (numsecond != 0)
			{
				secondper = Math.Round((num_numwinsecond * 100.0 / numsecond), 2, MidpointRounding.AwayFromZero);
			}

			if (numfirst + numsecond != 0)
			{
				allper = Math.Round(((num_numwinfirst + num_numwinsecond) * 100.0 / (numfirst + numsecond)), 2, MidpointRounding.AwayFromZero);
			}
			pDGV.Rows.Add(num_add, "計", num_numwinfirst, num_numlosefirst, firstper
						, num_numwinsecond, num_numlosesecond, secondper, num_numwinfirst + num_numwinsecond, num_numlosefirst + num_numlosesecond, allper);



			if (checkBox_except.Checked)
			{
				ExceptLowBattleDeck(pDGV);
			}
		}


		public void WinLoseCount(ArrayList array, string[] readstr, int mode)
		{
			//添字を、クラスによってかランクによってか等と分けて書くと先行後攻勝敗×クラスランクデッキで、4*3個同じようなのを書く必要になるからこっちに纏めておく
			switch (mode)
			{
			case 0: //クラス別
				{
					((AnaData)array[m_com.GetClassNumber(readstr[2])]).CountAdd();
				}
				break;
			case 1: //ランク別
				{
					((AnaData)array[m_com.GetRankNumber(readstr[6], 1)]).CountAdd(); //1は大雑把モード。この辺どうするかは要考慮
				}
				break;
			case 2: //デッキ別
				{
					int temp = IndexOfAnaData(array, MakeAnaData(readstr[3], m_com.GetClassNumber(readstr[2])));
					((AnaData)array[temp]).CountAdd();
				}
				break;
			default:
				{

				}
				break;
			}
		}


		//指定した対戦数以下のデッキを表示しない
		private void ExceptLowBattleDeck(DataGridView pDGV)
		{
			int deck_num = pDGV.RowCount;
			int except_num = int.Parse(textBox_ExceptBattle.Text);

			for (int i = 0; i < deck_num; i++)
			{
				if ((int)pDGV.Rows[i].Cells[8].Value + (int)pDGV.Rows[i].Cells[9].Value <= except_num)
				{
					pDGV.Rows[i].Visible = false;
				}
			}
		}


		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}


		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{

		}
	}


	public class AnaData
	{
		//名前(デッキ名、クラス名、ランク名)、クラス、回数の要素を持つ構造体みたいなの
		private String name;
		private int count;
		private int classnumber;

		public AnaData(String name, int classnumber = -1)
		{
			this.name = name;
			this.classnumber = classnumber;
			this.count = 0; //カウントは0で初期化
		}

		public String GetName()
		{
			return name;
		}
		public int GetClassNumber()
		{
			return classnumber;
		}
		public int CountAdd()
		{
			count++;
			return count;
		}
		public int GetCount()
		{
			return count;
		}

		public bool Equals(AnaData ad)
		{
			bool bret = false;
			//カウントはチェックする必要がない
			if (ad.GetName() == this.GetName() && ad.GetClassNumber() == this.GetClassNumber())
			{
				bret = true;
			}

			return bret;
		}

	};


}
