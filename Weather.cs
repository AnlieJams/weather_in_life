using System;
using System.Windows.Forms;

namespace WinFormsApp15
{
    public partial class Form1 : Form
    {
        private TextBox cityTextBox;
        private Label timeLabel;

        public Form1()
        {
            InitializeComponent();
            InitializeUI();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void InitializeUI()
        {
            cityTextBox = new TextBox();
            cityTextBox.Location = new System.Drawing.Point(10, 10);
            cityTextBox.Size = new System.Drawing.Size(200, 20);

            timeLabel = new Label();
            timeLabel.Location = new System.Drawing.Point(10, 40);
            timeLabel.Size = new System.Drawing.Size(200, 20);

            Controls.Add(cityTextBox);
            Controls.Add(timeLabel);

            cityTextBox.TextChanged += CityTextBox_TextChanged;
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void UpdateTime()
        {
            string cityName = cityTextBox.Text.Trim();
            if (string.IsNullOrEmpty(cityName))
            {
                timeLabel.Text = "ֲגוהטעו םאחגאםטו דמנמהא";
                return;
            }

            try
            {
                
                TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(cityName);
                DateTime cityTime = TimeZoneInfo.ConvertTime(DateTime.Now, timeZone);

                
                timeLabel.Text = $"ׂוךףשוו גנולÿ ג {cityName}: {cityTime}";
            }
            catch (Exception ex)
            {
                timeLabel.Text = $"Ýננמנננננננננננ: {ex.Message}";
            }
        }
    }
}
