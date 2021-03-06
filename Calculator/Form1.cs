using System;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;

namespace Calculator
{

    //Basic calculator Version 1.0 made by Hakam <3

    public partial class Form1 : Form
    {
        #region Constructor
        public Form1()
        {
            InitializeComponent();
        }

        #endregion
 

        #region settings
        private void CE_Click(object sender, EventArgs e)
        {

            this.userInputText.Text = string.Empty;
            this.calculationResultText.Text = string.Empty;
            FocusInputText();
        }

        private void Del_Click(object sender, EventArgs e)
        {

            deleteTextValue();
            FocusInputText();

        }

        private void C_Click(object sender, EventArgs e)
        {
            this.userInputText.Text = string.Empty;
            FocusInputText();
        }

        private void Result_Click(object sender, EventArgs e)
        {

        }


        #endregion



        #region actions

        private void Multi_Click(object sender, EventArgs e)
        {
            insetTextValue("*");
            FocusInputText();
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            insetTextValue("/");
            FocusInputText();
        }



        private void Minus_Click(object sender, EventArgs e)
        {
            insetTextValue("-");
            FocusInputText();
        }


        private void Plus_Click(object sender, EventArgs e)
        {
            insetTextValue("+");
            FocusInputText();
        }

        private void Percentage_Click(object sender, EventArgs e)
        {
            insetTextValue("%");
            FocusInputText();
        }



        private void Equal_Click(object sender, EventArgs e)
        {
            CalculateEquation();
            FocusInputText();
        }

        private void Dot_Click(object sender, EventArgs e)
        {
            //insetTextValue(".");
            MessageBox.Show("I'll add the ability to use float values in the next version, thanks :)!");
            FocusInputText();
        }


        private void OpenPunc_Click(object sender, EventArgs e)
        {
            insetTextValue("(");
        }

        private void ClosePunc_Click(object sender, EventArgs e)
        {
            insetTextValue(")");
        }






        #endregion



        #region numbers

        private void Zero_Click(object sender, EventArgs e)
        {

            if (this.calculationResultText.Text == this.userInputText.Text)
                this.userInputText.Text = string.Empty;

            insetTextValue("0");
            FocusInputText();
        }

        private void One_Click(object sender, EventArgs e)
        {
            if (this.calculationResultText.Text == this.userInputText.Text)
                this.userInputText.Text = string.Empty;

            insetTextValue("1");
            FocusInputText();
        }


        private void Two_Click(object sender, EventArgs e)
        {
            if (this.calculationResultText.Text == this.userInputText.Text)
                this.userInputText.Text = string.Empty;

            insetTextValue("2");
            FocusInputText();
        }


        private void Three_Click(object sender, EventArgs e)
        {
            if (this.calculationResultText.Text == this.userInputText.Text)
                this.userInputText.Text = string.Empty;

            insetTextValue("3");
            FocusInputText();
        }


        private void Four_Click(object sender, EventArgs e)
        {
            if (this.calculationResultText.Text == this.userInputText.Text)
                this.userInputText.Text = string.Empty;

            insetTextValue("4");
            FocusInputText();
        }



        private void Five_Click(object sender, EventArgs e)
        {
            if (this.calculationResultText.Text == this.userInputText.Text)
                this.userInputText.Text = string.Empty;

            insetTextValue("5");
            FocusInputText();
        }




        private void Six_Click(object sender, EventArgs e)
        {
            if (this.calculationResultText.Text == this.userInputText.Text)
                this.userInputText.Text = string.Empty;

            insetTextValue("6");
            FocusInputText();
        }



        private void Seven_Click(object sender, EventArgs e)
        {
            if (this.calculationResultText.Text == this.userInputText.Text)
                this.userInputText.Text = string.Empty;

            insetTextValue("7");
            FocusInputText();
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            if (this.calculationResultText.Text == this.userInputText.Text)
                this.userInputText.Text = string.Empty;

            insetTextValue("8");
            FocusInputText();
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            if (this.calculationResultText.Text == this.userInputText.Text)
                this.userInputText.Text = string.Empty;

            insetTextValue("9");
            FocusInputText();
        }

        #endregion



        #region functions
        private void insetTextValue(string value)
        {
            //remember selection start
            var selectionStart = this.userInputText.SelectionStart;

            //set new text
            this.userInputText.Text = this.userInputText.Text.Insert(this.userInputText.SelectionStart, value);

            //restore selection start
            this.userInputText.SelectionStart = selectionStart + value.Length;

            //set selection length to 0 [Highlighted text]

            this.userInputText.SelectionLength = 0;

        }

        private void deleteTextValue()
        {
            if (this.userInputText.Text.Length < this.userInputText.SelectionStart + 1)
                return;

            //remember selection start
            var selectionStart = this.userInputText.SelectionStart;

            //Delete selection
            this.userInputText.Text = this.userInputText.Text.Remove(this.userInputText.SelectionStart, 1);

            //restore selection start
            this.userInputText.SelectionStart = selectionStart;

            //set selection length to 0 [Highlighted text]

            this.userInputText.SelectionLength = 0;

        }


        //Focus on result bar
        private void FocusInputText()
        {
            this.userInputText.Focus();
        }


        //Not finished
        private void CalculateEquation()
        {
            string temp = this.userInputText.Text;
            if (Solved(ref temp))
                this.calculationResultText.Text = temp;
            else
                this.calculationResultText.Text = "Invalid equasion";

            //Changes the value of the textbox to the result
            this.userInputText.Text = temp;
            this.userInputText.SelectionStart = temp.Length; //<-- Sets the selection start to the length of the result

            //Focus user input
            this.userInputText.Focus();

        }

        private bool Solved(ref string equasion)
        {

            #region Equasion validity

            #region remove Spaces from string
            //Remove spaces
            equasion = equasion.Replace(" ", "");
            //Replace % with /100 to make it an easier problem to solve
            equasion = equasion.Replace("%", "/100");
            #endregion

            #region characterCheck
            //This basically checks if the equasion is doesn't have any invalid character
            foreach (char item in equasion)
            {
                if (!(item >= '0' && item <= '9' || item == '(' || item == ')' || item == '*' || item == '/' || item == '+' || item == '-'))
                {
                    return false;
                }
            }
            #endregion

            #region punctuationCheck
            //This basically checks if the number of times ( & ) in the equasion was repeated equally else the equasion has an invalid input
            int punctuation = 0;
            foreach (char item in equasion)
            {
                if (item == '(')
                    punctuation++;
                else if (item == ')')
                    punctuation--;
            }
            if (punctuation != 0)
                return false; //<-- if true that means the equasion has invalid input
            #endregion

            #region equasion format check
            //Checks if the equasion starts with an invalid character
            for (int i = 0; i < equasion.Length; i++)
            {
                //Makes sure equasion doesn't start with those symbols
                if (i == 0)
                {
                    if (equasion[i] == '*' || equasion[i] == '/' || equasion[i] == '+')
                    {
                        return false;
                    }
                }

                //Makes sure symbols are in correct format
                if (i != 0 && i != equasion.Length - 1)
                {
                    if (equasion[i] == '*' || equasion[i] == '/' || equasion[i] == '+')
                    {
                        if (equasion[i - 1] == '*' || equasion[i - 1] == '/' || equasion[i - 1] == '+')
                            return false;
                        else if (equasion[i + 1] == '*' || equasion[i + 1] == '/' || equasion[i + 1] == '+')
                            return false;
                    }


                    else if (equasion[i] == '(')
                    {
                        if (equasion[i - 1] != '+' && equasion[i - 1] != '-' && equasion[i - 1] != '*' && equasion[i - 1] != '/' && equasion[i - 1] != '(')
                            return false;


                        else if (!(equasion[i + 1] != '+' && equasion[i + 1] != '-' && equasion[i + 1] != '*' && equasion[i + 1] != '/' && equasion[i + 1] != ')'))
                            return false;
                    }

                    else if (equasion[i] == ')')
                    {
                        if (!(equasion[i - 1] != '+' && equasion[i - 1] != '-' && equasion[i - 1] != '*' && equasion[i - 1] != '/' && equasion[i - 1] != '('))
                            return false;

                        else if (equasion[i + 1] != '+' && equasion[i + 1] != '-' && equasion[i + 1] != '*' && equasion[i + 1] != '/' && equasion[i + 1] != ')')
                            return false;

                    }
                }

                //Makes sure equasion doesn't end with those symbols
                if (i == equasion.Length - 1)
                {
                    if (equasion[i] == '*' || equasion[i] == '/' || equasion[i] == '+' || equasion[i] == '-')
                    {
                        return false;
                    }
                }
            }

            #endregion



            #endregion

            #region Calculations
            bool notFinished = true;
            while (notFinished) //notFinished if the equasion still has (/ + - *)
            {
                notFinished = !notFinished;
                //if there are no punctations in the equasion IE "()".
                if (equasion.IndexOf('(') == -1)
                {
                    if (equasion.IndexOf('/') != -1)
                    {
                        char symbol = '/';
                        if (!calculation(ref equasion, symbol))
                            return false;



                    }

                    else if (equasion.IndexOf('*') != -1)
                    {
                        char symbol = '*';
                        if (!calculation(ref equasion, symbol))
                            return false;
                    }

                    else if (equasion.IndexOf('+') != -1)
                    {
                        char symbol = '+';
                        calculation(ref equasion, symbol);
                    }

                    else if (equasion.IndexOf('-') != -1)
                    {
                        char symbol = '-';
                        calculation(ref equasion, symbol);
                    }
                }

                else
                {
                    int startIndex = equasion.IndexOf('(');
                    int endIndex = 0;

                    int openPunctation = 0;
                    int closePunctation = 0;

                    for (int i = startIndex; i < equasion.Length; i++)
                    {
                        if (equasion[i] == '(')
                            openPunctation++;

                        if (equasion[i] == ')')
                        {
                            closePunctation++;
                            endIndex = i;
                        }

                        if (openPunctation == closePunctation)
                            break;
                    }

                    //checks form validation -- )(  is not allowed.
                    if (endIndex < startIndex)
                        return false;

                    string insidePunctuation = equasion.Substring(startIndex + 1, endIndex - startIndex - 1);

                    Solved(ref insidePunctuation); //<-- Sent it to the same function to solve the equasion inside the punctations - () and then return with the result

                    equasion = equasion.Remove(startIndex, endIndex - startIndex + 1);
                    equasion = equasion.Insert(startIndex, insidePunctuation);
                }


                for (int i = 0; i < equasion.Length; i++)
                {
                    if (equasion[i] == '+' || equasion[i] == '*' || equasion[i] == '/' || equasion[i] == '(' || equasion[i] == ')') //<-- This checks if the equasion is solved
                        notFinished = true;

                    else if (i != 0 && equasion[i] == '-') //<-- there is a chance for the equasion to be negative
                        return true;

                }
            }

            #endregion

            return true;
        }

        private bool calculation(ref string equasion, char symbol)
        {
            //remembers the place of the symbol
            int index = equasion.IndexOf(symbol);
            //Takes the left side of the equasion
            string leftSide = "";
            int left = index - 1; //<-- because I want to remember the place where it ends
            for (; left >= 0 && equasion[left] != '/' && equasion[left] != '*' && equasion[left] != '+'; left--)
            {
                if (equasion[left] != '-')
                {
                    leftSide = leftSide.Insert(0, equasion[left].ToString());
                }
                else
                {
                    leftSide = leftSide.Insert(0, equasion[left].ToString());
                    break;
                }
            }
            left++;

            //Takes the right side of the equasion
            string rightSide = "";
            int right = index + 1;//<-- because I want to remember the place where it ends
            for (; right < equasion.Length && equasion[right] != '/' && equasion[right] != '*' && equasion[right] != '+'; right++)
            {
                rightSide += equasion[right];
            }
            right--;

            //Equasion done here
            string result = "";

            switch (symbol)
            {
                case '*':
                    result = (Convert.ToDouble(leftSide) * Convert.ToDouble(rightSide)).ToString();
                    break;
                case '/':
                    if (Convert.ToDouble(rightSide) == 0)
                        return false;

                    result = (Convert.ToDouble(leftSide) / Convert.ToDouble(rightSide)).ToString();

                    break;
                case '-':
                    result = (Convert.ToDouble(leftSide) - Convert.ToDouble(rightSide)).ToString();
                    break;
                case '+':
                    result = (Convert.ToDouble(leftSide) + Convert.ToDouble(rightSide)).ToString();
                    break;
            }

            equasion = equasion.Remove(left, right - left + 1);
            equasion = equasion.Insert(left, result);

            return true;
        }

        #endregion







        #region What am I doing in my life

        private void Squidward_Click(object sender, EventArgs e)
        {
            this.userInputText.Text = string.Empty;
            this.userInputText.Text = "Who clicked the dam button, leave me alone";
            FocusInputText();
            this.userInputText.SelectionLength = 0;
            this.userInputText.SelectionStart = this.userInputText.Text.Length;
        }

        private void Spongebob_Click(object sender, EventArgs e)
        {
            this.userInputText.Text = string.Empty;
            this.userInputText.Text = "I should find new friends";
            FocusInputText();
            this.userInputText.SelectionLength = 0;
            this.userInputText.SelectionStart = this.userInputText.Text.Length;
        }

        private void Patrick_Click(object sender, EventArgs e)
        {
            this.userInputText.Text = string.Empty;
            this.userInputText.Text = "I need a life";
            FocusInputText();
            this.userInputText.SelectionLength = 0;
            this.userInputText.SelectionStart = this.userInputText.Text.Length;


        }

        #endregion
    }
}
