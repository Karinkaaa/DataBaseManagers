using Repository.Repository;
using RepositoryLogic.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUI
{
    public partial class Form1 : Form
    {
        private ManagerRepository Repository;

        public Form1()
        {
            this.Repository = new ManagerRepository();
            InitializeComponent();
            ManagersGrid.DataSource = Repository.GetAll();
        }
               
        private void SaveManager_Click(object sender, EventArgs e)
        {
            this.Repository.Save(new Manager()
            {
                Name = NameText.Text,
                Surname = SurnameText.Text,
                Age = Convert.ToInt32(AgeText.Text),
                Phone = PhoneText.Text
            });
            ManagersGrid.DataSource = Repository.GetAll();
        }

        private void RemoveManager_Click(object sender, EventArgs e)
        {
            this.Repository.Remove(Convert.ToInt32(ManagersGrid.SelectedRows[0].Cells[0].Value));
            ManagersGrid.DataSource = Repository.GetAll();
        }
    }
}
