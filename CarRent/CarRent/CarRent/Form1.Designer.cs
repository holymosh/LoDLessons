namespace CarRent
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FromLabel = new System.Windows.Forms.Label();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.ToLabel = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.CarList = new System.Windows.Forms.ListBox();
            this.carDescription = new System.Windows.Forms.RichTextBox();
            this.orderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FromLabel
            // 
            this.FromLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FromLabel.Location = new System.Drawing.Point(402, 64);
            this.FromLabel.Name = "FromLabel";
            this.FromLabel.Size = new System.Drawing.Size(134, 22);
            this.FromLabel.TabIndex = 0;
            this.FromLabel.Text = "From:";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(406, 102);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerFrom.TabIndex = 1;
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Location = new System.Drawing.Point(402, 144);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(31, 20);
            this.ToLabel.TabIndex = 2;
            this.ToLabel.Text = "To:";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(406, 178);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerTo.TabIndex = 3;
            // 
            // CarList
            // 
            this.CarList.FormattingEnabled = true;
            this.CarList.ItemHeight = 20;
            this.CarList.Location = new System.Drawing.Point(23, 64);
            this.CarList.Name = "CarList";
            this.CarList.Size = new System.Drawing.Size(341, 464);
            this.CarList.TabIndex = 4;
            // 
            // carDescription
            // 
            this.carDescription.Location = new System.Drawing.Point(406, 241);
            this.carDescription.Name = "carDescription";
            this.carDescription.Size = new System.Drawing.Size(200, 227);
            this.carDescription.TabIndex = 5;
            this.carDescription.Text = "";
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(406, 502);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(200, 33);
            this.orderButton.TabIndex = 6;
            this.orderButton.Text = "Make An Order ";
            this.orderButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(639, 568);
            this.Controls.Add(this.orderButton);
            this.Controls.Add(this.carDescription);
            this.Controls.Add(this.CarList);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.ToLabel);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.FromLabel);
            this.Name = "Form1";
            this.Text = "Аренда машин";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FromLabel;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.ListBox CarList;
        private System.Windows.Forms.RichTextBox carDescription;
        private System.Windows.Forms.Button orderButton;
    }
}

