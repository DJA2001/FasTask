namespace TaskApp
{
    partial class NewTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnNewTask = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboPriority = new System.Windows.Forms.ComboBox();
            this.dateDate = new System.Windows.Forms.DateTimePicker();
            this.AssignedPerson = new System.Windows.Forms.Label();
            this.comboAssignedPerson = new System.Windows.Forms.ComboBox();
            this.tblFamilyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Time = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tblFamilyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Task Title";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 418);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Description";
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.Location = new System.Drawing.Point(163, 41);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(205, 20);
            this.txtTaskTitle.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(26, 446);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(455, 173);
            this.txtDescription.TabIndex = 7;
            // 
            // btnNewTask
            // 
            this.btnNewTask.BackColor = System.Drawing.Color.DarkGreen;
            this.btnNewTask.ForeColor = System.Drawing.Color.White;
            this.btnNewTask.Location = new System.Drawing.Point(26, 625);
            this.btnNewTask.Name = "btnNewTask";
            this.btnNewTask.Size = new System.Drawing.Size(294, 33);
            this.btnNewTask.TabIndex = 8;
            this.btnNewTask.Text = "Save as New Task";
            this.btnNewTask.UseVisualStyleBackColor = false;
            this.btnNewTask.Click += new System.EventHandler(this.btnNewTask_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.ForeColor = System.Drawing.Color.Gray;
            this.button2.Location = new System.Drawing.Point(326, 625);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 33);
            this.button2.TabIndex = 9;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 359);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Priority";
            // 
            // comboPriority
            // 
            this.comboPriority.FormattingEnabled = true;
            this.comboPriority.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Urgent"});
            this.comboPriority.Location = new System.Drawing.Point(135, 365);
            this.comboPriority.Name = "comboPriority";
            this.comboPriority.Size = new System.Drawing.Size(121, 21);
            this.comboPriority.TabIndex = 11;
            // 
            // dateDate
            // 
            this.dateDate.CustomFormat = "MMMMdd, yyyy | hh:mm";
            this.dateDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDate.Location = new System.Drawing.Point(135, 201);
            this.dateDate.Name = "dateDate";
            this.dateDate.Size = new System.Drawing.Size(101, 20);
            this.dateDate.TabIndex = 13;
            this.dateDate.Value = new System.DateTime(2019, 10, 31, 0, 0, 0, 0);
            // 
            // AssignedPerson
            // 
            this.AssignedPerson.AutoSize = true;
            this.AssignedPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AssignedPerson.Location = new System.Drawing.Point(21, 116);
            this.AssignedPerson.Name = "AssignedPerson";
            this.AssignedPerson.Size = new System.Drawing.Size(175, 25);
            this.AssignedPerson.TabIndex = 14;
            this.AssignedPerson.Text = "Assigned Person";
            // 
            // comboAssignedPerson
            // 
            this.comboAssignedPerson.DataSource = this.tblFamilyBindingSource;
            this.comboAssignedPerson.DisplayMember = "FamilyMembers";
            this.comboAssignedPerson.FormattingEnabled = true;
            this.comboAssignedPerson.Location = new System.Drawing.Point(220, 122);
            this.comboAssignedPerson.Name = "comboAssignedPerson";
            this.comboAssignedPerson.Size = new System.Drawing.Size(148, 21);
            this.comboAssignedPerson.TabIndex = 15;
            this.comboAssignedPerson.ValueMember = "FamilyMembers";
            // 
            // tblFamilyBindingSource
            // 
            this.tblFamilyBindingSource.DataMember = "tbl_Family";
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(21, 277);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(59, 25);
            this.Time.TabIndex = 16;
            this.Time.Text = "Time";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(109, 283);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 17;
            // 
            // NewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(509, 678);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.comboAssignedPerson);
            this.Controls.Add(this.AssignedPerson);
            this.Controls.Add(this.dateDate);
            this.Controls.Add(this.comboPriority);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNewTask);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTaskTitle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "NewTask";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Task";
            ((System.ComponentModel.ISupportInitialize)(this.tblFamilyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnNewTask;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboPriority;
        private System.Windows.Forms.DateTimePicker dateDate;
        private System.Windows.Forms.Label AssignedPerson;
        private System.Windows.Forms.ComboBox comboAssignedPerson;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.BindingSource tblFamilyBindingSource;
    }
}