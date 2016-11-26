using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections; //ArrayList用
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShadowNote_CS
{
	public partial class Form1 : Form
	{
		private const int numclass = 7;
		private ArrayList[] m_ene_decklist;
		private ArrayList m_mydeckclass; //自分の各デッキに対応するクラスを保存
		private Timer m_timer;
		private Common m_com;

        public Form1()
		{
			InitializeComponent();
		}

		private void button_Add_Click(object sender, EventArgs e)
		{
			//選択されていないコントロールがないか確認し、無ければ情報をファイルに書き込む
			//まずはチェック

			using (StreamWriter sw = new StreamWriter("BattleLog.log", true))
			{
				String writestr;
				Common com = new Common();
				//各種コントロールから保存する文章を作成
				//自クラス,自デッキ名,相手クラス,相手デッキ名,勝敗(w or l),先攻後攻(f or s or n),ランク,(日付)20160912,(時刻)163855
				//デッキ名からクラスを取得する

				writestr = (string)m_mydeckclass[comboBox_MyDec.SelectedIndex];
				writestr += "," + comboBox_MyDec.Text;
				writestr += "," + com.ChangeClassName(comboBox_EneClass.Text);
				writestr += "," + comboBox_EneDec.Text;
				writestr += "," + (comboBox_Winlose.Text=="勝利" ? "w" : "l");
				writestr += "," + (comboBox_FirstSecond.Text != "忘れた" ? (comboBox_FirstSecond.Text != "先攻" ? "s" : "f") : "n");
				writestr += "," + comboBox_Rank.Text;

				DateTime dt = DateTime.Now;
				writestr += "," + m_com.FormatTime(dt, Common.COM_DATE_DAY);
				writestr += "," + m_com.FormatTime(dt, Common.COM_DATE_TIME);

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


		private void Form1_Load(object sender, EventArgs e)
		{
			//各変数の初期化
			m_com = new Common();
			m_ene_decklist = new ArrayList[numclass];
			for(int i=0;i< numclass;i++)
			{
				m_ene_decklist[i] = new ArrayList();
			}
			m_mydeckclass = new ArrayList();

			//各コントロールの初期化処理はここに書く
			m_com.DeckListLoad(comboBox_MyDec, comboBox_EneDec, m_ene_decklist, m_mydeckclass);
			m_com.SetClassList(comboBox_EneClass);
			SetFirstSecond();
			SetRankList();
			SetWinLose();
		}

		private void SetFirstSecond()
		{
			comboBox_FirstSecond.Items.Add("先攻");
			comboBox_FirstSecond.Items.Add("後攻");
			comboBox_FirstSecond.Items.Add("忘れた");
			comboBox_FirstSecond.SelectedIndex = 0;
			comboBox_FirstSecond.Update();
		}

		private void SetWinLose()
		{
			comboBox_Winlose.Items.Add("勝利");
			comboBox_Winlose.Items.Add("敗北");
			comboBox_Winlose.SelectedIndex = 0;
			comboBox_Winlose.Update();
		}

		private void SetRankList()
		{
			comboBox_Rank.Items.Add("フリー");
			comboBox_Rank.Items.Add("Beginner0");
			comboBox_Rank.Items.Add("Beginner1");
			comboBox_Rank.Items.Add("Beginner2");
			comboBox_Rank.Items.Add("Beginner3");
			comboBox_Rank.Items.Add("D0");
			comboBox_Rank.Items.Add("D1");
			comboBox_Rank.Items.Add("D2");
			comboBox_Rank.Items.Add("D3");
			comboBox_Rank.Items.Add("C0");
			comboBox_Rank.Items.Add("C1");
			comboBox_Rank.Items.Add("C2");
			comboBox_Rank.Items.Add("C3");
			comboBox_Rank.Items.Add("B0");
			comboBox_Rank.Items.Add("B1");
			comboBox_Rank.Items.Add("B2");
			comboBox_Rank.Items.Add("B3");
			comboBox_Rank.Items.Add("A0");
			comboBox_Rank.Items.Add("A1");
			comboBox_Rank.Items.Add("A2");
			comboBox_Rank.Items.Add("A3");
			comboBox_Rank.Items.Add("AA0");
			comboBox_Rank.Items.Add("AA1");
			comboBox_Rank.Items.Add("AA2");
			comboBox_Rank.Items.Add("AA3");
			comboBox_Rank.Items.Add("Master");
			comboBox_Rank.SelectedIndex = 0;
			comboBox_Rank.Update();
		}

		private void comboBox_EneClass_SelectedIndexChanged(object sender, EventArgs e)
		{
			comboBox_EneDec.Items.Clear();
			int classnumber = m_com.GetClassNumber(comboBox_EneClass.Text);
			int numdeck = m_ene_decklist[classnumber].Count;
			for (int i = 0; i < numdeck; i++)
			{
				comboBox_EneDec.Items.Add(m_ene_decklist[classnumber][i]);
			}
			if (comboBox_EneDec.Items.Count > 0)
			{
				comboBox_EneDec.SelectedIndex = 0;
			}
			comboBox_EneDec.Update();
		}
		
		private void button_DeckAdd_Click(object sender, EventArgs e)
		{
			DeckAdd deckadd = new DeckAdd();
			deckadd.ShowDialog(this);
			deckadd.Dispose();
			m_com.DeckListLoad(comboBox_MyDec, comboBox_EneDec, m_ene_decklist, m_mydeckclass);
		}
		

		private void button_LogAna_Click(object sender, EventArgs e)
		{
			LogAna logana = new LogAna();
			logana.Show(this); //モードレスダイアログではdispose()を呼び出す必要がない
		}

		private void button_FileShow_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process P = System.Diagnostics.Process.Start("BattleLog.log");
        }
	}
}
