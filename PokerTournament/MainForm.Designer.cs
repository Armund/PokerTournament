﻿namespace PokerTournament
{
    partial class MainForm
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
            this.listBoxPersons.Location = new System.Drawing.Point(427, 50);
            this.listBoxPersons.Name = "listBoxPersons";
            this.listBoxPersons.Size = new System.Drawing.Size(333, 381);
            this.listBoxPersons.TabIndex = 3;
            // 
            // buttonListbox
            // 
            this.buttonListbox.Location = new System.Drawing.Point(766, 48);
            this.buttonListbox.Name = "buttonListbox";
            this.buttonListbox.Size = new System.Drawing.Size(75, 23);
            this.buttonListbox.TabIndex = 4;
            this.buttonListbox.Text = "Показать";
            this.buttonListbox.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 655);
            this.Controls.Add(this.buttonListbox);
            this.Controls.Add(this.listBoxPersons);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxName);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.ListBox listBoxPersons;
        private System.Windows.Forms.Button buttonListbox;
    }
}

