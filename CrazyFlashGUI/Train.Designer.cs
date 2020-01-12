using System;

namespace CrazyFlashGUI
{
    partial class Train
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.ResultBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuestionLabel.Location = new System.Drawing.Point(416, 98);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(118, 32);
            this.QuestionLabel.TabIndex = 1;
            this.QuestionLabel.Text = "Question";
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AnswerLabel.Location = new System.Drawing.Point(416, 203);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(100, 32);
            this.AnswerLabel.TabIndex = 2;
            this.AnswerLabel.Text = "Answer";
            // 
            // ResultBtn
            // 
            this.ResultBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultBtn.Location = new System.Drawing.Point(402, 381);
            this.ResultBtn.Name = "ResultBtn";
            this.ResultBtn.Size = new System.Drawing.Size(141, 35);
            this.ResultBtn.TabIndex = 3;
            this.ResultBtn.Text = "Show Result";
            this.ResultBtn.UseVisualStyleBackColor = true;
            this.ResultBtn.Click += new System.EventHandler(this.ResultBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtn.Location = new System.Drawing.Point(653, 381);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(141, 35);
            this.NextBtn.TabIndex = 4;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            // 
            // Train
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.ResultBtn);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.label1);
            this.Name = "Train";
            this.Size = new System.Drawing.Size(981, 602);
            this.Load += new System.EventHandler(this.Train_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.Button ResultBtn;
        private System.Windows.Forms.Button NextBtn;
    }
}
