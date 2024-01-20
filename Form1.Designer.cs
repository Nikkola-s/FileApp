namespace FileApp
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
            btnOpenSearch = new Button();
            SuspendLayout();
            // 
            // btnOpenSearch
            // 
            btnOpenSearch.Location = new Point(231, 183);
            btnOpenSearch.Name = "btnOpenSearch";
            btnOpenSearch.Size = new Size(340, 29);
            btnOpenSearch.TabIndex = 0;
            btnOpenSearch.Text = "Пошук папки";
            btnOpenSearch.UseVisualStyleBackColor = true;
            btnOpenSearch.Click += btnOpenSearch_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpenSearch);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenSearch;
    }
}