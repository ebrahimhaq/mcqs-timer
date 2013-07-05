using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form

       

    {
        int score = 0;
        int sec=0;
        int min=0;
        int count;
        int idLbl;
        String zero = "0";
        public Form1()
        {
            InitializeComponent();
        }


        public void resetTimer()
        {

            timer1.Stop();
            timer1.Start();
             sec = 0;
             min = 0;
             lblMin.Text = zero + "0";
             lblMin.BackColor = System.Drawing.Color.White;
             lblSec.BackColor = System.Drawing.Color.White;
        }
      
       
        private void MyTimer_Tick(object sender, EventArgs e)
        {
          

            if (sec < 10)
            {
                lblSec.Text = zero + Convert.ToString(sec);
                sec++;
            }
            else {

                lblSec.Text = Convert.ToString(sec);
                sec++;
            
            }
             if (lblSec.Text == "60")
             {
                 sec = 0;
                   min++;
                   lblMin.Text = zero +  Convert.ToString(min); 

             }
             if (min == 2)
             {
                 min = 0;
                 questionsBindingSource.MoveNext();
                 resetTimer();
             }
            count++;

            if (lblMin.Visible && lblSec.Visible && lblMin.Text == "01" && lblSec.Text == "50")
            {
                lblMin.Visible = false;
                lblSec.Visible = false;

                lblMin.BackColor = System.Drawing.Color.Red;
                lblSec.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                lblMin.Visible = true;
                lblSec.Visible = true;
            }
           

          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'examQuestionsDataSet1.Questions' table. You can move, or remove it, as needed.
            this.questionsTableAdapter.Fill(this.examQuestionsDataSet1.Questions);

            timer1.Interval = (1000); 
            timer1.Tick += new EventHandler(MyTimer_Tick);
            timer1.Start();
            idLbl = Convert.ToInt32(lblID.Text);
            btnSubmit.Visible = false;
            
            //lblScore.Text = Convert.ToString(score);

        }
       

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (lblID.Text == "10")
            {
                btnSubmit.Visible = true;
                btnNext.Visible = false;
                btnPrevious.Visible = false;
                
            }
            
            if (choiceA.Checked && answerDB.Text == "A")
            {
                score += 10;
            }

            if (choiceB.Checked && answerDB.Text == "B")
            {
                score += 10;
            }

            if (choiceC.Checked && answerDB.Text == "C")
            {
                score += 10;
            }

            if (choiceD.Checked && answerDB.Text == "D")
            {
                score += 10;
            }
            //lblScore.Text = Convert.ToString(score);
            //moves to next question
           
            questionsBindingSource.MoveNext();
           
            resetTimer();
           
            //Sets radio button choices to false on next button click
            choiceA.Checked = false;
            choiceB.Checked = false;
            choiceC.Checked = false;
            choiceD.Checked = false;

        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //moves to previous question
            questionsBindingSource.MovePrevious();
            
        }

     
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            MessageBox.Show("Test Result:\nYou answered "+score/10+" question(s) correctly.\nYour score is: "+score);
            
        }
       
    }
}
