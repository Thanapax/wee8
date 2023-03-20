class program{
    public static string InputName(){
        Console.Write("Input Name : ");

        return Console.ReadLine();
    }
    public static string InputScore(){
        Console.Write("Input Score : ");

        return Console.ReadLine();
    }
    public static void PrintInputInformation(string name, string inputScore, string grade){
        Console.WriteLine();
        Console.WriteLine("***************************************");
        Console.WriteLine("Name is {0}", name);
        Console.WriteLine("Score is {0}", inputScore);
        Console.WriteLine("Grade is {0}", grade);
        Console.WriteLine("***************************************");
        Console.WriteLine();
    }
    public static string ConvertScoreToGrade(int score){
        if(score > 100) { throw new Exception("Please input data 0 - 100");}

        if(isGradeA(score)){
            return "Grade A";
        } else if (isGradeBPlus(score)){
            return "Grade B+";
        } else if (isGradeB(score)){
            return "Grade B";
        } else if (isGradeCPlus(score)){
            return "Grade C+";
        } else if (isGradeC(score)){
            return "Grade C";
        } else if (isGradeDPlus(score)){
            return "Grade D+";
        } else if (isGradeD(score)){
            return "Grade D";
        } else {
            return "Grade F";
        }
    }
    public static bool isGradeA(int score){
        return (score <= 100 && score >= 80) ? true : false;
    }
    public static bool isGradeBPlus(int score){
        return (score < 80 && score >= 75);
    }
    public static bool isGradeB(int score){
        if (score < 75 && score >= 70){
            return true;
        }
        return false;
    }
    public static bool isGradeCPlus(int score){
        return score < 70 && score >= 65;
    }
    public static bool isGradeC(int score){
        return score < 65 && score >= 60;
    }
    public static bool isGradeDPlus(int score){
        return score < 60 && score >= 55;
    }
    public static bool isGradeD(int score){
        return score < 55 && score >= 50;
    }
    static void Main(string[] args){
        string name = InputName();
        string scoreString = InputScore();
        int score = int.Parse(Console.ReadLine());
        string grade = ConvertScoreToGrade(score);

        PrintInputInformation(name, scoreString, grade);
    }
}