﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamApp
{
    public partial class edit_form : Form
    {
        public edit_form()
        {
            InitializeComponent();
        }

        public Button DirectingButton1
        {
            get { return this.CreateQuestionButton; }
        }

        public FlowLayoutPanel QBox
        {
            get { return QuestionFlowLayout; }
        }

        public CheckBox SubcategoriesQ
        {
            get { return this.ShowQuestionsSubcategoriesCheckBox; }
        }

        public TabControl DirectTab
        {
            get { return DirectionInEditPanel; }
        }

        public void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            if(e.Index == DirectionInEditPanel.SelectedIndex)
            {
                e.Graphics.DrawString(DirectionInEditPanel.TabPages[e.Index].Text, new Font(DirectionInEditPanel.Font, FontStyle.Regular), Brushes.Black, new PointF(e.Bounds.X, e.Bounds.Y));
            }
            else
            {
                e.Graphics.DrawString(DirectionInEditPanel.TabPages[e.Index].Text, new Font(DirectionInEditPanel.Font, FontStyle.Regular), Brushes.DeepSkyBlue, new PointF(e.Bounds.X, e.Bounds.Y));
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if(panel22.Visible == true)
            {
                panel22.Hide();
                this.label1.Image = global::ExamApp.Properties.Resources.icon1;
            }
            else
            {
                panel22.Show();
                this.label1.Image = global::ExamApp.Properties.Resources.icon2;
            }
        }

        private void label18_Click(object sender, EventArgs e)
        {
            if (panel44.Visible == true)
            {
                panel44.Hide();
                this.label17.Image = global::ExamApp.Properties.Resources.icon1;
            }
            else
            {
                panel44.Show();
                this.label17.Image = global::ExamApp.Properties.Resources.icon2;
            }
        }
    }
}
