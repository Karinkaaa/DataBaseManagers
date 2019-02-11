using System;

namespace WinFormUI
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
            this.ManagersGrid = new System.Windows.Forms.DataGridView();
            this.NameText = new System.Windows.Forms.TextBox();
            this.SurnameText = new System.Windows.Forms.TextBox();
            this.AgeText = new System.Windows.Forms.TextBox();
            this.PhoneText = new System.Windows.Forms.TextBox();
            this.SaveManager = new System.Windows.Forms.Button();
            this.NameTextLabel = new System.Windows.Forms.Label();
            this.SurnameTextLabel = new System.Windows.Forms.Label();
            this.AgeTextLable = new System.Windows.Forms.Label();
            this.PhoneTextLabel = new System.Windows.Forms.Label();
            this.RemoveManager = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ManagersGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ManagersGrid
            // 
            this.ManagersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManagersGrid.Location = new System.Drawing.Point(12, 82);
            this.ManagersGrid.Name = "ManagersGrid";
            this.ManagersGrid.Size = new System.Drawing.Size(861, 393);
            this.ManagersGrid.TabIndex = 0;
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(18, 17);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(124, 20);
            this.NameText.TabIndex = 1;
            // 
            // SurnameText
            // 
            this.SurnameText.Location = new System.Drawing.Point(148, 17);
            this.SurnameText.Name = "SurnameText";
            this.SurnameText.Size = new System.Drawing.Size(157, 20);
            this.SurnameText.TabIndex = 2;
            // 
            // AgeText
            // 
            this.AgeText.Location = new System.Drawing.Point(311, 17);
            this.AgeText.Name = "AgeText";
            this.AgeText.Size = new System.Drawing.Size(54, 20);
            this.AgeText.TabIndex = 3;
            // 
            // PhoneText
            // 
            this.PhoneText.Location = new System.Drawing.Point(371, 17);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Size = new System.Drawing.Size(168, 20);
            this.PhoneText.TabIndex = 4;
            // 
            // SaveManager
            // 
            this.SaveManager.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.SaveManager.Location = new System.Drawing.Point(567, 8);
            this.SaveManager.Name = "SaveManager";
            this.SaveManager.Size = new System.Drawing.Size(113, 29);
            this.SaveManager.TabIndex = 5;
            this.SaveManager.Text = "SaveManager";
            this.SaveManager.UseVisualStyleBackColor = false;
            this.SaveManager.Click += new System.EventHandler(this.SaveManager_Click);
            // 
            // NameTextLabel
            // 
            this.NameTextLabel.AutoSize = true;
            this.NameTextLabel.Location = new System.Drawing.Point(63, 40);
            this.NameTextLabel.Name = "NameTextLabel";
            this.NameTextLabel.Size = new System.Drawing.Size(35, 13);
            this.NameTextLabel.TabIndex = 6;
            this.NameTextLabel.Text = "Name";
            this.NameTextLabel.Click += new System.EventHandler(this.Name_Click);
            // 
            // SurnameTextLabel
            // 
            this.SurnameTextLabel.AutoSize = true;
            this.SurnameTextLabel.Location = new System.Drawing.Point(204, 40);
            this.SurnameTextLabel.Name = "SurnameTextLabel";
            this.SurnameTextLabel.Size = new System.Drawing.Size(49, 13);
            this.SurnameTextLabel.TabIndex = 7;
            this.SurnameTextLabel.Text = "Surname";
            this.SurnameTextLabel.Click += new System.EventHandler(this.Surname_Click);
            // 
            // AgeTextLable
            // 
            this.AgeTextLable.AutoSize = true;
            this.AgeTextLable.Location = new System.Drawing.Point(326, 40);
            this.AgeTextLable.Name = "AgeTextLable";
            this.AgeTextLable.Size = new System.Drawing.Size(26, 13);
            this.AgeTextLable.TabIndex = 8;
            this.AgeTextLable.Text = "Age";
            this.AgeTextLable.Click += new System.EventHandler(this.label3_Click);
            // 
            // PhoneTextLabel
            // 
            this.PhoneTextLabel.AutoSize = true;
            this.PhoneTextLabel.Location = new System.Drawing.Point(429, 40);
            this.PhoneTextLabel.Name = "PhoneTextLabel";
            this.PhoneTextLabel.Size = new System.Drawing.Size(38, 13);
            this.PhoneTextLabel.TabIndex = 9;
            this.PhoneTextLabel.Text = "Phone";
            this.PhoneTextLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // RemoveManager
            // 
            this.RemoveManager.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.RemoveManager.Location = new System.Drawing.Point(567, 40);
            this.RemoveManager.Name = "RemoveManager";
            this.RemoveManager.Size = new System.Drawing.Size(113, 36);
            this.RemoveManager.TabIndex = 10;
            this.RemoveManager.Text = "RemoveManager";
            this.RemoveManager.UseVisualStyleBackColor = false;
            this.RemoveManager.Click += new System.EventHandler(this.RemoveManager_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 533);
            this.Controls.Add(this.RemoveManager);
            this.Controls.Add(this.PhoneTextLabel);
            this.Controls.Add(this.AgeTextLable);
            this.Controls.Add(this.SurnameTextLabel);
            this.Controls.Add(this.NameTextLabel);
            this.Controls.Add(this.SaveManager);
            this.Controls.Add(this.PhoneText);
            this.Controls.Add(this.AgeText);
            this.Controls.Add(this.SurnameText);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.ManagersGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ManagersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Surname_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Name_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.DataGridView ManagersGrid;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox SurnameText;
        private System.Windows.Forms.TextBox AgeText;
        private System.Windows.Forms.TextBox PhoneText;
        private System.Windows.Forms.Button SaveManager;
        private System.Windows.Forms.Label NameTextLabel;
        private System.Windows.Forms.Label SurnameTextLabel;
        private System.Windows.Forms.Label AgeTextLable;
        private System.Windows.Forms.Label PhoneTextLabel;
        private System.Windows.Forms.Button RemoveManager;
    }
}

