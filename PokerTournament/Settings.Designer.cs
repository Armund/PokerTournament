namespace PokerTournament
{
    partial class Settings
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.listBoxPersons = new System.Windows.Forms.ListBox();
            this.buttonListbox = new System.Windows.Forms.Button();
            this.btnClearPeople = new System.Windows.Forms.Button();
            this.btnLanding = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(33, 50);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(185, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(30, 34);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(29, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Имя";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(224, 48);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // listBoxPersons
            // 
            this.listBoxPersons.AccessibleDescription = "";
            this.listBoxPersons.FormattingEnabled = true;
            this.listBoxPersons.Location = new System.Drawing.Point(337, 34);
            this.listBoxPersons.Name = "listBoxPersons";
            this.listBoxPersons.Size = new System.Drawing.Size(567, 693);
            this.listBoxPersons.TabIndex = 3;
            // 
            // buttonListbox
            // 
            this.buttonListbox.Location = new System.Drawing.Point(910, 49);
            this.buttonListbox.Name = "buttonListbox";
            this.buttonListbox.Size = new System.Drawing.Size(75, 23);
            this.buttonListbox.TabIndex = 4;
            this.buttonListbox.Text = "Обновить";
            this.buttonListbox.UseVisualStyleBackColor = true;
            this.buttonListbox.Click += new System.EventHandler(this.buttonListbox_Click);
            // 
            // btnClearPeople
            // 
            this.btnClearPeople.Location = new System.Drawing.Point(910, 78);
            this.btnClearPeople.Name = "btnClearPeople";
            this.btnClearPeople.Size = new System.Drawing.Size(75, 23);
            this.btnClearPeople.TabIndex = 5;
            this.btnClearPeople.Text = "Очистить";
            this.btnClearPeople.UseVisualStyleBackColor = true;
            this.btnClearPeople.Click += new System.EventHandler(this.btnClearPeople_Click);
            // 
            // btnLanding
            // 
            this.btnLanding.Location = new System.Drawing.Point(910, 107);
            this.btnLanding.Name = "btnLanding";
            this.btnLanding.Size = new System.Drawing.Size(75, 23);
            this.btnLanding.TabIndex = 6;
            this.btnLanding.Text = "Рассадить";
            this.btnLanding.UseVisualStyleBackColor = true;
            this.btnLanding.Click += new System.EventHandler(this.btnLanding_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 732);
            this.Controls.Add(this.btnLanding);
            this.Controls.Add(this.btnClearPeople);
            this.Controls.Add(this.buttonListbox);
            this.Controls.Add(this.listBoxPersons);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Name = "Settings";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxPersons;
        private System.Windows.Forms.Button buttonListbox;
        private System.Windows.Forms.Button btnClearPeople;
        private System.Windows.Forms.Button btnLanding;
    }
}

