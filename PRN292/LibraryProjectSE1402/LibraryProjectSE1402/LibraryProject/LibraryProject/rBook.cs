﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class rBook : Form
    {
        public rBook()
        {
            InitializeComponent();
        }

        private void rBook_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsBook.Books' table. You can move, or remove it, as needed.
            this.BooksTableAdapter.Fill(this.dsBook.Books);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
