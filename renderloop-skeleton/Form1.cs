using OpenGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace renderloop_skeleton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            RenderControl.DoubleBuffer = true;
        }

        private void RenderControl_ContextUpdate(object sender, GlControlEventArgs e)
        {

        }

        private void RenderControl_Render(object sender, GlControlEventArgs e)
        {            
            Gl.ClearColor(0.2f, 0.3f, 0.3f, 1.0f);
            Gl.Clear(ClearBufferMask.ColorBufferBit);
        }

        private void RenderControl_ContextDestroying(object sender, GlControlEventArgs e)
        {

        }

        private void RenderControl_ContextCreated(object sender, GlControlEventArgs e)
        {

        }
    }
}
