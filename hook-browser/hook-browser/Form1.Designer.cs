namespace hook_browser
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tb_url = new System.Windows.Forms.TextBox();
            this.btn_defHome = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_parar = new System.Windows.Forms.Button();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_ir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 92);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1332, 656);
            this.webBrowser1.TabIndex = 0;
            // 
            // tb_url
            // 
            this.tb_url.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tb_url.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_url.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_url.ForeColor = System.Drawing.SystemColors.Menu;
            this.tb_url.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tb_url.Location = new System.Drawing.Point(244, 27);
            this.tb_url.Multiline = true;
            this.tb_url.Name = "tb_url";
            this.tb_url.Size = new System.Drawing.Size(710, 23);
            this.tb_url.TabIndex = 1;
            this.tb_url.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_url_KeyDown);
            // 
            // btn_defHome
            // 
            this.btn_defHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_defHome.Image = global::hook_browser.Properties.Resources.definirhome_icon;
            this.btn_defHome.Location = new System.Drawing.Point(1247, 24);
            this.btn_defHome.Name = "btn_defHome";
            this.btn_defHome.Size = new System.Drawing.Size(31, 25);
            this.btn_defHome.TabIndex = 9;
            this.btn_defHome.UseVisualStyleBackColor = true;
            this.btn_defHome.Click += new System.EventHandler(this.btn_defHome_Click);
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_pesquisar.Image = global::hook_browser.Properties.Resources.search_icon1;
            this.btn_pesquisar.Location = new System.Drawing.Point(205, 27);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(33, 23);
            this.btn_pesquisar.TabIndex = 8;
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            this.btn_pesquisar.Click += new System.EventHandler(this.btn_pesquisar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.Black;
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_atualizar.Image = global::hook_browser.Properties.Resources.refresh_color;
            this.btn_atualizar.Location = new System.Drawing.Point(960, 25);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(29, 27);
            this.btn_atualizar.TabIndex = 7;
            this.btn_atualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_parar
            // 
            this.btn_parar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_parar.Image = global::hook_browser.Properties.Resources.parar_icon;
            this.btn_parar.Location = new System.Drawing.Point(995, 29);
            this.btn_parar.Name = "btn_parar";
            this.btn_parar.Size = new System.Drawing.Size(22, 20);
            this.btn_parar.TabIndex = 6;
            this.btn_parar.UseVisualStyleBackColor = true;
            this.btn_parar.Click += new System.EventHandler(this.btn_parar_Click);
            // 
            // btn_proximo
            // 
            this.btn_proximo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_proximo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_proximo.Image = global::hook_browser.Properties.Resources.proxim_icon;
            this.btn_proximo.Location = new System.Drawing.Point(172, 27);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(27, 25);
            this.btn_proximo.TabIndex = 5;
            this.btn_proximo.UseVisualStyleBackColor = false;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_anterior.Image = global::hook_browser.Properties.Resources.anterior_icon1;
            this.btn_anterior.Location = new System.Drawing.Point(142, 27);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(24, 25);
            this.btn_anterior.TabIndex = 4;
            this.btn_anterior.UseVisualStyleBackColor = false;
            this.btn_anterior.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Black;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_home.Image = global::hook_browser.Properties.Resources.home_icon;
            this.btn_home.Location = new System.Drawing.Point(32, 26);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(26, 24);
            this.btn_home.TabIndex = 3;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_ir
            // 
            this.btn_ir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_ir.Image = global::hook_browser.Properties.Resources.navegar_icon;
            this.btn_ir.Location = new System.Drawing.Point(1023, 27);
            this.btn_ir.Name = "btn_ir";
            this.btn_ir.Size = new System.Drawing.Size(20, 22);
            this.btn_ir.TabIndex = 2;
            this.btn_ir.UseVisualStyleBackColor = true;
            this.btn_ir.Click += new System.EventHandler(this.btn_navegar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1334, 749);
            this.Controls.Add(this.btn_defHome);
            this.Controls.Add(this.btn_pesquisar);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_parar);
            this.Controls.Add(this.btn_proximo);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_ir);
            this.Controls.Add(this.tb_url);
            this.Controls.Add(this.webBrowser1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.TransparencyKey = System.Drawing.Color.WhiteSmoke;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox tb_url;
        private System.Windows.Forms.Button btn_ir;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.Button btn_parar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_defHome;
    }
}

