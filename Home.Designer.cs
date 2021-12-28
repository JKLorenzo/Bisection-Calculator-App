namespace Bisection_Calculator
{
    partial class Home
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
            this.txt_equation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ea = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.lv_fxLimits = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.num_places = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.num_range = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lv_pBrackets = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_iBracket = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_root = new System.Windows.Forms.TextBox();
            this.lv_result = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.num_places)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_range)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_equation
            // 
            this.txt_equation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_equation.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_equation.Location = new System.Drawing.Point(98, 19);
            this.txt_equation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_equation.Name = "txt_equation";
            this.txt_equation.Size = new System.Drawing.Size(409, 26);
            this.txt_equation.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Equation:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ea:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_ea
            // 
            this.txt_ea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ea.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_ea.Location = new System.Drawing.Point(98, 49);
            this.txt_ea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ea.Name = "txt_ea";
            this.txt_ea.Size = new System.Drawing.Size(164, 26);
            this.txt_ea.TabIndex = 3;
            // 
            // btn_calculate
            // 
            this.btn_calculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_calculate.Location = new System.Drawing.Point(514, 19);
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.Size = new System.Drawing.Size(95, 56);
            this.btn_calculate.TabIndex = 4;
            this.btn_calculate.Text = "Calculate";
            this.btn_calculate.UseVisualStyleBackColor = true;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // lv_fxLimits
            // 
            this.lv_fxLimits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_fxLimits.GridLines = true;
            this.lv_fxLimits.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lv_fxLimits.HideSelection = false;
            this.lv_fxLimits.Location = new System.Drawing.Point(6, 25);
            this.lv_fxLimits.Name = "lv_fxLimits";
            this.lv_fxLimits.Size = new System.Drawing.Size(584, 98);
            this.lv_fxLimits.TabIndex = 5;
            this.lv_fxLimits.UseCompatibleStateImageBehavior = false;
            this.lv_fxLimits.View = System.Windows.Forms.View.Details;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(270, 49);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Places:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // num_places
            // 
            this.num_places.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_places.Location = new System.Drawing.Point(337, 49);
            this.num_places.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.num_places.Name = "num_places";
            this.num_places.Size = new System.Drawing.Size(42, 26);
            this.num_places.TabIndex = 7;
            this.num_places.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_places.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(386, 49);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 26);
            this.label4.TabIndex = 8;
            this.label4.Text = "Range:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // num_range
            // 
            this.num_range.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.num_range.Location = new System.Drawing.Point(465, 49);
            this.num_range.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.num_range.Name = "num_range";
            this.num_range.Size = new System.Drawing.Size(42, 26);
            this.num_range.TabIndex = 9;
            this.num_range.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_range.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lv_fxLimits);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(597, 129);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function Limits";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lv_pBrackets);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cb_iBracket);
            this.groupBox2.Location = new System.Drawing.Point(12, 232);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(597, 75);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bracket";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(190, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Possible:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lv_pBrackets
            // 
            this.lv_pBrackets.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.lv_pBrackets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_pBrackets.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lv_pBrackets.HideSelection = false;
            this.lv_pBrackets.Location = new System.Drawing.Point(290, 22);
            this.lv_pBrackets.Name = "lv_pBrackets";
            this.lv_pBrackets.ShowGroups = false;
            this.lv_pBrackets.Size = new System.Drawing.Size(301, 44);
            this.lv_pBrackets.TabIndex = 12;
            this.lv_pBrackets.TileSize = new System.Drawing.Size(10, 10);
            this.lv_pBrackets.UseCompatibleStateImageBehavior = false;
            this.lv_pBrackets.View = System.Windows.Forms.View.List;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Initial:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_iBracket
            // 
            this.cb_iBracket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_iBracket.FormattingEnabled = true;
            this.cb_iBracket.Location = new System.Drawing.Point(86, 31);
            this.cb_iBracket.Name = "cb_iBracket";
            this.cb_iBracket.Size = new System.Drawing.Size(97, 28);
            this.cb_iBracket.TabIndex = 0;
            this.cb_iBracket.SelectedIndexChanged += new System.EventHandler(this.cb_iBracket_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tb_root);
            this.groupBox3.Controls.Add(this.lv_result);
            this.groupBox3.Location = new System.Drawing.Point(12, 313);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(597, 354);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(5, 316);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(441, 26);
            this.label7.TabIndex = 14;
            this.label7.Text = "Root of Function:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_root
            // 
            this.tb_root.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_root.Location = new System.Drawing.Point(453, 316);
            this.tb_root.Name = "tb_root";
            this.tb_root.ReadOnly = true;
            this.tb_root.Size = new System.Drawing.Size(137, 26);
            this.tb_root.TabIndex = 1;
            this.tb_root.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lv_result
            // 
            this.lv_result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_result.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_result.HideSelection = false;
            this.lv_result.Location = new System.Drawing.Point(6, 26);
            this.lv_result.Name = "lv_result";
            this.lv_result.Size = new System.Drawing.Size(584, 284);
            this.lv_result.TabIndex = 0;
            this.lv_result.UseCompatibleStateImageBehavior = false;
            this.lv_result.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Iteration";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "x0";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "x1";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "x2";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "fx2";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Ea";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 100;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 676);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.num_range);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.num_places);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_calculate);
            this.Controls.Add(this.txt_ea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_equation);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Home";
            this.Text = "Bisection Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.num_places)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_range)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_equation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ea;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.ListView lv_fxLimits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown num_places;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num_range;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView lv_pBrackets;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_iBracket;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lv_result;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_root;
    }
}

