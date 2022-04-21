using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNH2
{
    public partial class Form1 : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        
        public Form1()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panel1.Controls.Add(leftBorderBtn);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private struct RGBColors
        {
            public static Color Color1 = Color.FromArgb(172,126,241);
            public static Color Color2 = Color.FromArgb(249, 118, 176);
            public static Color Color3 = Color.FromArgb(253, 138, 114);
            public static Color Color4 = Color.FromArgb(95, 77, 221);
            public static Color Color5 = Color.FromArgb(249, 88, 155);
            public static Color Color6 = Color.FromArgb(24, 161, 251);

        }
        
        private void ActivateButton(object senderBtn,Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37,36,81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign=ContentAlignment.MiddleLeft;
                currentBtn.IconColor= color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign= ContentAlignment.MiddleLeft;
                leftBorderBtn.BackColor = color;
                
                leftBorderBtn.Location= new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible= true;
                leftBorderBtn.BringToFront();
                iconPictureBox1.IconChar = currentBtn.IconChar;
                iconPictureBox1.IconColor = color;
            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(37, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.Color1);

            openChildForm(new Form2 ());
            label1.Text = "DOANH THU";
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.Color2);
            openChildForm(new THỰC_ĐƠN());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.Color3);
            openChildForm(new DANH_MỤC());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.Color4);
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.Color5);
        }

        private void iconButton6_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.Color6);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        private void  openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock= DockStyle.Fill;
            panelDexktop.Controls.Add(childForm);
            panelDexktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = childForm.Text;
        }
        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconPictureBox1.IconChar = IconChar.Home;
            iconPictureBox1.IconColor = Color.MediumPurple;
            label1.Text = "Home";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }
    }
}
