namespace WindowsFormsApp1.FORMULARIOS
{
    partial class Reportes
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtpHastaVentasDia = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDesdeVentasDia = new System.Windows.Forms.DateTimePicker();
            this.button7 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpHastaMP = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDesdeMP = new System.Windows.Forms.DateTimePicker();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpHastaVentasDia);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.dtpDesdeVentasDia);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Location = new System.Drawing.Point(78, 50);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(634, 110);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "VENTAS POR DIA";
            // 
            // dtpHastaVentasDia
            // 
            this.dtpHastaVentasDia.Location = new System.Drawing.Point(381, 35);
            this.dtpHastaVentasDia.Name = "dtpHastaVentasDia";
            this.dtpHastaVentasDia.Size = new System.Drawing.Size(200, 20);
            this.dtpHastaVentasDia.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Hasta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Desde";
            // 
            // dtpDesdeVentasDia
            // 
            this.dtpDesdeVentasDia.Location = new System.Drawing.Point(89, 35);
            this.dtpDesdeVentasDia.Name = "dtpDesdeVentasDia";
            this.dtpDesdeVentasDia.Size = new System.Drawing.Size(200, 20);
            this.dtpDesdeVentasDia.TabIndex = 0;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(482, 70);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 23);
            this.button7.TabIndex = 0;
            this.button7.Text = "Cargar Reporte";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(348, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "REPORTES";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpHastaMP);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dtpDesdeMP);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Location = new System.Drawing.Point(78, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 110);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MATERIA PRIMA UTILIZADA";
            // 
            // dtpHastaMP
            // 
            this.dtpHastaMP.Location = new System.Drawing.Point(381, 35);
            this.dtpHastaMP.Name = "dtpHastaMP";
            this.dtpHastaMP.Size = new System.Drawing.Size(200, 20);
            this.dtpHastaMP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Desde";
            // 
            // dtpDesdeMP
            // 
            this.dtpDesdeMP.Location = new System.Drawing.Point(89, 35);
            this.dtpDesdeMP.Name = "dtpDesdeMP";
            this.dtpDesdeMP.Size = new System.Drawing.Size(200, 20);
            this.dtpDesdeMP.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(482, 70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 23);
            this.button5.TabIndex = 0;
            this.button5.Text = "Cargar Reporte";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(668, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox4);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpHastaVentasDia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDesdeVentasDia;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpHastaMP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDesdeMP;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
    }
}