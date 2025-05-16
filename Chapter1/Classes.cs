namespace Chapter1;

public class Classes
{
    /*
     * C# is an object-oriented language that supports declaring classes with various members like,
     * constructors, finalizers, constants, fields, properties, indexers, events, methods, operators, and delegates
     *
     * Classes in C# also support inheritance and implementing interfaces
     * static, abstract, sealed, and virtual members are also available
     * access modifiers include public, protected, internal, private, and file
     *
     * Accessors: get to return the property value
     *            set to assign a new value for the property
     *            init to set a value during object construction and prevent modifications
     *
     * By combining accessor we can create permissions categories:
     *           Read-only with the get accessor and without the set accessor
     *           Write-only with the set accessor and without the get accessor
     *           Read-write with both get and set accessors
     */
    public class Person
    {
        private string _location = string.Empty;
        
        public string Name { get; set; } // getter & setter setup Name & Age
        public required int Age { get; set; }

        // Default for if no name is provided?
        public Person() => Name = "---";

        // Constructor
        public Person(string name)
        {
            Name = name;
        }

        // Public method for updating Persons private _location
        public void Relocate(string location)
        {
            if (!string.IsNullOrEmpty(location))
            {
                _location = location;
            }
        }

        // Single line method, lambda can return float
        public float GetDistance(string location) => DistanceHelpers.GetDistance(_location, location);
        
        
        
        
    }
    
    
    
    
}