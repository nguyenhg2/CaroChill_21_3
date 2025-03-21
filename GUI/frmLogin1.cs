using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroChill_13_03.GUI
{
    public partial class frmLogin1 : Form
    {

        #region Tạo khung bo tròn
        // Ghi đè phương thức OnLoad để áp dụng bo tròn khi form tải
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Bán kính góc bo tròn
            int cornerRadius = 30;

            // Tạo vùng bo tròn cho form
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(0, 0, cornerRadius, cornerRadius, 180, 90);
                path.AddArc(this.Width - cornerRadius - 1, 0, cornerRadius, cornerRadius, 270, 90);
                path.AddArc(this.Width - cornerRadius - 1, this.Height - cornerRadius - 1, cornerRadius, cornerRadius, 0, 90);
                path.AddArc(0, this.Height - cornerRadius - 1, cornerRadius, cornerRadius, 90, 90);
                path.CloseFigure();

                // Áp dụng hình dạng bo tròn vào form
                this.Region = new Region(path);
            }
        }

        #endregion

        public frmLogin1()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Tên người chơi")
            {
                MessageBox.Show("Vui lòng nhập tên người chơi", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbLevel.SelectedIndex == 0)
            {
                MessageBox.Show("Vui lòng chọn cấp độ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            frmChessBoard frmChessBoard = new frmChessBoard();
            frmChessBoard.StartPosition = FormStartPosition.CenterScreen;
            frmChessBoard.ShowDialog();
            this.Close();
        }

        // Khi người dùng nhấn vào textbox để nhập
        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Tên người chơi")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.Black;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                txtUserName.Text = "Tên người chơi";
                txtUserName.ForeColor = Color.Gray;
            }
        }
        // nhấn enter sau khi nhập tên
        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbLevel.Focus();
                e.SuppressKeyPress = true;// Ngăn không cho nhấn Enter trong TextBox
            }
        }

        private void cmbLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.Focus();
            }
        }
    }
}
