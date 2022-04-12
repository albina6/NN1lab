namespace NN1lab
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
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lawsB = new System.Windows.Forms.Button();
            this.yPanel = new System.Windows.Forms.Panel();
            this.addCriterionB = new System.Windows.Forms.Button();
            this.baseCritPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(937, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новыйToolStripMenuItem,
            this.сохранитьКакToolStripMenuItem,
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // новыйToolStripMenuItem
            // 
            this.новыйToolStripMenuItem.Name = "новыйToolStripMenuItem";
            this.новыйToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.новыйToolStripMenuItem.Text = "Новый";
            // 
            // сохранитьКакToolStripMenuItem
            // 
            this.сохранитьКакToolStripMenuItem.Name = "сохранитьКакToolStripMenuItem";
            this.сохранитьКакToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохранитьКакToolStripMenuItem.Text = "Сохранить как";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            // 
            // lawsB
            // 
            this.lawsB.Location = new System.Drawing.Point(572, 491);
            this.lawsB.Name = "lawsB";
            this.lawsB.Size = new System.Drawing.Size(165, 42);
            this.lawsB.TabIndex = 3;
            this.lawsB.Text = "Ввод/редактирование правил";
            this.lawsB.UseVisualStyleBackColor = true;
            this.lawsB.Click += new System.EventHandler(this.lawsB_Click);
            // 
            // yPanel
            // 
            this.yPanel.AccessibleName = "";
            this.yPanel.Location = new System.Drawing.Point(572, 50);
            this.yPanel.Name = "yPanel";
            this.yPanel.Size = new System.Drawing.Size(325, 357);
            this.yPanel.TabIndex = 5;
            // 
            // addCriterionB
            // 
            this.addCriterionB.Location = new System.Drawing.Point(572, 440);
            this.addCriterionB.Margin = new System.Windows.Forms.Padding(0);
            this.addCriterionB.Name = "addCriterionB";
            this.addCriterionB.Size = new System.Drawing.Size(165, 39);
            this.addCriterionB.TabIndex = 6;
            this.addCriterionB.Text = "Добавить критерий";
            this.addCriterionB.UseVisualStyleBackColor = true;
            this.addCriterionB.Click += new System.EventHandler(this.addCriterionB_Click);
            // 
            // baseCritPanel
            // 
            this.baseCritPanel.AutoScroll = true;
            this.baseCritPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.baseCritPanel.Location = new System.Drawing.Point(35, 50);
            this.baseCritPanel.Name = "baseCritPanel";
            this.baseCritPanel.Size = new System.Drawing.Size(489, 357);
            this.baseCritPanel.TabIndex = 7;
            this.baseCritPanel.WrapContents = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(937, 545);
            this.Controls.Add(this.baseCritPanel);
            this.Controls.Add(this.addCriterionB);
            this.Controls.Add(this.yPanel);
            this.Controls.Add(this.lawsB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.Button lawsB;
        private System.Windows.Forms.Panel yPanel;
        private System.Windows.Forms.Button addCriterionB;
        private System.Windows.Forms.FlowLayoutPanel baseCritPanel;
    }
}

