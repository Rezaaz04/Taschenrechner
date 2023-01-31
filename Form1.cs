using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        public void FirstNumExist() //Diese Methode prüft, ob der Nutzer schon die erste Eingabe (Zahl) getätigt hat.
        {
            if(lblFirstNum.Text == "")
            {
                MessageBox.Show("Trage bitte zuerst eine Zahl ein!");
                lblArithmeticOP.Text = "";
            }
            else if(lblFirstNum.Text != "")
            {
                lblFirstNumIsEmpty.Text = "t";
            }
        }

        private void bttnMult_Click(object sender, EventArgs e) //Der Rechenoperator "Multiplikation" wurde vom Nutzer gewählt.
        {
            lblArithmeticOP.Text = "×";
            FirstNumExist();
        }

        private void bttnDiv_Click(object sender, EventArgs e) //Der Rechenoperator "Division" wurde vom Nutzer gewählt.
        {
            lblArithmeticOP.Text = "÷";
            FirstNumExist();
        }

        private void bttnPlus_Click(object sender, EventArgs e) //Der Rechenoperator "Plus" wurde vom Nutzer gewählt.
        {
            lblArithmeticOP.Text = "+";
            FirstNumExist();
        }

        private void bttnMinus_Click(object sender, EventArgs e) //Der Rechenoperator "Minus" wurde vom Nutzer gewählt.
        {
            lblArithmeticOP.Text = "-";
            FirstNumExist();
        }

        private void bttnNum1_Click(object sender, EventArgs e)
        {
            if(lblFirstNumIsEmpty.Text == "")
            {
                lblFirstNum.Text += "1";
            }
            else if(lblFirstNumIsEmpty.Text != "")
            {
                lblSecondNum.Text += "1";
            }
        }

        private void bttnNum2_Click(object sender, EventArgs e)
        {
            if(lblFirstNumIsEmpty.Text == "")
            {
                lblFirstNum.Text += "2";
            }
            else if (lblFirstNumIsEmpty.Text != "")
            {
                lblSecondNum.Text += "2";
            }
        }

        private void bttnNum3_Click(object sender, EventArgs e)
        {
            if (lblFirstNumIsEmpty.Text == "")
            {
                lblFirstNum.Text += "3";
            }
            else if (lblFirstNumIsEmpty.Text != "")
            {
                lblSecondNum.Text += "3";
            }
        }

        private void bttnNum4_Click(object sender, EventArgs e)
        {
            if (lblFirstNumIsEmpty.Text == "")
            {
                lblFirstNum.Text += "4";
            }
            else if (lblFirstNumIsEmpty.Text != "")
            {
                lblSecondNum.Text += "4";
            }
        }

        private void bttnNum5_Click(object sender, EventArgs e)
        {
            if (lblFirstNumIsEmpty.Text == "")
            {
                lblFirstNum.Text += "5";
            }
            else if (lblFirstNumIsEmpty.Text != "")
            {
                lblSecondNum.Text += "5";
            }
        }

        private void bttnNum6_Click(object sender, EventArgs e)
        {
            if (lblFirstNumIsEmpty.Text == "")
            {
                lblFirstNum.Text += "6";
            }
            else if (lblFirstNumIsEmpty.Text != "")
            {
                lblSecondNum.Text += "6";
            }
        }

        private void bttnNum7_Click(object sender, EventArgs e)
        {
            if (lblFirstNumIsEmpty.Text == "")
            {
                lblFirstNum.Text += "7";
            }
            else if (lblFirstNumIsEmpty.Text != "")
            {
                lblSecondNum.Text += "7";
            }
        }

        private void bttnNum8_Click(object sender, EventArgs e)
        {
            if (lblFirstNumIsEmpty.Text == "")
            {
                lblFirstNum.Text += "8";
            }
            else if (lblFirstNumIsEmpty.Text != "")
            {
                lblSecondNum.Text += "8";
            }
        }

        private void bttnNum9_Click(object sender, EventArgs e)
        {
            if (lblFirstNumIsEmpty.Text == "")
            {
                lblFirstNum.Text += "9";
            }
            else if (lblFirstNumIsEmpty.Text != "")
            {
                lblSecondNum.Text += "9";
            }
        }

        private void bttnNum0_Click(object sender, EventArgs e)
        {
            if (lblFirstNumIsEmpty.Text == "")
            {
                lblFirstNum.Text += "0";
            }
            else if (lblFirstNumIsEmpty.Text != "")
            {
                lblSecondNum.Text += "0";
            }
        }

        private void bttnDelete_Click(object sender, EventArgs e)
        {
            lblArithmeticOP.Text = ""; //Alle Eingaben werden zurückgesetzt.
            lblFirstNum.Text = "";
            lblSecondNum.Text = "";
            lblFirstNumIsEmpty.Text = "";
            lblEquals.Text = "";
        }

        private void bttnNegativ_Click(object sender, EventArgs e)
        {
            if(lblFirstNumIsEmpty.Text == "" && lblFirstNum.Text == "")
            {
                lblFirstNum.Text += "-";
            }
            else
            {
                MessageBox.Show("Entferne deine Eingabe, bevor du mit mit negativen Werten rechen willst.");
            }
        }

        public double Addition(double Zahl1, double Zahl2) //Die Methoden, welche die Rechnungen mit den Nutzereingaben durchführen.
        {
            return Zahl1 + Zahl2;
        }
        public double Subtraktion(double Zahl1, double Zahl2)
        {
            return Zahl1 - Zahl2;
        }
        public double Division(double Zahl1, double Zahl2)
        {
            return Zahl1 / Zahl2;
        }
        public double Multiplikation(double Zahl1, double Zahl2)
        {
            return Zahl1 * Zahl2;
        }

        private void bttnCalc_Click(object sender, EventArgs e)
        {
            if (lblFirstNum.Text == "" || lblSecondNum.Text == "") //Dieses If-Statement überprüft, ob der Nutzer schon seine Werte eingetragen hat.
            {
                MessageBox.Show("Du musst zuerst deine Zahlen eintragen!");
                MessageBox.Show("Du kannst ja nicht einmal ein Taschenrechner bedienen!");
            }
            else //Wenn die Eingaben vorhanden sind, dann soll die jeweilige Methode ausgeführt werden.
            {
                double Zahl1 = Convert.ToDouble(lblFirstNum.Text);
                double Zahl2 = Convert.ToDouble(lblSecondNum.Text);
                
                if (lblArithmeticOP.Text == "+")
                {
                    double ergebnis = Addition(Zahl1, Zahl2);
                    lblEquals.Text = Convert.ToString(ergebnis);
                }
                else if (lblArithmeticOP.Text == "-")
                {
                    double ergebnis = Subtraktion(Zahl1, Zahl2);
                    lblEquals.Text = Convert.ToString(ergebnis);
                }
                else if (lblArithmeticOP.Text == "×")
                {
                    double ergebnis = Multiplikation(Zahl1, Zahl2);
                    lblEquals.Text = Convert.ToString(ergebnis);
                }
                else if (lblArithmeticOP.Text == "÷")
                {
                    double ergebnis = Division(Zahl1, Zahl2);
                    lblEquals.Text = Convert.ToString(ergebnis);
                }

            }

        }
    }
}
