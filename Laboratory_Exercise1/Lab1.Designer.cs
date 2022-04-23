namespace Laboratory_Exercise1
{
    partial class Lab1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.part_desc = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.qty_stock = new System.Windows.Forms.TextBox();
            this.brake_parts = new System.Windows.Forms.Button();
            this.wiper_blades = new System.Windows.Forms.Button();
            this.oil_filters = new System.Windows.Forms.Button();
            this.exitt = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(477, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Our Parts are Cheap!!!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Part Description:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(366, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // part_desc
            // 
            this.part_desc.Location = new System.Drawing.Point(482, 232);
            this.part_desc.Name = "part_desc";
            this.part_desc.ReadOnly = true;
            this.part_desc.Size = new System.Drawing.Size(393, 20);
            this.part_desc.TabIndex = 3;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(482, 280);
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Size = new System.Drawing.Size(135, 20);
            this.price.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(632, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantity in Stock:";
            // 
            // qty_stock
            // 
            this.qty_stock.Location = new System.Drawing.Point(740, 280);
            this.qty_stock.Name = "qty_stock";
            this.qty_stock.Size = new System.Drawing.Size(135, 20);
            this.qty_stock.TabIndex = 6;
            // 
            // brake_parts
            // 
            this.brake_parts.Location = new System.Drawing.Point(489, 355);
            this.brake_parts.Name = "brake_parts";
            this.brake_parts.Size = new System.Drawing.Size(117, 50);
            this.brake_parts.TabIndex = 7;
            this.brake_parts.Text = "Brake Parts";
            this.brake_parts.UseVisualStyleBackColor = true;
            this.brake_parts.Click += new System.EventHandler(this.button1_Click);
            // 
            // wiper_blades
            // 
            this.wiper_blades.Location = new System.Drawing.Point(616, 355);
            this.wiper_blades.Name = "wiper_blades";
            this.wiper_blades.Size = new System.Drawing.Size(117, 50);
            this.wiper_blades.TabIndex = 8;
            this.wiper_blades.Text = "Wiper Blades";
            this.wiper_blades.UseVisualStyleBackColor = true;
            this.wiper_blades.Click += new System.EventHandler(this.button2_Click);
            // 
            // oil_filters
            // 
            this.oil_filters.Location = new System.Drawing.Point(740, 355);
            this.oil_filters.Name = "oil_filters";
            this.oil_filters.Size = new System.Drawing.Size(117, 50);
            this.oil_filters.TabIndex = 9;
            this.oil_filters.Text = "Oil Filters";
            this.oil_filters.UseVisualStyleBackColor = true;
            this.oil_filters.Click += new System.EventHandler(this.button3_Click);
            // 
            // exitt
            // 
            this.exitt.Location = new System.Drawing.Point(740, 411);
            this.exitt.Name = "exitt";
            this.exitt.Size = new System.Drawing.Size(117, 50);
            this.exitt.TabIndex = 12;
            this.exitt.Text = "Exit";
            this.exitt.UseVisualStyleBackColor = true;
            this.exitt.Click += new System.EventHandler(this.button4_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(616, 411);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(117, 50);
            this.reset.TabIndex = 11;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.button5_Click);
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(489, 411);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(117, 50);
            this.print.TabIndex = 10;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.print_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(366, 502);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "by Jess Arreza";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 663);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exitt);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.print);
            this.Controls.Add(this.oil_filters);
            this.Controls.Add(this.wiper_blades);
            this.Controls.Add(this.brake_parts);
            this.Controls.Add(this.qty_stock);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.price);
            this.Controls.Add(this.part_desc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "VB University - Student Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox part_desc;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox qty_stock;
        private System.Windows.Forms.Button brake_parts;
        private System.Windows.Forms.Button wiper_blades;
        private System.Windows.Forms.Button oil_filters;
        private System.Windows.Forms.Button exitt;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.Label label5;
    }
}

