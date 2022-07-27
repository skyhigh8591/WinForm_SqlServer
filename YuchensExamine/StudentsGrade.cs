using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuchensExamine
{
    public partial class StudentsGrade : Form
    {



        private StudentsGradeController studentsGradeController;

        public StudentsGrade()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {

            studentsGradeController = new StudentsGradeController();

            textBoxName.Text = "Test";
            textBoxChinese.Text = "0";
            textBoxEnglish.Text = "0";
            textBoxMath.Text = "0";

            studentsGradeController.AddItem(ref listViewData);
        }

        private void TextBoxChinese_TextChanged(object sender, EventArgs e)
        {
            studentsGradeController.LimitSize(ref textBoxChinese);
        }

        private void TextBoxEnglish_TextChanged(object sender, EventArgs e)
        {
            studentsGradeController.LimitSize(ref textBoxEnglish);
        }

        private void TextBoxMath_TextChanged(object sender, EventArgs e)
        {
            studentsGradeController.LimitSize(ref textBoxMath);
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判斷輸入是否為數字
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            studentsGradeController.SetUserId(0);
            studentsGradeController.StatisticalOperations(true,ref textBoxName, ref textBoxChinese, ref textBoxEnglish, ref textBoxMath);
            studentsGradeController.AddItem(ref listViewData);

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            studentsGradeController.StatisticalOperations(false,ref textBoxName, ref textBoxChinese, ref textBoxEnglish, ref textBoxMath);
            studentsGradeController.AddItem(ref listViewData);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            studentsGradeController.DeleteLast();
            studentsGradeController.AddItem(ref listViewData);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            studentsGradeController.Clear(ref listViewData);
            studentsGradeController.AddItem(ref listViewData);
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            listBoxStatistics.Items.Clear();
            listBoxStatistics.Items.Add("項目" + "\t" + "國文" + "\t" + "英文" + "\t" + "數學");
            listBoxStatistics.Items.Add(studentsGradeController.SumList());
            listBoxStatistics.Items.Add(studentsGradeController.AvgList());
            listBoxStatistics.Items.Add(studentsGradeController.MaxList());
            listBoxStatistics.Items.Add(studentsGradeController.MinList());
            studentsGradeController.UpScore();
        }

        private void listViewData_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (listViewData.SelectedIndices != null && listViewData.SelectedIndices.Count > 0)
            {
                ListView.SelectedIndexCollection c = listViewData.SelectedIndices;
                studentsGradeController.SetUserId(Convert.ToInt32(listViewData.Items[c[0]].SubItems[0].Text));
                textBoxName.Text = listViewData.Items[c[0]].SubItems[1].Text;
                textBoxChinese.Text = listViewData.Items[c[0]].SubItems[2].Text;
                textBoxEnglish.Text = listViewData.Items[c[0]].SubItems[3].Text;
                textBoxMath.Text = listViewData.Items[c[0]].SubItems[4].Text;
            }
        }

    }
}
