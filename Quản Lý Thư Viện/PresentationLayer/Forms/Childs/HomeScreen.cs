﻿using BusinessLogicLayer;
using Core;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Forms.Childs
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }
        
        private void HomeForm_Load(object sender, EventArgs e)
        {
            this.lblHello.Text = $"Xin chào {Auth.User.Name}!";
            this.grdCardTongSoSach.Content = BookLogic.Count().ToString();
            this.grdCardTongSoNhaPhatHanh.Content = PublisherLogic.Count().ToString();
            this.grdCardTongSoNguoiDung.Content = UserLogic.Count().ToString();
            this.grdCardTongSoTacGia.Content = AuthorLogic.Count().ToString();
        }
    }
}
