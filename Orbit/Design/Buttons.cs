using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orbit.Design
{
    internal class Buttons
    {
        public class Enter
        {
            public static void OnHover(object sender, EventArgs e)
            {
                if (sender is Label)
                {
                    Label label = (Label)sender;
                    label.ForeColor = Colour.Main;
                }
                else if (sender is Button)
                {
                    Button button = (Button)sender;
                    button.BackColor = Colour.Main;
                }
            }
        }
        public static class Leave
        {
            public static void OnHover(object sender, EventArgs e)
            {
                if (sender is Label)
                {
                    Label label = (Label)sender;
                    label.ForeColor = Colour.Secondary;
                }
                else if (sender is Button)
                {
                    Button button = (Button)sender;
                    button.BackColor = Colour.Secondary;
                }
            }
        }
    }
}
