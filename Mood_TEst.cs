using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyze
{
    public class MoodAnalyser
    {

        
        string message;

        //parameterized constructor for initializing instance member
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        //Analyser method to find mood
        public string Analyser() 
        {
            if (this.message.ToLower().Contains("happy"))
            {
                return "happy";
            }
            else
            {
                return " sad";
            }
        }
    }
}
