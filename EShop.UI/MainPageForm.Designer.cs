namespace EShop.UI;

partial class MainPageForm
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
        components = new System.ComponentModel.Container();
        panel1 = new Panel();
        panel2 = new Panel();
        button1 = new Button();
        label1 = new Label();
        dataGridView1 = new DataGridView();
        UserIdColumn = new DataGridViewTextBoxColumn();
        UserLoginColumn = new DataGridViewTextBoxColumn();
        UserNameColumn = new DataGridViewTextBoxColumn();
        eShopDbContextBindingSource = new BindingSource(components);
        userServiceBindingSource = new BindingSource(components);
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        button5 = new Button();
        textBox1 = new TextBox();
        button6 = new Button();
        panel1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)eShopDbContextBindingSource).BeginInit();
        ((System.ComponentModel.ISupportInitialize)userServiceBindingSource).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.BackColor = Color.Teal;
        panel1.Controls.Add(button5);
        panel1.Controls.Add(button4);
        panel1.Controls.Add(button3);
        panel1.Controls.Add(button2);
        panel1.Controls.Add(panel2);
        panel1.Controls.Add(button1);
        panel1.Controls.Add(label1);
        panel1.Location = new Point(-1, 19);
        panel1.Name = "panel1";
        panel1.Size = new Size(197, 430);
        panel1.TabIndex = 0;
        // 
        // panel2
        // 
        panel2.Location = new Point(3, 63);
        panel2.Name = "panel2";
        panel2.Size = new Size(194, 59);
        panel2.TabIndex = 2;
        // 
        // button1
        // 
        button1.BackColor = Color.Teal;
        button1.FlatStyle = FlatStyle.Flat;
        button1.Font = new Font("Segoe UI Symbol", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
        button1.Location = new Point(0, 63);
        button1.Margin = new Padding(0);
        button1.Name = "button1";
        button1.Size = new Size(197, 59);
        button1.TabIndex = 1;
        button1.Text = "Expenses";
        button1.UseVisualStyleBackColor = false;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Symbol", 18F, FontStyle.Bold, GraphicsUnit.Point);
        label1.Location = new Point(13, 18);
        label1.Name = "label1";
        label1.Size = new Size(167, 41);
        label1.TabIndex = 0;
        label1.Text = "Main Page";
        // 
        // dataGridView1
        // 
        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Columns.AddRange(new DataGridViewColumn[] { UserIdColumn, UserLoginColumn, UserNameColumn });
        dataGridView1.Location = new Point(225, 68);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.RowHeadersWidth = 51;
        dataGridView1.RowTemplate.Height = 29;
        dataGridView1.Size = new Size(581, 370);
        dataGridView1.TabIndex = 1;
        // 
        // UserIdColumn
        // 
        UserIdColumn.HeaderText = "UserId";
        UserIdColumn.MinimumWidth = 6;
        UserIdColumn.Name = "UserIdColumn";
        UserIdColumn.ReadOnly = true;
        // 
        // UserLoginColumn
        // 
        UserLoginColumn.HeaderText = "UserLogin";
        UserLoginColumn.MinimumWidth = 6;
        UserLoginColumn.Name = "UserLoginColumn";
        UserLoginColumn.ReadOnly = true;
        // 
        // UserNameColumn
        // 
        UserNameColumn.HeaderText = "UserName";
        UserNameColumn.MinimumWidth = 6;
        UserNameColumn.Name = "UserNameColumn";
        UserNameColumn.ReadOnly = true;
        // 
        // eShopDbContextBindingSource
        // 
        eShopDbContextBindingSource.DataSource = typeof(Infrastructure.Persistance.EShopDbContext);
        // 
        // userServiceBindingSource
        // 
        userServiceBindingSource.DataSource = typeof(Infrastructure.Services.UserService);
        // 
        // button2
        // 
        button2.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
        button2.Location = new Point(8, 130);
        button2.Name = "button2";
        button2.Size = new Size(181, 46);
        button2.TabIndex = 2;
        button2.Text = "Create";
        button2.UseVisualStyleBackColor = true;
        // 
        // button3
        // 
        button3.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
        button3.Location = new Point(8, 178);
        button3.Name = "button3";
        button3.Size = new Size(181, 46);
        button3.TabIndex = 3;
        button3.Text = "Update";
        button3.TextAlign = ContentAlignment.BottomCenter;
        button3.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
        button4.Location = new Point(8, 226);
        button4.Name = "button4";
        button4.Size = new Size(181, 46);
        button4.TabIndex = 4;
        button4.Text = "Delete";
        button4.UseVisualStyleBackColor = true;
        // 
        // button5
        // 
        button5.Font = new Font("Segoe UI Symbol", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
        button5.Location = new Point(8, 274);
        button5.Name = "button5";
        button5.Size = new Size(181, 46);
        button5.TabIndex = 5;
        button5.Text = "GetById";
        button5.UseVisualStyleBackColor = true;
        // 
        // textBox1
        // 
        textBox1.Location = new Point(225, 19);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(184, 27);
        textBox1.TabIndex = 2;
        // 
        // button6
        // 
        button6.Location = new Point(415, 18);
        button6.Name = "button6";
        button6.Size = new Size(94, 29);
        button6.TabIndex = 3;
        button6.Text = "search";
        button6.UseVisualStyleBackColor = true;
        // 
        // MainPageForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(828, 450);
        Controls.Add(button6);
        Controls.Add(textBox1);
        Controls.Add(dataGridView1);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "MainPageForm";
        Text = "MainPageForm";
        FormClosed += MainPageForm_FormClosed;
        panel1.ResumeLayout(false);
        panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ((System.ComponentModel.ISupportInitialize)eShopDbContextBindingSource).EndInit();
        ((System.ComponentModel.ISupportInitialize)userServiceBindingSource).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Button button1;
    private Label label1;
    private Panel panel2;
    private DataGridView dataGridView1;
    private DataGridViewTextBoxColumn UserIdColumn;
    private DataGridViewTextBoxColumn UserLoginColumn;
    private DataGridViewTextBoxColumn UserNameColumn;
    private BindingSource userServiceBindingSource;
    private BindingSource eShopDbContextBindingSource;
    private Button button5;
    private Button button4;
    private Button button3;
    private Button button2;
    private TextBox textBox1;
    private Button button6;
}