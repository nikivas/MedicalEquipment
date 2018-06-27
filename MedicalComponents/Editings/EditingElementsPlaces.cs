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
    public partial class EditingElementsPlaces : Form
    {
        public int id = -1;
        public EditingElementsPlaces()
        {
            InitializeComponent();
        }

        public EditingElementsPlaces(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void EditingElementsPlaces_Load(object sender, EventArgs e)
        {
            initComboBoxes();

            try
            {
                if (id != -1)
                {
                    var el = TablesModel.entities.ElementsPlaces.Where(x => x.element_place_id == id).First();
                    dateTimePickerMoved.Value = el.date_begin;

                    for (int i = 0; i < comboBoxCorpus.Items.Count; i++)
                    {
                        var cmbEl = comboBoxCorpus.Items[i] as dynamic;
                        if (cmbEl.id == el.corpus_id)
                            comboBoxCorpus.SelectedIndex = i;
                    }

                    for (int i = 0; i < comboBoxModelElement.Items.Count; i++)
                    {
                        var cmbEl = comboBoxModelElement.Items[i] as dynamic;
                        if (cmbEl.id == el.model_element_id)
                            comboBoxModelElement.SelectedIndex = i;
                    }

                    for (int i = 0; i < comboBoxMoveReason.Items.Count; i++)
                    {
                        var cmbEl = comboBoxMoveReason.Items[i] as dynamic;
                        if (cmbEl.id == el.move_reason_id)
                            comboBoxMoveReason.SelectedIndex = i;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("элемент не найден, попробуйте еще раз!");
                this.Close();
            }

        }

        public void initComboBoxes()
        {
            ComboBoxWorker.initModelElement(comboBoxModelElement);
            ComboBoxWorker.initCorpus(comboBoxCorpus);
            ComboBoxWorker.initMoveReason(comboBoxMoveReason);
            ComboBoxWorker.initModelType(comboBoxType);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == -1)
                {
                    int addId = TablesModel.entities.ElementsPlaces.Count() == 0 ? 0 : TablesModel.entities.ElementsPlaces.Max(x => x.element_place_id) + 1;
                    TablesModel.entities.ElementsPlaces.Add(new Models.ElementsPlaces()
                    {
                        element_place_id = addId,
                        date_begin = dateTimePickerMoved.Value,
                        date_end = dateTimePickerMoved.Value,
                        corpus_id = (int)comboBoxCorpus.SelectedValue,
                        floor = 0,
                        room = "..",
                        model_element_id = (int)comboBoxModelElement.SelectedValue,
                        move_reason_id = (int)comboBoxMoveReason.SelectedValue
                    });

                }
                else
                {
                    var el = TablesModel.entities.ElementsPlaces.Where(x => x.element_place_id == id).First();
                    el.date_begin = dateTimePickerMoved.Value;
                    el.date_end = dateTimePickerMoved.Value;
                    el.corpus_id = (int)comboBoxCorpus.SelectedValue;
                    el.model_element_id = (int)comboBoxModelElement.SelectedValue;
                    el.move_reason_id = (int)comboBoxMoveReason.SelectedValue;

                }
                TablesModel.entities.SaveChanges();
                var frm = DBEditing.getInstanceDB();
                if (frm != null)
                    frm.UPdateDB();
                MessageBox.Show("изменения успешно приняты");
                this.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("Введены некорректные данные");
            }
        }
    }
}
