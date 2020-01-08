using System;
using System.Drawing;
using System.Windows.Forms;

namespace SlidePuzzle
{
    /// <summary>
    /// パズル情報を生成するフォーム
    /// </summary>
    public partial class GenerateForm : Form
    {
        /// <summary>
        /// 最終的に呼び出し元に渡すパズル情報
        /// </summary>
        public Puzzle MyPuzzle { get; set; }

        /// <summary>
        /// パズル生成に使用する画像
        /// </summary>
        private Image PuzzleImage { get; set; }

        /// <summary>
        /// フォームのコンストラクタ
        /// </summary>
        public GenerateForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 埋め込みリソースに指定されている画像を取得する
        /// </summary>
        /// <param name="path">取得するファイル名</param>
        /// <returns>取得した埋め込みリソース</returns>
        private Image GetResourceImage(string path)
        {
            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            return new Bitmap(assembly.GetManifestResourceStream("SlidePuzzle.Images." + path));
        }

        /// <summary>
        /// 選択した画像ファイルを加工して取得する
        /// </summary>
        /// <returns>加工済みの画像</returns>
        private Image LoadImage()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog
                {
                    Filter = "イメージファイル(*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|すべてのファイル(*.*)|*.*",
                    Title = "開く画像ファイルを選択してください",
                    RestoreDirectory = true
                };

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    System.IO.FileStream fs = new System.IO.FileStream(
                        ofd.FileName,
                        System.IO.FileMode.Open,
                        System.IO.FileAccess.Read
                    );
                    Image image = Image.FromStream(fs);
                    fs.Close();

                    if (image.Width < 300 || image.Height < 300)
                    {
                        MessageBox.Show("サイズが縦" + 300 + "px、横" + 300 + "px以上の画像にして！", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // スキャン用のフォームを表示
                        this.FilePathTextBox.Text = ofd.FileName;
                        ImageScannerForm form = new ImageScannerForm(image, this.LevelComboBox.SelectedIndex + 1);
                        form.Left = this.Left + (this.Width - form.Width) / 2;
                        form.Top = this.Top + (this.Height - form.Height) / 2;
                        form.ShowDialog();

                        // 確定された画像があれば返す
                        if(form.TrimedImage != null)
                            return form.TrimedImage.Resize(300);
                    }
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "使用されたパラメーターが有効ではありません。")
                {
                    MessageBox.Show("選択したファイルは対応してません。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show(ex.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return null;
        }
        
        /// <summary>
        /// プレビュー画像の更新を行う
        /// </summary>
        private void UpdatePreview()
        {
            if (this.PuzzleImage != null) this.PreviewPictureBox.Image = this.PuzzleImage.Resize(150).DrawMeshLine(this.LevelComboBox.SelectedIndex + 2);
        }
        
        /// <summary>
        /// フォームのロードイベント
        /// </summary>
        private void GenerateForm_Load(object sender, EventArgs e)
        {
            // パズルの難易度Lv1を選択
            LevelComboBox.SelectedIndex = 0;
        }
        
        /// <summary>
        /// パズル生成元ラジオボタン(番号)の値変更イベント
        /// </summary>
        private void FromNumberRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.FromNumberRadioButton.Checked)
            {
                this.PuzzleImage = this.GetResourceImage("level" + (this.LevelComboBox.SelectedIndex + 1) + ".PNG");
                this.FilePathTextBox.Clear();
                this.ReferenceButton.Enabled = false;
                this.UpdatePreview();
            }
        }
        
        /// <summary>
        /// パズル生成元ラジオボタン(画像)の値変更イベント
        /// </summary>
        private void FromImageRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (this.FromImageRadioButton.Checked)
            {
                Image openImage = this.LoadImage();
                if (openImage == null)
                {
                    this.FilePathTextBox.Clear();
                    this.FromNumberRadioButton.Checked = true;
                }
                else
                {
                    this.PuzzleImage = openImage;
                    this.PreviewPictureBox.Image = ImageTransformation.Resize(this.PuzzleImage, 150).DrawMeshLine(this.LevelComboBox.SelectedIndex + 1);
                    this.ReferenceButton.Enabled = true;
                    this.UpdatePreview();
                }
            }
        }
        
        /// <summary>
        /// 参照ボタンのクリックイベント
        /// </summary>
        private void ReferenceButton_Click(object sender, EventArgs e)
        {
            Image openImage = this.LoadImage();
            if (openImage != null)
            {
                this.PuzzleImage = openImage;
                this.PreviewPictureBox.Image = ImageTransformation.Resize(this.PuzzleImage, 150).DrawMeshLine(this.LevelComboBox.SelectedIndex + 1);
                this.UpdatePreview();
            }
        }
        
        /// <summary>
        /// パズル難易度の値変更イベント
        /// </summary>
        private void LevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 番号からパズルを生成を選択している場合に画像も入れ替える
            if (this.FromNumberRadioButton.Checked)
            {
                this.PuzzleImage = this.GetResourceImage("level" + (this.LevelComboBox.SelectedIndex + 1) + ".PNG");
            }

            this.UpdatePreview();
        }
        
        /// <summary>
        /// 生成ボタンのクリックイベント
        /// </summary>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            this.MyPuzzle = new Puzzle(this.PuzzleImage, this.LevelComboBox.SelectedIndex + 1);
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
