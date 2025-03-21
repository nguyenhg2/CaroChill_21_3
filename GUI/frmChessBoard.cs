using CaroChill_13_03.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CaroChill_13_03.GUI
{
    public partial class frmChessBoard : Form
    {
        #region Properties
        ChessBoardManager chessBoard;
        #endregion
        public frmChessBoard()
        {

            InitializeComponent();
            chessBoard = new ChessBoardManager(pnlChessBoard, ptbavt1, ptbavt2, labname1, labname2, progressBar1, progressBar2);
            chessBoard.DrawChessBoard();



        }

    }
}
