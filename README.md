# FRAMEWORK PROGRAMMING MIDTERM IUP

Muhammad Fatih AKbar</br>
502521117

----

## 1. Complete the Model\BMIResult.cs class.

This class should represent the columns on the table (id, name, heigh, weight, BMI Score, and Result).

```cs
    public class BMIResult
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int Id { get; set; }

        public string Name { get; set; }

        public double Height{ get; set; }

        public double Weight { get; set; }

        public double BMIScore { get; set; }

        public string Result { get; set; }

    }
```

## 2. Complete the Repository\BMIResultRepository.cs class so it can be used to save the data to database.

```cs
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
```

## 3. Complete the ViewModel\BMICalculatorViewModel.cs so it can be used for handling data input inside the view.

```cs
        [RelayCommand]
        public void Save(string dbpath)
        {
            try
            {
                BMIResultRepository bmiResultRepository = new BMIResultRepository(dbpath);
                bmiResultRepository.AddNewBMIResult(name, height, weight, BMIScore, BMIResult);
            }
            catch (Exception ex)
            {
                
            }

        }

        [RelayCommand]
        public void Clear(string dbpath)
        {
            // TODO
            name = "";
            height = 0;
            weight = 0;
        }
```

## 4. MainPage.xaml

a. Use the appropriate xmlns:local to import the view models

b. Change the Ɵtle into: “BMI Calculator Page”

c. Check all the bindings and make sure that your input can bind properly.

```xaml
xmlns:local="clr-namespace:IUP_BMI_Calculator.ViewModel"
Title="BMI Calculator Page">
```

## 5. MainPage.xaml.cs

Use the appropriate ViewModels as BindingContext

```cs
	public MainPage()
	{
		InitializeComponent();
        this.BindingContext = new BMICalculatorViewModel();
    }
```

## 6. MauiProgram.cs

a. Add the dbPath variable declaraƟon for SQLite database. Use this file name format: BMIResult_StudentID_Name.db3

b. Add BMIResultRepository into builder.Services

## 7. App.xaml.cs

a. Add the BMIResultRepository as a property and iniƟalize it inside the constructor.