
namespace worpadkiller
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
            this.fntlbl = new System.Windows.Forms.Label();
            this.sizelbl = new System.Windows.Forms.Label();
            this.fontstylelbl = new System.Windows.Forms.Label();
            this.alignmentlbl = new System.Windows.Forms.Label();
            this.colorlbl = new System.Windows.Forms.Label();
            this.loadnameinput = new System.Windows.Forms.TextBox();
            this.fontinput = new System.Windows.Forms.ComboBox();
            this.sizeinput = new System.Windows.Forms.ComboBox();
            this.boldbtn = new System.Windows.Forms.Button();
            this.underlinebtn = new System.Windows.Forms.Button();
            this.italicbtn = new System.Windows.Forms.Button();
            this.rightbtn = new System.Windows.Forms.Button();
            this.centerbtn = new System.Windows.Forms.Button();
            this.leftbtn = new System.Windows.Forms.Button();
            this.colorinput = new System.Windows.Forms.ComboBox();
            this.loadbtn = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.savenameinput = new System.Windows.Forms.TextBox();
            this.maininput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // fntlbl
            // 
            this.fntlbl.AutoSize = true;
            this.fntlbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fntlbl.Location = new System.Drawing.Point(40, 9);
            this.fntlbl.Name = "fntlbl";
            this.fntlbl.Size = new System.Drawing.Size(44, 23);
            this.fntlbl.TabIndex = 0;
            this.fntlbl.Text = "Font";
            // 
            // sizelbl
            // 
            this.sizelbl.AutoSize = true;
            this.sizelbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizelbl.Location = new System.Drawing.Point(135, 9);
            this.sizelbl.Name = "sizelbl";
            this.sizelbl.Size = new System.Drawing.Size(43, 23);
            this.sizelbl.TabIndex = 1;
            this.sizelbl.Text = "Size";
            // 
            // fontstylelbl
            // 
            this.fontstylelbl.AutoSize = true;
            this.fontstylelbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontstylelbl.Location = new System.Drawing.Point(180, 9);
            this.fontstylelbl.Name = "fontstylelbl";
            this.fontstylelbl.Size = new System.Drawing.Size(92, 23);
            this.fontstylelbl.TabIndex = 2;
            this.fontstylelbl.Text = "Font Style";
            // 
            // alignmentlbl
            // 
            this.alignmentlbl.AutoSize = true;
            this.alignmentlbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alignmentlbl.Location = new System.Drawing.Point(278, 8);
            this.alignmentlbl.Name = "alignmentlbl";
            this.alignmentlbl.Size = new System.Drawing.Size(84, 23);
            this.alignmentlbl.TabIndex = 3;
            this.alignmentlbl.Text = "Alignment";
            // 
            // colorlbl
            // 
            this.colorlbl.AutoSize = true;
            this.colorlbl.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorlbl.Location = new System.Drawing.Point(399, 9);
            this.colorlbl.Name = "colorlbl";
            this.colorlbl.Size = new System.Drawing.Size(48, 23);
            this.colorlbl.TabIndex = 4;
            this.colorlbl.Text = "Color";
            // 
            // loadnameinput
            // 
            this.loadnameinput.Location = new System.Drawing.Point(493, 9);
            this.loadnameinput.Name = "loadnameinput";
            this.loadnameinput.Size = new System.Drawing.Size(226, 20);
            this.loadnameinput.TabIndex = 5;
            // 
            // fontinput
            // 
            this.fontinput.FormattingEnabled = true;
            this.fontinput.Items.AddRange(new object[] {
            "Arial",
            "Calibri",
            "Comic Sans MS"});
            this.fontinput.Location = new System.Drawing.Point(12, 35);
            this.fontinput.Name = "fontinput";
            this.fontinput.Size = new System.Drawing.Size(102, 21);
            this.fontinput.TabIndex = 6;
            // 
            // sizeinput
            // 
            this.sizeinput.FormattingEnabled = true;
            this.sizeinput.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "36",
            "48",
            "72"});
            this.sizeinput.Location = new System.Drawing.Point(131, 35);
            this.sizeinput.Name = "sizeinput";
            this.sizeinput.Size = new System.Drawing.Size(47, 21);
            this.sizeinput.TabIndex = 7;
            this.sizeinput.SelectedIndexChanged += new System.EventHandler(this.sizeinput_SelectedIndexChanged);
            // 
            // boldbtn
            // 
            this.boldbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boldbtn.Location = new System.Drawing.Point(188, 35);
            this.boldbtn.Name = "boldbtn";
            this.boldbtn.Size = new System.Drawing.Size(23, 23);
            this.boldbtn.TabIndex = 8;
            this.boldbtn.Text = "B";
            this.boldbtn.UseVisualStyleBackColor = true;
            this.boldbtn.Click += new System.EventHandler(this.boldbtn_Click);
            // 
            // underlinebtn
            // 
            this.underlinebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.underlinebtn.Location = new System.Drawing.Point(217, 35);
            this.underlinebtn.Name = "underlinebtn";
            this.underlinebtn.Size = new System.Drawing.Size(23, 23);
            this.underlinebtn.TabIndex = 9;
            this.underlinebtn.Text = "U";
            this.underlinebtn.UseVisualStyleBackColor = true;
            this.underlinebtn.Click += new System.EventHandler(this.underlinebtn_Click);
            // 
            // italicbtn
            // 
            this.italicbtn.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italicbtn.Location = new System.Drawing.Point(246, 35);
            this.italicbtn.Name = "italicbtn";
            this.italicbtn.Size = new System.Drawing.Size(23, 23);
            this.italicbtn.TabIndex = 10;
            this.italicbtn.Text = "I";
            this.italicbtn.UseVisualStyleBackColor = true;
            this.italicbtn.Click += new System.EventHandler(this.italicbtn_Click);
            // 
            // rightbtn
            // 
            this.rightbtn.Location = new System.Drawing.Point(342, 35);
            this.rightbtn.Name = "rightbtn";
            this.rightbtn.Size = new System.Drawing.Size(23, 23);
            this.rightbtn.TabIndex = 13;
            this.rightbtn.Text = "R";
            this.rightbtn.UseVisualStyleBackColor = true;
            this.rightbtn.Click += new System.EventHandler(this.rightbtn_Click);
            // 
            // centerbtn
            // 
            this.centerbtn.Location = new System.Drawing.Point(313, 35);
            this.centerbtn.Name = "centerbtn";
            this.centerbtn.Size = new System.Drawing.Size(23, 23);
            this.centerbtn.TabIndex = 12;
            this.centerbtn.Text = "C";
            this.centerbtn.UseVisualStyleBackColor = true;
            this.centerbtn.Click += new System.EventHandler(this.centerbtn_Click);
            // 
            // leftbtn
            // 
            this.leftbtn.Location = new System.Drawing.Point(284, 35);
            this.leftbtn.Name = "leftbtn";
            this.leftbtn.Size = new System.Drawing.Size(23, 23);
            this.leftbtn.TabIndex = 11;
            this.leftbtn.Text = "L";
            this.leftbtn.UseVisualStyleBackColor = true;
            this.leftbtn.Click += new System.EventHandler(this.leftbtn_Click);
            // 
            // colorinput
            // 
            this.colorinput.FormattingEnabled = true;
            this.colorinput.Items.AddRange(new object[] {
            "Red",
            "Black",
            "Blue",
            "Green",
            "Yellow"});
            this.colorinput.Location = new System.Drawing.Point(371, 35);
            this.colorinput.Name = "colorinput";
            this.colorinput.Size = new System.Drawing.Size(102, 21);
            this.colorinput.TabIndex = 14;
            this.colorinput.SelectedIndexChanged += new System.EventHandler(this.colorinput_SelectedIndexChanged);
            // 
            // loadbtn
            // 
            this.loadbtn.Location = new System.Drawing.Point(725, 9);
            this.loadbtn.Name = "loadbtn";
            this.loadbtn.Size = new System.Drawing.Size(63, 23);
            this.loadbtn.TabIndex = 15;
            this.loadbtn.Text = "Load";
            this.loadbtn.UseVisualStyleBackColor = true;
            this.loadbtn.Click += new System.EventHandler(this.loadbtn_Click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(725, 35);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(63, 23);
            this.savebtn.TabIndex = 17;
            this.savebtn.Text = "Save";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // savenameinput
            // 
            this.savenameinput.Location = new System.Drawing.Point(493, 35);
            this.savenameinput.Name = "savenameinput";
            this.savenameinput.Size = new System.Drawing.Size(226, 20);
            this.savenameinput.TabIndex = 16;
            // 
            // maininput
            // 
            this.maininput.Location = new System.Drawing.Point(12, 63);
            this.maininput.Multiline = true;
            this.maininput.Name = "maininput";
            this.maininput.Size = new System.Drawing.Size(776, 375);
            this.maininput.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.maininput);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.savenameinput);
            this.Controls.Add(this.loadbtn);
            this.Controls.Add(this.colorinput);
            this.Controls.Add(this.rightbtn);
            this.Controls.Add(this.centerbtn);
            this.Controls.Add(this.leftbtn);
            this.Controls.Add(this.italicbtn);
            this.Controls.Add(this.underlinebtn);
            this.Controls.Add(this.boldbtn);
            this.Controls.Add(this.sizeinput);
            this.Controls.Add(this.fontinput);
            this.Controls.Add(this.loadnameinput);
            this.Controls.Add(this.colorlbl);
            this.Controls.Add(this.alignmentlbl);
            this.Controls.Add(this.fontstylelbl);
            this.Controls.Add(this.sizelbl);
            this.Controls.Add(this.fntlbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fntlbl;
        private System.Windows.Forms.Label sizelbl;
        private System.Windows.Forms.Label fontstylelbl;
        private System.Windows.Forms.Label alignmentlbl;
        private System.Windows.Forms.Label colorlbl;
        private System.Windows.Forms.TextBox loadnameinput;
        private System.Windows.Forms.ComboBox fontinput;
        private System.Windows.Forms.ComboBox sizeinput;
        private System.Windows.Forms.Button boldbtn;
        private System.Windows.Forms.Button underlinebtn;
        private System.Windows.Forms.Button italicbtn;
        private System.Windows.Forms.Button rightbtn;
        private System.Windows.Forms.Button centerbtn;
        private System.Windows.Forms.Button leftbtn;
        private System.Windows.Forms.ComboBox colorinput;
        private System.Windows.Forms.Button loadbtn;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.TextBox savenameinput;
        private System.Windows.Forms.TextBox maininput;
    }
}

