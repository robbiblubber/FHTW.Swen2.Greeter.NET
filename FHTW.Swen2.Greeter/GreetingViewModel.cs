using System;
using System.ComponentModel;



namespace FHTW.Swen2.Greeter
{
    /// <summary>This class implements the greeting view model.</summary>
    internal class GreetingViewModel: INotifyPropertyChanged
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // private members                                                                                                  //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>Greeting action command.</summary>
        private GreetingActionCommand _GreetingAction;



        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // constructors                                                                                                     //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>Creates a new instance of this class.</summary>
        public GreetingViewModel() 
        {
            _GreetingAction = new(this);
        }



        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // public properties                                                                                                //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>Gets the greeting action command.</summary>
        public GreetingActionCommand GreetingAction
        {
            get { return _GreetingAction; }
        }


        /// <summary>Gets or sets the greeting target.</summary>
        public string Target
        { 
            get { return Greeting.Instance.TargetName; }
            set
            {
                Greeting.Instance.TargetName = value;
                PropertyChanged?.Invoke(this, new(nameof(Target)));
            }
        }


        /// <summary>Gets or sets the greeting text.</summary>
        public string Text
        {
            get { return Greeting.Instance.GreetingText; }
            set 
            { 
                Greeting.Instance.GreetingText = value; 
                PropertyChanged?.Invoke(this, new(nameof(Text)));
            }
        }



        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // [interface] INotifyPropertyChanged                                                                               //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>Occures when a property is changed.</summary>
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
