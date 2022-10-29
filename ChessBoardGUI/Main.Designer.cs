namespace ChessBoardGUI
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPiece = new System.Windows.Forms.ComboBox();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a piece, then place on board.";
            // 
            // cmbPiece
            // 
            this.cmbPiece.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPiece.FormattingEnabled = true;
            this.cmbPiece.Items.AddRange(new object[] {
            "King",
            "Queen",
            "Bishop",
            "Rook",
            "Knight"});
            this.cmbPiece.Location = new System.Drawing.Point(672, 20);
            this.cmbPiece.Name = "cmbPiece";
            this.cmbPiece.Size = new System.Drawing.Size(168, 33);
            this.cmbPiece.TabIndex = 1;
            // 
            // mainPanel
            // 
            this.mainPanel.Location = new System.Drawing.Point(40, 75);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 800);
            this.mainPanel.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 912);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.cmbPiece);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Chess Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPiece;
        private System.Windows.Forms.Panel mainPanel;
    }
}

