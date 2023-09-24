namespace Lab02
{
    partial class MainForm
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
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabelNumber = new ToolStripStatusLabel();
            result = new TextBox();
            StSurname = new TextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            StSurname2 = new TextBox();
            groupBox2 = new GroupBox();
            button2 = new Button();
            TSurname = new TextBox();
            groupBox3 = new GroupBox();
            button3 = new Button();
            BusNumber = new TextBox();
            groupBox4 = new GroupBox();
            button4 = new Button();
            GradeTB = new TextBox();
            groupBox5 = new GroupBox();
            button5 = new Button();
            groupBox6 = new GroupBox();
            button6 = new Button();
            this.classroomTBTeach = new TextBox();
            groupBox7 = new GroupBox();
            button7 = new Button();
            gradeTBTeach = new TextBox();
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(926, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(46, 24);
            файлToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            loadToolStripMenuItem.Size = new Size(178, 26);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += fileToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabelNumber });
            statusStrip1.Location = new Point(0, 587);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(926, 26);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(86, 20);
            toolStripStatusLabel1.Text = "Time count:";
            // 
            // toolStripStatusLabelNumber
            // 
            toolStripStatusLabelNumber.Name = "toolStripStatusLabelNumber";
            toolStripStatusLabelNumber.Size = new Size(39, 20);
            toolStripStatusLabelNumber.Text = "time";
            // 
            // result
            // 
            result.Anchor = AnchorStyles.None;
            result.Location = new Point(436, 43);
            result.Margin = new Padding(3, 4, 3, 4);
            result.Multiline = true;
            result.Name = "result";
            result.ScrollBars = ScrollBars.Vertical;
            result.Size = new Size(456, 526);
            result.TabIndex = 3;
            // 
            // StSurname
            // 
            StSurname.Cursor = Cursors.IBeam;
            StSurname.Location = new Point(16, 26);
            StSurname.Name = "StSurname";
            StSurname.PlaceholderText = " Student's Surname";
            StSurname.Size = new Size(222, 27);
            StSurname.TabIndex = 5;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Lavender;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(StSurname);
            groupBox1.Location = new Point(12, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(395, 70);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task 1 (Get student's teachers)";
            // 
            // button1
            // 
            button1.BackColor = Color.AliceBlue;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(266, 26);
            button1.Name = "button1";
            button1.Size = new Size(101, 27);
            button1.TabIndex = 6;
            button1.Text = "Find";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // StSurname2
            // 
            StSurname2.Cursor = Cursors.IBeam;
            StSurname2.Location = new Point(16, 26);
            StSurname2.Name = "StSurname2";
            StSurname2.PlaceholderText = " Student's Surname";
            StSurname2.Size = new Size(222, 27);
            StSurname2.TabIndex = 5;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.AliceBlue;
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(StSurname2);
            groupBox2.Location = new Point(12, 119);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(395, 70);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Task 2 (Find bus by student)";
            // 
            // button2
            // 
            button2.BackColor = Color.Lavender;
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(266, 26);
            button2.Name = "button2";
            button2.Size = new Size(101, 27);
            button2.TabIndex = 7;
            button2.Text = "Find";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // TSurname
            // 
            TSurname.Cursor = Cursors.IBeam;
            TSurname.Location = new Point(16, 26);
            TSurname.Name = "TSurname";
            TSurname.PlaceholderText = " Teacher's Surname";
            TSurname.Size = new Size(222, 27);
            TSurname.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Lavender;
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(TSurname);
            groupBox3.Location = new Point(12, 195);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(395, 70);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Task 3 (Get teachers student list)";
            // 
            // button3
            // 
            button3.BackColor = Color.AliceBlue;
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(266, 26);
            button3.Name = "button3";
            button3.Size = new Size(101, 27);
            button3.TabIndex = 8;
            button3.Text = "Find";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // BusNumber
            // 
            BusNumber.Cursor = Cursors.IBeam;
            BusNumber.Location = new Point(16, 26);
            BusNumber.Name = "BusNumber";
            BusNumber.PlaceholderText = " Bus number";
            BusNumber.Size = new Size(222, 27);
            BusNumber.TabIndex = 5;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.AliceBlue;
            groupBox4.Controls.Add(button4);
            groupBox4.Controls.Add(BusNumber);
            groupBox4.Location = new Point(12, 271);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(395, 70);
            groupBox4.TabIndex = 8;
            groupBox4.TabStop = false;
            groupBox4.Text = "Task 4 (Find students by their bus)";
            // 
            // button4
            // 
            button4.BackColor = Color.Lavender;
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(266, 26);
            button4.Name = "button4";
            button4.Size = new Size(101, 27);
            button4.TabIndex = 10;
            button4.Text = "Find";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // GradeTB
            // 
            GradeTB.Cursor = Cursors.IBeam;
            GradeTB.Location = new Point(16, 26);
            GradeTB.Name = "GradeTB";
            GradeTB.PlaceholderText = " Grade";
            GradeTB.Size = new Size(222, 27);
            GradeTB.TabIndex = 5;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Lavender;
            groupBox5.Controls.Add(button5);
            groupBox5.Controls.Add(GradeTB);
            groupBox5.Location = new Point(12, 347);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(395, 70);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Task 5 (Find students by grade)";
            // 
            // button5
            // 
            button5.BackColor = Color.AliceBlue;
            button5.Cursor = Cursors.Hand;
            button5.Location = new Point(266, 26);
            button5.Name = "button5";
            button5.Size = new Size(101, 27);
            button5.TabIndex = 12;
            button5.Text = "Find";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.AliceBlue;
            groupBox6.Controls.Add(button6);
            groupBox6.Controls.Add(this.classroomTBTeach);
            groupBox6.Location = new Point(12, 423);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(395, 70);
            groupBox6.TabIndex = 13;
            groupBox6.TabStop = false;
            groupBox6.Text = "Task 6 (Find teachers by classroom)";
            // 
            // button6
            // 
            button6.BackColor = Color.Lavender;
            button6.Cursor = Cursors.Hand;
            button6.Location = new Point(266, 26);
            button6.Name = "button6";
            button6.Size = new Size(101, 27);
            button6.TabIndex = 12;
            button6.Text = "Find";
            button6.UseVisualStyleBackColor = false;
            // 
            // classroomTBTeach
            // 
            this.classroomTBTeach.Cursor = Cursors.IBeam;
            this.classroomTBTeach.Location = new Point(16, 26);
            this.classroomTBTeach.Name = "classroomTBTeach";
            this.classroomTBTeach.PlaceholderText = " Classroom";
            this.classroomTBTeach.Size = new Size(222, 27);
            this.classroomTBTeach.TabIndex = 5;
            // 
            // groupBox7
            // 
            groupBox7.BackColor = Color.Lavender;
            groupBox7.Controls.Add(button7);
            groupBox7.Controls.Add(gradeTBTeach);
            groupBox7.Location = new Point(12, 499);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(395, 70);
            groupBox7.TabIndex = 14;
            groupBox7.TabStop = false;
            groupBox7.Text = "Task 7 (Find teachers by grade)";
            // 
            // button7
            // 
            button7.BackColor = Color.AliceBlue;
            button7.Cursor = Cursors.Hand;
            button7.Location = new Point(266, 26);
            button7.Name = "button7";
            button7.Size = new Size(101, 27);
            button7.TabIndex = 12;
            button7.Text = "Find";
            button7.UseVisualStyleBackColor = false;
            // 
            // gradeTBTeach
            // 
            gradeTBTeach.Cursor = Cursors.IBeam;
            gradeTBTeach.Location = new Point(16, 26);
            gradeTBTeach.Name = "gradeTBTeach";
            gradeTBTeach.PlaceholderText = " Grade";
            gradeTBTeach.Size = new Size(222, 27);
            gradeTBTeach.TabIndex = 5;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(926, 613);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(result);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabelNumber;
        private TextBox result;
        private TextBox StSurname;
        private GroupBox groupBox1;
        private TextBox StSurname2;
        private GroupBox groupBox2;
        private TextBox TSurname;
        private GroupBox groupBox3;
        private TextBox BusNumber;
        private GroupBox groupBox4;
        private TextBox GradeTB;
        private GroupBox groupBox5;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private GroupBox groupBox6;
        private TextBox textBox1;
        private GroupBox groupBox7;
        private TextBox gradeTBTeach;
        private TextBox textBox3;
        private GroupBox groupBox8;
    }

}