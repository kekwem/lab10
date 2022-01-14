using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void intToString_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(firstTextBox.Text);
            int b = Convert.ToInt32(secondTextBox.Text);
            int c = Convert.ToInt32(thirdTextBox.Text);
            Trojka<int> element = new Trojka<int>(a, b, c);
            ContentTextBox.Text = element.ToString();
        }

        private void intSort_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(firstTextBox.Text);
            int b = Convert.ToInt32(secondTextBox.Text);
            int c = Convert.ToInt32(thirdTextBox.Text);
            Trojka<int> element = new Trojka<int>(a, b, c);
            element.Sort();
            ContentTextBox.Text = element.ToString();
        }

        private void stringToString_Click(object sender, EventArgs e)
        {
            Trojka<string> element = new Trojka<string>(firstTextBox.Text, secondTextBox.Text, thirdTextBox.Text);
            ContentTextBox.Text = element.ToString();
        }

        private void stringSort_Click(object sender, EventArgs e)
        {
            Trojka<string> element = new Trojka<string>(firstTextBox.Text, secondTextBox.Text, thirdTextBox.Text);
            element.Sort();
            ContentTextBox.Text = element.ToString();
        }

        private void personToString_Click(object sender, EventArgs e)
        {
            string[] persons = personTextBox.Text.Split('\n');
            string[] firstPerson = persons[0].Split(' ');
            string[] secondPerson = persons[1].Split(' ');
            string[] thirdPerson = persons[2].Split(' ');
            //
            Person pirwszy = new Person(firstPerson[0], firstPerson[1], Convert.ToDouble(firstPerson[2]),
                Convert.ToDouble( firstPerson[3]));
            Person drugi = new Person(secondPerson[0], secondPerson[1], Convert.ToDouble(secondPerson[2]),
                Convert.ToDouble(secondPerson[3]));
            Person trzeczi = new Person(thirdPerson[0], thirdPerson[1], Convert.ToDouble(thirdPerson[2]),
                Convert.ToDouble(thirdPerson[3]));
            Trojka<Person> element = new Trojka<Person>(pirwszy, drugi, trzeczi);
            ContentTextBox.Text = element.ToString();
        }

        private void personSort_Click(object sender, EventArgs e)
        {
            string[] persons = personTextBox.Text.Split('\n');
            string[] firstPerson = persons[0].Split(' ');
            string[] secondPerson = persons[1].Split(' ');
            string[] thirdPerson = persons[2].Split(' ');
            //
            Person pirwszy = new Person(firstPerson[0], firstPerson[1], Convert.ToDouble(firstPerson[2]),
                Convert.ToDouble(firstPerson[3]));
            Person drugi = new Person(secondPerson[0], secondPerson[1], Convert.ToDouble(secondPerson[2]),
                Convert.ToDouble(secondPerson[3]));
            Person trzeczi = new Person(thirdPerson[0], thirdPerson[1], Convert.ToDouble(thirdPerson[2]),
                Convert.ToDouble(thirdPerson[3]));
            Trojka<Person> element = new Trojka<Person>(pirwszy, drugi, trzeczi);
            element.Sort();
            ContentTextBox.Text = element.ToString();
        }
    }
}
