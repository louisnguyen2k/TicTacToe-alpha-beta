using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Operator
    {
        /* Property */
        int x; // tọa độ x trong ma trận 3*3
        int y; // tọa độ y trong ma trận 3*3

        // hàm khởi tạo
        public Operator(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // đánh nước đánh ở vị trí [x, y], trả về trạng thái cả bàn cờ sau nước đánh vừa rồi
        public State move(State s)
        {
            int sz = s.N;

            // check nước đánh hợp lệ
            if(x < 0 || x >= sz) // out X
            {
                return null;
            }
            if(y < 0 || y >= sz) // out Y
            {
                return null;
            }
            if(s.data[x * sz + y] != 0) // đã đánh
            {
                return null;
            }

            int res = 0;

            // Đếm số lượng ô đã đánh rồi
            for(int i = 0; i < MyStaticVar.NUM; i++)
            {
                if(s.data[i] != MyStaticVar.NaN) 
                {
                    res++;
                }
            }

            State sn = s.clone();

            if (res % 2 == 0) // Chẵn => lượt X đi
            {
                sn.data[x * sz + y] = MyStaticVar.X;
            }
            else // Lẻ => lượt O đi
            {
                sn.data[x * sz + y] = MyStaticVar.O;
            }
            return sn;
        }
    }
}
