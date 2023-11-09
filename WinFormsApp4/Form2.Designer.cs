namespace WinFormsApp4
{
    partial class Form2
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
            btnOrigin = new Button();
            btngray1 = new Button();
            btnopen = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtT = new TextBox();
            btnnsgative = new Button();
            button2 = new Button();
            button3 = new Button();
            txtc = new TextBox();
            label2 = new Label();
            txtc2 = new TextBox();
            label3 = new Label();
            button4 = new Button();
            txtgm = new TextBox();
            label4 = new Label();
            button5 = new Button();
            button6 = new Button();
            btnglay2 = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnOrigin
            // 
            btnOrigin.Location = new Point(27, 16);
            btnOrigin.Name = "btnOrigin";
            btnOrigin.Size = new Size(95, 36);
            btnOrigin.TabIndex = 0;
            btnOrigin.Text = "Origin";
            btnOrigin.UseVisualStyleBackColor = true;
            btnOrigin.Click += btnOrigin_Click;
            // 
            // btngray1
            // 
            btngray1.Location = new Point(128, 16);
            btngray1.Name = "btngray1";
            btngray1.Size = new Size(95, 36);
            btngray1.TabIndex = 1;
            btngray1.Text = "Gray Scale";
            btngray1.UseVisualStyleBackColor = true;
            btngray1.Click += btngray1_Click;
            // 
            // btnopen
            // 
            btnopen.BackColor = SystemColors.GradientActiveCaption;
            btnopen.ForeColor = SystemColors.Highlight;
            btnopen.Location = new Point(369, 16);
            btnopen.Name = "btnopen";
            btnopen.Size = new Size(116, 36);
            btnopen.TabIndex = 3;
            btnopen.Text = "Open Image";
            btnopen.UseVisualStyleBackColor = false;
            btnopen.Click += btnopen_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(27, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(438, 366);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(491, 133);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 6;
            label1.Text = "Thteshold: ";
            // 
            // txtT
            // 
            txtT.Location = new Point(582, 130);
            txtT.Multiline = true;
            txtT.Name = "txtT";
            txtT.Size = new Size(93, 29);
            txtT.TabIndex = 7;
            txtT.Text = "128";
            txtT.TextChanged += txtT_TextChanged;
            // 
            // btnnsgative
            // 
            btnnsgative.Location = new Point(491, 203);
            btnnsgative.Name = "btnnsgative";
            btnnsgative.Size = new Size(108, 32);
            btnnsgative.TabIndex = 8;
            btnnsgative.Text = "Nagative";
            btnnsgative.UseVisualStyleBackColor = true;
            btnnsgative.Click += btnnsgative_Click;
            // 
            // button2
            // 
            button2.Location = new Point(491, 165);
            button2.Name = "button2";
            button2.Size = new Size(108, 32);
            button2.TabIndex = 9;
            button2.Text = "Invert";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(491, 255);
            button3.Name = "button3";
            button3.Size = new Size(169, 34);
            button3.TabIndex = 10;
            button3.Text = "Log Transformation";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtc
            // 
            txtc.Location = new Point(582, 295);
            txtc.Multiline = true;
            txtc.Name = "txtc";
            txtc.Size = new Size(93, 29);
            txtc.TabIndex = 12;
            txtc.Text = "30";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(491, 298);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 11;
            label2.Text = "C : ";
            // 
            // txtc2
            // 
            txtc2.Location = new Point(582, 370);
            txtc2.Multiline = true;
            txtc2.Name = "txtc2";
            txtc2.Size = new Size(93, 29);
            txtc2.TabIndex = 14;
            txtc2.Text = "1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(491, 373);
            label3.Name = "label3";
            label3.Size = new Size(29, 20);
            label3.TabIndex = 13;
            label3.Text = "C : ";
            // 
            // button4
            // 
            button4.Location = new Point(495, 330);
            button4.Name = "button4";
            button4.Size = new Size(169, 34);
            button4.TabIndex = 15;
            button4.Text = "Power Low";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // txtgm
            // 
            txtgm.Location = new Point(582, 405);
            txtgm.Multiline = true;
            txtgm.Name = "txtgm";
            txtgm.Size = new Size(93, 29);
            txtgm.TabIndex = 17;
            txtgm.Text = "2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(491, 408);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 16;
            label4.Text = "Gamma: ";
            // 
            // button5
            // 
            button5.Location = new Point(27, 455);
            button5.Name = "button5";
            button5.Size = new Size(169, 34);
            button5.TabIndex = 18;
            button5.Text = "Median Filter";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(296, 455);
            button6.Name = "button6";
            button6.Size = new Size(169, 34);
            button6.TabIndex = 19;
            button6.Text = "Mean Filter";
            button6.UseVisualStyleBackColor = true;
            // 
            // btnglay2
            // 
            btnglay2.Location = new Point(238, 16);
            btnglay2.Name = "btnglay2";
            btnglay2.Size = new Size(105, 36);
            btnglay2.TabIndex = 22;
            btnglay2.Text = "Gray Scale 2";
            btnglay2.UseVisualStyleBackColor = true;
            btnglay2.Click += btnglay2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(491, 70);
            button1.Name = "button1";
            button1.Size = new Size(156, 36);
            button1.TabIndex = 23;
            button1.Text = "Black and White";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 521);
            Controls.Add(button1);
            Controls.Add(btnglay2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(txtgm);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(txtc2);
            Controls.Add(label3);
            Controls.Add(txtc);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnnsgative);
            Controls.Add(txtT);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnopen);
            Controls.Add(btngray1);
            Controls.Add(btnOrigin);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOrigin;
        private Button btngray1;
        private Button btnopen;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtT;
        private Button btnnsgative;
        private Button button2;
        private Button button3;
        private TextBox txtc;
        private Label label2;
        private TextBox txtc2;
        private Label label3;
        private Button button4;
        private TextBox txtgm;
        private Label label4;
        private Button button5;
        private Button button6;
        private Button btnglay2;
        private Button button1;
    }
}