namespace PenHomework
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
            this.Canvas = new System.Windows.Forms.Panel();
            this.ButtonPen = new System.Windows.Forms.Button();
            this.ButtonEraser = new System.Windows.Forms.Button();
            this.ButtonLine = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonColorChooser = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ButtonBugFeature = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Canvas
            // 
            this.Canvas.BackColor = System.Drawing.SystemColors.Control;
            this.Canvas.Location = new System.Drawing.Point(8, 9);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(567, 315);
            this.Canvas.TabIndex = 0;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // ButtonPen
            // 
            this.ButtonPen.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonPen.Location = new System.Drawing.Point(581, 42);
            this.ButtonPen.Name = "ButtonPen";
            this.ButtonPen.Size = new System.Drawing.Size(41, 25);
            this.ButtonPen.TabIndex = 7;
            this.ButtonPen.Text = "Pen";
            this.ButtonPen.UseVisualStyleBackColor = true;
            this.ButtonPen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonPen_MouseClick);
            // 
            // ButtonEraser
            // 
            this.ButtonEraser.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonEraser.Location = new System.Drawing.Point(678, 42);
            this.ButtonEraser.Name = "ButtonEraser";
            this.ButtonEraser.Size = new System.Drawing.Size(41, 25);
            this.ButtonEraser.TabIndex = 8;
            this.ButtonEraser.Text = "Eraser";
            this.ButtonEraser.UseVisualStyleBackColor = true;
            this.ButtonEraser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonEraser_MouseClick);
            // 
            // ButtonLine
            // 
            this.ButtonLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLine.Location = new System.Drawing.Point(630, 42);
            this.ButtonLine.Name = "ButtonLine";
            this.ButtonLine.Size = new System.Drawing.Size(41, 25);
            this.ButtonLine.TabIndex = 9;
            this.ButtonLine.Text = "Line";
            this.ButtonLine.UseVisualStyleBackColor = true;
            this.ButtonLine.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonLine_MouseClick);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(581, 73);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(137, 32);
            this.ButtonClear.TabIndex = 10;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonClear_MouseClick);
            // 
            // ButtonColorChooser
            // 
            this.ButtonColorChooser.Location = new System.Drawing.Point(581, 9);
            this.ButtonColorChooser.Name = "ButtonColorChooser";
            this.ButtonColorChooser.Size = new System.Drawing.Size(137, 27);
            this.ButtonColorChooser.TabIndex = 11;
            this.ButtonColorChooser.Text = "Choose Color";
            this.ButtonColorChooser.UseVisualStyleBackColor = true;
            this.ButtonColorChooser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonColorChooser_MouseClick);
            // 
            // ButtonBugFeature
            // 
            this.ButtonBugFeature.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonBugFeature.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonBugFeature.ForeColor = System.Drawing.Color.Red;
            this.ButtonBugFeature.Location = new System.Drawing.Point(581, 122);
            this.ButtonBugFeature.Name = "ButtonBugFeature";
            this.ButtonBugFeature.Size = new System.Drawing.Size(136, 30);
            this.ButtonBugFeature.TabIndex = 12;
            this.ButtonBugFeature.Text = "Definitely not a bug";
            this.ButtonBugFeature.UseVisualStyleBackColor = false;
            this.ButtonBugFeature.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonBugFeature_MouseClick);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(722, 333);
            this.Controls.Add(this.ButtonBugFeature);
            this.Controls.Add(this.ButtonColorChooser);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonLine);
            this.Controls.Add(this.ButtonEraser);
            this.Controls.Add(this.ButtonPen);
            this.Controls.Add(this.Canvas);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.Button ButtonPen;
        private System.Windows.Forms.Button ButtonEraser;
        private System.Windows.Forms.Button ButtonLine;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonColorChooser;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button ButtonBugFeature;
    }
}

