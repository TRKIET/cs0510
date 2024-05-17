namespace gp510
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mybutten = new Button();
            SuspendLayout();
            // 
            // mybutten
            // 
            mybutten.BackColor = SystemColors.ActiveCaption;
            mybutten.Location = new Point(114, 97);
            mybutten.Margin = new Padding(3, 4, 3, 4);
            mybutten.Name = "mybutten";
            mybutten.Size = new Size(237, 233);
            mybutten.TabIndex = 0;
            mybutten.Text = "button1";
            mybutten.UseVisualStyleBackColor = false;
            mybutten.Click += mybutten_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(914, 540);
            Controls.Add(mybutten);
            Font = new Font("メイリオ", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button mybutten;
    }
}