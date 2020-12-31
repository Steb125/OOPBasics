// Types of class members refer to anything placed within a class
//     1. Fields
//          a. Data that will live on an object of a class
//             ex. a variable defined within a class
//          b. What does the class possess?
//             ex. a vehicle has a maximum number of passengers
//     2. Methods 
//          a. A function defined within a class that can be called from an object of the class
//          b. Behavior (functions) that a class can perform
//     3. Properties
//          a. Allows control of how fields are retrieved and updated

using System;
namespace OOPBasics
{
    class Vehicle
    {
        // Fields of the vehicle class 
        public int MaxNumPassengers; 
        public string Color;
        public double MaxSpeed;

        // Methods of the vehicle class
        // Void is the return type
        // String is the type for the input parameters
        // 1. Pass a string variable to the noise that will be made
        void MakeNoise(string noise)
        {
            // 2. Write the string to the Console
            Console.WriteLine(noise);
        }

        // In C# we can have multiple methods of the same name (method overloading) 
        //  as long as they have different input parameters 
        // This MakeNoise method does not return any parameters
        void MakeNoise()
        {
            Console.WriteLine("BEEP!");
        }

        // Properties of the vehicle class
        // Properties provide publicly accessible members of a class that have direct control over hidden fields
        // A color property that returns the Color Field
        // someVehicle.ColorProp => Color
        // A color property that assigns a value
        // someVehicle.ColorProp = "Some Color"
        // Properties include a type (string) and a name (ColorProp)
        string ColorProp
        {
            // get and set are keywords that behave like methods
            // get and set are accessors.  The compiler requires at least 1 accessor
            // If we only use get, access to the class will be restricted to read only
            // get retrieves values
            // set assigns values
            // get must return the type declared in the property (string)
            get
            {
                // 2 options to return a string
                // return Color;
                // Or
                if(Color == "Green")
                    return $"This SWEET thing is {Color}";
                return $"This thing is {Color}";
            }
            set
            {
                // value represents whatever we are attempting to assign to the property
                // Color = value;
                // set can have restrictions added to it
                // in this example, Green is NOT allowed 
                if(value != "Green")
                    Color = value;
            }
        }

        // AutoProperty of the vehicle class
        // Provides a backing field
        // Compiler creates a field that will not display, but the data will exist on the object
        // The property will be auto initialized
        // get and set are automatically assigned to the Name property
        string Name {get;set;}

        // Access Modifiers control where class members can be accessed 
            // public: No access restriction
            // private: Access restricted to own class (default for class members)
            // protected: Access restricted to own class, and any child class
            // internal: Access restricted to Assembly (essentially, your project's compiled .dll)

        // Encapsulation
            // You will want to keep all members as restricted as you are able.  
            // The idea is to follow a common OOP principle of encapsulation: 
                // to hide internal implementation from outside code as much as possible 
                // and to only publicly provide what is essential. 

    }
}