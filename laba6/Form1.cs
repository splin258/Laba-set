using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            add_set_1.Visible = false;
            elem.Visible = false;
            intersection.Visible = false;
            num_set.Visible = false;
            perform.Visible = false;
            label_elem_or_index.Visible = false;
            label_num_set.Visible = false;
            association.Visible = false;
            list_set_1.Visible = false;
            list_set_2.Visible = false;
            list_set_res.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            set_1.size = 0;
            set_1.capacity = 2;
            set_1.mas = new int[set_1.capacity];
            set_2.size = 0;
            set_2.capacity = 2;
            set_2.mas = new int[set_2.capacity];
            new_set.Hide();
            elem.Visible = true;
            add_set_1.Visible = true;
            intersection.Visible = true;
            num_set.Visible = true;
            perform.Visible = true;
            label_elem_or_index.Visible = true;
            label_num_set.Visible = true;
            association.Visible = true;
            list_set_1.Visible = true;
            list_set_2.Visible = true;
            list_set_res.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;

        }

        public Set set_1 = new Set();
        public Set set_2 = new Set();
        public Set res = new Set();
        public int tmp;
        public bool check_enter_set2 = false;
        public bool check_enter_set1 = false;

        private void add_set_1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void perform_Click(object sender, EventArgs e)
        {
            if (add_set_1.Checked == true)
            {
                try
                {
                    tmp = Convert.ToInt32(num_set.Text);
                }
                catch
                {
                    MessageBox.Show("Введите номер множества", "Ошибка!");
                    return;
                }
                try
                {
                    Convert.ToInt32(elem.Text);
                }
                catch
                {
                    MessageBox.Show("Введите элемент", "Ошибка!");
                    return;
                }
                if(tmp > 2 || tmp < 1)
                {
                    MessageBox.Show("Такого множества не существует", "Ошибка!");
                    return;
                }
                switch (tmp)
                {
                    case 1:
                        {
                            list_set_1.Items.Clear();
                            set_1.add(Convert.ToInt32(elem.Text));
                            for (int i = 0; i < set_1.size; i++)
                            {
                                list_set_1.Items.Add(Convert.ToString(set_1.mas[i]));
                            }
                            check_enter_set1 = true;
                            return;
                        }
                    case 2:
                        {
                            list_set_2.Items.Clear();
                            set_2.add(Convert.ToInt32(elem.Text));
                            for (int i = 0; i < set_2.size; i++)
                            {
                                list_set_2.Items.Add(Convert.ToString(set_2.mas[i]));
                            }
                            check_enter_set2 = true;
                            return;
                        }
                }
            }
            if(!check_enter_set1)
            {
                MessageBox.Show("добавте хотя бы один элемент в первое множество", "Ошибка!");
                return;
            }
            if(!check_enter_set2)
            {
                MessageBox.Show("добавте хотя бы один элемент во второе множество", "Ошибка!");
                return;
            }
            if (intersection.Checked == true)
            {
                list_set_res.Items.Clear();
              // res = set_1;
                res = set_1.Intersection(set_2);
                for (int i = 0; i < res.size; i++)
                {
                    list_set_res.Items.Add(Convert.ToString(res.mas[i]));
                }
                return;
            }
            if(association.Checked == true)
            {
                list_set_res.Items.Clear();
                //res = set_1;
                res = set_1.Combine(set_2);
                for (int i = 0; i < res.size; i++)
                {
                    list_set_res.Items.Add(Convert.ToString(res.mas[i]));
                }
                return;
            }
            if (add_set_1.Checked == false || intersection.Checked == false || association.Checked == false)
            {
                MessageBox.Show("Выберете действие", "Ошибка!");
                return;
            }
        }

        private void find_elem_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label_elem_or_index_Click(object sender, EventArgs e)
        {

        }
    }
}
