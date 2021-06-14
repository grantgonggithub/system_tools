/*----------------------------------------------------------------
Copyright (C) 2014 宏图会员管理系统（Grant 巩建春）

项目名称： 宏图会员管理系统
创建者：   grant (巩建春 emaill : nnn987@126.com ; QQ:406333743;Tel:+86 15619212255)
CLR版本：  4.0.30319.42000
时间：     2014/8/28 18:16:22

功能描述：本软件为本人业余时间所写，其所有源码都可以进行免费的学习交流，切勿用于商业用途

----------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Tools;

namespace CRM
{
    public partial class frmLogin : skinBase
    {
        public frmLogin()
        {
            InitializeComponent();
            txtUserName.Focus();
        }

        public frmLogin(bool _isLock)
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPwd.Text = "";
            txtUserName.Text = "";

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmProducts frmProducts = new FrmProducts();
            frmProducts.ShowDialog();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (CommStatic.MyCache != null && CommStatic.MyCache.Login!=null&&CommStatic.MyCache.Login.isLock)
            {
                MessageBox.Show("请输入解锁账户和密码");
                e.Cancel = true;
                return;
            }
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            RegistWaring addUser = new RegistWaring();
            addUser.ShowDialog();
        }
    }
}
