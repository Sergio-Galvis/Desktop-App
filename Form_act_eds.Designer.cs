namespace WindowsFormsApp2
{
    partial class Form_act_eds
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_act_eds));
            this.label_Terpel = new System.Windows.Forms.Label();
            this.label_AsistenteCES = new System.Windows.Forms.Label();
            this.panel_CasosSalesforce = new System.Windows.Forms.Panel();
            this.button_Enviar = new System.Windows.Forms.Button();
            this.textBox_CasosSalesforce = new System.Windows.Forms.TextBox();
            this.panel_CasosSalesforce.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Terpel
            // 
            this.label_Terpel.Image = ((System.Drawing.Image)(resources.GetObject("label_Terpel.Image")));
            this.label_Terpel.Location = new System.Drawing.Point(12, 9);
            this.label_Terpel.Name = "label_Terpel";
            this.label_Terpel.Size = new System.Drawing.Size(150, 53);
            this.label_Terpel.TabIndex = 1;
            this.label_Terpel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_AsistenteCES
            // 
            this.label_AsistenteCES.AutoSize = true;
            this.label_AsistenteCES.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AsistenteCES.ForeColor = System.Drawing.Color.Goldenrod;
            this.label_AsistenteCES.Location = new System.Drawing.Point(168, 20);
            this.label_AsistenteCES.Name = "label_AsistenteCES";
            this.label_AsistenteCES.Size = new System.Drawing.Size(167, 25);
            this.label_AsistenteCES.TabIndex = 2;
            this.label_AsistenteCES.Text = "|  Asistente CES";
            // 
            // panel_CasosSalesforce
            // 
            this.panel_CasosSalesforce.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_CasosSalesforce.Controls.Add(this.button_Enviar);
            this.panel_CasosSalesforce.Controls.Add(this.textBox_CasosSalesforce);
            this.panel_CasosSalesforce.Location = new System.Drawing.Point(-1, 77);
            this.panel_CasosSalesforce.Name = "panel_CasosSalesforce";
            this.panel_CasosSalesforce.Size = new System.Drawing.Size(803, 377);
            this.panel_CasosSalesforce.TabIndex = 4;
            // 
            // button_Enviar
            // 
            this.button_Enviar.BackColor = System.Drawing.Color.Goldenrod;
            this.button_Enviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Enviar.ForeColor = System.Drawing.Color.White;
            this.button_Enviar.Location = new System.Drawing.Point(0, 333);
            this.button_Enviar.Name = "button_Enviar";
            this.button_Enviar.Size = new System.Drawing.Size(803, 41);
            this.button_Enviar.TabIndex = 1;
            this.button_Enviar.Text = "Enviar";
            this.button_Enviar.UseVisualStyleBackColor = false;
            this.button_Enviar.Click += new System.EventHandler(this.button_Enviar_Click);
            // 
            // textBox_CasosSalesforce
            // 
            this.textBox_CasosSalesforce.AcceptsReturn = true;
            this.textBox_CasosSalesforce.AcceptsTab = true;
            this.textBox_CasosSalesforce.CausesValidation = false;
            this.textBox_CasosSalesforce.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_CasosSalesforce.Location = new System.Drawing.Point(-1, 0);
            this.textBox_CasosSalesforce.Multiline = true;
            this.textBox_CasosSalesforce.Name = "textBox_CasosSalesforce";
            this.textBox_CasosSalesforce.ShortcutsEnabled = false;
            this.textBox_CasosSalesforce.Size = new System.Drawing.Size(803, 334);
            this.textBox_CasosSalesforce.TabIndex = 1;
            // 
            // Form_act_eds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_CasosSalesforce);
            this.Controls.Add(this.label_AsistenteCES);
            this.Controls.Add(this.label_Terpel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_act_eds";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Casos Salesforce";
            this.panel_CasosSalesforce.ResumeLayout(false);
            this.panel_CasosSalesforce.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Terpel;
        private System.Windows.Forms.Label label_AsistenteCES;
        private System.Windows.Forms.Panel panel_CasosSalesforce;
        public System.Windows.Forms.TextBox textBox_CasosSalesforce;
        private System.Windows.Forms.Button button_Enviar;
    }
}