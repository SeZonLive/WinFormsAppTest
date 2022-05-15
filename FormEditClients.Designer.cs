
namespace WinFormsAppTest
{
    partial class FormEditClients
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNaimenovanie = new System.Windows.Forms.TextBox();
            this.textBoxINN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxSferyDeyatelnosti = new System.Windows.Forms.ComboBox();
            this.tSferyDeyatelnostiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tESTDataSet = new WinFormsAppTest.TESTDataSet();
            this.t_SferyDeyatelnostiTableAdapter = new WinFormsAppTest.TESTDataSetTableAdapters.T_SferyDeyatelnostiTableAdapter();
            this.textBoxPrimechanie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tSferyDeyatelnostiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 50);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(256, 10);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Наименование:";
            // 
            // textBoxNaimenovanie
            // 
            this.textBoxNaimenovanie.Location = new System.Drawing.Point(7, 30);
            this.textBoxNaimenovanie.Multiline = true;
            this.textBoxNaimenovanie.Name = "textBoxNaimenovanie";
            this.textBoxNaimenovanie.Size = new System.Drawing.Size(365, 48);
            this.textBoxNaimenovanie.TabIndex = 2;
            // 
            // textBoxINN
            // 
            this.textBoxINN.Location = new System.Drawing.Point(7, 113);
            this.textBoxINN.Name = "textBoxINN";
            this.textBoxINN.Size = new System.Drawing.Size(365, 20);
            this.textBoxINN.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "ИНН:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Сфера деятельности:";
            // 
            // comboBoxSferyDeyatelnosti
            // 
            this.comboBoxSferyDeyatelnosti.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tSferyDeyatelnostiBindingSource, "ID_SferyDeyatelnosti", true));
            this.comboBoxSferyDeyatelnosti.DataSource = this.tSferyDeyatelnostiBindingSource;
            this.comboBoxSferyDeyatelnosti.DisplayMember = "SferaDeyatelnosti";
            this.comboBoxSferyDeyatelnosti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSferyDeyatelnosti.FormattingEnabled = true;
            this.comboBoxSferyDeyatelnosti.Location = new System.Drawing.Point(7, 174);
            this.comboBoxSferyDeyatelnosti.Name = "comboBoxSferyDeyatelnosti";
            this.comboBoxSferyDeyatelnosti.Size = new System.Drawing.Size(361, 21);
            this.comboBoxSferyDeyatelnosti.TabIndex = 7;
            this.comboBoxSferyDeyatelnosti.ValueMember = "ID_SferyDeyatelnosti";
            // 
            // tSferyDeyatelnostiBindingSource
            // 
            this.tSferyDeyatelnostiBindingSource.DataMember = "T_SferyDeyatelnosti";
            this.tSferyDeyatelnostiBindingSource.DataSource = this.tESTDataSet;
            // 
            // tESTDataSet
            // 
            this.tESTDataSet.DataSetName = "TESTDataSet";
            this.tESTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // t_SferyDeyatelnostiTableAdapter
            // 
            this.t_SferyDeyatelnostiTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxPrimechanie
            // 
            this.textBoxPrimechanie.Location = new System.Drawing.Point(7, 236);
            this.textBoxPrimechanie.Multiline = true;
            this.textBoxPrimechanie.Name = "textBoxPrimechanie";
            this.textBoxPrimechanie.Size = new System.Drawing.Size(365, 48);
            this.textBoxPrimechanie.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Примечание:";
            // 
            // FormEditClients
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(378, 353);
            this.Controls.Add(this.textBoxPrimechanie);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxSferyDeyatelnosti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxINN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNaimenovanie);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormEditClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEdit";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tSferyDeyatelnostiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tESTDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxNaimenovanie;
        public System.Windows.Forms.TextBox textBoxINN;
        public System.Windows.Forms.ComboBox comboBoxSferyDeyatelnosti;
        private System.Windows.Forms.BindingSource tSferyDeyatelnostiBindingSource;
        public TESTDataSet tESTDataSet;
        public TESTDataSetTableAdapters.T_SferyDeyatelnostiTableAdapter t_SferyDeyatelnostiTableAdapter;
        public System.Windows.Forms.TextBox textBoxPrimechanie;
        private System.Windows.Forms.Label label4;
    }
}