namespace EmguCVDemo
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
            components = new System.ComponentModel.Container();
            btn_Start = new Button();
            btn_Stop = new Button();
            pictureBox1 = new PictureBox();
            label = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Start
            // 
            btn_Start.Location = new Point(260, 476);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(112, 34);
            btn_Start.TabIndex = 0;
            btn_Start.Text = "Start";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // btn_Stop
            // 
            btn_Stop.Location = new Point(529, 476);
            btn_Stop.Name = "btn_Stop";
            btn_Stop.Size = new Size(112, 34);
            btn_Stop.TabIndex = 1;
            btn_Stop.Text = "Stop";
            btn_Stop.UseVisualStyleBackColor = true;
            btn_Stop.Click += btn_Stop_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(35, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1118, 434);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(960, 481);
            label.Name = "label";
            label.Size = new Size(59, 25);
            label.TabIndex = 3;
            label.Text = "label1";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1186, 532);
            Controls.Add(label);
            Controls.Add(pictureBox1);
            Controls.Add(btn_Stop);
            Controls.Add(btn_Start);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Start;
        private Button btn_Stop;
        private PictureBox pictureBox1;
        private Label label;
        private System.Windows.Forms.Timer timer1;
    }
}