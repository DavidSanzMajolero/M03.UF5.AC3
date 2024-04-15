namespace M03.UF5.AC3
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
            groupBox1 = new GroupBox();
            totalBox = new TextBox();
            consumBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            domesticBox = new TextBox();
            activitatsBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            poblacioBox = new TextBox();
            comarcaBox = new ComboBox();
            anyBox = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            netejar = new Button();
            guardar = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(totalBox);
            groupBox1.Controls.Add(consumBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(domesticBox);
            groupBox1.Controls.Add(activitatsBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(poblacioBox);
            groupBox1.Controls.Add(comarcaBox);
            groupBox1.Controls.Add(anyBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(559, 185);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Gestió de dades demogràfiques de gestió";
            // 
            // totalBox
            // 
            totalBox.Location = new Point(416, 137);
            totalBox.Name = "totalBox";
            totalBox.Size = new Size(119, 23);
            totalBox.TabIndex = 13;
            // 
            // consumBox
            // 
            consumBox.Location = new Point(416, 93);
            consumBox.Name = "consumBox";
            consumBox.Size = new Size(119, 23);
            consumBox.TabIndex = 12;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(300, 137);
            label7.Name = "label7";
            label7.Size = new Size(110, 38);
            label7.TabIndex = 11;
            label7.Text = "Total";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(300, 93);
            label6.Name = "label6";
            label6.Size = new Size(110, 38);
            label6.TabIndex = 10;
            label6.Text = "Consum domèstic per capità";
            // 
            // domesticBox
            // 
            domesticBox.Location = new Point(15, 134);
            domesticBox.Name = "domesticBox";
            domesticBox.Size = new Size(100, 23);
            domesticBox.TabIndex = 9;
            // 
            // activitatsBox
            // 
            activitatsBox.Location = new Point(131, 134);
            activitatsBox.Name = "activitatsBox";
            activitatsBox.Size = new Size(100, 23);
            activitatsBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(131, 93);
            label5.Name = "label5";
            label5.Size = new Size(154, 38);
            label5.TabIndex = 7;
            label5.Text = "Activitats econòmiques i fonts pròpies";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(15, 102);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 6;
            label4.Text = "Domèstic xarxa";
            // 
            // poblacioBox
            // 
            poblacioBox.Location = new Point(232, 48);
            poblacioBox.Name = "poblacioBox";
            poblacioBox.Size = new Size(100, 23);
            poblacioBox.TabIndex = 5;
            // 
            // comarcaBox
            // 
            comarcaBox.FormattingEnabled = true;
            comarcaBox.Location = new Point(111, 48);
            comarcaBox.Name = "comarcaBox";
            comarcaBox.Size = new Size(103, 23);
            comarcaBox.TabIndex = 4;
            // 
            // anyBox
            // 
            anyBox.FormattingEnabled = true;
            anyBox.Items.AddRange(new object[] { "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036", "2037", "2038", "2039", "2040", "2041", "2042", "2043", "2044", "2045", "2046", "2047", "2048", "2049", "2050" });
            anyBox.Location = new Point(15, 48);
            anyBox.Name = "anyBox";
            anyBox.Size = new Size(71, 23);
            anyBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(232, 30);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Població";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(111, 30);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Comarca";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(15, 30);
            label1.Name = "label1";
            label1.Size = new Size(28, 15);
            label1.TabIndex = 0;
            label1.Text = "Any";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlLight;
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(595, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(364, 185);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Estadístiques";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(21, 134);
            label11.Name = "label11";
            label11.Size = new Size(218, 15);
            label11.TabIndex = 17;
            label11.Text = "Consum domèstic per capità més baix:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(30, 101);
            label10.Name = "label10";
            label10.Size = new Size(209, 15);
            label10.TabIndex = 16;
            label10.Text = "Consum domèstic per capità més alt:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(100, 66);
            label9.Name = "label9";
            label9.Size = new Size(139, 15);
            label9.TabIndex = 15;
            label9.Text = "Consum domèstic mitjà:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(108, 30);
            label8.Name = "label8";
            label8.Size = new Size(131, 15);
            label8.TabIndex = 14;
            label8.Text = "Població > 20.000 hab:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Blue;
            label12.Location = new Point(301, 30);
            label12.Name = "label12";
            label12.Size = new Size(27, 15);
            label12.TabIndex = 18;
            label12.Text = "----";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Blue;
            label13.Location = new Point(290, 66);
            label13.Name = "label13";
            label13.Size = new Size(38, 15);
            label13.TabIndex = 19;
            label13.Text = "00,00";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Blue;
            label14.Location = new Point(301, 102);
            label14.Name = "label14";
            label14.Size = new Size(27, 15);
            label14.TabIndex = 20;
            label14.Text = "----";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Blue;
            label15.Location = new Point(301, 140);
            label15.Name = "label15";
            label15.Size = new Size(27, 15);
            label15.TabIndex = 21;
            label15.Text = "----";
            // 
            // netejar
            // 
            netejar.Location = new Point(392, 203);
            netejar.Name = "netejar";
            netejar.Size = new Size(85, 23);
            netejar.TabIndex = 15;
            netejar.Text = "Netejar";
            netejar.UseVisualStyleBackColor = true;
            // 
            // guardar
            // 
            guardar.Location = new Point(483, 203);
            guardar.Name = "guardar";
            guardar.Size = new Size(88, 23);
            guardar.TabIndex = 16;
            guardar.Text = "Guardar";
            guardar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 450);
            Controls.Add(guardar);
            Controls.Add(netejar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox poblacioBox;
        private ComboBox comarcaBox;
        private ComboBox anyBox;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label4;
        private TextBox totalBox;
        private TextBox consumBox;
        private Label label7;
        private Label label6;
        private TextBox domesticBox;
        private TextBox activitatsBox;
        private GroupBox groupBox2;
        private Label label9;
        private Label label8;
        private Label label11;
        private Label label10;
        private Label label12;
        private Label label15;
        private Label label14;
        private Label label13;
        private Button netejar;
        private Button guardar;
    }
}
