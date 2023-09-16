namespace EShop.UI;

partial class Form1
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
        panel1 = new Panel();
        label1 = new Label();
        pictureBox1 = new PictureBox();
        logintxtbx = new TextBox();
        label2 = new Label();
        label3 = new Label();
        passwordtxtbx = new TextBox();
        label4 = new Label();
        button1 = new Button();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.Green;
        panel1.Controls.Add(label1);
        panel1.Controls.Add(pictureBox1);
        panel1.Location = new Point(-2, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(600, 850);
        panel1.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.BackColor = Color.Lime;
        label1.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(53, 276);
        label1.Name = "label1";
        label1.Size = new Size(506, 50);
        label1.TabIndex = 1;
        label1.Text = "Welcome to PDP ERP system";
        // 
        // pictureBox1
        // 
        pictureBox1.Image = Properties.Resources.pdp;
        pictureBox1.Location = new Point(78, 108);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(428, 118);
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // logintxtbx
        // 
        logintxtbx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        logintxtbx.Location = new Point(666, 167);
        logintxtbx.Name = "logintxtbx";
        logintxtbx.Size = new Size(472, 34);
        logintxtbx.TabIndex = 1;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI Emoji", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
        label2.ForeColor = Color.FromArgb(0, 64, 0);
        label2.Location = new Point(666, 52);
        label2.Name = "label2";
        label2.Size = new Size(158, 49);
        label2.TabIndex = 2;
        label2.Text = "Sign Up";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
        label3.Location = new Point(666, 127);
        label3.Name = "label3";
        label3.Size = new Size(90, 37);
        label3.TabIndex = 3;
        label3.Text = "Login";
        // 
        // passwordtxtbx
        // 
        passwordtxtbx.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        passwordtxtbx.Location = new Point(666, 257);
        passwordtxtbx.Name = "passwordtxtbx";
        passwordtxtbx.Size = new Size(472, 34);
        passwordtxtbx.TabIndex = 4;
        passwordtxtbx.UseSystemPasswordChar = true;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI Emoji", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
        label4.Location = new Point(666, 217);
        label4.Name = "label4";
        label4.Size = new Size(141, 37);
        label4.TabIndex = 5;
        label4.Text = "Password";
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI Historic", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
        button1.Location = new Point(996, 311);
        button1.Name = "button1";
        button1.Size = new Size(142, 39);
        button1.TabIndex = 6;
        button1.Text = "Enter";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.ActiveCaption;
        ClientSize = new Size(1182, 803);
        Controls.Add(button1);
        Controls.Add(label4);
        Controls.Add(passwordtxtbx);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(logintxtbx);
        Controls.Add(panel1);
        Name = "Form1";
        Text = "MyForm";
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel1;
    private PictureBox pictureBox1;
    private Label label1;
    private TextBox logintxtbx;
    private Label label2;
    private Label label3;
    private TextBox passwordtxtbx;
    private Label label4;
    private Button button1;
}
