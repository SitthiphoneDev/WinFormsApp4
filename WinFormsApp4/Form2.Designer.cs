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
            btngray2 = new Button();
            btnopen = new Button();
            btnbw = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtT = new TextBox();
            btnnsgative = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            button4 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            button5 = new Button();
            button6 = new Button();
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
            // btngray2
            // 
            btngray2.Location = new Point(229, 16);
            btngray2.Name = "btngray2";
            btngray2.Size = new Size(114, 36);
            btngray2.TabIndex = 2;
            btngray2.Text = "Gray Scale 2";
            btngray2.UseVisualStyleBackColor = true;
            // 
            // btnopen
            // 
            btnopen.Location = new Point(349, 16);
            btnopen.Name = "btnopen";
            btnopen.Size = new Size(116, 36);
            btnopen.TabIndex = 3;
            btnopen.Text = "Open Image";
            btnopen.UseVisualStyleBackColor = true;
            btnopen.Click += btnopen_Click;
            // 
            // btnbw
            // 
            btnbw.Location = new Point(486, 79);
            btnbw.Name = "btnbw";
            btnbw.Size = new Size(169, 42);
            btnbw.TabIndex = 4;
            btnbw.Text = "Black and White";
            btnbw.UseVisualStyleBackColor = true;
            btnbw.Click += btnbw_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(27, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(421, 322);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(491, 148);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 6;
            label1.Text = "Thteshold: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(578, 145);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(93, 29);
            textBox1.TabIndex = 7;
            textBox1.Text = "150";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(btnbw);
            Controls.Add(btnopen);
            Controls.Add(btngray2);
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
        private Button btngray2;
        private Button btnopen;
        private Button btnbw;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox1;
    }
}