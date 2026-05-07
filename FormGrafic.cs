using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProiectPAW
{
    public partial class FormGrafic : Form
    {
        private AgendaActivitati agenda;

        public FormGrafic(AgendaActivitati agenda)
        {
            InitializeComponent();
            this.agenda = agenda;
            cbTipGrafic.SelectedIndex = 0;
        }

        private void cbTipGrafic_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelGrafic.Invalidate();
        }

        private void panelGrafic_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            if (agenda.TotalActivitati == 0)
            {
                gr.DrawString("Nu exista activitati de afisat.",
                    new Font("Segoe UI", 12), Brushes.Gray, 20, 20);
                return;
            }
            if (cbTipGrafic.SelectedIndex <= 0)
                DesenPieChart(gr);
            else
                DesenBarChart(gr);
        }

        #region Pie Chart - Distributie pe domenii

        private void DesenPieChart(Graphics gr)
        {
            Dictionary<string, int> perDomeniu = new Dictionary<string, int>();
            Dictionary<string, string> culoriDomeniu = new Dictionary<string, string>();
            foreach (Activitate a in agenda.Activitati)
            {
                string numeDom = a.Domeniu.Titlu;
                if (perDomeniu.ContainsKey(numeDom))
                    perDomeniu[numeDom]++;
                else
                {
                    perDomeniu[numeDom] = 1;
                    culoriDomeniu[numeDom] = a.Domeniu.Culoare;
                }
            }

            int total = agenda.TotalActivitati;
            int w = panelGrafic.ClientSize.Width;
            int h = panelGrafic.ClientSize.Height;

            Font fontTitlu = new Font("Segoe UI", 14, FontStyle.Bold);
            string titlu = "Distributia activitatilor pe domenii";
            SizeF sizeTitlu = gr.MeasureString(titlu, fontTitlu);
            gr.DrawString(titlu, fontTitlu, Brushes.DarkSlateGray, (w - sizeTitlu.Width) / 2, 10);

            int diametru = Math.Min(w - 200, h - 100);
            if (diametru < 100) diametru = 100;
            int pieX = 30;
            int pieY = (h - diametru) / 2 + 15;
            Rectangle rectPie = new Rectangle(pieX, pieY, diametru, diametru);

            float unghiStart = 0;
            int idx = 0;
            Font fontLegenda = new Font("Segoe UI", 10);
            int legendaX = pieX + diametru + 30;
            int legendaY = pieY + 10;

            foreach (var pereche in perDomeniu)
            {
                float unghi = (float)pereche.Value / total * 360f;
                Color culoare = GetCuloare(culoriDomeniu[pereche.Key], idx);

                using (Brush br = new SolidBrush(culoare))
                    gr.FillPie(br, rectPie, unghiStart, unghi);
                gr.DrawPie(Pens.White, rectPie, unghiStart, unghi);

                gr.FillRectangle(new SolidBrush(culoare), legendaX, legendaY, 16, 16);
                gr.DrawRectangle(Pens.DarkGray, legendaX, legendaY, 16, 16);
                gr.DrawString($"{pereche.Key}: {pereche.Value} ({pereche.Value * 100 / total}%)",
                    fontLegenda, Brushes.Black, legendaX + 22, legendaY - 1);

                legendaY += 25;
                unghiStart += unghi;
                idx++;
            }

            gr.DrawString($"Total: {total} activitati", fontLegenda,
                Brushes.DarkSlateGray, legendaX, legendaY + 5);
        }

        #endregion

        #region Bar Chart - Activitati pe prioritate

        private void DesenBarChart(Graphics gr)
        {
            int[] perPrioritate = new int[5];
            foreach (Activitate a in agenda.Activitati)
                perPrioritate[a.Prioritate - 1]++;

            int w = panelGrafic.ClientSize.Width;
            int h = panelGrafic.ClientSize.Height;

            Font fontTitlu = new Font("Segoe UI", 14, FontStyle.Bold);
            string titlu = "Activitati pe nivel de prioritate";
            SizeF sizeTitlu = gr.MeasureString(titlu, fontTitlu);
            gr.DrawString(titlu, fontTitlu, Brushes.DarkSlateGray, (w - sizeTitlu.Width) / 2, 10);

            int mL = 50, mR = 30, mT = 50, mB = 50;
            Rectangle zona = new Rectangle(mL, mT, w - mL - mR, h - mT - mB);

            Pen penAxa = new Pen(Color.DarkGray, 2);
            gr.DrawLine(penAxa, zona.Left, zona.Top, zona.Left, zona.Bottom);
            gr.DrawLine(penAxa, zona.Left, zona.Bottom, zona.Right, zona.Bottom);

            int maxVal = perPrioritate.Max();
            if (maxVal == 0) maxVal = 1;

            Color[] culori = {
                Color.FromArgb(76, 175, 80),
                Color.FromArgb(139, 195, 74),
                Color.FromArgb(255, 193, 7),
                Color.FromArgb(255, 152, 0),
                Color.FromArgb(244, 67, 54)
            };

            float latimeBar = zona.Width / 5f * 0.6f;
            float distanta = zona.Width / 5f;
            Font fontVal = new Font("Segoe UI", 11, FontStyle.Bold);
            Font fontLabel = new Font("Segoe UI", 9);

            for (int i = 1; i <= maxVal; i++)
            {
                int yL = zona.Bottom - (int)((float)i / maxVal * zona.Height);
                gr.DrawLine(new Pen(Color.FromArgb(230, 230, 230)), zona.Left + 1, yL, zona.Right, yL);
                gr.DrawString(i.ToString(), fontLabel, Brushes.Gray, zona.Left - 25, yL - 7);
            }

            for (int i = 0; i < 5; i++)
            {
                float x = zona.Left + i * distanta + (distanta - latimeBar) / 2;
                float inaltime = (float)perPrioritate[i] / maxVal * zona.Height;
                float y = zona.Bottom - inaltime;

                using (Brush br = new SolidBrush(culori[i]))
                    gr.FillRectangle(br, x, y, latimeBar, inaltime);
                gr.DrawRectangle(Pens.DarkGray, x, y, latimeBar, inaltime);

                string val = perPrioritate[i].ToString();
                SizeF sv = gr.MeasureString(val, fontVal);
                gr.DrawString(val, fontVal, Brushes.DarkSlateGray,
                    x + (latimeBar - sv.Width) / 2, y - sv.Height - 2);

                string label = $"P{i + 1}";
                SizeF sl = gr.MeasureString(label, fontLabel);
                gr.DrawString(label, fontLabel, Brushes.Black,
                    x + (latimeBar - sl.Width) / 2, zona.Bottom + 5);
            }
        }

        #endregion

        #region Culoare Helper

        private Color GetCuloare(string culoareDomeniu, int index)
        {
            switch (culoareDomeniu?.ToLower())
            {
                case "albastru":   return Color.FromArgb(66, 133, 244);
                case "rosu":       return Color.FromArgb(234, 67, 53);
                case "verde":      return Color.FromArgb(52, 168, 83);
                case "galben":     return Color.FromArgb(251, 188, 4);
                case "portocaliu": return Color.FromArgb(255, 152, 0);
                case "mov":        return Color.FromArgb(156, 39, 176);
                case "gri":        return Color.FromArgb(158, 158, 158);
                default:
                    Color[] rezerva = { Color.CornflowerBlue, Color.Coral, Color.MediumSeaGreen };
                    return rezerva[index % rezerva.Length];
            }
        }

        #endregion

        private void btnSalveazaImagine_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Imagine PNG (*.png)|*.png|Imagine BMP (*.bmp)|*.bmp";
            sfd.FileName = "grafic_agenda.png";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(panelGrafic.Width, panelGrafic.Height);
                panelGrafic.DrawToBitmap(bmp, new Rectangle(0, 0, panelGrafic.Width, panelGrafic.Height));
                bmp.Save(sfd.FileName);
                bmp.Dispose();
                MessageBox.Show("Graficul a fost salvat!", "Salvare",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
