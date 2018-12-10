using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Form3 : Form
    {

        public string ID;
        public string FirstName;
        public string LastName;
        public string Phone;
        public string Address;
        public string City;
        public string State;
        public string ZipCode;
        public string Contract;

        Form1 form1;
        

      
        public Form3(Form1 f1)
        {
            InitializeComponent();
            form1 = f1;
        }

        public Form3()
        {
            InitializeComponent();   
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            idBox.Text = ID;
            fnameBox.Text = FirstName;
            lnameBox.Text = LastName;
            phoneBox.Text = Phone;
            addressBox.Text = Address;
            cityBox.Text = City;
            stateBox.Text = State;
            zipBox.Text = ZipCode;

            if (Contract == "Yes")
            {
                contractBox.Text = contractBox.Items[0].ToString();
            }

            if (Contract == "No")
            {
                contractBox.Text = contractBox.Items[1].ToString();
            }

            idBox.Enabled = false;


        }
        private void doneButton_Click(object sender, EventArgs e)
        {

            ID = idBox.Text.Trim();
            FirstName = fnameBox.Text.Trim();
            LastName = lnameBox.Text.Trim();
            Phone = phoneBox.Text.Trim();
            Address = addressBox.Text.Trim();
            City = cityBox.Text.Trim();
            State = stateBox.Text.Trim();
            ZipCode = zipBox.Text.Trim();

            if (ID == null || FirstName == null || LastName == null || Phone == null || Address == null || City == null || State == null || ZipCode == null || Contract == null)
            {
                MessageBox.Show("One or more fields missing valid input.");
                return;
            }

            if (string.IsNullOrWhiteSpace(ID))
            {
                MessageBox.Show("One or more fields missing valid input.");
                idBox.Text = null;
                return;
            }

            if (string.IsNullOrWhiteSpace(FirstName))
            {
                MessageBox.Show("One or more fields missing valid input.");
                fnameBox.Text = null;
                return;
            }


            if (string.IsNullOrWhiteSpace(LastName))
            {
                MessageBox.Show("One or more fields missing valid input.");
                lnameBox.Text = null;
                return;
            }

            if (string.IsNullOrWhiteSpace(Phone))
            {
                MessageBox.Show("One or more fields missing valid input.");
                phoneBox.Text = null;
                return;
            }

            if (string.IsNullOrWhiteSpace(Address))
            {
                MessageBox.Show("One or more fields missing valid input.");
                addressBox.Text = null;
                return;
            }

            if (string.IsNullOrWhiteSpace(City))
            {
                MessageBox.Show("One or more fields missing valid input.");
                cityBox.Text = null;
                return;
            }

            if (string.IsNullOrWhiteSpace(State))
            {
                MessageBox.Show("One or more fields missing valid input.");
                stateBox.Text = null;
                return;
            }

            if (string.IsNullOrWhiteSpace(ZipCode))
            {
                MessageBox.Show("One or more fields missing valid input.");
                zipBox.Text = null;
                return;
            }

            Close();
        }

        private void idBox_TextChanged(object sender, EventArgs e)
        {
            ID = idBox.Text;
        }

        private void fnameBox_TextChanged(object sender, EventArgs e)
        {
            FirstName = fnameBox.Text;
        }

        private void lnameBox_TextChanged(object sender, EventArgs e)
        {
            LastName = lnameBox.Text;
        }

        private void phoneBox_TextChanged(object sender, EventArgs e)
        {
            Phone = phoneBox.Text;
        }

        private void addressBox_TextChanged(object sender, EventArgs e)
        {
            Address = addressBox.Text;
        }

        private void cityBox_TextChanged(object sender, EventArgs e)
        {
            City = cityBox.Text;
        }

        private void stateBox_TextChanged(object sender, EventArgs e)
        {
            State = stateBox.Text;
        }

        private void zipBox_TextChanged(object sender, EventArgs e)
        {
            ZipCode = zipBox.Text;
        }

        private void contractBox_TextChanged(object sender, EventArgs e)
        {
            Contract = contractBox.Text;
        }



        private void idBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyPressed = e.KeyChar;
            if (Char.IsNumber(keyPressed) || (keyPressed == '-') || keyPressed == (Char)(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void fnameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyPressed = e.KeyChar;

            if (Char.IsLetter(keyPressed) || keyPressed == (Char)(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void lnameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyPressed = e.KeyChar;

            if (Char.IsLetter(keyPressed) || keyPressed == (Char)(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void phoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyPressed = e.KeyChar;
            if (Char.IsNumber(keyPressed) || (keyPressed == '-') || keyPressed == (Char)(Keys.Back) || keyPressed == (Char)(Keys.Space))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void cityBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyPressed = e.KeyChar;

            if (Char.IsLetter(keyPressed) || keyPressed == (Char)(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void stateBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyPressed = e.KeyChar;

            if (Char.IsLetter(keyPressed) || keyPressed == (Char)(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void zipBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyPressed = e.KeyChar;
            if (Char.IsNumber(keyPressed) || keyPressed == (Char)(Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void contractBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


    }
}


