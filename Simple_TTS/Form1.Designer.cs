namespace Simple_TTS
{
    partial class Form1
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
            this.TextHolder = new System.Windows.Forms.RichTextBox();
            this.TTS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextHolder
            // 
            this.TextHolder.Location = new System.Drawing.Point(33, 54);
            this.TextHolder.Name = "TextHolder";
            this.TextHolder.Size = new System.Drawing.Size(466, 251);
            this.TextHolder.TabIndex = 0;
            this.TextHolder.Text = "";
            this.TextHolder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextHolder_KeyDown);
          
            // 
            // TTS
            // 
            this.TTS.Location = new System.Drawing.Point(610, 148);
            this.TTS.Name = "TTS";
            this.TTS.Size = new System.Drawing.Size(107, 49);
            this.TTS.TabIndex = 1;
            this.TTS.Text = "TTS";
            this.TTS.UseVisualStyleBackColor = true;
            this.TTS.Click += new System.EventHandler(this.TTS_Click);
        
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TTS);
            this.Controls.Add(this.TextHolder);
            this.Name = "TTS";
            this.Text = "Simple TTS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextHolder;
        private System.Windows.Forms.Button TTS;
    }
}

