using IUP_BMI_Calculator.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IUP_BMI_Calculator.Repository
{
    public class BMIResultRepository
    {
        string _dbPath;

        SQLiteConnection conn;

        private void Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteConnection(_dbPath);
            conn.CreateTable<BMIResult>();
        }

        public BMIResultRepository(string dbPath)
        {
            _dbPath = dbPath;
        }

        public void AddNewBMIResult(string name, double height, double weight, double BMIScore, string Result)
        {
            Init();

            BMIResult bmiResult = new BMIResult();
            bmiResult.Name = name;
            bmiResult.Height = height;
            bmiResult.Weight = weight;
            bmiResult.BMIScore = BMIScore;
            bmiResult.Result = Result;

            conn.Insert(bmiResult);
        }
    }
}
