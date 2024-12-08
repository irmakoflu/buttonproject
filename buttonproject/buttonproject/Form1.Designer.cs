namespace buttonproject
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
            component11 = new Component1();
            SuspendLayout();
            // 
            // component11
            // 
            component11.BackColor = Color.Orange;
            component11.FlatAppearance.BorderSize = 0;
            component11.FlatStyle = FlatStyle.Flat;
            component11.ForeColor = Color.White;
            component11.Location = new Point(238, 94);
            component11.Name = "component11";
            component11.Size = new Size(240, 127);
            component11.TabIndex = 0;
            component11.Text = "component11";
            component11.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(component11);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Component1 component11;
    }
}
