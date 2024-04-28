using System;



namespace FHTW.Swen2.Greeter
{
    /// <summary>This class implements the greeting business logic.</summary>
    public class Greeting
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // public constants                                                                                                 //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>Gets the singleton instance.</summary>
        public static readonly Greeting Instance = new();



        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // constructors                                                                                                     //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>Creates a new instance of this class.</summary>
        private Greeting()
        {}



        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // public properties                                                                                                //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>Gets or sets the greeting target name.</summary>
        public string TargetName { get; set; } = "World";


        /// <summary>Gets or sets the greeting text.</summary>
        public string GreetingText { get; set; } = "Hello, World!";
    }
}
