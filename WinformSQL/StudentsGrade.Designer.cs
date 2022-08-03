
namespace YuchensExamine
{
    partial class StudentsGrade
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelChinese = new System.Windows.Forms.Label();
            this.labelEnglish = new System.Windows.Forms.Label();
            this.labelMath = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxChinese = new System.Windows.Forms.TextBox();
            this.textBoxEnglish = new System.Windows.Forms.TextBox();
            this.textBoxMath = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRevise = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.listViewData = new System.Windows.Forms.ListView();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.listBoxStatistics = new System.Windows.Forms.ListBox();
            this.buttonStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(37, 33);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(69, 26);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "姓名 : ";
            // 
            // labelChinese
            // 
            this.labelChinese.AutoSize = true;
            this.labelChinese.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelChinese.Location = new System.Drawing.Point(37, 81);
            this.labelChinese.Name = "labelChinese";
            this.labelChinese.Size = new System.Drawing.Size(69, 26);
            this.labelChinese.TabIndex = 1;
            this.labelChinese.Text = "國文 : ";
            // 
            // labelEnglish
            // 
            this.labelEnglish.AutoSize = true;
            this.labelEnglish.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEnglish.Location = new System.Drawing.Point(37, 129);
            this.labelEnglish.Name = "labelEnglish";
            this.labelEnglish.Size = new System.Drawing.Size(69, 26);
            this.labelEnglish.TabIndex = 2;
            this.labelEnglish.Text = "英文 : ";
            // 
            // labelMath
            // 
            this.labelMath.AutoSize = true;
            this.labelMath.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMath.Location = new System.Drawing.Point(37, 177);
            this.labelMath.Name = "labelMath";
            this.labelMath.Size = new System.Drawing.Size(69, 26);
            this.labelMath.TabIndex = 3;
            this.labelMath.Text = "數學 : ";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxName.Location = new System.Drawing.Point(112, 30);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(119, 34);
            this.textBoxName.TabIndex = 4;
            // 
            // textBoxChinese
            // 
            this.textBoxChinese.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxChinese.Location = new System.Drawing.Point(112, 78);
            this.textBoxChinese.Name = "textBoxChinese";
            this.textBoxChinese.Size = new System.Drawing.Size(119, 34);
            this.textBoxChinese.TabIndex = 5;
            this.textBoxChinese.TextChanged += new System.EventHandler(this.TextBoxChinese_TextChanged);
            this.textBoxChinese.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // textBoxEnglish
            // 
            this.textBoxEnglish.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxEnglish.Location = new System.Drawing.Point(112, 126);
            this.textBoxEnglish.Name = "textBoxEnglish";
            this.textBoxEnglish.Size = new System.Drawing.Size(119, 34);
            this.textBoxEnglish.TabIndex = 6;
            this.textBoxEnglish.TextChanged += new System.EventHandler(this.TextBoxEnglish_TextChanged);
            this.textBoxEnglish.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // textBoxMath
            // 
            this.textBoxMath.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxMath.Location = new System.Drawing.Point(112, 174);
            this.textBoxMath.Name = "textBoxMath";
            this.textBoxMath.Size = new System.Drawing.Size(119, 34);
            this.textBoxMath.TabIndex = 7;
            this.textBoxMath.TextChanged += new System.EventHandler(this.TextBoxMath_TextChanged);
            this.textBoxMath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(47, 328);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(163, 32);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "加入學生資料";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRevise
            // 
            this.buttonRevise.Location = new System.Drawing.Point(47, 382);
            this.buttonRevise.Name = "buttonRevise";
            this.buttonRevise.Size = new System.Drawing.Size(163, 32);
            this.buttonRevise.TabIndex = 9;
            this.buttonRevise.Text = "更新儲存資料";
            this.buttonRevise.UseVisualStyleBackColor = true;
            this.buttonRevise.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(47, 438);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(163, 32);
            this.buttonDelete.TabIndex = 10;
            this.buttonDelete.Text = "移除資料";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(47, 493);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(163, 32);
            this.buttonClear.TabIndex = 11;
            this.buttonClear.Text = "清除所有資料";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // listViewData
            // 
            this.listViewData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader9,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listViewData.FullRowSelect = true;
            this.listViewData.GridLines = true;
            this.listViewData.HideSelection = false;
            this.listViewData.Location = new System.Drawing.Point(274, 30);
            this.listViewData.MultiSelect = false;
            this.listViewData.Name = "listViewData";
            this.listViewData.Size = new System.Drawing.Size(983, 339);
            this.listViewData.TabIndex = 17;
            this.listViewData.UseCompatibleStateImageBehavior = false;
            this.listViewData.View = System.Windows.Forms.View.Details;
            this.listViewData.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewData_ItemSelectionChanged);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "座號";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "姓名";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "國文";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "英文";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "數學";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "總分";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "平均";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "最高";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 140;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "最低";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 140;
            // 
            // listBoxStatistics
            // 
            this.listBoxStatistics.FormattingEnabled = true;
            this.listBoxStatistics.ItemHeight = 15;
            this.listBoxStatistics.Location = new System.Drawing.Point(274, 402);
            this.listBoxStatistics.Name = "listBoxStatistics";
            this.listBoxStatistics.Size = new System.Drawing.Size(992, 124);
            this.listBoxStatistics.TabIndex = 18;
            // 
            // buttonStatistics
            // 
            this.buttonStatistics.Location = new System.Drawing.Point(1084, 551);
            this.buttonStatistics.Name = "buttonStatistics";
            this.buttonStatistics.Size = new System.Drawing.Size(182, 33);
            this.buttonStatistics.TabIndex = 19;
            this.buttonStatistics.Text = "統計";
            this.buttonStatistics.UseVisualStyleBackColor = true;
            this.buttonStatistics.Click += new System.EventHandler(this.buttonStatistics_Click);
            // 
            // StudentsGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 610);
            this.Controls.Add(this.buttonStatistics);
            this.Controls.Add(this.listBoxStatistics);
            this.Controls.Add(this.listViewData);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonRevise);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxMath);
            this.Controls.Add(this.textBoxEnglish);
            this.Controls.Add(this.textBoxChinese);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelMath);
            this.Controls.Add(this.labelEnglish);
            this.Controls.Add(this.labelChinese);
            this.Controls.Add(this.labelName);
            this.Name = "StudentsGrade";
            this.Text = "StudentsGrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelChinese;
        private System.Windows.Forms.Label labelEnglish;
        private System.Windows.Forms.Label labelMath;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxChinese;
        private System.Windows.Forms.TextBox textBoxEnglish;
        private System.Windows.Forms.TextBox textBoxMath;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRevise;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.ListView listViewData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListBox listBoxStatistics;
        private System.Windows.Forms.Button buttonStatistics;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}

