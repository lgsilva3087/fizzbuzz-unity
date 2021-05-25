using UnityEngine;
using UnityEngine.UI;

namespace View
{
    /// <summary>
    /// View class for user interface handling
    /// </summary>
    public class FizzBuzzView : MonoBehaviour
    {
        [SerializeField] private FizzBuzz fizzBuzz;

        [SerializeField] private Text consoleText;

        [SerializeField] private InputField initInputField;
        [SerializeField] private InputField endInputField;

        /// <summary>
        /// Runs the FizzBuzz algorithm from the UI
        /// </summary>
        public void OnRunButtonClicked()
        {
            //The InputFields are configured to accept only integer numbers,
            //so I do not need to TryParse
            int init = int.Parse(initInputField.text);
            int end = int.Parse(endInputField.text);
            
            //Range validation
            if(init > end)
                LogToConsole("The minimum can not be greater than the maximum.");

            if (fizzBuzz != null)
            {
                consoleText.text = "";
                
                string result = fizzBuzz.GetFizzBuzz(init, end);
                
                LogToConsole(result);
            }
        }

        /// <summary>
        /// Adds a line to the UI console.
        /// </summary>
        /// <param name="text">Line of text to be added</param>
        private void LogToConsole(string text)
        {
            if (consoleText != null)
                consoleText.text = consoleText.text + text + "\n";
        }
    }
}
