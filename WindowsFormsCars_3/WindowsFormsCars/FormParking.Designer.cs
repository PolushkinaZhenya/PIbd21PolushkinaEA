﻿namespace WindowsFormsCars
{
     partial class FormParking 
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonSetTruckTrailer = new System.Windows.Forms.Button();
            this.buttonSetTruck = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBoxTakeTruck = new System.Windows.Forms.PictureBox();
            this.buttonTakeTruck = new System.Windows.Forms.Button();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeTruck)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxParking.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(733, 500);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonSetTruckTrailer
            // 
            this.buttonSetTruckTrailer.Location = new System.Drawing.Point(815, 16);
            this.buttonSetTruckTrailer.Name = "buttonSetTruckTrailer";
            this.buttonSetTruckTrailer.Size = new System.Drawing.Size(172, 71);
            this.buttonSetTruckTrailer.TabIndex = 1;
            this.buttonSetTruckTrailer.Text = "Припарковать грузовик";
            this.buttonSetTruckTrailer.UseVisualStyleBackColor = true;
            this.buttonSetTruckTrailer.Click += new System.EventHandler(this.buttonSetTruckTrailer_Click);
            // 
            // buttonSetTruck
            // 
            this.buttonSetTruck.Location = new System.Drawing.Point(815, 93);
            this.buttonSetTruck.Name = "buttonSetTruck";
            this.buttonSetTruck.Size = new System.Drawing.Size(172, 75);
            this.buttonSetTruck.TabIndex = 2;
            this.buttonSetTruck.Text = "Припарковать грузовик-полуприцеп";
            this.buttonSetTruck.UseVisualStyleBackColor = true;
            this.buttonSetTruck.Click += new System.EventHandler(this.buttonSetTruck_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBoxTakeTruck);
            this.groupBox1.Controls.Add(this.buttonTakeTruck);
            this.groupBox1.Controls.Add(this.maskedTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(733, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 284);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Забрать машину:";
            // 
            // pictureBoxTakeTruck
            // 
            this.pictureBoxTakeTruck.Location = new System.Drawing.Point(29, 162);
            this.pictureBoxTakeTruck.Name = "pictureBoxTakeTruck";
            this.pictureBoxTakeTruck.Size = new System.Drawing.Size(225, 119);
            this.pictureBoxTakeTruck.TabIndex = 3;
            this.pictureBoxTakeTruck.TabStop = false;
            // 
            // buttonTakeTruck
            // 
            this.buttonTakeTruck.Location = new System.Drawing.Point(68, 108);
            this.buttonTakeTruck.Name = "buttonTakeTruck";
            this.buttonTakeTruck.Size = new System.Drawing.Size(105, 48);
            this.buttonTakeTruck.TabIndex = 2;
            this.buttonTakeTruck.Text = "Забрать";
            this.buttonTakeTruck.UseVisualStyleBackColor = true;
            this.buttonTakeTruck.Click += new System.EventHandler(this.buttonTakeTruck_Click);
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(106, 80);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(28, 22);
            this.maskedTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(26, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место:";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 500);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSetTruck);
            this.Controls.Add(this.buttonSetTruckTrailer);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeTruck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonSetTruckTrailer;
        private System.Windows.Forms.Button buttonSetTruck;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBoxTakeTruck;
        private System.Windows.Forms.Button buttonTakeTruck;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label label1;
    }
}