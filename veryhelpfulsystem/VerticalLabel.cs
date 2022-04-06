using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veryhelpfulsystem
{
    public class VerticalLabel : UserControl
    {
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public new string Text
        {
            get { return base.Text; }
            set { base.Text = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.RotateTransform(-90);
            using (var brush = new SolidBrush(ForeColor))
                e.Graphics.DrawString(Text, Font, brush, 1 - Height, 1);
        }
    }
}
