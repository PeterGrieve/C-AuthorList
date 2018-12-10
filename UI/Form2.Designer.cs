namespace UI
{
    partial class Form2
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
            this.doneButton = new System.Windows.Forms.Button();
            this.idBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fname = new System.Windows.Forms.Label();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lnameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addressBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.Label();
            this.stateBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.zipBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.contractBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(219, 276);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(107, 31);
            this.doneButton.TabIndex = 0;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(15, 38);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(152, 20);
            this.idBox.TabIndex = 1;
            this.idBox.TextChanged += new System.EventHandler(this.idBox_TextChanged);
            this.idBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Number:";
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(12, 79);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(60, 13);
            this.fname.TabIndex = 3;
            this.fname.Text = "First Name:";
            // 
            // fnameBox
            // 
            this.fnameBox.Location = new System.Drawing.Point(15, 96);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(152, 20);
            this.fnameBox.TabIndex = 4;
            this.fnameBox.TextChanged += new System.EventHandler(this.fnameBox_TextChanged);
            this.fnameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fnameBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name:";
            // 
            // lnameBox
            // 
            this.lnameBox.Location = new System.Drawing.Point(15, 158);
            this.lnameBox.Name = "lnameBox";
            this.lnameBox.Size = new System.Drawing.Size(152, 20);
            this.lnameBox.TabIndex = 6;
            this.lnameBox.TextChanged += new System.EventHandler(this.lnameBox_TextChanged);
            this.lnameBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lnameBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone:";
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(15, 219);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(152, 20);
            this.phoneBox.TabIndex = 8;
            this.phoneBox.TextChanged += new System.EventHandler(this.phoneBox_TextChanged);
            this.phoneBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address:";
            // 
            // addressBox
            // 
            this.addressBox.Location = new System.Drawing.Point(15, 276);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(152, 20);
            this.addressBox.TabIndex = 10;
            this.addressBox.TextChanged += new System.EventHandler(this.addressBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "City:";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(219, 37);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(137, 20);
            this.cityBox.TabIndex = 12;
            this.cityBox.TextChanged += new System.EventHandler(this.cityBox_TextChanged);
            this.cityBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cityBox_KeyPress);
            // 
            // state
            // 
            this.state.AutoSize = true;
            this.state.Location = new System.Drawing.Point(216, 79);
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(35, 13);
            this.state.TabIndex = 13;
            this.state.Text = "State:";
            // 
            // stateBox
            // 
            this.stateBox.Location = new System.Drawing.Point(219, 95);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(137, 20);
            this.stateBox.TabIndex = 14;
            this.stateBox.TextChanged += new System.EventHandler(this.stateBox_TextChanged);
            this.stateBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stateBox_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Zip Code:";
            // 
            // zipBox
            // 
            this.zipBox.Location = new System.Drawing.Point(219, 157);
            this.zipBox.Name = "zipBox";
            this.zipBox.Size = new System.Drawing.Size(137, 20);
            this.zipBox.TabIndex = 16;
            this.zipBox.TextChanged += new System.EventHandler(this.zipBox_TextChanged);
            this.zipBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zipBox_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Contract:";
            // 
            // contractBox
            // 
            this.contractBox.FormattingEnabled = true;
            this.contractBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.contractBox.Location = new System.Drawing.Point(219, 219);
            this.contractBox.Name = "contractBox";
            this.contractBox.Size = new System.Drawing.Size(137, 21);
            this.contractBox.TabIndex = 19;
            this.contractBox.TextChanged += new System.EventHandler(this.contractBox_TextChanged);
            this.contractBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contractBox_KeyPress);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 332);
            this.Controls.Add(this.contractBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.zipBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.state);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addressBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lnameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.doneButton);
            this.Name = "Form2";
            this.Text = "Add an Author";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lnameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addressBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label state;
        private System.Windows.Forms.TextBox stateBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox zipBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox contractBox;
    }
}