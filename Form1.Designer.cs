namespace GraphicEditor
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ChooseСolor = new System.Windows.Forms.Button();
            this.textRadius = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выборЭлементаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PointToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ArcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearButton = new System.Windows.Forms.Button();
            this.typeLabel = new System.Windows.Forms.Label();
            this.textAlpha = new System.Windows.Forms.TextBox();
            this.labelAlpha = new System.Windows.Forms.Label();
            this.GraphicPanel = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicPanel)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseСolor
            // 
            this.ChooseСolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseСolor.Location = new System.Drawing.Point(12, 813);
            this.ChooseСolor.Name = "ChooseСolor";
            this.ChooseСolor.Size = new System.Drawing.Size(212, 50);
            this.ChooseСolor.TabIndex = 1;
            this.ChooseСolor.Text = "Выбрать цвет";
            this.ChooseСolor.UseVisualStyleBackColor = true;
            this.ChooseСolor.Click += new System.EventHandler(this.ChooseСolor_Click);
            // 
            // textRadius
            // 
            this.textRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textRadius.Location = new System.Drawing.Point(350, 819);
            this.textRadius.Name = "textRadius";
            this.textRadius.Size = new System.Drawing.Size(100, 40);
            this.textRadius.TabIndex = 2;
            this.textRadius.Text = "5";
            this.textRadius.TextChanged += new System.EventHandler(this.textRadius_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(230, 822);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Radius:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.выборЭлементаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1493, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // выборЭлементаToolStripMenuItem
            // 
            this.выборЭлементаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PointToolStripMenuItem,
            this.LineToolStripMenuItem,
            this.RectangleToolStripMenuItem,
            this.ArcToolStripMenuItem});
            this.выборЭлементаToolStripMenuItem.Name = "выборЭлементаToolStripMenuItem";
            this.выборЭлементаToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.выборЭлементаToolStripMenuItem.Text = "Выбор элемента";
            // 
            // PointToolStripMenuItem
            // 
            this.PointToolStripMenuItem.Name = "PointToolStripMenuItem";
            this.PointToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.PointToolStripMenuItem.Text = "Точка";
            this.PointToolStripMenuItem.Click += new System.EventHandler(this.PointToolStripMenuItem_Click);
            // 
            // LineToolStripMenuItem
            // 
            this.LineToolStripMenuItem.Name = "LineToolStripMenuItem";
            this.LineToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.LineToolStripMenuItem.Text = "Линия";
            this.LineToolStripMenuItem.Click += new System.EventHandler(this.LineToolStripMenuItem_Click);
            // 
            // RectangleToolStripMenuItem
            // 
            this.RectangleToolStripMenuItem.Name = "RectangleToolStripMenuItem";
            this.RectangleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.RectangleToolStripMenuItem.Text = "Прямоугольник";
            this.RectangleToolStripMenuItem.Click += new System.EventHandler(this.RectangleToolStripMenuItem_Click);
            // 
            // ArcToolStripMenuItem
            // 
            this.ArcToolStripMenuItem.Name = "ArcToolStripMenuItem";
            this.ArcToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.ArcToolStripMenuItem.Text = "Дуга";
            this.ArcToolStripMenuItem.Click += new System.EventHandler(this.ArcToolStripMenuItem_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(1197, 813);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(151, 41);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.typeLabel.Location = new System.Drawing.Point(670, 826);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(161, 33);
            this.typeLabel.TabIndex = 6;
            this.typeLabel.Text = "Тип: Точка";
            // 
            // textAlpha
            // 
            this.textAlpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textAlpha.Location = new System.Drawing.Point(564, 819);
            this.textAlpha.Name = "textAlpha";
            this.textAlpha.Size = new System.Drawing.Size(100, 40);
            this.textAlpha.TabIndex = 7;
            this.textAlpha.TextChanged += new System.EventHandler(this.textAlpha_TextChanged);
            // 
            // labelAlpha
            // 
            this.labelAlpha.AutoSize = true;
            this.labelAlpha.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAlpha.Location = new System.Drawing.Point(465, 822);
            this.labelAlpha.Name = "labelAlpha";
            this.labelAlpha.Size = new System.Drawing.Size(86, 33);
            this.labelAlpha.TabIndex = 8;
            this.labelAlpha.Text = "Угол:";
            // 
            // GraphicPanel
            // 
            this.GraphicPanel.BackColor = System.Drawing.Color.White;
            this.GraphicPanel.Location = new System.Drawing.Point(0, 27);
            this.GraphicPanel.Name = "GraphicPanel";
            this.GraphicPanel.Size = new System.Drawing.Size(1481, 771);
            this.GraphicPanel.TabIndex = 9;
            this.GraphicPanel.TabStop = false;
            this.GraphicPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GraphiсPanel_MouseDown);
            this.GraphicPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GraphicPanel_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 867);
            this.Controls.Add(this.GraphicPanel);
            this.Controls.Add(this.labelAlpha);
            this.Controls.Add(this.textAlpha);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textRadius);
            this.Controls.Add(this.ChooseСolor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Graphic Editor";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GraphicPanel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button ChooseСolor;
        private System.Windows.Forms.TextBox textRadius;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выборЭлементаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PointToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LineToolStripMenuItem;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ToolStripMenuItem RectangleToolStripMenuItem;
        private System.Windows.Forms.TextBox textAlpha;
        private System.Windows.Forms.Label labelAlpha;
        private System.Windows.Forms.ToolStripMenuItem ArcToolStripMenuItem;
        private System.Windows.Forms.PictureBox GraphicPanel;
    }
}

