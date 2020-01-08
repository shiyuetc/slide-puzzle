using System;
using System.Drawing;
using System.Windows.Forms;

namespace SlidePuzzle
{
    /// <summary>
    /// 画像の切り取りフォーム
    /// </summary>
    public partial class ImageScannerForm : Form
    {
        /// <summary>
        /// 親に渡す切り取った後の画像
        /// </summary>
        public Image TrimedImage { get; set; } = null;
        
        /// <summary>
        /// 引数で渡されるパズルの画像
        /// </summary>
        private Image OpenImage { get; set; }

        /// <summary>
        /// 引数で渡される生成するパズルのレベル
        /// </summary>
        private int Level { get; set; }
        
        /// <summary>
        /// 切り取り枠の移動フラグ
        /// </summary>
        private bool TrimLineMoveFlag { get; set; }
        
        /// <summary>
        /// 切り取り枠の移動開始位置
        /// </summary>
        private Point TrimLineMousePoint { get; set; }
        
        /// <summary>
        /// 切り取り枠の移動制御用
        /// </summary>
        private int MovedLeft { get; set; }
        private int MovedTop { get; set; }
        
        /// <summary>
        /// 切り取り枠の最大移動可能範囲
        /// </summary>
        private int MaxLeft { get; set; }
        private int MaxTop { get; set; }
        
        /// <summary>
        /// 1つ前のトラックバーの値
        /// </summary>
        private int PrevZoomDirection { get; set; } = 10;

        /// <summary>
        /// スクロールで一度に増減する幅
        /// </summary>
        private int IncreaseWidth { get; set; }
        private int IncreaseHeight { get; set; }

        /// <summary>
        /// フォームのコンストラクタ
        /// </summary>
        /// <param name="openImage">切り取る画像</param>
        /// <param name="level">パズルのレベル</param>
        public ImageScannerForm(Image openImage, int level)
        {
            this.OpenImage = openImage;
            this.Level = level;
            InitializeComponent();
        }
        
        /// <summary>
        /// フォームのロードイベント
        /// </summary>
        private void ImageScannerForm_Load(object sender, EventArgs e)
        {
            // 読み込んだ画像情報を表示
            this.OpenImagePictureBox.Image = this.OpenImage;
            this.OpenImagePictureBox.BackgroundImage = this.OpenImage;
            this.ImageSizeToolStripStatusLabel.Text = "|  画像サイズ：(横" + this.OpenImage.Width + "px, 縦" + this.OpenImage.Height + "px)";
            this.ZoomedImageSizeToolStripStatusLabel.Text = "|  拡大後の画像サイズ：(横" + this.OpenImage.Width + "px, 縦" + this.OpenImage.Height + "px)";

            // 切り取り線を表示
            this.TrimLinePictureBox.Parent = this.OpenImagePictureBox;
            this.TrimLinePictureBox.Image = new Bitmap(300, 300).DrawMeshLine(this.Level + 1, true);

            // 切り取り枠の最大移動可能範囲を設定
            this.MaxLeft = this.OpenImagePictureBox.Width - this.TrimLinePictureBox.Width;
            this.MaxTop = this.OpenImagePictureBox.Height - this.TrimLinePictureBox.Height;

            // 一度に増減する画像サイズを計算
            this.IncreaseWidth = (int)(this.OpenImage.Width * 0.05);
            this.IncreaseHeight = (int)(this.OpenImage.Height * 0.05);

            // 元画像の大きさで縮小できる回数を制限
            int divisionWidth = (this.OpenImage.Width - 300) / this.IncreaseWidth;
            int divisionHeight = (this.OpenImage.Height - 300) / this.IncreaseHeight;
            int maxSmall = (divisionWidth > divisionHeight) ? divisionHeight : divisionWidth;
            if (maxSmall < 10)
            {
                this.ZoomLevelTrackBar.Minimum = 10 - maxSmall;
            }
        }
        
        /// <summary>
        /// 拡大レベルトラックバーのスクロールイベント
        /// </summary>
        private void ZoomLevelTrackBar_Scroll(object sender, EventArgs e)
        {
            // 1つ前の値になってしまった時は更新しない
            if (this.PrevZoomDirection == this.ZoomLevelTrackBar.Value)
                return;
            this.PrevZoomDirection = this.ZoomLevelTrackBar.Value;
            
            // 画像のリサイズ
            this.OpenImagePictureBox.Image = this.OpenImage;
            this.OpenImagePictureBox.Image = this.OpenImagePictureBox.Image.Resize(
                this.OpenImagePictureBox.Image.Width + this.IncreaseWidth * (this.ZoomLevelTrackBar.Value - 10),
                this.OpenImagePictureBox.Image.Height + this.IncreaseHeight * (this.ZoomLevelTrackBar.Value - 10)
            );

            // トリム画像の最大移動範囲を更新
            this.MaxLeft = this.OpenImagePictureBox.Width - this.TrimLinePictureBox.Width;
            this.MaxTop = this.OpenImagePictureBox.Height - this.TrimLinePictureBox.Height;

            // 画像を縮小した際にトリム画像が移動範囲外の場合、強制的に移動範囲内に戻す
            if (this.TrimLinePictureBox.Left > this.MaxLeft)
                this.TrimLinePictureBox.Left = this.MaxLeft;
            if (this.TrimLinePictureBox.Top > this.MaxTop)
                this.TrimLinePictureBox.Top = this.MaxTop;

            // ラベルに反映
            this.ZoomLevelTitleLabel.Text = "拡大レベル：\r\n(" + ((this.ZoomLevelTrackBar.Value >= 10) ? "+" : "") + (this.ZoomLevelTrackBar.Value - 10) + ")";
            this.TrimLocationToolStripStatusLabel.Text = "起点座標：(" + this.TrimLinePictureBox.Left + ", " + this.TrimLinePictureBox.Top + ")";
            this.ZoomedImageSizeToolStripStatusLabel.Text = "|  拡大後の画像サイズ：(横" + this.OpenImagePictureBox.Width + "px, 縦" + this.OpenImagePictureBox.Height + "px)";
        }
        
        /// <summary>
        /// 切り取り枠のマウスダウンイベント
        /// </summary>
        private void TrimLinePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            // 切り取り枠の移動フラグをオンにする
            this.TrimLineMoveFlag = true;

            // 切り取り開始位置を記憶
            this.TrimLineMousePoint = new Point(e.X, e.Y);
        }
        
        /// <summary>
        /// 切り取り枠のマウスアップイベント
        /// </summary>
        private void TrimLinePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            // 切り取り枠の移動フラグをオフにする
            this.TrimLineMoveFlag = false;
        }
        
        /// <summary>
        /// 切り取り枠のマウスムーブイベント
        /// </summary>
        private void TrimLinePictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            // 切り取り枠の移動フラグを確認して真なら継続
            if (this.TrimLineMoveFlag)
            {
                // 移動範囲を計算
                this.MovedLeft = this.TrimLinePictureBox.Left + e.X - this.TrimLineMousePoint.X;
                if (this.MovedLeft < 0)
                    this.MovedLeft = 0;
                else if (this.MovedLeft > this.MaxLeft)
                    this.MovedLeft = this.MaxLeft;

                this.MovedTop = this.TrimLinePictureBox.Top + e.Y - this.TrimLineMousePoint.Y;
                if (this.MovedTop < 0)
                    this.MovedTop = 0;
                else if (this.MovedTop > this.MaxTop)
                    this.MovedTop = this.MaxTop;

                // 切り取り枠を実際に移動
                this.TrimLinePictureBox.Left = this.MovedLeft;
                this.TrimLinePictureBox.Top = this.MovedTop;

                // 切り取り起点座標をラベルに反映
                this.TrimLocationToolStripStatusLabel.Text = "起点座標：(" + this.TrimLinePictureBox.Left + ", " + this.TrimLinePictureBox.Top + ")";
            }
        }
        
        /// <summary>
        /// 確定ボタンのクリックイベント
        /// </summary>
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            // 切り取った画像を格納して閉じる
            this.TrimedImage = this.OpenImagePictureBox.Image.Trim(300, this.TrimLinePictureBox.Left, this.TrimLinePictureBox.Top);
            this.Close();
        }
        
        /// <summary>
        /// キャンセルボタンのクリックイベント
        /// </summary>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
