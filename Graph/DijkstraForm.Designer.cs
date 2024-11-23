namespace Graph
{
    partial class DijkstraForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            resGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)resGridView).BeginInit();
            SuspendLayout();
            // 
            // resGridView
            // 
            resGridView.AllowUserToAddRows = false;
            resGridView.AllowUserToDeleteRows = false;
            resGridView.AllowUserToResizeColumns = false;
            resGridView.AllowUserToResizeRows = false;
            resGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resGridView.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            resGridView.DefaultCellStyle = dataGridViewCellStyle1;
            resGridView.Location = new Point(0, 0);
            resGridView.Margin = new Padding(0);
            resGridView.Name = "resGridView";
            resGridView.ReadOnly = true;
            resGridView.RowHeadersVisible = false;
            resGridView.Size = new Size(799, 449);
            resGridView.TabIndex = 0;
            // 
            // DijkstraForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(resGridView);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DijkstraForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Алгоритм Дейкстра";
            ((System.ComponentModel.ISupportInitialize)resGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView resGridView;
    }
}