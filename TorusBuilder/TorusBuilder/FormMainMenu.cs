using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using System.Drawing.Imaging;
using MyLib;
using System.Xml;
using System.IO;

namespace TorusBuilder
{
    public partial class FormMainMenu : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        Bitmap bitmap;
        private int borderSize = 2;
        private Size formSize;
        public static int back_red = Color.MintCream.R, back_green = Color.MintCream.G, back_blue = Color.MintCream.B;
        public static int text_red = DefaultForeColor.R, text_green = DefaultForeColor.G, text_blue = DefaultForeColor.B;
        public static Font font_text = DefaultFont;  
        double AngleX = 0, AngleY, CoordX, CoordY; // Углы поворота и положение на экране
        bool aMouse = false; 
        ObjectGraph objectGraph;    //Объект визуализации модели
        double temp_InnerRadius = 2.2, temp_OuterRadius = 5.2;
        int temp_NumOfSides = 32, temp_NumOfRings = 32;  // Временные переменные для исправления ошибок
        bool manual_control = true, start_the_timer = true;
        public static Client class1;
        string xml_path; // файл для сохраниения настроек
        XmlDocument xml_doc;

        // Загрузка приложения
        public FormMainMenu()
        {
            class1 = new Client();   // создаем объект класса из подключаемой библиотеки
            class1.Connect_To_Server();   // Соединяемся с сервером
            InitializeComponent();
            Status.Text += class1.GetStatusOfConnection();
            AnT.InitializeContexts();  
            objectGraph = new ObjectGraph(AnT);   // Создаем объект класса нашей модели
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 50);
            panelMenu.Controls.Add(leftBorderBtn);
            Padding = new Padding(borderSize);
            BackColor = Color.MintCream;
            panelSubMenu.Visible = false;
            btnOff.Checked = true;
            rb_x.Checked = true;
            rbTorusBackColor.Checked = true;
            btnBack.Enabled = false;
            checkBoxManualControl.Checked = true;
            checkBoxComposition.Checked = false;
            checkBoxLighting.Checked = true;
            btnSave.Enabled = false;
            iconCurrentChildForm.IconSize = 40;
            SetLongPressOfButtons();
        }
        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            comboBoxRotation.SelectedIndex = 0;
            objectGraph.angleX = (int)AngleX;
            objectGraph.GridMode = false;
            objectGraph.isComposition = false;
            objectGraph.lighting = true;
           /* 
            // Считывание данных из текстовых файлов
            InnerRadius.Text = File.ReadAllText(@"D:\inner_radius.txt");
            OuterRadius.Text = File.ReadAllText(@"D:\outer_radius.txt");
            NumOfSides.Text = File.ReadAllText(@"D:\sides.txt");
            NumOfRings.Text = File.ReadAllText(@"D:\rings.txt");*/
            objectGraph.inner_radius = Convert.ToDouble(InnerRadius.Text);
            objectGraph.outer_radius = Convert.ToDouble(OuterRadius.Text);
            objectGraph.num_sides = Convert.ToInt32(NumOfSides.Text);
            objectGraph.num_rings = Convert.ToInt32(NumOfRings.Text);
           /* xml_path = @"D:\Текстовый документ.txt\XMLFile.xml";
            xml_doc = new XmlDocument();
            xml_doc.Load(xml_path);*/
          //  class1.ReadFromXML();
          //  Client.RadFromXML(xml_doc, radioButton1, radioButton2, ref border, ref fill_rect, ref fill_tri, checkBox1, ref k, ref width, ref left_angle);

        }

        // Добавляем долгое нажатие на кнопки
        private void SetLongPressOfButtons() 
        {
            new LongPressButton(rot_1, 60).Click += new EventHandler(rot_1_Click);
            new LongPressButton(rot_2, 60).Click += new EventHandler(rot_2_Click);
            new LongPressButton(zoom_plus, 100).Click += new EventHandler(zoom_plus_Click);
            new LongPressButton(zoom_minus, 100).Click += new EventHandler(zoom_minus_Click);
            new LongPressButton(btnPlus_1, 500).Click += new EventHandler(btnPlus_1_Click);
            new LongPressButton(btnPlus_2, 500).Click += new EventHandler(btnPlus_2_Click);
            new LongPressButton(btnPlus_3, 500).Click += new EventHandler(btnPlus_3_Click);
            new LongPressButton(btnPlus_4, 500).Click += new EventHandler(btnPlus_4_Click);
            new LongPressButton(btnMinus_1, 500).Click += new EventHandler(btnMinus_1_Click);
            new LongPressButton(btnMinus_2, 500).Click += new EventHandler(btnMinus_2_Click);
            new LongPressButton(btnMinus_3, 500).Click += new EventHandler(btnMinus_3_Click);
            new LongPressButton(btnMinus_4, 500).Click += new EventHandler(btnMinus_4_Click);
            new LongPressButton(btnOffsetFirstDirection, 80).Click += new EventHandler(btnOffsetFirstDirection_Click);
            new LongPressButton(btnOffsetSecondDirection, 80).Click += new EventHandler(btnOffsetSecondDirection_Click);
        }
        
        // Управление моделью при помощи мыши
        // Нажали
        private void AnT_MouseDown(object sender, MouseEventArgs e)
        {
            if (manual_control)
            {
                CoordX = e.X;
                CoordY = e.Y;
                aMouse = true;
            }
        }
        
        // Движение мышкой по области
        private void AnT_MouseMove(object sender, MouseEventArgs e)
        {
            if (manual_control)
            {
                if (aMouse)
                {
                    if (((AngleX > -150) | ((e.Y - CoordY) / 6 > 0)) &
                        ((AngleX < 360) | ((e.Y - CoordY) / 6 < 0))) AngleX = AngleX + (e.Y - CoordY) / 6;
                    AngleY = AngleY + (e.X - CoordX) / 6;
                    CoordX = e.X;
                    CoordY = e.Y;
                    objectGraph.angleX = (int)AngleX;
                    objectGraph.angleY = (int)AngleY;
                }
            }
        }
        
        // Отпустили мышку
        private void AnT_MouseUp(object sender, MouseEventArgs e)
        {
            aMouse = false;
        }
        
        // Чек боксы
        private void checkBoxComposition_CheckedChanged(object sender, EventArgs e)   // композиция 
        {
            if (checkBoxComposition.Checked)
            {
                objectGraph.isComposition = true;
            }
            else
            {
                objectGraph.isComposition = false;
            }
        }
        
        private void checkBoxManualControl_CheckedChanged(object sender, EventArgs e)  // Состояние ручного управления
        {
            if (checkBoxManualControl.Checked)
            {
                manual_control = true;
                btnOff.Checked = true;
                groupBoxAxes.Enabled = false;
                panelAngle.Enabled = false;
                panelAutoRot.Enabled = false;
                AnT.Cursor = Cursors.Default;
            }
            else
            {
                manual_control = false;
                groupBoxAxes.Enabled = true;
                panelAngle.Enabled = true;
                panelAutoRot.Enabled = true;
                AnT.Cursor = Cursors.No;
            }
        }
        
        // Перемещение формы
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Overridden methods
        protected override void WndProc(ref Message m)
        {
            const int WM_NCCALCSIZE = 0x0083;//Standar Title Bar - Snap Window
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MINIMIZE = 0xF020; //Minimize form (Before)
            const int SC_RESTORE = 0xF120; //Restore form (Before)
            const int WM_NCHITTEST = 0x0084;//Win32, Mouse Input Notification: Determine what part of the window corresponds to a point, allows to resize the form.
            const int resizeAreaSize = 10;
            #region Form Resize
            // Resize/WM_NCHITTEST values
            const int HTCLIENT = 1; //Represents the client area of the window
            const int HTLEFT = 10;  //Left border of a window, allows resize horizontally to the left
            const int HTRIGHT = 11; //Right border of a window, allows resize horizontally to the right
            const int HTTOP = 12;   //Upper-horizontal border of a window, allows resize vertically up
            const int HTTOPLEFT = 13;//Upper-left corner of a window border, allows resize diagonally to the left
            const int HTTOPRIGHT = 14;//Upper-right corner of a window border, allows resize diagonally to the right
            const int HTBOTTOM = 15; //Lower-horizontal border of a window, allows resize vertically down
            const int HTBOTTOMLEFT = 16;//Lower-left corner of a window border, allows resize diagonally to the left
            const int HTBOTTOMRIGHT = 17;//Lower-right corner of a window border, allows resize diagonally to the right
            ///<Doc> More Information: https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-nchittest </Doc>
            if (m.Msg == WM_NCHITTEST)
            { //If the windows m is WM_NCHITTEST
                base.WndProc(ref m);
                if (this.WindowState == FormWindowState.Normal)//Resize the form if it is in normal state
                {
                    if ((int)m.Result == HTCLIENT)//If the result of the m (mouse pointer) is in the client area of the window
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32()); //Gets screen point coordinates(X and Y coordinate of the pointer)                           
                        Point clientPoint = this.PointToClient(screenPoint); //Computes the location of the screen point into client coordinates                          
                        if (clientPoint.Y <= resizeAreaSize)//If the pointer is at the top of the form (within the resize area- X coordinate)
                        {
                            if (clientPoint.X <= resizeAreaSize) //If the pointer is at the coordinate X=0 or less than the resizing area(X=10) in 
                                m.Result = (IntPtr)HTTOPLEFT; //Resize diagonally to the left
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize))//If the pointer is at the coordinate X=11 or less than the width of the form(X=Form.Width-resizeArea)
                                m.Result = (IntPtr)HTTOP; //Resize vertically up
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTTOPRIGHT;
                        }
                        else if (clientPoint.Y <= (this.Size.Height - resizeAreaSize)) //If the pointer is inside the form at the Y coordinate(discounting the resize area size)
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize horizontally to the left
                                m.Result = (IntPtr)HTLEFT;
                            else if (clientPoint.X > (this.Width - resizeAreaSize))//Resize horizontally to the right
                                m.Result = (IntPtr)HTRIGHT;
                        }
                        else
                        {
                            if (clientPoint.X <= resizeAreaSize)//Resize diagonally to the left
                                m.Result = (IntPtr)HTBOTTOMLEFT;
                            else if (clientPoint.X < (this.Size.Width - resizeAreaSize)) //Resize vertically down
                                m.Result = (IntPtr)HTBOTTOM;
                            else //Resize diagonally to the right
                                m.Result = (IntPtr)HTBOTTOMRIGHT;
                        }
                    }
                }
                return;
            }
            #endregion
            //Remove border and keep snap window
            if (m.Msg == WM_NCCALCSIZE && m.WParam.ToInt32() == 1)
            {
                return;
            }
            //Keep form size when it is minimized and restored. Since the form is resized because it takes into account the size of the title bar and borders.
            if (m.Msg == WM_SYSCOMMAND)
            {
                /// <see cref="https://docs.microsoft.com/en-us/windows/win32/menurc/wm-syscommand"/>
                /// Quote:
                /// In WM_SYSCOMMAND messages, the four low - order bits of the wParam parameter 
                /// are used internally by the system.To obtain the correct result when testing 
                /// the value of wParam, an application must combine the value 0xFFF0 with the 
                /// wParam value by using the bitwise AND operator.
                int wParam = (m.WParam.ToInt32() & 0xFFF0);
                if (wParam == SC_MINIMIZE)  //Before
                    formSize = this.ClientSize;
                if (wParam == SC_RESTORE)// Restored form(Before)
                    this.Size = formSize;
            }
            base.WndProc(ref m);
        }

        private void FormMainMenu_Resize(object sender, EventArgs e)
        {
            AdjustForm();
        }

        // Изменение размеров формы
        private void AdjustForm()
        {
            switch (this.WindowState)
            {
                case FormWindowState.Maximized: //Maximized form (After)
                    this.Padding = new Padding(8, 8, 8, 0);
                    break;
                case FormWindowState.Normal: //Restored form (After)
                    if (this.Padding.Top != borderSize)
                        this.Padding = new Padding(borderSize);
                    break;
            }
        }
       
        // Активация кнопок и форм
        // Окрашивание кнопок
        private struct RGBColors   
        {
            public static Color color_1 = Color.FromArgb(0, 0, 255);
            public static Color color_2 = Color.FromArgb(102, 255, 0);
            public static Color color_3 = Color.FromArgb(255, 215, 0);
            public static Color color_4 = Color.FromArgb(70, 246, 241);
        }

        // Активация кнопки
        private void ActivateButton(object senderBtn, Color clr)   
        {
            if (senderBtn != null)
            {
                DisableButton();
                btnBack.Enabled = true;
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.Red;
                currentBtn.IconColor = clr;
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = clr;
                lblTitleChildForm.Text = currentBtn.Tag.ToString();
                tempName.Text = currentBtn.Tag.ToString();
                lblTitleChildForm.ForeColor = clr;
                leftBorderBtn.BackColor = clr;
                currentBtn.ForeColor = clr;
                if (panelMenu.Width != 70)
                {
                    currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                    currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                    currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                    leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();
                }
            }
        }

        // Деактивация кнопки
        private void DisableButton()  
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Maroon;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                if (panelMenu.Width != 70)
                    currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
                else
                    currentBtn.ImageAlign = ContentAlignment.MiddleCenter;
                leftBorderBtn.Visible = false;
            }
        }

        // открыть дочернюю форму на рабочей области
        private void OpenChildForm(Form childForm)   
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        
        // Построение 3D модели
        private void btnPlus_1_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(InnerRadius.Text) + 0.1 <= 30)
            {
                objectGraph.inner_radius += 0.1;  // увеличение внутреннего радиуса
                InnerRadius.Text = Convert.ToString(objectGraph.inner_radius);
                class1.SendCommandToServer("Changing the size");
            }
            else
            {
                MessageBox.Show("The maximum allowed value is 30!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnPlus_2_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(OuterRadius.Text) + 0.1 <= 30)
            {
                objectGraph.outer_radius += 0.1;   // Увеличение внешнего радиуса
                OuterRadius.Text = Convert.ToString(objectGraph.outer_radius);
                class1.SendCommandToServer("Changing the size");
            }
            else
            {
                MessageBox.Show("The maximum allowed value is 30!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnPlus_3_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(NumOfSides.Text) + 1 <= 60)
            {
                objectGraph.num_sides++;   // Увеличение кол-ва сторон
                NumOfSides.Text = Convert.ToString(objectGraph.num_sides);
                class1.SendCommandToServer("Changing the size");
            }
            else
            {
                MessageBox.Show("The maximum allowed value is 60!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void btnPlus_4_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(NumOfRings.Text) + 1 <= 60)
            {
                objectGraph.num_rings++;   // увеличение кол-ва колец
                NumOfRings.Text = Convert.ToString(objectGraph.num_rings);
                class1.SendCommandToServer("Changing the size");
            }
            else
            {
                MessageBox.Show("The maximum allowed value is 60!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnMinus_1_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(InnerRadius.Text) - 0.1 >= 0.1)
            {
                objectGraph.inner_radius -= 0.1;   // Уменьшение внутреннего радиуса
                InnerRadius.Text = Convert.ToString(objectGraph.inner_radius);
                class1.SendCommandToServer("Changing the size");
            }
            else
            {
                MessageBox.Show("The minimum allowed value is 0.1!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnMinus_2_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(OuterRadius.Text) - 0.1 >= 0.1)
            {
                objectGraph.outer_radius -= 0.1;   // Уменьшение внешнего радиуса
                OuterRadius.Text = Convert.ToString(objectGraph.outer_radius);
                class1.SendCommandToServer("Changing the size");
            }
            else
            {
                MessageBox.Show("The minimum allowed value is 0.1!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void btnMinus_3_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(NumOfSides.Text) - 1 >= 1)
            {
                objectGraph.num_sides--;   // Уменьшение кол-ва сторон
                NumOfSides.Text = Convert.ToString(objectGraph.num_sides);
                class1.SendCommandToServer("Changing the size");
            }
            else
            {
                MessageBox.Show("The minimum allowed value is 1!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void btnMinus_4_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(NumOfRings.Text) - 1 >= 1)
            {
                objectGraph.num_rings--;   // Уменьшение кол-ва колец
                NumOfRings.Text = Convert.ToString(objectGraph.num_rings);
                class1.SendCommandToServer("Changing the size");
            }
            else
            {
                MessageBox.Show("The minimum allowed value is 1!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Откат значений
        private void RollBackValues(bool isValue1, bool isValue2, bool isValue3, bool isValue4)  
        {
            if (isValue1) InnerRadius.Text = Convert.ToString(temp_InnerRadius);
            if (isValue2) OuterRadius.Text = Convert.ToString(temp_OuterRadius);
            if (isValue3) NumOfSides.Text = Convert.ToString(temp_NumOfSides);
            if (isValue4) NumOfRings.Text = Convert.ToString(temp_NumOfRings);
        }

        // Изменение внутреннего радиуса тора
        private void InnerRadius_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                ValidationOfInputValues(true, false, false, false);  
        }

        // Изменение внешнего радиуса тора
        private void OuterRadius_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                ValidationOfInputValues(false, true, false, false);  
        }

        // Изменение числа сторон
        private void NumOfSides_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                ValidationOfInputValues(false, false, true, false);  
        }

        // Изменение числа колец
        private void NumOfRings_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                ValidationOfInputValues(false, false, false, true);  
        }

        // Проверка на корректность ввода
        private void ValidationOfInputValues(bool isValue1, bool isValue2, bool isValue3, bool isValue4)  
        {
            bool incorrect_value = false;
            string error_message = "Out of limits!\n";   // сообщение об ошибке
            try
            {   // Соберем сообщения о всевозможных ошибках нарушения дипазона допустимых значений и выведем их на экран в случае наличия таковых
                if (isValue1 && (Convert.ToDouble(InnerRadius.Text) <= 0 || Convert.ToDouble(InnerRadius.Text) > 30))
                {
                    incorrect_value = true;
                    error_message += "Range of inner radius values ​​- (0;30]!\n";
                }
                if (isValue2 && (Convert.ToDouble(OuterRadius.Text) <= 0 || Convert.ToDouble(OuterRadius.Text) > 30))
                {
                    incorrect_value = true;
                    error_message += "Range of outer radius values ​​- (0;30]!\n";
                }
                if (isValue3 && (Convert.ToInt32(NumOfSides.Text) < 1 || Convert.ToInt32(NumOfSides.Text) > 60))
                {
                    incorrect_value = true;
                    error_message += "The range of values ​​for the number of sides is [1;60]!\n";
                }
                if (isValue4 && (Convert.ToInt32(NumOfRings.Text) < 1 || Convert.ToInt32(NumOfRings.Text) > 60))
                {
                    incorrect_value = true;
                    error_message += "The range of values ​​for the number of rings is [1;60]!";
                }
                if (incorrect_value == true)
                {
                    MessageBox.Show(error_message, "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RollBackValues(isValue1, isValue2, isValue3, isValue4);
                    return;
                }
                else
                {
                    if (isValue1)
                    {
                        objectGraph.inner_radius = Convert.ToDouble(InnerRadius.Text);
                        temp_InnerRadius = objectGraph.inner_radius;
                    }
                    if (isValue2)
                    {
                        objectGraph.outer_radius = Convert.ToDouble(OuterRadius.Text);
                        temp_OuterRadius = objectGraph.outer_radius;
                    }
                    if (isValue3)
                    {
                        objectGraph.num_sides = Convert.ToInt32(NumOfSides.Text);
                        temp_NumOfSides = objectGraph.num_sides;
                    }
                    if (isValue4)
                    {
                        objectGraph.num_rings = Convert.ToInt32(NumOfRings.Text);
                        temp_NumOfRings = objectGraph.num_rings;
                    }
                    if (start_the_timer)   // Таймер запускается только один раз
                    {
                        RenderTimer.Start();
                        btnSave.Enabled = true;
                        start_the_timer = false;
                    }      
                    else
                        class1.SendCommandToServer("Changing the size");
                }
            }
            catch
            {
                MessageBox.Show("Incorrect data entry!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Error);
                RollBackValues(isValue1, isValue2, isValue3, isValue4);
                return;
            }
        }

        // Кнопка визуализации модели
        private void btnVisualize_Click(object sender, EventArgs e)   
        {
            class1.SendCommandToServer("Building");
            ValidationOfInputValues(true, true, true, true);
        }

        // Управление 3D моделью
        // Увеличение масштаба
        private void zoom_plus_Click(object sender, EventArgs e)
        {
            objectGraph.zoom += 0.02;  
        }

        // уменьшение масштаба
        private void zoom_minus_Click(object sender, EventArgs e)
        {
            objectGraph.zoom -= 0.02;   
        }

        // Смещение по осям координат в одну сторону
        private void btnOffsetFirstDirection_Click(object sender, EventArgs e)   
        {
            if (rb_x.Checked)
            {
                objectGraph.X_axis -= 0.05;
            }
            else if (rb_y.Checked)
            {
                objectGraph.Y_axis -= 0.05;
            }
            else if (rb_z.Checked)
            {
                objectGraph.Z_axis -= 0.05;
            }
        }

        // Смещение по осям координат в другую сторону
        private void btnOffsetSecondDirection_Click(object sender, EventArgs e)   
        {
            if (rb_x.Checked)
            {
                objectGraph.X_axis += 0.05;
            }
            else if (rb_y.Checked)
            {
                objectGraph.Y_axis += 0.05;
            }
            else if (rb_z.Checked)
            {
                objectGraph.Z_axis += 0.05;
            }
        }

        // Вращение в одну сторону
        private void rot_1_Click(object sender, EventArgs e)   
        {
            if (comboBoxRotation.SelectedIndex == 0)
                objectGraph.angleX -= 2;   // Вращение вдоль Ох
            else if (comboBoxRotation.SelectedIndex == 1)
                objectGraph.angleY -= 2;   // Вращение вдоль Оу
            else if (comboBoxRotation.SelectedIndex == 2)
                objectGraph.angleZ -= 2;   // Вращение вдоль Оz
            else if (comboBoxRotation.SelectedIndex == 3)
            {   // Мульти-вращение
                objectGraph.angleX -= 2;
                objectGraph.angleY -= 2;
                objectGraph.angleZ -= 2;
            }
        }

        // Вращение в другую сторону
        private void rot_2_Click(object sender, EventArgs e)   
        {
            if (comboBoxRotation.SelectedIndex == 0)
                objectGraph.angleX += 2;   // Вращение вдоль Ох
            else if (comboBoxRotation.SelectedIndex == 1)
                objectGraph.angleY += 2;   // Вращение вдоль Оу
            else if (comboBoxRotation.SelectedIndex == 2)
                objectGraph.angleZ += 2;   // Вращение вдоль Оz
            else if (comboBoxRotation.SelectedIndex == 3)
            {   // Мульти-вращение
                objectGraph.angleX += 2;
                objectGraph.angleY += 2;
                objectGraph.angleZ += 2;
            }
        }

        // Сеточная или полигонная визуализация модели
        private void checkBoxLine_CheckedChanged(object sender, EventArgs e)  
        {
            if (checkBoxLine.Checked)
            {
                objectGraph.GridMode = true;
            }
            else
            {
                objectGraph.GridMode = false;
            }
            class1.SendCommandToServer("Changing the view");
        }

        // Проверка на авто-вращение
        private void btnOff_CheckedChanged(object sender, EventArgs e)  
        {
            if (btnOff.Checked)
                panelAngle.Enabled = true;
            else
                panelAngle.Enabled = false;
        }

        // Проверка на подсветку
        private void checkBoxLighting_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLighting.Checked)
            {
                objectGraph.lighting = true;
                rbTorusColor.Enabled = false;
            }
            else
            {
                
                objectGraph.lighting = false;
                rbTorusColor.Enabled = true;
            }
            class1.SendCommandToServer("Changing the view");
        }
        
        // Изменение картинок при выборе смещения модели по осям координат
        private void rb_x_CheckedChanged(object sender, EventArgs e)
        {
            ChangingIcons();
        }
       
        private void rb_y_CheckedChanged(object sender, EventArgs e)
        {
            ChangingIcons();
        }
        
        private void rb_z_CheckedChanged(object sender, EventArgs e)
        {
            ChangingIcons();
        }
        
        private void ChangingIcons()
        {
            if (rb_x.Checked)
            {
                btnOffsetFirstDirection.IconChar = IconChar.AngleLeft;
                btnOffsetSecondDirection.IconChar = IconChar.AngleRight;
            }
            else if (rb_y.Checked)
            {
                btnOffsetFirstDirection.IconChar = IconChar.AngleDown;
                btnOffsetSecondDirection.IconChar = IconChar.AngleUp;
            }
            else if (rb_z.Checked)
            {
                btnOffsetFirstDirection.IconChar = IconChar.Minus;
                btnOffsetSecondDirection.IconChar = IconChar.Plus;
            }
        }
        
        // Проверка на клик мыши для возможного скрытия бокового меню
        private void tcModelSettings_MouseClick(object sender, MouseEventArgs e)
        {
            ClickTest();
        }
        
        private void tabPageControl_MouseClick(object sender, MouseEventArgs e)
        {
            ClickTest();
        }
        
        private void tabPageBuilding_MouseClick(object sender, MouseEventArgs e)
        {
            ClickTest();
        }
        
        private void panelDesktop_MouseClick(object sender, MouseEventArgs e)
        {
            ClickTest();
        }
        
        private void panelBottom_MouseClick(object sender, MouseEventArgs e)
        {
            if (panelMenu.Width != 70 && !checkBoxLock.Checked) CollapseMenu();
        }
        
        public void ClickTest()
        {
            if (panelMenu.Width != 70 && !checkBoxLock.Checked) CollapseMenu();
        }

        // Сворачивание/разворачивание бокового меню и изменение подсказки
        // Нажатие на кнопку меню
        private void btnMenu_Click(object sender, EventArgs e)   
        {
            if (this.panelMenu.Width > 200)
            {
                CollapseMenu();
                info_smth.SetToolTip(this.btnMenu, "Expand Panel Menu");
            }
            else
            {
                ExpandMenu();
                info_smth.SetToolTip(this.btnMenu, "Collapse Panel Menu");
            }
        }

        // свернуть боковое меню
        public void CollapseMenu()  
        {
            Width -= 170;
            panelMenu.Width = 70;
            LockPanel.Visible = false;
            foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
            {
                SetMiniButton(menuButton);
                if (menuButton.BackColor == Color.Red) leftBorderBtn.Visible = false;
            }
            foreach (Button menuButton in panelSubMenu.Controls.OfType<Button>())
            {
                SetMiniButton(menuButton);
            }
        }

        // установка мини-иконок кнопок
        private void SetMiniButton(Button button)  
        {
            button.Text = "";
            button.ImageAlign = ContentAlignment.MiddleCenter;
            button.Padding = new Padding(0);
        }
        
        // Развернуть боковое меню
        private void ExpandMenu()
        {
            Width += 170;
            panelMenu.Width = 240;
            LockPanel.Visible = true;
            foreach (Button menuButton in panelMenu.Controls.OfType<Button>())
            {
                SetNormalButton(menuButton);
            }
            foreach (Button menuButton in panelSubMenu.Controls.OfType<Button>())
            {
                SetNormalButton(menuButton);
            }
        }
        
        // Установка кнопок нормального размера
        private void SetNormalButton(Button button)
        {
            button.Text = "" + button.Tag.ToString();
            button.ImageAlign = ContentAlignment.MiddleLeft;
            button.Padding = new Padding(10, 0, 0, 0);
            if (button.BackColor == Color.Red)
            {
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        // Управление кнопками в верхней панели
        // свернуть окно
        private void btnMinimize_Click(object sender, EventArgs e)  
        {
            WindowState = FormWindowState.Minimized;
        }

        // развернуть окно
        private void btnMaximize_Click(object sender, EventArgs e)  
        {
            if (WindowState == FormWindowState.Normal)
            {
                formSize = ClientSize;
                WindowState = FormWindowState.Maximized;
                btnMaximize.IconChar = IconChar.WindowRestore;
                info_smth.SetToolTip(btnMaximize, "Minimize window");
            }
            else
            {
                WindowState = FormWindowState.Normal;
                Size = formSize;
                btnMaximize.IconChar = IconChar.WindowMaximize;
                info_smth.SetToolTip(btnMaximize, "Maximize window");
            }
        }

        // Закрытие программы
        private void btnClose_Click(object sender, EventArgs e)  
        {
            DialogResult result = MessageBox.Show("Save settings before exiting?", "Pop-up window", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                class1.SaveToXML(objectGraph.inner_radius, objectGraph.outer_radius, objectGraph.num_sides, objectGraph.num_rings);
            }
            string checking = File.ReadAllText(@"D:\uved.txt");
            if (checking != "0")
            {
                FormRate formRate = new FormRate(this);
                formRate.ShowDialog();
            }
            Application.Exit();
        }

        // Открыть руководство по пользованию
        private void btnHelp_Click(object sender, EventArgs e)   
        {
            Process.Start(@"D:\Справочник\NewProject\NewProject\NewProject.chm");
        }

        // вернуться в главное меню
        private void btnBack_Click(object sender, EventArgs e)  
        {
            btnBack.Enabled = false;
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        // Первоначальное заполнение меток
        private void Reset()  
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Cube;
            iconCurrentChildForm.IconColor = Color.White;
            lblTitleChildForm.Text = "Model";
            lblTitleChildForm.ForeColor = Color.White;
            tempName.Text = "Model";
        }

        // Нажатие на кнопки меню
        // Открыть настройки
        private void btnSettings_Click(object sender, EventArgs e)  
        {
            ActivateButton(btnSettings, RGBColors.color_2);
            OpenChildForm(new FormSettings(this));
        }

        // Открыть информацию о приложении
        private void btnAbout_Click(object sender, EventArgs e)  
        {
            ActivateButton(sender, RGBColors.color_3);
            OpenChildForm(new FormAbout(this));
        }

        // Сохранение изображения
        private void btnSavePicture_Click(object sender, EventArgs e) 
        {
            RenderTimer.Stop();
            //создание диалогового окна "Сохранить как..", для сохранения изображения
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "Save picture as...";
            //отображать ли предупреждение, если пользователь указывает имя уже существующего файла
            savedialog.OverwritePrompt = true;
            //отображать ли предупреждение, если пользователь указывает несуществующий путь
            savedialog.CheckPathExists = true;
            //список форматов файла, отображаемый в поле "Тип файла"
            savedialog.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image Files(*.PNG)|*.PNG|All files (*.*)|*.*";
            //отображается ли кнопка "Справка" в диалоговом окне
            savedialog.ShowHelp = true;
            if (savedialog.ShowDialog() == DialogResult.OK) //если в диалоговом окне нажата кнопка "ОК"
            {
                try
                {
                    bitmap.Save(savedialog.FileName, ImageFormat.Jpeg);
                }
                catch
                {
                    MessageBox.Show("Unable to save image", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            RenderTimer.Start();
        }

        // кнопка сохранить
        private void btnSave_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color_1);
            if (panelSubMenu.Visible == false)
            {
                panelSubMenu.Visible = true;
            }
            else
            {
                panelSubMenu.Visible = false;
            }
        }  
        
        // Сохранение данных в word
        private void SaveToWord_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\idea\source\repos\TorusBuilder\Files for program\Torus.png";
            pictureBox1.Image.Save(path, ImageFormat.Png);
            RenderTimer.Stop();
            Word.Application word = new Word.Application(); // создаю объект
            Word.Document doc = word.Documents.Add(); // создание страницы в ворде
            Word.Range range = doc.Range(0, 0);  // место куда пихаю
            range.Text = $"\nSurface of revolution torus (toroid)\nIts parameters:\nInner radius - {InnerRadius.Text}\n" +
                $"Outer radius - {OuterRadius.Text}\nNumber of sides for each radial section - {NumOfSides.Text}\n" +
                $"Number of radial divisions for the torus - {NumOfRings.Text}\n";
            range.Bold = 1;   // Толщина
            word.Application.Selection.InlineShapes.AddPicture(path);   // Добавляю картинку
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "Save word document as...";
            savedialog.OverwritePrompt = true;
            savedialog.CheckPathExists = true;
            savedialog.Filter = "*.docx |*.doc";  // Фильтр для документа Word
            savedialog.ShowHelp = true;
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    doc.SaveAs(savedialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Unable to save image", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            doc.Close();
            DialogResult result = MessageBox.Show("The document has been successfully saved. Open?", "Saving (WORD)", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Word.Document docx = word.Application.Documents.Open(savedialog.FileName);
                word.Visible = true;
            }
            RenderTimer.Start();
        }

        // Сохранение данных в Excel
        private void SaveToExcel_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\idea\source\repos\TorusBuilder\Files for program\Torus.png";
            pictureBox1.Image.Save(path, ImageFormat.Png);
            RenderTimer.Stop();
            // Создаем документ
            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Add();
            Excel.Worksheet wrksheet = excel.ActiveSheet;
            excel.Range["A1"].Value = "Surface of revolution torus (toroid)";
            excel.Range["A2"].Value = "Its parameters";
            excel.Range["A3"].Value = "Inner radius - ";
            excel.Range["B3"].Value = Convert.ToDouble(InnerRadius.Text);
            excel.Range["A4"].Value = "Outer radius - ";
            excel.Range["B4"].Value = Convert.ToDouble(OuterRadius.Text);
            excel.Range["A5"].Value = "Number of sides for each radial section - ";
            excel.Range["B5"].Value = Convert.ToInt32(NumOfSides.Text);
            excel.Range["A6"].Value = "Number of radial divisions for the torus - ";
            excel.Range["B6"].Value = Convert.ToInt32(NumOfRings.Text);
            wrksheet.get_Range("A1", "B6").Columns.AutoFit();
            wrksheet.get_Range("A1", "B6").Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            excel.DisplayAlerts = false;
            wrksheet.Shapes.AddPicture(path, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue, 100, 100, 250, 250);
            // Окно сохранения
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "Save excel document as...";
            savedialog.OverwritePrompt = true;
            savedialog.CheckPathExists = true;
            savedialog.Filter = "*.xls|*.xls |*.xlsx|*.xlsx";  // Фильтр для документа Word
            savedialog.ShowHelp = true;
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    workbook.SaveAs(savedialog.FileName);
                }
                catch
                {
                    MessageBox.Show("Unable to save image", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            workbook.Close();
            DialogResult result = MessageBox.Show("The document has been successfully saved. Open?", "Saving (EXCEL)", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Excel.Workbook xlsx = excel.Application.Workbooks.Open(savedialog.FileName);
                excel.Visible = true;
            }
            RenderTimer.Start();
        }

        // Обновления
        private void btnUpdates_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color_4);
            class1.SendCommandToServer("Check for updates");
            MessageBox.Show(class1.GetAnswerFromServer(), "Update center", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisableButton();
        } 

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Save settings before exiting?", "Pop-up window", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                class1.SaveToXML(objectGraph.inner_radius, objectGraph.outer_radius, objectGraph.num_sides, objectGraph.num_rings);
            }
            string checking = File.ReadAllText(@"D:\uved.txt");
            if (checking != "0")
            {
                FormRate formRate = new FormRate(this);
                formRate.ShowDialog();
            }
            Application.Exit();
        }

        // Изменение цвета фона и текста
        public void change_color(Color clr, int operation)   
        {
            if (operation == 1)
            {
                panelDesktop.BackColor = clr;
                foreach (TabPage tp in tcModelSettings.TabPages)
                {
                    tp.BackColor = clr;
                }
            }
            else if (operation == 2)
            {
                foreach (Control control in this.Controls)
                {
                    control.ForeColor = clr;
                }
            }
        }

        // Изменение шрифта
        public void change_font(Font font)   
        {
            foreach (TabPage tp in tcModelSettings.TabPages)
            {
                tp.Font = font;
                foreach (Control control in tp.Controls)
                {
                    control.Font = font;
                }

            }
            label6.Font = font;
            label7.Font = font;
            label8.Font = font;
            label12.Font = font;
            label13.Font = font;
            label14.Font = font;
            label15.Font = font;
        }
        
        // Изменение параметров фигуры
        private void SetModelVizualizeSettings(Color color)
        {
            if (rbTorusBackColor.Checked)
            {
                objectGraph.red_bc = color.R;
                objectGraph.green_bc = color.G;
                objectGraph.blue_bc = color.B;
            }
            else if (rbTorusColor.Checked)
            {
                objectGraph.red_mc = color.R;
                objectGraph.green_mc = color.G;
                objectGraph.blue_mc = color.B;
            }
            class1.SendCommandToServer("Changing the view");
        }
        
        private void btnSetWhite_Click(object sender, EventArgs e)
        {   // Установка белого цвета
            SetModelVizualizeSettings(Color.White);
        }
        
        private void btnSetBlack_Click(object sender, EventArgs e)
        {   // Установка черного цвета
            SetModelVizualizeSettings(Color.Black);
        }
        
        private void btnSetRed_Click(object sender, EventArgs e)
        {
            // Установка красного цвета
            SetModelVizualizeSettings(Color.Red);
        }
        
        private void btnsetYellow_Click(object sender, EventArgs e)
        {
            // Установка желтого цвета
            SetModelVizualizeSettings(Color.Yellow);
        }
        
        private void btnSetBlue_Click(object sender, EventArgs e)
        {
            // Установка синего цвета
            SetModelVizualizeSettings(Color.Blue);
        }
        
        private void btnSetLime_Click(object sender, EventArgs e)
        {
            // Установка лаймового цвета
            SetModelVizualizeSettings(Color.Lime);
        }
        
        private void btnSetMagenta_Click(object sender, EventArgs e)
        {
            // Установка цвета magenta
            SetModelVizualizeSettings(Color.Magenta);
        }
        
        private void btnSetCyan_Click(object sender, EventArgs e)
        {   // Установка цвета cyan
            SetModelVizualizeSettings(Color.Cyan);
        }

        // Захват изображения
        private void GetImageOfModel()
        {
            bitmap = new Bitmap(AnT.Width, AnT.Height);
            using (Graphics gr = Graphics.FromImage(bitmap))
            {
                gr.CopyFromScreen(AnT.PointToScreen(Point.Empty), Point.Empty, AnT.Size);
            }
        }

        // Клик по ссылке
        // Открытие справочника по ручному управлению и авто-вращению
        private void infoManualControl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)  
        {
            Process.Start("C:\\Users\\idea\\source\\repos\\TorusBuilder\\Files for program\\Manual Control.txt");
        }

        // Ссылка на страницу Создателя в Telegram
        private void linkToMe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)  
        {
            Process.Start("https://t.me/TiraNter");
        }
        
        // Моделирование тора
        private void RenderTimer_Tick(object sender, EventArgs e)  // Каждый тик таймера
        {
            GetImageOfModel();
            pictureBox1.Image = bitmap;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            switch (comboBoxRotation.SelectedIndex)
            {
                case 0:   // Вращение вдоль Ох
                {
                    if (btn_firstDir.Checked)
                        objectGraph.angleX--;
                    else if (btn_secDir.Checked)
                        objectGraph.angleX++;
                    break;
                }
                case 1:   // Вращение вдоль Оу
                    {
                        if (btn_firstDir.Checked)
                            objectGraph.angleY--;
                        else if (btn_secDir.Checked)
                            objectGraph.angleY++;
                        break;
                    }
                case 2:   // Вращение вдоль Оz
                    {
                        if (btn_firstDir.Checked)
                            objectGraph.angleZ--;
                        else if (btn_secDir.Checked)
                            objectGraph.angleZ++;
                        break;
                    }
                case 3:   // Мульти-вращение
                    {
                        if (btn_firstDir.Checked)
                        {
                            objectGraph.angleX--;
                            objectGraph.angleY--;
                            objectGraph.angleZ--;
                        }
                        else if (btn_secDir.Checked)
                        {
                            objectGraph.angleX++;
                            objectGraph.angleY++;
                            objectGraph.angleZ++;
                        }
                        break;
                    }
            }
            objectGraph.Draw();
            InnerRadius.Text = Convert.ToString(objectGraph.inner_radius);
            OuterRadius.Text = Convert.ToString(objectGraph.outer_radius);
            NumOfSides.Text = Convert.ToString(objectGraph.num_sides);
            NumOfRings.Text = Convert.ToString(objectGraph.num_rings);
        }
    }
}