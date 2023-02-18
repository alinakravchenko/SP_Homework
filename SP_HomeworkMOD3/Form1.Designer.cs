namespace SP_HomeworkMOD3
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
            this.lb_primeNumber = new System.Windows.Forms.ListBox();
            this.labelThread1 = new System.Windows.Forms.Label();
            this.labelBeginRange = new System.Windows.Forms.Label();
            this.labelEndRange = new System.Windows.Forms.Label();
            this.textBoxBeginRange = new System.Windows.Forms.TextBox();
            this.textBoxEndRange = new System.Windows.Forms.TextBox();
            this.buttonRunPrimeNumber = new System.Windows.Forms.Button();
            this.buttonAbortPrimeNumber = new System.Windows.Forms.Button();
            this.buttonSuppentPrimeNumber = new System.Windows.Forms.Button();
            this.buttonResumePrimeNumber = new System.Windows.Forms.Button();
            this.buttonRestartPrimeNumber = new System.Windows.Forms.Button();
            this.labelPrimeThreadState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_primeNumber
            // 
            this.lb_primeNumber.FormattingEnabled = true;
            this.lb_primeNumber.ItemHeight = 15;
            this.lb_primeNumber.Location = new System.Drawing.Point(12, 32);
            this.lb_primeNumber.Name = "lb_primeNumber";
            this.lb_primeNumber.Size = new System.Drawing.Size(179, 409);
            this.lb_primeNumber.TabIndex = 0;
            // 
            // labelThread1
            // 
            this.labelThread1.AutoSize = true;
            this.labelThread1.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelThread1.Location = new System.Drawing.Point(12, 9);
            this.labelThread1.Name = "labelThread1";
            this.labelThread1.Size = new System.Drawing.Size(179, 20);
            this.labelThread1.TabIndex = 1;
            this.labelThread1.Text = "Пoтoк 1. Прoстые числа";
            // 
            // labelBeginRange
            // 
            this.labelBeginRange.AutoSize = true;
            this.labelBeginRange.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelBeginRange.Location = new System.Drawing.Point(208, 32);
            this.labelBeginRange.Name = "labelBeginRange";
            this.labelBeginRange.Size = new System.Drawing.Size(115, 17);
            this.labelBeginRange.TabIndex = 2;
            this.labelBeginRange.Text = "Нижняя граница";
            // 
            // labelEndRange
            // 
            this.labelEndRange.AutoSize = true;
            this.labelEndRange.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEndRange.Location = new System.Drawing.Point(208, 90);
            this.labelEndRange.Name = "labelEndRange";
            this.labelEndRange.Size = new System.Drawing.Size(119, 17);
            this.labelEndRange.TabIndex = 3;
            this.labelEndRange.Text = "Верхняя граница";
            // 
            // textBoxBeginRange
            // 
            this.textBoxBeginRange.Location = new System.Drawing.Point(348, 32);
            this.textBoxBeginRange.Name = "textBoxBeginRange";
            this.textBoxBeginRange.Size = new System.Drawing.Size(100, 23);
            this.textBoxBeginRange.TabIndex = 17;
            this.textBoxBeginRange.Text = "2";
            this.textBoxBeginRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxEndRange
            // 
            this.textBoxEndRange.Location = new System.Drawing.Point(348, 84);
            this.textBoxEndRange.Name = "textBoxEndRange";
            this.textBoxEndRange.Size = new System.Drawing.Size(100, 23);
            this.textBoxEndRange.TabIndex = 5;
            this.textBoxEndRange.Text = "10000";
            this.textBoxEndRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // buttonRunPrimeNumber
            // 
            this.buttonRunPrimeNumber.Location = new System.Drawing.Point(208, 143);
            this.buttonRunPrimeNumber.Name = "buttonRunPrimeNumber";
            this.buttonRunPrimeNumber.Size = new System.Drawing.Size(240, 23);
            this.buttonRunPrimeNumber.TabIndex = 16;
            this.buttonRunPrimeNumber.Text = " RUN";
            this.buttonRunPrimeNumber.UseVisualStyleBackColor = true;
            this.buttonRunPrimeNumber.Click += new System.EventHandler(this.buttonRunPrimeNumber_Click);
            // 
            // buttonAbortPrimeNumber
            // 
            this.buttonAbortPrimeNumber.Location = new System.Drawing.Point(208, 182);
            this.buttonAbortPrimeNumber.Name = "buttonAbortPrimeNumber";
            this.buttonAbortPrimeNumber.Size = new System.Drawing.Size(240, 23);
            this.buttonAbortPrimeNumber.TabIndex = 9;
            this.buttonAbortPrimeNumber.Text = "Abort";
            this.buttonAbortPrimeNumber.UseVisualStyleBackColor = true;
            this.buttonAbortPrimeNumber.Click += new System.EventHandler(this.buttonAbortPrimeNumber_Click);
            // 
            // buttonSuppentPrimeNumber
            // 
            this.buttonSuppentPrimeNumber.Location = new System.Drawing.Point(208, 223);
            this.buttonSuppentPrimeNumber.Name = "buttonSuppentPrimeNumber";
            this.buttonSuppentPrimeNumber.Size = new System.Drawing.Size(240, 23);
            this.buttonSuppentPrimeNumber.TabIndex = 11;
            this.buttonSuppentPrimeNumber.Text = "Suppent";
            this.buttonSuppentPrimeNumber.UseVisualStyleBackColor = true;
            this.buttonSuppentPrimeNumber.Click += new System.EventHandler(this.buttonSuppentPrimeNumber_Click);
            // 
            // buttonResumePrimeNumber
            // 
            this.buttonResumePrimeNumber.Location = new System.Drawing.Point(208, 265);
            this.buttonResumePrimeNumber.Name = "buttonResumePrimeNumber";
            this.buttonResumePrimeNumber.Size = new System.Drawing.Size(240, 23);
            this.buttonResumePrimeNumber.TabIndex = 13;
            this.buttonResumePrimeNumber.Text = "Resume";
            this.buttonResumePrimeNumber.UseVisualStyleBackColor = true;
            this.buttonResumePrimeNumber.Click += new System.EventHandler(this.buttonResumePrimeNumber_Click);
            // 
            // buttonRestartPrimeNumber
            // 
            this.buttonRestartPrimeNumber.Location = new System.Drawing.Point(208, 305);
            this.buttonRestartPrimeNumber.Name = "buttonRestartPrimeNumber";
            this.buttonRestartPrimeNumber.Size = new System.Drawing.Size(240, 23);
            this.buttonRestartPrimeNumber.TabIndex = 18;
            this.buttonRestartPrimeNumber.Text = "Restart";
            this.buttonRestartPrimeNumber.UseVisualStyleBackColor = true;
            this.buttonRestartPrimeNumber.Click += new System.EventHandler(this.buttonRestartPrimeNumber_Click);
            // 
            // labelPrimeThreadState
            // 
            this.labelPrimeThreadState.AutoSize = true;
            this.labelPrimeThreadState.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPrimeThreadState.Location = new System.Drawing.Point(212, 349);
            this.labelPrimeThreadState.Name = "labelPrimeThreadState";
            this.labelPrimeThreadState.Size = new System.Drawing.Size(136, 21);
            this.labelPrimeThreadState.TabIndex = 19;
            this.labelPrimeThreadState.Text = "Статус Пoтoка";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 450);
            this.Controls.Add(this.labelPrimeThreadState);
            this.Controls.Add(this.buttonRestartPrimeNumber);
            this.Controls.Add(this.buttonResumePrimeNumber);
            this.Controls.Add(this.buttonSuppentPrimeNumber);
            this.Controls.Add(this.buttonAbortPrimeNumber);
            this.Controls.Add(this.buttonRunPrimeNumber);
            this.Controls.Add(this.textBoxEndRange);
            this.Controls.Add(this.textBoxBeginRange);
            this.Controls.Add(this.labelEndRange);
            this.Controls.Add(this.labelBeginRange);
            this.Controls.Add(this.labelThread1);
            this.Controls.Add(this.lb_primeNumber);
            this.Name = "Form1";
            this.Text = "Многопоточность";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lb_primeNumber;
        private Label labelThread1;
        private Label labelBeginRange;
        private Label labelEndRange;
        private TextBox textBoxBeginRange;
        private TextBox textBoxEndRange;
        private Button buttonRunPrimeNumber;
        private Button buttonAbortPrimeNumber;
        private Button buttonSuppentPrimeNumber;
        private Button buttonResumePrimeNumber;
        private Button buttonRestartPrimeNumber;
        private Label labelPrimeThreadState;
    }
}