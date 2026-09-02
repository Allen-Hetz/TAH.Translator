namespace TAH.Translator.UI
{
    partial class Translator
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
            lblTranslation = new Label();
            btnGerman = new Button();
            menuStrip1 = new MenuStrip();
            lblEnglish = new Label();
            btnSpainish = new Button();
            btnFrench = new Button();
            lblEnglishText = new Label();
            lblTranslationText = new Label();
            SuspendLayout();
            // 
            // lblTranslation
            // 
            lblTranslation.BorderStyle = BorderStyle.Fixed3D;
            lblTranslation.FlatStyle = FlatStyle.Popup;
            lblTranslation.Font = new Font("Segoe UI", 16F);
            lblTranslation.Location = new Point(443, 211);
            lblTranslation.Name = "lblTranslation";
            lblTranslation.Size = new Size(199, 60);
            lblTranslation.TabIndex = 0;
            lblTranslation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnGerman
            // 
            btnGerman.FlatStyle = FlatStyle.Popup;
            btnGerman.Font = new Font("Segoe UI", 24F);
            btnGerman.Location = new Point(12, 51);
            btnGerman.Name = "btnGerman";
            btnGerman.Size = new Size(229, 72);
            btnGerman.TabIndex = 1;
            btnGerman.Text = "Deutsch";
            btnGerman.UseVisualStyleBackColor = true;
            btnGerman.Click += btnGerman_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // lblEnglish
            // 
            lblEnglish.BorderStyle = BorderStyle.Fixed3D;
            lblEnglish.FlatStyle = FlatStyle.Popup;
            lblEnglish.Font = new Font("Segoe UI", 16F);
            lblEnglish.Location = new Point(443, 98);
            lblEnglish.Name = "lblEnglish";
            lblEnglish.Size = new Size(199, 60);
            lblEnglish.TabIndex = 4;
            lblEnglish.Text = "Hello World";
            lblEnglish.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSpainish
            // 
            btnSpainish.FlatStyle = FlatStyle.Popup;
            btnSpainish.Font = new Font("Segoe UI", 24F);
            btnSpainish.Location = new Point(12, 190);
            btnSpainish.Name = "btnSpainish";
            btnSpainish.Size = new Size(229, 72);
            btnSpainish.TabIndex = 5;
            btnSpainish.Text = "Español";
            btnSpainish.UseVisualStyleBackColor = true;
            btnSpainish.Click += btnSpainish_Click;
            // 
            // btnFrench
            // 
            btnFrench.FlatStyle = FlatStyle.Popup;
            btnFrench.Font = new Font("Segoe UI", 24F);
            btnFrench.Location = new Point(12, 324);
            btnFrench.Name = "btnFrench";
            btnFrench.Size = new Size(229, 72);
            btnFrench.TabIndex = 6;
            btnFrench.Text = "Français";
            btnFrench.UseVisualStyleBackColor = true;
            btnFrench.Click += btnFrench_Click;
            // 
            // lblEnglishText
            // 
            lblEnglishText.AutoSize = true;
            lblEnglishText.Font = new Font("Segoe UI", 16F);
            lblEnglishText.Location = new Point(414, 68);
            lblEnglishText.Name = "lblEnglishText";
            lblEnglishText.Size = new Size(85, 30);
            lblEnglishText.TabIndex = 7;
            lblEnglishText.Text = "English:";
            // 
            // lblTranslationText
            // 
            lblTranslationText.AutoSize = true;
            lblTranslationText.Font = new Font("Segoe UI", 16F);
            lblTranslationText.Location = new Point(414, 181);
            lblTranslationText.Name = "lblTranslationText";
            lblTranslationText.Size = new Size(121, 30);
            lblTranslationText.TabIndex = 8;
            lblTranslationText.Text = "Translation:";
            // 
            // Translator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTranslationText);
            Controls.Add(lblEnglishText);
            Controls.Add(btnFrench);
            Controls.Add(btnSpainish);
            Controls.Add(lblEnglish);
            Controls.Add(btnGerman);
            Controls.Add(lblTranslation);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Translator";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTranslation;
        private Button btnGerman;
        private MenuStrip menuStrip1;
        private Label lblEnglish;
        private Button btnSpainish;
        private Button btnFrench;
        private Label lblEnglishText;
        private Label lblTranslationText;
    }
}
