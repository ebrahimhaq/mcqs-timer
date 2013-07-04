namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.examQuestionsDataSet1 = new WindowsFormsApplication2.ExamQuestionsDataSet();
            this.lblID = new System.Windows.Forms.Label();
            this.questionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.questionsTableAdapter = new WindowsFormsApplication2.ExamQuestionsDataSetTableAdapters.QuestionsTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.choiceA = new System.Windows.Forms.RadioButton();
            this.choiceB = new System.Windows.Forms.RadioButton();
            this.choiceC = new System.Windows.Forms.RadioButton();
            this.choiceD = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.answerDB = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.examQuestionsDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(148, 302);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 0;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(264, 302);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time Elapsed:";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.BackColor = System.Drawing.Color.White;
            this.lblMin.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblMin.Location = new System.Drawing.Point(346, 49);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(53, 37);
            this.lblMin.TabIndex = 3;
            this.lblMin.Text = "00";
            this.lblMin.Click += new System.EventHandler(this.lblMin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Exam Assistant";
            // 
            // examQuestionsDataSet1
            // 
            this.examQuestionsDataSet1.DataSetName = "ExamQuestionsDataSet";
            this.examQuestionsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "ID", true));
            this.lblID.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(97, 90);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(30, 17);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "(ID)";
            // 
            // questionsBindingSource
            // 
            this.questionsBindingSource.DataMember = "Questions";
            this.questionsBindingSource.DataSource = this.examQuestionsDataSet1;
            // 
            // questionsTableAdapter
            // 
            this.questionsTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Question#";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "Question", true));
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(38, 124);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(72, 17);
            this.lblQuestion.TabIndex = 7;
            this.lblQuestion.Text = "(Question)";
            // 
            // choiceA
            // 
            this.choiceA.AutoSize = true;
            this.choiceA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "Choice A", true));
            this.choiceA.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceA.Location = new System.Drawing.Point(35, 162);
            this.choiceA.Name = "choiceA";
            this.choiceA.Size = new System.Drawing.Size(89, 21);
            this.choiceA.TabIndex = 8;
            this.choiceA.TabStop = true;
            this.choiceA.Text = "(Choice A)";
            this.choiceA.UseVisualStyleBackColor = true;
            this.choiceA.CheckedChanged += new System.EventHandler(this.choiceA_CheckedChanged);
            // 
            // choiceB
            // 
            this.choiceB.AutoSize = true;
            this.choiceB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "Choice B", true));
            this.choiceB.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceB.Location = new System.Drawing.Point(337, 162);
            this.choiceB.Name = "choiceB";
            this.choiceB.Size = new System.Drawing.Size(88, 21);
            this.choiceB.TabIndex = 9;
            this.choiceB.TabStop = true;
            this.choiceB.Text = "(Choice B)";
            this.choiceB.UseVisualStyleBackColor = true;
            this.choiceB.CheckedChanged += new System.EventHandler(this.choiceB_CheckedChanged);
            // 
            // choiceC
            // 
            this.choiceC.AutoSize = true;
            this.choiceC.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "Choice C", true));
            this.choiceC.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceC.Location = new System.Drawing.Point(35, 209);
            this.choiceC.Name = "choiceC";
            this.choiceC.Size = new System.Drawing.Size(89, 21);
            this.choiceC.TabIndex = 10;
            this.choiceC.TabStop = true;
            this.choiceC.Text = "(Choice C)";
            this.choiceC.UseVisualStyleBackColor = true;
            // 
            // choiceD
            // 
            this.choiceD.AutoSize = true;
            this.choiceD.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "Choice D", true));
            this.choiceD.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choiceD.Location = new System.Drawing.Point(337, 209);
            this.choiceD.Name = "choiceD";
            this.choiceD.Size = new System.Drawing.Size(90, 21);
            this.choiceD.TabIndex = 11;
            this.choiceD.TabStop = true;
            this.choiceD.Text = "(Choice D)";
            this.choiceD.UseVisualStyleBackColor = true;
            this.choiceD.CheckedChanged += new System.EventHandler(this.choiceD_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 487);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Developed by Ebrahim Haq";
            // 
            // answerDB
            // 
            this.answerDB.AutoSize = true;
            this.answerDB.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.questionsBindingSource, "Correct Answer", true));
            this.answerDB.ForeColor = System.Drawing.SystemColors.Control;
            this.answerDB.Location = new System.Drawing.Point(21, 265);
            this.answerDB.Name = "answerDB";
            this.answerDB.Size = new System.Drawing.Size(48, 13);
            this.answerDB.TabIndex = 15;
            this.answerDB.Text = "(Answer)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(405, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 37);
            this.label6.TabIndex = 16;
            this.label6.Text = ":";
            // 
            // lblSec
            // 
            this.lblSec.AutoSize = true;
            this.lblSec.BackColor = System.Drawing.Color.White;
            this.lblSec.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSec.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblSec.Location = new System.Drawing.Point(436, 49);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(53, 37);
            this.lblSec.TabIndex = 17;
            this.lblSec.Text = "00";
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(161, 372);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(178, 72);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit Test";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(515, 523);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.answerDB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.choiceD);
            this.Controls.Add(this.choiceC);
            this.Controls.Add(this.choiceB);
            this.Controls.Add(this.choiceA);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.examQuestionsDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private ExamQuestionsDataSet examQuestionsDataSet1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.BindingSource questionsBindingSource;
        private ExamQuestionsDataSetTableAdapters.QuestionsTableAdapter questionsTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RadioButton choiceA;
        private System.Windows.Forms.RadioButton choiceB;
        private System.Windows.Forms.RadioButton choiceC;
        private System.Windows.Forms.RadioButton choiceD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label answerDB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Button btnSubmit;

    }
}

