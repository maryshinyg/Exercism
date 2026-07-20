public static class LineUp
{
    public static string Format(string name, int number)
    {
        int lastTwo = number%100;
        if(lastTwo == 11 || lastTwo == 12 || lastTwo == 13){
            return $"{name}, you are the {number}th customer we serve today. Thank you!";
        }
        int lastNum = number%10;
        if(lastNum == 1)return $"{name}, you are the {number}st customer we serve today. Thank you!";
        if(lastNum == 2) return $"{name}, you are the {number}nd customer we serve today. Thank you!";
        if(lastNum == 3) return $"{name}, you are the {number}rd customer we serve today. Thank you!";
        else return $"{name}, you are the {number}th customer we serve today. Thank you!";
    }
}
