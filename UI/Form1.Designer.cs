namespace UI
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
            this.authorListView = new System.Windows.Forms.ListView();
            this.addButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorListView
            // 
            this.authorListView.Location = new System.Drawing.Point(13, 13);
            this.authorListView.Name = "authorListView";
            this.authorListView.Size = new System.Drawing.Size(667, 427);
            this.authorListView.TabIndex = 0;
            this.authorListView.UseCompatibleStateImageBehavior = false;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(717, 48);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(111, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add Author";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(718, 88);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(110, 23);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 521);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.authorListView);
            this.MaximumSize = new System.Drawing.Size(856, 560);
            this.MinimumSize = new System.Drawing.Size(856, 560);
            this.Name = "Form1";
            this.Text = "Author List";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button exitButton;
        public System.Windows.Forms.ListView authorListView;
    }
}

