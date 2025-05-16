﻿namespace Chapter1;


// ------------------------------------------------------------------------------------------------ //
//                                         Nullable                                                 //
// ------------------------------------------------------------------------------------------------ //
public static class Nullable
{
    public static void NullableTesting()
    {
        int? age = 34;
        float? note = 5.5f;
        Nullable<bool> isAccepted = null;

        if (age != null){Console.WriteLine(age.Value);}
        if (note.HasValue){Console.WriteLine(note.Value);}

        // If age is !null it's assigned to chosenAge, else 18 is used
        int chosenAge = age ?? 18;
        if (age != null) {Console.WriteLine(chosenAge);}
        
        // If note is !null it's assigned to shownNote, else 5.0f is assigned
        float shownNote = note.GetValueOrDefault(5.0f);
        // If default value was assigned do something
        if (shownNote == 5.0f) {Console.WriteLine(shownNote + 10.0f);}
        else {Console.WriteLine(shownNote);} // Otherwise display our shownNote
        
        DateTime date = new(1988, 11, 9);
        int? age2 = GetAgeFromBirthDate(date);
        Console.WriteLine(age2);
        
        // Null-coalescing assignment operator ??=
        age ??= 18;
        Console.WriteLine(age);
        
        // Null conditional operator ?.
        string? GetFormatted(float? number) => number?.ToString("F2");
        
        
        return;
    }

    public static int? GetAgeFromBirthDate(DateTime date)
    {
        // DateTime minus a date creates a TimeSpan object with a TotalDays method that returns a float 
        double days = (DateTime.Now - date).TotalDays;
        // using a conditional ternary operator: condition ? valueIfTrue : valueIfFalse
        // also using the order of operations so that we cast our resulting answer
        return days > 0 ? (int) (days / 365) : null;
        // the problem is even if we had 364.2 and did integer division after flooring
        // 364 / 365 would equal 0 using integer division
    }
}
