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
		int[] m_numwinfirst_class;
		int[] m_numlosefirst_class;
		int[] m_numwinsecond_class;
		int[] m_numlosesecond_class;
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

			Analysising();

			m_com.DeckListLoad(comboBox_Mydec, comboBox_Enedec, m_ene_decklist, m_mydeckclass);
			m_com.SetClassList(comboBox_Eneclass);
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
			Analysising();
		}

		private void Analysising(int mode) //0…class毎、1…Rank毎、2…deck毎
		{
			m_numwinfirst_class = new int[7];
			m_numlosefirst_class = new int[7];
			m_numwinsecond_class = new int[7];
			m_numlosesecond_class = new int[7];

			String[] m_classlist = { "ロイヤル", "エルフ", "ウィッチ", "ドラゴン", "ネクロマンサー", "ヴァンパイア", "ビショップ" };

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
							m_numwinfirst_class[m_com.GetClassNumber(readstr[2])]++;
						}
						else
						{
							m_numwinsecond_class[m_com.GetClassNumber(readstr[2])]++;
						}
					}
					else
					{
						if (readstr[5] == "f")
						{
							m_numlosefirst_class[m_com.GetClassNumber(readstr[2])]++;
						}
						else
						{
							m_numlosesecond_class[m_com.GetClassNumber(readstr[2])]++;
						}
					}
				}
			}

			int numfirst = 0;
			int numsecond = 0;
			double firstper = 0; //四捨五入する為に
			double secondper = 0;
			double allper = 0;
			int num_numwinfirst_class = 0;
			int num_numlosefirst_class = 0;
			int num_numwinsecond_class = 0;
			int num_numlosesecond_class = 0;
			int num_add = 1;

			dataGridView_Main.Rows.Clear();

            for (int i = 0; i < 7; i++)
			{
				//先攻後攻の勝負数を計算して、0回の場合は0除算を回避する
				numfirst = m_numwinfirst_class[i] + m_numlosefirst_class[i];
				numsecond = m_numwinsecond_class[i] + m_numlosesecond_class[i];

				//ID,クラス名,先攻勝数,先攻敗数,先攻勝率,後攻勝数,後攻敗数,後攻勝率,,
				if (numfirst + numsecond != 0) //両方0回でない場合
				{
					firstper = (double)Math.Round((double)m_numwinfirst_class[i] * 100 / numfirst, 2, MidpointRounding.AwayFromZero);
					secondper = (double)Math.Round(((double)m_numwinsecond_class[i] * 100 / numsecond), 2, MidpointRounding.AwayFromZero);
					allper = (double)Math.Round(((double)(m_numwinfirst_class[i] + m_numwinsecond_class[i]) * 100 / (numfirst + numsecond)), 2, MidpointRounding.AwayFromZero);

					dataGridView_Main.Rows.Add(num_add, m_classlist[i], m_numwinfirst_class[i], m_numlosefirst_class[i], firstper
						, m_numwinsecond_class[i], m_numlosesecond_class[i], secondper, m_numwinfirst_class[i]+ m_numwinsecond_class[i], m_numlosefirst_class[i] + m_numlosesecond_class[i], allper);
				}
				else if (numfirst + numsecond == 0) //両方0回の場合
				{
					dataGridView_Main.Rows.Add(num_add, m_classlist[i], 0, 0, 0, 0, 0, 0, 0, 0, 0);
				}
				else if (numfirst == 0) //先攻0回の場合
				{
					dataGridView_Main.Rows.Add(num_add, m_classlist[i], 0, 0, 0
						   , m_numwinsecond_class[i], m_numlosesecond_class[i], ((double)m_numwinsecond_class[i] / numsecond), m_numwinsecond_class[i], m_numlosesecond_class[i], ((double)m_numwinsecond_class[i] / numsecond));

				}
				else //後攻0回の場合
				{
					dataGridView_Main.Rows.Add(num_add, m_classlist[i], m_numwinfirst_class[i], m_numlosefirst_class[i], ((double)m_numwinfirst_class[i] / numfirst)
						, 0, 0, 0, m_numwinfirst_class[i], m_numlosefirst_class[i], ((double)m_numwinfirst_class[i] / numfirst));
				}

				//合計を出す
				num_numwinfirst_class += m_numwinfirst_class[i];
				num_numlosefirst_class += m_numlosefirst_class[i];
				num_numwinsecond_class += m_numwinsecond_class[i];
				num_numlosesecond_class += m_numlosesecond_class[i];
				num_add++;
			}

			//上手く合計出せないのかな
			numfirst = num_numwinfirst_class + num_numlosefirst_class;
			if (numfirst != 0)
			{
				firstper = (double)Math.Round((double)num_numwinfirst_class * 100 / numfirst, 2, MidpointRounding.AwayFromZero);
			}
			else
			{
				firstper = 0;
			}

			numsecond = num_numwinsecond_class + num_numlosesecond_class;
			if (numsecond != 0)
			{
				secondper = (double)Math.Round(((double)num_numwinsecond_class * 100 / numsecond), 2, MidpointRounding.AwayFromZero);
			}

			if(numfirst+numsecond!=0)
			{
				allper = (double)Math.Round(((double)(num_numwinfirst_class + num_numwinsecond_class) * 100 / (numfirst + numsecond)), 2, MidpointRounding.AwayFromZero);
			}
			dataGridView_Main.Rows.Add(num_add, "計", num_numwinfirst_class, num_numlosefirst_class, firstper
						, num_numwinsecond_class, num_numlosesecond_class, secondper, num_numwinfirst_class+ num_numwinsecond_class, num_numlosefirst_class+ num_numlosesecond_class, allper);
		}
    }
}
