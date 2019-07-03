using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingScoreTracker
{
    public class TrainingGrid
    {

        /*
         * 
         * 
         * This will take 3 entries as a string literal value
         * and create a 3 by 3 grid to display on a screen.
         * The grid user can select in which order to do the
         * the grid, stopping on each square for X number of
         * repetitions.  A user may also choose a preset pattern
         * to traverse the grid to complete the training.
         * 
         * Once a pattern has been selected, the screen will
         * display the string value of the first spot on the grid
         * to fill up the entire screen with a number of repeitioons
         * on it. A user will need to complete X number of repetitions
         * and upon completion of each repetition, tap the screen to advance
         * the countdown (decrease?) Once X has been reached, the screen
         * will display the next spot on the grid. And so forth.
         * 
         * When training is complete, stuff will happen like saving of the
         * training session grid, order of completion and repetitions in each
         * stop. This can be sent via email to somewhere maybe, or saved 
         * to the cloud!!!!
         * 
         * 
         */

        public string[][] CreateTrainingGrid(string firstTrainingFocus, string secondTrainingFocus, string thirdTrainingFocus)
        {
            string[][] trainingGrid = new string[3][];
            string firstFocus = firstTrainingFocus;
            string secondFocus = secondTrainingFocus;
            string thirdFocus = thirdTrainingFocus;

            var initialRow = CreateInitialRow(firstTrainingFocus, secondTrainingFocus, thirdTrainingFocus);

            string[] rowOne = CreateRow(initialRow, firstTrainingFocus);
            string[] rowTwo = CreateRow(initialRow, secondTrainingFocus);
            string[] rowThree = CreateRow(initialRow, thirdTrainingFocus);

            for (int i = 0; i < 3; i++)
            {



            }


            return new string[1][];
        }

        public string[] CreateRow(string[] rowOfTrainingTargets, string individualTarget)
        {


            return new string[1];
        }

        public string[] CreateInitialRow(string firstTarget, string secondTarget, string thirdTarget)
        {
            return new string[3] { firstTarget, secondTarget, thirdTarget };
        }


    }
}
