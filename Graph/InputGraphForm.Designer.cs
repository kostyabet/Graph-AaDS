namespace Graph
{
    partial class InputGraphForm
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
            createGraphButton = new Button();
            nodesLabel = new Label();
            nodesTextBox = new TextBox();
            edgesTextBox = new TextBox();
            edgesLabel = new Label();
            edgesView = new Label();
            nodesViewLabel = new Label();
            srcLabel = new Label();
            destLabel = new Label();
            srcTextBox = new TextBox();
            destTextBox = new TextBox();
            SuspendLayout();
            // 
            // createGraphButton
            // 
            createGraphButton.Location = new Point(12, 217);
            createGraphButton.Name = "createGraphButton";
            createGraphButton.Size = new Size(496, 40);
            createGraphButton.TabIndex = 0;
            createGraphButton.Text = "Сформировать Граф";
            createGraphButton.UseVisualStyleBackColor = true;
            createGraphButton.Click += createGraphButton_Click;
            // 
            // nodesLabel
            // 
            nodesLabel.AutoSize = true;
            nodesLabel.Location = new Point(12, 25);
            nodesLabel.Name = "nodesLabel";
            nodesLabel.Size = new Size(148, 15);
            nodesLabel.TabIndex = 1;
            nodesLabel.Text = "Введите вершины графа: ";
            // 
            // nodesTextBox
            // 
            nodesTextBox.Location = new Point(166, 12);
            nodesTextBox.Multiline = true;
            nodesTextBox.Name = "nodesTextBox";
            nodesTextBox.Size = new Size(342, 52);
            nodesTextBox.TabIndex = 2;
            // 
            // edgesTextBox
            // 
            edgesTextBox.Location = new Point(166, 70);
            edgesTextBox.Multiline = true;
            edgesTextBox.Name = "edgesTextBox";
            edgesTextBox.Size = new Size(342, 92);
            edgesTextBox.TabIndex = 3;
            // 
            // edgesLabel
            // 
            edgesLabel.AutoSize = true;
            edgesLabel.Location = new Point(12, 103);
            edgesLabel.Name = "edgesLabel";
            edgesLabel.Size = new Size(132, 15);
            edgesLabel.TabIndex = 4;
            edgesLabel.Text = "Введите пары вершин:";
            // 
            // edgesView
            // 
            edgesView.AutoSize = true;
            edgesView.Location = new Point(24, 120);
            edgesView.Name = "edgesView";
            edgesView.Size = new Size(105, 15);
            edgesView.TabIndex = 5;
            edgesView.Text = "1-12-2 (от-вес-до)";
            // 
            // nodesViewLabel
            // 
            nodesViewLabel.AutoSize = true;
            nodesViewLabel.Location = new Point(57, 40);
            nodesViewLabel.Name = "nodesViewLabel";
            nodesViewLabel.Size = new Size(40, 15);
            nodesViewLabel.TabIndex = 6;
            nodesViewLabel.Text = "1 2 3 4";
            // 
            // srcLabel
            // 
            srcLabel.AutoSize = true;
            srcLabel.Location = new Point(41, 182);
            srcLabel.Name = "srcLabel";
            srcLabel.Size = new Size(87, 15);
            srcLabel.TabIndex = 7;
            srcLabel.Text = "Введите исток:";
            // 
            // destLabel
            // 
            destLabel.AutoSize = true;
            destLabel.Location = new Point(282, 182);
            destLabel.Name = "destLabel";
            destLabel.Size = new Size(80, 15);
            destLabel.TabIndex = 8;
            destLabel.Text = "Введите сток:";
            // 
            // srcTextBox
            // 
            srcTextBox.Location = new Point(134, 179);
            srcTextBox.Name = "srcTextBox";
            srcTextBox.Size = new Size(100, 23);
            srcTextBox.TabIndex = 9;
            // 
            // destTextBox
            // 
            destTextBox.Location = new Point(368, 179);
            destTextBox.Name = "destTextBox";
            destTextBox.Size = new Size(100, 23);
            destTextBox.TabIndex = 10;
            // 
            // InputGraphForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 273);
            Controls.Add(destTextBox);
            Controls.Add(srcTextBox);
            Controls.Add(destLabel);
            Controls.Add(srcLabel);
            Controls.Add(nodesViewLabel);
            Controls.Add(edgesView);
            Controls.Add(edgesLabel);
            Controls.Add(edgesTextBox);
            Controls.Add(nodesTextBox);
            Controls.Add(nodesLabel);
            Controls.Add(createGraphButton);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "InputGraphForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ввод графа";
            Load += InputGraphForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createGraphButton;
        private Label nodesLabel;
        private TextBox nodesTextBox;
        private TextBox edgesTextBox;
        private Label edgesLabel;
        private Label edgesView;
        private Label nodesViewLabel;
        private Label srcLabel;
        private Label destLabel;
        private TextBox srcTextBox;
        private TextBox destTextBox;
    }
}