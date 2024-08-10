using System;


namespace time
{
    public class Time
    {
        public int hour;

       // Constructor
       /*
       public Time(int hour)
       {
           this.hour = hour;

       }*/




        // Complex getter and setter with if else statement
        
        public int Hour
        {

            get
            {
                return hour;

            }
            set
            {
                if (value >= 0 && value < 24)
                {
                    hour = value;
                }
                else
                {
                    hour = 0;
                }
            }
        }

        // Private getter and setter where the setter is private so you can't assign a value.
       
        
        
        /*
        public int Hour
        {  

            get
            {

                return hour;
            }
            private set
            {
                if (value < 0 && value <24)
                {
                    hour = value;
                }
                else
                {
                    hour = 0;
                }
            }
        } */
        


    }
}