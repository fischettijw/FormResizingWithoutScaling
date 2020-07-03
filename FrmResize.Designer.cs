namespace FormResizingWithoutScaling
{
    partial class FrmResize
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
            this.LblTop = new System.Windows.Forms.Label();
            this.LblLeft = new System.Windows.Forms.Label();
            this.LbxStudent = new System.Windows.Forms.ListBox();
            this.LblStudent = new System.Windows.Forms.Label();
            this.LblAge = new System.Windows.Forms.Label();
            this.LblSchool = new System.Windows.Forms.Label();
            this.LblComment = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.LblDate = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.LblUser = new System.Windows.Forms.Label();
            this.TxtDate = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // LblTop
            // 
            this.LblTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LblTop.Location = new System.Drawing.Point(0, 0);
            this.LblTop.Name = "LblTop";
            this.LblTop.Size = new System.Drawing.Size(784, 20);
            this.LblTop.TabIndex = 0;
            // 
            // LblLeft
            // 
            this.LblLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.LblLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LblLeft.Location = new System.Drawing.Point(0, 0);
            this.LblLeft.Name = "LblLeft";
            this.LblLeft.Size = new System.Drawing.Size(20, 561);
            this.LblLeft.TabIndex = 1;
            // 
            // LbxStudent
            // 
            this.LbxStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbxStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbxStudent.FormattingEnabled = true;
            this.LbxStudent.ItemHeight = 20;
            this.LbxStudent.Location = new System.Drawing.Point(36, 95);
            this.LbxStudent.MultiColumn = true;
            this.LbxStudent.Name = "LbxStudent";
            this.LbxStudent.Size = new System.Drawing.Size(736, 384);
            this.LbxStudent.TabIndex = 3;
            // 
            // LblStudent
            // 
            this.LblStudent.AutoSize = true;
            this.LblStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStudent.Location = new System.Drawing.Point(39, 71);
            this.LblStudent.Name = "LblStudent";
            this.LblStudent.Size = new System.Drawing.Size(112, 20);
            this.LblStudent.TabIndex = 4;
            this.LblStudent.Text = "Student Name";
            // 
            // LblAge
            // 
            this.LblAge.AutoSize = true;
            this.LblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAge.Location = new System.Drawing.Point(189, 71);
            this.LblAge.Name = "LblAge";
            this.LblAge.Size = new System.Drawing.Size(38, 20);
            this.LblAge.TabIndex = 5;
            this.LblAge.Text = "Age";
            // 
            // LblSchool
            // 
            this.LblSchool.AutoSize = true;
            this.LblSchool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSchool.Location = new System.Drawing.Point(287, 71);
            this.LblSchool.Name = "LblSchool";
            this.LblSchool.Size = new System.Drawing.Size(58, 20);
            this.LblSchool.TabIndex = 6;
            this.LblSchool.Text = "School";
            // 
            // LblComment
            // 
            this.LblComment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblComment.AutoSize = true;
            this.LblComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComment.Location = new System.Drawing.Point(493, 71);
            this.LblComment.Name = "LblComment";
            this.LblComment.Size = new System.Drawing.Size(78, 20);
            this.LblComment.TabIndex = 7;
            this.LblComment.Text = "Comment";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.Location = new System.Drawing.Point(36, 501);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(140, 40);
            this.BtnAdd.TabIndex = 8;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.Location = new System.Drawing.Point(317, 501);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(174, 40);
            this.BtnDelete.TabIndex = 9;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(632, 501);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(140, 40);
            this.BtnUpdate.TabIndex = 10;
            this.BtnUpdate.Text = "Update";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(69, 35);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(44, 20);
            this.LblDate.TabIndex = 11;
            this.LblDate.Text = "Date";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUserName.Location = new System.Drawing.Point(521, 32);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(214, 26);
            this.TxtUserName.TabIndex = 14;
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.Location = new System.Drawing.Point(403, 35);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(89, 20);
            this.LblUser.TabIndex = 13;
            this.LblUser.Text = "User Name";
            // 
            // TxtDate
            // 
            this.TxtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDate.Location = new System.Drawing.Point(158, 32);
            this.TxtDate.Mask = "00/00/0000";
            this.TxtDate.Name = "TxtDate";
            this.TxtDate.Size = new System.Drawing.Size(99, 26);
            this.TxtDate.TabIndex = 15;
            this.TxtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtDate.ValidatingType = typeof(System.DateTime);
            // 
            // FrmResize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.TxtDate);
            this.Controls.Add(this.TxtUserName);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.LblComment);
            this.Controls.Add(this.LblSchool);
            this.Controls.Add(this.LblAge);
            this.Controls.Add(this.LblStudent);
            this.Controls.Add(this.LbxStudent);
            this.Controls.Add(this.LblLeft);
            this.Controls.Add(this.LblTop);
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FrmResize";
            this.Text = "Form Resizing Without Scaling by Joseph Fischetti";
            this.Load += new System.EventHandler(this.FrmResize_Load);
            this.Resize += new System.EventHandler(this.FrmResize_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTop;
        private System.Windows.Forms.Label LblLeft;
        private System.Windows.Forms.ListBox LbxStudent;
        private System.Windows.Forms.Label LblStudent;
        private System.Windows.Forms.Label LblAge;
        private System.Windows.Forms.Label LblSchool;
        private System.Windows.Forms.Label LblComment;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.TextBox TxtUserName;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.MaskedTextBox TxtDate;
    }
}

