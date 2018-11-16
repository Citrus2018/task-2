namespace ErsanDraw_0._2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PaintList = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ElipseOfColour = new System.Windows.Forms.PictureBox();
            this.DisplayOfColour = new System.Windows.Forms.PictureBox();
            this.NewListButton = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ColourDisplayToogle = new System.Windows.Forms.PictureBox();
            this.ToolPen = new System.Windows.Forms.PictureBox();
            this.ToolLine = new System.Windows.Forms.PictureBox();
            this.ButtonOfColour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PaintList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElipseOfColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayOfColour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewListButton)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColourDisplayToogle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolPen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolLine)).BeginInit();
            this.SuspendLayout();
            // 
            // PaintList
            // 
            this.PaintList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaintList.Location = new System.Drawing.Point(0, 0);
            this.PaintList.Name = "PaintList";
            this.PaintList.Size = new System.Drawing.Size(762, 377);
            this.PaintList.TabIndex = 0;
            this.PaintList.TabStop = false;
            this.PaintList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PaintList_MouseDown);
            this.PaintList.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PaintList_MouseMove);
            this.PaintList.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PaintList_MouseUp);
            // 
            // ElipseOfColour
            // 
            this.ElipseOfColour.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ElipseOfColour.Image = ((System.Drawing.Image)(resources.GetObject("ElipseOfColour.Image")));
            this.ElipseOfColour.Location = new System.Drawing.Point(768, 0);
            this.ElipseOfColour.Name = "ElipseOfColour";
            this.ElipseOfColour.Size = new System.Drawing.Size(266, 273);
            this.ElipseOfColour.TabIndex = 2;
            this.ElipseOfColour.TabStop = false;
            this.ElipseOfColour.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ElipseOfColour_MouseDown);
            this.ElipseOfColour.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ElipseOfColour_MouseMove);
            this.ElipseOfColour.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ElipseOfColour_MouseUp);
            // 
            // DisplayOfColour
            // 
            this.DisplayOfColour.BackColor = System.Drawing.SystemColors.WindowText;
            this.DisplayOfColour.Location = new System.Drawing.Point(768, 279);
            this.DisplayOfColour.Name = "DisplayOfColour";
            this.DisplayOfColour.Size = new System.Drawing.Size(100, 94);
            this.DisplayOfColour.TabIndex = 3;
            this.DisplayOfColour.TabStop = false;
            // 
            // NewListButton
            // 
            this.NewListButton.Image = global::ErsanDraw_0._2.Properties.Resources._new;
            this.NewListButton.Location = new System.Drawing.Point(3, 3);
            this.NewListButton.Name = "NewListButton";
            this.NewListButton.Size = new System.Drawing.Size(32, 32);
            this.NewListButton.TabIndex = 5;
            this.NewListButton.TabStop = false;
            this.NewListButton.Click += new System.EventHandler(this.NewListButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ColourDisplayToogle);
            this.panel1.Controls.Add(this.NewListButton);
            this.panel1.Location = new System.Drawing.Point(1040, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 419);
            this.panel1.TabIndex = 6;
            // 
            // ColourDisplayToogle
            // 
            this.ColourDisplayToogle.BackgroundImage = global::ErsanDraw_0._2.Properties.Resources.tools;
            this.ColourDisplayToogle.Location = new System.Drawing.Point(3, 41);
            this.ColourDisplayToogle.Name = "ColourDisplayToogle";
            this.ColourDisplayToogle.Size = new System.Drawing.Size(32, 32);
            this.ColourDisplayToogle.TabIndex = 9;
            this.ColourDisplayToogle.TabStop = false;
            this.ColourDisplayToogle.Click += new System.EventHandler(this.ColourDisplayToogle_Click);
            // 
            // ToolPen
            // 
            this.ToolPen.Image = global::ErsanDraw_0._2.Properties.Resources.pencil;
            this.ToolPen.Location = new System.Drawing.Point(12, 383);
            this.ToolPen.Name = "ToolPen";
            this.ToolPen.Size = new System.Drawing.Size(32, 32);
            this.ToolPen.TabIndex = 7;
            this.ToolPen.TabStop = false;
            this.ToolPen.Click += new System.EventHandler(this.ToolPen_Click);
            // 
            // ToolLine
            // 
            this.ToolLine.Image = global::ErsanDraw_0._2.Properties.Resources.line;
            this.ToolLine.Location = new System.Drawing.Point(62, 383);
            this.ToolLine.Name = "ToolLine";
            this.ToolLine.Size = new System.Drawing.Size(32, 32);
            this.ToolLine.TabIndex = 8;
            this.ToolLine.TabStop = false;
            this.ToolLine.Click += new System.EventHandler(this.ToolLine_Click);
            // 
            // ButtonOfColour
            // 
            this.ButtonOfColour.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ButtonOfColour.Location = new System.Drawing.Point(791, 12);
            this.ButtonOfColour.Name = "ButtonOfColour";
            this.ButtonOfColour.Size = new System.Drawing.Size(228, 227);
            this.ButtonOfColour.TabIndex = 10;
            this.ButtonOfColour.Text = "Выберите цвет";
            this.ButtonOfColour.UseVisualStyleBackColor = true;
            this.ButtonOfColour.Visible = false;
            this.ButtonOfColour.Click += new System.EventHandler(this.ButtonOfColour_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::ErsanDraw_0._2.Properties.Resources.Konoha_236633;
            this.ClientSize = new System.Drawing.Size(1079, 419);
            this.Controls.Add(this.ButtonOfColour);
            this.Controls.Add(this.ToolLine);
            this.Controls.Add(this.ToolPen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.DisplayOfColour);
            this.Controls.Add(this.ElipseOfColour);
            this.Controls.Add(this.PaintList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Paint Tool EERsan";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.PaintList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ElipseOfColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayOfColour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NewListButton)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ColourDisplayToogle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolPen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToolLine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PaintList;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.PictureBox ElipseOfColour;
        private System.Windows.Forms.PictureBox DisplayOfColour;
        private System.Windows.Forms.PictureBox NewListButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ToolPen;
        private System.Windows.Forms.PictureBox ToolLine;
        private System.Windows.Forms.PictureBox ColourDisplayToogle;
        private System.Windows.Forms.Button ButtonOfColour;
    }
}

