
namespace ObserverPattern.Observable
{
    partial class FrmObservable
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
            this.TxtState = new System.Windows.Forms.TextBox();
            this.txtObserversCount = new System.Windows.Forms.TextBox();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtState
            // 
            this.TxtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtState.Location = new System.Drawing.Point(58, 37);
            this.TxtState.Name = "TxtState";
            this.TxtState.ReadOnly = true;
            this.TxtState.Size = new System.Drawing.Size(267, 26);
            this.TxtState.TabIndex = 0;
            this.TxtState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtObserversCount
            // 
            this.txtObserversCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObserversCount.Location = new System.Drawing.Point(58, 84);
            this.txtObserversCount.Name = "txtObserversCount";
            this.txtObserversCount.ReadOnly = true;
            this.txtObserversCount.Size = new System.Drawing.Size(267, 26);
            this.txtObserversCount.TabIndex = 1;
            this.txtObserversCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdate.Location = new System.Drawing.Point(92, 138);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(200, 40);
            this.BtnUpdate.TabIndex = 2;
            this.BtnUpdate.Text = "Update Temperatura";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // FrmObservable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 185);
            this.ControlBox = false;
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.txtObserversCount);
            this.Controls.Add(this.TxtState);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmObservable";
            this.Text = "Observable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtState;
        private System.Windows.Forms.TextBox txtObserversCount;
        private System.Windows.Forms.Button BtnUpdate;
    }
}