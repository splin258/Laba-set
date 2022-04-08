namespace laba6
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.new_set = new System.Windows.Forms.Button();
            this.add_set_1 = new System.Windows.Forms.RadioButton();
            this.perform = new System.Windows.Forms.Button();
            this.intersection = new System.Windows.Forms.RadioButton();
            this.num_set = new System.Windows.Forms.TextBox();
            this.label_num_set = new System.Windows.Forms.Label();
            this.elem = new System.Windows.Forms.TextBox();
            this.label_elem_or_index = new System.Windows.Forms.Label();
            this.association = new System.Windows.Forms.RadioButton();
            this.list_set_1 = new System.Windows.Forms.ListBox();
            this.list_set_2 = new System.Windows.Forms.ListBox();
            this.list_set_res = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // new_set
            // 
            this.new_set.Location = new System.Drawing.Point(323, 200);
            this.new_set.Name = "new_set";
            this.new_set.Size = new System.Drawing.Size(92, 41);
            this.new_set.TabIndex = 0;
            this.new_set.Text = "Создать 2 множества";
            this.new_set.UseVisualStyleBackColor = true;
            this.new_set.Click += new System.EventHandler(this.button1_Click);
            // 
            // add_set_1
            // 
            this.add_set_1.AutoSize = true;
            this.add_set_1.Location = new System.Drawing.Point(57, 34);
            this.add_set_1.Name = "add_set_1";
            this.add_set_1.Size = new System.Drawing.Size(190, 17);
            this.add_set_1.TabIndex = 1;
            this.add_set_1.TabStop = true;
            this.add_set_1.Text = "добавить элемент в множество ";
            this.add_set_1.UseVisualStyleBackColor = true;
            this.add_set_1.CheckedChanged += new System.EventHandler(this.add_set_1_CheckedChanged);
            // 
            // perform
            // 
            this.perform.Location = new System.Drawing.Point(57, 156);
            this.perform.Name = "perform";
            this.perform.Size = new System.Drawing.Size(75, 23);
            this.perform.TabIndex = 4;
            this.perform.Text = "Выполнить";
            this.perform.UseVisualStyleBackColor = true;
            this.perform.Click += new System.EventHandler(this.perform_Click);
            // 
            // intersection
            // 
            this.intersection.AutoSize = true;
            this.intersection.Location = new System.Drawing.Point(57, 57);
            this.intersection.Name = "intersection";
            this.intersection.Size = new System.Drawing.Size(144, 17);
            this.intersection.TabIndex = 5;
            this.intersection.TabStop = true;
            this.intersection.Text = "пересечение множеств";
            this.intersection.UseVisualStyleBackColor = true;
            this.intersection.CheckedChanged += new System.EventHandler(this.find_elem_CheckedChanged);
            // 
            // num_set
            // 
            this.num_set.Location = new System.Drawing.Point(57, 104);
            this.num_set.Name = "num_set";
            this.num_set.Size = new System.Drawing.Size(100, 20);
            this.num_set.TabIndex = 6;
            // 
            // label_num_set
            // 
            this.label_num_set.AutoSize = true;
            this.label_num_set.Location = new System.Drawing.Point(164, 110);
            this.label_num_set.Name = "label_num_set";
            this.label_num_set.Size = new System.Drawing.Size(594, 13);
            this.label_num_set.TabIndex = 7;
            this.label_num_set.Text = "Введите номер множества с которым хотите выполнить действие (только для добавлени" +
    "я элемента в множество)";
            // 
            // elem
            // 
            this.elem.Location = new System.Drawing.Point(57, 130);
            this.elem.Name = "elem";
            this.elem.Size = new System.Drawing.Size(100, 20);
            this.elem.TabIndex = 3;
            // 
            // label_elem_or_index
            // 
            this.label_elem_or_index.AutoSize = true;
            this.label_elem_or_index.Location = new System.Drawing.Point(164, 136);
            this.label_elem_or_index.Name = "label_elem_or_index";
            this.label_elem_or_index.Size = new System.Drawing.Size(344, 13);
            this.label_elem_or_index.TabIndex = 8;
            this.label_elem_or_index.Text = "Введите элемент (только для добавления элемента в множество)";
            this.label_elem_or_index.Click += new System.EventHandler(this.label_elem_or_index_Click);
            // 
            // association
            // 
            this.association.AutoSize = true;
            this.association.Location = new System.Drawing.Point(57, 81);
            this.association.Name = "association";
            this.association.Size = new System.Drawing.Size(146, 17);
            this.association.TabIndex = 9;
            this.association.TabStop = true;
            this.association.Text = "объединение множеств";
            this.association.UseVisualStyleBackColor = true;
            // 
            // list_set_1
            // 
            this.list_set_1.FormattingEnabled = true;
            this.list_set_1.Location = new System.Drawing.Point(70, 284);
            this.list_set_1.Name = "list_set_1";
            this.list_set_1.Size = new System.Drawing.Size(120, 95);
            this.list_set_1.TabIndex = 10;
            // 
            // list_set_2
            // 
            this.list_set_2.FormattingEnabled = true;
            this.list_set_2.Location = new System.Drawing.Point(638, 284);
            this.list_set_2.Name = "list_set_2";
            this.list_set_2.Size = new System.Drawing.Size(120, 95);
            this.list_set_2.TabIndex = 11;
            // 
            // list_set_res
            // 
            this.list_set_res.FormattingEnabled = true;
            this.list_set_res.Location = new System.Drawing.Point(360, 284);
            this.list_set_res.Name = "list_set_res";
            this.list_set_res.Size = new System.Drawing.Size(120, 95);
            this.list_set_res.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "1 множество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "2 множество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "множество с результатом";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_set_res);
            this.Controls.Add(this.list_set_2);
            this.Controls.Add(this.list_set_1);
            this.Controls.Add(this.association);
            this.Controls.Add(this.label_elem_or_index);
            this.Controls.Add(this.label_num_set);
            this.Controls.Add(this.num_set);
            this.Controls.Add(this.intersection);
            this.Controls.Add(this.perform);
            this.Controls.Add(this.elem);
            this.Controls.Add(this.add_set_1);
            this.Controls.Add(this.new_set);
            this.Name = "Form1";
            this.Text = "Множества";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button new_set;
        private System.Windows.Forms.RadioButton add_set_1;
        private System.Windows.Forms.Button perform;
        private System.Windows.Forms.RadioButton intersection;
        private System.Windows.Forms.TextBox num_set;
        private System.Windows.Forms.Label label_num_set;
        private System.Windows.Forms.TextBox elem;
        private System.Windows.Forms.Label label_elem_or_index;
        private System.Windows.Forms.RadioButton association;
        private System.Windows.Forms.ListBox list_set_1;
        private System.Windows.Forms.ListBox list_set_2;
        private System.Windows.Forms.ListBox list_set_res;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

