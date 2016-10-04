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
			m_ene_decklist = new ArrayList[Common.numclass];
			for (int i = 0; i < Common.numclass; i++)
			{
				m_ene_decklist[i] = new ArrayList();
			}
			m_mydeckclass = new ArrayList();

			Analysising(0);
		//	Analysising(1);

			m_com.DeckListLoad(comboBox_Mydec, comboBox_Enedec, m_ene_decklist, m_mydeckclass);
			m_com.SetClassList(comboBox_Eneclass);
		}
		
		public AnaData MakeAnaData(String name, int classnumber)
		{
			AnaData ret_anadata = new AnaData(name, classnumber);
			return ret_anadata;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(dataGridView_Main.Visible==false)
			{
				dataGridView_Main.Visible = true;
			}
			else
			{
				dataGridView_Main.Visible = false;
			}
        }


		private void comboBox_Eneclass_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBox_Enedec.Items.Clear();
			int classnumber = m_com.GetClassNumber(comboBox_Eneclass.Text);
			int numdeck = m_ene_decklist[classnumber].Count;
			for (int i = 0; i < numdeck; i++)
			{
				comboBox_Enedec.Items.Add(m_ene_decklist[classnumber][i]);
			}
			if (comboBox_Enedec.Items.Count > 0)
			{
				comboBox_Enedec.SelectedIndex = 0;
			}
			comboBox_Enedec.Update();
		}
		

		private void button_Ana_Click(object sender, EventArgs e)
		{
			Analysising(0);
		}


		private void Analysising(int mode) //0…class毎、1…Rank毎、2…deck毎、3…全部
		{
			m_numwinfirst = new ArrayList();
			m_numlosefirst = new ArrayList();
			m_numwinsecond = new ArrayList();
			m_numlosesecond = new ArrayList();

			String[] m_classlist = { "ロイヤル", "エルフ", "ウィッチ", "ドラゴン", "ネクロマンサー", "ヴァンパイア", "ビショップ" };

			//数えるための配列を作る
			m_numwinfirst.Clear();
			switch (mode)
			{
			case 0:
				{
					m_numwinfirst.Add(MakeAnaData("ロイヤル", -1));
					m_numwinfirst.Add(MakeAnaData("エルフ", -1));
					m_numwinfirst.Add(MakeAnaData("ウィッチ", -1));
					m_numwinfirst.Add(MakeAnaData("ドラゴン", -1));
					m_numwinfirst.Add(MakeAnaData("ネクロマンサー", -1));
					m_numwinfirst.Add(MakeAnaData("ヴァンパイア", -1));
					m_numwinfirst.Add(MakeAnaData("ビショップ", -1));
					m_numwinfirst.Add(MakeAnaData("計", -1));

					m_numlosefirst.Add(MakeAnaData("ロイヤル", -1));
					m_numlosefirst.Add(MakeAnaData("エルフ", -1));
					m_numlosefirst.Add(MakeAnaData("ウィッチ", -1));
					m_numlosefirst.Add(MakeAnaData("ドラゴン", -1));
					m_numlosefirst.Add(MakeAnaData("ネクロマンサー", -1));
					m_numlosefirst.Add(MakeAnaData("ヴァンパイア", -1));
					m_numlosefirst.Add(MakeAnaData("ビショップ", -1));
					m_numlosefirst.Add(MakeAnaData("計", -1));

					m_numwinsecond.Add(MakeAnaData("ロイヤル", -1));
					m_numwinsecond.Add(MakeAnaData("エルフ", -1));
					m_numwinsecond.Add(MakeAnaData("ウィッチ", -1));
					m_numwinsecond.Add(MakeAnaData("ドラゴン", -1));
					m_numwinsecond.Add(MakeAnaData("ネクロマンサー", -1));
					m_numwinsecond.Add(MakeAnaData("ヴァンパイア", -1));
					m_numwinsecond.Add(MakeAnaData("ビショップ", -1));
					m_numwinsecond.Add(MakeAnaData("計", -1));

					m_numlosesecond.Add(MakeAnaData("ロイヤル", -1));
					m_numlosesecond.Add(MakeAnaData("エルフ", -1));
					m_numlosesecond.Add(MakeAnaData("ウィッチ", -1));
					m_numlosesecond.Add(MakeAnaData("ドラゴン", -1));
					m_numlosesecond.Add(MakeAnaData("ネクロマンサー", -1));
					m_numlosesecond.Add(MakeAnaData("ヴァンパイア", -1));
					m_numlosesecond.Add(MakeAnaData("ビショップ", -1));
					m_numlosesecond.Add(MakeAnaData("計", -1));
				}
				break;
			case 1:
				{
					using (StreamReader sr = new StreamReader("DeckList.txt"))
					{
						//名前(デッキ名、クラス名、ランク名)、クラス、回数の要素を持つ構造体を定義する
						while (sr.EndOfStream == false)
						{
							m_numwinfirst.Add(MakeAnaData("A未満", -1));
							m_numwinfirst.Add(MakeAnaData("A0", -1));
							m_numwinfirst.Add(MakeAnaData("A1", -1));
							m_numwinfirst.Add(MakeAnaData("A2", -1));
							m_numwinfirst.Add(MakeAnaData("A3", -1));
							m_numwinfirst.Add(MakeAnaData("AA0", -1));
							m_numwinfirst.Add(MakeAnaData("AA1", -1));
							m_numwinfirst.Add(MakeAnaData("AA2", -1));
							m_numwinfirst.Add(MakeAnaData("AA3", -1));
							m_numwinfirst.Add(MakeAnaData("Master", -1));
							m_numwinfirst.Add(MakeAnaData("計", -1));

							m_numwinsecond.Add(MakeAnaData("A未満", -1));
							m_numwinsecond.Add(MakeAnaData("A0", -1));
							m_numwinsecond.Add(MakeAnaData("A1", -1));
							m_numwinsecond.Add(MakeAnaData("A2", -1));
							m_numwinsecond.Add(MakeAnaData("A3", -1));
							m_numwinsecond.Add(MakeAnaData("AA0", -1));
							m_numwinsecond.Add(MakeAnaData("AA1", -1));
							m_numwinsecond.Add(MakeAnaData("AA2", -1));
							m_numwinsecond.Add(MakeAnaData("AA3", -1));
							m_numwinsecond.Add(MakeAnaData("Master", -1));
							m_numwinsecond.Add(MakeAnaData("計", -1));

							m_numlosefirst.Add(MakeAnaData("A未満", -1));
							m_numlosefirst.Add(MakeAnaData("A0", -1));
							m_numlosefirst.Add(MakeAnaData("A1", -1));
							m_numlosefirst.Add(MakeAnaData("A2", -1));
							m_numlosefirst.Add(MakeAnaData("A3", -1));
							m_numlosefirst.Add(MakeAnaData("AA0", -1));
							m_numlosefirst.Add(MakeAnaData("AA1", -1));
							m_numlosefirst.Add(MakeAnaData("AA2", -1));
							m_numlosefirst.Add(MakeAnaData("AA3", -1));
							m_numlosefirst.Add(MakeAnaData("Master", -1));
							m_numlosefirst.Add(MakeAnaData("計", -1));

							m_numlosesecond.Add(MakeAnaData("A未満", -1));
							m_numlosesecond.Add(MakeAnaData("A0", -1));
							m_numlosesecond.Add(MakeAnaData("A1", -1));
							m_numlosesecond.Add(MakeAnaData("A2", -1));
							m_numlosesecond.Add(MakeAnaData("A3", -1));
							m_numlosesecond.Add(MakeAnaData("AA0", -1));
							m_numlosesecond.Add(MakeAnaData("AA1", -1));
							m_numlosesecond.Add(MakeAnaData("AA2", -1));
							m_numlosesecond.Add(MakeAnaData("AA3", -1));
							m_numlosesecond.Add(MakeAnaData("Master", -1));
							m_numlosesecond.Add(MakeAnaData("計", -1));
						}
					}
				}
				break;
			}

			//読み込んで数を数える
			using (StreamReader sr = new StreamReader("BattleLog.log"))
			{
				String[] readstr;

				while (sr.EndOfStream == false) //EOFならtrueっぽいよ
				{
					readstr = sr.ReadLine().Split(',');
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

			dataGridView_Main.Rows.Clear();

            for (int i = 0; i < 7; i++)
			{
				//表示の簡略化
				int winfirst_now= ((AnaData)m_numwinfirst[i]).GetCount();
				int losefirst_now = ((AnaData)m_numlosefirst[i]).GetCount();
				int winsecond_now = ((AnaData)m_numwinsecond[i]).GetCount();
				int losesecond_now = ((AnaData)m_numlosesecond[i]).GetCount();

				//先攻後攻の勝負数を計算して、0回の場合は0除算を回避する
				numfirst = winfirst_now + losefirst_now;
				numsecond = winsecond_now + losesecond_now;

				//ID,クラス名,先攻勝数,先攻敗数,先攻勝率,後攻勝数,後攻敗数,後攻勝率,,
				if (numfirst + numsecond != 0) //両方0回でない場合
				{
					firstper = Math.Round(winfirst_now * 100.0 / numfirst, 2, MidpointRounding.AwayFromZero);
					secondper = Math.Round((winsecond_now * 100.0 / numsecond), 2, MidpointRounding.AwayFromZero);
					allper = Math.Round(((winfirst_now + winsecond_now) * 100.0 / (numfirst + numsecond)), 2, MidpointRounding.AwayFromZero);

					dataGridView_Main.Rows.Add(num_add, m_classlist[i], winfirst_now, losefirst_now, firstper
						, winsecond_now, losesecond_now, secondper, winfirst_now + winsecond_now, losefirst_now + losesecond_now, allper);
				}
				else if (numfirst + numsecond == 0) //両方0回の場合
				{
					dataGridView_Main.Rows.Add(num_add, m_classlist[i], 0, 0, 0, 0, 0, 0, 0, 0, 0);
				}
				else if (numfirst == 0) //先攻0回の場合
				{
					dataGridView_Main.Rows.Add(num_add, m_classlist[i], 0, 0, 0
						   , winsecond_now, losesecond_now, ((double)winsecond_now / numsecond), winsecond_now, losesecond_now, ((double)winsecond_now / numsecond));

				}
				else //後攻0回の場合
				{
					dataGridView_Main.Rows.Add(num_add, m_classlist[i], winfirst_now, losefirst_now, ((double)winfirst_now / numfirst)
						, 0, 0, 0, winfirst_now, losefirst_now, ((double)winfirst_now / numfirst));
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

			if(numfirst+numsecond!=0)
			{
				allper = Math.Round(((num_numwinfirst + num_numwinsecond) * 100.0 / (numfirst + numsecond)), 2, MidpointRounding.AwayFromZero);
			}
			dataGridView_Main.Rows.Add(num_add, "計", num_numwinfirst, num_numlosefirst, firstper
						, num_numwinsecond, num_numlosesecond, secondper, num_numwinfirst+ num_numwinsecond, num_numlosefirst+ num_numlosesecond, allper);
		}


		public void WinLoseCount(ArrayList array, string[] readstr, int mode)
		{
			//添字を、クラスによってかランクによってか等と分けて書くと先行後攻勝敗×クラスランクデッキで、4*3個同じようなのを書く必要になるからこっちに纏めておく
			switch(mode)
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

				}
				break;
			default:
				{

				}
				break;
			}
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

	};


}
