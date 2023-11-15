namespace interface111
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
            this.создатьСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьЭлементToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переборКнопокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переборОбъектовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.создатьЭнумераторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveNextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьЭнумераторToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.moveNextToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.currentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьСписокToolStripMenuItem,
            this.добавитьЭлементToolStripMenuItem,
            this.переборКнопокToolStripMenuItem,
            this.переборОбъектовToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(621, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // создатьСписокToolStripMenuItem
            // 
            this.создатьСписокToolStripMenuItem.Name = "создатьСписокToolStripMenuItem";
            this.создатьСписокToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.создатьСписокToolStripMenuItem.Text = "Создать список";
            this.создатьСписокToolStripMenuItem.Click += new System.EventHandler(this.создатьСписокToolStripMenuItem_Click);
            // 
            // добавитьЭлементToolStripMenuItem
            // 
            this.добавитьЭлементToolStripMenuItem.Name = "добавитьЭлементToolStripMenuItem";
            this.добавитьЭлементToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.добавитьЭлементToolStripMenuItem.Text = "Добавить элемент";
            this.добавитьЭлементToolStripMenuItem.Click += new System.EventHandler(this.добавитьЭлементToolStripMenuItem_Click_1);
            // 
            // переборКнопокToolStripMenuItem
            // 
            this.переборКнопокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьЭнумераторToolStripMenuItem,
            this.moveNextToolStripMenuItem,
            this.currentToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.переборКнопокToolStripMenuItem.Name = "переборКнопокToolStripMenuItem";
            this.переборКнопокToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.переборКнопокToolStripMenuItem.Text = "Перебор кнопок";
            // 
            // переборОбъектовToolStripMenuItem
            // 
            this.переборОбъектовToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьЭнумераторToolStripMenuItem1,
            this.moveNextToolStripMenuItem1,
            this.currentToolStripMenuItem1,
            this.resetToolStripMenuItem1});
            this.переборОбъектовToolStripMenuItem.Name = "переборОбъектовToolStripMenuItem";
            this.переборОбъектовToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.переборОбъектовToolStripMenuItem.Text = "Перебор объектов";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Location = new System.Drawing.Point(26, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 100);
            this.panel1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 371);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(621, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // создатьЭнумераторToolStripMenuItem
            // 
            this.создатьЭнумераторToolStripMenuItem.Name = "создатьЭнумераторToolStripMenuItem";
            this.создатьЭнумераторToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.создатьЭнумераторToolStripMenuItem.Text = "Создать энумератор";
            this.создатьЭнумераторToolStripMenuItem.Click += new System.EventHandler(this.создатьЭнумераторToolStripMenuItem_Click);
            // 
            // moveNextToolStripMenuItem
            // 
            this.moveNextToolStripMenuItem.Checked = true;
            this.moveNextToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.moveNextToolStripMenuItem.Name = "moveNextToolStripMenuItem";
            this.moveNextToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.moveNextToolStripMenuItem.Text = "MoveNext";
            this.moveNextToolStripMenuItem.Click += new System.EventHandler(this.moveNextToolStripMenuItem_Click);
            // 
            // currentToolStripMenuItem
            // 
            this.currentToolStripMenuItem.Name = "currentToolStripMenuItem";
            this.currentToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.currentToolStripMenuItem.Text = "Current";
            this.currentToolStripMenuItem.Click += new System.EventHandler(this.currentToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // создатьЭнумераторToolStripMenuItem1
            // 
            this.создатьЭнумераторToolStripMenuItem1.Name = "создатьЭнумераторToolStripMenuItem1";
            this.создатьЭнумераторToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.создатьЭнумераторToolStripMenuItem1.Text = "Создать энумератор";
            this.создатьЭнумераторToolStripMenuItem1.Click += new System.EventHandler(this.создатьЭнумераторToolStripMenuItem1_Click);
            // 
            // moveNextToolStripMenuItem1
            // 
            this.moveNextToolStripMenuItem1.Name = "moveNextToolStripMenuItem1";
            this.moveNextToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.moveNextToolStripMenuItem1.Text = "MoveNext";
            this.moveNextToolStripMenuItem1.Click += new System.EventHandler(this.moveNextToolStripMenuItem1_Click);
            // 
            // currentToolStripMenuItem1
            // 
            this.currentToolStripMenuItem1.Name = "currentToolStripMenuItem1";
            this.currentToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.currentToolStripMenuItem1.Text = "Current";
            this.currentToolStripMenuItem1.Click += new System.EventHandler(this.currentToolStripMenuItem1_Click);
            // 
            // resetToolStripMenuItem1
            // 
            this.resetToolStripMenuItem1.Name = "resetToolStripMenuItem1";
            this.resetToolStripMenuItem1.Size = new System.Drawing.Size(186, 22);
            this.resetToolStripMenuItem1.Text = "Reset";
            this.resetToolStripMenuItem1.Click += new System.EventHandler(this.resetToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(621, 393);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem создатьСписокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьЭлементToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переборКнопокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переборОбъектовToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem создатьЭнумераторToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveNextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьЭнумераторToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem moveNextToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem currentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem1;
    }
}

