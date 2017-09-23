using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvancedHMIDrivers;
using CodeVendor.Controls;
using System.IO;

namespace WindowsFormsApplication8
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            addEvent("Components Initialized");
        }

        // Displays an error message when there is a communication error
        private void commError(Boolean isError)
        {
            String message;
            if (isError == true)
            {
                message = "Communication error on " + serialConn1.ComPort + " at " + serialConn1.BaudRate + "";
                changeErrorMessage(message);
                textBoxConnectionStatus.ForeColor = System.Drawing.Color.Red;
                addEvent(message);
            }
            else
            {
                message = "Connected to PLC on " + serialConn1.ComPort + " at " + serialConn1.BaudRate;
                changeErrorMessage(message);
                textBoxConnectionStatus.ForeColor = System.Drawing.Color.Green;
                addEvent(message);
            }
        }
        // Changes the text in the error message textbox
        private void changeErrorMessage(string message)
        {
            textBoxConnectionStatus.Text = message;
        }




        // Saves the position of switches and values of schuduler for next use
        private void saveValues()
        {
            try
            {
                // Create a file to write to.
                string path = "data.txt";
                string createText =

                    comboBoxComm.SelectedItem.ToString() + "," +


                    // 1st Group Parameters
                    textBoxForce0.Text + ";" +
                    grouperDay0.Enabled + ";" +
                    checkBoxM0.Checked + ";" +
                    checkBoxT0.Checked + ";" +
                    checkBoxW0.Checked + ";" +
                    checkBoxR0.Checked + ";" +
                    checkBoxF0.Checked + ";" +
                    checkBoxS0.Checked + ";" +
                    checkBoxSu0.Checked + ";" +

                    grouperTime0.Enabled + ";" +
                    numericTimeHour0.Value + ";" +
                    numericTimeMinute0.Value + ";" +

                    grouperDuration0.Enabled + ";" +
                    numericDurationHour0.Value + ";" +
                    numericDurationMinute0.Value + ";," +

                    // 2nd Group Parameters
                    textBoxForce1.Text + ";" +
                    grouperDay1.Enabled + ";" +
                    checkBoxM1.Checked + ";" +
                    checkBoxT1.Checked + ";" +
                    checkBoxW1.Checked + ";" +
                    checkBoxR1.Checked + ";" +
                    checkBoxF1.Checked + ";" +
                    checkBoxS1.Checked + ";" +
                    checkBoxSu1.Checked + ";" +

                    grouperTime1.Enabled + ";" +
                    numericTimeHour1.Value + ";" +
                    numericTimeMinute1.Value + ";" +

                    grouperDuration1.Enabled + ";" +
                    numericDurationHour1.Value + ";" +
                    numericDurationMinute1.Value + ";";

                    
                string[] Lines = createText.Split(',');

                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (string line in Lines)
                    {
                        sw.WriteLine(line);
                    }
                }
                addEvent("Saved settings as " + path);
            }

            catch (Exception Err)
            {
                addEvent("Error in saving presets!!");
                var x = MessageBox.Show("Error in Saving Files\n"+Err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // This is reading all of the values that were saved top data.txt and setting the values in program
        private void loadValues()
        {
            String file = "data.txt";

            using (StreamReader sr = new StreamReader(file))
            {
                comboBoxComm.SelectedItem = sr.ReadLine();

                while (sr.Peek() >= 0)
                {
                    string[] data = sr.ReadLine().Split(';');

                    textBoxForce0.Text = data[0];

                    if (Convert.ToBoolean(data[1]) == false)
                        disableGroup(grouperDay0);
                    else
                        enableGroup(grouperDay0);

                    checkBoxM0.Checked = Convert.ToBoolean(data[2]);
                    checkBoxT0.Checked = Convert.ToBoolean(data[3]);
                    checkBoxW0.Checked = Convert.ToBoolean(data[4]);
                    checkBoxR0.Checked = Convert.ToBoolean(data[5]);
                    checkBoxF0.Checked = Convert.ToBoolean(data[6]);
                    checkBoxS0.Checked = Convert.ToBoolean(data[7]);
                    checkBoxSu0.Checked = Convert.ToBoolean(data[8]);

                    if (Convert.ToBoolean(data[9]) == false)
                        disableGroup(grouperTime0);
                    else
                        enableGroup(grouperTime0);

                    numericTimeHour0.Value = Convert.ToDecimal(data[10]);
                    numericTimeMinute0.Value = Convert.ToDecimal(data[11]);

                    if (Convert.ToBoolean(data[12]) == false)
                        disableGroup(grouperDuration0);
                    else
                        enableGroup(grouperDuration0);

                    numericDurationHour0.Value = Convert.ToDecimal(data[13]);
                    numericDurationMinute0.Value = Convert.ToDecimal(data[14]);

                }
            }
            addEvent("Loaded presets from " + file);
        }


        // Updating PLC Communication Settings
        private Boolean updateCommSettings() {

            serialConn1.ComPort = comboBoxComm.SelectedItem.ToString();
            return checkCommStatus();
        }

        // Checking Communication between PLC and Computer
        private Boolean checkCommStatus()
        {
            Boolean commsGood = false;
            try
            {
                if (serialConn1.Read("B3:0/0") != "" && serialConn1.Read("B3:0/0") != null)
                {
                    commError(false);
                    commsGood = true;
                }
            }
            catch
            {
                commError(true);
                commsGood = false;
            }

            return commsGood;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            addEvent("Application Starting...");

            serialConn1.BaudRate = "9600";

            //comboBoxComm.SelectedIndex = 0;
            //updateCommSettings();

            // setting al vRegisters to 0 for initialization
            TextBox[] vRegisters = new TextBox[] { textBoxConditionsMet0, textBoxConditionsMet1, textBoxConditionsMet2, textBoxConditionsMet3, textBoxConditionsMet4, textBoxConditionsMet5,
                textBoxForce0, textBoxForce1, textBoxForce2, textBoxForce3, textBoxForce4, textBoxForce5,
                textBoxOn0, textBoxOn1, textBoxOn2, textBoxOn3, textBoxOn4, textBoxOn5};

            //foreach (TextBox vRegister in vRegisters) {

             //   vRegister.Text = "0";

            //}
            
            //loadDataFromPLC();
            loadValues();

            checkConditions();

            commTimer.Enabled = true;

            addEvent("Application started");
        }


        private void loadDataFromPLC()
        {
            addEvent("Loading data from PLC");
            if (checkCommStatus() == true)
            {
                textBoxOn0.Text = boolToInt(serialConn1.Read("B3:0/0"));
                textBoxOn1.Text = boolToInt(serialConn1.Read("B3:1/0"));
                textBoxOn2.Text = boolToInt(serialConn1.Read("B3:2/0"));
                textBoxOn3.Text = boolToInt(serialConn1.Read("B3:3/0"));
                textBoxOn4.Text = boolToInt(serialConn1.Read("B3:4/0"));
                textBoxOn5.Text = boolToInt(serialConn1.Read("B3:5/0"));


                textBoxForce0.Text = boolToInt(serialConn1.Read("B3:6/0"));
                textBoxForce1.Text = boolToInt(serialConn1.Read("B3:7/0"));
                textBoxForce2.Text = boolToInt(serialConn1.Read("B3:8/0"));
                textBoxForce3.Text = boolToInt(serialConn1.Read("B3:9/0"));
                textBoxForce4.Text = boolToInt(serialConn1.Read("B3:10/0"));
                textBoxForce5.Text = boolToInt(serialConn1.Read("B3:11/0"));
            }
            else
            {
                addEvent("*** Error loading data from PLC! ***");
            }
        }
        private void addEvent(string text)
        {
            int maxSize = 500;
            DateTime dateTimeNow = DateTime.Now;

            listBoxEvents.Items.Insert(0, dateTimeNow.ToString() + " : " +  text);

            if (listBoxEvents.Items.Count > maxSize)
            {
                listBoxEvents.Items.RemoveAt(maxSize);
            }
            
        }
        // This function checks to see if all conditions are met
        // to determine if circuit will be on or off
        private void checkConditions()
        {
            //addEvent("Checking conditions...");
            // Storing all objects in arrays to cycle through
            CheckBox[][] checkBoxesDays = new CheckBox[6][];

            checkBoxesDays[0] = new CheckBox[7];
            checkBoxesDays[0][0] = checkBoxSu0;
            checkBoxesDays[0][1] = checkBoxM0;
            checkBoxesDays[0][2] = checkBoxT0;
            checkBoxesDays[0][3] = checkBoxW0;
            checkBoxesDays[0][4] = checkBoxR0;
            checkBoxesDays[0][5] = checkBoxF0;
            checkBoxesDays[0][6] = checkBoxS0;

            checkBoxesDays[1] = new CheckBox[7];
            checkBoxesDays[1][0] = checkBoxSu1;
            checkBoxesDays[1][1] = checkBoxM1;
            checkBoxesDays[1][2] = checkBoxT1;
            checkBoxesDays[1][3] = checkBoxW1;
            checkBoxesDays[1][4] = checkBoxR1;
            checkBoxesDays[1][5] = checkBoxF1;
            checkBoxesDays[1][6] = checkBoxS1;

            checkBoxesDays[2] = new CheckBox[7];
            checkBoxesDays[2][0] = checkBoxSu2;
            checkBoxesDays[2][1] = checkBoxM2;
            checkBoxesDays[2][2] = checkBoxT2;
            checkBoxesDays[2][3] = checkBoxW2;
            checkBoxesDays[2][4] = checkBoxR2;
            checkBoxesDays[2][5] = checkBoxF2;
            checkBoxesDays[2][6] = checkBoxS2;

            checkBoxesDays[3] = new CheckBox[7];
            checkBoxesDays[3][0] = checkBoxSu3;
            checkBoxesDays[3][1] = checkBoxM3;
            checkBoxesDays[3][2] = checkBoxT3;
            checkBoxesDays[3][3] = checkBoxW3;
            checkBoxesDays[3][4] = checkBoxR3;
            checkBoxesDays[3][5] = checkBoxF3;
            checkBoxesDays[3][6] = checkBoxS3;

            checkBoxesDays[4] = new CheckBox[7];
            checkBoxesDays[4][0] = checkBoxSu4;
            checkBoxesDays[4][1] = checkBoxM4;
            checkBoxesDays[4][2] = checkBoxT4;
            checkBoxesDays[4][3] = checkBoxW4;
            checkBoxesDays[4][4] = checkBoxR4;
            checkBoxesDays[4][5] = checkBoxF4;
            checkBoxesDays[4][6] = checkBoxS4;

            checkBoxesDays[5] = new CheckBox[7];
            checkBoxesDays[5][0] = checkBoxSu5;
            checkBoxesDays[5][1] = checkBoxM5;
            checkBoxesDays[5][2] = checkBoxT5;
            checkBoxesDays[5][3] = checkBoxW5;
            checkBoxesDays[5][4] = checkBoxR5;
            checkBoxesDays[5][5] = checkBoxF5;
            checkBoxesDays[5][6] = checkBoxS5;
            

            Grouper[][] groups = new Grouper[6][];
            groups[0] = new Grouper[3];
            groups[0][0] = grouperDay0;
            groups[0][1] = grouperTime0;
            groups[0][2] = grouperDuration0;

            groups[1] = new Grouper[3];
            groups[1][0] = grouperDay1;
            groups[1][1] = grouperTime1;
            groups[1][2] = grouperDuration1;

            groups[2] = new Grouper[3];
            groups[2][0] = grouperDay2;
            groups[2][1] = grouperTime2;
            groups[2][2] = grouperDuration2;

            groups[3] = new Grouper[3];
            groups[3][0] = grouperDay3;
            groups[3][1] = grouperTime3;
            groups[3][2] = grouperDuration3;

            groups[4] = new Grouper[3];
            groups[4][0] = grouperDay4;
            groups[4][1] = grouperTime4;
            groups[4][2] = grouperDuration4;

            groups[5] = new Grouper[3];
            groups[5][0] = grouperDay5;
            groups[5][1] = grouperTime5;
            groups[5][2] = grouperDuration5;


            decimal[] timeHour = new decimal[6];
            timeHour[0] = numericTimeHour0.Value;
            timeHour[1] = numericTimeHour1.Value;
            timeHour[2] = numericTimeHour2.Value;
            timeHour[3] = numericTimeHour3.Value;
            timeHour[4] = numericTimeHour4.Value;
            timeHour[5] = numericTimeHour5.Value;

            decimal[] timeMinute = new decimal[6];
            timeMinute[0] = numericTimeMinute0.Value;
            timeMinute[1] = numericTimeMinute1.Value;
            timeMinute[2] = numericTimeMinute2.Value;
            timeMinute[3] = numericTimeMinute3.Value;
            timeMinute[4] = numericTimeMinute4.Value;
            timeMinute[5] = numericTimeMinute5.Value;

            decimal[] durationHours = new decimal[6];
            durationHours[0] = numericDurationHour0.Value;
            durationHours[1] = numericDurationHour1.Value;
            durationHours[2] = numericDurationHour2.Value;
            durationHours[3] = numericDurationHour3.Value;
            durationHours[4] = numericDurationHour4.Value;
            durationHours[5] = numericDurationHour5.Value;

            decimal[] durationMinutes = new decimal[6];
            durationMinutes[0] = numericDurationMinute0.Value;
            durationMinutes[1] = numericDurationMinute1.Value;
            durationMinutes[2] = numericDurationMinute2.Value;
            durationMinutes[3] = numericDurationMinute3.Value;
            durationMinutes[4] = numericDurationMinute4.Value;
            durationMinutes[5] = numericDurationMinute5.Value;

            TextBox[] conditionsMet = new TextBox[6];
            conditionsMet[0] = textBoxConditionsMet0;
            conditionsMet[1] = textBoxConditionsMet1;
            conditionsMet[2] = textBoxConditionsMet2;
            conditionsMet[3] = textBoxConditionsMet3;
            conditionsMet[4] = textBoxConditionsMet4;
            conditionsMet[5] = textBoxConditionsMet5;
            

            //int i = 0;

            // Cycling through each group to check if conditions are met
            for (int i=0; i<6; i++) 
            {
            if (checkDay(groups[i][0], checkBoxesDays[i]) == true &&
                    checkTime(groups[i][1], groups[i][2], timeHour[i], timeMinute[i], durationHours[i], durationMinutes[i]) == true)
                {
                    conditionsMet[i].Text = "1";
                }
                else
                {
                    conditionsMet[i].Text = "0";
                }
            }
            setImages();
  
        }


        // checks whether the day(s) selected equal today
        // Takes in an array of checkboxes representing the checkbox objects on the HMI
        private Boolean checkDay(Grouper group, CheckBox[] checkBoxDays)
        {
            int day = (int)DateTime.Now.DayOfWeek;

            Boolean conditionMet = false;

            if (checkBoxDays[0].Checked == true && day == 0) conditionMet = true;
            if (checkBoxDays[1].Checked == true && day == 1) conditionMet = true;
            if (checkBoxDays[2].Checked == true && day == 2) conditionMet = true;
            if (checkBoxDays[3].Checked == true && day == 3) conditionMet = true;
            if (checkBoxDays[4].Checked == true && day == 4) conditionMet = true;
            if (checkBoxDays[5].Checked == true && day == 5) conditionMet = true;
            if (checkBoxDays[6].Checked == true && day == 6) conditionMet = true;

            if (group.Enabled == true)
            {
                if (conditionMet == true)
                {
                    conditionIsMet(group);
                }
                else
                {
                    conditionIsNotMet(group);
                }
            }
            // If the group is disabled, 
            else
            {
                conditionMet = true;
            }

            return conditionMet;
        }



        // Checks whether the time values are equal to now
        private Boolean checkTime(Grouper timeGroup, Grouper durationGroup, 
            decimal startHour, decimal startMinute, decimal durationHours, decimal durationMinutes)
        {
            Boolean isNow = false;

            DateTime sysDate = DateTime.Now;
            DateTime startTime = new DateTime(sysDate.Year, sysDate.Month, sysDate.Day, Convert.ToInt16(startHour),Convert.ToInt16(startMinute),0);
            DateTime endTime = startTime.AddHours(Convert.ToDouble(durationHours));
                       endTime = endTime.AddMinutes(Convert.ToDouble(durationMinutes));

            if (timeGroup.Enabled == true)
            {
                if (sysDate >= startTime && sysDate <= endTime)
                {
                    conditionIsMet(timeGroup);
                    conditionIsMet(durationGroup);
                    isNow = true;
                }
                else
                {
                    conditionIsNotMet(timeGroup);
                    conditionIsNotMet(durationGroup);
                }
            }
            else
            {
                isNow = true;
            }
            return isNow;
        }

        // Modifies grouper box to indicate conditions are met
        private void conditionIsMet(Grouper group)
        {
            group.BorderColor = System.Drawing.Color.Green;
        }

        // Modifies grouper box to indicate conditions are NOT met
        private void conditionIsNotMet(Grouper group)
        {
            group.BorderColor = System.Drawing.Color.Black;
        }

        // Swaps an Image out based on vRegister value
        private void setImage(TextBox vRegister, PictureBox img, string imgIf0, string imgIf1)
        {
            if (vRegister.Text == "1")
            {
                img.ImageLocation = imgIf1;
            }
            else
            {
                img.ImageLocation = imgIf0;
            }
        }
        // Setting the on / off Images and force images
        // depending on what the logic (internal textboxes / virtual registers are set to)
        private void setImages()
        {
            //addEvent("set Image function called");

            string offButton = "C:\\Users\\Owner\\Documents\\Visual Studio 2013\\Projects\\Home Automation\\WindowsFormsApplication8\\images\\switch_off_small.jpg";
            string onButton =  "C:\\Users\\Owner\\Documents\\Visual Studio 2013\\Projects\\Home Automation\\WindowsFormsApplication8\\images\\switch_on_small.jpg";
            string forceOff = "C:\\Users\\Owner\\Documents\\Visual Studio 2013\\Projects\\Home Automation\\WindowsFormsApplication8\\images\\force_off.jpg";
            string forceOn = "C:\\Users\\Owner\\Documents\\Visual Studio 2013\\Projects\\Home Automation\\WindowsFormsApplication8\\images\\force_on.jpg";

            setImage(textBoxOn0, onOff0, offButton, onButton);
            setImage(textBoxOn1, onOff1, offButton, onButton);
            setImage(textBoxOn2, onOff2, offButton, onButton);
            setImage(textBoxOn3, onOff3, offButton, onButton);
            setImage(textBoxOn4, onOff4, offButton, onButton);
            setImage(textBoxOn5, onOff5, offButton, onButton);

            setImage(textBoxForce0, switchForce0, forceOff, forceOn);
            setImage(textBoxForce1, switchForce1, forceOff, forceOn);
            setImage(textBoxForce2, switchForce2, forceOff, forceOn);
            setImage(textBoxForce3, switchForce3, forceOff, forceOn);
            setImage(textBoxForce4, switchForce4, forceOff, forceOn);
            setImage(textBoxForce5, switchForce5, forceOff, forceOn);
        }


        string boolToInt(string x)
        {
            if (x == "True")
                return "1";
            else
                return "0";
        }


        // Switching bits inside the PLC
        private void dataToPLC(int vRegister)
        {
            try
            {
                addEvent("Data sent to PLC for channel " + vRegister.ToString() + "");

                switch (vRegister) { 
                        
                    case 0:
                        serialConn1.Write("B3:0/0", textBoxOn0.Text);
                    break;

                    case 1:
                        serialConn1.Write("B3:1/0", textBoxOn1.Text);
                    break;

                    case 2:
                        serialConn1.Write("B3:2/0", textBoxOn2.Text);
                    break;

                    case 3:
                        serialConn1.Write("B3:3/0", textBoxOn3.Text);
                    break;

                    case 4:
                        serialConn1.Write("B3:4/0", textBoxOn4.Text);
                    break;

                    case 5:
                        serialConn1.Write("B3:5/0", textBoxOn5.Text);
                    break;

                    case 6:
                        serialConn1.Write("B3:0/0", textBoxOn0.Text);
                        serialConn1.Write("B3:1/0", textBoxOn1.Text);
                        serialConn1.Write("B3:2/0", textBoxOn2.Text);
                        serialConn1.Write("B3:3/0", textBoxOn3.Text);
                        serialConn1.Write("B3:4/0", textBoxOn4.Text);
                        serialConn1.Write("B3:5/0", textBoxOn5.Text);
                    break;
                    /*
                    serialConn1.Write("B3:6/0", textBoxForce0.Text);
                    serialConn1.Write("B3:7/0", textBoxForce1.Text);
                    serialConn1.Write("B3:8/0", textBoxForce2.Text);
                    serialConn1.Write("B3:9/0", textBoxForce3.Text);
                    serialConn1.Write("B3:10/0", textBoxForce4.Text);
                    serialConn1.Write("B3:11/0", textBoxForce5.Text);
                        **/
                }
            }
            catch
            {
                commError(true);
            }
        }


        // Toggling on / Off if force is enabled
        private void toggleOn(TextBox vRegisterOnOff, TextBox vRegisterForce)
        {
            addEvent("Toggled " + vRegisterOnOff.Text + " / " + vRegisterForce.Text);

            if (vRegisterForce.Text == "1")
            {
                if (vRegisterOnOff.Text == "0")
                {
                    vRegisterOnOff.Text = "1";
                }
                else
                {
                    vRegisterOnOff.Text = "0";
                }
            }
        }
        // When user clicks On / Off # 0
        private void onOff0_Click(object sender, EventArgs e)
        {
            toggleOn(textBoxOn0, textBoxForce0);
           
        }
        // When user clicks On /Of # 1
        private void onOff1_Click(object sender, EventArgs e)
        {
            toggleOn(textBoxOn1, textBoxForce1);
        }

        // When user clicks On /Of # 2
        private void onOff2_Click(object sender, EventArgs e)
        {
            toggleOn(textBoxOn2, textBoxForce2);
        }


        // When user clicks On /Of # 3
        private void onOff3_Click(object sender, EventArgs e)
        {
            toggleOn(textBoxOn3, textBoxForce3);
        }

        // When user clicks On /Of # 4
        private void onOff4_Click(object sender, EventArgs e)
        {
            toggleOn(textBoxOn4, textBoxForce4);
        }

        // When user clicks On /Of # 5
        private void onOff5_Click(object sender, EventArgs e)
        {
            toggleOn(textBoxOn5, textBoxForce5);
        }



        private void commTimer_Tick(object sender, EventArgs e)
        {
            //addEvent("tick");
            checkConditions();
        }




        // The next block of code is for when a FORCE button is clicked
        private void switchForce0_Click(object sender, EventArgs e)
        {
            switchForceClick(0);
        }
        
        private void switchForce1_Click(object sender, EventArgs e)
        {
            switchForceClick(1);
        }

        private void switchForce2_Click(object sender, EventArgs e)
        {
            switchForceClick(2);
        }

        private void switchForce3_Click(object sender, EventArgs e)
        {
            switchForceClick(3);
        }

        private void switchForce4_Click(object sender, EventArgs e)
        {
            switchForceClick(4);
        }

        private void switchForce5_Click(object sender, EventArgs e)
        {
            switchForceClick(5);
        }
        // Switches the force button logic
        // Takes in the textbox name of the box to switch
        private void switchForceClick(int switchNumber)
        {
            Grouper day, duration, time;
            TextBox vRegister;
            PictureBox calandarPic, clockPic;

            switch (switchNumber)
            {
                case 0:
                    day = grouperDay0;
                    duration = grouperDuration0;
                    time = grouperTime0;
                    vRegister = textBoxForce0;
                    calandarPic = pictureBoxSchedule0;
                    clockPic = pictureBoxClock0;
                    break;

                case 1:
                    day = grouperDay1;
                    duration = grouperDuration1;
                    time = grouperTime1;
                    vRegister = textBoxForce1;
                    calandarPic = pictureBoxSchedule1;
                    clockPic = pictureBoxClock1;
                    break;

                case 2:
                    day = grouperDay2;
                    duration = grouperDuration2;
                    time = grouperTime2;
                    vRegister = textBoxForce2;
                    calandarPic = pictureBoxSchedule2;
                    clockPic = pictureBoxClock2;
                    break;

                case 3:
                    day = grouperDay3;
                    duration = grouperDuration3;
                    time = grouperTime3;
                    vRegister = textBoxForce3;
                    calandarPic = pictureBoxSchedule3;
                    clockPic = pictureBoxClock3;
                    break;

                case 4:
                    day = grouperDay4;
                    duration = grouperDuration4;
                    time = grouperTime4;
                    vRegister = textBoxForce4;
                    calandarPic = pictureBoxSchedule4;
                    clockPic = pictureBoxClock4;
                    break;

                case 5:
                    day = grouperDay5;
                    duration = grouperDuration5;
                    time = grouperTime5;
                    vRegister = textBoxForce5;
                    calandarPic = pictureBoxSchedule5;
                    clockPic = pictureBoxClock5;
                    break;

                default:
                    day = grouperDay0;
                    duration = grouperDuration0;
                    time = grouperTime0;
                    vRegister = textBoxForce0;
                    calandarPic = pictureBoxSchedule0;
                    clockPic = pictureBoxClock0;
                    addEvent("*** Exception encountered when applying force button ***");
                    break;

            } 
            //  If force off, turn on
            if (vRegister.Text == "0")
            {
                addEvent("Force enabled on " + vRegister.Name);

                vRegister.Text = "1";
                disableGroup(day);
                disableGroup(duration);
                disableGroup(time);

                calandarPic.Enabled = false;
                clockPic.Enabled = false;
            }
            // If force on turn off
            else
            {
                addEvent("Force disabled on " + vRegister.Name);

                calandarPic.Enabled = true;
                clockPic.Enabled = true;
                
                vRegister.Text = "0";
                enableGroup(day);
                enableGroup(duration);
                enableGroup(time);
            }
        }

        // This function toggles a group box on or off
        private void toggleGroupBox(Grouper group)
        {
            if (group.Enabled == true)
            {
                disableGroup(group);
            }
            else
            {
                enableGroup(group);
            }
        }

        // This function disables a group box
        private void disableGroup(Grouper group) 
        {
            addEvent("disable group called");
            group.Enabled = false;
            group.BackgroundColor = System.Drawing.Color.LightGray;
            group.GroupTitle = "[disabled]";
            group.BorderColor = System.Drawing.Color.LightGray;
        }

        // This function enables the group
        private void enableGroup(Grouper group)
        {
            addEvent("enable group called");
            string caption = "";

            if (group == grouperDay0 || 
                group == grouperDay1 ||
                group == grouperDay2)

            {
                caption = "Enable on Day";
            }
            if (group == grouperDuration0 ||
                group == grouperDuration1 ||
                group == grouperDuration2)
            {
                caption = "Duration";
            }
            if (group == grouperTime0 ||
                group == grouperTime1 ||
                group == grouperTime2)
            {
                caption = "Enable on Time";
            }

            group.Enabled = true;
            group.BackgroundColor = System.Drawing.Color.White;
            group.BorderColor = System.Drawing.Color.Black;
            group.GroupTitle = caption;
            checkConditions();
        }

        

        // Numeric Hours and Minutes once Clicked
        private void numericHour0_ValueChanged(object sender, EventArgs e)
        {
            checkConditions();
        }

        private void numericMinute0_ValueChanged(object sender, EventArgs e)
        {
            checkConditions();
        }

        private void numericDurationHour0_ValueChanged(object sender, EventArgs e)
        {
            checkConditions();
        }

        private void numericDurationMinute0_ValueChanged(object sender, EventArgs e)
        {
            checkConditions();
        }


        private void numericTimeHour1_ValueChanged(object sender, EventArgs e)
        {
            checkConditions();
        }

        private void numericTimeMinute1_ValueChanged(object sender, EventArgs e)
        {
            checkConditions();
        }

        private void numericDurationHour1_ValueChanged_1(object sender, EventArgs e)
        {
            checkConditions();
        }

        private void numericDurationMinute1_ValueChanged_1(object sender, EventArgs e)
        {
            checkConditions();
        }

        private void numericTimeHour2_ValueChanged(object sender, EventArgs e)
        {
            checkConditions();
        }

        private void numericTimeMinute2_ValueChanged(object sender, EventArgs e)
        {
            checkConditions();
        }

        private void numericDurationHour2_ValueChanged_1(object sender, EventArgs e)
        {
            checkConditions();
        }

        private void numericDurationMinute2_ValueChanged_1(object sender, EventArgs e)
        {
            checkConditions();
        }



        // When the condition changes in a vRegister, toggle in on/off
        private void textBoxConditionsMet0_TextChanged(object sender, EventArgs e)
        {
            vRegisterConditionChange(textBoxConditionsMet0, textBoxOn0, textBoxForce0);
        }

        private void textBoxConditionsMet1_TextChanged(object sender, EventArgs e)
        {
            vRegisterConditionChange(textBoxConditionsMet1, textBoxOn1, textBoxForce1);
        }
        private void textBoxConditionsMet2_TextChanged(object sender, EventArgs e)
        {
            vRegisterConditionChange(textBoxConditionsMet2, textBoxOn2, textBoxForce2);
        }

        private void textBoxConditionsMet3_TextChanged(object sender, EventArgs e)
        {
            vRegisterConditionChange(textBoxConditionsMet3, textBoxOn3, textBoxForce3);
        }

        private void textBoxConditionsMet4_TextChanged(object sender, EventArgs e)
        {
            vRegisterConditionChange(textBoxConditionsMet4, textBoxOn4, textBoxForce4);
        }

        private void textBoxConditionsMet5_TextChanged(object sender, EventArgs e)
        {
            vRegisterConditionChange(textBoxConditionsMet5, textBoxOn5, textBoxForce5);
        }



        private void vRegisterConditionChange(TextBox condition, TextBox target, TextBox force)
        {
            if (force.Text == "0" && condition.Text == "1")
            {
                writeVRegister(target, "1");
                addEvent("Condition changed IF [ " + condition.Name.ToString() + "= 1 & " + force.Name.ToString() + " : set " + target.Name.ToString() + " to 1");
            }
            else 
            {
                addEvent("Condition changed ELSE [ " + condition.Name.ToString() + " = '"+condition.Text.ToString() + "' " + force.Name.ToString() + " = '" + force.Text.ToString() + "' || set " + target.Name.ToString() + " to 0");
                writeVRegister(target, "0");
            }
            
        }
        private void writeVRegister(TextBox vRegister, string text)
        {
            vRegister.Text = text;
        }



        // When the condition vRegister changes, send new information to PLC
        private void textBoxOn0_TextChanged(object sender, EventArgs e)
        {
            dataToPLC(0);
        }

        private void textBoxOn1_TextChanged(object sender, EventArgs e)
        {
            dataToPLC(1);
        }

        private void textBoxOn2_TextChanged(object sender, EventArgs e)
        {
            dataToPLC(2);
        }

        private void textBoxOn3_TextChanged(object sender, EventArgs e)
        {
            dataToPLC(3);
        }

        private void textBoxOn4_TextChanged(object sender, EventArgs e)
        {
            dataToPLC(4);
        }

        private void textBoxOn5_TextChanged(object sender, EventArgs e)
        {
            dataToPLC(5);
        }

        private void comboBoxComm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (updateCommSettings() == true)
            {
                dataToPLC(6);
            }
                
        }

        // Saving the project
        private void label1_Click(object sender, EventArgs e)
        {
            saveValues();
        }


        // Days of the week once checked
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            checkConditions();
        }


        // Clicking on the Scheduler Icon to Enable / Disable
        private void pictureBoxSchedule0_Click(object sender, EventArgs e)
        {
            toggleGroupBox(grouperDay0);
            checkConditions();
        }

        private void pictureBoxSchedule1_Click(object sender, EventArgs e)
        {
            toggleGroupBox(grouperDay1);
            checkConditions();
        }

        private void pictureBoxSchedule2_Click(object sender, EventArgs e)
        {
            toggleGroupBox(grouperDay2);
            checkConditions();
        }
        private void pictureBoxSchedule3_Click(object sender, EventArgs e)
        {
            toggleGroupBox(grouperDay3);
            checkConditions();
        }

        private void pictureBoxSchedule4_Click(object sender, EventArgs e)
        {
            toggleGroupBox(grouperDay4);
            checkConditions();
        }

        private void pictureBoxSchedule5_Click(object sender, EventArgs e)
        {
            toggleGroupBox(grouperDay5);
            checkConditions();
        }




        // Clicking on the Clock Icon to Enable / Disable
        private void pictureBoxClock0_Click(object sender, EventArgs e)
        {
            toggleGroupBox(grouperTime0);
            toggleGroupBox(grouperDuration0);
            checkConditions();
        }
        private void pictureBoxClock1_Click(object sender, EventArgs e)
        {
            toggleGroupBox(grouperTime1);
            toggleGroupBox(grouperDuration1);
            checkConditions();
        }

        private void pictureBoxClock2_Click(object sender, EventArgs e)
        {
            toggleGroupBox(grouperTime2);
            toggleGroupBox(grouperDuration2);
            checkConditions();
        }

        private void pictureBoxClock3_Click(object sender, EventArgs e)
        {
            toggleGroupBox(grouperTime3);
            toggleGroupBox(grouperDuration3);
            checkConditions();
        }

        private void pictureBoxClock4_Click(object sender, EventArgs e)
        {
            toggleGroupBox(grouperTime4);
            toggleGroupBox(grouperDuration4);
            checkConditions();
        }

        private void pictureBoxClock5_Click(object sender, EventArgs e)
        {
            toggleGroupBox(grouperTime5);
            toggleGroupBox(grouperDuration5);
            checkConditions();
        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void tabViewOverview_Click(object sender, EventArgs e)
        {

        }


    }

}
