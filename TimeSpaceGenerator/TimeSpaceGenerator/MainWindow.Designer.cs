﻿using System.Drawing;
using System.Windows.Forms;

namespace TimeSpaceGenerator
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.PacketTextBox = new System.Windows.Forms.TextBox();
            this.GenerateXmlButton = new System.Windows.Forms.Button();
            this.PacketsLabel = new System.Windows.Forms.Label();
            this.ErrorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.Button();
            this.GenerateXmlFileButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonXmlFilePreview = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PacketTextBox
            // 
            this.PacketTextBox.BackColor = System.Drawing.Color.Silver;
            this.PacketTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PacketTextBox.Location = new System.Drawing.Point(13, 122);
            this.PacketTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PacketTextBox.MaxLength = 0;
            this.PacketTextBox.Multiline = true;
            this.PacketTextBox.Name = "PacketTextBox";
            this.PacketTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PacketTextBox.Size = new System.Drawing.Size(909, 337);
            this.PacketTextBox.TabIndex = 1;
            // 
            // GenerateXmlButton
            // 
            this.GenerateXmlButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateXmlButton.Location = new System.Drawing.Point(53, 18);
            this.GenerateXmlButton.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateXmlButton.Name = "GenerateXmlButton";
            this.GenerateXmlButton.Size = new System.Drawing.Size(232, 100);
            this.GenerateXmlButton.TabIndex = 2;
            this.GenerateXmlButton.Text = "G E N E R A T E";
            this.GenerateXmlButton.UseVisualStyleBackColor = true;
            this.GenerateXmlButton.Click += new System.EventHandler(this.GenerateXmlButton_Click);
            // 
            // PacketsLabel
            // 
            this.PacketsLabel.AutoSize = true;
            this.PacketsLabel.Location = new System.Drawing.Point(13, 78);
            this.PacketsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PacketsLabel.Name = "PacketsLabel";
            this.PacketsLabel.Size = new System.Drawing.Size(87, 23);
            this.PacketsLabel.TabIndex = 3;
            this.PacketsLabel.Text = "Packets";
            this.PacketsLabel.Click += new System.EventHandler(this.PacketsLabel_Click);
            // 
            // ErrorTextBox
            // 
            this.ErrorTextBox.BackColor = System.Drawing.Color.Silver;
            this.ErrorTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorTextBox.Location = new System.Drawing.Point(13, 515);
            this.ErrorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ErrorTextBox.Multiline = true;
            this.ErrorTextBox.Name = "ErrorTextBox";
            this.ErrorTextBox.ReadOnly = true;
            this.ErrorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ErrorTextBox.Size = new System.Drawing.Size(909, 199);
            this.ErrorTextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 471);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Error Log";
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.BackColor = System.Drawing.Color.White;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ExitButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExitButton.Location = new System.Drawing.Point(959, 12);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(20, 20);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // GenerateXmlFileButton
            // 
            this.GenerateXmlFileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateXmlFileButton.Location = new System.Drawing.Point(353, 18);
            this.GenerateXmlFileButton.Margin = new System.Windows.Forms.Padding(4);
            this.GenerateXmlFileButton.Name = "GenerateXmlFileButton";
            this.GenerateXmlFileButton.Size = new System.Drawing.Size(232, 100);
            this.GenerateXmlFileButton.TabIndex = 10;
            this.GenerateXmlFileButton.Text = "G E N E R A T E\r\nX M L";
            this.GenerateXmlFileButton.UseVisualStyleBackColor = true;
            this.GenerateXmlFileButton.Click += new System.EventHandler(this.GenerateXmlFileButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.buttonMinimize);
            this.panel1.Controls.Add(this.buttonClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 79);
            this.panel1.TabIndex = 13;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(299, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "TimeSpace Generator";
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Location = new System.Drawing.Point(673, 12);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(117, 53);
            this.buttonMinimize.TabIndex = 1;
            this.buttonMinimize.Text = "Minimize";
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Location = new System.Drawing.Point(805, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(117, 53);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonXmlFilePreview);
            this.panel2.Controls.Add(this.GenerateXmlButton);
            this.panel2.Controls.Add(this.GenerateXmlFileButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 736);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 131);
            this.panel2.TabIndex = 14;
            // 
            // buttonXmlFilePreview
            // 
            this.buttonXmlFilePreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXmlFilePreview.Location = new System.Drawing.Point(653, 18);
            this.buttonXmlFilePreview.Name = "buttonXmlFilePreview";
            this.buttonXmlFilePreview.Size = new System.Drawing.Size(232, 100);
            this.buttonXmlFilePreview.TabIndex = 12;
            this.buttonXmlFilePreview.Text = "F I L E \r\nP R E V I E W";
            this.buttonXmlFilePreview.UseVisualStyleBackColor = true;
            this.buttonXmlFilePreview.Click += new System.EventHandler(this.ButtonXmlFilePreview_Click);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.DefaultExt = "xml";
            this.SaveFileDialog.Filter = "XML Files|*.xml";
            this.SaveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.GenerateXmlFile);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(935, 867);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ErrorTextBox);
            this.Controls.Add(this.PacketTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PacketsLabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PacketTextBox;
        private System.Windows.Forms.Button GenerateXmlButton;
        private System.Windows.Forms.Label PacketsLabel;
        private System.Windows.Forms.TextBox ErrorTextBox;
        private System.Windows.Forms.Label label1;
        private Button ExitButton;
        private Button GenerateXmlFileButton;
        private Panel panel1;
        private Label label4;
        private Button buttonMinimize;
        private Button buttonClose;
        private Panel panel2;
        private Button buttonXmlFilePreview;
        private SaveFileDialog SaveFileDialog;
    }
}

