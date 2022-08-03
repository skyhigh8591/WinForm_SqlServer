using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace YuchensExamine
{
    /// <summary>
    /// ListView 資料
    /// </summary>
    public class StudentsGradeModel
    {
        private SqlConnection connection;

        public StudentsGradeModel()
        {
            //連接對象
            connection = new SqlConnection();

            //連線字串
            connection.ConnectionString = "Data Source=192.168.2.198,8080;Initial Catalog=student;Persist Security Info=True;User ID=sa;Password=12345678";

            //建立連接
            connection.Open();

            Debug.WriteLine("輸出提示");
            //輸出提示
            if (connection.State == System.Data.ConnectionState.Open)
            {
                Debug.WriteLine("連線成功");
                connection.Close();
            }

        }

        /// <summary>
        /// 取得資料庫全部的資料
        /// </summary>
        /// <returns></returns>
        public List<StudentsGradeData> SelectAll()
        {
            connection.Open();
            String sqlString = $@"SELECT * FROM student_data";
            SqlCommand command = new SqlCommand(sqlString, connection);

            SqlDataReader result = command.ExecuteReader();

            List<StudentsGradeData> viewData = new List<StudentsGradeData>();

            while (result.Read())
            {
                StudentsGradeData studentsGradeData = new StudentsGradeData();

                studentsGradeData.Id = result["studnet_id"].ToString();
                studentsGradeData.Name = result["studnet_name"].ToString();
                studentsGradeData.Chinese = Convert.ToInt32(result["studnet_chinese"]);
                studentsGradeData.English = Convert.ToInt32(result["studnet_english"]);
                studentsGradeData.Math = Convert.ToInt32(result["studnet_math"]);
                studentsGradeData.TotalScore = Convert.ToInt32(result["studnet_total"]);
                studentsGradeData.Average = Convert.ToInt32(result["studnet_avg"]);
                studentsGradeData.MaxStr = result["studnet_maxstr"].ToString();
                studentsGradeData.Max = Convert.ToInt32(result["studnet_max"]);
                studentsGradeData.MinStr = result["studnet_minstr"].ToString();
                studentsGradeData.Min = Convert.ToInt32(result["studnet_min"]);

                viewData.Add(studentsGradeData);
            }

            connection.Close();

            return viewData;
        }

        /// <summary>
        /// 新增一筆資料
        /// </summary>
        /// <param name="studentsGradeData"></param>
        public void Insert(StudentsGradeData studentsGradeData)
        {
            connection.Open();
            String sqlString = $@" INSERT INTO student_data(
                    studnet_name,
                    studnet_chinese,
                    studnet_english,
                    studnet_math,
                    studnet_total,
                    studnet_avg,
                    studnet_maxstr,
                    studnet_max,
                    studnet_minstr,
                    studnet_min
                    )
                    VALUES(
                    '{studentsGradeData.Name}',
                    '{studentsGradeData.Chinese}',
                    '{studentsGradeData.English}',
                    '{studentsGradeData.Math}',
                    '{studentsGradeData.TotalScore}',
                    '{studentsGradeData.Average}',
                    '{studentsGradeData.MaxStr}',
                    '{studentsGradeData.Max}',
                    '{studentsGradeData.MinStr}',
                    '{studentsGradeData.Min}'
                    )";
            SqlCommand command = new SqlCommand(sqlString, connection);

            int result = command.ExecuteNonQuery();

            connection.Close();
        }

        public void Update(StudentsGradeData studentsGradeData , int userId)
        {
            connection.Open();
            String sqlString = $@"UPDATE student_data SET
                    studnet_name = '{studentsGradeData.Name}',
                    studnet_chinese = '{studentsGradeData.Chinese}',
                    studnet_english = '{studentsGradeData.English}',
                    studnet_math = '{studentsGradeData.Math}',
                    studnet_total = '{studentsGradeData.TotalScore}',
                    studnet_avg = '{studentsGradeData.Average}',
                    studnet_maxstr = '{studentsGradeData.MaxStr}',
                    studnet_max = '{studentsGradeData.Max}',
                    studnet_minstr = '{studentsGradeData.MinStr}',
                    studnet_min = '{studentsGradeData.Min}'
                    WHERE studnet_id = '{userId}'";

            SqlCommand command = new SqlCommand(sqlString, connection);

            int result = command.ExecuteNonQuery();

            connection.Close();
        }

        public void Remove(int userId)
        {
            connection.Open();
            String sqlString = $@"DELETE  FROM student_data WHERE studnet_id = '{userId}'";

            SqlCommand command = new SqlCommand(sqlString, connection);

            int result = command.ExecuteNonQuery();

            connection.Close();
        }

        public void Delete()
        {
            connection.Open();
            String sqlString = $@"DELETE FROM student_data";

            SqlCommand command = new SqlCommand(sqlString, connection);

            int result = command.ExecuteNonQuery();

            connection.Close();
        }

        public void Identity()
        {
            connection.Open();
         
            SqlCommand command = new SqlCommand();
         
            command = new SqlCommand("DBCC CHECKIDENT('student_data', RESEED, 0)", connection);

            int result = command.ExecuteNonQuery();

            connection.Close();
        }

        public void ScoreUpdare(ref List<StudentsGradeData> viewData)
        {
            connection.Open();

            String sqlString = $@"UPDATE score_data SET
                    score_total = '{viewData.Sum(x => x.Chinese)}',
                    score_avg = '{Math.Round(viewData.Average(x => x.Chinese),0)}',
                    score_max = '{viewData.Max(x => x.Chinese)}',
                    score_min = '{viewData.Min(x => x.Chinese)}'
                    WHERE score_id = 'Chinese'";

            SqlCommand command = new SqlCommand(sqlString, connection);

            int result = command.ExecuteNonQuery();

             sqlString = $@"UPDATE score_data SET
                    score_total = '{viewData.Sum(x => x.English)}',
                    score_avg = '{Math.Round(viewData.Average(x => x.English),0)}',
                    score_max = '{viewData.Max(x => x.English)}',
                    score_min = '{viewData.Min(x => x.English)}'
                    WHERE score_id = 'English'";

             command = new SqlCommand(sqlString, connection);

             result = command.ExecuteNonQuery();


             sqlString = $@"UPDATE score_data SET
                    score_total = '{viewData.Sum(x => x.Math)}',
                    score_avg = '{Math.Round(viewData.Average(x => x.Math),0)}',
                    score_max = '{viewData.Max(x => x.Math)}',
                    score_min = '{viewData.Min(x => x.Math)}'
                    WHERE score_id = 'Math'";

             command = new SqlCommand(sqlString, connection);

             result = command.ExecuteNonQuery();

            connection.Close();
        }




    }
}
