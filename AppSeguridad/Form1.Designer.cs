namespace AppSeguridad
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCesar = new System.Windows.Forms.TabPage();
            this.tabMono = new System.Windows.Forms.TabPage();
            this.tabRSA = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdecrypt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtencrypt = new System.Windows.Forms.TextBox();
            this.btn_Cifrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtplain = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabRSA.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCesar);
            this.tabControl1.Controls.Add(this.tabMono);
            this.tabControl1.Controls.Add(this.tabRSA);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCesar
            // 
            this.tabCesar.Location = new System.Drawing.Point(4, 24);
            this.tabCesar.Name = "tabCesar";
            this.tabCesar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCesar.Size = new System.Drawing.Size(792, 422);
            this.tabCesar.TabIndex = 0;
            this.tabCesar.Text = "Algoritmo de Cesar";
            this.tabCesar.UseVisualStyleBackColor = true;
            // 
            // tabMono
            // 
            this.tabMono.Location = new System.Drawing.Point(4, 24);
            this.tabMono.Name = "tabMono";
            this.tabMono.Padding = new System.Windows.Forms.Padding(3);
            this.tabMono.Size = new System.Drawing.Size(792, 422);
            this.tabMono.TabIndex = 1;
            this.tabMono.Text = "MonoAlfabetico - Sustitucion";
            this.tabMono.UseVisualStyleBackColor = true;
            // 
            // tabRSA
            // 
            this.tabRSA.Controls.Add(this.label3);
            this.tabRSA.Controls.Add(this.txtdecrypt);
            this.tabRSA.Controls.Add(this.button1);
            this.tabRSA.Controls.Add(this.label2);
            this.tabRSA.Controls.Add(this.txtencrypt);
            this.tabRSA.Controls.Add(this.btn_Cifrar);
            this.tabRSA.Controls.Add(this.label1);
            this.tabRSA.Controls.Add(this.txtplain);
            this.tabRSA.Location = new System.Drawing.Point(4, 24);
            this.tabRSA.Name = "tabRSA";
            this.tabRSA.Padding = new System.Windows.Forms.Padding(3);
            this.tabRSA.Size = new System.Drawing.Size(792, 422);
            this.tabRSA.TabIndex = 2;
            this.tabRSA.Text = "Algoritmo RSA";
            this.tabRSA.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(41, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Texto Descifrado";
            // 
            // txtdecrypt
            // 
            this.txtdecrypt.Location = new System.Drawing.Point(41, 324);
            this.txtdecrypt.Multiline = true;
            this.txtdecrypt.Name = "txtdecrypt";
            this.txtdecrypt.Size = new System.Drawing.Size(711, 80);
            this.txtdecrypt.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 80);
            this.button1.TabIndex = 5;
            this.button1.Text = "Descifrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Texto cifrado";
            // 
            // txtencrypt
            // 
            this.txtencrypt.Location = new System.Drawing.Point(35, 189);
            this.txtencrypt.Multiline = true;
            this.txtencrypt.Name = "txtencrypt";
            this.txtencrypt.Size = new System.Drawing.Size(588, 80);
            this.txtencrypt.TabIndex = 3;
            // 
            // btn_Cifrar
            // 
            this.btn_Cifrar.Location = new System.Drawing.Point(644, 61);
            this.btn_Cifrar.Name = "btn_Cifrar";
            this.btn_Cifrar.Size = new System.Drawing.Size(102, 80);
            this.btn_Cifrar.TabIndex = 2;
            this.btn_Cifrar.Text = "Cifrar";
            this.btn_Cifrar.UseVisualStyleBackColor = true;
            this.btn_Cifrar.Click += new System.EventHandler(this.btn_Cifrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(35, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texto a Cifrar";
            // 
            // txtplain
            // 
            this.txtplain.Location = new System.Drawing.Point(35, 61);
            this.txtplain.Multiline = true;
            this.txtplain.Name = "txtplain";
            this.txtplain.Size = new System.Drawing.Size(588, 80);
            this.txtplain.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabRSA.ResumeLayout(false);
            this.tabRSA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabCesar;
        private TabPage tabMono;
        private TabPage tabRSA;
        private Label label3;
        private TextBox txtdecrypt;
        private Button button1;
        private Label label2;
        private TextBox txtencrypt;
        private Button btn_Cifrar;
        private Label label1;
        private TextBox txtplain;
    }
}