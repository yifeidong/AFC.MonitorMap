/**********************************************************
** 文件名： ToolText.cs
** 文件作用:Text Tool
**
**---------------------------------------------------------
**修改历史记录：
**修改时间      修改人    修改内容概要
**2018-09-14    xwj       增加
**
**********************************************************/

using DrawTools.Device;
using System.Windows.Forms;

namespace DrawTools.DeviceTools
{
    public class ToolText : ToolRectangle
    {
        public ToolText()
        {
            Cursor = new Cursor(GetType(), "Ellipse.cur");
        }

        public override void OnMouseDown(DrawArea drawArea, MouseEventArgs e)
        {
            AddNewObject(drawArea, new Text(e.X, e.Y, 80, 40));
        }
    }
}