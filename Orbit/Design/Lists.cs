using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orbit.Design
{
    internal class Lists
    {
        public class Draws
        {
            public static void DrawItem(object sender, DrawItemEventArgs e)
            {
                var listBox = sender as ListBox;
                var backColor = Design.Colour.Secondary;         /*Default BackColor*/
                var textColor = Design.Colour.Text;          /*Default ForeColor*/
                var txt = listBox.GetItemText(listBox.Items[e.Index]);
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                {
                    backColor = Color.FromArgb(28, 28, 28);     /*Seletion BackColor*/
                    textColor = Design.Colour.Main;           /*Seletion ForeColor*/
                }
                using (var brush = new SolidBrush(backColor))
                    e.Graphics.FillRectangle(brush, e.Bounds);
                TextRenderer.DrawText(e.Graphics, txt, Design.Fonts.ProcessMain, e.Bounds, textColor,
                    TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
            }
        }
    }
}
