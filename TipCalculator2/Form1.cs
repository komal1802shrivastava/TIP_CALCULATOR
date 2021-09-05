using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator2
{
   
    public partial class Form1 : Form
    {
        //ERROR HANDLING CLASS
        class MyException : ApplicationException
        {
            //ERROR HANDLING FUNCTION WHEN USERS ENTER NEGATIVE NUMBER IN THE TIP FIELD .
            public void TipNegativeException()
            {
                MessageBox.Show("TIP SHOULD BE IN POSITIVE");
            }

            //ERROR HANDLING FUNCTION WHEN USERS ENTER ZERO OR NEGATIVE NUMBER IN THE NO. OF PEOPLE FIELD .
            public void PeopleNegativeZeroException()
            {
                MessageBox.Show("N0. OF PEOPLE SHOULD BE GREATER THAN ZERO");
            }

            //ERROR HANDLING FUNCTION WHEN USERS ENTER NEGATIVE NUMBER IN THE COSTOFMEAL FIELD .
            public void BillNegativeException()
            {
                MessageBox.Show("BILL SHOULD BE IN POSITIVE");
            }

            //ERROR HANDLING FUNCTION WHEN SOME UNEXPECTED SITUATION HAPPENS.
            public void UnexpectedError()
            {
                MessageBox.Show("SOMETHING IS WRONG !!! ");
            }

            //ERROR HANDLING FUNCTION WHEN NO. OF PEOPLE FIELDS NOT IS IN INTEGER.
            public void PeopleInteger()
            {
                MessageBox.Show("NUMBER OF PEOPLE SHOULD BE IN INTEGER !!! ");
            }

            //ERROR HANDLING FUNCTION WHEN USERS FORGET TO ENTER SOME DETAILS.
            public void FieldEmpty()
            {
                MessageBox.Show("FIELD IS EMPTY!!! ");
            }

        }


        public Form1()
        {
            InitializeComponent();
        }

        private void billBox(object sender, EventArgs e)    //COSTOFMEAL TEXTBOX.

        {
            try
            {
                //STATEMENT FOR ENTERING DETAILS IN COSTOFMEAL TEXTBOX
                double bill = Convert.ToDouble(this.billBoxField.Text);
            }

            catch (Exception)
            {
                //POPUP WHEN USER TRIES TO ENTER STRING IN COSTOFMEAL FIELDS.
                MessageBox.Show("BILL SHOULD BE IN NUMERIC VALUE !!! ");
            }
        }

        private void noOfPeopleBox(object sender, EventArgs e)     //No. of people textbox
        {
            try
            {
                //STATEMENT FOR ENTERING DETAILS IN NO. OF PEOPLE TEXTBOX.
                int noOfPeople = Convert.ToInt32(noOfPeopleField.Text);
            }

            catch (Exception)
            {
                //POPUP WHEN USER TRIES TO ENTER SOMETHING RATHER THAN INTEGER IN NO. OF PEOPLE FIELD .
                MessageBox.Show("NUMBER OF PEOPLE SHOULD BE INTEGER !!! ");
            }

        }


        //BUTTON WHICH DECREMENT THE TIP VALUE BY 1
        private void decrementTip(object sender, EventArgs e)
        {
            double tip;
            tip = Convert.ToDouble(tipBoxField.Text);
            tip = tip - 1;
            tipBoxField.Text = tip.ToString();

        }


        //BUTTON WHICH INCREMENT THE NO. OF PEOPLE VALUE BY 1
        private void incrementNoOfPeople(object sender, EventArgs e)
        {
            double noOfPeople;
            noOfPeople = Convert.ToDouble(noOfPeopleField.Text);
            noOfPeople = noOfPeople + 1;
            noOfPeopleField.Text = noOfPeople.ToString();

        }


        //BUTTON WHICH DECREMENT THE NO. OF PEOPLE VALUE BY 1
        private void decrementNoOfPeople(object sender, EventArgs e)
        {
            double noOfPeople;          // NO. OF PEOPLE
            noOfPeople = Convert.ToDouble(noOfPeopleField.Text);
            noOfPeople = noOfPeople - 1;
            noOfPeopleField.Text = noOfPeople.ToString();

        }


        //BUTTON WHICH INCREMENT THE TIP VALUE BY 1
        private void incrementTip(object sender, EventArgs e)
        {
            double tip;         //TIP
            tip = Convert.ToDouble(tipBoxField.Text);
            tip = tip + 1;
            tipBoxField.Text = tip.ToString();

        }

        private void tipBox(object sender, EventArgs e)
        {
            try
            {
                double tip = Convert.ToDouble(tipBoxField.Text);     //STATEMENT FOR ENTERING DETAILS IN TIP TEXTBOX.
            }

            catch (Exception)
            {
                MessageBox.Show("TIP SHOULD BE IN NUMERIC VALUE!!! ");    //POPUP WHEN USER TRIES TO ENTER STRING IN TIP FIELD .
            }
        }

        //BUTTON TO SUBMIT THE DETAILS IN THE FORM.
        private void submitButton(object sender, EventArgs e)
        {
            double costOfMeal;          // COST OF THE MEAL
            double tip;                  // TIP 
            int noOfPeople;              // NO. OF PEOPLE 
            double tipPerPerson;        // TIP PER PERSON
            double billPerPerson;       // BILL PER PERSON
            try
            {
                try
                {
                    //WHEN USER FORGETS TO PUT DETAILS IT WILL THROW AN ERROR
                    if (String.IsNullOrEmpty(billBoxField.Text) || String.IsNullOrEmpty(tipBoxField.Text) || String.IsNullOrEmpty(noOfPeopleField.Text))
                    {
                        throw new MyException();
                    }
                }

                catch(MyException ex6)
                {
                    ex6.FieldEmpty();

                }

                //INPUT OF THE COST OF MEAL TAKEN FROM THE USER.
                costOfMeal = Convert.ToDouble(billBoxField.Text);

                //INPUT OF THE TIP TAKEN FROM THE USER.
                tip = Convert.ToDouble(tipBoxField.Text);

                //INPUT OF THE NO. OF PEOPLE TAKEN FROM THE USER.
                noOfPeople = Convert.ToInt32(noOfPeopleField.Text);

                try
                {
                    //WHEN COST OF MEAL LESS THAN ZERO IT WILL THROW AN ERROR.
                    if (costOfMeal < 0)
                    {
                        throw new MyException();
                    }
                }

                catch(MyException ex1)
                {
                    //CALLING OF THE FUNCTION BillNegativeException
                    ex1.BillNegativeException();
                }

                try
                {
                    //WHEN TIP IS LESS  THAN ZERO IT WILL THROW AN ERROR. 
                    if (tip < 0)
                    {
                        throw new MyException();
                    }
                }

                catch(MyException ex2)
                {
                    //CALLING OF THE FUNCTION TipNegativeException.
                    ex2.TipNegativeException();
                }
                try
                {
                    //WHEN NO. OF PEOPLE IS LESS THAN OR EQUAL TO ZERO IT WILL THROW AN ERROR.
                    if(noOfPeople <= 0)
                    {
                        throw new MyException();
                    }
                }

                catch(MyException ex3)
                {
                    //CALLING OF THE FUNCTION .PeopleNegativeZeroException.
                    ex3.PeopleNegativeZeroException();
                }


                tipPerPerson = (costOfMeal * (tip / 100)) / noOfPeople;         //FORMULA FOR TIP PER PERSON
                billPerPerson = (costOfMeal / noOfPeople) + tipPerPerson;       //FORMULA FOR TOTAL BILL PER PERSON

                //TO SHOW THE OUTPUT OF THE TIP PER PERSON.
                listBox1.Items.Add(tipPerPerson.ToString("C"));

                //TO SHOW THE OUTPUT OF THE BILL PER PERSON.
                listBox2.Items.Add(billPerPerson.ToString("C"));
            }
            catch(MyException ex4)
            {
                //CALLING OF THE FUNCTION unexpectedError
                ex4.UnexpectedError();

            }                    

        }

      
    }
}
