﻿using System;
using System.Windows.Forms;
using Presenter;
using Model;

namespace View
{
    public partial class CreatNuturalClienFormView : Form, ICreatNuturalClienView
    {
        private readonly ApplicationContext _context;
        
        public event Action EnterReturnWorkMenu;
        public event Delegates.TransmitDataOfCreatAtVisualizeNuturalClient ViewDataMan;

        public CreatNuturalClienFormView(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        public void setSurname_Name_MiddleNameOnForm(string surname, string name, string middlename)
        {
            tB_Surname.Text = surname;
            tB_Name.Text = name;
            tB_MiddleName.Text = middlename;
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreatNuturalClienFormView_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegistration_Click(object sender, EventArgs e)
        {
            NuturalClient nuturalClient = new NuturalClient(new AliasMan(tB_Surname.Text, tB_Name.Text, tB_MiddleName.Text),
                dTP_DateOfBirth.Value, dTP_DataCar.Value, cB_Sex.Text, tB_Address.Text, tB_PhoneNumber.Text);
            ViewDataMan?.Invoke(nuturalClient);
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
        }

        private void textBoxMiddleName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cB_Sex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dTP_DataCar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dTP_DateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
