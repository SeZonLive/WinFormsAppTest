
namespace WinFormsAppTest
{
    partial class FormEditZayavki
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxNaimenovanie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxOpisanie = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtPickerDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.tStatusyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tESTDataSet = new WinFormsAppTest.TESTDataSet();
            this.t_StatusyTableAdapter = new WinFormsAppTest.TESTDataSetTableAdapters.T_StatusyTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tStatusyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 50);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(269, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(11, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxNaimenovanie
            // 
            this.textBoxNaimenovanie.Location = new System.Drawing.Point(6, 93);
            this.textBoxNaimenovanie.Multiline = true;
            this.textBoxNaimenovanie.Name = "textBoxNaimenovanie";
            this.textBoxNaimenovanie.Size = new System.Drawing.Size(365, 48);
            this.textBoxNaimenovanie.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Наименование работ:";
            // 
            // textBoxOpisanie
            // 
            this.textBoxOpisanie.Location = new System.Drawing.Point(6, 176);
            this.textBoxOpisanie.Multiline = true;
            this.textBoxOpisanie.Name = "textBoxOpisanie";
            this.textBoxOpisanie.Size = new System.Drawing.Size(365, 48);
            this.textBoxOpisanie.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Описание работ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата заявки:";
            // 
            // dtPickerDate
            // 
            this.dtPickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerDate.Location = new System.Drawing.Point(6, 32);
            this.dtPickerDate.Name = "dtPickerDate";
            this.dtPickerDate.Size = new System.Drawing.Size(364, 20);
            this.dtPickerDate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Статус:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tStatusyBindingSource, "ID_Status", true));
            this.comboBoxStatus.DataSource = this.tStatusyBindingSource;
            this.comboBoxStatus.DisplayMember = "Status";
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(6, 264);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(365, 21);
            this.comboBoxStatus.TabIndex = 11;
            this.comboBoxStatus.ValueMember = "ID_Status";
            // 
            // tStatusyBindingSource
            // 
            this.tStatusyBindingSource.DataMember = "T_Statusy";
            this.tStatusyBindingSource.DataSource = this.tESTDataSet;
            // 
            // tESTDataSet
            // 
            this.tESTDataSet.DataSetName = "TESTDataSet";
            this.tESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_StatusyTableAdapter
            // 
            this.t_StatusyTableAdapter.ClearBeforeFill = true;
            // 
            // FormEditZayavki
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(391, 355);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtPickerDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxOpisanie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNaimenovanie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormEditZayavki";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditZayavki";
            this.Load += new System.EventHandler(this.FormEditZayavki_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tStatusyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBoxNaimenovanie;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox textBoxOpisanie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource tStatusyBindingSource;
        public TESTDataSet tESTDataSet;
        public TESTDataSetTableAdapters.T_StatusyTableAdapter t_StatusyTableAdapter;
        public System.Windows.Forms.DateTimePicker dtPickerDate;
        public System.Windows.Forms.ComboBox comboBoxStatus;
    }
}