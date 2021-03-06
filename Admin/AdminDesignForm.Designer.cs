namespace Booking3.Admin
{
    partial class AdminDesignForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ButtonDeletePictureButton = new System.Windows.Forms.Button();
            this.ButtonLayoutCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonPictureButton = new System.Windows.Forms.Button();
            this.ButtonColorButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ButtonFontButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TextBoxFontButton = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(462, 305);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ButtonDeletePictureButton);
            this.tabPage1.Controls.Add(this.ButtonLayoutCombo);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ButtonPictureButton);
            this.tabPage1.Controls.Add(this.ButtonColorButton);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.ButtonFontButton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(454, 279);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Дизайн кнопок";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // ButtonDeletePictureButton
            // 
            this.ButtonDeletePictureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ButtonDeletePictureButton.Location = new System.Drawing.Point(371, 133);
            this.ButtonDeletePictureButton.Name = "ButtonDeletePictureButton";
            this.ButtonDeletePictureButton.Size = new System.Drawing.Size(71, 59);
            this.ButtonDeletePictureButton.TabIndex = 9;
            this.ButtonDeletePictureButton.Text = "X";
            this.ButtonDeletePictureButton.UseVisualStyleBackColor = true;
            this.ButtonDeletePictureButton.Click += new System.EventHandler(this.ButtonDeletePictureButton_Click);
            // 
            // ButtonLayoutCombo
            // 
            this.ButtonLayoutCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ButtonLayoutCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ButtonLayoutCombo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ButtonLayoutCombo.FormattingEnabled = true;
            this.ButtonLayoutCombo.Items.AddRange(new object[] {
            "Никакой",
            "Какой-то",
            "Во всю кнопку",
            "Во всю кнопку с пропорциями",
            "По центру"});
            this.ButtonLayoutCombo.Location = new System.Drawing.Point(149, 160);
            this.ButtonLayoutCombo.Name = "ButtonLayoutCombo";
            this.ButtonLayoutCombo.Size = new System.Drawing.Size(216, 32);
            this.ButtonLayoutCombo.TabIndex = 8;
            this.ButtonLayoutCombo.SelectedIndexChanged += new System.EventHandler(this.ButtonLayoutCombo_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(157, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Положение";
            // 
            // ButtonPictureButton
            // 
            this.ButtonPictureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ButtonPictureButton.Location = new System.Drawing.Point(8, 133);
            this.ButtonPictureButton.Name = "ButtonPictureButton";
            this.ButtonPictureButton.Size = new System.Drawing.Size(128, 59);
            this.ButtonPictureButton.TabIndex = 6;
            this.ButtonPictureButton.Text = "Картинка";
            this.ButtonPictureButton.UseVisualStyleBackColor = true;
            this.ButtonPictureButton.Click += new System.EventHandler(this.ButtonPictureButton_Click);
            // 
            // ButtonColorButton
            // 
            this.ButtonColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ButtonColorButton.Location = new System.Drawing.Point(8, 75);
            this.ButtonColorButton.Name = "ButtonColorButton";
            this.ButtonColorButton.Size = new System.Drawing.Size(128, 52);
            this.ButtonColorButton.TabIndex = 5;
            this.ButtonColorButton.Text = "Цвет";
            this.ButtonColorButton.UseVisualStyleBackColor = true;
            this.ButtonColorButton.Click += new System.EventHandler(this.ButtonColorButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(353, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Образец";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.button1.Location = new System.Drawing.Point(314, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 38);
            this.button1.TabIndex = 3;
            this.button1.Text = "Button";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonFontButton
            // 
            this.ButtonFontButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ButtonFontButton.Location = new System.Drawing.Point(8, 17);
            this.ButtonFontButton.Name = "ButtonFontButton";
            this.ButtonFontButton.Size = new System.Drawing.Size(128, 52);
            this.ButtonFontButton.TabIndex = 1;
            this.ButtonFontButton.Text = "Шрифт";
            this.ButtonFontButton.UseVisualStyleBackColor = true;
            this.ButtonFontButton.Click += new System.EventHandler(this.ButtonFontButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(454, 279);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дизайн панелей и форм";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(454, 279);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Дизайн лейблов";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Controls.Add(this.TextBoxFontButton);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(454, 279);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Дизайн текстбоксов";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(273, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Образец";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBox1.Location = new System.Drawing.Point(277, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Привет";
            // 
            // TextBoxFontButton
            // 
            this.TextBoxFontButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.TextBoxFontButton.Location = new System.Drawing.Point(8, 21);
            this.TextBoxFontButton.Name = "TextBoxFontButton";
            this.TextBoxFontButton.Size = new System.Drawing.Size(128, 38);
            this.TextBoxFontButton.TabIndex = 0;
            this.TextBoxFontButton.Text = "Шрифт";
            this.TextBoxFontButton.UseVisualStyleBackColor = true;
            this.TextBoxFontButton.Click += new System.EventHandler(this.TextBoxFontButton_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // AdminDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 305);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminDesignForm";
            this.Text = "Дизайн форм и компонентов";
            this.Load += new System.EventHandler(this.AdminDesignForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button TextBoxFontButton;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ButtonFontButton;
        private System.Windows.Forms.Button ButtonColorButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button ButtonPictureButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox ButtonLayoutCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonDeletePictureButton;
    }
}