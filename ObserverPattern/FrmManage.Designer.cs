
namespace ObserverPattern
{
    partial class FrmManage
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
            this.BtnObservable = new System.Windows.Forms.Button();
            this.BtnObservador = new System.Windows.Forms.Button();
            this.BtnFin = new System.Windows.Forms.Button();
            this.TxtObservable = new System.Windows.Forms.TextBox();
            this.TxtObservers = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnObservable
            // 
            this.BtnObservable.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnObservable.Location = new System.Drawing.Point(12, 224);
            this.BtnObservable.Name = "BtnObservable";
            this.BtnObservable.Size = new System.Drawing.Size(122, 60);
            this.BtnObservable.TabIndex = 0;
            this.BtnObservable.Text = "Iniciar Observable";
            this.BtnObservable.UseVisualStyleBackColor = true;
            this.BtnObservable.Click += new System.EventHandler(this.BtnObservable_Click);
            // 
            // BtnObservador
            // 
            this.BtnObservador.Enabled = false;
            this.BtnObservador.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnObservador.Location = new System.Drawing.Point(156, 224);
            this.BtnObservador.Name = "BtnObservador";
            this.BtnObservador.Size = new System.Drawing.Size(122, 60);
            this.BtnObservador.TabIndex = 1;
            this.BtnObservador.Text = "Iniciar Observador";
            this.BtnObservador.UseVisualStyleBackColor = true;
            this.BtnObservador.Click += new System.EventHandler(this.BtnObservador_Click);
            // 
            // BtnFin
            // 
            this.BtnFin.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFin.Location = new System.Drawing.Point(296, 224);
            this.BtnFin.Name = "BtnFin";
            this.BtnFin.Size = new System.Drawing.Size(122, 60);
            this.BtnFin.TabIndex = 2;
            this.BtnFin.Text = "Terminar";
            this.BtnFin.UseVisualStyleBackColor = true;
            this.BtnFin.Click += new System.EventHandler(this.BtnFin_Click);
            // 
            // TxtObservable
            // 
            this.TxtObservable.Location = new System.Drawing.Point(12, 12);
            this.TxtObservable.Multiline = true;
            this.TxtObservable.Name = "TxtObservable";
            this.TxtObservable.ReadOnly = true;
            this.TxtObservable.Size = new System.Drawing.Size(187, 187);
            this.TxtObservable.TabIndex = 3;
            // 
            // TxtObservers
            // 
            this.TxtObservers.Location = new System.Drawing.Point(216, 12);
            this.TxtObservers.Multiline = true;
            this.TxtObservers.Name = "TxtObservers";
            this.TxtObservers.ReadOnly = true;
            this.TxtObservers.Size = new System.Drawing.Size(202, 187);
            this.TxtObservers.TabIndex = 4;
            // 
            // FrmManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 296);
            this.ControlBox = false;
            this.Controls.Add(this.TxtObservers);
            this.Controls.Add(this.TxtObservable);
            this.Controls.Add(this.BtnFin);
            this.Controls.Add(this.BtnObservador);
            this.Controls.Add(this.BtnObservable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnObservable;
        private System.Windows.Forms.Button BtnObservador;
        private System.Windows.Forms.Button BtnFin;
        private System.Windows.Forms.TextBox TxtObservable;
        private System.Windows.Forms.TextBox TxtObservers;
    }
}