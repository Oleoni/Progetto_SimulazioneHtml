namespace Progetto_Oleoni_Sampietro
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberare le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txt_css = new System.Windows.Forms.RichTextBox();
            this.txt_html = new System.Windows.Forms.RichTextBox();
            this.btn_html = new System.Windows.Forms.Button();
            this.btn_css = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(756, 68);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(301, 443);
            this.webBrowser1.TabIndex = 0;
            // 
            // txt_css
            // 
            this.txt_css.Location = new System.Drawing.Point(389, 68);
            this.txt_css.Name = "txt_css";
            this.txt_css.Size = new System.Drawing.Size(309, 443);
            this.txt_css.TabIndex = 1;
            this.txt_css.Text = "";
            this.txt_css.TextChanged += new System.EventHandler(this.txt_css_TextChanged);
            this.txt_css.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_css_KeyUp);
            // 
            // txt_html
            // 
            this.txt_html.Location = new System.Drawing.Point(12, 68);
            this.txt_html.Name = "txt_html";
            this.txt_html.Size = new System.Drawing.Size(307, 443);
            this.txt_html.TabIndex = 2;
            this.txt_html.Text = "";
            this.txt_html.TextChanged += new System.EventHandler(this.txt_html_TextChanged);
            this.txt_html.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_html_KeyUp);
            // 
            // btn_html
            // 
            this.btn_html.Location = new System.Drawing.Point(12, 28);
            this.btn_html.Name = "btn_html";
            this.btn_html.Size = new System.Drawing.Size(75, 23);
            this.btn_html.TabIndex = 3;
            this.btn_html.Text = "Salva Html";
            this.btn_html.UseVisualStyleBackColor = true;
            this.btn_html.Click += new System.EventHandler(this.btn_html_Click);
            // 
            // btn_css
            // 
            this.btn_css.Location = new System.Drawing.Point(389, 28);
            this.btn_css.Name = "btn_css";
            this.btn_css.Size = new System.Drawing.Size(75, 23);
            this.btn_css.TabIndex = 4;
            this.btn_css.Text = "Salva Css";
            this.btn_css.UseVisualStyleBackColor = true;
            this.btn_css.Click += new System.EventHandler(this.btn_css_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "SIMULAZIONE HTML";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "SIMULAZIONE CSS";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(949, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "SIMULAZIONE WEB";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 523);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_css);
            this.Controls.Add(this.btn_html);
            this.Controls.Add(this.txt_html);
            this.Controls.Add(this.txt_css);
            this.Controls.Add(this.webBrowser1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.RichTextBox txt_css;
        private System.Windows.Forms.RichTextBox txt_html;
        private System.Windows.Forms.Button btn_html;
        private System.Windows.Forms.Button btn_css;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

