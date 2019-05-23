﻿namespace ArrayForm
{
    partial class ArrayForm
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
            this.ShowButton = new System.Windows.Forms.Button();
            this.showRichTextBox = new System.Windows.Forms.RichTextBox();
            this.addTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ReverseButton = new System.Windows.Forms.Button();
            this.SumButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.duplicateButton = new System.Windows.Forms.Button();
            this.uniqueButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(252, 68);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(86, 39);
            this.ShowButton.TabIndex = 0;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // showRichTextBox
            // 
            this.showRichTextBox.Location = new System.Drawing.Point(44, 68);
            this.showRichTextBox.Name = "showRichTextBox";
            this.showRichTextBox.Size = new System.Drawing.Size(202, 265);
            this.showRichTextBox.TabIndex = 1;
            this.showRichTextBox.Text = "";
            // 
            // addTextBox
            // 
            this.addTextBox.BackColor = System.Drawing.Color.White;
            this.addTextBox.Location = new System.Drawing.Point(44, 38);
            this.addTextBox.Name = "addTextBox";
            this.addTextBox.Size = new System.Drawing.Size(131, 20);
            this.addTextBox.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(184, 35);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(62, 26);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ReverseButton
            // 
            this.ReverseButton.Location = new System.Drawing.Point(252, 128);
            this.ReverseButton.Name = "ReverseButton";
            this.ReverseButton.Size = new System.Drawing.Size(86, 40);
            this.ReverseButton.TabIndex = 4;
            this.ReverseButton.Text = "Reverse";
            this.ReverseButton.UseVisualStyleBackColor = true;
            this.ReverseButton.Click += new System.EventHandler(this.ReverseButton_Click);
            // 
            // SumButton
            // 
            this.SumButton.Location = new System.Drawing.Point(252, 185);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(86, 39);
            this.SumButton.TabIndex = 5;
            this.SumButton.Text = "Sum";
            this.SumButton.UseVisualStyleBackColor = true;
            this.SumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.Location = new System.Drawing.Point(252, 241);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(86, 37);
            this.CopyButton.TabIndex = 7;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = true;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // duplicateButton
            // 
            this.duplicateButton.Location = new System.Drawing.Point(354, 128);
            this.duplicateButton.Name = "duplicateButton";
            this.duplicateButton.Size = new System.Drawing.Size(86, 40);
            this.duplicateButton.TabIndex = 8;
            this.duplicateButton.Text = "Duplicate";
            this.duplicateButton.UseVisualStyleBackColor = true;
            this.duplicateButton.Click += new System.EventHandler(this.duplicateButton_Click);
            // 
            // uniqueButton
            // 
            this.uniqueButton.Location = new System.Drawing.Point(354, 68);
            this.uniqueButton.Name = "uniqueButton";
            this.uniqueButton.Size = new System.Drawing.Size(93, 39);
            this.uniqueButton.TabIndex = 9;
            this.uniqueButton.Text = "Unique";
            this.uniqueButton.UseVisualStyleBackColor = true;
            // 
            // ArrayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 401);
            this.Controls.Add(this.uniqueButton);
            this.Controls.Add(this.duplicateButton);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.SumButton);
            this.Controls.Add(this.ReverseButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.addTextBox);
            this.Controls.Add(this.showRichTextBox);
            this.Controls.Add(this.ShowButton);
            this.Name = "ArrayForm";
            this.Text = "Array Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.RichTextBox showRichTextBox;
        private System.Windows.Forms.TextBox addTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ReverseButton;
        private System.Windows.Forms.Button SumButton;
        private System.Windows.Forms.Button CopyButton;
        private System.Windows.Forms.Button duplicateButton;
        private System.Windows.Forms.Button uniqueButton;
    }
}

