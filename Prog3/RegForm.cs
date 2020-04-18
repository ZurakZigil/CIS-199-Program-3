/*
Grading ID: W9957
Program#: 2
Due Date: 3/08/2018 11:59.00
Course Section: 199-01

Description:
A program to determine when a student attending UofL can register for classes. This time using arrays and searches.

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog2
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        // Find and display earliest registration time
        private void findRegTimeBtn_Click(object sender, EventArgs e)
        {
            string[] day = { "March 28", "March 29", "March 30", "April 2", "April 3", "April 4" }; //array for possible scheduled days (partially parallel to hours[])
            int[] hours = { 90, 60, 30}; //array of hours determining seniority

            const char daySeperator = 'L'; //a constant that seperates which days a sophomore or freshman would registration
            char[] lastInitial = { 'A', 'C', 'E', 'G', 'J', 'M', 'P', 'R', 'T', 'W' }; //array of letters that determine times for the registrations (partially parallel to time[]) - why create another array when the data already existed and can just be manipulated?
            string[] time = { "8:30 AM", "10:00 AM", "11:30 AM", "2:00 PM", "4:00 PM" }; //array of possible times to registration


            string lastNameStr;         // Entered last name
            char lastNameLetterCh;      // First letter of last name, as char
            string dateStr = "Error";   // Holds date of registration
            string timeStr = "Error";   // Holds time of registration
            float creditHours;          // Previously earned credit hours
            bool isUpperClass;          // Upperclass or not?



            lastNameStr = tBoxLastName.Text;
            if (lastNameStr.Length > 0) // Empty string?
            {
                lastNameLetterCh = lastNameStr[0];   // First char of last name
                lastNameLetterCh = char.ToUpper(lastNameLetterCh); // Ensure upper case

                if (float.TryParse(tBoxCreditHours.Text, out creditHours) && creditHours >= 0)
                {
                    if (char.IsLetter(lastNameLetterCh)) // Is it a letter?
                    {
                        isUpperClass = (creditHours >= hours[1]);

                        // Juniors and Seniors share same schedule but different days
                        if (isUpperClass)
                        {

                            for(int i=1; !(i<0) && creditHours>=hours[i]; i--) //a search to find the day for a junior or senior
                            {
                                dateStr = day[i]; //sets day
                            }

                            for (int i = 0; !(i == 10) && (lastNameLetterCh >= lastInitial[i]); i = i + 2) //a search for the last initial in the array (adjusts for only using half the characters in the array)
                            {
                                timeStr = time[WholeNumber(i)]; //sets time using a method to correct the fact the Senior and Junior times correlate to only half of the letters in the array
                            }
                        }
                        // Sophomores and Freshmen
                        else 
                        {
                            if (creditHours >= hours[2])
                            {
                                // A-L on day one
                                if ((lastNameLetterCh <= daySeperator)) dateStr = day[2];   // <= L
                                else dateStr = day[3]; // All other letters on next day
                            }
                            else // must be freshman
                            {
                                // A-L on day one
                                if ((lastNameLetterCh <= daySeperator)) dateStr = day[4];   // <= L
                                else dateStr = day[5]; // All other letters on next day

                            }

                            for (int i=0;(!(lastNameLetterCh>=lastInitial[5]) && lastNameLetterCh>=lastInitial[i]) || (!(i==5) && lastNameLetterCh >= lastInitial[i + 5]); i++) //assigns the time through 2 test of the last initial. The first is A-L the next is for M-Z
                            {
                                timeStr = time[i]; //sets time
                            }
                        }

                        // Output results
                        displayDateTime.Text = dateStr + " at " + timeStr;
                    }
                    else // Not A-Z
                        MessageBox.Show("Make sure last name starts with a letter!");
                }
                else //valid credit hours
                    MessageBox.Show("Enter a valid number of credit hours!");
            }
            else // Empty textbox
                MessageBox.Show("Please enter last name!");
        }

        //used to round a number divided by 2 up so we can use it for the subscript of an array
        private static int WholeNumber(double index) //Pre-Condition: requires the argument to be a double   
        {
            int newIndex; 

            if (index % 2 > 0) //tests the remainder and whether it needs to be rounded
            {
                newIndex =Convert.ToInt32((index / 2) + 0.5); //adds .5 so it's a whole number
            }
            else
            {
                newIndex = (Convert.ToInt32(index)) / 2; //divides by two
            }

            return newIndex; //Post-Condition: returns a divided double by two and rounded up to an int
        }

    }
}
