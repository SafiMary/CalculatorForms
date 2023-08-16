namespace CalculatorForms
{
    partial class FormCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculator));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTwo = new System.Windows.Forms.Label();
            this.labelOne = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.textBoxThree = new System.Windows.Forms.TextBox();
            this.textBoxTwo = new System.Windows.Forms.TextBox();
            this.textBoxOne = new System.Windows.Forms.TextBox();
            this.comboBoxForm = new System.Windows.Forms.ComboBox();
            this.labelColour = new System.Windows.Forms.Label();
            this.labelForm = new System.Windows.Forms.Label();
            this.groupBoxChoice = new System.Windows.Forms.GroupBox();
            this.buttonColour = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBoxChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(504, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Результат";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(442, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Выберите операцию";
            // 
            // labelTwo
            // 
            this.labelTwo.AutoSize = true;
            this.labelTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTwo.Location = new System.Drawing.Point(638, 78);
            this.labelTwo.Name = "labelTwo";
            this.labelTwo.Size = new System.Drawing.Size(167, 20);
            this.labelTwo.TabIndex = 15;
            this.labelTwo.Text = "Введите 2-е число";
            // 
            // labelOne
            // 
            this.labelOne.AutoSize = true;
            this.labelOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOne.Location = new System.Drawing.Point(273, 78);
            this.labelOne.Name = "labelOne";
            this.labelOne.Size = new System.Drawing.Size(167, 20);
            this.labelOne.TabIndex = 14;
            this.labelOne.Text = "Введите 1-е число";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(642, 365);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(135, 49);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTwo.Location = new System.Drawing.Point(323, 365);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(135, 49);
            this.buttonTwo.TabIndex = 12;
            this.buttonTwo.Text = "Очистить";
            this.buttonTwo.UseVisualStyleBackColor = true;
            this.buttonTwo.Click += new System.EventHandler(this.buttonTwo_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOne.Location = new System.Drawing.Point(469, 188);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(158, 49);
            this.buttonOne.TabIndex = 13;
            this.buttonOne.Text = "Посчитать";
            this.buttonOne.UseVisualStyleBackColor = true;
            this.buttonOne.Click += new System.EventHandler(this.buttonOne_Click);
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBox.Location = new System.Drawing.Point(493, 120);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(95, 33);
            this.comboBox.TabIndex = 10;
            // 
            // textBoxThree
            // 
            this.textBoxThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxThree.Location = new System.Drawing.Point(493, 290);
            this.textBoxThree.Name = "textBoxThree";
            this.textBoxThree.Size = new System.Drawing.Size(121, 30);
            this.textBoxThree.TabIndex = 7;
            // 
            // textBoxTwo
            // 
            this.textBoxTwo.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxTwo.Location = new System.Drawing.Point(665, 120);
            this.textBoxTwo.Name = "textBoxTwo";
            this.textBoxTwo.Size = new System.Drawing.Size(103, 30);
            this.textBoxTwo.TabIndex = 8;
            // 
            // textBoxOne
            // 
            this.textBoxOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOne.Location = new System.Drawing.Point(314, 120);
            this.textBoxOne.Name = "textBoxOne";
            this.textBoxOne.Size = new System.Drawing.Size(97, 30);
            this.textBoxOne.TabIndex = 9;
            // 
            // comboBoxForm
            // 
            this.comboBoxForm.FormattingEnabled = true;
            this.comboBoxForm.Items.AddRange(new object[] {
            "восмигранник",
            "элипс",
            "трапеция"});
            this.comboBoxForm.Location = new System.Drawing.Point(26, 238);
            this.comboBoxForm.Name = "comboBoxForm";
            this.comboBoxForm.Size = new System.Drawing.Size(147, 28);
            this.comboBoxForm.TabIndex = 18;
            this.comboBoxForm.SelectedIndexChanged += new System.EventHandler(this.comboBoxForm_SelectedIndexChanged);
            // 
            // labelColour
            // 
            this.labelColour.AutoSize = true;
            this.labelColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelColour.Location = new System.Drawing.Point(22, 76);
            this.labelColour.Name = "labelColour";
            this.labelColour.Size = new System.Drawing.Size(138, 20);
            this.labelColour.TabIndex = 16;
            this.labelColour.Text = "Выберите цвет";
            // 
            // labelForm
            // 
            this.labelForm.AutoSize = true;
            this.labelForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelForm.Location = new System.Drawing.Point(19, 189);
            this.labelForm.Name = "labelForm";
            this.labelForm.Size = new System.Drawing.Size(154, 20);
            this.labelForm.TabIndex = 16;
            this.labelForm.Text = "Выберите форму";
            // 
            // groupBoxChoice
            // 
            this.groupBoxChoice.Controls.Add(this.buttonColour);
            this.groupBoxChoice.Controls.Add(this.comboBoxForm);
            this.groupBoxChoice.Controls.Add(this.labelForm);
            this.groupBoxChoice.Controls.Add(this.labelColour);
            this.groupBoxChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxChoice.Location = new System.Drawing.Point(64, 78);
            this.groupBoxChoice.Name = "groupBoxChoice";
            this.groupBoxChoice.Size = new System.Drawing.Size(178, 349);
            this.groupBoxChoice.TabIndex = 19;
            this.groupBoxChoice.TabStop = false;
            this.groupBoxChoice.Text = "Изменение цвета и формы";
            // 
            // buttonColour
            // 
            this.buttonColour.Location = new System.Drawing.Point(26, 128);
            this.buttonColour.Name = "buttonColour";
            this.buttonColour.Size = new System.Drawing.Size(147, 31);
            this.buttonColour.TabIndex = 19;
            this.buttonColour.UseVisualStyleBackColor = true;
            this.buttonColour.Click += new System.EventHandler(this.buttonColour_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClose.BackgroundImage")));
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.Location = new System.Drawing.Point(314, 218);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 55);
            this.buttonClose.TabIndex = 20;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // FormCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.groupBoxChoice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelTwo);
            this.Controls.Add(this.labelOne);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.textBoxThree);
            this.Controls.Add(this.textBoxTwo);
            this.Controls.Add(this.textBoxOne);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCalculator";
            this.Text = "Калькулятор";
            this.Load += new System.EventHandler(this.FormCalculator_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormCalculator_MouseDown);
            this.groupBoxChoice.ResumeLayout(false);
            this.groupBoxChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTwo;
        private System.Windows.Forms.Label labelOne;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.TextBox textBoxThree;
        private System.Windows.Forms.TextBox textBoxTwo;
        private System.Windows.Forms.TextBox textBoxOne;
        private System.Windows.Forms.ComboBox comboBoxForm;
        private System.Windows.Forms.Label labelColour;
        private System.Windows.Forms.Label labelForm;
        private System.Windows.Forms.GroupBox groupBoxChoice;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonColour;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

