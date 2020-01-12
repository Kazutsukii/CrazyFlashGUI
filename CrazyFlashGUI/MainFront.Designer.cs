namespace CrazyFlashGUI
{
    partial class MainFront
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
            this.components = new System.ComponentModel.Container();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.TrainButton = new System.Windows.Forms.Button();
            this.ListDeck = new System.Windows.Forms.ListBox();
            this.AddDeckButton = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(626, 246);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(114, 40);
            this.RemoveButton.TabIndex = 12;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            // 
            // ModifyButton
            // 
            this.ModifyButton.Location = new System.Drawing.Point(626, 173);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(114, 40);
            this.ModifyButton.TabIndex = 11;
            this.ModifyButton.Text = "Modify";
            this.ModifyButton.UseVisualStyleBackColor = true;
            // 
            // TrainButton
            // 
            this.TrainButton.Location = new System.Drawing.Point(626, 101);
            this.TrainButton.Name = "TrainButton";
            this.TrainButton.Size = new System.Drawing.Size(114, 40);
            this.TrainButton.TabIndex = 10;
            this.TrainButton.Text = "Train";
            this.TrainButton.UseVisualStyleBackColor = true;
            this.TrainButton.Click += new System.EventHandler(this.TrainButton_Click);
            // 
            // ListDeck
            // 
            this.ListDeck.FormattingEnabled = true;
            this.ListDeck.Location = new System.Drawing.Point(103, 62);
            this.ListDeck.Name = "ListDeck";
            this.ListDeck.Size = new System.Drawing.Size(423, 355);
            this.ListDeck.TabIndex = 9;
            // 
            // AddDeckButton
            // 
            this.AddDeckButton.Location = new System.Drawing.Point(429, 486);
            this.AddDeckButton.Name = "AddDeckButton";
            this.AddDeckButton.Size = new System.Drawing.Size(114, 40);
            this.AddDeckButton.TabIndex = 8;
            this.AddDeckButton.Text = "Add a deck";
            this.AddDeckButton.UseVisualStyleBackColor = true;
            // 
            // MainFront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.TrainButton);
            this.Controls.Add(this.ListDeck);
            this.Controls.Add(this.AddDeckButton);
            this.Name = "MainFront";
            this.Size = new System.Drawing.Size(981, 602);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button ModifyButton;
        private System.Windows.Forms.Button TrainButton;
        private System.Windows.Forms.ListBox ListDeck;
        private System.Windows.Forms.Button AddDeckButton;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}
