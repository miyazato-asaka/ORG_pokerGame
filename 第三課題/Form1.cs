using System;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.VisualStyles;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Specialized;
using System.Threading;

namespace 第三課題
{
    public partial class Poker : Form
    {
        #region "デザイナーサポートメソッド"
        public Poker()
        {
            InitializeComponent();
        }
        #endregion

        #region 定数：パス定義
        /// <summary>
        /// 定数
        /// </summary>
        static class PathConclusion
        {
            public const string folderPath = @"../../../trump";
        }
        #endregion

        #region 定数：ファイル形式定義
        /// <summary>
        /// 定数
        /// </summary>
        public class FileExtensions
        {
            public const string Jpg = ".jpg";
            public const string Jpeg = ".jpeg";
            public const string Png = ".png";
            public const string Gif = ".gif";
        }

        #endregion

        #region 定数：役
        /// <summary>
        /// 定数
        /// </summary>
        public static class RoleMappings
        {
            public static Dictionary<int, string> RoleDictionary { get; } = new Dictionary<int, string>
            {
                { 0, "ハイカード" },
                { 1, "ワンペア" },
                { 2, "ツーペア" },
                { 3, "スリーカード" },
                { 4, "ストレート" },
                { 5, "フラッシュ" },
                { 6, "フルハウス" },
                { 7, "フォーカード" },
                { 8, "☆彡ストレートフラッシュ" },
                { 9, "ミ☆ロイヤルストレートフラッシュ☆彡" }
            };
        }
        #endregion

        #region メソッド：役判定
        public void RoleDecision(ref string[] fileNames, ref string message)
        {
            //ファイル名を_の前後で分ける（前：記号、後：数字）
            var role = RoleMappings.RoleDictionary;
            string cardSymbol = "";
            string cardNumber = "";
            var symbolList = new List<string>();
            var numberList = new List<string>();

            // アンダーバーの後ろの数字を基準に昇順で並べ替え
            fileNames = fileNames.OrderBy(n =>
            {
                int v = 0;
                if (int.TryParse(Path.GetFileNameWithoutExtension(n).Split('_')[1], out v))
                {
                    return v;
                }
                return int.MaxValue; // 数字でないファイル名は一番後ろになるように
            }).ToArray();
            for (int i = 0; i < 5; i++)
            {
                cardSymbol = (fileNames[i].Split('_')[0]).ToString();//前半
                cardNumber = (fileNames[i].Split('_')[1]).ToString();//後半
                symbolList.Add(cardSymbol); //手札の記号を集めたList
                numberList.Add(cardNumber); //手札の数字を集めたList
                continue;
            }
            int duplicationCount = 0;　　　//数字が重複しているかカウント
            int duplicationSymbolCount = 0; //記号が重複してるかカウント
            string startNum = numberList[0];
            string endNum = numberList[4];
            string[] straightNumBox = new string[5];
            bool isStraight = false;

            //役を判定
            //同じ記号がいくつそろったか（数字関係なし）
            var duplicationSymbolList = symbolList
                                        .GroupBy(i => i)
                                        .Where(g => g.Count() > 1)
                                        .Select(g => new { number = g.Key, duplicationCount = g.Count() - 1 })
                                        .ToList();
            //同じ数字がいくつそろったか（記号関係なし）
            var duplicationNumList = numberList
                                    .GroupBy(i => i)
                                    .Where(g => g.Count() > 1)
                                    .Select(g => new { number = g.Key, duplicationCount = g.Count() })
                                    .ToList();
            int count = duplicationNumList.Count;
            // 重複要素(記号)をカウントしてDictionaryに格納する
            foreach (var item in duplicationSymbolList)
            {
                duplicationSymbolCount = item.duplicationCount;
                continue;
            }
            // 重複要素(数字)をカウントしてDictionaryに格納する
            foreach (var item in duplicationNumList)
            {
                duplicationCount = item.duplicationCount;
                continue;
            }
            //ストレート
            //最初の番号を格納して、5回連続だったらストレート
            straightNumBox[0] = startNum;
            // 連続した数値を生成
            for (int i = 1; i <= 4; i++)
            {
                int frontNum = int.Parse(straightNumBox[i - 1]);
                int nextValue = frontNum + 1;

                // 14以上の場合は1から数え直す
                if (nextValue > 13)
                {
                    nextValue = 1;
                }
                straightNumBox[i] = nextValue.ToString();
            }
            //配列同士を比べる(ストレートなら見本straightNumBoxと同じになるはず)
            if (straightNumBox.SequenceEqual(numberList) || numberList[0] == "1" && numberList[1] == "10" && numberList[2] == "11" && numberList[3] == "12" && numberList[4]=="13")
            {
                isStraight = true;
                inOutBox.Text = role[4];
                message = inOutBox.Text;
            }
            //ロイヤルストレートフラッシュ　or 　ストレートフラッシュ
            if ((duplicationSymbolCount == 4) && isStraight)
            {
                //ストレートの先頭の番号が10だったら
                if (numberList[0] == "1" && numberList[1] == "10" && numberList[2] == "11" && numberList[3] == "12" && numberList[4] == "13")
                {
                    //ロイヤルストレートフラッシュ
                    inOutBox.Text = role[9];
                    message = inOutBox.Text;
                }
                else
                {
                    //ストレートフラッシュ
                    inOutBox.Text = role[8];
                    message = inOutBox.Text;
                }
            }
            //フラッシュ
            if (duplicationSymbolCount == 4 && !isStraight)
            {
                inOutBox.Text = role[5];
                message = inOutBox.Text;
            }
            //フルハウス（個数の最大が３で、ペアが2つ存在したら）
            if (duplicationNumList.Count() == 2 && (duplicationNumList[0].duplicationCount == 3 && duplicationNumList[1].duplicationCount == 2 || duplicationNumList[0].duplicationCount == 2 && duplicationNumList[1].duplicationCount == 3))
            {
                inOutBox.Text = role[6];
                message = inOutBox.Text;

            };
            //その他判定 上記で定まらなかった場合だけでよい
            if (message == "")
            {
                switch (duplicationCount)
                {
                    case 4:
                        inOutBox.Text = role[7];
                        message = inOutBox.Text;
                        break;
                    case 3:
                        inOutBox.Text = role[3];
                        message = inOutBox.Text;
                        break;
                }
            }
            if (message == "")
            {
                switch (count)
                {
                    case 2:
                        inOutBox.Text = role[2];
                        message = inOutBox.Text;
                        break;
                    case 1:
                        inOutBox.Text = role[1];
                        message = inOutBox.Text;
                        break;
                    default:
                        inOutBox.Text = role[0];
                        message = inOutBox.Text;
                        break;
                }
            }
        }
        #endregion

        #region "フォームロード"
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        #endregion

        //初期画面
        int countNum = 3;
        PictureBox pictureBox = new PictureBox();
        CheckBox checkBox = new CheckBox();
        int lineNumber = 0; // 行番号
        List<string[]> dataRows = new List<string[]>();// データを保持するリスト
        HashSet<string> selectedFiles = new HashSet<string>();
        #region イベントハンドラ

        #region startBtn(開始ボタン)
        private void startBtn_Click(object sender, EventArgs e)
        {
            try
            {

                // checkboxリセット
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                // checkbox活性化
                checkBox1.Enabled = true;
                checkBox2.Enabled = true;
                checkBox3.Enabled = true;
                checkBox4.Enabled = true;
                checkBox5.Enabled = true;
                //カウント表示
                countNum = 3;
                string[] extensions = { FileExtensions.Jpg, FileExtensions.Jpeg, FileExtensions.Png, FileExtensions.Gif };
                var random = new Random();
                selectedFiles = new HashSet<string>(); // 重複を防ぐためのセット

                remCountNum.Text = countNum.ToString();
                //ボタン活性化
                endBtn.Enabled = true;
                allSelectBtn.Enabled = true;
                changeBtn.Enabled = true;
                //ボタン非活性化
                startBtn.Enabled = false;
                //ランダムにカードをセット5枚　　ここから
                while (selectedFiles.Count < 5)
                {
                    var file = Directory.GetFiles(PathConclusion.folderPath, "*.*", SearchOption.AllDirectories)
                                        .Where(f => extensions.Contains(Path.GetExtension(f)))
                                        .OrderBy(f => random.Next())
                                        .FirstOrDefault(f => !selectedFiles.Contains(f));
                    selectedFiles.Add(file);
                }
                for (int i = 1; i <= 5; i++)
                {
                    PictureBox pictureBox = (PictureBox)this.Controls.Find("pictureBox" + i, true)[0];
                    pictureBox.ImageLocation = selectedFiles.ElementAt(i - 1);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                //ランダムにカードをセット5枚　ここまで
                //デバックモードON
                if (inOutBox.Text == "debug")
                {
                    MessageBox.Show("これより開発者モードに切り替わります。");
                    //ボタン表示
                    debugStartBtn.Visible = true;
                    debugEndBtn.Visible = true;
                    //ドロップボックス表示
                    cardOptionBox1.Visible = true;
                    cardOptionBox2.Visible = true;
                    cardOptionBox3.Visible = true;
                    cardOptionBox4.Visible = true;
                    cardOptionBox5.Visible = true;
                    //ボタン非表示
                    startBtn.Visible = false;
                    endBtn.Visible = false;
                    allSelectBtn.Visible = false;
                    changeBtn.Visible = false;
                    //checkbox非表示
                    checkBox1.Visible = false;
                    checkBox2.Visible = false;
                    checkBox3.Visible = false;
                    checkBox4.Visible = false;
                    checkBox5.Visible = false;
                }
                inOutBox.Text = "";
            }
            catch
            {
                Error form3 = new Error();
                form3.Show();
            }
        }
        #endregion

        #region endBtn(終了ボタン)
        private void endBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string message = "";
                string[] fileNames = new string[5];
                // DataTableを宣言する
                DataTable dt = new DataTable();
                //ボタン活性化
                startBtn.Enabled = true;
                //ボタン非活性化
                endBtn.Enabled = false;
                allSelectBtn.Enabled = false;
                changeBtn.Enabled = false;
                // checkbox活性化
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                //画像を取得する
                for (int i = 0; i < 5; i++)
                {
                    pictureBox = (PictureBox)Controls.Find("pictureBox" + (i + 1), true)[0];
                    fileNames[i] = Path.GetFileNameWithoutExtension(pictureBox.ImageLocation);
                    continue;
                }
                //役判定
                RoleDecision(ref fileNames, ref message);
                //出力
                // 10回以上だと古いものから順に上書きする
                if (lineNumber <= 9)
                {
                    lineNumber++; // 行番号をインクリメント
                    // データを出力
                    dataGridView1.Rows.Add(lineNumber, fileNames[0], fileNames[1], fileNames[2], fileNames[3], fileNames[4], message);
                    // データをリストに追加
                    dataRows.Add(new string[] { lineNumber.ToString(), fileNames[0], fileNames[1], fileNames[2], fileNames[3], fileNames[4], message });
                }
                else
                {
                    if (lineNumber == 10)
                    {
                        MessageBox.Show("記録は10回までしか保持できません。これより先は古いものから順に上書きになります。");
                    }
                    lineNumber++; // 行番号をインクリメント
                    // 一番古いデータを削除
                    dataGridView1.Rows.RemoveAt(0);
                    // 新しいデータをリストの先頭に追加
                    dataRows.RemoveAt(0);
                    dataRows.Add(new string[] { lineNumber.ToString(), fileNames[0], fileNames[1], fileNames[2], fileNames[3], fileNames[4], message });

                    // リストのデータをdataGridView1に再設定
                    dataGridView1.Rows.Clear();
                    foreach (var row in dataRows)
                    {
                        dataGridView1.Rows.Add(row);
                    }
                }
            }
            catch
            {
                Error form3 = new Error();
                form3.Show();
            }
        }
        #endregion

        #region handListBtn(ハンドリストボタン)
        private void handListBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Handlist form2 = new Handlist();
                form2.Show();
            }
            catch
            {
                Error form3 = new Error();
                form3.Show();
            }
        }
        #endregion

        #region allSelectBtn(全選択/全解除ボタン)
        private void allSelectBtn_Click(object sender, EventArgs e) //全選択/解除
        {
            try
            {
                // すべてのチェックボックスがチェックされているかどうかを判定
                bool allChecked = true;
                for (int i = 1; i <= 5; i++)
                {
                    checkBox = (CheckBox)this.Controls.Find("checkBox" + i, true)[0];
                    if (!checkBox.Checked)
                    {
                        allChecked = false;
                        break;
                    }
                }

                // 条件に応じてチェックを付けたり外したり
                for (int i = 1; i <= 5; i++)
                {
                    checkBox = (CheckBox)this.Controls.Find("checkBox" + i, true)[0];
                    if (allChecked)
                    {
                        // すべてチェックされている場合はチェックを外す
                        checkBox.Checked = false;
                    }
                    else
                    {
                        // すべてチェック外れている場合はチェックを付ける
                        checkBox.Checked = true;
                    }
                }
            }
            catch
            {
                Error form3 = new Error();
                form3.Show();
            }
        }
        #endregion

        #region changeBtn(手札を変更)
        private void changeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int checkCount = 0;
                checkCount = 0;
                // ランダムにカードをセット5枚
                string[] extensions = { FileExtensions.Jpg, FileExtensions.Jpeg, FileExtensions.Png, FileExtensions.Gif };
                var random = new Random();

                for (int i = 1; i <= 5; i++)
                {
                    checkBox = (CheckBox)this.Controls.Find("checkBox" + i, true)[0];
                    pictureBox = (PictureBox)Controls.Find("pictureBox" + i, true)[0];
                    if (checkBox.Checked)
                    {
                        checkCount++;
                        // そのカードにチェックがついている
                        var file = Directory.GetFiles(PathConclusion.folderPath, "*.*", SearchOption.AllDirectories)
                                            .Where(f => extensions.Contains(Path.GetExtension(f)))
                                            .OrderBy(f => random.Next())
                                            .FirstOrDefault(f => !selectedFiles.Contains(f));
                        selectedFiles.Add(file);
                        // ランダムに選ばれた画像をPictureBoxに合わせて表示
                        pictureBox.ImageLocation = file;
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                //まだ手札を替えられるなら残回数を表示、そうでなければ0を表示（ボタン非活性化）
                if (checkCount > 0)
                {
                    if (countNum > 1)
                    {
                        countNum--; // 残り回数を減らす
                        remCountNum.Text = countNum.ToString();
                    }
                    else
                    {
                        remCountNum.Text = "0";
                        changeBtn.Enabled = false;
                        allSelectBtn.Enabled = false;
                    }
                }
                //cardの数だけCheckboxのチェックをリセット
                for (int i = 1; i <= 5; i++)
                {
                    CheckBox checkBox = (CheckBox)this.Controls.Find("checkBox" + i, true)[0];
                    checkBox.Checked = false;
                }
            }
            catch
            {
                Error form3 = new Error();
                form3.Show();
            }
        }
        #endregion

        # region debugStartBtn(デバック開始ボタン)
        private void debugStartBtn_Click(object sender, EventArgs e)
        {
            try
            {
                debugEndBtn.Enabled = true;
                debugStartBtn.Enabled = false;
                int checkCount = 0;
                string[] extensions = { FileExtensions.Jpg, FileExtensions.Jpeg, FileExtensions.Png, FileExtensions.Gif };
                string[] selectedValues = new string[5];
                string[] fileNames = new string[5];

                for (int i = 1; i <= 5; i++)
                {
                    //画像を取得する
                    pictureBox = (PictureBox)Controls.Find("pictureBox" + (i), true)[0];
                    fileNames[i - 1] = Path.GetFileNameWithoutExtension(pictureBox.ImageLocation);
                }

                for (int i = 1; i <= 5; i++)
                {
                    //1つ以上変換がある
                    System.Windows.Forms.ComboBox cardOptionBox = (System.Windows.Forms.ComboBox)this.Controls.Find("cardOptionBox" + i, true)[0];
                    if (cardOptionBox.SelectedItem != null || !string.IsNullOrEmpty(cardOptionBox.Text))
                    {
                        string selectedValue = cardOptionBox.SelectedItem.ToString();
                        string[] selectFiles = Directory.GetFiles(PathConclusion.folderPath, "*.*", SearchOption.AllDirectories)
                                               .Where(file => extensions.Contains(Path.GetExtension(file)))
                                               .Where(file => Path.GetFileNameWithoutExtension(file) == selectedValue)
                                               .ToArray();
                        //選択された値と既に出ている手札の中に同じものがあるかどうか
                        int result = Array.IndexOf(fileNames, selectedValue);
                        if (cardOptionBox.SelectedIndex != -1)
                        {
                            checkCount++;
                            // 重複チェック
                            if (selectedValues.Contains(selectedValue) || result != -1)
                            {
                                MessageBox.Show("エラー：選択したカードが重複しています。重複しないように選んでください。");
                                cardOptionBox.SelectedIndex = -1;  // カードの変更を行わない
                            }
                            else
                            {
                                pictureBox = (PictureBox)Controls.Find("pictureBox" + (i), true)[0];
                                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                                pictureBox.ImageLocation = selectFiles.FirstOrDefault(file => Path.GetFileNameWithoutExtension(file) == selectedValue);
                                selectedValues[checkCount - 1] = selectedValue;
                            }
                        }
                        continue;
                    }
                }
                //コンボボックスのリセット
                for (int i = 1; i <= 5; i++)
                {
                    System.Windows.Forms.ComboBox cardOptionBox = (System.Windows.Forms.ComboBox)this.Controls.Find("cardOptionBox" + i, true)[0];
                    cardOptionBox.SelectedIndex = -1;
                }

                //デバックモードON
                if (inOutBox.Text == "normal")
                {
                    MessageBox.Show("これより通常モードに切り替わります。");
                    inOutBox.Text = "";
                    //ボタン表示
                    debugStartBtn.Visible = false;
                    debugEndBtn.Visible = false;
                    //ドロップボックス表示
                    cardOptionBox1.Visible = false;
                    cardOptionBox2.Visible = false;
                    cardOptionBox3.Visible = false;
                    cardOptionBox4.Visible = false;
                    cardOptionBox5.Visible = false;
                    //ボタン非表示
                    startBtn.Visible = true;
                    endBtn.Visible = true;
                    allSelectBtn.Visible = true;
                    changeBtn.Visible = true;
                    //checkbox非表示
                    checkBox1.Visible = true;
                    checkBox2.Visible = true;
                    checkBox3.Visible = true;
                    checkBox4.Visible = true;
                    checkBox5.Visible = true;
                }
                inOutBox.Text = "";
            }
            catch
            {
                Error form3 = new Error();
                form3.Show();
            }
        }
        #endregion

        #region debugEndBtn(デバック終了ボタン)
        private void debugEndBtn_Click(object sender, EventArgs e)
        {
            try
            {
                debugStartBtn.Enabled = true;
                debugEndBtn.Enabled = false;
                string[] fileNames = new string[5];
                string message = "";

                // DataTableを宣言する
                DataTable dt = new DataTable();
                //画像を取得する
                for (int i = 0; i < 5; i++)
                {
                    pictureBox = (PictureBox)Controls.Find("pictureBox" + (i + 1), true)[0];
                    fileNames[i] = Path.GetFileNameWithoutExtension(pictureBox.ImageLocation);
                }
                //役判定
                RoleDecision(ref fileNames, ref message);
                //出力
                // 10回以上だと古いものから順に上書きする
                if (lineNumber <= 9)
                {
                    lineNumber++; // 行番号をインクリメント
                    // データを出力
                    dataGridView1.Rows.Add(lineNumber, fileNames[0], fileNames[1], fileNames[2], fileNames[3], fileNames[4], message);
                    // データをリストに追加
                    dataRows.Add(new string[] { lineNumber.ToString(), fileNames[0], fileNames[1], fileNames[2], fileNames[3], fileNames[4], message });
                }
                else
                {
                    if (lineNumber == 10)
                    {
                        MessageBox.Show("記録は10回までしか保持できません。これより先は古いものから順に上書きになります。");
                    }
                    lineNumber++; // 行番号をインクリメント
                    // 一番古いデータを削除
                    dataGridView1.Rows.RemoveAt(0);
                    // 新しいデータをリストの先頭に追加
                    dataRows.Add(new string[] { lineNumber.ToString(), fileNames[0], fileNames[1], fileNames[2], fileNames[3], fileNames[4], message });
                    // リストのデータをdataGridView1に再設定
                    dataGridView1.Rows.Clear();
                    foreach (var row in dataRows)
                    {
                        dataGridView1.Rows.Add(row);
                    }
                }

            }
            catch
            {
                Error form3 = new Error();
                form3.Show();
            }
        }
        #endregion

        #endregion
    }
}