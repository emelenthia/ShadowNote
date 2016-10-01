using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections; //ArrayList用
using System.Windows.Forms;

namespace ShadowNote_CS
{

	class Common
	{
		public const int numclass = 7;

		public String ChangeClassName(String classname)
		{
			String return_str;
			switch (classname)
			{
			case "エルフ":
				return_str = "e";
				break;
			case "ロイヤル":
				return_str = "r";
				break;
			case "ウィッチ":
				return_str = "w";
				break;
			case "ドラゴン":
				return_str = "d";
				break;
			case "ネクロマンサー":
				return_str = "n";
				break;
			case "ヴァンパイア":
				return_str = "v";
				break;
			case "ビショップ":
				return_str = "b";
				break;
			case "e":
				return_str = "エルフ";
				break;
			case "r":
				return_str = "ロイヤル";
				break;
			case "w":
				return_str = "ウィッチ";
				break;
			case "d":
				return_str = "ドラゴン";
				break;
			case "n":
				return_str = "ネクロマンサー";
				break;
			case "v":
				return_str = "ヴァンパイア";
				break;
			case "b":
				return_str = "ビショップ";
				break;
			default:
				return_str = "エラー。クラス名がおかしいです";
				break;
			}
			return return_str;
		}

		public void SetClassList(ComboBox cb)
		{
			cb.Items.Add("エルフ");
			cb.Items.Add("ロイヤル");
			cb.Items.Add("ウィッチ");
			cb.Items.Add("ドラゴン");
			cb.Items.Add("ネクロマンサー");
			cb.Items.Add("ヴァンパイア");
			cb.Items.Add("ビショップ");
			cb.SelectedIndex = 0;
			cb.Update();
		}


		public int GetClassNumber(string str) //クラスを上から数えた際の順番を取得。配列の添字に使う
		{
			int ret = 0;
			switch (str)
			{
			case "エルフ":
			case "e":
				ret = 0;
				break;
			case "ロイヤル":
			case "r":
				ret = 1;
				break;
			case "ウィッチ":
			case "w":
				ret = 2;
				break;
			case "ドラゴン":
			case "d":
				ret = 3;
				break;
			case "ネクロマンサー":
			case "n":
				ret = 4;
				break;
			case "ヴァンパイア":
			case "v":
				ret = 5;
				break;
			case "ビショップ":
			case "b":
				ret = 6;
				break;
			default:
				ret = -1;
				break;
			}
			return ret;
		}


		//DeckList.txtからデッキリストを読み込む
		public void DeckListLoad(ComboBox comboBox_MyDec,ComboBox comboBox_EneDec, ArrayList[] ene_decklist, ArrayList mydeckclass)
		{
			//ファイルから情報を読み込む
			using (StreamReader sr = new StreamReader("DeckList.txt"))
			{
				comboBox_MyDec.Items.Clear();
				for (int i = 0; i < numclass; i++)
				{
					ene_decklist[i].Clear();
				}

				String[] readstr;

				while (sr.EndOfStream == false) //EOFならtrueっぽいよ
				{
					readstr = sr.ReadLine().Split(',');
					if (readstr[0] == "m")
					{
						//読み込んだデッキが自分の時
						comboBox_MyDec.Items.Add(readstr[2]);
						mydeckclass.Add(readstr[1]);
					}
					else
					{
						//相手の時はクラス別に保存して、クラスが変わる毎に登録する
						ene_decklist[GetClassNumber(readstr[1])].Add(readstr[2]);
					}
				}
			}

			if (comboBox_MyDec.Items.Count > 0)//何も入っていないコントロールのインデックスを設定しようとするとそこでエラーで中断されるっぽい
			{
				comboBox_MyDec.SelectedIndex = 0;
			}
			comboBox_MyDec.Update();
			comboBox_EneDec.Update();
		}

	}

}
