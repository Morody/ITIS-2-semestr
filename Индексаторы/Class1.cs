using System;
using System.Collections.Generic;
using System.Text;

namespace Индексаторы
{
    class MyArr
    {
        // считать и присвоить значения элементам массива
        // создать св-во, кооторое вернет резутатом размер массива
        // добавить индексатор: считать и присвоить значения столбцам массива

        private int[,] arr;
        private int rows, cols;
        private int Length;

        public MyArr (int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            arr = new int[this.rows, this.cols];
            Length = rows * cols;
        }
        
        public int ReturnLength
        {
            get { return Length; }
        }

        public int ReturnCols
        {
            get { return cols; }
        }

        public int ReturnRows
        {
            get { return rows; }
        }

        public int this [int index1, int index2]
        {
            get { return arr[index1, index2]; }
            set { arr[index1, index2] = value; }
        }
        
    }
}
