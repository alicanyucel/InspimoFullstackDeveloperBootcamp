﻿namespace FirstSolution.DesktopApp;

partial class Login
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
        label1 = new Label();
        label2 = new Label();
        textBox1 = new TextBox();
        textBox2 = new TextBox();
        button1 = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(63, 59);
        label1.Margin = new Padding(5, 0, 5, 0);
        label1.Name = "label1";
        label1.Size = new Size(127, 30);
        label1.TabIndex = 0;
        label1.Text = "Kullanıcı Adı";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(63, 129);
        label2.Margin = new Padding(5, 0, 5, 0);
        label2.Name = "label2";
        label2.Size = new Size(54, 30);
        label2.TabIndex = 1;
        label2.Text = "Şifre";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(213, 67);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(154, 35);
        textBox1.TabIndex = 2;
        // 
        // textBox2
        // 
        textBox2.Location = new Point(213, 126);
        textBox2.Name = "textBox2";
        textBox2.Size = new Size(154, 35);
        textBox2.TabIndex = 3;
        // 
        // button1
        // 
        button1.Location = new Point(74, 188);
        button1.Name = "button1";
        button1.Size = new Size(293, 52);
        button1.TabIndex = 4;
        button1.Text = "Giriş Yap";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Login
        // 
        AutoScaleDimensions = new SizeF(12F, 30F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(436, 278);
        Controls.Add(button1);
        Controls.Add(textBox2);
        Controls.Add(textBox1);
        Controls.Add(label2);
        Controls.Add(label1);
        Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
        Margin = new Padding(5, 6, 5, 6);
        Name = "Login";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Login";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private TextBox textBox1;
    private TextBox textBox2;
    private Button button1;
}