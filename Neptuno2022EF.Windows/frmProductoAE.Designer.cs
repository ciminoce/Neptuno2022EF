namespace Neptuno2022EF.Windows
{
    partial class frmProductoAE
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
            this.SuspendidoCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.MinimoNmericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.StockNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProveedoresComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CategoriasComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PrecioVtaTextBox = new System.Windows.Forms.TextBox();
            this.ProductoTextBox = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.ImagenPictureBox = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MinimoNmericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // SuspendidoCheckBox
            // 
            this.SuspendidoCheckBox.AutoSize = true;
            this.SuspendidoCheckBox.Location = new System.Drawing.Point(145, 245);
            this.SuspendidoCheckBox.Name = "SuspendidoCheckBox";
            this.SuspendidoCheckBox.Size = new System.Drawing.Size(15, 14);
            this.SuspendidoCheckBox.TabIndex = 60;
            this.SuspendidoCheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 59;
            this.label7.Text = "Suspendido:";
            // 
            // MinimoNmericUpDown
            // 
            this.MinimoNmericUpDown.Location = new System.Drawing.Point(145, 210);
            this.MinimoNmericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.MinimoNmericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinimoNmericUpDown.Name = "MinimoNmericUpDown";
            this.MinimoNmericUpDown.ReadOnly = true;
            this.MinimoNmericUpDown.Size = new System.Drawing.Size(120, 20);
            this.MinimoNmericUpDown.TabIndex = 57;
            this.MinimoNmericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Stock Mínimo:";
            // 
            // StockNumericUpDown
            // 
            this.StockNumericUpDown.Location = new System.Drawing.Point(145, 176);
            this.StockNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.StockNumericUpDown.Name = "StockNumericUpDown";
            this.StockNumericUpDown.ReadOnly = true;
            this.StockNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.StockNumericUpDown.TabIndex = 58;
            this.StockNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Precio Vta:";
            // 
            // ProveedoresComboBox
            // 
            this.ProveedoresComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProveedoresComboBox.FormattingEnabled = true;
            this.ProveedoresComboBox.Location = new System.Drawing.Point(145, 109);
            this.ProveedoresComboBox.Name = "ProveedoresComboBox";
            this.ProveedoresComboBox.Size = new System.Drawing.Size(263, 21);
            this.ProveedoresComboBox.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Proveedor:";
            // 
            // CategoriasComboBox
            // 
            this.CategoriasComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CategoriasComboBox.FormattingEnabled = true;
            this.CategoriasComboBox.Location = new System.Drawing.Point(145, 75);
            this.CategoriasComboBox.Name = "CategoriasComboBox";
            this.CategoriasComboBox.Size = new System.Drawing.Size(263, 21);
            this.CategoriasComboBox.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Categoría:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Producto:";
            // 
            // PrecioVtaTextBox
            // 
            this.PrecioVtaTextBox.Location = new System.Drawing.Point(145, 143);
            this.PrecioVtaTextBox.MaxLength = 200;
            this.PrecioVtaTextBox.Name = "PrecioVtaTextBox";
            this.PrecioVtaTextBox.Size = new System.Drawing.Size(263, 20);
            this.PrecioVtaTextBox.TabIndex = 47;
            // 
            // ProductoTextBox
            // 
            this.ProductoTextBox.Location = new System.Drawing.Point(145, 42);
            this.ProductoTextBox.MaxLength = 200;
            this.ProductoTextBox.Name = "ProductoTextBox";
            this.ProductoTextBox.Size = new System.Drawing.Size(360, 20);
            this.ProductoTextBox.TabIndex = 48;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = global::Neptuno2022EF.Windows.Properties.Resources.search_property_30px;
            this.btnBuscar.Location = new System.Drawing.Point(582, 193);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(159, 52);
            this.btnBuscar.TabIndex = 63;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::Neptuno2022EF.Windows.Properties.Resources.cancel_24px;
            this.btnCancelar.Location = new System.Drawing.Point(666, 288);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 66);
            this.btnCancelar.TabIndex = 62;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Image = global::Neptuno2022EF.Windows.Properties.Resources.ok_24px;
            this.btnOK.Location = new System.Drawing.Point(45, 288);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 66);
            this.btnOK.TabIndex = 64;
            this.btnOK.Text = "OK";
            this.btnOK.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnOK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // ImagenPictureBox
            // 
            this.ImagenPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImagenPictureBox.Location = new System.Drawing.Point(582, 42);
            this.ImagenPictureBox.Name = "ImagenPictureBox";
            this.ImagenPictureBox.Size = new System.Drawing.Size(159, 143);
            this.ImagenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImagenPictureBox.TabIndex = 61;
            this.ImagenPictureBox.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmProductoAE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 375);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.ImagenPictureBox);
            this.Controls.Add(this.SuspendidoCheckBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MinimoNmericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.StockNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProveedoresComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CategoriasComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrecioVtaTextBox);
            this.Controls.Add(this.ProductoTextBox);
            this.Name = "frmProductoAE";
            this.Text = "frmProductoAE";
            ((System.ComponentModel.ISupportInitialize)(this.MinimoNmericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StockNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImagenPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.PictureBox ImagenPictureBox;
        private System.Windows.Forms.CheckBox SuspendidoCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown MinimoNmericUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown StockNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ProveedoresComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CategoriasComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PrecioVtaTextBox;
        private System.Windows.Forms.TextBox ProductoTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}