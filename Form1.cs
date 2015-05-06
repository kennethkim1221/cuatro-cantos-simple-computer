using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WIPS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            initializeChildWindows();
        }
        
        private Registers register;
        private SourceCode source;
        private Cycles cycles;
        private Pipeline pipeline;
        private Statistics stats;
        private Data data;

        private void initializeChildWindows()
        {
            register = new Registers();
            register.MdiParent = this;

            source = new SourceCode();
            source.MdiParent = this;

            cycles = new Cycles();
            cycles.MdiParent = this;

            pipeline = new Pipeline();
            pipeline.MdiParent = this;

            stats = new Statistics();
            stats.MdiParent = this;

            data = new Data();
            data.MdiParent = this;

            register.Show();
            source.Show();
            cycles.Show();
            pipeline.Show();
            stats.Show();
            data.Show();
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SourceCode viewer = new SourceCode();
            viewer.MdiParent = this;
            viewer.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void arraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.ArrangeIcons);
        }
    }
}
