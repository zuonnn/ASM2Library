using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_add_new_student_Click(object sender, EventArgs e)
        {
            list_student.Controls.Add(new Button() { Text = "Student" });
        }

        private void btn_remove_student_Click(object sender, EventArgs e)
        {
            list_student.Controls.Clear();
        }
    }
}
