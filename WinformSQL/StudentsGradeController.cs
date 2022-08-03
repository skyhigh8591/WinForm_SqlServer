using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuchensExamine
{
    class StudentsGradeController
    {


        private List<StudentsGradeData> viewData;
        private StudentsGradeModel studentsGradeModel;
        public int userId = 0;

        public StudentsGradeController()
        {
            studentsGradeModel = new StudentsGradeModel();
            viewData = new List<StudentsGradeData>();
            viewData = studentsGradeModel.SelectAll();
        }

        /// <summary>
        /// 判斷書入的數值有沒有超過100
        /// </summary>
        /// <param name="textBox"></param>
        public void LimitSize(ref TextBox textBox)
        {
            if (textBox.Text == " " || textBox.Text == "")
            {
                textBox.Text = "0";
            }
            int number = int.Parse(textBox.Text);
            textBox.Text = number.ToString();
            if (number <= 100)
            {
                return;
            }
            textBox.Text = textBox.Text.Remove(2);
            textBox.SelectionStart = textBox.Text.Length;
        }

        /// <summary>
        /// 輸出最大值 最小值 平均  與  加總
        /// </summary>
        /// <param name="_chinese"></param>
        /// <param name="_english"></param>
        /// <param name="_math"></param>
        public void StatisticalOperations(
            bool insert,
            ref TextBox textBoxName,
            ref TextBox textBoxChinese,
            ref TextBox textBoxEnglish,
            ref TextBox textBoxMath
            )
        {

            string name = textBoxName.Text;
            int chineseScore = Convert.ToInt32(textBoxChinese.Text);
            int englishScore = Convert.ToInt32(textBoxEnglish.Text);
            int mathScore = Convert.ToInt32(textBoxMath.Text);

            int totalScore = chineseScore + englishScore + mathScore;
            int average = totalScore / 3;

            int[] list = new int[] { chineseScore, englishScore, mathScore };
            int max = list.Max();
            int min = list.Min();

            StringBuilder maxStr = new StringBuilder();
            StringBuilder minStr = new StringBuilder();

            Dictionary<string, int> score = new Dictionary<string, int>();

            score.Add("國文", chineseScore);
            score.Add("英文", englishScore);
            score.Add("數學", mathScore);

            foreach (var scoreKey in score.Where(x => x.Value == max))
            {
                maxStr.Append($"{scoreKey.Key} ");
            }

            foreach (var scoreKey in score.Where(x => x.Value == min))
            {
                minStr.Append($"{scoreKey.Key} ");
            }

            if (insert)
            {
                studentsGradeModel.Insert(new StudentsGradeData()
                {
                    Name = name,
                    Chinese = chineseScore,
                    Math = mathScore,
                    English = englishScore,
                    TotalScore = totalScore,
                    Average = average,
                    MaxStr = maxStr.ToString(),
                    MinStr = minStr.ToString(),
                    Max = max,
                    Min = min
                });
            }
            else
            {
                studentsGradeModel.Update(new StudentsGradeData()
                {
                    Name = name,
                    Chinese = chineseScore,
                    Math = mathScore,
                    English = englishScore,
                    TotalScore = totalScore,
                    Average = average,
                    MaxStr = maxStr.ToString(),
                    MinStr = minStr.ToString(),
                    Max = max,
                    Min = min
                },userId);
            }

            viewData = studentsGradeModel.SelectAll();
        }

        /// <summary>
        /// 刪除最後一筆資料
        /// </summary>
        public void DeleteLast()
        {
            if (viewData.Count == 0)
            {
                return;
            }
            studentsGradeModel.Remove( Convert.ToInt32( viewData[(viewData.Count - 1)].Id ) );
            viewData = studentsGradeModel.SelectAll();
        }

        /// <summary>
        /// 刪除全部的資料
        /// </summary>
        /// <param name="listViewData"></param>
        public void Clear(ref ListView listViewData)
        {
            studentsGradeModel.Identity();
            studentsGradeModel.Delete();
            viewData = studentsGradeModel.SelectAll();
        }

        /// <summary>
        /// 將數值顯示在 listView
        /// </summary>
        /// <param name="listViewData"></param>
        public void AddItem(ref ListView listViewData)
        {
            listViewData.Items.Clear();

            foreach (var addDate in viewData)
            {
                ListViewItem list = new ListViewItem();

                list.Text = addDate.Id;
                list.SubItems.Add(addDate.Name.ToString());
                list.SubItems.Add(addDate.Chinese.ToString());
                list.SubItems.Add(addDate.English.ToString());
                list.SubItems.Add(addDate.Math.ToString());
                list.SubItems.Add(addDate.TotalScore.ToString());
                list.SubItems.Add(addDate.Average.ToString());
                list.SubItems.Add(addDate.MaxStr + addDate.Max);
                list.SubItems.Add(addDate.MinStr + addDate.Min);

                listViewData.Items.Add(list);
            }
        }

        /// <summary>
        /// 計算加總
        /// </summary>
        /// <returns></returns>
        public StringBuilder SumList()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"總分\t");
            stringBuilder.Append(viewData.Count > 0 ? $"{viewData.Sum(x => x.Chinese)}\t" : "0\t");
            stringBuilder.Append(viewData.Count > 0 ? $"{viewData.Sum(x => x.English)}\t" : "0\t");
            stringBuilder.Append(viewData.Count > 0 ? $"{viewData.Sum(x => x.Math)}\t" : "0\t");
            return stringBuilder;
        }

        /// <summary>
        /// 計算平均
        /// </summary>
        /// <returns></returns>
        public StringBuilder AvgList()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"平均\t");
            stringBuilder.Append(viewData.Count > 0 ? $"{Math.Round(viewData.Average(x => x.Chinese), 0)}\t" : "0\t");
            stringBuilder.Append(viewData.Count > 0 ? $"{Math.Round(viewData.Average(x => x.English), 0)}\t" : "0\t");
            stringBuilder.Append(viewData.Count > 0 ? $"{Math.Round(viewData.Average(x => x.Math), 0)}\t" : "0\t");
            return stringBuilder;
        }

        /// <summary>
        /// 計算最大值
        /// </summary>
        /// <returns></returns>
        public StringBuilder MaxList()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"最大\t");
            stringBuilder.Append(viewData.Count > 0 ? $"{viewData.Max(x => x.Chinese)}\t" : "0\t");
            stringBuilder.Append(viewData.Count > 0 ? $"{viewData.Max(x => x.English)}\t" : "0\t");
            stringBuilder.Append(viewData.Count > 0 ? $"{viewData.Max(x => x.Math)}\t" : "0\t");
            return stringBuilder;
        }

        /// <summary>
        /// 計算最小值
        /// </summary>
        /// <returns></returns>
        public StringBuilder MinList()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"最小\t");
            stringBuilder.Append(viewData.Count > 0 ? $"{viewData.Min(x => x.Chinese)}\t" : "0\t");
            stringBuilder.Append(viewData.Count > 0 ? $"{viewData.Min(x => x.English)}\t" : "0\t");
            stringBuilder.Append(viewData.Count > 0 ? $"{viewData.Min(x => x.Math)}\t" : "0\t");
            return stringBuilder;
        }

        /// <summary>
        /// 更換UserId
        /// </summary>
        /// <param name="id"></param>
        public void SetUserId(int id)
        {
            userId = id;
        }

 
        public void UpScore()
        {
            studentsGradeModel.ScoreUpdare(ref viewData);
        }

    }
}
