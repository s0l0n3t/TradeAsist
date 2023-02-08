using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Xml.Linq;
using System.Xml;

namespace TradeAsist.tools
{
    [DefaultEvent("OnSelectedIndexChanged")]
    class CustomComboBox : UserControl
    {
        private Color back_color = Color.White;
        private Color font_color = Color.IndianRed;
        private Color listBackColor = Color.FromArgb(204,102,102);
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.IndianRed;
        private int borderSize = 1;
      

        private ComboBox cmblist;
        private Label lbllist;
        private Button btnlist;

        [Category("Custom Code - Appearance")]
        public Color Back_color {
            get { return back_color; }
            set
            {
                back_color = value;
                btnlist.BackColor = back_color;
                lbllist.BackColor = back_color;

            }
        }
        [Category("Custom Code - Appearance")]
        public Color Font_color
        {
            get
            {
                return font_color;
            }
            set
            {
                font_color = value;
                btnlist.Invalidate();//Redrawing icon   


            }
        }
        [Category("Custom Code - Appearance")]
        public Color ListBackColor {
            get 
            {
                return listBackColor;
            }
            set 
            {
                listBackColor = value;
                cmblist.BackColor= listBackColor;

            }
            }
        [Category("Custom Code - Appearance")]
        public Color ListTextColor 
        {
            get 
            {
                return listTextColor;
            }
            set 
            {
                listTextColor = value;
                cmblist.ForeColor= listTextColor;
                }
        }
        [Category("Custom Code - Appearance")]
        public Color BorderColor 
        {
            get { return borderColor; }
            set 
            {
                borderColor = value;
                base.BackColor = borderColor;

            } 
        }
        [Category("Custom Code - Appearance")]
        public int BorderSize 
        {
            get { return borderSize; }
            set 
            {
                borderSize = value;
                this.Padding = new Padding(borderSize);
                AdjustComboBoxDimensions();
            } 
        }
        [Category("Custom Code - Appearance")]
        public override Color ForeColor 
        {
            get 
            {
               return base.ForeColor;
            }
            set { base.ForeColor = value;
                lbllist.ForeColor = value;
            }
        }
        [Category("Custom Code - Appearance")]
        public override Font Font 
        {
            get
            {
                return base.Font;
            }
            set 
            {
                base.Font = value;
                lbllist.Font = value;
                cmblist.Font = value;//Optional

            }
        }
        [Category("Custom Code - Appearance")]
        public string Texts
        {
            get
            {
                return lbllist.Text;

            }
            set
            {
                lbllist.Text = value;
            }
        }
        [Category("Custom Code - Appearance")]
        public ComboBoxStyle DropdownStyle
        {
            get
            {
                return cmblist.DropDownStyle;
            }
            set
            {

                if(cmblist.DropDownStyle != ComboBoxStyle.Simple)
                    cmblist.DropDownStyle = value;
            }
        }
        [Category("Custom Code - Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get { return cmblist.Items; }
        }
        [Category("Custom Code - Data")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public object DataSource
        {
            get { return cmblist.DataSource; }
            set { cmblist.DataSource = value; }
        }
        [Category("Custom Code - Data")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get { return cmblist.AutoCompleteCustomSource; }
            set { cmblist.AutoCompleteCustomSource = value; }
        }
        [Category("Custom Code - Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get { return cmblist.AutoCompleteSource; }
            set { cmblist.AutoCompleteSource = value; }
        }
        [Category("Custom Code - Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get { return cmblist.AutoCompleteMode; }
            set { cmblist.AutoCompleteMode = value; }
        }
        [Category("Custom Code - Data")]
        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get { return cmblist.SelectedItem; }
            set { cmblist.SelectedItem = value; }
        }
        [Category("Custom Code - Data")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get { return cmblist.SelectedIndex; }
            set { cmblist.SelectedIndex = value; }
        }
        [Category("Custom Code - Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string DisplayMember
        {
            get { return cmblist.DisplayMember; }
            set { cmblist.DisplayMember = value; }
        }
        [Category("Custom Code - Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string ValueMember
        {
            get { return cmblist.ValueMember; }
            set { cmblist.ValueMember = value; }
        }


        public event EventHandler OnSelectedIndexChanged;

        public CustomComboBox()
        {
            cmblist= new ComboBox();
            lbllist= new Label();
            btnlist = new Button();
            this.SuspendLayout();

            cmblist.BackColor= listBackColor;
            cmblist.Font = new Font(this.Font.Name, 10F);
            cmblist.ForeColor = listTextColor;
            cmblist.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            cmblist.TextChanged += new EventHandler(ComboBox_TextChanged);
            btnlist.Dock = DockStyle.Right;
            btnlist.FlatStyle = FlatStyle.Flat;
            btnlist.FlatAppearance.BorderSize= 0;
            btnlist.BackColor= listBackColor;
            btnlist.Size = new Size(30, 30);
            btnlist.Cursor = Cursors.Hand;
            btnlist.Click += new EventHandler(Icon_Click);
            btnlist.Paint += new PaintEventHandler(Icon_Paint);


            lbllist.Dock = DockStyle.Fill;
            lbllist.AutoSize= false;
            lbllist.BackColor= listBackColor;
            lbllist.TextAlign=ContentAlignment.MiddleLeft;
            lbllist.Padding = new Padding(8,0,0,0);
            lbllist.Font = new Font(this.Font.Name, 10F);
            lbllist.Click+= new EventHandler(Surface_Click); // select combobox

            this.Controls.Add(lbllist);
            this.Controls.Add(btnlist);
            this.Controls.Add(cmblist);
            this.MaximumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor= Color.DimGray;
            this.Padding = new Padding(borderSize);
            base.BackColor = borderColor;
            this.ResumeLayout();
            AdjustComboBoxDimensions();



        }

        private void AdjustComboBoxDimensions()
        {
            cmblist.Width = lbllist.Width;
            cmblist.Location = new Point()
            {
                X = this.Width - this.Padding.Right - cmblist.Width,
                Y = lbllist.Bottom - cmblist.Height

            };

        }

        private void Surface_Click(object? sender, EventArgs e)
        {
            this.OnClick(e);
            //Select combo box
            cmblist.Select();
            if (cmblist.DropDownStyle == ComboBoxStyle.DropDownList)
                cmblist.DroppedDown = true;//Open dropdown list
        }

        private void Icon_Paint(object? sender, PaintEventArgs e)
        {
            int iconWidht = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnlist.Width - iconWidht) / 2, (btnlist.Height - iconHeight) / 2, iconWidht, iconHeight);
            Graphics graph = e.Graphics;
            //Draw arrow down icon
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(font_color, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidht / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidht / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }

        private void Icon_Click(object? sender, EventArgs e)
        {
            cmblist.Select();
            cmblist.DroppedDown = true;
        }

        private void ComboBox_TextChanged(object? sender, EventArgs e)
        {
            lbllist.Text = cmblist.Text;
        }

        private void ComboBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);
            //Refresh text
            btnlist.Text = cmblist.Text;
        }
    }
}
