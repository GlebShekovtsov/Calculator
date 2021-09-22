
namespace WindowsFormsApp5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.обычныйРежимToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.конвертерToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.режимПрограммистаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button_segment = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_minus = new System.Windows.Forms.Button();
            this.button_plus = new System.Windows.Forms.Button();
            this.button_equal = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button_d = new System.Windows.Forms.Button();
            this.button_num0 = new System.Windows.Forms.Button();
            this.button_num1 = new System.Windows.Forms.Button();
            this.button_num2 = new System.Windows.Forms.Button();
            this.button_num3 = new System.Windows.Forms.Button();
            this.button_num4 = new System.Windows.Forms.Button();
            this.button_num5 = new System.Windows.Forms.Button();
            this.button_num6 = new System.Windows.Forms.Button();
            this.button_num7 = new System.Windows.Forms.Button();
            this.button_num8 = new System.Windows.Forms.Button();
            this.button_num9 = new System.Windows.Forms.Button();
            this.button_joke = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_delete = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.обычныйРежимToolStripMenuItem,
            this.конвертерToolStripMenuItem,
            this.режимПрограммистаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // обычныйРежимToolStripMenuItem
            // 
            this.обычныйРежимToolStripMenuItem.Name = "обычныйРежимToolStripMenuItem";
            this.обычныйРежимToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.обычныйРежимToolStripMenuItem.Text = "Обычный режим";
            this.обычныйРежимToolStripMenuItem.Click += new System.EventHandler(this.обычныйРежимToolStripMenuItem_Click);
            // 
            // конвертерToolStripMenuItem
            // 
            this.конвертерToolStripMenuItem.Name = "конвертерToolStripMenuItem";
            this.конвертерToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.конвертерToolStripMenuItem.Text = "Конвертер";
            this.конвертерToolStripMenuItem.Click += new System.EventHandler(this.конвертерToolStripMenuItem_Click);
            // 
            // режимПрограммистаToolStripMenuItem
            // 
            this.режимПрограммистаToolStripMenuItem.Name = "режимПрограммистаToolStripMenuItem";
            this.режимПрограммистаToolStripMenuItem.Size = new System.Drawing.Size(141, 20);
            this.режимПрограммистаToolStripMenuItem.Text = "Режим программиста";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(562, 528);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.button_equal, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.button_plus, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.button_minus, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.button_multiply, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.button_segment, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(393, 80);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.09026F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.09026F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.32779F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.76484F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.48931F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(166, 445);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // button_segment
            // 
            this.button_segment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_segment.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_segment.Location = new System.Drawing.Point(3, 3);
            this.button_segment.Name = "button_segment";
            this.button_segment.Size = new System.Drawing.Size(160, 92);
            this.button_segment.TabIndex = 1;
            this.button_segment.Text = "/";
            this.button_segment.UseVisualStyleBackColor = true;
            this.button_segment.Click += new System.EventHandler(this.button_segment_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_multiply.Location = new System.Drawing.Point(3, 101);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(160, 92);
            this.button_multiply.TabIndex = 2;
            this.button_multiply.Text = "*";
            this.button_multiply.UseVisualStyleBackColor = true;
            this.button_multiply.Click += new System.EventHandler(this.button_multiply_Click);
            // 
            // button_minus
            // 
            this.button_minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_minus.Location = new System.Drawing.Point(3, 199);
            this.button_minus.Name = "button_minus";
            this.button_minus.Size = new System.Drawing.Size(160, 93);
            this.button_minus.TabIndex = 3;
            this.button_minus.Text = "-";
            this.button_minus.UseVisualStyleBackColor = true;
            this.button_minus.Click += new System.EventHandler(this.button_minus_Click);
            // 
            // button_plus
            // 
            this.button_plus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_plus.Location = new System.Drawing.Point(3, 298);
            this.button_plus.Name = "button_plus";
            this.button_plus.Size = new System.Drawing.Size(160, 77);
            this.button_plus.TabIndex = 4;
            this.button_plus.Text = "+";
            this.button_plus.UseVisualStyleBackColor = true;
            this.button_plus.Click += new System.EventHandler(this.button_plus_Click);
            // 
            // button_equal
            // 
            this.button_equal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_equal.Location = new System.Drawing.Point(3, 381);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(160, 61);
            this.button_equal.TabIndex = 5;
            this.button_equal.Text = "=";
            this.button_equal.UseVisualStyleBackColor = true;
            this.button_equal.Click += new System.EventHandler(this.button_equal_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.Controls.Add(this.button_joke, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.button_num9, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.button_num8, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.button_num7, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.button_num6, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_num5, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_num4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button_num3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_num2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_num1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_num0, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.button_d, 2, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 80);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(384, 445);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // button_d
            // 
            this.button_d.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_d.Location = new System.Drawing.Point(258, 297);
            this.button_d.Name = "button_d";
            this.button_d.Size = new System.Drawing.Size(123, 145);
            this.button_d.TabIndex = 10;
            this.button_d.Text = ",";
            this.button_d.UseVisualStyleBackColor = true;
            this.button_d.Click += new System.EventHandler(this.button11_Click);
            // 
            // button_num0
            // 
            this.button_num0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_num0.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_num0.Location = new System.Drawing.Point(130, 297);
            this.button_num0.Name = "button_num0";
            this.button_num0.Size = new System.Drawing.Size(122, 145);
            this.button_num0.TabIndex = 9;
            this.button_num0.Text = "0";
            this.button_num0.UseVisualStyleBackColor = true;
            this.button_num0.Click += new System.EventHandler(this.button_num0_Click);
            // 
            // button_num1
            // 
            this.button_num1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_num1.Location = new System.Drawing.Point(3, 3);
            this.button_num1.Name = "button_num1";
            this.button_num1.Size = new System.Drawing.Size(121, 92);
            this.button_num1.TabIndex = 0;
            this.button_num1.Text = "1";
            this.button_num1.UseVisualStyleBackColor = true;
            this.button_num1.Click += new System.EventHandler(this.button_num1_Click);
            // 
            // button_num2
            // 
            this.button_num2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_num2.Location = new System.Drawing.Point(130, 3);
            this.button_num2.Name = "button_num2";
            this.button_num2.Size = new System.Drawing.Size(122, 92);
            this.button_num2.TabIndex = 1;
            this.button_num2.Text = "2";
            this.button_num2.UseVisualStyleBackColor = true;
            this.button_num2.Click += new System.EventHandler(this.button_num2_Click);
            // 
            // button_num3
            // 
            this.button_num3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_num3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_num3.Location = new System.Drawing.Point(258, 3);
            this.button_num3.Name = "button_num3";
            this.button_num3.Size = new System.Drawing.Size(123, 92);
            this.button_num3.TabIndex = 2;
            this.button_num3.Text = "3";
            this.button_num3.UseVisualStyleBackColor = true;
            this.button_num3.Click += new System.EventHandler(this.button_num3_Click);
            // 
            // button_num4
            // 
            this.button_num4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_num4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_num4.Location = new System.Drawing.Point(3, 101);
            this.button_num4.Name = "button_num4";
            this.button_num4.Size = new System.Drawing.Size(121, 92);
            this.button_num4.TabIndex = 3;
            this.button_num4.Text = "4";
            this.button_num4.UseVisualStyleBackColor = true;
            this.button_num4.Click += new System.EventHandler(this.button_num4_Click);
            // 
            // button_num5
            // 
            this.button_num5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_num5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_num5.Location = new System.Drawing.Point(130, 101);
            this.button_num5.Name = "button_num5";
            this.button_num5.Size = new System.Drawing.Size(122, 92);
            this.button_num5.TabIndex = 4;
            this.button_num5.Text = "5";
            this.button_num5.UseVisualStyleBackColor = true;
            this.button_num5.Click += new System.EventHandler(this.button_num5_Click);
            // 
            // button_num6
            // 
            this.button_num6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_num6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_num6.Location = new System.Drawing.Point(258, 101);
            this.button_num6.Name = "button_num6";
            this.button_num6.Size = new System.Drawing.Size(123, 92);
            this.button_num6.TabIndex = 5;
            this.button_num6.Text = "6";
            this.button_num6.UseVisualStyleBackColor = true;
            this.button_num6.Click += new System.EventHandler(this.button_num6_Click);
            // 
            // button_num7
            // 
            this.button_num7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_num7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_num7.Location = new System.Drawing.Point(3, 199);
            this.button_num7.Name = "button_num7";
            this.button_num7.Size = new System.Drawing.Size(121, 92);
            this.button_num7.TabIndex = 6;
            this.button_num7.Text = "7";
            this.button_num7.UseVisualStyleBackColor = true;
            this.button_num7.Click += new System.EventHandler(this.button_num7_Click);
            // 
            // button_num8
            // 
            this.button_num8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_num8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_num8.Location = new System.Drawing.Point(130, 199);
            this.button_num8.Name = "button_num8";
            this.button_num8.Size = new System.Drawing.Size(122, 92);
            this.button_num8.TabIndex = 7;
            this.button_num8.Text = "8";
            this.button_num8.UseVisualStyleBackColor = true;
            this.button_num8.Click += new System.EventHandler(this.button_num8_Click);
            // 
            // button_num9
            // 
            this.button_num9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_num9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_num9.Location = new System.Drawing.Point(258, 199);
            this.button_num9.Name = "button_num9";
            this.button_num9.Size = new System.Drawing.Size(123, 92);
            this.button_num9.TabIndex = 8;
            this.button_num9.Text = "9";
            this.button_num9.UseVisualStyleBackColor = true;
            this.button_num9.Click += new System.EventHandler(this.button_num9_Click);
            // 
            // button_joke
            // 
            this.button_joke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_joke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_joke.Location = new System.Drawing.Point(3, 297);
            this.button_joke.Name = "button_joke";
            this.button_joke.Size = new System.Drawing.Size(121, 145);
            this.button_joke.TabIndex = 11;
            this.button_joke.Text = "С";
            this.button_joke.UseVisualStyleBackColor = true;
            this.button_joke.Click += new System.EventHandler(this.button_joke_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.47369F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.52632F));
            this.tableLayoutPanel1.Controls.Add(this.button_delete, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.68927F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.31074F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(562, 528);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.14322F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.85678F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(384, 71);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(326, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 71);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(317, 65);
            this.textBox1.TabIndex = 1;
            // 
            // button_delete
            // 
            this.button_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_delete.Image = global::WindowsFormsApp5.Properties.Resources.www_EasyImages_net_35526156a97848150b0f7fb1e185acbd;
            this.button_delete.Location = new System.Drawing.Point(393, 3);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(166, 71);
            this.button_delete.TabIndex = 1;
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(562, 552);
            this.panel2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 552);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Калькулятор";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem обычныйРежимToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem конвертерToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem режимПрограммистаToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button button_joke;
        private System.Windows.Forms.Button button_num9;
        private System.Windows.Forms.Button button_num8;
        private System.Windows.Forms.Button button_num7;
        private System.Windows.Forms.Button button_num6;
        private System.Windows.Forms.Button button_num5;
        private System.Windows.Forms.Button button_num4;
        private System.Windows.Forms.Button button_num3;
        private System.Windows.Forms.Button button_num2;
        private System.Windows.Forms.Button button_num1;
        private System.Windows.Forms.Button button_num0;
        private System.Windows.Forms.Button button_d;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button_equal;
        private System.Windows.Forms.Button button_plus;
        private System.Windows.Forms.Button button_minus;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Button button_segment;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
    }
}

