namespace TorusBuilder
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.btnApply = new FontAwesome.Sharp.IconButton();
            this.panelOfIndColors = new System.Windows.Forms.Panel();
            this.btnBlue = new FontAwesome.Sharp.IconButton();
            this.btnGreen = new FontAwesome.Sharp.IconButton();
            this.btnRed = new FontAwesome.Sharp.IconButton();
            this.ManualColorControlPanel = new System.Windows.Forms.Panel();
            this.BlueScrollBar = new System.Windows.Forms.VScrollBar();
            this.GreenScrollBar = new System.Windows.Forms.VScrollBar();
            this.RedScrollBar = new System.Windows.Forms.VScrollBar();
            this.blue_value = new System.Windows.Forms.TextBox();
            this.green_value = new System.Windows.Forms.TextBox();
            this.red_value = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rBtnTurnOff = new System.Windows.Forms.RadioButton();
            this.rBtnTurnOn = new System.Windows.Forms.RadioButton();
            this.checkBoxBlue = new System.Windows.Forms.CheckBox();
            this.checkBoxGreen = new System.Windows.Forms.CheckBox();
            this.checkBoxRed = new System.Windows.Forms.CheckBox();
            this.panelShade = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.IconExample = new FontAwesome.Sharp.IconPictureBox();
            this.LabelExample = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelFontName = new System.Windows.Forms.Label();
            this.rBtnForeIconColor = new System.Windows.Forms.RadioButton();
            this.rBtnBackColor = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panelDisplaySettings = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.backColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foreColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panelIndividualsColors = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SelectPropertiesPanel = new System.Windows.Forms.Panel();
            this.rbFont = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panelColorControl = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panelBuiltInTools = new System.Windows.Forms.Panel();
            this.btnBuiltInFont = new FontAwesome.Sharp.IconButton();
            this.btnBuiltInColor = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panelOfIndColors.SuspendLayout();
            this.ManualColorControlPanel.SuspendLayout();
            this.panelShade.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconExample)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelDisplaySettings.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panelIndividualsColors.SuspendLayout();
            this.SelectPropertiesPanel.SuspendLayout();
            this.panelColorControl.SuspendLayout();
            this.panelBuiltInTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.Color.White;
            this.btnApply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApply.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnApply.ForeColor = System.Drawing.Color.Black;
            this.btnApply.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnApply.IconColor = System.Drawing.Color.Black;
            this.btnApply.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnApply.Location = new System.Drawing.Point(190, 480);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(120, 50);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // panelOfIndColors
            // 
            this.panelOfIndColors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOfIndColors.Controls.Add(this.btnBlue);
            this.panelOfIndColors.Controls.Add(this.btnGreen);
            this.panelOfIndColors.Controls.Add(this.btnRed);
            this.panelOfIndColors.Location = new System.Drawing.Point(505, 480);
            this.panelOfIndColors.Name = "panelOfIndColors";
            this.panelOfIndColors.Size = new System.Drawing.Size(435, 50);
            this.panelOfIndColors.TabIndex = 6;
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.White;
            this.btnBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBlue.ForeColor = System.Drawing.Color.Blue;
            this.btnBlue.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnBlue.IconColor = System.Drawing.Color.Black;
            this.btnBlue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBlue.Location = new System.Drawing.Point(341, 5);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(60, 40);
            this.btnBlue.TabIndex = 2;
            this.btnBlue.Text = "B";
            this.toolTip1.SetToolTip(this.btnBlue, "Sets the color (0, 0, 255)");
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.White;
            this.btnGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGreen.ForeColor = System.Drawing.Color.Green;
            this.btnGreen.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGreen.IconColor = System.Drawing.Color.Black;
            this.btnGreen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGreen.Location = new System.Drawing.Point(207, 5);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(60, 40);
            this.btnGreen.TabIndex = 1;
            this.btnGreen.Text = "G";
            this.toolTip1.SetToolTip(this.btnGreen, "Sets the color (0, 255, 0)");
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.White;
            this.btnRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRed.ForeColor = System.Drawing.Color.Red;
            this.btnRed.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRed.IconColor = System.Drawing.Color.Black;
            this.btnRed.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRed.Location = new System.Drawing.Point(74, 5);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(60, 40);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "R";
            this.toolTip1.SetToolTip(this.btnRed, "Sets the color (255, 0, 0)");
            this.btnRed.UseVisualStyleBackColor = false;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // ManualColorControlPanel
            // 
            this.ManualColorControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ManualColorControlPanel.Controls.Add(this.BlueScrollBar);
            this.ManualColorControlPanel.Controls.Add(this.GreenScrollBar);
            this.ManualColorControlPanel.Controls.Add(this.RedScrollBar);
            this.ManualColorControlPanel.Controls.Add(this.blue_value);
            this.ManualColorControlPanel.Controls.Add(this.green_value);
            this.ManualColorControlPanel.Controls.Add(this.red_value);
            this.ManualColorControlPanel.Controls.Add(this.label4);
            this.ManualColorControlPanel.Controls.Add(this.label3);
            this.ManualColorControlPanel.Controls.Add(this.label2);
            this.ManualColorControlPanel.Location = new System.Drawing.Point(505, 170);
            this.ManualColorControlPanel.Name = "ManualColorControlPanel";
            this.ManualColorControlPanel.Size = new System.Drawing.Size(435, 300);
            this.ManualColorControlPanel.TabIndex = 5;
            // 
            // BlueScrollBar
            // 
            this.BlueScrollBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BlueScrollBar.Location = new System.Drawing.Point(341, 50);
            this.BlueScrollBar.Maximum = 255;
            this.BlueScrollBar.Name = "BlueScrollBar";
            this.BlueScrollBar.Size = new System.Drawing.Size(60, 200);
            this.BlueScrollBar.TabIndex = 11;
            this.BlueScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.BlueScrollBar_Scroll);
            // 
            // GreenScrollBar
            // 
            this.GreenScrollBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GreenScrollBar.Location = new System.Drawing.Point(207, 50);
            this.GreenScrollBar.Maximum = 255;
            this.GreenScrollBar.Name = "GreenScrollBar";
            this.GreenScrollBar.Size = new System.Drawing.Size(60, 200);
            this.GreenScrollBar.TabIndex = 10;
            this.GreenScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.GreenScrollBar_Scroll);
            // 
            // RedScrollBar
            // 
            this.RedScrollBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RedScrollBar.Location = new System.Drawing.Point(74, 50);
            this.RedScrollBar.Maximum = 255;
            this.RedScrollBar.Name = "RedScrollBar";
            this.RedScrollBar.Size = new System.Drawing.Size(60, 200);
            this.RedScrollBar.TabIndex = 9;
            this.RedScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RedScrollBar_Scroll);
            // 
            // blue_value
            // 
            this.blue_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blue_value.Location = new System.Drawing.Point(300, 133);
            this.blue_value.Name = "blue_value";
            this.blue_value.Size = new System.Drawing.Size(35, 22);
            this.blue_value.TabIndex = 8;
            this.blue_value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.blue_value_KeyPress);
            // 
            // green_value
            // 
            this.green_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.green_value.Location = new System.Drawing.Point(167, 133);
            this.green_value.Name = "green_value";
            this.green_value.Size = new System.Drawing.Size(35, 22);
            this.green_value.TabIndex = 7;
            this.green_value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.green_value_KeyPress);
            // 
            // red_value
            // 
            this.red_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.red_value.Location = new System.Drawing.Point(33, 133);
            this.red_value.Name = "red_value";
            this.red_value.Size = new System.Drawing.Size(35, 22);
            this.red_value.TabIndex = 6;
            this.red_value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.red_value_KeyPress);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(341, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "B";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(207, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "G";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(74, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "R";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rBtnTurnOff
            // 
            this.rBtnTurnOff.BackColor = System.Drawing.Color.White;
            this.rBtnTurnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBtnTurnOff.Dock = System.Windows.Forms.DockStyle.Top;
            this.rBtnTurnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBtnTurnOff.Location = new System.Drawing.Point(0, 55);
            this.rBtnTurnOff.Name = "rBtnTurnOff";
            this.rBtnTurnOff.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rBtnTurnOff.Size = new System.Drawing.Size(198, 30);
            this.rBtnTurnOff.TabIndex = 1;
            this.rBtnTurnOff.TabStop = true;
            this.rBtnTurnOff.Text = "Turn off";
            this.rBtnTurnOff.UseVisualStyleBackColor = false;
            this.rBtnTurnOff.CheckedChanged += new System.EventHandler(this.rBtnTurnOff_CheckedChanged);
            // 
            // rBtnTurnOn
            // 
            this.rBtnTurnOn.BackColor = System.Drawing.Color.White;
            this.rBtnTurnOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBtnTurnOn.Dock = System.Windows.Forms.DockStyle.Top;
            this.rBtnTurnOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBtnTurnOn.Location = new System.Drawing.Point(0, 25);
            this.rBtnTurnOn.Name = "rBtnTurnOn";
            this.rBtnTurnOn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rBtnTurnOn.Size = new System.Drawing.Size(198, 30);
            this.rBtnTurnOn.TabIndex = 0;
            this.rBtnTurnOn.TabStop = true;
            this.rBtnTurnOn.Text = "Turn on";
            this.rBtnTurnOn.UseVisualStyleBackColor = false;
            this.rBtnTurnOn.CheckedChanged += new System.EventHandler(this.rBtnTurnOn_CheckedChanged);
            // 
            // checkBoxBlue
            // 
            this.checkBoxBlue.BackColor = System.Drawing.Color.White;
            this.checkBoxBlue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxBlue.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxBlue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxBlue.Location = new System.Drawing.Point(0, 75);
            this.checkBoxBlue.Name = "checkBoxBlue";
            this.checkBoxBlue.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.checkBoxBlue.Size = new System.Drawing.Size(198, 25);
            this.checkBoxBlue.TabIndex = 2;
            this.checkBoxBlue.Text = "Blue Control";
            this.checkBoxBlue.UseVisualStyleBackColor = false;
            this.checkBoxBlue.CheckedChanged += new System.EventHandler(this.checkBoxBlue_CheckedChanged);
            // 
            // checkBoxGreen
            // 
            this.checkBoxGreen.BackColor = System.Drawing.Color.White;
            this.checkBoxGreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxGreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxGreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxGreen.Location = new System.Drawing.Point(0, 50);
            this.checkBoxGreen.Name = "checkBoxGreen";
            this.checkBoxGreen.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.checkBoxGreen.Size = new System.Drawing.Size(198, 25);
            this.checkBoxGreen.TabIndex = 1;
            this.checkBoxGreen.Text = "Green Control";
            this.checkBoxGreen.UseVisualStyleBackColor = false;
            this.checkBoxGreen.CheckedChanged += new System.EventHandler(this.checkBoxGreen_CheckedChanged);
            // 
            // checkBoxRed
            // 
            this.checkBoxRed.BackColor = System.Drawing.Color.White;
            this.checkBoxRed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxRed.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkBoxRed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxRed.Location = new System.Drawing.Point(0, 25);
            this.checkBoxRed.Name = "checkBoxRed";
            this.checkBoxRed.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.checkBoxRed.Size = new System.Drawing.Size(198, 25);
            this.checkBoxRed.TabIndex = 0;
            this.checkBoxRed.Text = "Red Control";
            this.checkBoxRed.UseVisualStyleBackColor = false;
            this.checkBoxRed.CheckedChanged += new System.EventHandler(this.checkBoxRed_CheckedChanged);
            // 
            // panelShade
            // 
            this.panelShade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelShade.Controls.Add(this.panel3);
            this.panelShade.Controls.Add(this.panel2);
            this.panelShade.Location = new System.Drawing.Point(35, 170);
            this.panelShade.Name = "panelShade";
            this.panelShade.Size = new System.Drawing.Size(435, 300);
            this.panelShade.TabIndex = 2;
            this.toolTip1.SetToolTip(this.panelShade, "Preview area");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.IconExample);
            this.panel3.Controls.Add(this.LabelExample);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(433, 171);
            this.panel3.TabIndex = 4;
            // 
            // IconExample
            // 
            this.IconExample.BackColor = System.Drawing.Color.Transparent;
            this.IconExample.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IconExample.IconChar = FontAwesome.Sharp.IconChar.HourglassEnd;
            this.IconExample.IconColor = System.Drawing.SystemColors.ControlText;
            this.IconExample.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconExample.IconSize = 50;
            this.IconExample.Location = new System.Drawing.Point(191, 60);
            this.IconExample.Name = "IconExample";
            this.IconExample.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.IconExample.Size = new System.Drawing.Size(50, 50);
            this.IconExample.TabIndex = 1;
            this.IconExample.TabStop = false;
            this.toolTip1.SetToolTip(this.IconExample, "Preview icon");
            // 
            // LabelExample
            // 
            this.LabelExample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelExample.Location = new System.Drawing.Point(0, 0);
            this.LabelExample.Name = "LabelExample";
            this.LabelExample.Size = new System.Drawing.Size(433, 171);
            this.LabelExample.TabIndex = 0;
            this.LabelExample.Text = "TEXT COLOR";
            this.LabelExample.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolTip1.SetToolTip(this.LabelExample, "Preview tеxt");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelFontName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 171);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 127);
            this.panel2.TabIndex = 3;
            // 
            // labelFontName
            // 
            this.labelFontName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFontName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFontName.Location = new System.Drawing.Point(0, 0);
            this.labelFontName.Name = "labelFontName";
            this.labelFontName.Size = new System.Drawing.Size(433, 127);
            this.labelFontName.TabIndex = 2;
            this.labelFontName.Text = "FONT NAME";
            this.labelFontName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // rBtnForeIconColor
            // 
            this.rBtnForeIconColor.BackColor = System.Drawing.Color.White;
            this.rBtnForeIconColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBtnForeIconColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.rBtnForeIconColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBtnForeIconColor.Location = new System.Drawing.Point(0, 50);
            this.rBtnForeIconColor.Name = "rBtnForeIconColor";
            this.rBtnForeIconColor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rBtnForeIconColor.Size = new System.Drawing.Size(198, 25);
            this.rBtnForeIconColor.TabIndex = 1;
            this.rBtnForeIconColor.Text = "Text and Icon Color";
            this.rBtnForeIconColor.UseVisualStyleBackColor = false;
            this.rBtnForeIconColor.CheckedChanged += new System.EventHandler(this.rBtnForeIconColor_CheckedChanged);
            // 
            // rBtnBackColor
            // 
            this.rBtnBackColor.BackColor = System.Drawing.Color.White;
            this.rBtnBackColor.Checked = true;
            this.rBtnBackColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBtnBackColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.rBtnBackColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rBtnBackColor.Location = new System.Drawing.Point(0, 25);
            this.rBtnBackColor.Name = "rBtnBackColor";
            this.rBtnBackColor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rBtnBackColor.Size = new System.Drawing.Size(198, 25);
            this.rBtnBackColor.TabIndex = 0;
            this.rBtnBackColor.TabStop = true;
            this.rBtnBackColor.Text = "Background color";
            this.rBtnBackColor.UseVisualStyleBackColor = false;
            this.rBtnBackColor.CheckedChanged += new System.EventHandler(this.rBtnBackColor_CheckedChanged);
            // 
            // colorDialog1
            // 
            this.colorDialog1.Tag = "Settings";
            // 
            // panelDisplaySettings
            // 
            this.panelDisplaySettings.BackColor = System.Drawing.Color.MintCream;
            this.panelDisplaySettings.Controls.Add(this.toolStrip1);
            this.panelDisplaySettings.Controls.Add(this.panelIndividualsColors);
            this.panelDisplaySettings.Controls.Add(this.SelectPropertiesPanel);
            this.panelDisplaySettings.Controls.Add(this.panelColorControl);
            this.panelDisplaySettings.Controls.Add(this.panelBuiltInTools);
            this.panelDisplaySettings.Controls.Add(this.panelOfIndColors);
            this.panelDisplaySettings.Controls.Add(this.btnApply);
            this.panelDisplaySettings.Controls.Add(this.ManualColorControlPanel);
            this.panelDisplaySettings.Controls.Add(this.panelShade);
            this.panelDisplaySettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDisplaySettings.Location = new System.Drawing.Point(0, 0);
            this.panelDisplaySettings.Name = "panelDisplaySettings";
            this.panelDisplaySettings.Size = new System.Drawing.Size(975, 550);
            this.panelDisplaySettings.TabIndex = 2;
            this.panelDisplaySettings.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelDisplaySettings_MouseClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.toolStripSeparator2,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(975, 30);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.AutoSize = false;
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backColorToolStripMenuItem,
            this.foreColorToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.toolStripDropDownButton2.ForeColor = System.Drawing.Color.Black;
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(79, 27);
            this.toolStripDropDownButton2.Text = "Default";
            // 
            // backColorToolStripMenuItem
            // 
            this.backColorToolStripMenuItem.Name = "backColorToolStripMenuItem";
            this.backColorToolStripMenuItem.Size = new System.Drawing.Size(172, 28);
            this.backColorToolStripMenuItem.Text = "Back color";
            this.backColorToolStripMenuItem.ToolTipText = "Sets defaukt back color";
            this.backColorToolStripMenuItem.Click += new System.EventHandler(this.backColorToolStripMenuItem_Click);
            // 
            // foreColorToolStripMenuItem
            // 
            this.foreColorToolStripMenuItem.Name = "foreColorToolStripMenuItem";
            this.foreColorToolStripMenuItem.Size = new System.Drawing.Size(172, 28);
            this.foreColorToolStripMenuItem.Text = "Fore color";
            this.foreColorToolStripMenuItem.ToolTipText = "Sets default fore and icon color";
            this.foreColorToolStripMenuItem.Click += new System.EventHandler(this.foreColorToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(172, 28);
            this.fontToolStripMenuItem.Text = "Font";
            this.fontToolStripMenuItem.ToolTipText = "Sets default font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 30);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Black;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(361, 27);
            this.toolStripLabel1.Text = "After selecting the default setting, click on the \"Apply\" button";
            // 
            // panelIndividualsColors
            // 
            this.panelIndividualsColors.BackColor = System.Drawing.Color.White;
            this.panelIndividualsColors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelIndividualsColors.Controls.Add(this.label5);
            this.panelIndividualsColors.Controls.Add(this.rBtnTurnOff);
            this.panelIndividualsColors.Controls.Add(this.rBtnTurnOn);
            this.panelIndividualsColors.Controls.Add(this.label8);
            this.panelIndividualsColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelIndividualsColors.Location = new System.Drawing.Point(740, 40);
            this.panelIndividualsColors.Name = "panelIndividualsColors";
            this.panelIndividualsColors.Size = new System.Drawing.Size(200, 110);
            this.panelIndividualsColors.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(0, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(198, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Bottom panel";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 25);
            this.label8.TabIndex = 0;
            this.label8.Text = "Panel of individual colors";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SelectPropertiesPanel
            // 
            this.SelectPropertiesPanel.BackColor = System.Drawing.Color.White;
            this.SelectPropertiesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectPropertiesPanel.Controls.Add(this.rbFont);
            this.SelectPropertiesPanel.Controls.Add(this.rBtnForeIconColor);
            this.SelectPropertiesPanel.Controls.Add(this.rBtnBackColor);
            this.SelectPropertiesPanel.Controls.Add(this.label7);
            this.SelectPropertiesPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectPropertiesPanel.Location = new System.Drawing.Point(35, 40);
            this.SelectPropertiesPanel.Name = "SelectPropertiesPanel";
            this.SelectPropertiesPanel.Size = new System.Drawing.Size(200, 110);
            this.SelectPropertiesPanel.TabIndex = 15;
            // 
            // rbFont
            // 
            this.rbFont.BackColor = System.Drawing.Color.White;
            this.rbFont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbFont.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbFont.Location = new System.Drawing.Point(0, 75);
            this.rbFont.Name = "rbFont";
            this.rbFont.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rbFont.Size = new System.Drawing.Size(198, 25);
            this.rbFont.TabIndex = 2;
            this.rbFont.Text = "Font";
            this.rbFont.UseVisualStyleBackColor = false;
            this.rbFont.CheckedChanged += new System.EventHandler(this.rbFont_CheckedChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Location = new System.Drawing.Point(0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(198, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Select property";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelColorControl
            // 
            this.panelColorControl.BackColor = System.Drawing.Color.White;
            this.panelColorControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorControl.Controls.Add(this.checkBoxBlue);
            this.panelColorControl.Controls.Add(this.checkBoxGreen);
            this.panelColorControl.Controls.Add(this.checkBoxRed);
            this.panelColorControl.Controls.Add(this.label6);
            this.panelColorControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelColorControl.Location = new System.Drawing.Point(505, 40);
            this.panelColorControl.Name = "panelColorControl";
            this.panelColorControl.Size = new System.Drawing.Size(200, 110);
            this.panelColorControl.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(198, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Element Management";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBuiltInTools
            // 
            this.panelBuiltInTools.BackColor = System.Drawing.Color.White;
            this.panelBuiltInTools.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBuiltInTools.Controls.Add(this.btnBuiltInFont);
            this.panelBuiltInTools.Controls.Add(this.btnBuiltInColor);
            this.panelBuiltInTools.Controls.Add(this.label1);
            this.panelBuiltInTools.Location = new System.Drawing.Point(270, 40);
            this.panelBuiltInTools.Name = "panelBuiltInTools";
            this.panelBuiltInTools.Size = new System.Drawing.Size(200, 110);
            this.panelBuiltInTools.TabIndex = 12;
            // 
            // btnBuiltInFont
            // 
            this.btnBuiltInFont.BackColor = System.Drawing.Color.White;
            this.btnBuiltInFont.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuiltInFont.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuiltInFont.FlatAppearance.BorderSize = 0;
            this.btnBuiltInFont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuiltInFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuiltInFont.IconChar = FontAwesome.Sharp.IconChar.Font;
            this.btnBuiltInFont.IconColor = System.Drawing.Color.Black;
            this.btnBuiltInFont.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuiltInFont.IconSize = 30;
            this.btnBuiltInFont.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuiltInFont.Location = new System.Drawing.Point(0, 65);
            this.btnBuiltInFont.Name = "btnBuiltInFont";
            this.btnBuiltInFont.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBuiltInFont.Size = new System.Drawing.Size(198, 40);
            this.btnBuiltInFont.TabIndex = 14;
            this.btnBuiltInFont.Text = "Font";
            this.btnBuiltInFont.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuiltInFont.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuiltInFont.UseVisualStyleBackColor = false;
            this.btnBuiltInFont.Click += new System.EventHandler(this.btnBuiltInFont_Click);
            // 
            // btnBuiltInColor
            // 
            this.btnBuiltInColor.BackColor = System.Drawing.Color.White;
            this.btnBuiltInColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuiltInColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuiltInColor.FlatAppearance.BorderSize = 0;
            this.btnBuiltInColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuiltInColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBuiltInColor.IconChar = FontAwesome.Sharp.IconChar.PaintRoller;
            this.btnBuiltInColor.IconColor = System.Drawing.Color.Black;
            this.btnBuiltInColor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuiltInColor.IconSize = 30;
            this.btnBuiltInColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuiltInColor.Location = new System.Drawing.Point(0, 25);
            this.btnBuiltInColor.Name = "btnBuiltInColor";
            this.btnBuiltInColor.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnBuiltInColor.Size = new System.Drawing.Size(198, 40);
            this.btnBuiltInColor.TabIndex = 13;
            this.btnBuiltInColor.Text = "Color";
            this.btnBuiltInColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuiltInColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuiltInColor.UseVisualStyleBackColor = false;
            this.btnBuiltInColor.Click += new System.EventHandler(this.btnBuiltInColor_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Built-in settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSettings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(975, 550);
            this.Controls.Add(this.panelDisplaySettings);
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Settings";
            this.Text = "FormSettings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.panelOfIndColors.ResumeLayout(false);
            this.ManualColorControlPanel.ResumeLayout(false);
            this.ManualColorControlPanel.PerformLayout();
            this.panelShade.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconExample)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panelDisplaySettings.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelIndividualsColors.ResumeLayout(false);
            this.SelectPropertiesPanel.ResumeLayout(false);
            this.panelColorControl.ResumeLayout(false);
            this.panelBuiltInTools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnApply;
        private System.Windows.Forms.Panel panelOfIndColors;
        private FontAwesome.Sharp.IconButton btnBlue;
        private FontAwesome.Sharp.IconButton btnGreen;
        private FontAwesome.Sharp.IconButton btnRed;
        private System.Windows.Forms.Panel ManualColorControlPanel;
        private System.Windows.Forms.VScrollBar BlueScrollBar;
        private System.Windows.Forms.VScrollBar GreenScrollBar;
        private System.Windows.Forms.VScrollBar RedScrollBar;
        private System.Windows.Forms.TextBox blue_value;
        private System.Windows.Forms.TextBox green_value;
        private System.Windows.Forms.TextBox red_value;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rBtnTurnOff;
        private System.Windows.Forms.RadioButton rBtnTurnOn;
        private System.Windows.Forms.CheckBox checkBoxBlue;
        private System.Windows.Forms.CheckBox checkBoxGreen;
        private System.Windows.Forms.CheckBox checkBoxRed;
        private System.Windows.Forms.Panel panelShade;
        private System.Windows.Forms.Label LabelExample;
        private System.Windows.Forms.RadioButton rBtnForeIconColor;
        private System.Windows.Forms.RadioButton rBtnBackColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panelDisplaySettings;
        private System.Windows.Forms.Panel panelBuiltInTools;
        private FontAwesome.Sharp.IconButton btnBuiltInFont;
        private FontAwesome.Sharp.IconButton btnBuiltInColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.RadioButton rbFont;
        private System.Windows.Forms.Panel panelColorControl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panelIndividualsColors;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel SelectPropertiesPanel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem backColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foreColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.Label labelFontName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox IconExample;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    }
}