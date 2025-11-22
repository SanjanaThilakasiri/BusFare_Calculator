namespace WinFormsApp1
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
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtName = new TextBox();
            txtID = new TextBox();
            txtNIC = new TextBox();
            txtBusFare = new TextBox();
            txtFrom = new TextBox();
            txtTransit = new TextBox();
            txtTo = new TextBox();
            txtBusRoute = new TextBox();
            txtSeasonFare = new TextBox();
            label = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(340, 246);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(472, 246);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 342);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(942, 178);
            dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 56);
            label1.Name = "label1";
            label1.Size = new Size(119, 17);
            label1.TabIndex = 3;
            label1.Text = "Student Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 109);
            label2.Name = "label2";
            label2.Size = new Size(93, 17);
            label2.TabIndex = 3;
            label2.Text = "Student ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(55, 159);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 3;
            label3.Text = "NIC :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(55, 212);
            label4.Name = "label4";
            label4.Size = new Size(111, 17);
            label4.TabIndex = 3;
            label4.Text = "Bus Fare : Rs.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(526, 56);
            label5.Name = "label5";
            label5.Size = new Size(105, 17);
            label5.TabIndex = 3;
            label5.Text = "Travel From :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(564, 109);
            label6.Name = "label6";
            label6.Size = new Size(68, 17);
            label6.TabIndex = 3;
            label6.Text = "Transit :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(595, 159);
            label7.Name = "label7";
            label7.Size = new Size(35, 17);
            label7.TabIndex = 3;
            label7.Text = "To :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(497, 208);
            label8.Name = "label8";
            label8.Size = new Size(134, 17);
            label8.TabIndex = 3;
            label8.Text = "Bus Route No(s) :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Californian FB", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(234, 303);
            label9.Name = "label9";
            label9.Size = new Size(250, 22);
            label9.TabIndex = 3;
            label9.Text = "Your Season Ticket Fare is : Rs.";
            // 
            // txtName
            // 
            txtName.Location = new Point(180, 57);
            txtName.Name = "txtName";
            txtName.Size = new Size(260, 21);
            txtName.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.Location = new Point(180, 105);
            txtID.Name = "txtID";
            txtID.Size = new Size(260, 21);
            txtID.TabIndex = 4;
            // 
            // txtNIC
            // 
            txtNIC.Location = new Point(180, 158);
            txtNIC.Name = "txtNIC";
            txtNIC.Size = new Size(260, 21);
            txtNIC.TabIndex = 4;
            // 
            // txtBusFare
            // 
            txtBusFare.Location = new Point(180, 208);
            txtBusFare.Name = "txtBusFare";
            txtBusFare.Size = new Size(100, 21);
            txtBusFare.TabIndex = 4;
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(637, 52);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(171, 21);
            txtFrom.TabIndex = 4;
            // 
            // txtTransit
            // 
            txtTransit.Location = new Point(637, 105);
            txtTransit.Name = "txtTransit";
            txtTransit.Size = new Size(171, 21);
            txtTransit.TabIndex = 4;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(636, 155);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(170, 21);
            txtTo.TabIndex = 4;
            txtTo.TextChanged += txtTo_TextChanged;
            // 
            // txtBusRoute
            // 
            txtBusRoute.Location = new Point(637, 207);
            txtBusRoute.Name = "txtBusRoute";
            txtBusRoute.Size = new Size(169, 21);
            txtBusRoute.TabIndex = 4;
            txtBusRoute.TextChanged += textBox8_TextChanged;
            // 
            // txtSeasonFare
            // 
            txtSeasonFare.Location = new Point(490, 304);
            txtSeasonFare.Name = "txtSeasonFare";
            txtSeasonFare.Size = new Size(113, 21);
            txtSeasonFare.TabIndex = 4;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Bodoni MT", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label.Location = new Point(234, 9);
            label.Name = "label";
            label.Size = new Size(473, 32);
            label.TabIndex = 5;
            label.Text = "Application Form For Bus Season Ticket ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(625, 248);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(267, 21);
            dateTimePicker1.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 520);
            Controls.Add(dateTimePicker1);
            Controls.Add(label);
            Controls.Add(txtBusRoute);
            Controls.Add(txtSeasonFare);
            Controls.Add(txtBusFare);
            Controls.Add(txtTo);
            Controls.Add(txtNIC);
            Controls.Add(txtTransit);
            Controls.Add(txtFrom);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximumSize = new Size(962, 559);
            MinimumSize = new Size(962, 559);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtName;
        private TextBox txtID;
        private TextBox txtNIC;
        private TextBox txtBusFare;
        private TextBox txtFrom;
        private TextBox txtTransit;
        private TextBox txtTo;
        private TextBox txtBusRoute;
        private TextBox txtSeasonFare;
        private Label label;
        private DateTimePicker dateTimePicker1;
    }
}
