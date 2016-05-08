namespace Solver
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
            this.startButton = new System.Windows.Forms.Button();
            this.listBox_sequence = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_maxMember = new System.Windows.Forms.TextBox();
            this.label_3K = new System.Windows.Forms.Label();
            this.label_2k = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox_showSequence = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_inputvalue = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(334, 389);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // listBox_sequence
            // 
            this.listBox_sequence.FormattingEnabled = true;
            this.listBox_sequence.Location = new System.Drawing.Point(18, 127);
            this.listBox_sequence.Name = "listBox_sequence";
            this.listBox_sequence.Size = new System.Drawing.Size(360, 95);
            this.listBox_sequence.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "The sequence:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of 3k+1 operations: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number of 2k operations:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Maximum member:";
            // 
            // textBox_maxMember
            // 
            this.textBox_maxMember.Location = new System.Drawing.Point(115, 78);
            this.textBox_maxMember.Name = "textBox_maxMember";
            this.textBox_maxMember.ReadOnly = true;
            this.textBox_maxMember.Size = new System.Drawing.Size(263, 20);
            this.textBox_maxMember.TabIndex = 6;
            this.textBox_maxMember.Tag = "";
            // 
            // label_3K
            // 
            this.label_3K.AutoSize = true;
            this.label_3K.Location = new System.Drawing.Point(162, 26);
            this.label_3K.Name = "label_3K";
            this.label_3K.Size = new System.Drawing.Size(13, 13);
            this.label_3K.TabIndex = 7;
            this.label_3K.Text = "0";
            // 
            // label_2k
            // 
            this.label_2k.AutoSize = true;
            this.label_2k.Location = new System.Drawing.Point(162, 52);
            this.label_2k.Name = "label_2k";
            this.label_2k.Size = new System.Drawing.Size(13, 13);
            this.label_2k.TabIndex = 9;
            this.label_2k.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox_showSequence);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label_2k);
            this.groupBox1.Controls.Add(this.listBox_sequence);
            this.groupBox1.Controls.Add(this.label_3K);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_maxMember);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 274);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // checkBox_showSequence
            // 
            this.checkBox_showSequence.AutoSize = true;
            this.checkBox_showSequence.Checked = true;
            this.checkBox_showSequence.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_showSequence.Location = new System.Drawing.Point(18, 237);
            this.checkBox_showSequence.Name = "checkBox_showSequence";
            this.checkBox_showSequence.Size = new System.Drawing.Size(324, 17);
            this.checkBox_showSequence.TabIndex = 10;
            this.checkBox_showSequence.Text = "Show the sequence (Will be somewhat slow for big input value)";
            this.checkBox_showSequence.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_inputvalue);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 91);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Natural number (max 1000 digits)";
            // 
            // textBox_inputvalue
            // 
            this.textBox_inputvalue.Location = new System.Drawing.Point(18, 44);
            this.textBox_inputvalue.MaxLength = 1000;
            this.textBox_inputvalue.Name = "textBox_inputvalue";
            this.textBox_inputvalue.Size = new System.Drawing.Size(360, 20);
            this.textBox_inputvalue.TabIndex = 0;
            this.textBox_inputvalue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_inputvalue_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 424);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.startButton);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solver";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ListBox listBox_sequence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_maxMember;
        private System.Windows.Forms.Label label_3K;
        private System.Windows.Forms.Label label_2k;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_inputvalue;
        private System.Windows.Forms.CheckBox checkBox_showSequence;
    }
}

