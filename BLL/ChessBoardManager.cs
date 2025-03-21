using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CaroChill_13_03.GUI;

namespace CaroChill_13_03.Class
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel chessBoard;
        public Panel ChessBoard
        {
            get { return chessBoard; }
            set { chessBoard = value; }
        }

        private PictureBox avartar1;
        public PictureBox Avatar1
        {
            get { return avartar1; }
            set { avartar1 = value; }
        }
        private PictureBox avartar2;
        public PictureBox Avatar2
        {
            get { return avartar2; }
            set { avartar2 = value; }
        }

        private Label labelName1;
        public Label LabelName1
        {
            get { return labelName1; }
            set { labelName1 = value; }
        }
        private Label labelName2;
        public Label LabelName2
        {
            get { return labelName2; }
            set { labelName2 = value; }
        }

        // Thêm ProgressBar cho hai người chơi
        private ProgressBar progressBar1;
        public ProgressBar ProgressBar1
        {
            get { return progressBar1; }
            set { progressBar1 = value; }
        }

        private ProgressBar progressBar2;
        public ProgressBar ProgressBar2
        {
            get { return progressBar2; }
            set { progressBar2 = value; }
        }

        // Quản lý timer riêng biệt
        private GameTimerManager timerManager;

        private string imagePathX = $"{Application.StartupPath}\\Resources\\X.png"; // Đường dẫn ảnh X
        private string imagePathO = $"{Application.StartupPath}\\Resources\\O.png"; // Đường dẫn ảnh O

        private Image imageX;
        private Image imageO;

        private List<List<Button>> matrix = new List<List<Button>>();

        public List<Player> Player { get; set; } = new List<Player>();

        private int currentPlayer = 0;
        private bool isFirstDraw = true;
        #endregion

        #region Initialize
        public ChessBoardManager(Panel chessBoard, PictureBox avt1, PictureBox avt2, Label lab1, Label lab2, ProgressBar prgBar1, ProgressBar prgBar2)
        {
            this.chessBoard = chessBoard;
            this.avartar1 = avt1;
            this.avartar2 = avt2;
            this.labelName1 = lab1;
            this.labelName2 = lab2;
            this.progressBar1 = prgBar1;
            this.progressBar2 = prgBar2;

            //// Bật Double Buffering cho Panel
            //typeof(Panel).InvokeMember("DoubleBuffered",
            //    BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
            //    null, chessBoard, new object[] { true });

            imageX = File.Exists(imagePathX) ? Image.FromFile(imagePathX) : new Bitmap(1, 1);
            imageO = File.Exists(imagePathO) ? Image.FromFile(imagePathO) : new Bitmap(1, 1);

            // Khởi tạo người chơi
            Player.Add(new Player("Player 1", imageX));
            Player.Add(new Player("Player 2", imageO));

            // Khởi tạo timer manager
            timerManager = new GameTimerManager(progressBar1, progressBar2, OnTimeOut);

            DrawChessBoard();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Xử lý khi hết thời gian
        /// </summary>
        private void OnTimeOut(int player)
        {
            // Kiểm tra xem form có đang hiển thị không
            if (frmChessBoard.ActiveForm != null && frmChessBoard.ActiveForm.Visible == true)
            {
                MessageBox.Show($"{Player[player].Name} đã thua do hết thời gian!",
                               "Hết thời gian", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Reset bàn cờ
            if (isFirstDraw)
                DrawChessBoard();
            else
                ResetChessBoard();
        }

        public void DrawChessBoard()
        {
            // Dừng timer nếu đang chạy
            timerManager.StopTimer();

            // Tạm dừng layout để tăng hiệu suất
            chessBoard.SuspendLayout();

            // Xóa bàn cờ cũ
            chessBoard.Controls.Clear();
            // Khởi tạo ma trận button
            matrix.Clear();

            // Tạo danh sách để lưu tất cả các button
            List<Button> allButtons = new List<Button>();

            for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT; i++)
            {
                matrix.Add(new List<Button>());

                for (int j = 0; j < Cons.CHESS_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(j * Cons.CHESS_WIDTH, i * Cons.CHESS_HEIGHT),
                        BackgroundImageLayout = ImageLayout.Stretch, // Căn chỉnh ảnh vừa với button
                        Tag = i.ToString(), // Lưu vị trí dòng để dễ xử lý sau này
                        TabStop = false
                    };

                    btn.Click += Btn_Click; // Thêm sự kiện click

                    matrix[i].Add(btn); // Thêm button vào ma trận
                    allButtons.Add(btn); // Thêm vào danh sách tạm
                }
            }

            // Thêm tất cả các button vào panel cùng một lúc
            chessBoard.Controls.AddRange(allButtons.ToArray());

            // Tiếp tục layout
            chessBoard.ResumeLayout(true);

            isFirstDraw = false;

            // Reset màu nền của tên người chơi
            labelName1.BackColor = Color.White;
            labelName2.BackColor = Color.White;

            // Thiết lập người chơi đầu tiên
            currentPlayer = 0;
            ChangePlayer();

            // Bắt đầu đếm ngược cho người chơi đầu tiên
            timerManager.StartCountdown(currentPlayer);
        }

        /// <summary>
        /// Reset bàn cờ mà không tạo lại các button
        /// </summary>
        public void ResetChessBoard()
        {
            // Dừng timer
            timerManager.StopTimer();

            // Tạm dừng layout
            chessBoard.SuspendLayout();

            // Xóa hình ảnh nền của tất cả các button
            foreach (List<Button> buttonRow in matrix)
            {
                foreach (Button button in buttonRow)
                {
                    button.BackgroundImage = null;
                }
            }

            // Tiếp tục layout
            chessBoard.ResumeLayout(true);

            // Reset màu nền của tên người chơi
            labelName1.BackColor = Color.White;
            labelName2.BackColor = Color.White;

            // Thiết lập người chơi đầu tiên
            currentPlayer = 0;
            ChangePlayer();

            // Bắt đầu đếm ngược cho người chơi đầu tiên
            timerManager.StartCountdown(currentPlayer);
        }

        private void Btn_Click(object? sender, EventArgs e)
        {
            Button? btn = sender as Button;

            if (btn == null) return;

            // Nếu button đã có ảnh thì không xử lý
            if (btn.BackgroundImage != null)
                return;

            // Dừng timer hiện tại
            timerManager.StopTimer();

            // Hiển thị ảnh X hoặc O tùy thuộc vào người chơi hiện tại
            btn.BackgroundImage = Player[currentPlayer].Mark;

            // Kiểm tra thắng thua
            if (CheckWin(btn))
            {
                // Xử lý khi có người thắng
                MessageBox.Show($"{Player[currentPlayer].Name} đã thắng!",
                               "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetChessBoard();
                return;
            }

            // Chuyển lượt người chơi
            currentPlayer = currentPlayer == 0 ? 1 : 0;

            // Cập nhật giao diện để hiển thị lượt người chơi hiện tại
            ChangePlayer();

            // Bắt đầu đếm ngược cho người chơi mới
            timerManager.StartCountdown(currentPlayer);
        }

        private void ChangePlayer()
        {
            // Reset màu nền
            labelName1.BackColor = Color.White;
            labelName2.BackColor = Color.White;

            // Thay đổi hiển thị tên người chơi hiện tại
            if (currentPlayer == 0)
            {
                labelName1.BackColor = Color.Green;
            }
            else
            {
                labelName2.BackColor = Color.Green;
            }
        }

        private bool CheckWin(Button btn)
        {
            // Lấy vị trí của button trong ma trận
            int row = Convert.ToInt32(btn.Tag);
            int col = matrix[row].IndexOf(btn);

            // Phương thức này sẽ được phát triển sau để kiểm tra thắng thua
            // Dựa trên các quy tắc của trò chơi Caro
            // Có thể kiểm tra theo hàng, cột, đường chéo

            return false; // Tạm thời trả về false
        }

        public void StartGame()
        {
            // Nếu đã vẽ bàn cờ rồi thì chỉ reset
            if (matrix.Count > 0 && !isFirstDraw)
            {
                ResetChessBoard();
            }
            else
            {
                DrawChessBoard();
            }
        }

        /// <summary>
        /// Dừng timer khi đóng form hoặc kết thúc trò chơi
        /// </summary>
        public void StopGame()
        {
            timerManager.StopTimer();
        }

        /// <summary>
        /// Giải phóng tài nguyên khi form đóng
        /// </summary>
        public void Dispose()
        {
            timerManager.Dispose();
            imageX?.Dispose();
            imageO?.Dispose();
        }
        #endregion
    }
}
