using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class State
    {
        /* Property */
        public int[]data = new int[MyStaticVar.NUM]; // mảng lưu trạng thái các ô trên bàn cờ
        public int N = MyStaticVar.SIZE; // kích thước của bàn cờ N = 3 (3*3 = 9)

        // Hàm khởi tạo
        public State(int[] data)
        {
            this.data = data;
        }

        // trả về một State clone
        public State clone()
        {
            int []clone_data = new int[MyStaticVar.NUM];
            for (int i = 0; i < MyStaticVar.NUM; i++)
            {
                clone_data[i] = data[i];
            }
            return new State(clone_data);
        }

        // Hàm in ra trạng thái (không cần)
        //public void getStatus()
        //{
        //    int sz = N;
        //    for (int i = 0; i < sz; i++)
        //    {
        //        for (int j = 0; j < sz; j++)
        //        {
        //            int tmp = data[i * sz + j];
        //            if(tmp == MyStaticVar.NaN)
        //            {

        //            }
        //            else if(tmp == MyStaticVar.X)
        //            {

        //            }
        //            else if(tmp == MyStaticVar.O)
        //            {

        //            }
        //        }
        //    }
        //}
    }
}
