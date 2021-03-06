﻿using System.Drawing;
using System.Windows.Forms;
using SmartTaskbar.PlatformInvoke;

namespace SmartTaskbar.UI.Views
{
    public sealed class MenuButton : Button
    {
        public MenuButton()
        {
            FlatStyle = FlatStyle.Flat;
            BackColor = Color.Transparent;
            Size = new Size(230, 32);
            Margin = Padding.Empty;
            FlatAppearance.BorderSize = 0;
            Font = new Font("Segoe UI", 9F);
            TextAlign = ContentAlignment.MiddleLeft;
            TextImageRelation = TextImageRelation.ImageBeforeText;
            ImageAlign = ContentAlignment.MiddleCenter;
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            UseVisualStyleBackColor = false;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            ForeColor = UIInfo.ForeGround;
            FlatAppearance.MouseOverBackColor = FlatAppearance.MouseDownBackColor =
                UIInfo.IsWhiteBackground ? UIInfo.AccentLight3 : UIInfo.AccentDark3;
        }
    }
}
