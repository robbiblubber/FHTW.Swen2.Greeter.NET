using System;
using System.ComponentModel;
using System.Windows.Input;



namespace FHTW.Swen2.Greeter
{
    /// <summary>This class implements a command for the greeting button.</summary>
    internal class GreetingActionCommand: ICommand
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // private members                                                                                                  //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>View model.</summary>
        private GreetingViewModel _Model;



        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // constructors                                                                                                     //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>Creates a new instance of this class.</summary>
        /// <param name="m">View model.</param>
        public GreetingActionCommand(GreetingViewModel m)
        {
            _Model = m;
            _Model.PropertyChanged += _Model_PropertyChanged;
        }



        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // [interface] ICommand                                                                                             //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>Occurs when the <see cref="CanExecute"/> value has changed.</summary>
        public event EventHandler? CanExecuteChanged;


        /// <summary>Gets if the command can be executed.</summary>
        /// <param name="parameter">Command parameters.</param>
        /// <returns>Returns TRUE if the command can be executed, otherwise returns FALSE.</returns>
        public bool CanExecute(object? parameter)
        {
            return !string.IsNullOrWhiteSpace(_Model.Target);
        }


        /// <summary>Executes the command.</summary>
        /// <param name="parameter">Command parameter.</param>
        public void Execute(object? parameter)
        {
            _Model.Text = $"Hello, {_Model.Target}!";
        }



        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        // event handlers                                                                                                   //
        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        
        /// <summary>Handles the view model PropertyChange event.</summary>
        /// <param name="sender">Object that raised the event.</param>
        /// <param name="e">Event arguments.</param>
        private void _Model_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if(e.PropertyName == nameof(_Model.Target))
            {
                CanExecuteChanged?.Invoke(this, new EventArgs());
            }
        }
    }
}
