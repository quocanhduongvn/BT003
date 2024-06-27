using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT003
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
           // listBoxChon.Name = "Bạn Đã chọn website:";
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "Bạn Đã chọn website:\r\n";
            try
            {
                if (listBox.SelectedItem != null)
                {
                    this.textBox1.Text += listBox.SelectedItem.ToString();
                }
                else
                {
                    MessageBox.Show("Lỗi: Không có phần tử được chọn.");
                }
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Lỗi");
            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.textBox1.ResetText();
        }
    }
}
