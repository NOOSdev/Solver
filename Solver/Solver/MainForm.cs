using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CollatzConjectureSolver;

namespace Solver
{
    public partial class Form1 : Form
    {
        private SolverClass solver;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox_inputvalue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            //Main class for calculation
            solver = new SolverClass();

            Button startButton = sender as Button;
            startButton.Enabled = false;

            //Input Value - inputNumber
            byte[] inputNumber = solver.StringToByteArr (textBox_inputvalue.Text);

            if (inputNumber == null)
            {
                MessageBox.Show("Error: Input number is empty.");
                startButton.Enabled = true;
                return;
            }

            TimeSpan tsStart = DateTime.Now.TimeOfDay;

            //Start to calculate
            solver.StartSolve(inputNumber);

            //Output values
            label_2k.Text = solver.Num2k.ToString();
            label_3K.Text = solver.Num3k.ToString();
            textBox_maxMember.Text = solver.ByteArrToString (solver.MaxUInt.Value);
            listBox_sequence.Items.Clear();

            //If need to show the sequence
            if (checkBox_showSequence.Checked) listBox_sequence.Items.AddRange(solver.MainSequence.ToArray());

            tsStart = DateTime.Now.TimeOfDay - tsStart;
            string messageRusult = string.Format("Finished. Time of calculation: {0:0.##} sec", tsStart.TotalSeconds);

            MessageBox.Show(messageRusult);

            startButton.Enabled = true;

            solver.Dispose();
        }
    }
}
