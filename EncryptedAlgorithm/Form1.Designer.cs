
namespace EncryptedAlgorithm
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
            this.txbText = new System.Windows.Forms.RichTextBox();
            this.btnConvertEnc = new System.Windows.Forms.Button();
            this.txbEncrypted = new System.Windows.Forms.RichTextBox();
            this.btnConvertText = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearText = new System.Windows.Forms.Button();
            this.btnClearEncrypted = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbText
            // 
            this.txbText.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txbText.Location = new System.Drawing.Point(12, 33);
            this.txbText.Name = "txbText";
            this.txbText.Size = new System.Drawing.Size(365, 209);
            this.txbText.TabIndex = 0;
            this.txbText.Text = "";
            this.txbText.TextChanged += new System.EventHandler(this.txbText_TextChanged);
            // 
            // btnConvertEnc
            // 
            this.btnConvertEnc.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnConvertEnc.Location = new System.Drawing.Point(253, 248);
            this.btnConvertEnc.Name = "btnConvertEnc";
            this.btnConvertEnc.Size = new System.Drawing.Size(124, 23);
            this.btnConvertEnc.TabIndex = 1;
            this.btnConvertEnc.Text = "Convert to encrypted";
            this.btnConvertEnc.UseVisualStyleBackColor = false;
            this.btnConvertEnc.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txbEncrypted
            // 
            this.txbEncrypted.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txbEncrypted.ForeColor = System.Drawing.SystemColors.Desktop;
            this.txbEncrypted.Location = new System.Drawing.Point(409, 33);
            this.txbEncrypted.Name = "txbEncrypted";
            this.txbEncrypted.Size = new System.Drawing.Size(365, 209);
            this.txbEncrypted.TabIndex = 2;
            this.txbEncrypted.Text = "";
            // 
            // btnConvertText
            // 
            this.btnConvertText.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnConvertText.Location = new System.Drawing.Point(668, 248);
            this.btnConvertText.Name = "btnConvertText";
            this.btnConvertText.Size = new System.Drawing.Size(106, 23);
            this.btnConvertText.TabIndex = 3;
            this.btnConvertText.Text = "Convert to text";
            this.btnConvertText.UseVisualStyleBackColor = false;
            this.btnConvertText.Click += new System.EventHandler(this.btnConvertText_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Text Box :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(405, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Encrypted Box :";
            // 
            // btnClearText
            // 
            this.btnClearText.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnClearText.Location = new System.Drawing.Point(152, 248);
            this.btnClearText.Name = "btnClearText";
            this.btnClearText.Size = new System.Drawing.Size(95, 23);
            this.btnClearText.TabIndex = 6;
            this.btnClearText.Text = "Clear text box";
            this.btnClearText.UseVisualStyleBackColor = false;
            this.btnClearText.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClearEncrypted
            // 
            this.btnClearEncrypted.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnClearEncrypted.Location = new System.Drawing.Point(547, 248);
            this.btnClearEncrypted.Name = "btnClearEncrypted";
            this.btnClearEncrypted.Size = new System.Drawing.Size(115, 23);
            this.btnClearEncrypted.TabIndex = 7;
            this.btnClearEncrypted.Text = "Cleart encrypted box";
            this.btnClearEncrypted.UseVisualStyleBackColor = false;
            this.btnClearEncrypted.Click += new System.EventHandler(this.btnClearEncrypted_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 279);
            this.Controls.Add(this.btnClearEncrypted);
            this.Controls.Add(this.btnClearText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConvertText);
            this.Controls.Add(this.txbEncrypted);
            this.Controls.Add(this.btnConvertEnc);
            this.Controls.Add(this.txbText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Encrypted Algorithm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txbText;
        private System.Windows.Forms.Button btnConvertEnc;
        private System.Windows.Forms.RichTextBox txbEncrypted;
        private System.Windows.Forms.Button btnConvertText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearText;
        private System.Windows.Forms.Button btnClearEncrypted;
    }
}

