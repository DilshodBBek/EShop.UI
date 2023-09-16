using EShop.Application.Interfaces;
using EShop.Domain.Entities;
using EShop.Infrastructure.Services;

namespace EShop.UI;

public partial class Form1 : Form
{
    private readonly IUserService _userService;
    public Form1()
    {
        _userService = new UserService();
        InitializeComponent();
    }


    private void button1_Click(object sender, EventArgs e)
    {
        //_userService.Create(new User()
        //{
        //    EmailLogin = "a@gmail.com",
        //    Name = "MisterA",
        //    Password = "1234"
        //});

        User SignedUser = _userService.Login(this.logintxtbx.Text, this.passwordtxtbx.Text);
        if (SignedUser == null)
            MessageBox.Show("User not found 404!");

        else
        {
            MainPageForm mainPageForm = new(SignedUser);
            this.Hide();
            mainPageForm.Show();
        }

    }
}
