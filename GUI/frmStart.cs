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
    public partial class frmStart : Form
    {

        #region // Tạo hiệu ứng bo tròn khung
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

        public frmStart()
        {
            InitializeComponent();
        }

        private void btnQuitGame_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát game?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn2Player_Click(object sender, EventArgs e)
        {

        }

        private void btn1Player_Click(object sender, EventArgs e)
        {
            frmLogin1 frmLogin1 = new frmLogin1();
            frmLogin1.StartPosition = FormStartPosition.CenterScreen;
            frmLogin1.ShowDialog();
        }

        private void btnTheRules_Click(object sender, EventArgs e)
        {
            frmTheRules frmTheRules = new frmTheRules();
            frmTheRules.StartPosition = FormStartPosition.CenterScreen;
            frmTheRules.ShowDialog();
        }
    }
}
