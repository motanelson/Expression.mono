using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace guiExpr
{
partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 36);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(783, 182);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(0, 224);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(783, 182);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "expr";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.clearDataToolStripMenuItem,
            this.saveDataToolStripMenuItem,
            this.runToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clearToolStripMenuItem.Text = "clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearDataToolStripMenuItem
            // 
            this.clearDataToolStripMenuItem.Name = "clearDataToolStripMenuItem";
            this.clearDataToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.clearDataToolStripMenuItem.Text = "clear data";
            this.clearDataToolStripMenuItem.Click += new System.EventHandler(this.clearDataToolStripMenuItem_Click);
            // 
            // saveDataToolStripMenuItem
            // 
            this.saveDataToolStripMenuItem.Name = "saveDataToolStripMenuItem";
            this.saveDataToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveDataToolStripMenuItem.Text = "save data";
            this.saveDataToolStripMenuItem.Click += new System.EventHandler(this.saveDataToolStripMenuItem_Click);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.runToolStripMenuItem.Text = "run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Expression";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
class runexpression
    {



        public static Double total = 0.00; static Double value = 0.00; static string[] signal = { }; static Double[] parcel = { }; static int counter = 0; static Double d = 0.00; static String st; static bool prints = false;

        static void writer()
        {

            if (prints) Console.WriteLine(total);

        }

        static int finders(String s, char s1)
        {
            return s.IndexOf(s1);
        }

        static int returner(String s)
        {
            int i0 = s.Length;
            int i1 = 0;
            int i2 = 0;
            int i3 = 0;
            int i4 = 0;
            i1 = finders(s, '+');
            i2 = finders(s, '-');
            i3 = finders(s, '*');
            i4 = finders(s, '/');
            if (i1 > -1) i0 = Math.Min(i0, i1);
            if (i2 > -1) i0 = Math.Min(i0, i2);
            if (i3 > -1) i0 = Math.Min(i0, i3);
            if (i4 > -1) i0 = Math.Min(i0, i4);
            if (i0 == s.Length) return 0;
            return i0;
        }
        static void parm(String ss)

        {
            ss = ss.Trim();
            if (counter == 0) st = ss;
            if (counter == 1)
            {
                try
                {
                    d = Double.Parse(ss);
                }
                catch (Exception e)
                {
                    Console.WriteLine("error:");

                }
                if (st == "+") total = total + d;
                if (st == "-") total = total - d;
                if (st == "*") total = total * d;
                if (st == "X") total = total * d;
                if (st == "x") total = total * d;
                if (st == "\\") total = total / d;
                if (st == "/") total = total / d;
                counter = -1;
            }
            counter++;



        }


        public static void splint(String s)
        {
            String[] f = { };
            String[] ss = { };

            int i = 0;
            i = 0;

            while (true)
            {


                i = returner(s);
                if (i == 0)
                {
                    Array.Resize(ref ss, ss.Length + 1);

                    ss[ss.Length - 1] = s;
                    break;
                }
                else
                {
                    Array.Resize(ref ss, ss.Length + 2);

                    ss[ss.Length - 2] = s.Substring(0, i);
                    ss[ss.Length - 1] = s.Substring(i, 1);
                    s = s.Substring(i + 1, s.Length - 1 - i);

                }
            }


            try
            {
                total = Double.Parse(ss[0]);
            }
            catch (Exception e)
            {
                Console.WriteLine("error:");

            }
            for (i = 1; i < ss.Length; i++)
            {
                parm(ss[i]);


            }
            writer();

        }
        static String rfinds(String s)

        {
            String ss = "";
            int f1 = s.IndexOf(")") + 1;
            if (f1 == 0) return "";
            ss = s.Substring(0, f1);
            f1 = ss.LastIndexOf("(");
            if (f1 == -1)
            {
                Console.WriteLine("error:");
                return "";
            }
            ss = ss.Substring(f1);
            return ss;
        }
        public static String expressionLoop(String s)
        {
            String ss = "";
            String sss = "";
            String ssss = "";
            
            while (true)

            {

                ss = rfinds(s);
                sss = ss.Replace(")", "");
                sss = sss.Replace("(", "");
                if (ss == "")
                {
                    total = 0.00;
                    prints = true;
                    splint(s);
                    break;



                }
                else
                {
                    prints = false;
                    total = 0.00;
                    splint(sss);
                    sss = total.ToString();
                    total = 0.00;
                    s = s.Replace(ss, sss);


                }

                

            }



            return total.ToString();
        }

    }




    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName!="")textBox1.Text= File.ReadAllText(openFileDialog1.FileName);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog(this);
            if (saveFileDialog1.FileName != "") File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
            textBox1.Text = "";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog(this);
            if (saveFileDialog1.FileName != "") File.WriteAllText(saveFileDialog1.FileName, textBox1.Text);
        }

        private void clearDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog(this);
            if (saveFileDialog1.FileName != "") File.WriteAllText(saveFileDialog1.FileName, textBox2.Text);
            textBox2.Text = "";
        }

        private void saveDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "";
            saveFileDialog1.ShowDialog(this);
            if (saveFileDialog1.FileName != "") File.WriteAllText(saveFileDialog1.FileName, textBox2.Text);
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String[] s = textBox1.Text.Split('\n');
            foreach (String s2 in s)
            {
                textBox2.Text+= runexpression.expressionLoop(s2)+"\r\n";


            }
        }
    }

    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
