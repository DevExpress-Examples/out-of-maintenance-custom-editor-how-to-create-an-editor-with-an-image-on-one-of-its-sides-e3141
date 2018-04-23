using System;
using DevExpress.XtraEditors.Drawing;
using System.Drawing;

namespace WindowsApplication1
{
    public class MyButtonEditPainter : ButtonEditPainter
    {

        public MyButtonEditPainter()
        {

        }

        protected override void DrawButton(DevExpress.XtraEditors.ViewInfo.ButtonEditViewInfo viewInfo, EditorButtonObjectInfoArgs info)
        {
            if ("IsImage".Equals(info.Button.Tag))
            {
                Rectangle bounds = info.Bounds;
                info.Graphics.FillRectangle(viewInfo.PaintAppearance.GetBackBrush(info.Cache), info.Bounds);
                bounds.Inflate(-3, -3);
                info.Graphics.DrawImage(info.Button.Image, bounds);
            }
            else
                base.DrawButton(viewInfo, info);
        }
    }
}
