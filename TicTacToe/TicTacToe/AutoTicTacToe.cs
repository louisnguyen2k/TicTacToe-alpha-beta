using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace TicTacToe
{
    public partial class AutoTicTacToe : Form
    {
        /* Property */
        bool turn; // xác định turn đi của Boss X hay Boss Y 
        int depthX = MyStaticVar.INF; // độ sâu mặc định mới vào game của X là INF = 10
        int depthO = MyStaticVar.INF; // độ sâu mặc định mới vào game của O là INF = 10
        bool usingABP = true; // Xác định xem đang dùng kĩ thuật alpha-beta hay chỉ minimax
        int x; // tọa độ nước đi x
        int y; // tọa độ nước đi y
        int XWin = 0; // số lần X win
        int OWin = 0; // số lần O win
        int Bound = 0; // số lần hòa

        State s; // trạng thái hiện hành của trò chơi

        MyGame mg = new MyGame(); // đối tượng có các phương thức thực thi trò chơi
        public AutoTicTacToe()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false; // check legal cho thread dùng đối tượng trong form
        }

        private void AutoTicTacToe_Load(object sender, EventArgs e)
        {
            rbtDXInf.Checked = true;
            rbtDOInf.Checked = true;
            cbAlphaBeta.Checked = true;
            initGame();
        }

        void initGame()
        {
            btChoiLai.Enabled = false;
            turn = true;
            //
            BT00.Enabled = true;
            BT01.Enabled = true;
            BT02.Enabled = true;
            BT10.Enabled = true;
            BT11.Enabled = true;
            BT12.Enabled = true;
            BT20.Enabled = true;
            BT21.Enabled = true;
            BT22.Enabled = true;
            //
            BT00.Text = string.Empty;
            BT01.Text = string.Empty;
            BT02.Text = string.Empty;
            BT10.Text = string.Empty;
            BT11.Text = string.Empty;
            BT12.Text = string.Empty;
            BT20.Text = string.Empty;
            BT21.Text = string.Empty;
            BT22.Text = string.Empty;
            //
            BT00.BackColor = Color.White;
            BT01.BackColor = Color.White;
            BT02.BackColor = Color.White;
            BT10.BackColor = Color.White;
            BT11.BackColor = Color.White;
            BT12.BackColor = Color.White;
            BT20.BackColor = Color.White;
            BT21.BackColor = Color.White;
            BT22.BackColor = Color.White;
            //
            //
            int[] start = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            s = new State(start);

            x = -1;
            y = -1;
            new Thread(() =>
            {
                run();
            })
            { IsBackground = true }.Start();
        }

        // hàm thực thi trò chơi trong 1 thread
        void run()
        {
            while (true)
            {
                if (turn) // AI X
                {
                    int mx = -2; // minimum beta
                    State maxChild = null;
                    int sz = s.N;

                    // duyệt tất cả không gian trạng thái
                    for (int i = 0; i < sz; i++)
                    {
                        for (int j = 0; j < sz; j++)
                        {
                            State child = new Operator(i, j).move(s);

                            if (child == null) // trạng thái không hợp lệ (đã được đánh)
                            {
                                continue;
                            }

                            /*
                            ///////////////////////// depth độ sâu
                             */
                            int tmp;
                            if (usingABP) // using minimax alpha-beta pruning
                            {
                                tmp = mg.Minimax_ABP(child, depthX, false);
                            }
                            else // using just minimax simple pruning
                            {
                                tmp = mg.Minimax_no(child, depthX, false);
                            }
                            // print(i, j, tmp)
                            if (mx < tmp)
                            {
                                mx = tmp;
                                maxChild = child;
                                //
                                x = i;
                                y = j;
                            }
                        }
                    }
                    s = maxChild;
                    // s.print()
                    turnX();
                    Thread.Sleep(1500);

                    //
                    if (mg.isWin(s)) // AI win
                    {
                        /*
                        //////////////////////////////////// AI win
                        */
                        XWin = Convert.ToInt32(lbXWin.Text) + 1;
                        lbXWin.Text = XWin.ToString();
                        btChoiLai.Enabled = true;
                        endGame();
                        MessageBox.Show("X win!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }
                else // AI O
                {
                    int mn = 2; // minimum beta
                    State minChild = null;
                    int sz = s.N;

                    // duyệt tất cả không gian trạng thái
                    for (int i = 0; i < sz; i++)
                    {
                        for (int j = 0; j < sz; j++)
                        {
                            State child = new Operator(i, j).move(s);

                            if (child == null) // trạng thái không hợp lệ (đã được đánh)
                            {
                                continue;
                            }

                            /*
                            ///////////////////////// depth độ sâu
                             */
                            int tmp;
                            if (usingABP) // using minimax alpha-beta pruning
                            {
                                tmp = mg.Minimax_ABP(child, depthO, true);
                            }
                            else // using just minimax simple pruning
                            {
                                tmp = mg.Minimax_no(child, depthO, true);
                            }
                            // print(i, j, tmp)
                            if (mn > tmp)
                            {
                                mn = tmp;
                                minChild = child;
                                //
                                x = i;
                                y = j;
                            }
                        }
                    }
                    s = minChild;
                    turnO();
                    Thread.Sleep(1500);
                    //
                    if (mg.isWin(s)) // AI win
                    {
                        /*
                        //////////////////////////////////// AI win
                        */
                        OWin = Convert.ToInt32(lbOWin.Text) + 1;
                        lbOWin.Text = OWin.ToString();
                        btChoiLai.Enabled = true;
                        endGame();
                        MessageBox.Show("O win!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                }

                if (mg.isEndNode(s)) // Hòa cờ
                {
                    // draw
                    Bound = Convert.ToInt32(lbBound.Text) + 1;
                    lbBound.Text = Bound.ToString();
                    btChoiLai.Enabled = true;
                    endGame();
                    MessageBox.Show("Draw!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                }
                turn = !turn;
            }

        }


        // Chạy khi gặp trạng thái end game
        void endGame()
        {
            BT00.Enabled = false;
            BT01.Enabled = false;
            BT02.Enabled = false;
            BT10.Enabled = false;
            BT11.Enabled = false;
            BT12.Enabled = false;
            BT20.Enabled = false;
            BT21.Enabled = false;
            BT22.Enabled = false;
            //
            BT00.BackColor = Color.Snow;
            BT01.BackColor = Color.Snow;
            BT02.BackColor = Color.Snow;
            BT10.BackColor = Color.Snow;
            BT11.BackColor = Color.Snow;
            BT12.BackColor = Color.Snow;
            BT20.BackColor = Color.Snow;
            BT21.BackColor = Color.Snow;
            BT22.BackColor = Color.Snow;
        }

        // mark vào turn của X 
        void turnX()
        {
            if (x == 0 && y == 0 &&
                BT00.Enabled == true)
            {
                BT00.BackColor = Color.Snow;
                //BT00.ForeColor = Color.Maroon;
                BT00.Text = "X".ToString();
                BT00.Enabled = false;
            }
            else if (x == 0 && y == 1 &&
                BT01.Enabled == true)
            {
                BT01.BackColor = Color.Snow;
                //BT01.ForeColor = Color.Maroon;
                BT01.Text = "X".ToString();
                BT01.Enabled = false;
            }
            else if (x == 0 && y == 2 &&
                BT02.Enabled == true)
            {
                BT02.BackColor = Color.Snow;
                //BT02.ForeColor = Color.Maroon;
                BT02.Text = "X".ToString();
                BT02.Enabled = false;
            }
            else if (x == 1 && y == 0 &&
                BT10.Enabled == true)
            {
                BT10.BackColor = Color.Snow;
                //BT10.ForeColor = Color.Maroon;
                BT10.Text = "X".ToString();
                BT10.Enabled = false;
            }
            else if (x == 1 && y == 1 &&
                BT11.Enabled == true)
            {
                BT11.BackColor = Color.Snow;
                //BT11.ForeColor = Color.Maroon;
                BT11.Text = "X".ToString();
                BT11.Enabled = false;
            }
            else if (x == 1 && y == 2 &&
                BT12.Enabled == true)
            {
                BT12.BackColor = Color.Snow;
                //BT12.ForeColor = Color.Maroon;
                BT12.Text = "X".ToString();
                BT12.Enabled = false;
            }
            else if (x == 2 && y == 0 &&
                BT20.Enabled == true)
            {
                BT20.BackColor = Color.Snow;
                //BT20.ForeColor = Color.Maroon;
                BT20.Text = "X".ToString();
                BT20.Enabled = false;
            }
            else if (x == 2 && y == 1 &&
                BT21.Enabled == true)
            {
                BT21.BackColor = Color.Snow;
                //BT21.ForeColor = Color.Maroon;
                BT21.Text = "X".ToString();
                BT21.Enabled = false;
            }
            else if (x == 2 && y == 2 &&
                BT22.Enabled == true)
            {
                BT22.BackColor = Color.Snow;
                //BT22.ForeColor = Color.Maroon;
                BT22.Text = "X".ToString();
                BT22.Enabled = false;
            }
            return;
        }

        // mark vào turn của O
        void turnO()
        {
            if (x == 0 && y == 0 &&
                BT00.Enabled == true)
            {
                BT00.BackColor = Color.Snow;
                //BT00.ForeColor = Color.Green;
                BT00.Text = "O";
                BT00.Enabled = false;
            }
            else if (x == 0 && y == 1 &&
                BT01.Enabled == true)
            {
                BT01.BackColor = Color.Snow;
                //BT01.ForeColor = Color.Green;
                BT01.Text = "O";
                BT01.Enabled = false;
            }
            else if (x == 0 && y == 2 &&
                BT02.Enabled == true)
            {
                BT02.BackColor = Color.Snow;
                //BT02.ForeColor = Color.Green;
                BT02.Text = "O";
                BT02.Enabled = false;
            }
            else if (x == 1 && y == 0 &&
                BT10.Enabled == true)
            {
                BT10.BackColor = Color.Snow;
                //BT10.ForeColor = Color.Green;
                BT10.Text = "O";
                BT10.Enabled = false;
            }
            else if (x == 1 && y == 1 &&
                BT11.Enabled == true)
            {
                BT11.BackColor = Color.Snow;
                //BT11.ForeColor = Color.Green;
                BT11.Text = "O";
                BT11.Enabled = false;
            }
            else if (x == 1 && y == 2 &&
                BT12.Enabled == true)
            {
                BT12.BackColor = Color.Snow;
                //BT12.ForeColor = Color.Green;
                BT12.Text = "O";
                BT12.Enabled = false;
            }
            else if (x == 2 && y == 0 &&
                BT20.Enabled == true)
            {
                BT20.BackColor = Color.Snow;
                //BT20.ForeColor = Color.Green;
                BT20.Text = "O";
                BT20.Enabled = false;
            }
            else if (x == 2 && y == 1 &&
                BT21.Enabled == true)
            {
                BT21.BackColor = Color.Snow;
                //BT21.ForeColor = Color.Green;
                BT21.Text = "O";
                BT21.Enabled = false;
            }
            else if (x == 2 && y == 2 &&
                BT22.Enabled == true)
            {
                BT22.BackColor = Color.Snow;
                //BT22.ForeColor = Color.Green;
                BT22.Text = "O";
                BT22.Enabled = false;
            }
            return;
        }

        // sự kiện checkbox đổi thuật toán
        private void checkbox_change(object sender, EventArgs e)
        {
            if (cbAlphaBeta.Checked == true)
            {
                usingABP = true;
            }
            else
            {
                usingABP = false;
            }
        }

        // sự kiện click rbt đổi độ sâu X
        private void rbt_changeX(object sender, EventArgs e)
        {
            RadioButton rbt = (RadioButton)sender;
            if (rbt.Text == "INF")
                depthX = MyStaticVar.INF;
            else
                depthX = Convert.ToInt32(rbt.Text);
        }

        private void rbt_changeO(object sender, EventArgs e)
        {
            RadioButton rbt = (RadioButton)sender;
            if (rbt.Text == "INF")
                depthO = MyStaticVar.INF;
            else
                depthO = Convert.ToInt32(rbt.Text);
        }

        private void btChoiLai_Click(object sender, EventArgs e)
        {
            initGame();
        }
    }
}
