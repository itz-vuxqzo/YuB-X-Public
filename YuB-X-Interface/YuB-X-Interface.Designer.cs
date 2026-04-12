namespace YuB_X_Interface
{
    partial class YuB_X_Interface
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
            this.ScriptEditor = new System.Windows.Forms.RichTextBox();
            this.Execute = new System.Windows.Forms.Button();
            this.Inject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScriptEditor
            // 
            this.ScriptEditor.Location = new System.Drawing.Point(12, 12);
            this.ScriptEditor.Name = "ScriptEditor";
            this.ScriptEditor.Size = new System.Drawing.Size(560, 237);
            this.ScriptEditor.TabIndex = 0;
            this.ScriptEditor.Text = "";
            // 
            // Execute
            // 
            this.Execute.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Execute.Location = new System.Drawing.Point(12, 255);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(100, 44);
            this.Execute.TabIndex = 1;
            this.Execute.Text = "Execute";
            this.Execute.UseVisualStyleBackColor = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // Inject
            // 
            this.Inject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inject.Location = new System.Drawing.Point(472, 255);
            this.Inject.Name = "Inject";
            this.Inject.Size = new System.Drawing.Size(100, 44);
            this.Inject.TabIndex = 2;
            this.Inject.Text = "Inject";
            this.Inject.UseVisualStyleBackColor = true;
            this.Inject.Click += new System.EventHandler(this.Inject_Click);
            // 
            // YuB_X_Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.Inject);
            this.Controls.Add(this.Execute);
            this.Controls.Add(this.ScriptEditor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "YuB_X_Interface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YuB-X-Interface";
            this.Load += new System.EventHandler(this.YuB_X_Interface_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox ScriptEditor;
        private System.Windows.Forms.Button Execute;
        private System.Windows.Forms.Button Inject;
    }
}