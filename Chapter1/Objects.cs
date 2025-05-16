namespace Chapter1;

public class Objects
{
    /*
     * Everything in C# derives from Object
     * The Object class is declared in the System namespace
     * This creates a unified type system where all built-in
     * types derive from the Object class
     * A few methods that are available to all objects:
     *  ToString()    - Returns a string representation of the object
     *  GetType()     - Returns a type of the instance
     *  Equals()      - Checks whether the object is equal to a given object
     *  GetHashCode() - Uses the hash function and returns its result
     */
    public static void ObjectsDemo()
    {
        int age = 28;
        object ageBoxing = age;
        int ageUnboxing = (int)ageBoxing;
    }
}