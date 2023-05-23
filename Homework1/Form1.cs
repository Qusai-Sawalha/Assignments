using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
                // Create a new TextBox control
                TextBox txtBox = new TextBox();
                txtBox.Location = new Point(10, 10);
                txtBox.Size = new Size(100, 20);
                txtBox.Text = "Enter text here";

                // Add the TextBox control to the form's Controls collection
                this.Controls.Add(txtBox);

                // Create a new ComboBox control
                ComboBox comboBox = new ComboBox();
                comboBox.Location = new Point(10, 40);
                comboBox.Size = new Size(100, 20);
                comboBox.Items.Add("Item 1");
                comboBox.Items.Add("Item 2");
                comboBox.Items.Add("Item 3");

                // Add the ComboBox control to the form's Controls collection
                this.Controls.Add(comboBox);

                // Create a new Label control
                Label label = new Label();
                label.Location = new Point(10, 70);
                label.Size = new Size(100, 20);
                label.Text = "This is a label";

                // Add the Label control to the form's Controls collection
                this.Controls.Add(label);
            }

        }
    }

