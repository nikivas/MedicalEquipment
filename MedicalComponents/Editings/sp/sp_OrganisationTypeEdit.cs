using MedicalComponents.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalComponents.Editings.sp
{
    public partial class sp_OrganisationTypeEdit : Form
    {
        int id = -1;
        public sp_OrganisationTypeEdit()
        {
            InitializeComponent();
        }
        public sp_OrganisationTypeEdit(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void sp_OrganisationType_Load(object sender, EventArgs e)
        {
            if (id != -1)
                this.textBox1.Text = TablesModel.entities
                                                .sp_OrganisationType
                                                .Where(x => x.organisation_type_id == id)
                                                .Select(x => x.organisation_type_name)
                                                .First();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
                if(id == -1)
                {
                    int addId = TablesModel.entities.sp_OrganisationType.Count() == 0 ? 0 : TablesModel.entities.sp_OrganisationType.Max(x => x.organisation_type_id) + 1;
                    TablesModel.entities.sp_OrganisationType.Add(new Models.sp_OrganisationType()
                    {
                        organisation_type_id = addId,
                        organisation_type_name = textBox1.Text,
                        other = "..."
                    });
                    TablesModel.entities.SaveChanges();
                }
                else
                {
                    TablesModel.entities.sp_OrganisationType.Where(x => x.organisation_type_id == id).First().organisation_type_name = textBox1.Text;
                    TablesModel.entities.SaveChanges();
                }
                MessageBox.Show("изменения успешно приняты");
                this.Close();
            } catch(Exception ee)
            {
                MessageBox.Show("Введены некорректные данные");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
