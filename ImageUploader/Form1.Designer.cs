namespace ImageUploader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label imgPathLabel;
            System.Windows.Forms.Label imgLabel;
            this.myImages = new ImageUploader.myImages();
            this.image_UploadsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.image_UploadsTableAdapter = new ImageUploader.myImagesTableAdapters.Image_UploadsTableAdapter();
            this.tableAdapterManager = new ImageUploader.myImagesTableAdapters.TableAdapterManager();
            this.image_UploadsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.image_UploadsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.imgPathLabel1 = new System.Windows.Forms.Label();
            this.imgPictureBox = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            imgPathLabel = new System.Windows.Forms.Label();
            imgLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_UploadsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_UploadsBindingNavigator)).BeginInit();
            this.image_UploadsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // myImages
            // 
            this.myImages.DataSetName = "myImages";
            this.myImages.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // image_UploadsBindingSource
            // 
            this.image_UploadsBindingSource.DataMember = "Image_Uploads";
            this.image_UploadsBindingSource.DataSource = this.myImages;
            // 
            // image_UploadsTableAdapter
            // 
            this.image_UploadsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Image_UploadsTableAdapter = this.image_UploadsTableAdapter;
            this.tableAdapterManager.UpdateOrder = ImageUploader.myImagesTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // image_UploadsBindingNavigator
            // 
            this.image_UploadsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.image_UploadsBindingNavigator.BindingSource = this.image_UploadsBindingSource;
            this.image_UploadsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.image_UploadsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.image_UploadsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.image_UploadsBindingNavigatorSaveItem});
            this.image_UploadsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.image_UploadsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.image_UploadsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.image_UploadsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.image_UploadsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.image_UploadsBindingNavigator.Name = "image_UploadsBindingNavigator";
            this.image_UploadsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.image_UploadsBindingNavigator.Size = new System.Drawing.Size(377, 25);
            this.image_UploadsBindingNavigator.TabIndex = 0;
            this.image_UploadsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // image_UploadsBindingNavigatorSaveItem
            // 
            this.image_UploadsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.image_UploadsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("image_UploadsBindingNavigatorSaveItem.Image")));
            this.image_UploadsBindingNavigatorSaveItem.Name = "image_UploadsBindingNavigatorSaveItem";
            this.image_UploadsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.image_UploadsBindingNavigatorSaveItem.Text = "Save Data";
            this.image_UploadsBindingNavigatorSaveItem.Click += new System.EventHandler(this.image_UploadsBindingNavigatorSaveItem_Click);
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(63, 70);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(25, 20);
            idLabel.TabIndex = 1;
            idLabel.Text = "id:";
            // 
            // idLabel1
            // 
            this.idLabel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.image_UploadsBindingSource, "id", true));
            this.idLabel1.Location = new System.Drawing.Point(118, 67);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(100, 23);
            this.idLabel1.TabIndex = 2;
            this.idLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(48, 108);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(55, 20);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.image_UploadsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(121, 110);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(122, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // imgPathLabel
            // 
            imgPathLabel.AutoSize = true;
            imgPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imgPathLabel.Location = new System.Drawing.Point(38, 148);
            imgPathLabel.Name = "imgPathLabel";
            imgPathLabel.Size = new System.Drawing.Size(77, 20);
            imgPathLabel.TabIndex = 5;
            imgPathLabel.Text = "Img Path:";
            // 
            // imgPathLabel1
            // 
            this.imgPathLabel1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.imgPathLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.image_UploadsBindingSource, "ImgPath", true));
            this.imgPathLabel1.Location = new System.Drawing.Point(118, 148);
            this.imgPathLabel1.Name = "imgPathLabel1";
            this.imgPathLabel1.Size = new System.Drawing.Size(150, 23);
            this.imgPathLabel1.TabIndex = 6;
            this.imgPathLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imgLabel
            // 
            imgLabel.AutoSize = true;
            imgLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            imgLabel.Location = new System.Drawing.Point(63, 189);
            imgLabel.Name = "imgLabel";
            imgLabel.Size = new System.Drawing.Size(40, 20);
            imgLabel.TabIndex = 7;
            imgLabel.Text = "Img:";
            // 
            // imgPictureBox
            // 
            this.imgPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.image_UploadsBindingSource, "Img", true));
            this.imgPictureBox.Location = new System.Drawing.Point(121, 189);
            this.imgPictureBox.Name = "imgPictureBox";
            this.imgPictureBox.Size = new System.Drawing.Size(150, 150);
            this.imgPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPictureBox.TabIndex = 8;
            this.imgPictureBox.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(121, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = " Upload Image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "To add an image, click the yellow \'+\' above!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idLabel1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(imgPathLabel);
            this.Controls.Add(this.imgPathLabel1);
            this.Controls.Add(imgLabel);
            this.Controls.Add(this.imgPictureBox);
            this.Controls.Add(this.image_UploadsBindingNavigator);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Images";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.myImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_UploadsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.image_UploadsBindingNavigator)).EndInit();
            this.image_UploadsBindingNavigator.ResumeLayout(false);
            this.image_UploadsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private myImages myImages;
        private System.Windows.Forms.BindingSource image_UploadsBindingSource;
        private myImagesTableAdapters.Image_UploadsTableAdapter image_UploadsTableAdapter;
        private myImagesTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator image_UploadsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton image_UploadsBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label imgPathLabel1;
        private System.Windows.Forms.PictureBox imgPictureBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

