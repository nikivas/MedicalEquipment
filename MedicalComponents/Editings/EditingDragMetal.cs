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
    public partial class EditingDragMetal : Form
    {
        public int id = -1;
        public EditingDragMetal()
        {
            InitializeComponent();
        }

        public EditingDragMetal(int id)
        {
            this.id = id;
            InitializeComponent();
        }

        private void EditingDragMetal_Load(object sender, EventArgs e)
        {
            initComboBoxes();

            try
            {
                if (id != -1)
                {
                    var el = TablesModel.entities.ElementsDragMetal.Where(x => x.elements_drag_metal_id== id).First();
                    textBoxSize.Text = el.size.Value.ToString();
                    
                    for (int i = 0; i < comboBoxDragMetal.Items.Count; i++)
                    {
                        var cmbEl = comboBoxDragMetal.Items[i] as dynamic;
                        if (cmbEl.id == el.drag_metal_id)
                            comboBoxDragMetal.SelectedIndex = i;
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
            ComboBoxWorker.initDragMetal(comboBoxDragMetal);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == -1)
                {
                    int addId = TablesModel.entities.ElementsDragMetal.Count() == 0 ? 0 : TablesModel.entities.ElementsDragMetal.Max(x => x.elements_drag_metal_id) + 1;
                    TablesModel.entities.ElementsDragMetal.Add(new Models.ElementsDragMetal()
                    {
                        elements_drag_metal_id = addId,
                        model_element_id = (int) comboBoxModel.SelectedValue,
                        drag_metal_id = (int) comboBoxDragMetal.SelectedValue,
                        size = int.Parse(textBoxSize.Text)
                    });
                    TablesModel.entities.SaveChanges();
                }
                else
                {
                    var el = TablesModel.entities.ElementsDragMetal.Where(x => x.elements_drag_metal_id== id).First();
                    el.model_element_id = (int)comboBoxModel.SelectedValue;
                    el.drag_metal_id = (int) comboBoxDragMetal.SelectedValue;
                    el.size = int.Parse(textBoxSize.Text);
                    TablesModel.entities.SaveChanges();
                }
                MessageBox.Show("изменения успешно приняты");
                this.Close();
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
