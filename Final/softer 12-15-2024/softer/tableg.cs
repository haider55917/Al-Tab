using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace softer
{
    public partial class tableg : Form
    {
        public tableg()
        {
            InitializeComponent();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(Form_astqtab1))
            {
                tabControl1.Visible = true;
                tabControl1.Dock = DockStyle.Fill;
                tabControl1.TabPages.Add(Form_astqtab1);

                home home = new home();
                var x = Application.OpenForms["home"] as home;
                x.btn_slide_main.Enabled = false;
            }
            tabControl1.SelectedTab = Form_astqtab1;
            //MessageBox.Show("hhhh");
          
            
        }

        private void tableg_Load(object sender, EventArgs e)
        {
            tabControl1.Visible = false;
            tabControl1.TabPages.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnnext2_Click(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(Form_astqtab3))
            {
                tabControl1.TabPages.Add(Form_astqtab3);
                tabControl1.SelectedTab = Form_astqtab3;
            }
            tabControl1.SelectedTab = Form_astqtab3;
        }

        private void transfer_Click(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(Form_astqtab4))
            {
                tabControl1.TabPages.Add(Form_astqtab4);
                tabControl1.SelectedTab = Form_astqtab4;
            }
            tabControl1.SelectedTab = Form_astqtab4;
        }

        private void transfer_out_Click(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(Form_astqtab6))
            {
                tabControl1.TabPages.Add(Form_astqtab6);
                tabControl1.SelectedTab = Form_astqtab6;
            }
            tabControl1.SelectedTab = Form_astqtab6;
        }

        private void transfer_first_Click(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(Form_astqtab5))
            {
                tabControl1.TabPages.Add(Form_astqtab5);
                tabControl1.SelectedTab = Form_astqtab5;
            }
            tabControl1.SelectedTab = Form_astqtab5;
        }

        private void transfer_thired_Click(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(Form_astqtab7))
            {
                tabControl1.TabPages.Add(Form_astqtab7);
                tabControl1.SelectedTab = Form_astqtab7;
            }
            tabControl1.SelectedTab = Form_astqtab7;
        }

        private void btnsavelast_Click(object sender, EventArgs e)
        {
            home hom = (home)Application.OpenForms["home"];
            if (hom != null)
            {
                hom.form_panel.Controls.Clear();

                tableg tab = new tableg();
                tab.TopLevel = false;
                tab.FormBorderStyle = FormBorderStyle.None;
                tab.Dock = DockStyle.Fill;
                hom.form_panel.Controls.Add(tab);
                tab.Show();
            }
        }

        private void btnblas_Click(object sender, EventArgs e)
        {
            List<Panel> panelsToMove = new List<Panel> { panelwtha, panelcart, paneldwra, panelcarttd };
            PanelExpander expander = new PanelExpander(panelaml, panelsToMove, btnblas, 150);
            expander.ExpandPanel();
        }

        private void btnblas2_Click(object sender, EventArgs e)
        {
            List<Panel> panelsToMove = new List<Panel> { panelcart, paneldwra, panelcarttd };
            PanelExpander expander = new PanelExpander(panelwtha, panelsToMove, btnblas2, 150);
            expander.ExpandPanel();
        }

        private void btnblas3_Click(object sender, EventArgs e)
        {
            List<Panel> panelsToMove = new List<Panel> { paneldwra, panelcarttd };
            PanelExpander expander = new PanelExpander(panelcart, panelsToMove, btnblas3, 150);
            expander.ExpandPanel();
        }

        private void btnblas4_Click(object sender, EventArgs e)
        {
            List<Panel> panelsToMove = new List<Panel> { panelcarttd };
            PanelExpander expander = new PanelExpander(paneldwra, panelsToMove, btnblas4, 150);
            expander.ExpandPanel();
        }

        private void btnblas5_Click(object sender, EventArgs e)
        {
            // هنا تمرير Panel3 كـ scrollablePanel للتحكم في التمرير
            PanelExpander expander = new PanelExpander(panelcarttd, new List<Panel>(), btnblas5, 150, paneltableg3);
            expander.ExpandPanel();
        }

        private void btnblas6_Click(object sender, EventArgs e)
        {
            List<Panel> panelsToMove = new List<Panel> { };
            PanelExpander expander = new PanelExpander(panalmqdmat, panelsToMove, btnblas6, 150);
            expander.ExpandPanel();
        }

        private void btnblas7_Click(object sender, EventArgs e)
        {
            List<Panel> panelsToMove = new List<Panel> { };
            PanelExpander expander = new PanelExpander(panelstoh1, panelsToMove, btnblas7, 150);
            expander.ExpandPanel();
        }

        private void btnblas8_Click(object sender, EventArgs e)
        {
            List<Panel> panelsToMove = new List<Panel> { };
            PanelExpander expander = new PanelExpander(panelstoh2, panelsToMove, btnblas8, 150);
            expander.ExpandPanel();
        }

        private void btnblas9_Click(object sender, EventArgs e)
        {
            List<Panel> panelsToMove = new List<Panel> { };
            PanelExpander expander = new PanelExpander(panelout, panelsToMove, btnblas9, 150);
            expander.ExpandPanel();
        }

        private void btnblas10_Click(object sender, EventArgs e)
        {
            List<Panel> panelsToMove = new List<Panel> { };
            PanelExpander expander = new PanelExpander(panelmoarfon, panelsToMove, btnblas10, 150);
            expander.ExpandPanel();
        }

        private void scanpic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.bmb";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pic_scan_moa.Image = Image.FromFile(openFileDialog.FileName);
                pic_scan_moa.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btn_pic_info_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.bmb";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureinfo.Image = Image.FromFile(openFileDialog.FileName);
                pictureinfo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(Form_astqtab2))
            {
                tabControl1.TabPages.Add(Form_astqtab2);
                tabControl1.SelectedTab = Form_astqtab2;
            }
            tabControl1.SelectedTab = Form_astqtab2;
        }

        private void btntadqeq_Click(object sender, EventArgs e)
        {
            if (!tabControl1.TabPages.Contains(Form_astqtab8))
            {
                tabControl1.TabPages.Add(Form_astqtab8);
                tabControl1.SelectedTab = Form_astqtab8;
                tabControl1.Visible = true;
                tabControl1.Dock = DockStyle.Fill;
                home home = new home();
                var x = Application.OpenForms["home"] as home;
                x.btn_slide_main.Enabled = false;
            }
            tabControl1.SelectedTab = Form_astqtab8;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ستتوفر قريباً");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            MessageBox.Show("ستتوفر قريباً");
        }

        private void btntkarer_Click(object sender, EventArgs e)
        {

            MessageBox.Show("ستتوفر قريباً");
        }

        private void button2_Click_2(object sender, EventArgs e)
        {

            home home = new home();
            home.Show();
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (MessageBox.Show("هل انت متأكد من الرجوع", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                home hom = (home)Application.OpenForms["home"];
                if (hom != null)
                {
                    hom.form_panel.Controls.Clear();

                    tableg tab = new tableg();
                    tab.TopLevel = false;
                    tab.FormBorderStyle = FormBorderStyle.None;
                    tab.Dock = DockStyle.Fill;
                    hom.form_panel.Controls.Add(tab);
                    tab.Show();
                }
            }
    }

        private void btn_back_Click(object sender, EventArgs e)
        {
            home hom = (home)Application.OpenForms["home"];
            if (hom != null)
            {
                hom.form_panel.Controls.Clear();

                tableg tab = new tableg();
                tab.TopLevel = false;
                tab.FormBorderStyle = FormBorderStyle.None;
                tab.Dock = DockStyle.Fill;
                hom.form_panel.Controls.Add(tab);
                tab.Show();
            }
        }
    }
}
