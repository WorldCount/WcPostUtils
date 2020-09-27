using System.Drawing;
using System.Windows.Forms;

namespace PartStat.Core.Libs.Widget
{

    public class CheckDataGridColumn : DataGridViewCheckBoxColumn
    {

    }

    public class CheckDataGridColumnHeaderCell : DataGridViewColumnHeaderCell
    {
        public Image Image { get; set; }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex,
            DataGridViewElementStates dataGridViewElementState, object value, object formattedValue, string errorText,
            DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {
            if ((rowIndex != -1) || (Image == null))
            {
                base.Paint(graphics, clipBounds, cellBounds, rowIndex, dataGridViewElementState, value, formattedValue,
                    errorText, cellStyle, advancedBorderStyle, paintParts);
            }

            // Borders, background, focus selection can remain the same
            // But Foreground will have different image
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, dataGridViewElementState, value, formattedValue, errorText, cellStyle,
                advancedBorderStyle, paintParts & ~DataGridViewPaintParts.ContentForeground);

            if ((paintParts & DataGridViewPaintParts.ContentBackground) != DataGridViewPaintParts.None)
            {
                // +4 is hardcoded margin 
                Point bounds = new Point(cellBounds.X + 4, cellBounds.Y);

                // Handle vertical alignment correctly
                switch (cellStyle.Alignment)
                {
                    // Top
                    case DataGridViewContentAlignment.TopLeft:
                    case DataGridViewContentAlignment.TopCenter:
                    case DataGridViewContentAlignment.TopRight:
                        // Already set
                        break;

                    // Middle
                    case DataGridViewContentAlignment.MiddleLeft:
                    case DataGridViewContentAlignment.MiddleCenter:
                    case DataGridViewContentAlignment.MiddleRight:
                        bounds.Y = cellBounds.Y + (cellBounds.Height - Image.Height) / 2;
                        break;

                    // Bottom
                    case DataGridViewContentAlignment.BottomLeft:
                    case DataGridViewContentAlignment.BottomCenter:
                    case DataGridViewContentAlignment.BottomRight:
                        bounds.Y = cellBounds.Y + (cellBounds.Height - Image.Height);
                        break;

                }

                Size size = Image.Size;
                Point loc = new Point((cellBounds.Width - size.Width) / 2, (cellBounds.Height - size.Height) / 2);
                loc.Offset(cellBounds.Location);
                graphics.DrawImageUnscaled(Image, cellBounds);
            }

            // Foreground should be shifted by left image margin + image.width + right 
            // image margin and of course target spot should be a bit smaller
            if ((paintParts & DataGridViewPaintParts.ContentForeground) != DataGridViewPaintParts.None)
            {
                Rectangle newCellBounds = new Rectangle(cellBounds.X + 4 + Image.Width + 4, cellBounds.Y, cellBounds.Width - Image.Width - 8, cellBounds.Height);
                base.Paint(graphics, clipBounds, newCellBounds, rowIndex, dataGridViewElementState, value, formattedValue, errorText, cellStyle,
                    advancedBorderStyle, DataGridViewPaintParts.ContentForeground);
            }
        }

        protected override Size GetPreferredSize(Graphics graphics, DataGridViewCellStyle cellStyle, int rowIndex, Size constraintSize)
        {
            // Load up original image
            Size original = base.GetPreferredSize(graphics, cellStyle, rowIndex, constraintSize);

            // Ensure the image is set and that we are working on header
            if ((rowIndex != -1) || (Image == null))
            {
                return original;
            }

            // -1 is reserved value
            if (original.Width < 0)
            {
                return original;
            }
            return new Size(original.Width + Image.Width + 4, original.Height);
        }
    }
}
