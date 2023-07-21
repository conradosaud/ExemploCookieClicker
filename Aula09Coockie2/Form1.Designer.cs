namespace Aula09Coockie2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.temporizador = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.lblCookies = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPorSegundo = new System.Windows.Forms.Label();
            this.btnGerarCookies = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblVovo = new System.Windows.Forms.Label();
            this.btnComprarVovo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // temporizador
            // 
            this.temporizador.Enabled = true;
            this.temporizador.Interval = 1000;
            this.temporizador.Tick += new System.EventHandler(this.temporizador_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(50, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cookies:";
            // 
            // lblCookies
            // 
            this.lblCookies.AutoSize = true;
            this.lblCookies.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCookies.Location = new System.Drawing.Point(69, 79);
            this.lblCookies.Name = "lblCookies";
            this.lblCookies.Size = new System.Drawing.Size(28, 32);
            this.lblCookies.TabIndex = 1;
            this.lblCookies.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(53, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Por segundo:";
            // 
            // lblPorSegundo
            // 
            this.lblPorSegundo.AutoSize = true;
            this.lblPorSegundo.Location = new System.Drawing.Point(77, 143);
            this.lblPorSegundo.Name = "lblPorSegundo";
            this.lblPorSegundo.Size = new System.Drawing.Size(13, 15);
            this.lblPorSegundo.TabIndex = 3;
            this.lblPorSegundo.Text = "0";
            // 
            // btnGerarCookies
            // 
            this.btnGerarCookies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGerarCookies.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGerarCookies.ForeColor = System.Drawing.Color.Red;
            this.btnGerarCookies.Location = new System.Drawing.Point(169, 21);
            this.btnGerarCookies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGerarCookies.Name = "btnGerarCookies";
            this.btnGerarCookies.Size = new System.Drawing.Size(109, 62);
            this.btnGerarCookies.TabIndex = 4;
            this.btnGerarCookies.Text = "Gerar Cookies";
            this.btnGerarCookies.UseVisualStyleBackColor = true;
            this.btnGerarCookies.Click += new System.EventHandler(this.btnGerarCookies_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(209, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vovó";
            // 
            // lblVovo
            // 
            this.lblVovo.AutoSize = true;
            this.lblVovo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblVovo.Location = new System.Drawing.Point(238, 126);
            this.lblVovo.Name = "lblVovo";
            this.lblVovo.Size = new System.Drawing.Size(28, 21);
            this.lblVovo.TabIndex = 6;
            this.lblVovo.Text = "10";
            // 
            // btnComprarVovo
            // 
            this.btnComprarVovo.Location = new System.Drawing.Point(174, 159);
            this.btnComprarVovo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnComprarVovo.Name = "btnComprarVovo";
            this.btnComprarVovo.Size = new System.Drawing.Size(104, 35);
            this.btnComprarVovo.TabIndex = 7;
            this.btnComprarVovo.Text = "Comprar vovo";
            this.btnComprarVovo.UseVisualStyleBackColor = true;
            this.btnComprarVovo.Click += new System.EventHandler(this.btnComprarVovo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(174, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Custo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 228);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnComprarVovo);
            this.Controls.Add(this.lblVovo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGerarCookies);
            this.Controls.Add(this.lblPorSegundo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCookies);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer temporizador;
        private Label label1;
        private Label lblCookies;
        private Label label2;
        private Label lblPorSegundo;
        private Button btnGerarCookies;
        private Label label3;
        private Label lblVovo;
        private Button btnComprarVovo;
        private Label label4;
    }
}