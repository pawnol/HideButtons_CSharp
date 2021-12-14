/*
 * Hide Buttons
 * Pawelski
 * 12/14/2021
 * This program should hide any button you click and reveal the other
 * buttons, but the code is not complete. Add the necessary code to
 * finish the program.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HideButtons
{
    public partial class HideButtonsForm : Form
    {
        public HideButtonsForm()
        {
            InitializeComponent();
        }

        private void topLeftButton_Click(object sender, EventArgs e)
        {
            topLeftButton.Visible = false;
            topRightButton.Visible = true;
            bottomLeftButton.Visible = true;
            bottomRightButton.Visible = true;
        }
    }
}
