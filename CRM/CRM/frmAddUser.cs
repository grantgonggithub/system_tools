﻿/*----------------------------------------------------------------
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
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Tools;

namespace CRM
{
    public partial class frmAddUser : skinBase
    {
        public DataRow row;
        public frmAddUser()
        {
            InitializeComponent();
        }


 

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtTel.Text = "";
            txt_verification_code.Text = "";
            txtRemark.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }

        private void frmAddUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            //CommStatic.FrmAddUser = null;
            CommStatic.TxtBoxCardId = null;
        }
    }
}
