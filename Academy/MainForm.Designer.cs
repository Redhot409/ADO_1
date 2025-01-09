namespace Academy
{
    partial class MainForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageGroups = new System.Windows.Forms.TabPage();
            this.lblGroupsDirection = new System.Windows.Forms.Label();
            this.cbGroupsDirection = new System.Windows.Forms.ComboBox();
            this.dgvGroups = new System.Windows.Forms.DataGridView();
            this.statusStripGroups = new System.Windows.Forms.StatusStrip();
            this.tslGroupCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPageStudents = new System.Windows.Forms.TabPage();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.statusStripStudents = new System.Windows.Forms.StatusStrip();
            this.tslStudentsCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.statusStripTeachers = new System.Windows.Forms.StatusStrip();
            this.tslTeachersCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgTeachers = new System.Windows.Forms.DataGridView();
            this.cbStudentsGroup = new System.Windows.Forms.ComboBox();
            this.cbStudentsDirection = new System.Windows.Forms.ComboBox();
            this.lblStudentsGroup = new System.Windows.Forms.Label();
            this.lblStudentsDirection = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPageGroups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
            this.statusStripGroups.SuspendLayout();
            this.tabPageStudents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.statusStripStudents.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.statusStripTeachers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageGroups);
            this.tabControl.Controls.Add(this.tabPageStudents);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(876, 450);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageGroups
            // 
            this.tabPageGroups.Controls.Add(this.lblGroupsDirection);
            this.tabPageGroups.Controls.Add(this.cbGroupsDirection);
            this.tabPageGroups.Controls.Add(this.dgvGroups);
            this.tabPageGroups.Controls.Add(this.statusStripGroups);
            this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
            this.tabPageGroups.Name = "tabPageGroups";
            this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGroups.Size = new System.Drawing.Size(868, 424);
            this.tabPageGroups.TabIndex = 1;
            this.tabPageGroups.Text = "Groups";
            this.tabPageGroups.UseVisualStyleBackColor = true;
            // 
            // lblGroupsDirection
            // 
            this.lblGroupsDirection.AutoSize = true;
            this.lblGroupsDirection.Location = new System.Drawing.Point(177, 9);
            this.lblGroupsDirection.Name = "lblGroupsDirection";
            this.lblGroupsDirection.Size = new System.Drawing.Size(127, 13);
            this.lblGroupsDirection.TabIndex = 3;
            this.lblGroupsDirection.Text = "Направление обучения:";
            // 
            // cbGroupsDirection
            // 
            this.cbGroupsDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGroupsDirection.FormattingEnabled = true;
            this.cbGroupsDirection.Location = new System.Drawing.Point(310, 6);
            this.cbGroupsDirection.Name = "cbGroupsDirection";
            this.cbGroupsDirection.Size = new System.Drawing.Size(215, 21);
            this.cbGroupsDirection.TabIndex = 2;
            // 
            // dgvGroups
            // 
            this.dgvGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGroups.Location = new System.Drawing.Point(3, 39);
            this.dgvGroups.Name = "dgvGroups";
            this.dgvGroups.Size = new System.Drawing.Size(865, 330);
            this.dgvGroups.TabIndex = 1;
            // 
            // statusStripGroups
            // 
            this.statusStripGroups.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslGroupCount});
            this.statusStripGroups.Location = new System.Drawing.Point(3, 399);
            this.statusStripGroups.Name = "statusStripGroups";
            this.statusStripGroups.Size = new System.Drawing.Size(862, 22);
            this.statusStripGroups.TabIndex = 0;
            this.statusStripGroups.Text = "statusStrip1";
            // 
            // tslGroupCount
            // 
            this.tslGroupCount.Name = "tslGroupCount";
            this.tslGroupCount.Size = new System.Drawing.Size(107, 17);
            this.tslGroupCount.Text = "Количество групп";
            // 
            // tabPageStudents
            // 
            this.tabPageStudents.Controls.Add(this.lblStudentsDirection);
            this.tabPageStudents.Controls.Add(this.lblStudentsGroup);
            this.tabPageStudents.Controls.Add(this.cbStudentsDirection);
            this.tabPageStudents.Controls.Add(this.cbStudentsGroup);
            this.tabPageStudents.Controls.Add(this.dgvStudents);
            this.tabPageStudents.Controls.Add(this.statusStripStudents);
            this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
            this.tabPageStudents.Name = "tabPageStudents";
            this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudents.Size = new System.Drawing.Size(868, 424);
            this.tabPageStudents.TabIndex = 0;
            this.tabPageStudents.Text = "Students";
            this.tabPageStudents.UseVisualStyleBackColor = true;
            // 
            // dgvStudents
            // 
            this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(-6, 27);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(868, 336);
            this.dgvStudents.TabIndex = 1;
            // 
            // statusStripStudents
            // 
            this.statusStripStudents.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslStudentsCount});
            this.statusStripStudents.Location = new System.Drawing.Point(3, 399);
            this.statusStripStudents.Name = "statusStripStudents";
            this.statusStripStudents.Size = new System.Drawing.Size(862, 22);
            this.statusStripStudents.TabIndex = 0;
            this.statusStripStudents.Text = "statusStrip1";
            // 
            // tslStudentsCount
            // 
            this.tslStudentsCount.Name = "tslStudentsCount";
            this.tslStudentsCount.Size = new System.Drawing.Size(129, 17);
            this.tslStudentsCount.Text = "Количество студентов";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.statusStripTeachers);
            this.tabPage1.Controls.Add(this.dgvTeachers);
            this.tabPage1.Controls.Add(this.dgTeachers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(868, 424);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Teachers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Location = new System.Drawing.Point(0, 35);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.Size = new System.Drawing.Size(868, 350);
            this.dgvTeachers.TabIndex = 0;
            // 
            // statusStripTeachers
            // 
            this.statusStripTeachers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTeachersCount});
            this.statusStripTeachers.Location = new System.Drawing.Point(0, 402);
            this.statusStripTeachers.Name = "statusStripTeachers";
            this.statusStripTeachers.Size = new System.Drawing.Size(868, 22);
            this.statusStripTeachers.TabIndex = 1;
            this.statusStripTeachers.Text = "statusStrip1";
            // 
            // tslTeachersCount
            // 
            this.tslTeachersCount.Name = "tslTeachersCount";
            this.tslTeachersCount.Size = new System.Drawing.Size(129, 17);
            this.tslTeachersCount.Text = "Количество учителей:";
            // 
            // dgTeachers
            // 
            this.dgTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTeachers.Location = new System.Drawing.Point(26, 134);
            this.dgTeachers.Name = "dgTeachers";
            this.dgTeachers.Size = new System.Drawing.Size(784, 232);
            this.dgTeachers.TabIndex = 2;
            // 
            // cbStudentsGroup
            // 
            this.cbStudentsGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudentsGroup.FormattingEnabled = true;
            this.cbStudentsGroup.Location = new System.Drawing.Point(151, 4);
            this.cbStudentsGroup.Name = "cbStudentsGroup";
            this.cbStudentsGroup.Size = new System.Drawing.Size(121, 21);
            this.cbStudentsGroup.TabIndex = 2;
            // 
            // cbStudentsDirection
            // 
            this.cbStudentsDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudentsDirection.FormattingEnabled = true;
            this.cbStudentsDirection.Location = new System.Drawing.Point(498, 3);
            this.cbStudentsDirection.Name = "cbStudentsDirection";
            this.cbStudentsDirection.Size = new System.Drawing.Size(274, 21);
            this.cbStudentsDirection.TabIndex = 3;
            // 
            // lblStudentsGroup
            // 
            this.lblStudentsGroup.AutoSize = true;
            this.lblStudentsGroup.Location = new System.Drawing.Point(86, 7);
            this.lblStudentsGroup.Name = "lblStudentsGroup";
            this.lblStudentsGroup.Size = new System.Drawing.Size(45, 13);
            this.lblStudentsGroup.TabIndex = 4;
            this.lblStudentsGroup.Text = "Группа:";
            // 
            // lblStudentsDirection
            // 
            this.lblStudentsDirection.AutoSize = true;
            this.lblStudentsDirection.Location = new System.Drawing.Point(350, 7);
            this.lblStudentsDirection.Name = "lblStudentsDirection";
            this.lblStudentsDirection.Size = new System.Drawing.Size(127, 13);
            this.lblStudentsDirection.TabIndex = 5;
            this.lblStudentsDirection.Text = "Направление обучения:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Academy";
            this.tabControl.ResumeLayout(false);
            this.tabPageGroups.ResumeLayout(false);
            this.tabPageGroups.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
            this.statusStripGroups.ResumeLayout(false);
            this.statusStripGroups.PerformLayout();
            this.tabPageStudents.ResumeLayout(false);
            this.tabPageStudents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.statusStripStudents.ResumeLayout(false);
            this.statusStripStudents.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.statusStripTeachers.ResumeLayout(false);
            this.statusStripTeachers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTeachers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageStudents;
        private System.Windows.Forms.TabPage tabPageGroups;
        private System.Windows.Forms.StatusStrip statusStripStudents;
        private System.Windows.Forms.ToolStripStatusLabel tslStudentsCount;
        private System.Windows.Forms.StatusStrip statusStripGroups;
        private System.Windows.Forms.ToolStripStatusLabel tslGroupCount;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridView dgvGroups;
        private System.Windows.Forms.Label lblGroupsDirection;
        private System.Windows.Forms.ComboBox cbGroupsDirection;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.StatusStrip statusStripTeachers;
        private System.Windows.Forms.ToolStripStatusLabel tslTeachersCount;
        private System.Windows.Forms.DataGridView dgTeachers;
        private System.Windows.Forms.ComboBox cbStudentsGroup;
        private System.Windows.Forms.ComboBox cbStudentsDirection;
        private System.Windows.Forms.Label lblStudentsDirection;
        private System.Windows.Forms.Label lblStudentsGroup;
    }
}

