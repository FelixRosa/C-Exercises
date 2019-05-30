using System;

namespace Exercise1_Control_Flow
{
    public class ProgLogic
    {
        //Write a program and ask the user to enter a number. The number should be between 1 to 10.
        //If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
        //(This logic is used a lot in applications where values entered into input boxes need to be validated.)
        public static String CheckNumber(int input)
        {
            var retStr = "";
            if (input < 11 && input > 0)
                retStr = "Valid";
            else
                retStr = "Invalid";

            return retStr;
        }
        
        //Write a program which takes two numbers from the console and displays the maximum of the two.
        public static int MaxNum(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        
        //Write a program and ask the user to enter the width and height of an image.
        //Then tell if the image is landscape or portrait. 
        public static String GetImageType(int width, int height)
        {
            if (width > height)
                return "The Image is landscape.";
            else
                return "The Image is a portrait.";
        }
        
        //Your job is to write a program for a speed camera.
        //For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
        //Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed of a car.
        //If the user enters a value less than the speed limit, program should display Ok on the console.
        //If the value is above the speed limit, the program should calculate the number of demerit points.
        //For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
        //If the number of demerit points is above 12, the program should display License Suspended. 
        public static String SpeedCam(int SpeedLimit, int Speed)
        {
            if (Speed < SpeedLimit)
                return "Ok";
                 
            int demeritPoints = 0;
            int discrepancy = Speed - SpeedLimit;
            for (int i = 0; i < discrepancy; i++)
            {
                if (i % 5 == 0 && demeritPoints < 12)
                {
                    demeritPoints = demeritPoints+1;
                }else if(demeritPoints == 12)
                { 
                    return String.Format("You exceeded the speed limit with {0} km/h. \n The fine is {1} Demerit Points. \n You're licence is suspended!", discrepancy, demeritPoints);
                }
            }
            return String.Format("You exceeded the speed limit with {0} km/h. \n The fine is {1} Demerit Points.", discrepancy, demeritPoints);
        }
    }
}