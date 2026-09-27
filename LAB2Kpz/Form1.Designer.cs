namespace LAB2Kpz
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
            this.PBRoute = new System.Windows.Forms.PictureBox();
            this.CBRoute = new System.Windows.Forms.ComboBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnShow = new System.Windows.Forms.Button();
            this.txtDetails = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBRoute)).BeginInit();
            this.SuspendLayout();
            // 
            // PBRoute
            // 
            this.PBRoute.Location = new System.Drawing.Point(12, 99);
            this.PBRoute.Name = "PBRoute";
            this.PBRoute.Size = new System.Drawing.Size(394, 485);
            this.PBRoute.TabIndex = 0;
            this.PBRoute.TabStop = false;
            // 
            // CBRoute
            // 
            this.CBRoute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRoute.FormattingEnabled = true;
            this.CBRoute.Items.AddRange(new object[] {
            "Піший",
            "Велосипедний",
            "Автомобільний",
            "Водний"});
            this.CBRoute.Location = new System.Drawing.Point(12, 13);
            this.CBRoute.Name = "CBRoute";
            this.CBRoute.Size = new System.Drawing.Size(121, 21);
            this.CBRoute.TabIndex = 1;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(139, 13);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(113, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Показати маршрут";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click_1);
            // 
            // txtDetails
            // 
            this.txtDetails.Location = new System.Drawing.Point(412, 98);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.ReadOnly = true;
            this.txtDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDetails.Size = new System.Drawing.Size(152, 171);
            this.txtDetails.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.txtDetails);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.CBRoute);
            this.Controls.Add(this.PBRoute);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PBRoute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PBRoute;
        private System.Windows.Forms.ComboBox CBRoute;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.TextBox txtDetails;
    }
}

