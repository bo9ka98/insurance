﻿using System;
using System.Windows.Forms;
using Presenter;
using Model.entity;

namespace View
{
    public partial class SearchLegalClientFormView : Form, ISearchLegalClientView
    {
        private readonly ApplicationContext _context;

        public event Action EnterReturnWorkMenu;
        public event Delegates.TransmitDataLegalSatC TransmitDataLegalSatC;

        public SearchLegalClientFormView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            AliasCompanu aliasCompanu = new AliasCompanu(TextBoxOrganisationName.Text, TextBoxUTN.Text);
            TransmitDataLegalSatC?.Invoke(aliasCompanu);
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }
    }
}
