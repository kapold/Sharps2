using System.ComponentModel;

namespace LW2;

partial class SearchForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        this.label3 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.label4 = new System.Windows.Forms.Label();
        this.searchFIO = new System.Windows.Forms.TextBox();
        this.button1 = new System.Windows.Forms.Button();
        this.label5 = new System.Windows.Forms.Label();
        this.searchSpec = new System.Windows.Forms.ComboBox();
        this.regexBox = new System.Windows.Forms.TextBox();
        this.searchCourse = new System.Windows.Forms.ComboBox();
        this.label1 = new System.Windows.Forms.Label();
        this.searchMark = new System.Windows.Forms.TrackBar();
        this.button2 = new System.Windows.Forms.Button();
        this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.searchTable = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize) (this.searchMark)).BeginInit();
        ((System.ComponentModel.ISupportInitialize) (this.searchTable)).BeginInit();
        this.SuspendLayout();
        // 
        // label3
        // 
        this.label3.AutoSize = true;
        this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
        this.label3.Location = new System.Drawing.Point(873, 92);
        this.label3.Name = "label3";
        this.label3.Size = new System.Drawing.Size(145, 20);
        this.label3.TabIndex = 70;
        this.label3.Text = "Специальность:";
        // 
        // label2
        // 
        this.label2.AutoSize = true;
        this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
        this.label2.Location = new System.Drawing.Point(873, 28);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(54, 20);
        this.label2.TabIndex = 69;
        this.label2.Text = "ФИО:";
        // 
        // label4
        // 
        this.label4.AutoSize = true;
        this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
        this.label4.Location = new System.Drawing.Point(873, 154);
        this.label4.Name = "label4";
        this.label4.Size = new System.Drawing.Size(52, 20);
        this.label4.TabIndex = 71;
        this.label4.Text = "Курс:";
        // 
        // searchFIO
        // 
        this.searchFIO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
        this.searchFIO.Location = new System.Drawing.Point(877, 51);
        this.searchFIO.Name = "searchFIO";
        this.searchFIO.Size = new System.Drawing.Size(233, 30);
        this.searchFIO.TabIndex = 72;
        // 
        // button1
        // 
        this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
        this.button1.Location = new System.Drawing.Point(877, 557);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(233, 57);
        this.button1.TabIndex = 69;
        this.button1.Text = "Поиск";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.SearchButton);
        // 
        // label5
        // 
        this.label5.AutoSize = true;
        this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
        this.label5.Location = new System.Drawing.Point(873, 215);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(133, 20);
        this.label5.TabIndex = 73;
        this.label5.Text = "Средний балл:";
        // 
        // searchSpec
        // 
        this.searchSpec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.searchSpec.FormattingEnabled = true;
        this.searchSpec.Items.AddRange(new object[] {"ПОИБМС", "ПОИТ", "ИСИТ", "ДЭВИ"});
        this.searchSpec.Location = new System.Drawing.Point(877, 115);
        this.searchSpec.Name = "searchSpec";
        this.searchSpec.Size = new System.Drawing.Size(233, 24);
        this.searchSpec.TabIndex = 74;
        // 
        // regexBox
        // 
        this.regexBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
        this.regexBox.Location = new System.Drawing.Point(877, 350);
        this.regexBox.Multiline = true;
        this.regexBox.Name = "regexBox";
        this.regexBox.Size = new System.Drawing.Size(233, 30);
        this.regexBox.TabIndex = 69;
        // 
        // searchCourse
        // 
        this.searchCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        this.searchCourse.FormattingEnabled = true;
        this.searchCourse.Items.AddRange(new object[] {"1", "2", "3", "4"});
        this.searchCourse.Location = new System.Drawing.Point(877, 177);
        this.searchCourse.Name = "searchCourse";
        this.searchCourse.Size = new System.Drawing.Size(233, 24);
        this.searchCourse.TabIndex = 75;
        // 
        // label1
        // 
        this.label1.AutoSize = true;
        this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
        this.label1.Location = new System.Drawing.Point(950, 327);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(160, 20);
        this.label1.TabIndex = 70;
        this.label1.Text = "Диапазон оценок:";
        // 
        // searchMark
        // 
        this.searchMark.Location = new System.Drawing.Point(877, 246);
        this.searchMark.Name = "searchMark";
        this.searchMark.Size = new System.Drawing.Size(233, 56);
        this.searchMark.TabIndex = 76;
        // 
        // button2
        // 
        this.button2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
        this.button2.Location = new System.Drawing.Point(877, 482);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(233, 57);
        this.button2.TabIndex = 69;
        this.button2.Text = "Regex поиск";
        this.button2.UseVisualStyleBackColor = true;
        this.button2.Click += new System.EventHandler(this.RegexButton);
        // 
        // dataGridViewTextBoxColumn8
        // 
        this.dataGridViewTextBoxColumn8.HeaderText = "Address";
        this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
        this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
        this.dataGridViewTextBoxColumn8.ReadOnly = true;
        this.dataGridViewTextBoxColumn8.Width = 140;
        // 
        // dataGridViewTextBoxColumn7
        // 
        this.dataGridViewTextBoxColumn7.HeaderText = "Male";
        this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
        this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
        this.dataGridViewTextBoxColumn7.ReadOnly = true;
        this.dataGridViewTextBoxColumn7.Width = 80;
        // 
        // dataGridViewTextBoxColumn6
        // 
        this.dataGridViewTextBoxColumn6.HeaderText = "AverMark";
        this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
        this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
        this.dataGridViewTextBoxColumn6.ReadOnly = true;
        this.dataGridViewTextBoxColumn6.Width = 80;
        // 
        // dataGridViewTextBoxColumn5
        // 
        this.dataGridViewTextBoxColumn5.HeaderText = "Group";
        this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
        this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
        this.dataGridViewTextBoxColumn5.ReadOnly = true;
        this.dataGridViewTextBoxColumn5.Width = 70;
        // 
        // dataGridViewTextBoxColumn4
        // 
        this.dataGridViewTextBoxColumn4.HeaderText = "Course";
        this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
        this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
        this.dataGridViewTextBoxColumn4.ReadOnly = true;
        this.dataGridViewTextBoxColumn4.Width = 70;
        // 
        // dataGridViewTextBoxColumn3
        // 
        this.dataGridViewTextBoxColumn3.HeaderText = "Birthday";
        this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
        this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        this.dataGridViewTextBoxColumn3.ReadOnly = true;
        this.dataGridViewTextBoxColumn3.Width = 120;
        // 
        // dataGridViewTextBoxColumn2
        // 
        this.dataGridViewTextBoxColumn2.HeaderText = "Speciality";
        this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
        this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        this.dataGridViewTextBoxColumn2.ReadOnly = true;
        this.dataGridViewTextBoxColumn2.Width = 70;
        // 
        // dataGridViewTextBoxColumn1
        // 
        this.dataGridViewTextBoxColumn1.HeaderText = "Name";
        this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
        this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        this.dataGridViewTextBoxColumn1.ReadOnly = true;
        this.dataGridViewTextBoxColumn1.Width = 140;
        // 
        // searchTable
        // 
        this.searchTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        this.searchTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.searchTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.dataGridViewTextBoxColumn1, this.dataGridViewTextBoxColumn2, this.dataGridViewTextBoxColumn3, this.dataGridViewTextBoxColumn4, this.dataGridViewTextBoxColumn5, this.dataGridViewTextBoxColumn6, this.dataGridViewTextBoxColumn7, this.dataGridViewTextBoxColumn8});
        this.searchTable.Location = new System.Drawing.Point(25, 28);
        this.searchTable.Name = "searchTable";
        this.searchTable.RowHeadersVisible = false;
        this.searchTable.RowHeadersWidth = 51;
        this.searchTable.RowTemplate.Height = 24;
        this.searchTable.Size = new System.Drawing.Size(789, 586);
        this.searchTable.TabIndex = 69;
        // 
        // SearchForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.SystemColors.Control;
        this.ClientSize = new System.Drawing.Size(1152, 648);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.searchMark);
        this.Controls.Add(this.label1);
        this.Controls.Add(this.searchCourse);
        this.Controls.Add(this.regexBox);
        this.Controls.Add(this.searchSpec);
        this.Controls.Add(this.label5);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.searchFIO);
        this.Controls.Add(this.searchTable);
        this.Controls.Add(this.label4);
        this.Controls.Add(this.label2);
        this.Controls.Add(this.label3);
        this.Location = new System.Drawing.Point(15, 15);
        this.Name = "SearchForm";
        ((System.ComponentModel.ISupportInitialize) (this.searchMark)).EndInit();
        ((System.ComponentModel.ISupportInitialize) (this.searchTable)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox searchFIO;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.ComboBox searchSpec;
    private System.Windows.Forms.TextBox regexBox;
    private System.Windows.Forms.ComboBox searchCourse;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TrackBar searchMark;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private System.Windows.Forms.DataGridView searchTable;

    private System.Windows.Forms.ComboBox comboBox1;
    private System.Windows.Forms.TextBox textBox2;
    private System.Windows.Forms.ComboBox comboBox2;
    private System.Windows.Forms.TrackBar trackBar1;

    #endregion
}