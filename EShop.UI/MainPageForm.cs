using EShop.Application.Interfaces;
using EShop.Infrastructure.Services;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EShop.UI;
public partial class MainPageForm : Form
{
    private readonly IUserService _userService;
    public MainPageForm(Domain.Entities.User user)
    {
        InitializeComponent();
        if (user != null)
        {
            if (user.EmailLogin == "a@gmail.com")
            {
                this.panel2.Hide();
            }
        }
        _userService = new UserService();
        var users = _userService.GetAll();
        foreach (var item in users)
        {
            this.dataGridView1.Rows.Add(item.Id, item.EmailLogin, item.Name);
        }
    }

    private void button2_Click(object sender, EventArgs e)
    {
        this.panel2.Hide();
    }

    private void MainPageForm_FormClosed(object sender, FormClosedEventArgs e)
    {
        System.Windows.Forms.Application.Exit();
    }

    private void sgsdgfdsfToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    //private void button2_Click(object sender, EventArgs e)
    //{
    //    this.panel2.Hide();
    //}
}
