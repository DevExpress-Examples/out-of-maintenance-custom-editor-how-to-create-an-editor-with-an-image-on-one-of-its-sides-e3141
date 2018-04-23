namespace WindowsApplication1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.myButtonEdit1 = new WindowsApplication1.MyButtonEdit();
            this.myButtonEdit2 = new WindowsApplication1.MyButtonEdit();
            this.myButtonEdit3 = new WindowsApplication1.MyButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit3.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // myButtonEdit1
            // 
            this.myButtonEdit1.Location = new System.Drawing.Point(21, 12);
            this.myButtonEdit1.Name = "myButtonEdit1";
            this.myButtonEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("myButtonEdit1.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", "IsImage", null, true)});
            this.myButtonEdit1.Size = new System.Drawing.Size(202, 22);
            this.myButtonEdit1.TabIndex = 0;
            // 
            // myButtonEdit2
            // 
            this.myButtonEdit2.Location = new System.Drawing.Point(21, 62);
            this.myButtonEdit2.Name = "myButtonEdit2";
            this.myButtonEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("myButtonEdit2.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", "IsImage", null, true)});
            this.myButtonEdit2.Size = new System.Drawing.Size(202, 22);
            this.myButtonEdit2.TabIndex = 1;
            // 
            // myButtonEdit3
            // 
            this.myButtonEdit3.Location = new System.Drawing.Point(21, 116);
            this.myButtonEdit3.Name = "myButtonEdit3";
            this.myButtonEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("myButtonEdit3.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", "IsImage", null, true),
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.myButtonEdit3.Size = new System.Drawing.Size(202, 22);
            this.myButtonEdit3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 316);
            this.Controls.Add(this.myButtonEdit3);
            this.Controls.Add(this.myButtonEdit2);
            this.Controls.Add(this.myButtonEdit1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myButtonEdit3.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyButtonEdit myButtonEdit1;
        private MyButtonEdit myButtonEdit2;
        private MyButtonEdit myButtonEdit3;

    }
}

