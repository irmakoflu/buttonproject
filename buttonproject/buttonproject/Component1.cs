using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buttonproject
{
    public partial class Component1 : Button
    {
        public Component1()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.ForeColor=Color.White;
            this.BackColor=Color.Orange;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
           // Graphics graphics=this.CreateGraphics();
            SolidBrush solidBrush=new SolidBrush(Color.White);
            Pen pen =new Pen (solidBrush);
            pevent.Graphics.DrawLine(pen,new Point(5,5),new Point(this.Width-5,5));
            pevent.Graphics.DrawLine(pen,new Point(5,this.Height-5),new Point(this.Width-5, this.Height - 5));
            pevent.Graphics.DrawLine(pen,new Point(5,5),new Point(5, this.Height - 5));
            pevent.Graphics.DrawLine(pen,new Point(this.Width-5,5),new Point(this.Width-5,this.Height-5));
        }


    }
}
