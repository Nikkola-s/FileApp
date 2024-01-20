namespace FileApp
{
    partial class SearchForm
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
            txtFolderPath = new TextBox();
            txtSearchPattern = new TextBox();
            btnBrowse = new Button();
            btnSearch = new Button();
            listViewFiles = new ListView();
            SuspendLayout();
            // 
            // txtFolderPath
            // 
            txtFolderPath.Location = new Point(129, 50);
            txtFolderPath.Name = "txtFolderPath";
            txtFolderPath.Size = new Size(454, 27);
            txtFolderPath.TabIndex = 0;
            // 
            // txtSearchPattern
            // 
            txtSearchPattern.Location = new Point(129, 129);
            txtSearchPattern.Name = "txtSearchPattern";
            txtSearchPattern.Size = new Size(454, 27);
            txtSearchPattern.TabIndex = 1;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(133, 205);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(143, 29);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Вибір папки";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(459, 205);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Пошук";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // listViewFiles
            // 
            listViewFiles.Location = new Point(130, 275);
            listViewFiles.Name = "listViewFiles";
            listViewFiles.Size = new Size(441, 121);
            listViewFiles.TabIndex = 4;
            listViewFiles.UseCompatibleStateImageBehavior = false;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listViewFiles);
            Controls.Add(btnSearch);
            Controls.Add(btnBrowse);
            Controls.Add(txtSearchPattern);
            Controls.Add(txtFolderPath);
            Name = "SearchForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFolderPath;
        private TextBox txtSearchPattern;
        private Button btnBrowse;
        private Button btnSearch;
        private ListView listViewFiles;
    }
}