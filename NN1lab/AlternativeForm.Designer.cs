namespace NN1lab
{
    partial class AlternativeForm
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
            this.okButton = new System.Windows.Forms.Button();
            this.nameAltTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FuncCB = new System.Windows.Forms.ComboBox();
            this.aLable = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.cLable = new System.Windows.Forms.Label();
            this.dLable = new System.Windows.Forms.Label();
            this.aTB = new System.Windows.Forms.TextBox();
            this.bTB = new System.Windows.Forms.TextBox();
            this.cTB = new System.Windows.Forms.TextBox();
            this.dTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(626, 128);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 0;
            this.okButton.Text = "ОК";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OK_Click);
            // 
            // nameAltTB
            // 
            this.nameAltTB.Location = new System.Drawing.Point(50, 53);
            this.nameAltTB.Name = "nameAltTB";
            this.nameAltTB.Size = new System.Drawing.Size(149, 20);
            this.nameAltTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите название альтернативы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Выберите тип функции принадлежности";
            // 
            // FuncCB
            // 
            this.FuncCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FuncCB.FormattingEnabled = true;
            this.FuncCB.Items.AddRange(new object[] {
            "Треугольная",
            "Трапецеидальная",
            "Z-образная",
            "S-образная"});
            this.FuncCB.Location = new System.Drawing.Point(297, 53);
            this.FuncCB.Name = "FuncCB";
            this.FuncCB.Size = new System.Drawing.Size(208, 21);
            this.FuncCB.TabIndex = 4;
            this.FuncCB.SelectedIndexChanged += new System.EventHandler(this.FuncCB_SelectedIndexChanged_1);
            // 
            // aLable
            // 
            this.aLable.AutoSize = true;
            this.aLable.Location = new System.Drawing.Point(169, 104);
            this.aLable.Name = "aLable";
            this.aLable.Size = new System.Drawing.Size(13, 13);
            this.aLable.TabIndex = 5;
            this.aLable.Text = "a";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(285, 104);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(13, 13);
            this.bLabel.TabIndex = 6;
            this.bLabel.Text = "b";
            // 
            // cLable
            // 
            this.cLable.AutoSize = true;
            this.cLable.Location = new System.Drawing.Point(403, 104);
            this.cLable.Name = "cLable";
            this.cLable.Size = new System.Drawing.Size(13, 13);
            this.cLable.TabIndex = 7;
            this.cLable.Text = "c";
            // 
            // dLable
            // 
            this.dLable.AutoSize = true;
            this.dLable.Location = new System.Drawing.Point(521, 104);
            this.dLable.Name = "dLable";
            this.dLable.Size = new System.Drawing.Size(13, 13);
            this.dLable.TabIndex = 8;
            this.dLable.Text = "d";
            // 
            // aTB
            // 
            this.aTB.Location = new System.Drawing.Point(188, 97);
            this.aTB.Name = "aTB";
            this.aTB.Size = new System.Drawing.Size(77, 20);
            this.aTB.TabIndex = 9;
            // 
            // bTB
            // 
            this.bTB.Location = new System.Drawing.Point(304, 97);
            this.bTB.Name = "bTB";
            this.bTB.Size = new System.Drawing.Size(77, 20);
            this.bTB.TabIndex = 10;
            // 
            // cTB
            // 
            this.cTB.Location = new System.Drawing.Point(422, 97);
            this.cTB.Name = "cTB";
            this.cTB.Size = new System.Drawing.Size(77, 20);
            this.cTB.TabIndex = 11;
            // 
            // dTB
            // 
            this.dTB.Location = new System.Drawing.Point(540, 97);
            this.dTB.Name = "dTB";
            this.dTB.Size = new System.Drawing.Size(77, 20);
            this.dTB.TabIndex = 12;
            // 
            // AlternativeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 198);
            this.Controls.Add(this.FuncCB);
            this.Controls.Add(this.aLable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bTB);
            this.Controls.Add(this.nameAltTB);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.cTB);
            this.Controls.Add(this.dTB);
            this.Controls.Add(this.cLable);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.dLable);
            this.Name = "AlternativeForm";
            this.Text = "Альтернатива";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox nameAltTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FuncCB;
        private System.Windows.Forms.Label aLable;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label cLable;
        private System.Windows.Forms.Label dLable;
        private System.Windows.Forms.TextBox aTB;
        private System.Windows.Forms.TextBox bTB;
        private System.Windows.Forms.TextBox cTB;
        private System.Windows.Forms.TextBox dTB;
    }
}