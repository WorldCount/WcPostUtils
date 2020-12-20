﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcApi.Win32;

namespace LK.Core.Libs.Widget
{
    public class ColoredProgressBar : ProgressBar
    {

        public ColoredProgressBar()
        {
            SetStyle(ControlStyles.UserPaint, true);
            DrawingControl.SetDoubleBuffered(this);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rec = e.ClipRectangle;

            rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;

            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);

            rec.Height = rec.Height - 4;

            e.Graphics.FillRectangle(new SolidBrush(BackColor), 2, 2, rec.Width, rec.Height);
        }
    }
}
