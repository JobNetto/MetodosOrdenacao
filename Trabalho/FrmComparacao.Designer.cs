namespace Trabalho
{
    partial class FrmComparacao
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDesord = new System.Windows.Forms.Button();
            this.btnC4 = new System.Windows.Forms.Button();
            this.btnC3 = new System.Windows.Forms.Button();
            this.btnC2 = new System.Windows.Forms.Button();
            this.btnC1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btGerar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1267, 419);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LavenderBlush;
            this.groupBox1.Controls.Add(this.btnDesord);
            this.groupBox1.Controls.Add(this.btnC4);
            this.groupBox1.Controls.Add(this.btnC3);
            this.groupBox1.Controls.Add(this.btnC2);
            this.groupBox1.Controls.Add(this.btnC1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 456);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1267, 127);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tempo Gasto";
            // 
            // btnDesord
            // 
            this.btnDesord.BackColor = System.Drawing.Color.DimGray;
            this.btnDesord.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDesord.Location = new System.Drawing.Point(414, 27);
            this.btnDesord.Name = "btnDesord";
            this.btnDesord.Size = new System.Drawing.Size(126, 46);
            this.btnDesord.TabIndex = 7;
            this.btnDesord.Text = "DESORDENAR";
            this.btnDesord.UseVisualStyleBackColor = false;
            this.btnDesord.Click += new System.EventHandler(this.btnDesord_Click);
            // 
            // btnC4
            // 
            this.btnC4.BackColor = System.Drawing.Color.IndianRed;
            this.btnC4.Location = new System.Drawing.Point(256, 98);
            this.btnC4.Name = "btnC4";
            this.btnC4.Size = new System.Drawing.Size(81, 22);
            this.btnC4.TabIndex = 6;
            this.btnC4.Text = "Calcular tempo ";
            this.btnC4.UseVisualStyleBackColor = false;
            this.btnC4.Click += new System.EventHandler(this.btnC4_Click);
            // 
            // btnC3
            // 
            this.btnC3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnC3.Location = new System.Drawing.Point(256, 75);
            this.btnC3.Name = "btnC3";
            this.btnC3.Size = new System.Drawing.Size(81, 22);
            this.btnC3.TabIndex = 5;
            this.btnC3.Text = "Calcular tempo ";
            this.btnC3.UseVisualStyleBackColor = false;
            this.btnC3.Click += new System.EventHandler(this.btnC3_Click);
            // 
            // btnC2
            // 
            this.btnC2.BackColor = System.Drawing.Color.YellowGreen;
            this.btnC2.Location = new System.Drawing.Point(256, 53);
            this.btnC2.Name = "btnC2";
            this.btnC2.Size = new System.Drawing.Size(81, 22);
            this.btnC2.TabIndex = 4;
            this.btnC2.Text = "Calcular tempo ";
            this.btnC2.UseVisualStyleBackColor = false;
            this.btnC2.Click += new System.EventHandler(this.btnC2_Click);
            // 
            // btnC1
            // 
            this.btnC1.BackColor = System.Drawing.Color.Yellow;
            this.btnC1.Location = new System.Drawing.Point(256, 27);
            this.btnC1.Name = "btnC1";
            this.btnC1.Size = new System.Drawing.Size(81, 22);
            this.btnC1.TabIndex = 3;
            this.btnC1.Text = "Calcular tempo ";
            this.btnC1.UseVisualStyleBackColor = false;
            this.btnC1.Click += new System.EventHandler(this.btnC1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.IndianRed;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Shell Sort";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quick Sort";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.YellowGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bubble Sort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Sort";
            // 
            // btGerar
            // 
            this.btGerar.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btGerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btGerar.Location = new System.Drawing.Point(11, 7);
            this.btGerar.Name = "btGerar";
            this.btGerar.Size = new System.Drawing.Size(123, 26);
            this.btGerar.TabIndex = 2;
            this.btGerar.Text = "Gerar Números";
            this.btGerar.UseVisualStyleBackColor = false;
            this.btGerar.Click += new System.EventHandler(this.btGerar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btGerar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1267, 37);
            this.panel1.TabIndex = 3;
            // 
            // FrmComparacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1267, 583);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmComparacao";
            this.Text = "Velocidade de Algoritmos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmComparacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGerar;
        private System.Windows.Forms.Button btnC1;
        private System.Windows.Forms.Button btnC4;
        private System.Windows.Forms.Button btnC3;
        private System.Windows.Forms.Button btnC2;
        private System.Windows.Forms.Button btnDesord;
        private System.Windows.Forms.Panel panel1;
    }
}