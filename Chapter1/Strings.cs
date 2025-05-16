namespace Chapter1;

public class Strings
{
    /*
     * A string can be set to a sequence of characters, a single char, an empty string, and null
     * Concatenation x + y is how you can perform operations on strings, duh!
     * You can access a character in a string using []
     */
    
    public static void StringsDemo()
    {
        string firstName = "Syn", lastName = "opsik"; // Same data types can be called on a single line
        int year = 6009;
        string note = firstName + " " + lastName.ToUpper() + " was born in " + year;
        string initials = firstName[0] + "." + lastName[0].ToString().ToUpper() + ".";
        
        Console.WriteLine(note);
        Console.WriteLine(initials);
        
        // Formatting can be used to construct a string with parameters
        string formatNote = string.Format("{0}{1} was born in {2}", firstName, lastName, year);
        Console.WriteLine(formatNote);
    }
    
}