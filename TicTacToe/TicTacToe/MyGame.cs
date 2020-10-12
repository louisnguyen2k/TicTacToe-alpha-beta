using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class MyGame
    {
        // kiểm tra trạng thái s có phải kết thúc
        public bool isEndNode(State s)
        {
            int sz = s.N;
            int []data = s.data;

            for (int i = 0; i < sz; i++)
            {
                // kết thúc hàng
                if(data[i*sz + 0] != 0 
                    && data[i*sz + 0] == data[i*sz + 1] && data[i*sz + 1] == data[i*sz + 2])
                {
                    return true;
                }
                // kết thúc cột
                if (data[0 * sz + i] != 0
                    && data[0 * sz + i] == data[1 * sz + i] && data[1 * sz + i] == data[2 * sz + i])
                {
                    return true;
                }
            }
            // Chéo chính
            if(data[0*sz + 0] != 0 
                && data[0*sz + 0] == data[1*sz + 1] && data[1*sz + 1] == data[2*sz + 2])
            {
                return true;
            }
            // Chéo phụ
            if (data[0*sz + 2] != 0
                && data[0*sz + 2] == data[1*sz + 1] && data[1*sz + 1] == data[2*sz + 0])
            {
                return true;
            }
            // kiểm tra xem kết thúc chưa (Đánh hết tất cả các ô)
            for(int i = 0; i < MyStaticVar.NUM; i++)
            {
                if (data[i] == 0)
                {
                    return false;
                } 
            }
            return true; // kết thúc trạng thái hòa(Đánh hết tất cả các ô)
        }

        // Kiểm tra sau nước đi vừa rồi có win ko
        public bool  isWin(State s)
        {
            if(s.data == null)
            {
                return false;
            }

            int sz = s.N;
            int[] data = s.data;
            // kiểm tra thắng không
            for (int i = 0; i < sz; i++)
            {
                // Thắng với hàng
                if (data[i * sz + 0] != 0
                    && data[i * sz + 0] == data[i * sz + 1] && data[i * sz + 1] == data[i * sz + 2])
                {
                    return true;
                }
                // Thắng với cột
                if (data[0 * sz + i] != 0
                    && data[0 * sz + i] == data[1 * sz + i] && data[1 * sz + i] == data[2 * sz + i])
                {
                    return true;
                }
            }
            // Thắng với Chéo chính
            if (data[0 * sz + 0] != 0
                && data[0 * sz + 0] == data[1 * sz + 1] && data[1 * sz + 1] == data[2 * sz + 2])
            {
                return true;
            }
            // Thắng với Chéo phụ
            if (data[0 * sz + 2] != 0
                && data[0 * sz + 2] == data[1 * sz + 1] && data[1 * sz + 1] == data[2 * sz + 0])
            {
                return true;
            }

            return false; // Chưa thắng
        }

        // kiểm tra turn vừa rồi là ai đánh
        public bool checkMyTurn(State s)
        {
            int res = 0;
            for(int i = 0; i < MyStaticVar.NUM; i++) // đếm số lượng vị trí đang trống
            {
                if(s.data[i] == 0)
                {
                    res++;
                }
            }

            if(res % 2 == 0) // vị trí còn trống chẵn => lượt O (mình) đánh
            {
                return true;
            }
            // else
            return false; // vị trí còn trống lẻ => lượt X (máy) đánh
        }

        // Hàm đánh giá node lá
        public int Value(State s)
        {
            if (isWin(s))
            {
                if (checkMyTurn(s)) // win ở turn O
                {
                    return 1;
                }
                else // win ở turn X
                {
                    return -1;
                }
            }
            return 0; // không win
        }

        // cắt tỉa alpha-beta
        public int AlphaBeta(State s, int depth, int a, int b, bool mp)
        {
            // Trạng thái kết thúc (node lá)
            if(isEndNode(s) || depth == 0)
            {
                return Value(s);
            }
            int sz = s.N;
            if(mp == true) // Trạng thái s hiện tại đang là Max
            {
                for (int i = 0; i< sz; i++) // duyệt các trạng thái con
                {
                    for (int j = 0; j <sz; j++)
                    {
                        State child = new Operator(i, j).move(s);
                        if(child == null)
                        {
                            continue;
                        }
                        int tmp = AlphaBeta(child, depth - 1, a, b, false);
                        a = Max(a, tmp);
                        if (a >= b)
                        {
                            break;
                        }
                    }
                }
                return a;
            }
            else  // Trạng thái s hiện tại đang là Min
            {
                for (int i = 0; i < sz; i++) // duyệt các trạng thái con
                {
                    for (int j = 0; j < sz; j++)
                    {
                        State child = new Operator(i, j).move(s);
                        if (child == null)
                        {
                            continue;
                        }
                        int tmp = AlphaBeta(child, depth - 1, a, b, true);
                        b = Min(b, tmp);
                        if (a >= b)
                        {
                            break;
                        }
                    }
                }
                return b;
            }
        }

        // thực thi thuật toán Minimax sử dụng Alpha-beta pruning
        public int Minimax_ABP(State s, int depth, bool mp)
        {
            return AlphaBeta(s, depth, -2, 2, mp);
        }

        //thực thi thuật toán Minimax thông thường
        public int Minimax_no(State s, int depth, bool mp)
        {
            // Trạng thái kết thúc (node lá)
            if (isEndNode(s) || depth == 0)
            {
                return Value(s);
            }
            int sz = s.N;
            if (mp == true) // Trạng thái s hiện tại đang là Max
            {
                int Mx = -2; // âm vô cùng
                for (int i = 0; i < sz; i++) // duyệt các trạng thái con
                {
                    for (int j = 0; j < sz; j++)
                    {
                        State child = new Operator(i, j).move(s);
                        if (child == null)
                        {
                            continue;
                        }
                        int tmp = Minimax_no(child, depth - 1, false);
                        Mx = Max(Mx, tmp);
                        
                    }
                }
                return Mx;
            }
            else  // Trạng thái s hiện tại đang là Min
            {
                int Mn = 2; // dương vô cùng
                for (int i = 0; i < sz; i++) // duyệt các trạng thái con
                {
                    for (int j = 0; j < sz; j++)
                    {
                        State child = new Operator(i, j).move(s);
                        if (child == null)
                        {
                            continue;
                        }
                        int tmp = Minimax_no(child, depth - 1, true);
                        Mn = Min(Mn, tmp);
                    }
                }
                return Mn;
            }
        }










        /*----- hàm so sánh 2 số -----*/
        int Max(int a, int b)
        {
            return a > b ? a : b;
        }
        int Min(int a, int b)
        {
            return a < b ? a : b;
        }
    }
}
