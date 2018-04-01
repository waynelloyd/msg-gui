/*
 * Created by SharpDevelop.
 * User: Wayne
 * Date: 05/09/2009
 * Time: 22:40
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MSG_GUI
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			  if (textBox2.Text.Length == 0)
            {

                // Initializes the variables to pass to the MessageBox.Show method.

                string message = "You did not specify a Username";
                string caption = "No Username Specified";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(this, message, caption, buttons,
                                         MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
			  }
			   else if (textBox1.Text.Length == 0)
            {

                // Initializes the variables to pass to the MessageBox.Show method.

                string message = "You did not enter a message";
                string caption = "";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(this, message, caption, buttons,
                                         MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            }
			  else if (textBox2.Text.Length > 0)
			  {
			System.Diagnostics.Process.Start("msg.exe", " /server:" + textBox3.Text + " " + textBox2.Text + " " + textBox1.Text);
			//MessageBox.Show("msg.exe /server:" + comboBox2.Text + " " + comboBox1.Text + " " + textBox1.Text);
		
			  }
		}
	}
}
