namespace GraphPlotter
{
    partial class GraphPlotterForm
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
            this.plotGraphButton = new System.Windows.Forms.Button();
            this.graphPictureBox = new System.Windows.Forms.PictureBox();
            this.functionNamesComboBox = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.beginXTextBox = new System.Windows.Forms.TextBox();
            this.endXTextBox = new System.Windows.Forms.TextBox();
            this.beginXLabel = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.endXLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // plotGraphButton
            // 
            this.plotGraphButton.Location = new System.Drawing.Point(42, 67);
            this.plotGraphButton.Name = "plotGraphButton";
            this.plotGraphButton.Size = new System.Drawing.Size(258, 50);
            this.plotGraphButton.TabIndex = 0;
            this.plotGraphButton.Text = "Построить график";
            this.plotGraphButton.UseVisualStyleBackColor = true;
            this.plotGraphButton.Click += new System.EventHandler(this.plotGraphButton_Click);
            // 
            // graphPictureBox
            // 
            this.graphPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphPictureBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.graphPictureBox.Location = new System.Drawing.Point(12, 12);
            this.graphPictureBox.Name = "graphPictureBox";
            this.graphPictureBox.Size = new System.Drawing.Size(950, 542);
            this.graphPictureBox.TabIndex = 1;
            this.graphPictureBox.TabStop = false;
            // 
            // functionNamesComboBox
            // 
            this.functionNamesComboBox.FormattingEnabled = true;
            this.functionNamesComboBox.Location = new System.Drawing.Point(42, 28);
            this.functionNamesComboBox.Name = "functionNamesComboBox";
            this.functionNamesComboBox.Size = new System.Drawing.Size(258, 33);
            this.functionNamesComboBox.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.functionNamesComboBox);
            this.flowLayoutPanel1.Controls.Add(this.plotGraphButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(659, 572);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(303, 145);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Выбор графика";
            // 
            // beginXTextBox
            // 
            this.beginXTextBox.Location = new System.Drawing.Point(3, 28);
            this.beginXTextBox.Name = "beginXTextBox";
            this.beginXTextBox.Size = new System.Drawing.Size(250, 31);
            this.beginXTextBox.TabIndex = 0;
            // 
            // endXTextBox
            // 
            this.endXTextBox.Location = new System.Drawing.Point(3, 90);
            this.endXTextBox.Name = "endXTextBox";
            this.endXTextBox.Size = new System.Drawing.Size(250, 31);
            this.endXTextBox.TabIndex = 4;
            // 
            // beginXLabel
            // 
            this.beginXLabel.AutoSize = true;
            this.beginXLabel.Location = new System.Drawing.Point(3, 0);
            this.beginXLabel.Name = "beginXLabel";
            this.beginXLabel.Size = new System.Drawing.Size(284, 25);
            this.beginXLabel.TabIndex = 5;
            this.beginXLabel.Text = " Левая граница диапазона:";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.flowLayoutPanel2.Controls.Add(this.beginXLabel);
            this.flowLayoutPanel2.Controls.Add(this.beginXTextBox);
            this.flowLayoutPanel2.Controls.Add(this.endXLabel);
            this.flowLayoutPanel2.Controls.Add(this.endXTextBox);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 572);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(318, 145);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // endXLabel
            // 
            this.endXLabel.AutoSize = true;
            this.endXLabel.Location = new System.Drawing.Point(3, 62);
            this.endXLabel.Name = "endXLabel";
            this.endXLabel.Size = new System.Drawing.Size(290, 25);
            this.endXLabel.TabIndex = 6;
            this.endXLabel.Text = "Правая граница диапазона:";
            // 
            // GraphPlotterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 729);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.graphPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(680, 620);
            this.Name = "GraphPlotterForm";
            this.Text = "GraphPlotter";
            ((System.ComponentModel.ISupportInitialize)(this.graphPictureBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button plotGraphButton;
        private System.Windows.Forms.PictureBox graphPictureBox;
        private System.Windows.Forms.ComboBox functionNamesComboBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label beginXLabel;
        private System.Windows.Forms.TextBox beginXTextBox;
        private System.Windows.Forms.TextBox endXTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label endXLabel;
    }
}

