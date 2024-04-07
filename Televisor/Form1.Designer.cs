namespace Televisor
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
            usuarioLabel = new Label();
            labelCanal = new Label();
            btnCambiarCanal = new Button();
            btnPrenderTv = new Button();
            txtNumCanal = new TextBox();
            label1 = new Label();
            labelEstado = new Label();
            SuspendLayout();
            // 
            // usuarioLabel
            // 
            usuarioLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            usuarioLabel.Location = new Point(287, 30);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new Size(245, 20);
            usuarioLabel.TabIndex = 0;
            usuarioLabel.Text = "Usuario";
            // 
            // labelCanal
            // 
            labelCanal.AutoSize = true;
            labelCanal.Location = new Point(101, 121);
            labelCanal.Name = "labelCanal";
            labelCanal.Size = new Size(96, 15);
            labelCanal.TabIndex = 1;
            labelCanal.Text = "numero de canal";
            // 
            // btnCambiarCanal
            // 
            btnCambiarCanal.Location = new Point(101, 157);
            btnCambiarCanal.Name = "btnCambiarCanal";
            btnCambiarCanal.Size = new Size(129, 23);
            btnCambiarCanal.TabIndex = 2;
            btnCambiarCanal.Text = "Cambiar canal (+)";
            btnCambiarCanal.UseVisualStyleBackColor = true;
            btnCambiarCanal.Click += btnCambiarCanal_Click;
            // 
            // btnPrenderTv
            // 
            btnPrenderTv.Location = new Point(101, 77);
            btnPrenderTv.Name = "btnPrenderTv";
            btnPrenderTv.Size = new Size(129, 23);
            btnPrenderTv.TabIndex = 3;
            btnPrenderTv.Text = "Prender TV";
            btnPrenderTv.UseVisualStyleBackColor = true;
            btnPrenderTv.Click += btnPrenderTv_Click;
            // 
            // txtNumCanal
            // 
            txtNumCanal.Location = new Point(238, 221);
            txtNumCanal.Name = "txtNumCanal";
            txtNumCanal.Size = new Size(101, 23);
            txtNumCanal.TabIndex = 4;
            txtNumCanal.TextChanged += txtNumCanal_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 221);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 5;
            label1.Text = "Introducir num. de canal";
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(302, 80);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(54, 15);
            labelEstado.TabIndex = 6;
            labelEstado.Text = "Apagada";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(800, 450);
            Controls.Add(labelEstado);
            Controls.Add(label1);
            Controls.Add(txtNumCanal);
            Controls.Add(btnPrenderTv);
            Controls.Add(btnCambiarCanal);
            Controls.Add(labelCanal);
            Controls.Add(usuarioLabel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usuarioLabel;
        private Label labelCanal;
        private Button btnCambiarCanal;
        private Button btnPrenderTv;
        private TextBox txtNumCanal;
        private Label label1;
        private Label labelEstado;
    }
}
