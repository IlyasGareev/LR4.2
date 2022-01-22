
namespace LR4._2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.numericUpDownA = new System.Windows.Forms.NumericUpDown();
            this.trackBarA = new System.Windows.Forms.TrackBar();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.numericUpDownB = new System.Windows.Forms.NumericUpDown();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.trackBarC = new System.Windows.Forms.TrackBar();
            this.numericUpDownC = new System.Windows.Forms.NumericUpDown();
            this.textBoxC = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 89.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(82, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(705, 134);
            this.label1.TabIndex = 0;
            this.label1.Text = "A <= B <= C";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(82, 233);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(120, 20);
            this.textBoxA.TabIndex = 1;
            this.textBoxA.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxA_KeyDown);
            // 
            // numericUpDownA
            // 
            this.numericUpDownA.Location = new System.Drawing.Point(82, 275);
            this.numericUpDownA.Name = "numericUpDownA";
            this.numericUpDownA.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownA.TabIndex = 2;
            this.numericUpDownA.ValueChanged += new System.EventHandler(this.numericUpDownA_ValueChanged);
            // 
            // trackBarA
            // 
            this.trackBarA.Location = new System.Drawing.Point(82, 321);
            this.trackBarA.Maximum = 100;
            this.trackBarA.Name = "trackBarA";
            this.trackBarA.Size = new System.Drawing.Size(124, 45);
            this.trackBarA.TabIndex = 3;
            this.trackBarA.Scroll += new System.EventHandler(this.trackBarA_Scroll);
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(369, 321);
            this.trackBarB.Maximum = 100;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(124, 45);
            this.trackBarB.TabIndex = 6;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBarB_Scroll);
            // 
            // numericUpDownB
            // 
            this.numericUpDownB.Location = new System.Drawing.Point(369, 275);
            this.numericUpDownB.Name = "numericUpDownB";
            this.numericUpDownB.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownB.TabIndex = 5;
            this.numericUpDownB.ValueChanged += new System.EventHandler(this.numericUpDownB_ValueChanged);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(369, 233);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(120, 20);
            this.textBoxB.TabIndex = 4;
            this.textBoxB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxB_KeyDown);
            // 
            // trackBarC
            // 
            this.trackBarC.Location = new System.Drawing.Point(654, 321);
            this.trackBarC.Maximum = 100;
            this.trackBarC.Name = "trackBarC";
            this.trackBarC.Size = new System.Drawing.Size(124, 45);
            this.trackBarC.TabIndex = 9;
            this.trackBarC.Scroll += new System.EventHandler(this.trackBarC_Scroll);
            // 
            // numericUpDownC
            // 
            this.numericUpDownC.Location = new System.Drawing.Point(654, 275);
            this.numericUpDownC.Name = "numericUpDownC";
            this.numericUpDownC.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownC.TabIndex = 8;
            this.numericUpDownC.ValueChanged += new System.EventHandler(this.numericUpDownC_ValueChanged);
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(654, 233);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(120, 20);
            this.textBoxC.TabIndex = 7;
            this.textBoxC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxC_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 506);
            this.Controls.Add(this.trackBarC);
            this.Controls.Add(this.numericUpDownC);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.numericUpDownB);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.trackBarA);
            this.Controls.Add(this.numericUpDownA);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.NumericUpDown numericUpDownA;
        private System.Windows.Forms.TrackBar trackBarA;
        private System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.NumericUpDown numericUpDownB;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TrackBar trackBarC;
        private System.Windows.Forms.NumericUpDown numericUpDownC;
        private System.Windows.Forms.TextBox textBoxC;
    }
}

