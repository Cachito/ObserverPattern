
namespace ObserverPattern.Observers
{
    partial class FrmObserver
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
            this.BtnDetach = new System.Windows.Forms.Button();
            this.TxtDisplayType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtState
            // 
            this.TxtState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtState.Location = new System.Drawing.Point(9, 53);
            this.TxtState.Name = "TxtState";
            this.TxtState.ReadOnly = true;
            this.TxtState.Size = new System.Drawing.Size(267, 26);
            this.TxtState.TabIndex = 1;
            this.TxtState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnDetach
            // 
            this.BtnDetach.Font = new System.Drawing.Font("JetBrains Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDetach.Location = new System.Drawing.Point(100, 114);
            this.BtnDetach.Name = "BtnDetach";
            this.BtnDetach.Size = new System.Drawing.Size(85, 30);
            this.BtnDetach.TabIndex = 2;
            this.BtnDetach.Text = "Detach";
            this.BtnDetach.UseVisualStyleBackColor = true;
            this.BtnDetach.Click += new System.EventHandler(this.BtnDetach_Click);
            // 
            // TxtDisplayType
            // 
            this.TxtDisplayType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplayType.Location = new System.Drawing.Point(9, 12);
            this.TxtDisplayType.Name = "TxtDisplayType";
            this.TxtDisplayType.ReadOnly = true;
            this.TxtDisplayType.Size = new System.Drawing.Size(267, 26);
            this.TxtDisplayType.TabIndex = 3;
            this.TxtDisplayType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmObserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 153);
            this.ControlBox = false;
            this.Controls.Add(this.TxtDisplayType);
            this.Controls.Add(this.BtnDetach);
            this.Controls.Add(this.TxtState);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmObserver";
            this.Text = "FrmObserver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtState;
        private System.Windows.Forms.Button BtnDetach;
        private System.Windows.Forms.TextBox TxtDisplayType;
    }
}