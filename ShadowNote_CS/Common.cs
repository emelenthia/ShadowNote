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


		public int GetRankNumber(string str, int mode) //ランクを低い方から数えた際の順番を取得。配列の添字に使う。細かいモードと大雑把モードが有る
		{

			int ret = 0;
			if (mode == 0) //細かいモード
			{
				switch (str)
				{
				case "フリー":
					ret = 0;
					break;
				case "Begginer0":
					ret = 1;
					break;
				case "Beginner1":
					ret = 2;
					break;
				case "Beginner2":
					ret = 3;
					break;
				case "Beginner3":
					ret = 4;
					break;
				case "D0":
					ret = 5;
					break;
				case "D1":
					ret = 6;
					break;
				case "D2":
					ret = 7;
					break;
				case "D3":
					ret = 8;
					break;
				case "C0":
					ret = 9;
					break;
				case "C1":
					ret = 10;
					break;
				case "C2":
					ret = 11;
					break;
				case "C3":
					ret = 12;
					break;
				case "B0":
					ret = 13;
					break;
				case "B1":
					ret = 14;
					break;
				case "B2":
					ret = 15;
					break;
				case "B3":
					ret = 16;
					break;
				case "A0":
					ret = 17;
					break;
				case "A1":
					ret = 18;
					break;
				case "A2":
					ret = 19;
					break;
				case "A3":
					ret = 20;
					break;
				case "AA0":
					ret = 21;
					break;
				case "AA1":
					ret = 22;
					break;
				case "AA2":
					ret = 23;
					break;
				case "AA3":
					ret = 24;
					break;
				case "Master":
					ret = 25;
					break;
				default:
					ret = -1;
					break;
				}
			}
			else //大雑把モード
			{
				switch (str)
				{
				case "フリー":
					ret = 0;
					break;
				case "A0":
					ret = 2;
					break;
				case "A1":
					ret = 3;
					break;
				case "A2":
					ret = 4;
					break;
				case "A3":
					ret = 5;
					break;
				case "AA0":
					ret = 6;
					break;
				case "AA1":
					ret = 7;
					break;
				case "AA2":
					ret = 8;
					break;
				case "AA3":
					ret = 9;
					break;
				case "Master":
					ret = 10;
					break;
				default: //それ以外ならA未満
					ret = 1;
					break;
				}
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


		//DateTimeを8桁の日付か6桁の時刻の文字列にして返す
		public const int COM_DATE_DAY = 0;
		public static readonly int COM_DATE_TIME = 1;
		public String FormatTime(DateTime dt, int mode)
		{
			String ret_str;
			if(mode==COM_DATE_DAY)
			{
				String month = dt.Month.ToString();
				AddZeroTime(month);
				String day = dt.Day.ToString();
				AddZeroTime(day);
				ret_str = dt.Year.ToString() + month + day;
			}
			else if(mode==COM_DATE_TIME)
			{
				String hour = dt.Hour.ToString();
				AddZeroTime(hour);
				String minute = dt.Minute.ToString();
				AddZeroTime(minute);
				String second = dt.Second.ToString();
				AddZeroTime(second);
				ret_str = hour + minute + second;
			}
			else
			{
				return "error in FormatTime.";
			}

			return ret_str;
		}

		//処理しやすいように一桁なら0を付ける
		public void AddZeroTime(String time)
		{
			if (int.Parse(time) < 10)
			{
				time = "0" + time;
			}
		}

		public DateTime MakeDateTime(String _day,String _time) //8桁の日付と6桁の時刻からDateTime構造体を作成します
		{
			DateTime ret_dt;
			int year = int.Parse(_day.Substring(0, 4));
			int month = int.Parse(_day.Substring(4, 2));
			int day = int.Parse(_day.Substring(6, 2));

			int hour = int.Parse(_time.Substring(0, 2));
			int minute = int.Parse(_time.Substring(2, 2));
			int second = int.Parse(_time.Substring(4, 2));

			ret_dt = new DateTime(year, month, day, hour, minute, second);

			return ret_dt;
		}

	}

}
