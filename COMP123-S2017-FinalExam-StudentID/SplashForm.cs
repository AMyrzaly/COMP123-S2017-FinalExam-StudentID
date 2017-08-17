using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Abubakir Myrzaly
 * Date: 8/17/2017
 * StudentID: 300931945
 * Description: Splash Form
 * Version: 0.1 Created Splash form
 */

namespace COMP123_S2017_FinalExam_StudentID
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PickHighestCardForm pickHighestCardForm = new PickHighestCardForm();
            pickHighestCardForm.Show();
            this.Hide();

            SplashFormTimer.Enabled = false;
        }
    }
}
