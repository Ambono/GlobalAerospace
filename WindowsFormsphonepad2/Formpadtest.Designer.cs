namespace WindowsFormsphonepad2
{
    partial class Formpadtest
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bt1 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.lbldisplay = new System.Windows.Forms.Label();
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.tmr2 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.btnAction);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(214, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 498);
            this.panel1.TabIndex = 0;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(528, 69);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(146, 72);
            this.exit.TabIndex = 15;
            this.exit.Text = "Close";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(203, 387);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(172, 52);
            this.btnAction.TabIndex = 14;
            this.btnAction.Text = "Show minimum time ";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel1.Controls.Add(this.bt1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn12, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn11, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn10, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.bt4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn8, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn6, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(191, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.23077F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.76923F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(272, 254);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(3, 3);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(85, 58);
            this.bt1.TabIndex = 5;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // btn12
            // 
            this.btn12.Location = new System.Drawing.Point(185, 198);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(84, 53);
            this.btn12.TabIndex = 12;
            this.btn12.Text = "#";
            this.btn12.UseVisualStyleBackColor = true;
            this.btn12.Click += new System.EventHandler(this.btn12_Click);
            // 
            // btn11
            // 
            this.btn11.Location = new System.Drawing.Point(94, 198);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(85, 53);
            this.btn11.TabIndex = 11;
            this.btn11.Text = "0\r\nSPACE";
            this.btn11.UseVisualStyleBackColor = true;
            this.btn11.Click += new System.EventHandler(this.btn11_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(185, 3);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(84, 58);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "3\r\ndef";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn10
            // 
            this.btn10.Location = new System.Drawing.Point(3, 198);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(85, 53);
            this.btn10.TabIndex = 10;
            this.btn10.Text = "*";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // bt4
            // 
            this.bt4.Location = new System.Drawing.Point(3, 67);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(85, 60);
            this.bt4.TabIndex = 3;
            this.bt4.Text = "4\r\nghi";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.bt4_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(185, 133);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(84, 59);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9\r\nwxyz";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(94, 67);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(85, 60);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5\r\njkl";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(94, 133);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(85, 59);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8\r\ntuv";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(185, 67);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(84, 60);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6\r\nmno";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(3, 133);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(85, 59);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7\r\npqrs";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(94, 3);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(85, 58);
            this.btn2.TabIndex = 13;
            this.btn2.Text = "2\r\nabc";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // lbldisplay
            // 
            this.lbldisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbldisplay.Location = new System.Drawing.Point(942, 114);
            this.lbldisplay.Name = "lbldisplay";
            this.lbldisplay.Size = new System.Drawing.Size(328, 219);
            this.lbldisplay.TabIndex = 1;
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.Fuchsia;
            this.lblTimer.Location = new System.Drawing.Point(938, 388);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(332, 139);
            this.lblTimer.TabIndex = 2;
            // 
            // Formpadtest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 640);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lbldisplay);
            this.Controls.Add(this.panel1);
            this.Name = "Formpadtest";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbldisplay;
        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Timer tmr2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button btn2;
    }
}

