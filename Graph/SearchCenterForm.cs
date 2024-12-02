﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    public partial class SearchCenterForm : Form
    {
        int[,] Ds;
        public SearchCenterForm(int[,] Ds)
        {
            this.Ds = Ds;
            InitializeComponent();
            createGrid(Ds);
        }

        void createGrid(int[,] Ds)
        {
            // grid settings
            const int rowWidth = 101;
            const int colWidth = 31;
            dataGridView.ColumnCount = Ds.GetLength(1) + 1;
            dataGridView.RowCount = Ds.GetLength(0) + 2;
            dataGridView.Width = rowWidth * dataGridView.ColumnCount;
            dataGridView.Height = colWidth * dataGridView.RowCount;
            this.Width = dataGridView.Width + 20;
            this.Height = dataGridView.Height + 20;
            this.MaximumSize = new Size(this.Width, this.Height);
            this.MinimumSize = new Size(this.Width, this.Height);
            // grid input
            dataGridView.Columns[0].DefaultCellStyle.BackColor = Color.LightGray;
            dataGridView.Rows[0].DefaultCellStyle.BackColor = Color.LightGray;
            
            for (int i = 1; i < Ds.GetLength(0) + 1; i++)
            {
                dataGridView.Rows[0].Cells[i].Value = $"{i}";
                dataGridView.Rows[i].Cells[0].Value = $"{i}";
            }
            for (int i = 1; i < Ds.GetLength(0) + 1; i++)
            {
                dataGridView.Rows[i].Cells[0].Value = $"{i}";
                for (int j = 1; j < Ds.GetLength(1) + 1; j++)
                { 
                    dataGridView.Rows[i].Cells[j].Value = Ds[i - 1, j - 1] == int.MaxValue ? "∞" : Ds[i - 1, j - 1];
                    if (i == j)
                    {
                        dataGridView.Rows[i].Cells[j].Value = '0';
                    }
                }
            }
            dataGridView.Rows[Ds.GetLength(1) + 1].Cells[0].Value = "max";
            int[] maxs = new int[Ds.GetLength(0)];
            for (int i = 1; i < Ds.GetLength(1) + 1; i++)
            {
                int max = Ds[0, i - 1];
                for (int j = 0; j < Ds.GetLength(1); j++)
                    if (Ds[j, i - 1] > max)
                        max = Ds[j, i - 1];
                maxs[i-1] = max;
                dataGridView.Rows[Ds.GetLength(1) + 1].Cells[i].Value = max == int.MaxValue ? "∞" : max;
            }
            int minIndex = 0;
            for (int i = 0; i < maxs.Length; i++)
            {
                if (maxs[minIndex] > maxs[i])
                {
                    minIndex = i;
                }
            }
            dataGridView.Rows[Ds.GetLength(1) + 1].Cells[minIndex + 1].Style.BackColor = Color.LightBlue;
        }
    }
}
