namespace Graph
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            inputGraphButton = new Button();
            graphPanel = new Panel();
            SuspendLayout();
            // 
            // inputGraphButton
            // 
            inputGraphButton.Location = new Point(0, 0);
            inputGraphButton.Margin = new Padding(0);
            inputGraphButton.Name = "inputGraphButton";
            inputGraphButton.Size = new Size(200, 50);
            inputGraphButton.TabIndex = 0;
            inputGraphButton.Text = "Ввод графа";
            inputGraphButton.UseVisualStyleBackColor = true;
            inputGraphButton.Click += this.inputGraphButton_Click;
            // 
            // graphPanel
            // 
            graphPanel.Location = new Point(200, 0);
            graphPanel.Margin = new Padding(0);
            graphPanel.Name = "graphPanel";
            graphPanel.Size = new Size(784, 561);
            graphPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(graphPanel);
            Controls.Add(inputGraphButton);
            MaximizeBox = false;
            MaximumSize = new Size(1000, 600);
            MinimumSize = new Size(1000, 600);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Лабораторная работа №3";
            ResumeLayout(false);
        }

        #endregion

        private Button inputGraphButton;
        private Panel graphPanel;
    }
}
