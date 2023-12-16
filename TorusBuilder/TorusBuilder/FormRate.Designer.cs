namespace TorusBuilder
{
    partial class FormRate
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMsg = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.star_5 = new FontAwesome.Sharp.IconButton();
            this.star_4 = new FontAwesome.Sharp.IconButton();
            this.star_3 = new FontAwesome.Sharp.IconButton();
            this.star_2 = new FontAwesome.Sharp.IconButton();
            this.star_1 = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNot = new FontAwesome.Sharp.IconButton();
            this.btnRemind = new FontAwesome.Sharp.IconButton();
            this.btnSubmit = new FontAwesome.Sharp.IconButton();
            this.timer_delay = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.labelMsg);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 174);
            this.panel1.TabIndex = 0;
            // 
            // labelMsg
            // 
            this.labelMsg.AutoEllipsis = true;
            this.labelMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMsg.ForeColor = System.Drawing.Color.Maroon;
            this.labelMsg.Location = new System.Drawing.Point(10, 110);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(262, 20);
            this.labelMsg.TabIndex = 3;
            this.labelMsg.Text = "Click on a number to rate the app!";
            this.labelMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Silver;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Gold;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Award;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Gold;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 50;
            this.iconPictureBox1.Location = new System.Drawing.Point(116, 20);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(50, 50);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(23, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enjoying TorusBuilder?";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.star_5);
            this.panel2.Controls.Add(this.star_4);
            this.panel2.Controls.Add(this.star_3);
            this.panel2.Controls.Add(this.star_2);
            this.panel2.Controls.Add(this.star_1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 174);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 48);
            this.panel2.TabIndex = 1;
            // 
            // star_5
            // 
            this.star_5.BackColor = System.Drawing.Color.White;
            this.star_5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star_5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.star_5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.star_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.star_5.IconChar = FontAwesome.Sharp.IconChar.None;
            this.star_5.IconColor = System.Drawing.Color.Black;
            this.star_5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.star_5.IconSize = 40;
            this.star_5.Location = new System.Drawing.Point(229, 6);
            this.star_5.Name = "star_5";
            this.star_5.Size = new System.Drawing.Size(36, 36);
            this.star_5.TabIndex = 4;
            this.star_5.Text = "5";
            this.toolTip1.SetToolTip(this.star_5, "Very well!");
            this.star_5.UseVisualStyleBackColor = false;
            this.star_5.Click += new System.EventHandler(this.star_5_Click);
            // 
            // star_4
            // 
            this.star_4.BackColor = System.Drawing.Color.White;
            this.star_4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star_4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.star_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.star_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.star_4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.star_4.IconColor = System.Drawing.Color.Black;
            this.star_4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.star_4.IconSize = 40;
            this.star_4.Location = new System.Drawing.Point(176, 6);
            this.star_4.Name = "star_4";
            this.star_4.Size = new System.Drawing.Size(36, 36);
            this.star_4.TabIndex = 3;
            this.star_4.Text = "4";
            this.toolTip1.SetToolTip(this.star_4, "Good");
            this.star_4.UseVisualStyleBackColor = false;
            this.star_4.Click += new System.EventHandler(this.star_4_Click);
            // 
            // star_3
            // 
            this.star_3.BackColor = System.Drawing.Color.White;
            this.star_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star_3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.star_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.star_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.star_3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.star_3.IconColor = System.Drawing.Color.Black;
            this.star_3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.star_3.IconSize = 40;
            this.star_3.Location = new System.Drawing.Point(123, 6);
            this.star_3.Name = "star_3";
            this.star_3.Size = new System.Drawing.Size(36, 36);
            this.star_3.TabIndex = 2;
            this.star_3.Text = "3";
            this.toolTip1.SetToolTip(this.star_3, "Satisfactorily");
            this.star_3.UseVisualStyleBackColor = false;
            this.star_3.Click += new System.EventHandler(this.star_3_Click);
            // 
            // star_2
            // 
            this.star_2.BackColor = System.Drawing.Color.White;
            this.star_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star_2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.star_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.star_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.star_2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.star_2.IconColor = System.Drawing.Color.Black;
            this.star_2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.star_2.IconSize = 40;
            this.star_2.Location = new System.Drawing.Point(70, 6);
            this.star_2.Name = "star_2";
            this.star_2.Size = new System.Drawing.Size(36, 36);
            this.star_2.TabIndex = 1;
            this.star_2.Text = "2";
            this.toolTip1.SetToolTip(this.star_2, "Badly");
            this.star_2.UseVisualStyleBackColor = false;
            this.star_2.Click += new System.EventHandler(this.star_2_Click);
            // 
            // star_1
            // 
            this.star_1.BackColor = System.Drawing.Color.White;
            this.star_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.star_1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.star_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.star_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.star_1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.star_1.IconColor = System.Drawing.Color.Black;
            this.star_1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.star_1.IconSize = 40;
            this.star_1.Location = new System.Drawing.Point(17, 6);
            this.star_1.Name = "star_1";
            this.star_1.Size = new System.Drawing.Size(36, 36);
            this.star_1.TabIndex = 0;
            this.star_1.Text = "1";
            this.toolTip1.SetToolTip(this.star_1, "Terrible");
            this.star_1.UseVisualStyleBackColor = false;
            this.star_1.Click += new System.EventHandler(this.star_1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnNot);
            this.panel3.Controls.Add(this.btnRemind);
            this.panel3.Controls.Add(this.btnSubmit);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 222);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 131);
            this.panel3.TabIndex = 2;
            // 
            // btnNot
            // 
            this.btnNot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNot.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNot.ForeColor = System.Drawing.Color.White;
            this.btnNot.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnNot.IconColor = System.Drawing.Color.White;
            this.btnNot.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNot.IconSize = 35;
            this.btnNot.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNot.Location = new System.Drawing.Point(0, 80);
            this.btnNot.Name = "btnNot";
            this.btnNot.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNot.Size = new System.Drawing.Size(282, 40);
            this.btnNot.TabIndex = 2;
            this.btnNot.Text = "Don\'t ask again";
            this.btnNot.UseVisualStyleBackColor = false;
            this.btnNot.Click += new System.EventHandler(this.btnNot_Click);
            // 
            // btnRemind
            // 
            this.btnRemind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRemind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemind.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRemind.ForeColor = System.Drawing.Color.White;
            this.btnRemind.IconChar = FontAwesome.Sharp.IconChar.Bell;
            this.btnRemind.IconColor = System.Drawing.Color.White;
            this.btnRemind.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRemind.IconSize = 35;
            this.btnRemind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRemind.Location = new System.Drawing.Point(0, 40);
            this.btnRemind.Name = "btnRemind";
            this.btnRemind.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnRemind.Size = new System.Drawing.Size(282, 40);
            this.btnRemind.TabIndex = 1;
            this.btnRemind.Text = "Remind me later";
            this.btnRemind.UseVisualStyleBackColor = false;
            this.btnRemind.Click += new System.EventHandler(this.btnRemind_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.btnSubmit.IconColor = System.Drawing.Color.White;
            this.btnSubmit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSubmit.IconSize = 35;
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.Location = new System.Drawing.Point(0, 0);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSubmit.Size = new System.Drawing.Size(282, 40);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // timer_delay
            // 
            this.timer_delay.Interval = 3000;
            this.timer_delay.Tick += new System.EventHandler(this.timer_delay_Tick);
            // 
            // FormRate
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(282, 353);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRate";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Rate";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton star_5;
        private FontAwesome.Sharp.IconButton star_4;
        private FontAwesome.Sharp.IconButton star_3;
        private FontAwesome.Sharp.IconButton star_2;
        private FontAwesome.Sharp.IconButton star_1;
        private FontAwesome.Sharp.IconButton btnNot;
        private FontAwesome.Sharp.IconButton btnRemind;
        private FontAwesome.Sharp.IconButton btnSubmit;
        private System.Windows.Forms.Timer timer_delay;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}