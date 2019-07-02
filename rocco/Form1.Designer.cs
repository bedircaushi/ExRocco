namespace rocco
{
    partial class Form1
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
            this.manager = new System.Windows.Forms.Button();
            this.waiter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.getInfoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manager
            // 
            this.manager.Location = new System.Drawing.Point(141, 264);
            this.manager.Name = "manager";
            this.manager.Size = new System.Drawing.Size(111, 72);
            this.manager.TabIndex = 0;
            this.manager.Text = "MANAGER";
            this.manager.UseVisualStyleBackColor = true;
            this.manager.Click += new System.EventHandler(this.manager_Click);
            // 
            // waiter
            // 
            this.waiter.Location = new System.Drawing.Point(505, 264);
            this.waiter.Name = "waiter";
            this.waiter.Size = new System.Drawing.Size(111, 72);
            this.waiter.TabIndex = 1;
            this.waiter.Text = "WAITER";
            this.waiter.UseVisualStyleBackColor = true;
            this.waiter.Click += new System.EventHandler(this.waiter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "EX ROCCO";
            // 
            // getInfoButton
            // 
            this.getInfoButton.Location = new System.Drawing.Point(327, 264);
            this.getInfoButton.Name = "getInfoButton";
            this.getInfoButton.Size = new System.Drawing.Size(111, 72);
            this.getInfoButton.TabIndex = 3;
            this.getInfoButton.Text = "GET INFO";
            this.getInfoButton.UseVisualStyleBackColor = true;
            this.getInfoButton.Click += new System.EventHandler(this.getInfoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.getInfoButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.waiter);
            this.Controls.Add(this.manager);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button manager;
        private System.Windows.Forms.Button waiter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button getInfoButton;
    }
}

