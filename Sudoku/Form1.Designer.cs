using System.Windows.Forms;

namespace Sudoku
{
    partial class Form1
    {
        private const int numberofboxes = 81;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.richTextBox9 = new System.Windows.Forms.RichTextBox();
            this.richTextBox10 = new System.Windows.Forms.RichTextBox();
            this.richTextBox11 = new System.Windows.Forms.RichTextBox();
            this.richTextBox12 = new System.Windows.Forms.RichTextBox();
            this.richTextBox13 = new System.Windows.Forms.RichTextBox();
            this.richTextBox14 = new System.Windows.Forms.RichTextBox();
            this.richTextBox15 = new System.Windows.Forms.RichTextBox();
            this.richTextBox16 = new System.Windows.Forms.RichTextBox();
            this.richTextBox17 = new System.Windows.Forms.RichTextBox();
            this.richTextBox18 = new System.Windows.Forms.RichTextBox();
            this.richTextBox19 = new System.Windows.Forms.RichTextBox();
            this.richTextBox20 = new System.Windows.Forms.RichTextBox();
            this.richTextBox21 = new System.Windows.Forms.RichTextBox();
            this.richTextBox22 = new System.Windows.Forms.RichTextBox();
            this.richTextBox23 = new System.Windows.Forms.RichTextBox();
            this.richTextBox24 = new System.Windows.Forms.RichTextBox();
            this.richTextBox25 = new System.Windows.Forms.RichTextBox();
            this.richTextBox26 = new System.Windows.Forms.RichTextBox();
            this.richTextBox27 = new System.Windows.Forms.RichTextBox();
            this.richTextBox28 = new System.Windows.Forms.RichTextBox();
            this.richTextBox29 = new System.Windows.Forms.RichTextBox();
            this.richTextBox30 = new System.Windows.Forms.RichTextBox();
            this.richTextBox31 = new System.Windows.Forms.RichTextBox();
            this.richTextBox32 = new System.Windows.Forms.RichTextBox();
            this.richTextBox33 = new System.Windows.Forms.RichTextBox();
            this.richTextBox34 = new System.Windows.Forms.RichTextBox();
            this.richTextBox35 = new System.Windows.Forms.RichTextBox();
            this.richTextBox36 = new System.Windows.Forms.RichTextBox();
            this.richTextBox37 = new System.Windows.Forms.RichTextBox();
            this.richTextBox38 = new System.Windows.Forms.RichTextBox();
            this.richTextBox39 = new System.Windows.Forms.RichTextBox();
            this.richTextBox40 = new System.Windows.Forms.RichTextBox();
            this.richTextBox41 = new System.Windows.Forms.RichTextBox();
            this.richTextBox42 = new System.Windows.Forms.RichTextBox();
            this.richTextBox43 = new System.Windows.Forms.RichTextBox();
            this.richTextBox44 = new System.Windows.Forms.RichTextBox();
            this.richTextBox45 = new System.Windows.Forms.RichTextBox();
            this.richTextBox46 = new System.Windows.Forms.RichTextBox();
            this.richTextBox47 = new System.Windows.Forms.RichTextBox();
            this.richTextBox48 = new System.Windows.Forms.RichTextBox();
            this.richTextBox49 = new System.Windows.Forms.RichTextBox();
            this.richTextBox50 = new System.Windows.Forms.RichTextBox();
            this.richTextBox51 = new System.Windows.Forms.RichTextBox();
            this.richTextBox52 = new System.Windows.Forms.RichTextBox();
            this.richTextBox53 = new System.Windows.Forms.RichTextBox();
            this.richTextBox54 = new System.Windows.Forms.RichTextBox();
            this.richTextBox55 = new System.Windows.Forms.RichTextBox();
            this.richTextBox56 = new System.Windows.Forms.RichTextBox();
            this.richTextBox57 = new System.Windows.Forms.RichTextBox();
            this.richTextBox58 = new System.Windows.Forms.RichTextBox();
            this.richTextBox59 = new System.Windows.Forms.RichTextBox();
            this.richTextBox60 = new System.Windows.Forms.RichTextBox();
            this.richTextBox61 = new System.Windows.Forms.RichTextBox();
            this.richTextBox62 = new System.Windows.Forms.RichTextBox();
            this.richTextBox63 = new System.Windows.Forms.RichTextBox();
            this.richTextBox64 = new System.Windows.Forms.RichTextBox();
            this.richTextBox65 = new System.Windows.Forms.RichTextBox();
            this.richTextBox66 = new System.Windows.Forms.RichTextBox();
            this.richTextBox67 = new System.Windows.Forms.RichTextBox();
            this.richTextBox68 = new System.Windows.Forms.RichTextBox();
            this.richTextBox69 = new System.Windows.Forms.RichTextBox();
            this.richTextBox70 = new System.Windows.Forms.RichTextBox();
            this.richTextBox71 = new System.Windows.Forms.RichTextBox();
            this.richTextBox72 = new System.Windows.Forms.RichTextBox();
            this.richTextBox73 = new System.Windows.Forms.RichTextBox();
            this.richTextBox74 = new System.Windows.Forms.RichTextBox();
            this.richTextBox75 = new System.Windows.Forms.RichTextBox();
            this.richTextBox76 = new System.Windows.Forms.RichTextBox();
            this.richTextBox77 = new System.Windows.Forms.RichTextBox();
            this.richTextBox78 = new System.Windows.Forms.RichTextBox();
            this.richTextBox79 = new System.Windows.Forms.RichTextBox();
            this.richTextBox80 = new System.Windows.Forms.RichTextBox();
            this.richTextBox81 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.MaxLength = 1;
            this.richTextBox1.Multiline = false;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(40, 40);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(58, 12);
            this.richTextBox2.MaxLength = 1;
            this.richTextBox2.Multiline = false;
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox2.Size = new System.Drawing.Size(40, 40);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox3.Location = new System.Drawing.Point(104, 12);
            this.richTextBox3.MaxLength = 1;
            this.richTextBox3.Multiline = false;
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox3.Size = new System.Drawing.Size(40, 40);
            this.richTextBox3.TabIndex = 2;
            this.richTextBox3.Text = "";
            this.richTextBox3.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox4
            // 
            this.richTextBox4.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox4.Location = new System.Drawing.Point(163, 12);
            this.richTextBox4.MaxLength = 1;
            this.richTextBox4.Multiline = false;
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox4.Size = new System.Drawing.Size(40, 40);
            this.richTextBox4.TabIndex = 3;
            this.richTextBox4.Text = "";
            this.richTextBox4.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox5
            // 
            this.richTextBox5.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox5.Location = new System.Drawing.Point(209, 12);
            this.richTextBox5.MaxLength = 1;
            this.richTextBox5.Multiline = false;
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox5.Size = new System.Drawing.Size(40, 40);
            this.richTextBox5.TabIndex = 4;
            this.richTextBox5.Text = "";
            this.richTextBox5.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox6
            // 
            this.richTextBox6.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox6.Location = new System.Drawing.Point(255, 12);
            this.richTextBox6.MaxLength = 1;
            this.richTextBox6.Multiline = false;
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox6.Size = new System.Drawing.Size(40, 40);
            this.richTextBox6.TabIndex = 5;
            this.richTextBox6.Text = "";
            this.richTextBox6.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox7
            // 
            this.richTextBox7.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox7.Location = new System.Drawing.Point(311, 12);
            this.richTextBox7.MaxLength = 1;
            this.richTextBox7.Multiline = false;
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox7.Size = new System.Drawing.Size(40, 40);
            this.richTextBox7.TabIndex = 6;
            this.richTextBox7.Text = "";
            this.richTextBox7.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox8
            // 
            this.richTextBox8.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox8.Location = new System.Drawing.Point(357, 12);
            this.richTextBox8.MaxLength = 1;
            this.richTextBox8.Multiline = false;
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox8.Size = new System.Drawing.Size(40, 40);
            this.richTextBox8.TabIndex = 7;
            this.richTextBox8.Text = "";
            this.richTextBox8.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox9
            // 
            this.richTextBox9.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox9.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox9.Location = new System.Drawing.Point(403, 12);
            this.richTextBox9.MaxLength = 1;
            this.richTextBox9.Multiline = false;
            this.richTextBox9.Name = "richTextBox9";
            this.richTextBox9.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox9.Size = new System.Drawing.Size(40, 40);
            this.richTextBox9.TabIndex = 8;
            this.richTextBox9.Text = "";
            this.richTextBox9.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox10
            // 
            this.richTextBox10.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox10.Location = new System.Drawing.Point(12, 58);
            this.richTextBox10.MaxLength = 1;
            this.richTextBox10.Multiline = false;
            this.richTextBox10.Name = "richTextBox10";
            this.richTextBox10.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox10.Size = new System.Drawing.Size(40, 40);
            this.richTextBox10.TabIndex = 9;
            this.richTextBox10.Text = "";
            this.richTextBox10.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox11
            // 
            this.richTextBox11.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox11.Location = new System.Drawing.Point(58, 58);
            this.richTextBox11.MaxLength = 1;
            this.richTextBox11.Multiline = false;
            this.richTextBox11.Name = "richTextBox11";
            this.richTextBox11.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox11.Size = new System.Drawing.Size(40, 40);
            this.richTextBox11.TabIndex = 10;
            this.richTextBox11.Text = "";
            this.richTextBox11.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox12
            // 
            this.richTextBox12.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox12.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox12.Location = new System.Drawing.Point(104, 58);
            this.richTextBox12.MaxLength = 1;
            this.richTextBox12.Multiline = false;
            this.richTextBox12.Name = "richTextBox12";
            this.richTextBox12.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox12.Size = new System.Drawing.Size(40, 40);
            this.richTextBox12.TabIndex = 11;
            this.richTextBox12.Text = "";
            this.richTextBox12.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox13
            // 
            this.richTextBox13.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox13.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox13.Location = new System.Drawing.Point(12, 104);
            this.richTextBox13.MaxLength = 1;
            this.richTextBox13.Multiline = false;
            this.richTextBox13.Name = "richTextBox13";
            this.richTextBox13.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox13.Size = new System.Drawing.Size(40, 40);
            this.richTextBox13.TabIndex = 12;
            this.richTextBox13.Text = "";
            this.richTextBox13.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox14
            // 
            this.richTextBox14.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox14.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox14.Location = new System.Drawing.Point(58, 104);
            this.richTextBox14.MaxLength = 1;
            this.richTextBox14.Multiline = false;
            this.richTextBox14.Name = "richTextBox14";
            this.richTextBox14.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox14.Size = new System.Drawing.Size(40, 40);
            this.richTextBox14.TabIndex = 13;
            this.richTextBox14.Text = "";
            this.richTextBox14.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox15
            // 
            this.richTextBox15.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox15.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox15.Location = new System.Drawing.Point(104, 104);
            this.richTextBox15.MaxLength = 1;
            this.richTextBox15.Multiline = false;
            this.richTextBox15.Name = "richTextBox15";
            this.richTextBox15.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox15.Size = new System.Drawing.Size(40, 40);
            this.richTextBox15.TabIndex = 14;
            this.richTextBox15.Text = "";
            this.richTextBox15.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox16
            // 
            this.richTextBox16.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox16.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox16.Location = new System.Drawing.Point(163, 58);
            this.richTextBox16.MaxLength = 1;
            this.richTextBox16.Multiline = false;
            this.richTextBox16.Name = "richTextBox16";
            this.richTextBox16.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox16.Size = new System.Drawing.Size(40, 40);
            this.richTextBox16.TabIndex = 15;
            this.richTextBox16.Text = "";
            this.richTextBox16.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox17
            // 
            this.richTextBox17.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox17.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox17.Location = new System.Drawing.Point(209, 58);
            this.richTextBox17.MaxLength = 1;
            this.richTextBox17.Multiline = false;
            this.richTextBox17.Name = "richTextBox17";
            this.richTextBox17.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox17.Size = new System.Drawing.Size(40, 40);
            this.richTextBox17.TabIndex = 16;
            this.richTextBox17.Text = "";
            this.richTextBox17.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox18
            // 
            this.richTextBox18.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox18.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox18.Location = new System.Drawing.Point(255, 58);
            this.richTextBox18.MaxLength = 1;
            this.richTextBox18.Multiline = false;
            this.richTextBox18.Name = "richTextBox18";
            this.richTextBox18.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox18.Size = new System.Drawing.Size(40, 40);
            this.richTextBox18.TabIndex = 17;
            this.richTextBox18.Text = "";
            this.richTextBox18.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox19
            // 
            this.richTextBox19.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox19.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox19.Location = new System.Drawing.Point(311, 58);
            this.richTextBox19.MaxLength = 1;
            this.richTextBox19.Multiline = false;
            this.richTextBox19.Name = "richTextBox19";
            this.richTextBox19.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox19.Size = new System.Drawing.Size(40, 40);
            this.richTextBox19.TabIndex = 18;
            this.richTextBox19.Text = "";
            this.richTextBox19.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox20
            // 
            this.richTextBox20.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox20.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox20.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox20.Location = new System.Drawing.Point(357, 58);
            this.richTextBox20.MaxLength = 1;
            this.richTextBox20.Multiline = false;
            this.richTextBox20.Name = "richTextBox20";
            this.richTextBox20.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox20.Size = new System.Drawing.Size(40, 40);
            this.richTextBox20.TabIndex = 19;
            this.richTextBox20.Text = "";
            this.richTextBox20.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox21
            // 
            this.richTextBox21.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox21.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox21.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox21.Location = new System.Drawing.Point(403, 58);
            this.richTextBox21.MaxLength = 1;
            this.richTextBox21.Multiline = false;
            this.richTextBox21.Name = "richTextBox21";
            this.richTextBox21.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox21.Size = new System.Drawing.Size(40, 40);
            this.richTextBox21.TabIndex = 20;
            this.richTextBox21.Text = "";
            this.richTextBox21.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox22
            // 
            this.richTextBox22.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox22.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox22.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox22.Location = new System.Drawing.Point(12, 160);
            this.richTextBox22.MaxLength = 1;
            this.richTextBox22.Multiline = false;
            this.richTextBox22.Name = "richTextBox22";
            this.richTextBox22.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox22.Size = new System.Drawing.Size(40, 40);
            this.richTextBox22.TabIndex = 21;
            this.richTextBox22.Text = "";
            this.richTextBox22.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox23
            // 
            this.richTextBox23.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox23.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox23.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox23.Location = new System.Drawing.Point(58, 160);
            this.richTextBox23.MaxLength = 1;
            this.richTextBox23.Multiline = false;
            this.richTextBox23.Name = "richTextBox23";
            this.richTextBox23.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox23.Size = new System.Drawing.Size(40, 40);
            this.richTextBox23.TabIndex = 22;
            this.richTextBox23.Text = "";
            this.richTextBox23.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox24
            // 
            this.richTextBox24.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox24.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox24.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox24.Location = new System.Drawing.Point(104, 160);
            this.richTextBox24.MaxLength = 1;
            this.richTextBox24.Multiline = false;
            this.richTextBox24.Name = "richTextBox24";
            this.richTextBox24.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox24.Size = new System.Drawing.Size(40, 40);
            this.richTextBox24.TabIndex = 23;
            this.richTextBox24.Text = "";
            this.richTextBox24.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox25
            // 
            this.richTextBox25.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox25.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox25.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox25.Location = new System.Drawing.Point(12, 206);
            this.richTextBox25.MaxLength = 1;
            this.richTextBox25.Multiline = false;
            this.richTextBox25.Name = "richTextBox25";
            this.richTextBox25.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox25.Size = new System.Drawing.Size(40, 40);
            this.richTextBox25.TabIndex = 24;
            this.richTextBox25.Text = "";
            this.richTextBox25.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox26
            // 
            this.richTextBox26.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox26.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox26.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox26.Location = new System.Drawing.Point(58, 206);
            this.richTextBox26.MaxLength = 1;
            this.richTextBox26.Multiline = false;
            this.richTextBox26.Name = "richTextBox26";
            this.richTextBox26.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox26.Size = new System.Drawing.Size(40, 40);
            this.richTextBox26.TabIndex = 25;
            this.richTextBox26.Text = "";
            this.richTextBox26.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox27
            // 
            this.richTextBox27.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox27.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox27.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox27.Location = new System.Drawing.Point(104, 206);
            this.richTextBox27.MaxLength = 1;
            this.richTextBox27.Multiline = false;
            this.richTextBox27.Name = "richTextBox27";
            this.richTextBox27.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox27.Size = new System.Drawing.Size(40, 40);
            this.richTextBox27.TabIndex = 26;
            this.richTextBox27.Text = "";
            this.richTextBox27.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox28
            // 
            this.richTextBox28.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox28.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox28.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox28.Location = new System.Drawing.Point(163, 104);
            this.richTextBox28.MaxLength = 1;
            this.richTextBox28.Multiline = false;
            this.richTextBox28.Name = "richTextBox28";
            this.richTextBox28.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox28.Size = new System.Drawing.Size(40, 40);
            this.richTextBox28.TabIndex = 27;
            this.richTextBox28.Text = "";
            this.richTextBox28.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox29
            // 
            this.richTextBox29.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox29.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox29.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox29.Location = new System.Drawing.Point(209, 104);
            this.richTextBox29.MaxLength = 1;
            this.richTextBox29.Multiline = false;
            this.richTextBox29.Name = "richTextBox29";
            this.richTextBox29.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox29.Size = new System.Drawing.Size(40, 40);
            this.richTextBox29.TabIndex = 28;
            this.richTextBox29.Text = "";
            this.richTextBox29.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox30
            // 
            this.richTextBox30.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox30.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox30.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox30.Location = new System.Drawing.Point(255, 104);
            this.richTextBox30.MaxLength = 1;
            this.richTextBox30.Multiline = false;
            this.richTextBox30.Name = "richTextBox30";
            this.richTextBox30.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox30.Size = new System.Drawing.Size(40, 40);
            this.richTextBox30.TabIndex = 29;
            this.richTextBox30.Text = "";
            this.richTextBox30.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox31
            // 
            this.richTextBox31.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox31.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox31.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox31.Location = new System.Drawing.Point(311, 104);
            this.richTextBox31.MaxLength = 1;
            this.richTextBox31.Multiline = false;
            this.richTextBox31.Name = "richTextBox31";
            this.richTextBox31.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox31.Size = new System.Drawing.Size(40, 40);
            this.richTextBox31.TabIndex = 30;
            this.richTextBox31.Text = "";
            this.richTextBox31.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox32
            // 
            this.richTextBox32.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox32.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox32.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox32.Location = new System.Drawing.Point(357, 104);
            this.richTextBox32.MaxLength = 1;
            this.richTextBox32.Multiline = false;
            this.richTextBox32.Name = "richTextBox32";
            this.richTextBox32.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox32.Size = new System.Drawing.Size(40, 40);
            this.richTextBox32.TabIndex = 31;
            this.richTextBox32.Text = "";
            this.richTextBox32.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox33
            // 
            this.richTextBox33.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox33.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox33.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox33.Location = new System.Drawing.Point(403, 104);
            this.richTextBox33.MaxLength = 1;
            this.richTextBox33.Multiline = false;
            this.richTextBox33.Name = "richTextBox33";
            this.richTextBox33.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox33.Size = new System.Drawing.Size(40, 40);
            this.richTextBox33.TabIndex = 32;
            this.richTextBox33.Text = "";
            this.richTextBox33.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox34
            // 
            this.richTextBox34.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox34.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox34.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox34.Location = new System.Drawing.Point(12, 252);
            this.richTextBox34.MaxLength = 1;
            this.richTextBox34.Multiline = false;
            this.richTextBox34.Name = "richTextBox34";
            this.richTextBox34.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox34.Size = new System.Drawing.Size(40, 40);
            this.richTextBox34.TabIndex = 33;
            this.richTextBox34.Text = "";
            this.richTextBox34.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox35
            // 
            this.richTextBox35.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox35.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox35.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox35.Location = new System.Drawing.Point(58, 252);
            this.richTextBox35.MaxLength = 1;
            this.richTextBox35.Multiline = false;
            this.richTextBox35.Name = "richTextBox35";
            this.richTextBox35.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox35.Size = new System.Drawing.Size(40, 40);
            this.richTextBox35.TabIndex = 34;
            this.richTextBox35.Text = "";
            this.richTextBox35.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox36
            // 
            this.richTextBox36.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox36.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox36.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox36.Location = new System.Drawing.Point(104, 252);
            this.richTextBox36.MaxLength = 1;
            this.richTextBox36.Multiline = false;
            this.richTextBox36.Name = "richTextBox36";
            this.richTextBox36.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox36.Size = new System.Drawing.Size(40, 40);
            this.richTextBox36.TabIndex = 35;
            this.richTextBox36.Text = "";
            this.richTextBox36.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox37
            // 
            this.richTextBox37.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox37.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox37.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox37.Location = new System.Drawing.Point(12, 307);
            this.richTextBox37.MaxLength = 1;
            this.richTextBox37.Multiline = false;
            this.richTextBox37.Name = "richTextBox37";
            this.richTextBox37.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox37.Size = new System.Drawing.Size(40, 40);
            this.richTextBox37.TabIndex = 36;
            this.richTextBox37.Text = "";
            this.richTextBox37.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox38
            // 
            this.richTextBox38.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox38.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox38.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox38.Location = new System.Drawing.Point(12, 353);
            this.richTextBox38.MaxLength = 1;
            this.richTextBox38.Multiline = false;
            this.richTextBox38.Name = "richTextBox38";
            this.richTextBox38.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox38.Size = new System.Drawing.Size(40, 40);
            this.richTextBox38.TabIndex = 37;
            this.richTextBox38.Text = "";
            this.richTextBox38.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox39
            // 
            this.richTextBox39.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox39.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox39.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox39.Location = new System.Drawing.Point(12, 399);
            this.richTextBox39.MaxLength = 1;
            this.richTextBox39.Multiline = false;
            this.richTextBox39.Name = "richTextBox39";
            this.richTextBox39.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox39.Size = new System.Drawing.Size(40, 40);
            this.richTextBox39.TabIndex = 38;
            this.richTextBox39.Text = "";
            this.richTextBox39.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox40
            // 
            this.richTextBox40.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox40.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox40.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox40.Location = new System.Drawing.Point(58, 307);
            this.richTextBox40.MaxLength = 1;
            this.richTextBox40.Multiline = false;
            this.richTextBox40.Name = "richTextBox40";
            this.richTextBox40.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox40.Size = new System.Drawing.Size(40, 40);
            this.richTextBox40.TabIndex = 39;
            this.richTextBox40.Text = "";
            this.richTextBox40.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox41
            // 
            this.richTextBox41.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox41.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox41.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox41.Location = new System.Drawing.Point(104, 307);
            this.richTextBox41.MaxLength = 1;
            this.richTextBox41.Multiline = false;
            this.richTextBox41.Name = "richTextBox41";
            this.richTextBox41.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox41.Size = new System.Drawing.Size(40, 40);
            this.richTextBox41.TabIndex = 40;
            this.richTextBox41.Text = "";
            this.richTextBox41.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox42
            // 
            this.richTextBox42.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox42.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox42.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox42.Location = new System.Drawing.Point(58, 353);
            this.richTextBox42.MaxLength = 1;
            this.richTextBox42.Multiline = false;
            this.richTextBox42.Name = "richTextBox42";
            this.richTextBox42.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox42.Size = new System.Drawing.Size(40, 40);
            this.richTextBox42.TabIndex = 41;
            this.richTextBox42.Text = "";
            this.richTextBox42.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox43
            // 
            this.richTextBox43.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox43.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox43.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox43.Location = new System.Drawing.Point(104, 353);
            this.richTextBox43.MaxLength = 1;
            this.richTextBox43.Multiline = false;
            this.richTextBox43.Name = "richTextBox43";
            this.richTextBox43.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox43.Size = new System.Drawing.Size(40, 40);
            this.richTextBox43.TabIndex = 42;
            this.richTextBox43.Text = "";
            this.richTextBox43.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox44
            // 
            this.richTextBox44.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox44.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox44.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox44.Location = new System.Drawing.Point(58, 399);
            this.richTextBox44.MaxLength = 1;
            this.richTextBox44.Multiline = false;
            this.richTextBox44.Name = "richTextBox44";
            this.richTextBox44.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox44.Size = new System.Drawing.Size(40, 40);
            this.richTextBox44.TabIndex = 43;
            this.richTextBox44.Text = "";
            this.richTextBox44.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox45
            // 
            this.richTextBox45.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox45.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox45.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox45.Location = new System.Drawing.Point(104, 399);
            this.richTextBox45.MaxLength = 1;
            this.richTextBox45.Multiline = false;
            this.richTextBox45.Name = "richTextBox45";
            this.richTextBox45.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox45.Size = new System.Drawing.Size(40, 40);
            this.richTextBox45.TabIndex = 44;
            this.richTextBox45.Text = "";
            this.richTextBox45.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox46
            // 
            this.richTextBox46.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox46.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox46.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox46.Location = new System.Drawing.Point(163, 160);
            this.richTextBox46.MaxLength = 1;
            this.richTextBox46.Multiline = false;
            this.richTextBox46.Name = "richTextBox46";
            this.richTextBox46.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox46.Size = new System.Drawing.Size(40, 40);
            this.richTextBox46.TabIndex = 45;
            this.richTextBox46.Text = "";
            this.richTextBox46.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox47
            // 
            this.richTextBox47.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox47.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox47.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox47.Location = new System.Drawing.Point(209, 160);
            this.richTextBox47.MaxLength = 1;
            this.richTextBox47.Multiline = false;
            this.richTextBox47.Name = "richTextBox47";
            this.richTextBox47.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox47.Size = new System.Drawing.Size(40, 40);
            this.richTextBox47.TabIndex = 46;
            this.richTextBox47.Text = "";
            this.richTextBox47.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox48
            // 
            this.richTextBox48.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox48.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox48.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox48.Location = new System.Drawing.Point(255, 160);
            this.richTextBox48.MaxLength = 1;
            this.richTextBox48.Multiline = false;
            this.richTextBox48.Name = "richTextBox48";
            this.richTextBox48.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox48.Size = new System.Drawing.Size(40, 40);
            this.richTextBox48.TabIndex = 47;
            this.richTextBox48.Text = "";
            this.richTextBox48.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox49
            // 
            this.richTextBox49.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox49.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox49.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox49.Location = new System.Drawing.Point(311, 160);
            this.richTextBox49.MaxLength = 1;
            this.richTextBox49.Multiline = false;
            this.richTextBox49.Name = "richTextBox49";
            this.richTextBox49.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox49.Size = new System.Drawing.Size(40, 40);
            this.richTextBox49.TabIndex = 48;
            this.richTextBox49.Text = "";
            this.richTextBox49.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox50
            // 
            this.richTextBox50.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox50.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox50.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox50.Location = new System.Drawing.Point(357, 160);
            this.richTextBox50.MaxLength = 1;
            this.richTextBox50.Multiline = false;
            this.richTextBox50.Name = "richTextBox50";
            this.richTextBox50.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox50.Size = new System.Drawing.Size(40, 40);
            this.richTextBox50.TabIndex = 49;
            this.richTextBox50.Text = "";
            this.richTextBox50.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox51
            // 
            this.richTextBox51.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox51.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox51.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox51.Location = new System.Drawing.Point(403, 160);
            this.richTextBox51.MaxLength = 1;
            this.richTextBox51.Multiline = false;
            this.richTextBox51.Name = "richTextBox51";
            this.richTextBox51.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox51.Size = new System.Drawing.Size(40, 40);
            this.richTextBox51.TabIndex = 50;
            this.richTextBox51.Text = "";
            this.richTextBox51.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox52
            // 
            this.richTextBox52.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox52.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox52.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox52.Location = new System.Drawing.Point(163, 206);
            this.richTextBox52.MaxLength = 1;
            this.richTextBox52.Multiline = false;
            this.richTextBox52.Name = "richTextBox52";
            this.richTextBox52.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox52.Size = new System.Drawing.Size(40, 40);
            this.richTextBox52.TabIndex = 51;
            this.richTextBox52.Text = "";
            this.richTextBox52.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox53
            // 
            this.richTextBox53.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox53.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox53.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox53.Location = new System.Drawing.Point(209, 206);
            this.richTextBox53.MaxLength = 1;
            this.richTextBox53.Multiline = false;
            this.richTextBox53.Name = "richTextBox53";
            this.richTextBox53.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox53.Size = new System.Drawing.Size(40, 40);
            this.richTextBox53.TabIndex = 52;
            this.richTextBox53.Text = "";
            this.richTextBox53.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox54
            // 
            this.richTextBox54.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox54.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox54.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox54.Location = new System.Drawing.Point(255, 206);
            this.richTextBox54.MaxLength = 1;
            this.richTextBox54.Multiline = false;
            this.richTextBox54.Name = "richTextBox54";
            this.richTextBox54.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox54.Size = new System.Drawing.Size(40, 40);
            this.richTextBox54.TabIndex = 53;
            this.richTextBox54.Text = "";
            this.richTextBox54.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox55
            // 
            this.richTextBox55.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox55.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox55.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox55.Location = new System.Drawing.Point(311, 206);
            this.richTextBox55.MaxLength = 1;
            this.richTextBox55.Multiline = false;
            this.richTextBox55.Name = "richTextBox55";
            this.richTextBox55.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox55.Size = new System.Drawing.Size(40, 40);
            this.richTextBox55.TabIndex = 54;
            this.richTextBox55.Text = "";
            this.richTextBox55.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox56
            // 
            this.richTextBox56.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox56.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox56.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox56.Location = new System.Drawing.Point(357, 206);
            this.richTextBox56.MaxLength = 1;
            this.richTextBox56.Multiline = false;
            this.richTextBox56.Name = "richTextBox56";
            this.richTextBox56.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox56.Size = new System.Drawing.Size(40, 40);
            this.richTextBox56.TabIndex = 55;
            this.richTextBox56.Text = "";
            this.richTextBox56.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox57
            // 
            this.richTextBox57.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox57.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox57.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox57.Location = new System.Drawing.Point(403, 206);
            this.richTextBox57.MaxLength = 1;
            this.richTextBox57.Multiline = false;
            this.richTextBox57.Name = "richTextBox57";
            this.richTextBox57.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox57.Size = new System.Drawing.Size(40, 40);
            this.richTextBox57.TabIndex = 56;
            this.richTextBox57.Text = "";
            this.richTextBox57.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox58
            // 
            this.richTextBox58.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox58.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox58.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox58.Location = new System.Drawing.Point(163, 252);
            this.richTextBox58.MaxLength = 1;
            this.richTextBox58.Multiline = false;
            this.richTextBox58.Name = "richTextBox58";
            this.richTextBox58.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox58.Size = new System.Drawing.Size(40, 40);
            this.richTextBox58.TabIndex = 57;
            this.richTextBox58.Text = "";
            this.richTextBox58.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox59
            // 
            this.richTextBox59.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox59.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox59.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox59.Location = new System.Drawing.Point(209, 252);
            this.richTextBox59.MaxLength = 1;
            this.richTextBox59.Multiline = false;
            this.richTextBox59.Name = "richTextBox59";
            this.richTextBox59.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox59.Size = new System.Drawing.Size(40, 40);
            this.richTextBox59.TabIndex = 58;
            this.richTextBox59.Text = "";
            this.richTextBox59.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox60
            // 
            this.richTextBox60.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox60.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox60.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox60.Location = new System.Drawing.Point(255, 252);
            this.richTextBox60.MaxLength = 1;
            this.richTextBox60.Multiline = false;
            this.richTextBox60.Name = "richTextBox60";
            this.richTextBox60.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox60.Size = new System.Drawing.Size(40, 40);
            this.richTextBox60.TabIndex = 59;
            this.richTextBox60.Text = "";
            this.richTextBox60.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox61
            // 
            this.richTextBox61.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox61.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox61.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox61.Location = new System.Drawing.Point(311, 252);
            this.richTextBox61.MaxLength = 1;
            this.richTextBox61.Multiline = false;
            this.richTextBox61.Name = "richTextBox61";
            this.richTextBox61.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox61.Size = new System.Drawing.Size(40, 40);
            this.richTextBox61.TabIndex = 60;
            this.richTextBox61.Text = "";
            this.richTextBox61.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox62
            // 
            this.richTextBox62.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox62.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox62.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox62.Location = new System.Drawing.Point(357, 252);
            this.richTextBox62.MaxLength = 1;
            this.richTextBox62.Multiline = false;
            this.richTextBox62.Name = "richTextBox62";
            this.richTextBox62.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox62.Size = new System.Drawing.Size(40, 40);
            this.richTextBox62.TabIndex = 61;
            this.richTextBox62.Text = "";
            this.richTextBox62.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox63
            // 
            this.richTextBox63.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox63.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox63.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox63.Location = new System.Drawing.Point(403, 252);
            this.richTextBox63.MaxLength = 1;
            this.richTextBox63.Multiline = false;
            this.richTextBox63.Name = "richTextBox63";
            this.richTextBox63.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox63.Size = new System.Drawing.Size(40, 40);
            this.richTextBox63.TabIndex = 62;
            this.richTextBox63.Text = "";
            this.richTextBox63.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox64
            // 
            this.richTextBox64.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox64.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox64.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox64.Location = new System.Drawing.Point(163, 307);
            this.richTextBox64.MaxLength = 1;
            this.richTextBox64.Multiline = false;
            this.richTextBox64.Name = "richTextBox64";
            this.richTextBox64.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox64.Size = new System.Drawing.Size(40, 40);
            this.richTextBox64.TabIndex = 63;
            this.richTextBox64.Text = "";
            this.richTextBox64.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox65
            // 
            this.richTextBox65.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox65.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox65.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox65.Location = new System.Drawing.Point(209, 307);
            this.richTextBox65.MaxLength = 1;
            this.richTextBox65.Multiline = false;
            this.richTextBox65.Name = "richTextBox65";
            this.richTextBox65.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox65.Size = new System.Drawing.Size(40, 40);
            this.richTextBox65.TabIndex = 64;
            this.richTextBox65.Text = "";
            this.richTextBox65.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox66
            // 
            this.richTextBox66.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox66.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox66.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox66.Location = new System.Drawing.Point(255, 307);
            this.richTextBox66.MaxLength = 1;
            this.richTextBox66.Multiline = false;
            this.richTextBox66.Name = "richTextBox66";
            this.richTextBox66.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox66.Size = new System.Drawing.Size(40, 40);
            this.richTextBox66.TabIndex = 65;
            this.richTextBox66.Text = "";
            this.richTextBox66.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox67
            // 
            this.richTextBox67.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox67.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox67.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox67.Location = new System.Drawing.Point(311, 307);
            this.richTextBox67.MaxLength = 1;
            this.richTextBox67.Multiline = false;
            this.richTextBox67.Name = "richTextBox67";
            this.richTextBox67.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox67.Size = new System.Drawing.Size(40, 40);
            this.richTextBox67.TabIndex = 66;
            this.richTextBox67.Text = "";
            this.richTextBox67.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox68
            // 
            this.richTextBox68.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox68.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox68.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox68.Location = new System.Drawing.Point(357, 307);
            this.richTextBox68.MaxLength = 1;
            this.richTextBox68.Multiline = false;
            this.richTextBox68.Name = "richTextBox68";
            this.richTextBox68.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox68.Size = new System.Drawing.Size(40, 40);
            this.richTextBox68.TabIndex = 67;
            this.richTextBox68.Text = "";
            this.richTextBox68.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox69
            // 
            this.richTextBox69.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox69.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox69.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox69.Location = new System.Drawing.Point(403, 307);
            this.richTextBox69.MaxLength = 1;
            this.richTextBox69.Multiline = false;
            this.richTextBox69.Name = "richTextBox69";
            this.richTextBox69.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox69.Size = new System.Drawing.Size(40, 40);
            this.richTextBox69.TabIndex = 68;
            this.richTextBox69.Text = "";
            this.richTextBox69.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox70
            // 
            this.richTextBox70.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox70.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox70.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox70.Location = new System.Drawing.Point(311, 353);
            this.richTextBox70.MaxLength = 1;
            this.richTextBox70.Multiline = false;
            this.richTextBox70.Name = "richTextBox70";
            this.richTextBox70.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox70.Size = new System.Drawing.Size(40, 40);
            this.richTextBox70.TabIndex = 69;
            this.richTextBox70.Text = "";
            this.richTextBox70.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox71
            // 
            this.richTextBox71.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox71.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox71.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox71.Location = new System.Drawing.Point(311, 399);
            this.richTextBox71.MaxLength = 1;
            this.richTextBox71.Multiline = false;
            this.richTextBox71.Name = "richTextBox71";
            this.richTextBox71.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox71.Size = new System.Drawing.Size(40, 40);
            this.richTextBox71.TabIndex = 70;
            this.richTextBox71.Text = "";
            this.richTextBox71.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox72
            // 
            this.richTextBox72.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox72.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox72.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox72.Location = new System.Drawing.Point(357, 353);
            this.richTextBox72.MaxLength = 1;
            this.richTextBox72.Multiline = false;
            this.richTextBox72.Name = "richTextBox72";
            this.richTextBox72.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox72.Size = new System.Drawing.Size(40, 40);
            this.richTextBox72.TabIndex = 71;
            this.richTextBox72.Text = "";
            this.richTextBox72.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox73
            // 
            this.richTextBox73.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox73.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox73.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox73.Location = new System.Drawing.Point(357, 399);
            this.richTextBox73.MaxLength = 1;
            this.richTextBox73.Multiline = false;
            this.richTextBox73.Name = "richTextBox73";
            this.richTextBox73.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox73.Size = new System.Drawing.Size(40, 40);
            this.richTextBox73.TabIndex = 72;
            this.richTextBox73.Text = "";
            this.richTextBox73.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox74
            // 
            this.richTextBox74.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox74.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox74.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox74.Location = new System.Drawing.Point(403, 353);
            this.richTextBox74.MaxLength = 1;
            this.richTextBox74.Multiline = false;
            this.richTextBox74.Name = "richTextBox74";
            this.richTextBox74.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox74.Size = new System.Drawing.Size(40, 40);
            this.richTextBox74.TabIndex = 73;
            this.richTextBox74.Text = "";
            this.richTextBox74.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox75
            // 
            this.richTextBox75.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox75.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox75.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox75.Location = new System.Drawing.Point(403, 399);
            this.richTextBox75.MaxLength = 1;
            this.richTextBox75.Multiline = false;
            this.richTextBox75.Name = "richTextBox75";
            this.richTextBox75.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox75.Size = new System.Drawing.Size(40, 40);
            this.richTextBox75.TabIndex = 74;
            this.richTextBox75.Text = "";
            this.richTextBox75.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox76
            // 
            this.richTextBox76.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox76.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox76.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox76.Location = new System.Drawing.Point(163, 353);
            this.richTextBox76.MaxLength = 1;
            this.richTextBox76.Multiline = false;
            this.richTextBox76.Name = "richTextBox76";
            this.richTextBox76.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox76.Size = new System.Drawing.Size(40, 40);
            this.richTextBox76.TabIndex = 75;
            this.richTextBox76.Text = "";
            this.richTextBox76.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox77
            // 
            this.richTextBox77.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox77.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox77.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox77.Location = new System.Drawing.Point(209, 353);
            this.richTextBox77.MaxLength = 1;
            this.richTextBox77.Multiline = false;
            this.richTextBox77.Name = "richTextBox77";
            this.richTextBox77.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox77.Size = new System.Drawing.Size(40, 40);
            this.richTextBox77.TabIndex = 76;
            this.richTextBox77.Text = "";
            this.richTextBox77.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox78
            // 
            this.richTextBox78.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox78.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox78.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox78.Location = new System.Drawing.Point(255, 353);
            this.richTextBox78.MaxLength = 1;
            this.richTextBox78.Multiline = false;
            this.richTextBox78.Name = "richTextBox78";
            this.richTextBox78.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox78.Size = new System.Drawing.Size(40, 40);
            this.richTextBox78.TabIndex = 77;
            this.richTextBox78.Text = "";
            this.richTextBox78.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox79
            // 
            this.richTextBox79.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox79.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox79.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox79.Location = new System.Drawing.Point(163, 399);
            this.richTextBox79.MaxLength = 1;
            this.richTextBox79.Multiline = false;
            this.richTextBox79.Name = "richTextBox79";
            this.richTextBox79.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox79.Size = new System.Drawing.Size(40, 40);
            this.richTextBox79.TabIndex = 78;
            this.richTextBox79.Text = "";
            this.richTextBox79.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox80
            // 
            this.richTextBox80.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox80.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox80.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox80.Location = new System.Drawing.Point(209, 399);
            this.richTextBox80.MaxLength = 1;
            this.richTextBox80.Multiline = false;
            this.richTextBox80.Name = "richTextBox80";
            this.richTextBox80.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox80.Size = new System.Drawing.Size(40, 40);
            this.richTextBox80.TabIndex = 79;
            this.richTextBox80.Text = "";
            this.richTextBox80.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // richTextBox81
            // 
            this.richTextBox81.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox81.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox81.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox81.Location = new System.Drawing.Point(255, 399);
            this.richTextBox81.MaxLength = 1;
            this.richTextBox81.Multiline = false;
            this.richTextBox81.Name = "richTextBox81";
            this.richTextBox81.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox81.Size = new System.Drawing.Size(40, 40);
            this.richTextBox81.TabIndex = 80;
            this.richTextBox81.Text = "";
            this.richTextBox81.TextChanged += new System.EventHandler(this.ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 512);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 81;
            this.button1.Text = "Auto Solve";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(455, 547);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox81);
            this.Controls.Add(this.richTextBox80);
            this.Controls.Add(this.richTextBox79);
            this.Controls.Add(this.richTextBox78);
            this.Controls.Add(this.richTextBox77);
            this.Controls.Add(this.richTextBox76);
            this.Controls.Add(this.richTextBox75);
            this.Controls.Add(this.richTextBox74);
            this.Controls.Add(this.richTextBox73);
            this.Controls.Add(this.richTextBox72);
            this.Controls.Add(this.richTextBox71);
            this.Controls.Add(this.richTextBox70);
            this.Controls.Add(this.richTextBox69);
            this.Controls.Add(this.richTextBox68);
            this.Controls.Add(this.richTextBox67);
            this.Controls.Add(this.richTextBox66);
            this.Controls.Add(this.richTextBox65);
            this.Controls.Add(this.richTextBox64);
            this.Controls.Add(this.richTextBox63);
            this.Controls.Add(this.richTextBox62);
            this.Controls.Add(this.richTextBox61);
            this.Controls.Add(this.richTextBox60);
            this.Controls.Add(this.richTextBox59);
            this.Controls.Add(this.richTextBox58);
            this.Controls.Add(this.richTextBox57);
            this.Controls.Add(this.richTextBox56);
            this.Controls.Add(this.richTextBox55);
            this.Controls.Add(this.richTextBox54);
            this.Controls.Add(this.richTextBox53);
            this.Controls.Add(this.richTextBox52);
            this.Controls.Add(this.richTextBox51);
            this.Controls.Add(this.richTextBox50);
            this.Controls.Add(this.richTextBox49);
            this.Controls.Add(this.richTextBox48);
            this.Controls.Add(this.richTextBox47);
            this.Controls.Add(this.richTextBox46);
            this.Controls.Add(this.richTextBox45);
            this.Controls.Add(this.richTextBox44);
            this.Controls.Add(this.richTextBox43);
            this.Controls.Add(this.richTextBox42);
            this.Controls.Add(this.richTextBox41);
            this.Controls.Add(this.richTextBox40);
            this.Controls.Add(this.richTextBox39);
            this.Controls.Add(this.richTextBox38);
            this.Controls.Add(this.richTextBox37);
            this.Controls.Add(this.richTextBox36);
            this.Controls.Add(this.richTextBox35);
            this.Controls.Add(this.richTextBox34);
            this.Controls.Add(this.richTextBox33);
            this.Controls.Add(this.richTextBox32);
            this.Controls.Add(this.richTextBox31);
            this.Controls.Add(this.richTextBox30);
            this.Controls.Add(this.richTextBox29);
            this.Controls.Add(this.richTextBox28);
            this.Controls.Add(this.richTextBox27);
            this.Controls.Add(this.richTextBox26);
            this.Controls.Add(this.richTextBox25);
            this.Controls.Add(this.richTextBox24);
            this.Controls.Add(this.richTextBox23);
            this.Controls.Add(this.richTextBox22);
            this.Controls.Add(this.richTextBox21);
            this.Controls.Add(this.richTextBox20);
            this.Controls.Add(this.richTextBox19);
            this.Controls.Add(this.richTextBox18);
            this.Controls.Add(this.richTextBox17);
            this.Controls.Add(this.richTextBox16);
            this.Controls.Add(this.richTextBox15);
            this.Controls.Add(this.richTextBox14);
            this.Controls.Add(this.richTextBox13);
            this.Controls.Add(this.richTextBox12);
            this.Controls.Add(this.richTextBox11);
            this.Controls.Add(this.richTextBox10);
            this.Controls.Add(this.richTextBox9);
            this.Controls.Add(this.richTextBox8);
            this.Controls.Add(this.richTextBox7);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Sudoku";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TextChanged += new System.EventHandler(this.ValueChanged);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.RichTextBox richTextBox2;
        public System.Windows.Forms.RichTextBox richTextBox3;
        public System.Windows.Forms.RichTextBox richTextBox4;
        public System.Windows.Forms.RichTextBox richTextBox5;
        public System.Windows.Forms.RichTextBox richTextBox6;
        public System.Windows.Forms.RichTextBox richTextBox7;
        public System.Windows.Forms.RichTextBox richTextBox8;
        public System.Windows.Forms.RichTextBox richTextBox9;
        public System.Windows.Forms.RichTextBox richTextBox10;
        public System.Windows.Forms.RichTextBox richTextBox11;
        public System.Windows.Forms.RichTextBox richTextBox12;
        public System.Windows.Forms.RichTextBox richTextBox13;
        public System.Windows.Forms.RichTextBox richTextBox14;
        public System.Windows.Forms.RichTextBox richTextBox15;
        public System.Windows.Forms.RichTextBox richTextBox16;
        public System.Windows.Forms.RichTextBox richTextBox17;
        public System.Windows.Forms.RichTextBox richTextBox18;
        public System.Windows.Forms.RichTextBox richTextBox19;
        public System.Windows.Forms.RichTextBox richTextBox20;
        public System.Windows.Forms.RichTextBox richTextBox21;
        public System.Windows.Forms.RichTextBox richTextBox22;
        public System.Windows.Forms.RichTextBox richTextBox23;
        public System.Windows.Forms.RichTextBox richTextBox24;
        public System.Windows.Forms.RichTextBox richTextBox25;
        public System.Windows.Forms.RichTextBox richTextBox26;
        public System.Windows.Forms.RichTextBox richTextBox27;
        public System.Windows.Forms.RichTextBox richTextBox28;
        public System.Windows.Forms.RichTextBox richTextBox29;
        public System.Windows.Forms.RichTextBox richTextBox30;
        public System.Windows.Forms.RichTextBox richTextBox31;
        public System.Windows.Forms.RichTextBox richTextBox32;
        public System.Windows.Forms.RichTextBox richTextBox33;
        public System.Windows.Forms.RichTextBox richTextBox34;
        public System.Windows.Forms.RichTextBox richTextBox35;
        public System.Windows.Forms.RichTextBox richTextBox36;
        public System.Windows.Forms.RichTextBox richTextBox37;
        public System.Windows.Forms.RichTextBox richTextBox38;
        public System.Windows.Forms.RichTextBox richTextBox39;
        public System.Windows.Forms.RichTextBox richTextBox40;
        public System.Windows.Forms.RichTextBox richTextBox41;
        public System.Windows.Forms.RichTextBox richTextBox42;
        public System.Windows.Forms.RichTextBox richTextBox43;
        public System.Windows.Forms.RichTextBox richTextBox44;
        public System.Windows.Forms.RichTextBox richTextBox45;
        public System.Windows.Forms.RichTextBox richTextBox46;
        public System.Windows.Forms.RichTextBox richTextBox47;
        public System.Windows.Forms.RichTextBox richTextBox48;
        public System.Windows.Forms.RichTextBox richTextBox49;
        public System.Windows.Forms.RichTextBox richTextBox50;
        public System.Windows.Forms.RichTextBox richTextBox51;
        public System.Windows.Forms.RichTextBox richTextBox52;
        public System.Windows.Forms.RichTextBox richTextBox53;
        public System.Windows.Forms.RichTextBox richTextBox54;
        public System.Windows.Forms.RichTextBox richTextBox55;
        public System.Windows.Forms.RichTextBox richTextBox56;
        public System.Windows.Forms.RichTextBox richTextBox57;
        public System.Windows.Forms.RichTextBox richTextBox58;
        public System.Windows.Forms.RichTextBox richTextBox59;
        public System.Windows.Forms.RichTextBox richTextBox60;
        public System.Windows.Forms.RichTextBox richTextBox61;
        public System.Windows.Forms.RichTextBox richTextBox62;
        public System.Windows.Forms.RichTextBox richTextBox63;
        public System.Windows.Forms.RichTextBox richTextBox64;
        public System.Windows.Forms.RichTextBox richTextBox65;
        public System.Windows.Forms.RichTextBox richTextBox66;
        public System.Windows.Forms.RichTextBox richTextBox67;
        public System.Windows.Forms.RichTextBox richTextBox68;
        public System.Windows.Forms.RichTextBox richTextBox69;
        public System.Windows.Forms.RichTextBox richTextBox70;
        public System.Windows.Forms.RichTextBox richTextBox71;
        public System.Windows.Forms.RichTextBox richTextBox72;
        public System.Windows.Forms.RichTextBox richTextBox73;
        public System.Windows.Forms.RichTextBox richTextBox74;
        public System.Windows.Forms.RichTextBox richTextBox75;
        public System.Windows.Forms.RichTextBox richTextBox76;
        public System.Windows.Forms.RichTextBox richTextBox77;
        public System.Windows.Forms.RichTextBox richTextBox78;
        public System.Windows.Forms.RichTextBox richTextBox79;
        public System.Windows.Forms.RichTextBox richTextBox80;
        public System.Windows.Forms.RichTextBox richTextBox81;
        public System.Windows.Forms.Button button1;
    }
}

