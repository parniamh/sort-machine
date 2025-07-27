using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace تکلیف4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] nums = new int[10];
        int temp;


        private void SortBtn_Click(object sender, EventArgs e)
        {
            nums[0] = Convert.ToInt32(textBox1.Text);
            nums[1] = Convert.ToInt32(textBox2.Text);
            nums[2] = Convert.ToInt32(textBox3.Text);
            nums[3] = Convert.ToInt32(textBox4.Text);
            nums[4] = Convert.ToInt32(textBox5.Text);
            nums[5] = Convert.ToInt32(textBox6.Text);
            nums[6] = Convert.ToInt32(textBox7.Text);
            nums[7] = Convert.ToInt32(textBox8.Text);
            nums[8] = Convert.ToInt32(textBox9.Text);
            nums[9] = Convert.ToInt32(textBox10.Text);

            for (int i = 0; i <= 9; i++)
            {
                for (int j = i + 1; j <= 9; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        int temp;
                        temp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = temp;
                    }

                }
            }


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = "";
            for (int k = 0; k <= 9; k++)
            {
                s1 = s1 + Convert.ToString(nums[k]) + "-";
            }
            textBox1.Text = nums[0].ToString();
            textBox2.Text = nums[1].ToString();
            textBox3.Text = nums[2].ToString();
            textBox4.Text = nums[3].ToString(); 
            textBox5.Text = nums[4].ToString();
            textBox6.Text = nums[5].ToString();
            textBox7.Text = nums[6].ToString();
            textBox8.Text = nums[7].ToString();
            textBox9.Text = nums[8].ToString();
            textBox10.Text = nums[9].ToString();
        }
    }
}