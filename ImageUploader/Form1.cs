using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageUploader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void image_UploadsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.image_UploadsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.myImages);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.image_UploadsTableAdapter.Fill(this.myImages.Image_Uploads);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Images only. | *.jpg; *.jpeg; *png; *.gif;";

            DialogResult dr = openFileDialog.ShowDialog();

            imgPictureBox.Image = Image.FromFile(openFileDialog.FileName);

            imgPathLabel1.Text = openFileDialog.FileName;
        }
    }
}
