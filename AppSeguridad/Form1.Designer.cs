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
            this.txt_desplazamiento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_descifradoCesar = new System.Windows.Forms.TextBox();
            this.btn_descifraCesar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_cifradoCesar = new System.Windows.Forms.TextBox();
            this.btn_cifraCesar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_textoCesar = new System.Windows.Forms.TextBox();
            this.tabMono = new System.Windows.Forms.TabPage();
            this.txt_claveMono = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_descifraMono = new System.Windows.Forms.TextBox();
            this.btn_descifrarMono = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_cifradoMono = new System.Windows.Forms.TextBox();
            this.btn_cifrarMono = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_textoMono = new System.Windows.Forms.TextBox();
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
            this.tabCesar.SuspendLayout();
            this.tabMono.SuspendLayout();
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
            this.tabCesar.Controls.Add(this.txt_desplazamiento);
            this.tabCesar.Controls.Add(this.label7);
            this.tabCesar.Controls.Add(this.label4);
            this.tabCesar.Controls.Add(this.txt_descifradoCesar);
            this.tabCesar.Controls.Add(this.btn_descifraCesar);
            this.tabCesar.Controls.Add(this.label5);
            this.tabCesar.Controls.Add(this.txt_cifradoCesar);
            this.tabCesar.Controls.Add(this.btn_cifraCesar);
            this.tabCesar.Controls.Add(this.label6);
            this.tabCesar.Controls.Add(this.txt_textoCesar);
            this.tabCesar.Location = new System.Drawing.Point(4, 24);
            this.tabCesar.Name = "tabCesar";
            this.tabCesar.Padding = new System.Windows.Forms.Padding(3);
            this.tabCesar.Size = new System.Drawing.Size(792, 422);
            this.tabCesar.TabIndex = 0;
            this.tabCesar.Text = "Algoritmo de Cesar";
            this.tabCesar.UseVisualStyleBackColor = true;
            // 
            // txt_desplazamiento
            // 
            this.txt_desplazamiento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_desplazamiento.Location = new System.Drawing.Point(539, 31);
            this.txt_desplazamiento.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.txt_desplazamiento.Name = "txt_desplazamiento";
            this.txt_desplazamiento.Size = new System.Drawing.Size(87, 25);
            this.txt_desplazamiento.TabIndex = 17;
            this.txt_desplazamiento.Text = "6";
            this.txt_desplazamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(386, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Desplazamiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(38, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 28);
            this.label4.TabIndex = 15;
            this.label4.Text = "Texto Descifrado";
            // 
            // txt_descifradoCesar
            // 
            this.txt_descifradoCesar.Location = new System.Drawing.Point(38, 320);
            this.txt_descifradoCesar.Multiline = true;
            this.txt_descifradoCesar.Name = "txt_descifradoCesar";
            this.txt_descifradoCesar.Size = new System.Drawing.Size(711, 80);
            this.txt_descifradoCesar.TabIndex = 14;
            // 
            // btn_descifraCesar
            // 
            this.btn_descifraCesar.Location = new System.Drawing.Point(647, 185);
            this.btn_descifraCesar.Name = "btn_descifraCesar";
            this.btn_descifraCesar.Size = new System.Drawing.Size(102, 80);
            this.btn_descifraCesar.TabIndex = 13;
            this.btn_descifraCesar.Text = "Descifrar";
            this.btn_descifraCesar.UseVisualStyleBackColor = true;
            this.btn_descifraCesar.Click += new System.EventHandler(this.btn_descifraCesar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(38, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Texto Cifrado";
            // 
            // txt_cifradoCesar
            // 
            this.txt_cifradoCesar.Location = new System.Drawing.Point(38, 185);
            this.txt_cifradoCesar.Multiline = true;
            this.txt_cifradoCesar.Name = "txt_cifradoCesar";
            this.txt_cifradoCesar.Size = new System.Drawing.Size(588, 80);
            this.txt_cifradoCesar.TabIndex = 11;
            // 
            // btn_cifraCesar
            // 
            this.btn_cifraCesar.Location = new System.Drawing.Point(647, 57);
            this.btn_cifraCesar.Name = "btn_cifraCesar";
            this.btn_cifraCesar.Size = new System.Drawing.Size(102, 80);
            this.btn_cifraCesar.TabIndex = 10;
            this.btn_cifraCesar.Text = "Cifrar";
            this.btn_cifraCesar.UseVisualStyleBackColor = true;
            this.btn_cifraCesar.Click += new System.EventHandler(this.btn_cifraCesar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(38, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Texto a Cifrar";
            // 
            // txt_textoCesar
            // 
            this.txt_textoCesar.Location = new System.Drawing.Point(38, 57);
            this.txt_textoCesar.Multiline = true;
            this.txt_textoCesar.Name = "txt_textoCesar";
            this.txt_textoCesar.Size = new System.Drawing.Size(588, 80);
            this.txt_textoCesar.TabIndex = 8;
            // 
            // tabMono
            // 
            this.tabMono.Controls.Add(this.txt_claveMono);
            this.tabMono.Controls.Add(this.label8);
            this.tabMono.Controls.Add(this.label9);
            this.tabMono.Controls.Add(this.txt_descifraMono);
            this.tabMono.Controls.Add(this.btn_descifrarMono);
            this.tabMono.Controls.Add(this.label10);
            this.tabMono.Controls.Add(this.txt_cifradoMono);
            this.tabMono.Controls.Add(this.btn_cifrarMono);
            this.tabMono.Controls.Add(this.label11);
            this.tabMono.Controls.Add(this.txt_textoMono);
            this.tabMono.Location = new System.Drawing.Point(4, 24);
            this.tabMono.Name = "tabMono";
            this.tabMono.Padding = new System.Windows.Forms.Padding(3);
            this.tabMono.Size = new System.Drawing.Size(792, 422);
            this.tabMono.TabIndex = 1;
            this.tabMono.Text = "MonoAlfabetico - Sustitucion";
            this.tabMono.UseVisualStyleBackColor = true;
            // 
            // txt_claveMono
            // 
            this.txt_claveMono.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txt_claveMono.Location = new System.Drawing.Point(288, 26);
            this.txt_claveMono.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.txt_claveMono.Name = "txt_claveMono";
            this.txt_claveMono.Size = new System.Drawing.Size(338, 25);
            this.txt_claveMono.TabIndex = 27;
            this.txt_claveMono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(227, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 28);
            this.label8.TabIndex = 26;
            this.label8.Text = "Clave:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(38, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 28);
            this.label9.TabIndex = 25;
            this.label9.Text = "Texto Descifrado";
            // 
            // txt_descifraMono
            // 
            this.txt_descifraMono.Location = new System.Drawing.Point(38, 320);
            this.txt_descifraMono.Multiline = true;
            this.txt_descifraMono.Name = "txt_descifraMono";
            this.txt_descifraMono.Size = new System.Drawing.Size(711, 80);
            this.txt_descifraMono.TabIndex = 24;
            // 
            // btn_descifrarMono
            // 
            this.btn_descifrarMono.Location = new System.Drawing.Point(647, 185);
            this.btn_descifrarMono.Name = "btn_descifrarMono";
            this.btn_descifrarMono.Size = new System.Drawing.Size(102, 80);
            this.btn_descifrarMono.TabIndex = 23;
            this.btn_descifrarMono.Text = "Descifrar";
            this.btn_descifrarMono.UseVisualStyleBackColor = true;
            this.btn_descifrarMono.Click += new System.EventHandler(this.btn_descifrarMono_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(38, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 28);
            this.label10.TabIndex = 22;
            this.label10.Text = "Texto Cifrado";
            // 
            // txt_cifradoMono
            // 
            this.txt_cifradoMono.Location = new System.Drawing.Point(38, 185);
            this.txt_cifradoMono.Multiline = true;
            this.txt_cifradoMono.Name = "txt_cifradoMono";
            this.txt_cifradoMono.Size = new System.Drawing.Size(588, 80);
            this.txt_cifradoMono.TabIndex = 21;
            // 
            // btn_cifrarMono
            // 
            this.btn_cifrarMono.Location = new System.Drawing.Point(647, 57);
            this.btn_cifrarMono.Name = "btn_cifrarMono";
            this.btn_cifrarMono.Size = new System.Drawing.Size(102, 80);
            this.btn_cifrarMono.TabIndex = 20;
            this.btn_cifrarMono.Text = "Cifrar";
            this.btn_cifrarMono.UseVisualStyleBackColor = true;
            this.btn_cifrarMono.Click += new System.EventHandler(this.btn_cifrarMono_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(38, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 28);
            this.label11.TabIndex = 19;
            this.label11.Text = "Texto a Cifrar";
            // 
            // txt_textoMono
            // 
            this.txt_textoMono.Location = new System.Drawing.Point(38, 57);
            this.txt_textoMono.Multiline = true;
            this.txt_textoMono.Name = "txt_textoMono";
            this.txt_textoMono.Size = new System.Drawing.Size(588, 80);
            this.txt_textoMono.TabIndex = 18;
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
            this.label3.Location = new System.Drawing.Point(35, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Texto Descifrado";
            // 
            // txtdecrypt
            // 
            this.txtdecrypt.Location = new System.Drawing.Point(35, 324);
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
            this.label2.Location = new System.Drawing.Point(35, 151);
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
            this.label1.Location = new System.Drawing.Point(35, 27);
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
            this.tabCesar.ResumeLayout(false);
            this.tabCesar.PerformLayout();
            this.tabMono.ResumeLayout(false);
            this.tabMono.PerformLayout();
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
        private Label label7;
        private Label label4;
        private TextBox txt_descifradoCesar;
        private Button btn_descifraCesar;
        private Label label5;
        private TextBox txt_cifradoCesar;
        private Button btn_cifraCesar;
        private Label label6;
        private TextBox txt_textoCesar;
        private TextBox txt_desplazamiento;
        private TextBox txt_claveMono;
        private Label label8;
        private Label label9;
        private TextBox txt_descifraMono;
        private Button btn_descifrarMono;
        private Label label10;
        private TextBox txt_cifradoMono;
        private Button btn_cifrarMono;
        private Label label11;
        private TextBox txt_textoMono;
    }
}