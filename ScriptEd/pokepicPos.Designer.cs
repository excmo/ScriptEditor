namespace ScriptEd
{
    partial class pokepicPos
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.screenBg = new System.Windows.Forms.Panel();
            this.pokePic = new System.Windows.Forms.PictureBox();
            this.showTextBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.accept_bt = new System.Windows.Forms.Button();
            this.cancel_bt = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.hex_y = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showBox = new System.Windows.Forms.CheckBox();
            this.x_var = new System.Windows.Forms.NumericUpDown();
            this.y_var = new System.Windows.Forms.NumericUpDown();
            this.hex_x = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.screenBg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pokePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTextBox)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x_var)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_var)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.screenBg, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 319);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // screenBg
            // 
            this.screenBg.AllowDrop = true;
            this.screenBg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.screenBg.BackgroundImage = global::ScriptEd.Properties.Resources.bg_fr;
            this.screenBg.Controls.Add(this.pokePic);
            this.screenBg.Controls.Add(this.showTextBox);
            this.screenBg.Location = new System.Drawing.Point(22, 15);
            this.screenBg.Name = "screenBg";
            this.screenBg.Size = new System.Drawing.Size(240, 160);
            this.screenBg.TabIndex = 0;
            // 
            // pokePic
            // 
            this.pokePic.BackColor = System.Drawing.Color.Transparent;
            this.pokePic.Image = global::ScriptEd.Properties.Resources.pokepic;
            this.pokePic.Location = new System.Drawing.Point(80, 24);
            this.pokePic.Name = "pokePic";
            this.pokePic.Size = new System.Drawing.Size(80, 80);
            this.pokePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pokePic.TabIndex = 0;
            this.pokePic.TabStop = false;
            // 
            // showTextBox
            // 
            this.showTextBox.BackColor = System.Drawing.Color.Transparent;
            this.showTextBox.Image = global::ScriptEd.Properties.Resources.textbox;
            this.showTextBox.Location = new System.Drawing.Point(0, 0);
            this.showTextBox.Name = "showTextBox";
            this.showTextBox.Size = new System.Drawing.Size(240, 160);
            this.showTextBox.TabIndex = 1;
            this.showTextBox.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.accept_bt, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cancel_bt, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 289);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(278, 27);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // accept_bt
            // 
            this.accept_bt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accept_bt.Location = new System.Drawing.Point(61, 3);
            this.accept_bt.Name = "accept_bt";
            this.accept_bt.Size = new System.Drawing.Size(75, 21);
            this.accept_bt.TabIndex = 0;
            this.accept_bt.Text = "Accept";
            this.accept_bt.UseVisualStyleBackColor = true;
            this.accept_bt.Click += new System.EventHandler(this.getPos);
            // 
            // cancel_bt
            // 
            this.cancel_bt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_bt.Location = new System.Drawing.Point(142, 3);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(75, 21);
            this.cancel_bt.TabIndex = 1;
            this.cancel_bt.Text = "Cancel";
            this.cancel_bt.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.65592F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.92114F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.42294F));
            this.tableLayoutPanel3.Controls.Add(this.hex_y, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.showBox, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.x_var, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.y_var, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.hex_x, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 194);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(278, 89);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // hex_y
            // 
            this.hex_y.AutoSize = true;
            this.hex_y.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hex_y.Location = new System.Drawing.Point(117, 25);
            this.hex_y.Name = "hex_y";
            this.hex_y.Size = new System.Drawing.Size(158, 25);
            this.hex_y.TabIndex = 6;
            this.hex_y.Text = "(03)";
            this.hex_y.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "X position:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y position:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // showBox
            // 
            this.showBox.AutoSize = true;
            this.showBox.Checked = true;
            this.showBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tableLayoutPanel3.SetColumnSpan(this.showBox, 2);
            this.showBox.Location = new System.Drawing.Point(3, 53);
            this.showBox.Name = "showBox";
            this.showBox.Size = new System.Drawing.Size(90, 17);
            this.showBox.TabIndex = 2;
            this.showBox.Text = "Show textbox";
            this.showBox.UseVisualStyleBackColor = true;
            this.showBox.CheckedChanged += new System.EventHandler(this.showBox_CheckedChanged);
            // 
            // x_var
            // 
            this.x_var.Location = new System.Drawing.Point(68, 3);
            this.x_var.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.x_var.Name = "x_var";
            this.x_var.Size = new System.Drawing.Size(40, 20);
            this.x_var.TabIndex = 3;
            this.x_var.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.x_var.ValueChanged += new System.EventHandler(this.xMove);
            // 
            // y_var
            // 
            this.y_var.Location = new System.Drawing.Point(68, 28);
            this.y_var.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.y_var.Name = "y_var";
            this.y_var.Size = new System.Drawing.Size(40, 20);
            this.y_var.TabIndex = 4;
            this.y_var.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.y_var.ValueChanged += new System.EventHandler(this.xMove);
            // 
            // hex_x
            // 
            this.hex_x.AutoSize = true;
            this.hex_x.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hex_x.Location = new System.Drawing.Point(117, 0);
            this.hex_x.Name = "hex_x";
            this.hex_x.Size = new System.Drawing.Size(158, 25);
            this.hex_x.TabIndex = 5;
            this.hex_x.Text = "(0A)";
            this.hex_x.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pokepicPos
            // 
            this.AcceptButton = this.accept_bt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancel_bt;
            this.ClientSize = new System.Drawing.Size(284, 319);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "pokepicPos";
            this.Text = "Set picture position";
            this.Load += new System.EventHandler(this.initPos);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.screenBg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pokePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showTextBox)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.x_var)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_var)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel screenBg;
        private System.Windows.Forms.PictureBox showTextBox;
        private System.Windows.Forms.PictureBox pokePic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button accept_bt;
        private System.Windows.Forms.Button cancel_bt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label hex_y;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox showBox;
        private System.Windows.Forms.NumericUpDown x_var;
        private System.Windows.Forms.NumericUpDown y_var;
        private System.Windows.Forms.Label hex_x;
    }
}