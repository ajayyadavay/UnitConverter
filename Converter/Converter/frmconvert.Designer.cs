namespace WindowsFormsApp1
{
    partial class converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(converter));
            this.sidepanel = new System.Windows.Forms.Panel();
            this.btnconvert = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnabout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnexit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btntemperature = new System.Windows.Forms.Button();
            this.btnvolume = new System.Windows.Forms.Button();
            this.btnarea = new System.Windows.Forms.Button();
            this.btnlength = new System.Windows.Forms.Button();
            this.sideheadpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.mainheadpanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblcaption = new System.Windows.Forms.Label();
            this.comboboxfrom = new System.Windows.Forms.ComboBox();
            this.comboboxto = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxfrom = new System.Windows.Forms.TextBox();
            this.textBoxto = new System.Windows.Forms.TextBox();
            this.toolTipminimize = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipclose = new System.Windows.Forms.ToolTip(this.components);
            this.sidepanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.sideheadpanel.SuspendLayout();
            this.mainheadpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sidepanel
            // 
            this.sidepanel.BackColor = System.Drawing.Color.Black;
            this.sidepanel.Controls.Add(this.btnconvert);
            this.sidepanel.Controls.Add(this.panel3);
            this.sidepanel.Controls.Add(this.panel1);
            this.sidepanel.Controls.Add(this.btntemperature);
            this.sidepanel.Controls.Add(this.btnvolume);
            this.sidepanel.Controls.Add(this.btnarea);
            this.sidepanel.Controls.Add(this.btnlength);
            this.sidepanel.Controls.Add(this.sideheadpanel);
            this.sidepanel.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.sidepanel, "sidepanel");
            this.sidepanel.Name = "sidepanel";
            // 
            // btnconvert
            // 
            this.btnconvert.BackColor = System.Drawing.Color.Black;
            this.btnconvert.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnconvert.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnconvert.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnconvert.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btnconvert, "btnconvert");
            this.btnconvert.ForeColor = System.Drawing.Color.White;
            this.btnconvert.Name = "btnconvert";
            this.btnconvert.UseVisualStyleBackColor = false;
            this.btnconvert.Click += new System.EventHandler(this.btnconvert_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnabout);
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // btnabout
            // 
            this.btnabout.BackColor = System.Drawing.Color.Black;
            this.btnabout.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnabout.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnabout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnabout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btnabout, "btnabout");
            this.btnabout.ForeColor = System.Drawing.Color.White;
            this.btnabout.Name = "btnabout";
            this.btnabout.UseVisualStyleBackColor = false;
            this.btnabout.Click += new System.EventHandler(this.btnabout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnexit);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Black;
            this.btnexit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnexit.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnexit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnexit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btnexit, "btnexit");
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Name = "btnexit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // btntemperature
            // 
            this.btntemperature.BackColor = System.Drawing.Color.Black;
            this.btntemperature.Cursor = System.Windows.Forms.Cursors.Default;
            this.btntemperature.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btntemperature.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSalmon;
            this.btntemperature.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btntemperature, "btntemperature");
            this.btntemperature.ForeColor = System.Drawing.Color.White;
            this.btntemperature.Name = "btntemperature";
            this.btntemperature.UseVisualStyleBackColor = false;
            this.btntemperature.Click += new System.EventHandler(this.btntemperature_Click);
            // 
            // btnvolume
            // 
            this.btnvolume.BackColor = System.Drawing.Color.Black;
            this.btnvolume.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnvolume.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnvolume.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnvolume.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btnvolume, "btnvolume");
            this.btnvolume.ForeColor = System.Drawing.Color.White;
            this.btnvolume.Name = "btnvolume";
            this.btnvolume.UseVisualStyleBackColor = false;
            this.btnvolume.Click += new System.EventHandler(this.btnvolume_Click);
            // 
            // btnarea
            // 
            this.btnarea.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnarea.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnarea.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnarea.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btnarea, "btnarea");
            this.btnarea.ForeColor = System.Drawing.Color.White;
            this.btnarea.Name = "btnarea";
            this.btnarea.UseVisualStyleBackColor = true;
            this.btnarea.Click += new System.EventHandler(this.btnarea_Click);
            // 
            // btnlength
            // 
            this.btnlength.BackColor = System.Drawing.Color.Black;
            this.btnlength.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnlength.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnlength.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.btnlength.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.btnlength, "btnlength");
            this.btnlength.ForeColor = System.Drawing.Color.White;
            this.btnlength.Name = "btnlength";
            this.btnlength.UseVisualStyleBackColor = false;
            this.btnlength.Click += new System.EventHandler(this.btnlength_Click);
            // 
            // sideheadpanel
            // 
            this.sideheadpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.sideheadpanel.Controls.Add(this.label1);
            resources.ApplyResources(this.sideheadpanel, "sideheadpanel");
            this.sideheadpanel.Name = "sideheadpanel";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Name = "label1";
            // 
            // mainheadpanel
            // 
            this.mainheadpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.mainheadpanel.Controls.Add(this.pictureBox2);
            this.mainheadpanel.Controls.Add(this.pictureBox1);
            this.mainheadpanel.Controls.Add(this.lblcaption);
            resources.ApplyResources(this.mainheadpanel, "mainheadpanel");
            this.mainheadpanel.Name = "mainheadpanel";
            this.mainheadpanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainheadpanel_MouseDown);
            this.mainheadpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainheadpanel_MouseMove);
            this.mainheadpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainheadpanel_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApp1.Properties.Resources._017391_black_inlay_crystal_clear_bubble_icon_symbols_shapes_minimize;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "";
            this.toolTipminimize.SetToolTip(this.pictureBox2, resources.GetString("pictureBox2.ToolTip"));
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.exit;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Close";
            this.toolTipclose.SetToolTip(this.pictureBox1, resources.GetString("pictureBox1.ToolTip"));
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblcaption
            // 
            resources.ApplyResources(this.lblcaption, "lblcaption");
            this.lblcaption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblcaption.Name = "lblcaption";
            // 
            // comboboxfrom
            // 
            this.comboboxfrom.BackColor = System.Drawing.Color.White;
            this.comboboxfrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboboxfrom, "comboboxfrom");
            this.comboboxfrom.ForeColor = System.Drawing.Color.Blue;
            this.comboboxfrom.FormattingEnabled = true;
            this.comboboxfrom.Name = "comboboxfrom";
            this.comboboxfrom.Sorted = true;
            // 
            // comboboxto
            // 
            this.comboboxto.BackColor = System.Drawing.Color.White;
            this.comboboxto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.comboboxto, "comboboxto");
            this.comboboxto.ForeColor = System.Drawing.Color.Red;
            this.comboboxto.FormattingEnabled = true;
            this.comboboxto.Name = "comboboxto";
            this.comboboxto.Sorted = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Name = "label5";
            // 
            // textBoxfrom
            // 
            this.textBoxfrom.BackColor = System.Drawing.Color.White;
            this.textBoxfrom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxfrom, "textBoxfrom");
            this.textBoxfrom.ForeColor = System.Drawing.Color.Blue;
            this.textBoxfrom.Name = "textBoxfrom";
            this.textBoxfrom.TextChanged += new System.EventHandler(this.textBoxfrom_TextChanged);
            // 
            // textBoxto
            // 
            this.textBoxto.BackColor = System.Drawing.Color.White;
            this.textBoxto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.textBoxto, "textBoxto");
            this.textBoxto.ForeColor = System.Drawing.Color.Red;
            this.textBoxto.Name = "textBoxto";
            // 
            // converter
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.textBoxto);
            this.Controls.Add(this.textBoxfrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboboxto);
            this.Controls.Add(this.comboboxfrom);
            this.Controls.Add(this.mainheadpanel);
            this.Controls.Add(this.sidepanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "converter";
            this.sidepanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.sideheadpanel.ResumeLayout(false);
            this.sideheadpanel.PerformLayout();
            this.mainheadpanel.ResumeLayout(false);
            this.mainheadpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sidepanel;
        private System.Windows.Forms.Panel sideheadpanel;
        private System.Windows.Forms.Panel mainheadpanel;
        private System.Windows.Forms.Button btnlength;
        private System.Windows.Forms.Button btnarea;
        private System.Windows.Forms.Button btntemperature;
        private System.Windows.Forms.Button btnvolume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblcaption;
        private System.Windows.Forms.ComboBox comboboxfrom;
        private System.Windows.Forms.ComboBox comboboxto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnabout;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox textBoxfrom;
        private System.Windows.Forms.TextBox textBoxto;
        private System.Windows.Forms.Button btnconvert;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTipminimize;
        private System.Windows.Forms.ToolTip toolTipclose;
    }
}

