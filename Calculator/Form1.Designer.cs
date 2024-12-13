using Microsoft.VisualBasic.Devices;

namespace Calculator
{
    partial class Form1
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
            ResBox = new TextBox();
            ZeroBtn = new Button();
            FourBtn = new Button();
            OneBtn = new Button();
            SevenBtn = new Button();
            EightBtn = new Button();
            TwoBtn = new Button();
            FiveBtn = new Button();
            DotBtn = new Button();
            NineBtn = new Button();
            ThreeBtn = new Button();
            SixBtn = new Button();
            AnsBtn = new Button();
            ClearBtn = new Button();
            DivBtn = new Button();
            SubBtn = new Button();
            MultiBtn = new Button();
            PlusBtn = new Button();
            PowBtn = new Button();
            PercentBtn = new Button();
            button2 = new Button();
            HistoryBtn = new Button();
            RightBtn = new Button();
            LeftBtn = new Button();
            DELBtn = new Button();
            SuspendLayout();
            // 
            // ResBox
            // 
            ResBox.Font = new Font("Segoe UI", 30F);
            ResBox.Location = new Point(12, 12);
            ResBox.Name = "ResBox";
            ResBox.Size = new Size(512, 61);
            ResBox.TabIndex = 0;
            ResBox.Text = "0";
            ResBox.TextAlign = HorizontalAlignment.Right;
            ResBox.TextChanged += ResBox_TextChanged;
            // 
            // ZeroBtn
            // 
            ZeroBtn.Font = new Font("Segoe UI", 20F);
            ZeroBtn.Location = new Point(12, 365);
            ZeroBtn.Name = "ZeroBtn";
            ZeroBtn.Size = new Size(75, 71);
            ZeroBtn.TabIndex = 1;
            ZeroBtn.Text = "0";
            ZeroBtn.UseVisualStyleBackColor = true;
            ZeroBtn.Click += ZeroBtn_Click;
            // 
            // FourBtn
            // 
            FourBtn.Font = new Font("Segoe UI", 20F);
            FourBtn.Location = new Point(12, 211);
            FourBtn.Name = "FourBtn";
            FourBtn.Size = new Size(75, 71);
            FourBtn.TabIndex = 5;
            FourBtn.Text = "4";
            FourBtn.UseVisualStyleBackColor = true;
            FourBtn.Click += FourBtn_Click;
            // 
            // OneBtn
            // 
            OneBtn.Font = new Font("Segoe UI", 20F);
            OneBtn.Location = new Point(12, 288);
            OneBtn.Name = "OneBtn";
            OneBtn.Size = new Size(75, 71);
            OneBtn.TabIndex = 6;
            OneBtn.Text = "1";
            OneBtn.UseVisualStyleBackColor = true;
            OneBtn.Click += OneBtn_Click;
            // 
            // SevenBtn
            // 
            SevenBtn.Font = new Font("Segoe UI", 20F);
            SevenBtn.Location = new Point(12, 134);
            SevenBtn.Name = "SevenBtn";
            SevenBtn.Size = new Size(75, 71);
            SevenBtn.TabIndex = 7;
            SevenBtn.Text = "7";
            SevenBtn.UseVisualStyleBackColor = true;
            SevenBtn.Click += SevenBtn_Click;
            // 
            // EightBtn
            // 
            EightBtn.Font = new Font("Segoe UI", 20F);
            EightBtn.Location = new Point(93, 134);
            EightBtn.Name = "EightBtn";
            EightBtn.Size = new Size(75, 71);
            EightBtn.TabIndex = 11;
            EightBtn.Text = "8";
            EightBtn.UseVisualStyleBackColor = true;
            EightBtn.Click += EightBtn_Click;
            // 
            // TwoBtn
            // 
            TwoBtn.Font = new Font("Segoe UI", 20F);
            TwoBtn.Location = new Point(93, 288);
            TwoBtn.Name = "TwoBtn";
            TwoBtn.Size = new Size(75, 71);
            TwoBtn.TabIndex = 10;
            TwoBtn.Text = "2";
            TwoBtn.UseVisualStyleBackColor = true;
            TwoBtn.Click += TwoBtn_Click;
            // 
            // FiveBtn
            // 
            FiveBtn.Font = new Font("Segoe UI", 20F);
            FiveBtn.Location = new Point(93, 211);
            FiveBtn.Name = "FiveBtn";
            FiveBtn.Size = new Size(75, 71);
            FiveBtn.TabIndex = 9;
            FiveBtn.Text = "5";
            FiveBtn.UseVisualStyleBackColor = true;
            FiveBtn.Click += FiveBtn_Click;
            // 
            // DotBtn
            // 
            DotBtn.Font = new Font("Segoe UI", 20F);
            DotBtn.Location = new Point(93, 365);
            DotBtn.Name = "DotBtn";
            DotBtn.Size = new Size(75, 71);
            DotBtn.TabIndex = 8;
            DotBtn.Text = ".";
            DotBtn.UseVisualStyleBackColor = true;
            DotBtn.Click += DotBtn_Click;
            // 
            // NineBtn
            // 
            NineBtn.Font = new Font("Segoe UI", 20F);
            NineBtn.Location = new Point(174, 134);
            NineBtn.Name = "NineBtn";
            NineBtn.Size = new Size(75, 71);
            NineBtn.TabIndex = 15;
            NineBtn.Text = "9";
            NineBtn.UseVisualStyleBackColor = true;
            NineBtn.Click += NineBtn_Click;
            // 
            // ThreeBtn
            // 
            ThreeBtn.Font = new Font("Segoe UI", 20F);
            ThreeBtn.Location = new Point(174, 288);
            ThreeBtn.Name = "ThreeBtn";
            ThreeBtn.Size = new Size(75, 71);
            ThreeBtn.TabIndex = 14;
            ThreeBtn.Text = "3";
            ThreeBtn.UseVisualStyleBackColor = true;
            ThreeBtn.Click += ThreeBtn_Click;
            // 
            // SixBtn
            // 
            SixBtn.Font = new Font("Segoe UI", 20F);
            SixBtn.Location = new Point(174, 211);
            SixBtn.Name = "SixBtn";
            SixBtn.Size = new Size(75, 71);
            SixBtn.TabIndex = 13;
            SixBtn.Text = "6";
            SixBtn.UseVisualStyleBackColor = true;
            SixBtn.Click += SixBtn_Click;
            // 
            // AnsBtn
            // 
            AnsBtn.Font = new Font("Segoe UI", 20F);
            AnsBtn.Location = new Point(449, 288);
            AnsBtn.Name = "AnsBtn";
            AnsBtn.Size = new Size(75, 148);
            AnsBtn.TabIndex = 12;
            AnsBtn.Text = "=";
            AnsBtn.UseVisualStyleBackColor = true;
            AnsBtn.Click += AnsBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Font = new Font("Segoe UI", 20F);
            ClearBtn.Location = new Point(449, 134);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(75, 71);
            ClearBtn.TabIndex = 19;
            ClearBtn.Text = "CE";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // DivBtn
            // 
            DivBtn.Font = new Font("Segoe UI", 20F);
            DivBtn.Location = new Point(368, 288);
            DivBtn.Name = "DivBtn";
            DivBtn.Size = new Size(75, 71);
            DivBtn.TabIndex = 18;
            DivBtn.Text = "/";
            DivBtn.UseVisualStyleBackColor = true;
            DivBtn.Click += DivBtn_Click;
            // 
            // SubBtn
            // 
            SubBtn.Font = new Font("Segoe UI", 20F);
            SubBtn.Location = new Point(368, 211);
            SubBtn.Name = "SubBtn";
            SubBtn.Size = new Size(75, 71);
            SubBtn.TabIndex = 17;
            SubBtn.Text = "-";
            SubBtn.UseVisualStyleBackColor = true;
            SubBtn.Click += SubBtn_Click;
            // 
            // MultiBtn
            // 
            MultiBtn.Font = new Font("Segoe UI", 20F);
            MultiBtn.Location = new Point(287, 288);
            MultiBtn.Name = "MultiBtn";
            MultiBtn.Size = new Size(75, 71);
            MultiBtn.TabIndex = 22;
            MultiBtn.Text = "X";
            MultiBtn.UseVisualStyleBackColor = true;
            MultiBtn.Click += MultiBtn_Click;
            // 
            // PlusBtn
            // 
            PlusBtn.Font = new Font("Segoe UI", 20F);
            PlusBtn.Location = new Point(449, 211);
            PlusBtn.Name = "PlusBtn";
            PlusBtn.Size = new Size(75, 71);
            PlusBtn.TabIndex = 21;
            PlusBtn.Text = "+";
            PlusBtn.UseVisualStyleBackColor = true;
            PlusBtn.Click += PlusBtn_Click;
            // 
            // PowBtn
            // 
            PowBtn.Font = new Font("Segoe UI", 20F);
            PowBtn.Location = new Point(174, 365);
            PowBtn.Name = "PowBtn";
            PowBtn.Size = new Size(75, 71);
            PowBtn.TabIndex = 20;
            PowBtn.UseVisualStyleBackColor = true;
            PowBtn.Click += PowBtn_Click;
            // 
            // PercentBtn
            // 
            PercentBtn.Font = new Font("Segoe UI", 20F);
            PercentBtn.Location = new Point(287, 211);
            PercentBtn.Name = "PercentBtn";
            PercentBtn.Size = new Size(75, 71);
            PercentBtn.TabIndex = 23;
            PercentBtn.Text = "%";
            PercentBtn.UseVisualStyleBackColor = true;
            PercentBtn.Click += PercentBtn_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20F);
            button2.Location = new Point(287, 365);
            button2.Name = "button2";
            button2.Size = new Size(75, 71);
            button2.TabIndex = 24;
            button2.Text = "√x";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // HistoryBtn
            // 
            HistoryBtn.Font = new Font("Segoe UI", 20F);
            HistoryBtn.Location = new Point(12, 442);
            HistoryBtn.Name = "HistoryBtn";
            HistoryBtn.Size = new Size(512, 53);
            HistoryBtn.TabIndex = 25;
            HistoryBtn.Text = "Hiện lịch sử tính";
            HistoryBtn.UseVisualStyleBackColor = true;
            HistoryBtn.Click += HistoryBtn_Click;
            // 
            // RightBtn
            // 
            RightBtn.Font = new Font("Segoe UI", 20F);
            RightBtn.Location = new Point(287, 134);
            RightBtn.Name = "RightBtn";
            RightBtn.Size = new Size(75, 71);
            RightBtn.TabIndex = 26;
            RightBtn.Text = "(";
            RightBtn.UseVisualStyleBackColor = true;
            RightBtn.Click += RightBtn_Click;
            // 
            // LeftBtn
            // 
            LeftBtn.Font = new Font("Segoe UI", 20F);
            LeftBtn.Location = new Point(368, 134);
            LeftBtn.Name = "LeftBtn";
            LeftBtn.Size = new Size(75, 71);
            LeftBtn.TabIndex = 27;
            LeftBtn.Text = ")";
            LeftBtn.UseVisualStyleBackColor = true;
            LeftBtn.Click += LeftBtn_Click;
            // 
            // DELBtn
            // 
            DELBtn.Font = new Font("Segoe UI", 20F);
            DELBtn.Location = new Point(368, 365);
            DELBtn.Name = "DELBtn";
            DELBtn.Size = new Size(75, 71);
            DELBtn.TabIndex = 28;
            DELBtn.Text = "DEL";
            DELBtn.UseVisualStyleBackColor = true;
            DELBtn.Click += DELBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 518);
            Controls.Add(DELBtn);
            Controls.Add(LeftBtn);
            Controls.Add(RightBtn);
            Controls.Add(HistoryBtn);
            Controls.Add(button2);
            Controls.Add(PercentBtn);
            Controls.Add(MultiBtn);
            Controls.Add(PlusBtn);
            Controls.Add(PowBtn);
            Controls.Add(ClearBtn);
            Controls.Add(DivBtn);
            Controls.Add(SubBtn);
            Controls.Add(NineBtn);
            Controls.Add(ThreeBtn);
            Controls.Add(SixBtn);
            Controls.Add(AnsBtn);
            Controls.Add(EightBtn);
            Controls.Add(TwoBtn);
            Controls.Add(FiveBtn);
            Controls.Add(DotBtn);
            Controls.Add(SevenBtn);
            Controls.Add(OneBtn);
            Controls.Add(FourBtn);
            Controls.Add(ZeroBtn);
            Controls.Add(ResBox);
            Name = "Form1";
            Text = "Calculator App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ResBox;
        private Button ZeroBtn;
        private Button FourBtn;
        private Button OneBtn;
        private Button SevenBtn;
        private Button EightBtn;
        private Button TwoBtn;
        private Button FiveBtn;
        private Button DotBtn;
        private Button NineBtn;
        private Button ThreeBtn;
        private Button SixBtn;
        private Button AnsBtn;
        private Button ClearBtn;
        private Button DivBtn;
        private Button SubBtn;
        private Button MultiBtn;
        private Button PlusBtn;
        private Button PowBtn;
        private Button PercentBtn;
        private Button button2;
        private Button HistoryBtn;
        private Button RightBtn;
        private Button LeftBtn;
        private Button DELBtn;
    }
}
