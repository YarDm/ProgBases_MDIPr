using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgBases_MDIPr
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
        

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Form2 newMDIChild = new Form2();
            // Set the Parent Form of the Child window.  
            newMDIChild.MdiParent = this;
            // Display the new form.  
            newMDIChild.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;

            if (activeChild != null)
            {
                activeChild.Close();
            }
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form[] allChilds = this.MdiChildren;

            if(allChilds.Length != 0)
            {
                foreach (Form child in allChilds)
                {
                    child.Close();
                }
            }
        }

        private void textBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBox tb = new TextBox();
            tb.AutoSize = false;
            tb.Height = 150;
            tb.Width = 150;
            tb.Multiline = true;
            tb.Text = "Hello! This is new TextBox!";
            
            Form activeChild = this.ActiveMdiChild;
            foreach (Control c in activeChild.Controls)
            {
                // Looks for a control called 'panel1' - put in your panel's name
                if (c.Name == "flowLayoutPanel1")
                {
                    c.Controls.Add(tb);
                }
            }


        }

        private void monthCalendarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MonthCalendar monthCalendar = new MonthCalendar();
            monthCalendar.AutoSize = false;
            monthCalendar.Height = 150;
            monthCalendar.Width = 150;

            Form activeChild = this.ActiveMdiChild;
            foreach (Control c in activeChild.Controls)
            {
                // Looks for a control called 'panel1' - put in your panel's name
                if (c.Name == "flowLayoutPanel1")
                {
                    c.Controls.Add(monthCalendar);
                }
            }
        }

        private void buttonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Text = "Неожиданно, это кнопка";
            button.Height = 50;
            button.Width = 150;

            Form activeChild = this.ActiveMdiChild;
            foreach (Control c in activeChild.Controls)
            {
                // Looks for a control called 'panel1' - put in your panel's name
                if (c.Name == "flowLayoutPanel1")
                {
                    c.Controls.Add(button);
                }
            }
        }

        private void timesNewRoman20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            foreach (Control c in activeChild.Controls)
            {
                // Looks for a control called 'panel1' - put in your panel's name
                if (c.Name == "flowLayoutPanel1")
                {
                    foreach (Control con in c.Controls)
                    {
                        if (con.Focused == true)
                        {
                            con.Font = new Font("TimesNewRoman", 20);
                        }
                    }
                }
            }
        }

        private void arialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            foreach (Control c in activeChild.Controls)
            {
                // Looks for a control called 'panel1' - put in your panel's name
                if (c.Name == "flowLayoutPanel1")
                {
                    foreach (Control con in c.Controls)
                    {
                        if (con.Focused == true)
                        {
                            con.Font = new Font("Arial", 15f, FontStyle.Bold);
                        }
                    }
                }
            }
        }

        private void verdana14ItalicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            foreach (Control c in activeChild.Controls)
            {
                // Looks for a control called 'panel1' - put in your panel's name
                if (c.Name == "flowLayoutPanel1")
                {
                    foreach (Control con in c.Controls)
                    {
                        if (con.Focused == true)
                        {
                            con.Font = new Font("Verdana", 14f, FontStyle.Italic);
                        }
                    }
                }
            }
        }

        private void activeControlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form activeChild = this.ActiveMdiChild;
            if (activeChild != null)
            {
                Form3 components = new Form3();
                components.MdiParent = this;
                components.Show();
                foreach (Control c in activeChild.Controls)
                {
                    
                    if (c.Name == "flowLayoutPanel1")
                    {
                        foreach (Control con in c.Controls)
                        {
                            ListBox lb = (ListBox)components.ActiveControl;
                            lb.Items.Add(con.ToString());
                        }
                    }
                }
            }

        }
    }
}
