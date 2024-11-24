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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            inputGraphButton = new Button();
            graphPanel = new Panel();
            searchShortWayButton = new Button();
            searchLongestWayButton = new Button();
            searchAllWaysButton = new Button();
            searchCenterButton = new Button();
            logGroupBox = new GroupBox();
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
            inputGraphButton.Click += inputGraphButton_Click;
            // 
            // graphPanel
            // 
            graphPanel.Location = new Point(200, 0);
            graphPanel.Margin = new Padding(0);
            graphPanel.Name = "graphPanel";
            graphPanel.Size = new Size(784, 561);
            graphPanel.TabIndex = 1;
            graphPanel.Paint += graphPanel_Paint;
            // 
            // searchShortWayButton
            // 
            searchShortWayButton.Location = new Point(0, 50);
            searchShortWayButton.Margin = new Padding(0);
            searchShortWayButton.Name = "searchShortWayButton";
            searchShortWayButton.Size = new Size(200, 50);
            searchShortWayButton.TabIndex = 2;
            searchShortWayButton.Text = "Поиск кратчайшего пути";
            searchShortWayButton.UseVisualStyleBackColor = true;
            searchShortWayButton.Click += searchShortWayButton_Click;
            // 
            // searchLongestWayButton
            // 
            searchLongestWayButton.Location = new Point(0, 100);
            searchLongestWayButton.Margin = new Padding(0);
            searchLongestWayButton.Name = "searchLongestWayButton";
            searchLongestWayButton.Size = new Size(200, 50);
            searchLongestWayButton.TabIndex = 3;
            searchLongestWayButton.Text = "Поиск самого длинного пути";
            searchLongestWayButton.UseVisualStyleBackColor = true;
            searchLongestWayButton.Click += searchLongestWayButton_Click;
            // 
            // searchAllWaysButton
            // 
            searchAllWaysButton.Location = new Point(0, 150);
            searchAllWaysButton.Margin = new Padding(0);
            searchAllWaysButton.Name = "searchAllWaysButton";
            searchAllWaysButton.Size = new Size(200, 50);
            searchAllWaysButton.TabIndex = 4;
            searchAllWaysButton.Text = "Поиск всех путей и сортировка их по возростанию";
            searchAllWaysButton.UseVisualStyleBackColor = true;
            searchAllWaysButton.Click += searchAllWaysButton_Click;
            // 
            // searchCenterButton
            // 
            searchCenterButton.Location = new Point(0, 200);
            searchCenterButton.Margin = new Padding(0);
            searchCenterButton.Name = "searchCenterButton";
            searchCenterButton.Size = new Size(200, 50);
            searchCenterButton.TabIndex = 5;
            searchCenterButton.Text = "Поиск центра орграфа";
            searchCenterButton.UseVisualStyleBackColor = true;
            searchCenterButton.Click += searchCenterButton_Click;
            // 
            // logGroupBox
            // 
            logGroupBox.Location = new Point(0, 253);
            logGroupBox.Name = "logGroupBox";
            logGroupBox.Size = new Size(200, 308);
            logGroupBox.TabIndex = 7;
            logGroupBox.TabStop = false;
            logGroupBox.Text = "Log программы";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(logGroupBox);
            Controls.Add(searchCenterButton);
            Controls.Add(searchAllWaysButton);
            Controls.Add(searchLongestWayButton);
            Controls.Add(searchShortWayButton);
            Controls.Add(graphPanel);
            Controls.Add(inputGraphButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
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
        private Button searchShortWayButton;
        private Button searchLongestWayButton;
        private Button searchAllWaysButton;
        private Button searchCenterButton;
        private GroupBox logGroupBox;
    }
}
