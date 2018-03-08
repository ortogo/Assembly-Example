namespace BaseProjectSolidWorks2
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.NominalTorque = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Fingers = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MuftaParams = new System.Windows.Forms.Label();
            this.SelectMufta = new System.Windows.Forms.OpenFileDialog();
            this.OpenMufta = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.PathToMufta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номинальный момент,кН";
            // 
            // NominalTorque
            // 
            this.NominalTorque.Location = new System.Drawing.Point(172, 6);
            this.NominalTorque.Name = "NominalTorque";
            this.NominalTorque.Size = new System.Drawing.Size(100, 20);
            this.NominalTorque.TabIndex = 1;
            this.NominalTorque.Text = "125";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количесво пальцев";
            // 
            // Fingers
            // 
            this.Fingers.Location = new System.Drawing.Point(172, 31);
            this.Fingers.Name = "Fingers";
            this.Fingers.Size = new System.Drawing.Size(100, 20);
            this.Fingers.TabIndex = 3;
            this.Fingers.Text = "4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Построить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(172, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Посчитать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MuftaParams
            // 
            this.MuftaParams.AutoSize = true;
            this.MuftaParams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MuftaParams.Location = new System.Drawing.Point(12, 64);
            this.MuftaParams.Name = "MuftaParams";
            this.MuftaParams.Size = new System.Drawing.Size(160, 26);
            this.MuftaParams.TabIndex = 6;
            this.MuftaParams.Text = "Рассчитанный диаметр 12 мм\r\nПринятый диаметр 14мм";
            this.MuftaParams.Click += new System.EventHandler(this.MuftaParams_Click);
            // 
            // SelectMufta
            // 
            this.SelectMufta.FileName = "...";
            // 
            // OpenMufta
            // 
            this.OpenMufta.Location = new System.Drawing.Point(12, 118);
            this.OpenMufta.Name = "OpenMufta";
            this.OpenMufta.Size = new System.Drawing.Size(75, 23);
            this.OpenMufta.TabIndex = 7;
            this.OpenMufta.Text = "Открыть";
            this.OpenMufta.UseVisualStyleBackColor = true;
            this.OpenMufta.Click += new System.EventHandler(this.OpenMufta_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Выберите файл муфты";
            // 
            // PathToMufta
            // 
            this.PathToMufta.Location = new System.Drawing.Point(93, 119);
            this.PathToMufta.Name = "PathToMufta";
            this.PathToMufta.Size = new System.Drawing.Size(100, 20);
            this.PathToMufta.TabIndex = 9;
            this.PathToMufta.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 179);
            this.Controls.Add(this.PathToMufta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OpenMufta);
            this.Controls.Add(this.MuftaParams);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Fingers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NominalTorque);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Работа со зборкой";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NominalTorque;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Fingers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label MuftaParams;
        private System.Windows.Forms.OpenFileDialog SelectMufta;
        private System.Windows.Forms.Button OpenMufta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PathToMufta;
    }
}

