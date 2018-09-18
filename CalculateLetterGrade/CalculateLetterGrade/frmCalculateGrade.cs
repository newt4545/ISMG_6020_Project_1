using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateLetterGrade
{
	public partial class frmCalculateGrade : Form
	{
		public frmCalculateGrade()
		{
			InitializeComponent(); //Opens form
		}

		
		
			
		

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			decimal numberGrade = Convert.ToDecimal(txtNumberGrade.Text); //Defines number grade variable as a decimal
			string letterGrade = ""; //Defines letter grade variable as a string

			if (numberGrade >= 88)
			{
				letterGrade = "A"; //Sets an "A" as a grade greater than or equal to 88
			}
			else if (numberGrade >= 80 && numberGrade <= 87)
			{
				letterGrade = "B"; //Sets a "B" as any grade between 80 and 87
			}
			else if (numberGrade >= 68 && numberGrade <= 79)
			{
				letterGrade = "C"; //Sets a "C" as any grade between 68 and 79
			}
			else if (numberGrade >= 60 && numberGrade <= 67)
			{
				letterGrade = "D"; //Sets a "D" as any grade between 60 and 67
			}
			else
			{
				letterGrade = "F"; //All other grades are an "F"
			}

			txtLetterGrade.Text = letterGrade; //Assigns letter grade string to the letter grade var
			txtNumberGrade.Focus(); //Focuses the form on the number grade text box

		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close(); //Closes application on Exit button click
		}

		
	}
}
