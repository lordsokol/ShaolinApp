using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace shaolin
{

    public partial class VisualTraining : Form
    {
        public static int numberOfObjects = 15;
        int[] theXs = new int[15];
        int[] theYs = new int[15];
        PictureBox[] theBoxes = new PictureBox[26];
        static Random ranDom = new Random();
        public int numberOfGeneratedSpheres = 15;
        public int lastCount = 0;
        public int playCount = 0;
        public int numBigGlobes = 10;
        public int level = 1;
        public int numberCorrect = 0;

        public VisualTraining()
        {
            InitializeComponent();
            doneButton.Visible = false;
            showMeButton.Visible = false;
            howManyButton.Visible = false;
            howManyLabel.Visible = false;
            howManyTextBox.Visible = false;
            showAllButton.Visible = false;
            hideButton.Visible = false;
            setUpDrawingObjects();
            getOriginalPos();
            hideAllSpheres();
        }

        private void goButton_Click(object sender, EventArgs e)
        {
            rulesBox.Visible = false;
            goButton.Visible = false;
            closeButton.Visible = false;
            directionsTextBox.Visible = false;
            doneButton.Visible = true;
            showMeButton.Visible = true;
            showAllButton.Visible = true;
            levelLable.Visible = true;
            levelContents.Visible = true;
            //put back into original positions
            originalPos(); 
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            rulesBox.Visible = true;
            goButton.Visible = true;
            showMeButton.Visible = false;
            closeButton.Visible = true;
            directionsTextBox.Visible = true; ;
            doneButton.Visible = false;
            howManyButton.Visible = false;
            howManyLabel.Visible = false;
            howManyTextBox.Visible = false;
            showAllButton.Visible = false;
            levelLable.Visible = false;
            levelContents.Visible = false;
            hideAllSpheres();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            levelLable.Visible = false;
            levelContents.Visible = false;
            this.Dispose();

        }

        private void animateSpheres()
        {
            int x, y, t, v = 0;
           
            
           //get original pos
            getOriginalPos();

            for (int count = 0; count < 10; count++)
            {
                for (x = 0; x < numberOfObjects; x++)
                {
                    t = theBoxes[x].Location.X;
                    theBoxes[x].Location = new System.Drawing.Point(t + x, theBoxes[x].Location.Y);
                }
                for (y = 0; y < numberOfObjects; y++)
                {
                    v = theBoxes[y].Location.Y;
                    theBoxes[y].Location = new System.Drawing.Point(theBoxes[y].Location.X, v + y);
                }
                for (x = numberOfObjects - 1; x > 0; x--)
                {
                    t = theBoxes[x].Location.X;
                    theBoxes[x].Location = new System.Drawing.Point(t - x, theBoxes[x].Location.Y);
                }
                for (y = numberOfObjects - 1; y > 0; y--)
                {
                    v = theBoxes[y].Location.Y;
                    theBoxes[y].Location = new System.Drawing.Point(theBoxes[y].Location.X, v - y);
                }
            }

            //put back into original positions
           originalPos();

        }

        public void originalPos()
        {
            //put back into original positions
            for (int pos = 0; pos < numberOfObjects; pos++)
            {
                theBoxes[pos].Location = new System.Drawing.Point(theXs[pos], theYs[pos]);
            }
        }

         //get original positions
        public void getOriginalPos()
        {
            for (int pos = 0; pos < numberOfObjects; pos++)
            {
                theYs[pos] = theBoxes[pos].Location.Y;
                theXs[pos] = theBoxes[pos].Location.X;
            }
        }

        public void setUpDrawingObjects()
        {
            theBoxes[0] = this.pictureBox1;
            theBoxes[1] = this.pictureBox2;
            theBoxes[2] = this.pictureBox3;
            theBoxes[3] = this.pictureBox4;
            theBoxes[4] = this.pictureBox5;
            theBoxes[5] = this.pictureBox6;
            theBoxes[6] = this.pictureBox7;
            theBoxes[7] = this.pictureBox8;
            theBoxes[8] = this.pictureBox9;
            theBoxes[9] = this.pictureBox10;
            theBoxes[10] = this.pictureBox11;
            theBoxes[11] = this.pictureBox12;
            theBoxes[12] = this.pictureBox13;
            theBoxes[13] = this.pictureBox14;
            theBoxes[14] = this.pictureBox15;
            theBoxes[15] = this.pictureBox16;
            theBoxes[16] = this.pictureBox17;
            theBoxes[17] = this.pictureBox18;
            theBoxes[18] = this.pictureBox19;
            theBoxes[19] = this.pictureBox20;
            theBoxes[20] = this.pictureBox21;
            theBoxes[21] = this.pictureBox22;
            theBoxes[22] = this.pictureBox23;
            theBoxes[23] = this.pictureBox24;
            theBoxes[24] = this.pictureBox25;
            theBoxes[25] = this.pictureBox26;

            //reset play count
            playCount = 0;
        }

        private void hideAllSpheres()
        {
            for (int x = 0; x < numberOfObjects; x++)
            {
                theBoxes[x].Visible = false;
            }
            hideAdditionalSpheres();
        }

        private void showAllSpheres()
        {
            for (int x = 0; x < numberOfObjects; x++)
            {
                theBoxes[x].Visible = true;
            }
        }

        private void showAdditionalSpheres()
        {
            for (int x = 15; x < 25; x++)
            {
                theBoxes[x].Visible = true;
            }
        }

        private void hideAdditionalSpheres()
        {
            for (int x = 15; x < 25; x++)
            {
                theBoxes[x].Visible = false;
            }
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            
        }

        private void tick(int mill)
        {
            
            for(int x = 0; x < mill; x++)
            {
                for (int t = 0; t < 99999999; t++)
                {

                }
            }
        }

        private void dealTimer(int interval)
        {
            DateTime dt1 = DateTime.Now;
            int diff = 0;

            while (diff < interval)
            {

                DateTime dt2 = DateTime.Now;
                TimeSpan ts = dt2.Subtract(dt1);
                diff = (int)ts.Milliseconds;
                Application.DoEvents();

            }
        }

        public void mouseEnter(object sender, EventArgs e)
        {
            animateSpheres();
        }

        public int showRandomSpheres(int playCount)
        {
            if (playCount < 5)
            {
                int n = ranDom.Next(numberOfObjects - 1) + 1;
                for (int x = 0; x < n; x++)
                {
                    theBoxes[x].Visible = true;
                }
                level = 1;
                return n;
                
            }

            if (playCount >= 5 && playCount < 15)
            {
                int n = ranDom.Next(numberOfObjects - 1) + 1;
                if (n <= numberOfObjects - 2)
                {
                    n += 2;
                }
                for (int x = 0; x < n; x++)
                {
                    theBoxes[x].Visible = true;
                }
                level = 2;
                return n;
            }

            if (playCount >= 15 && playCount < 25)
            {
                int n = ranDom.Next(numberOfObjects - 1) + 1;
                if (n <= numberOfObjects - 3)
                {
                    n += 3;
                }
                for (int x = 0; x < n; x++)
                {
                    theBoxes[x].Visible = true;
                }
                level = 3;
                return n;
            }


            if (playCount >= 25)
            {
                //numBigGlobes = 10;
                //show some big globes now too
                int m = ranDom.Next(numBigGlobes - 1) + 1;
                for (int y = 0; y < m; y++)
                {
                    theBoxes[y + numBigGlobes].Visible = true;
                }

                int n = ranDom.Next(numberOfObjects - 1) + 1;
                if (n <= numberOfObjects - 3)
                {
                    n += 3;
                }
                for (int x = 0; x < n; x++)
                {
                    theBoxes[x].Visible = true;
                }
                level = 4;
                return n + m;
            }
            return 1;
           
        }

        /* <comments>
         * */
        private int checkLevel()
        {
            String scoreMessage = "Ok \n";
            float score = numberCorrect / playCount;
            if (score == 1)
                scoreMessage = "PERFECT! \n";

            if (level == 2 && playCount == 6)
            {
                levelLable.Text = "LEVEL 2";
                levelLable.Visible = true;
                levelContents.Text = scoreMessage;
                levelContents.Text += "You have " + numberCorrect.ToString() + " out of " + playCount.ToString() + " so far. \n";
                levelContents.Text += "You will have less time to view the items now.  Be aware!";
                levelContents.Visible = true;
                return 0;
            }
            if (level == 3 && playCount == 16)
            {
                levelLable.Text = "LEVEL 3";
                levelLable.Visible = true;
                levelContents.Text = scoreMessage;
                levelContents.Text += "You have " + numberCorrect.ToString() + " out of " + playCount.ToString() + " so far. \n";
                levelContents.Text += "The display time is even shorter and there will be more objects!";
                levelContents.Visible = true;
                return 0;
            }
            if (level == 4 && playCount == 26)
            {
                levelLable.Text = "LEVEL 4";
                levelLable.Visible = true;
                levelContents.Text = scoreMessage;
                levelContents.Text += "You have " + numberCorrect.ToString() + " out of " + playCount.ToString() + " so far. \n";
                levelContents.Text += "Size and color do not matter, count the total number, if you can!";
                levelContents.Visible = true;
                return 0;
            }
            else
            {
                levelLable.Visible = false;
                levelContents.Visible = false;
            }
            return 0;
        }

        private void showMeButton_Click(object sender, EventArgs e)
        {
            levelLable.Visible = false;
            levelContents.Visible = false;
            if (playCount < 5)
            {
                numberOfGeneratedSpheres = showRandomSpheres(playCount);
                // do not repeat the number shown last time
                while (numberOfGeneratedSpheres == lastCount)
                {
                    numberOfGeneratedSpheres = showRandomSpheres(playCount);
                }
                lastCount = numberOfGeneratedSpheres;

                //set delay timer based on number of plays
                dealTimer(900);
            }

            if (playCount >= 5 && playCount < 15)
            {
                numberOfGeneratedSpheres = showRandomSpheres(playCount);
                // do not repeat the number shown last time
                while (numberOfGeneratedSpheres == lastCount)
                {
                    numberOfGeneratedSpheres = showRandomSpheres(playCount);
                }

                if (numberOfGeneratedSpheres > numberOfObjects)
                {
                    numberOfGeneratedSpheres = 15;
                }
                lastCount = numberOfGeneratedSpheres;

                //set delay timer based on number of plays
                dealTimer(700);  //get faster
            }

            if (playCount >= 15 && playCount < 25)
            {
                numberOfGeneratedSpheres = showRandomSpheres(playCount);
                // do not repeat the number shown last time
                while (numberOfGeneratedSpheres == lastCount)
                {
                    numberOfGeneratedSpheres = showRandomSpheres(playCount);
                }

                if (numberOfGeneratedSpheres > numberOfObjects)
                {
                    numberOfGeneratedSpheres = 15;
                }
                lastCount = numberOfGeneratedSpheres;

                //set delay timer based on number of plays
                 dealTimer(650);  //get faster
                
            }

            if (playCount >= 25)
            {
                numberOfGeneratedSpheres = showRandomSpheres(playCount);
                // do not repeat the number shown last time
                while (numberOfGeneratedSpheres == lastCount)
                {
                    numberOfGeneratedSpheres = showRandomSpheres(playCount);
                }

                if (numberOfGeneratedSpheres > numberOfObjects + numBigGlobes)
                {
                    numberOfGeneratedSpheres = 25;  //TODo make this not hard coded
                }
                lastCount = numberOfGeneratedSpheres;

                //set delay timer based on number of plays
                dealTimer(600);  //get faster
            }

            hideAllSpheres();
            howManyButton.Visible = true;
            howManyLabel.Visible = true;
            howManyTextBox.Visible = true;
            howManyTextBox.Focus();

            //increment play count to increase speed later
            playCount++;
        }

        private void howManyButton_Click(object sender, EventArgs e)
        {
            howManyButton.Visible = false;
            howManyLabel.Visible = false;
            howManyTextBox.Visible = false;
            if (howManyTextBox.Text == numberOfGeneratedSpheres.ToString())
            {
                YES yes = new YES();
                yes.ShowDialog();
                numberCorrect++;
            }
            else
            {
                NO no = new NO(numberOfGeneratedSpheres);
                no.ShowDialog();
           }
            
            howManyTextBox.Text = "";
            checkLevel();
        }


        private void hideNumberOfSpheres(int numObjs)
        {
            for (int x = 0; x < numObjs; x++)
            {
                theBoxes[x].Visible = false;
            }
        }

        private void showNumberOfSpheres(int numObjs)
        {
            for (int x = 0; x < numObjs; x++)
            {
                theBoxes[x].Visible = true;
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            levelLable.Visible = false;
            levelContents.Visible = false;
            showAllButton.Visible = false;
            hideButton.Visible = true;
            showNumberOfSpheres(26);
        }

        private void hideButton_Click(object sender, EventArgs e)
        {
            levelLable.Visible = false;
            levelContents.Visible = false;
            hideButton.Visible = false;
            showAllButton.Visible = true;
            hideNumberOfSpheres(26);
        }

    }
}
