using System;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using System.Data;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 第三課題
{
    public partial class Handlist : Form
    {
        #region "デザイナーサポートメソッド"
        public Handlist()
        {
            InitializeComponent();
        }
        #endregion


        #region "フォームロード"
        private void Handlist_Load(object sender, EventArgs e)
        {

        }

        #endregion

        private void closeBtn_Click(object sender, EventArgs e)　//閉じる
        {
            this.Hide();
        }

        private void roleList_SelectedIndexChanged(object sender, EventArgs e) //役一覧
        {

            try
            {
                int value = roleList.SelectedIndex; //index番号
                string role = roleList.Text;   //中身の値
                switch (value)
                {
                    case 0: //ハイカード
                        description.Text = "何もそろっていない。役無し。、、、どんまい！！";
                        samplePicture.ImageLocation = @"../../../role_sample/hicard.png";
                        samplePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 1: //ワンペア
                        description.Text = "数位でそろえたペアが1組ある役。がんばれ！";
                        samplePicture.ImageLocation = @"../../../role_sample/1pair.png";
                        samplePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 2: //ツーペア
                        description.Text = "数位でそろえたペアが2組ある役。その調子！";
                        samplePicture.ImageLocation = @"../../../role_sample/2pair.png";
                        samplePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 3: //スリーカード
                        description.Text = "数位の札3枚をそろえた役。いい調子★";
                        samplePicture.ImageLocation = @"../../../role_sample/3card.png";
                        samplePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 4: //ストレート
                        description.Text = "5枚のカードの数位が連続してそろった役。すごい！！！";
                        samplePicture.ImageLocation = @"../../../role_sample/straight.png";
                        samplePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 5: //フラッシュ
                        description.Text = "1種類のスートだけで構成された役。いい感じ！！";
                        samplePicture.ImageLocation = @"../../../role_sample/flash.png";
                        samplePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 6: //フルハウス
                        description.Text = "同数位の札を3枚そろえ、残り2枚もペアである役。結構レア！？";
                        samplePicture.ImageLocation = @"../../../role_sample/fullhouse.png";
                        samplePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 7: //フォーカード
                        description.Text = "同数位の札4枚をすべてそろえた役。運が強いね☆彡";
                        samplePicture.ImageLocation = @"../../../role_sample/4card.png";
                        samplePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 8: //ストレートフラッシュ
                        description.Text = "1種類のスートで、5枚の数位が連続してそろった役。君は強い！！";
                        samplePicture.ImageLocation = @"../../../role_sample/straightflash.png";
                        samplePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                    case 9: //ロイヤルストレートフラッシュ
                        description.Text = "1種類のスートで、最も数位の高い5枚がそろった役。勝ち確定！？";
                        samplePicture.ImageLocation = @"../../../role_sample/loyalstraightflash.png";
                        samplePicture.SizeMode = PictureBoxSizeMode.StretchImage;
                        break;
                }
            }
            catch
            {
                Error form3 = new Error();
                form3.Show();
            }

        }
    }
}
