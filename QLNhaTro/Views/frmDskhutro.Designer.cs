
namespace QLNhaTro.Views
{
    partial class frmDskhutro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDskhutro));
            this.pdfVThemkhutro = new DevExpress.XtraPdfViewer.PdfViewer();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.btnHuyDsnhatro = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // pdfVThemkhutro
            // 
            this.pdfVThemkhutro.Location = new System.Drawing.Point(67, 43);
            this.pdfVThemkhutro.Margin = new System.Windows.Forms.Padding(4);
            this.pdfVThemkhutro.Name = "pdfVThemkhutro";
            this.pdfVThemkhutro.Size = new System.Drawing.Size(1251, 407);
            this.pdfVThemkhutro.TabIndex = 0;
            // 
            // btnLuu
            // 
            this.btnLuu.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Appearance.Options.UseBackColor = true;
            this.btnLuu.Appearance.Options.UseFont = true;
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnLuu.Location = new System.Drawing.Point(565, 437);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(70, 80);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            // 
            // btnHuyDsnhatro
            // 
            this.btnHuyDsnhatro.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.btnHuyDsnhatro.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyDsnhatro.Appearance.Options.UseBackColor = true;
            this.btnHuyDsnhatro.Appearance.Options.UseFont = true;
            this.btnHuyDsnhatro.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuyDsnhatro.ImageOptions.Image")));
            this.btnHuyDsnhatro.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnHuyDsnhatro.Location = new System.Drawing.Point(707, 437);
            this.btnHuyDsnhatro.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyDsnhatro.Name = "btnHuyDsnhatro";
            this.btnHuyDsnhatro.Size = new System.Drawing.Size(70, 80);
            this.btnHuyDsnhatro.TabIndex = 6;
            this.btnHuyDsnhatro.Text = "Hủy";
            this.btnHuyDsnhatro.Click += new System.EventHandler(this.btnHuyDsnhatro_Click);
            // 
            // frmDskhutro
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1409, 705);
            this.Controls.Add(this.btnHuyDsnhatro);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.pdfVThemkhutro);
            this.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmDskhutro";
            this.Padding = new System.Windows.Forms.Padding(129, 500, 129, 59);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách dãy trọ";
            this.Load += new System.EventHandler(this.frmDskhutro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraPdfViewer.PdfViewer pdfVThemkhutro;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.SimpleButton btnHuyDsnhatro;
    }
}