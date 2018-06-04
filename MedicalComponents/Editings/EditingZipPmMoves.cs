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

namespace MedicalComponents.Editings
{
    public partial class EditingZipPmMoves : Form
    {
        public int id = -1;
        public int isZIP;
        public EditingZipPmMoves(int isZIP)
        {
            this.isZIP = isZIP;
            InitializeComponent();
        }
        public EditingZipPmMoves(int id, int isZIP)
        {
            this.isZIP = isZIP;
            this.id = id;
            InitializeComponent();
        }

        private void EditingZipPmMoves_Load(object sender, EventArgs e)
        {
            initComboBoxes();


            try
            {
                if (id != -1)
                {
                    var el = TablesModel.entities.ZIPPMMoves.Where(x => x.zipPM_move_id == id).First();
                    dateTimePickerMoved.Value = el.date_move;

                    for (int i = 0; i < comboBoxZIPPm.Items.Count; i++)
                    {
                        var cmbEl = comboBoxZIPPm.Items[i] as dynamic;
                        if (cmbEl.id == el.zipPM_element_id)
                            comboBoxZIPPm.SelectedIndex = i;
                    }

                    for (int i = 0; i < comboBoxModel.Items.Count; i++)
                    {
                        var cmbEl = comboBoxModel.Items[i] as dynamic;
                        if (cmbEl.id == el.model_element_id)
                            comboBoxModel.SelectedIndex = i;
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("элемент не найден, попробуйте еще раз!");
                this.Close();
            }
        }

        private void initComboBoxes()
        {
            ComboBoxWorker.initModelElement(comboBoxModel);
            ComboBoxWorker.initZIPMElement(comboBoxZIPPm,isZIP);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == -1)
                {
                    int addId = TablesModel.entities.ZIPPMMoves.Count() == 0 ? 0 : TablesModel.entities.ZIPPMMoves.Max(x => x.zipPM_move_id) + 1;
                    var el = new Models.ZIPPMMoves()
                    {
                        zipPM_move_id = addId,
                        date_move = dateTimePickerMoved.Value,
                        zipPM_element_id = (int)comboBoxZIPPm.SelectedValue,
                        model_element_id = (int)comboBoxModel.SelectedValue
                    };
                    TablesModel.entities.ZIPPMMoves.Add(el);

                    foreach (var el2 in el.sp_ZIP_AND_PM_Element.ZIPPMonStock)
                    {
                        if (el2.count <= 0)
                            throw new ArgumentException();
                        else
                            el2.count -= 1;

                    }




                }
                else
                {
                    var el = TablesModel.entities.ZIPPMMoves.Where(x => x.zipPM_move_id == id).First();
                    el.date_move = dateTimePickerMoved.Value;
                    el.zipPM_element_id = (int)comboBoxZIPPm.SelectedValue;
                    el.model_element_id = (int)comboBoxModel.SelectedValue;


                }


                


                TablesModel.entities.SaveChanges();
                var frm = DBEditing.getInstanceDB();
                if (frm != null)
                    frm.UPdateDB();
                MessageBox.Show("изменения успешно приняты");
                this.Close();
            }
            catch(ArgumentException ee)
            {
                MessageBox.Show("детали закончились на складе!");
                return;
            }
            catch (Exception ee)
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
