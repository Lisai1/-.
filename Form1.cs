using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CallCenterApp
{
    public partial class Form1 : Form
    {
        private CallCenterMetrics metrics;

        public Form1()
        {
            InitializeComponent();
            metrics = new CallCenterMetrics();
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                //Сбор и структурирование входных данных из полей формы
                int totalCalls = int.Parse(txtTotalCalls.Text);
                int firstCallResolved = int.Parse(txtFirstCallResolved.Text);
                int escalated = int.Parse(txtEscalated.Text);
                string[] times = txtResponseTimes.Text.Split(new[] { ' ', ',', ';' }, StringSplitOptions.RemoveEmptyEntries);
                List<int> responseTimes = new List<int>();
                foreach (string t in times)
                    responseTimes.Add(int.Parse(t));

                //Вызов методов расчёта
                double avg = metrics.AvgResponseTime(responseTimes);
                double fcr = metrics.FCR(totalCalls, firstCallResolved);
                double esc = metrics.EscalationRate(totalCalls, escalated);

                // Вывод результатов
                lblAvgResult.Text = $"Средняя скорость ответа: {avg:F2} сек";
                lblFCRResult.Text = $"FCR: {fcr:F2} %";
                lblEscResult.Text = $"Эскалация: {esc:F2} %";
            }
            catch (Exception ex)
            {
                // Обработка ошибок
                MessageBox.Show("❌ Ошибка: " + ex.Message, "Некорректный ввод", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    // Модуль расчётов
    public class CallCenterMetrics
    {
        // Расчёт средней скорости ответа (ASA)
        public double AvgResponseTime(List<int> responseTimes)
        {
            if (responseTimes == null || responseTimes.Count == 0)
                throw new ArgumentException("Список времени ответа пуст.");
            return responseTimes.Average(); // Σti / n
        }

        // Расчёт процента решённых с первого звонка (FCR)
        public double FCR(int totalCalls, int firstCallResolved)
        {
            if (totalCalls <= 0)
                throw new ArgumentException("Общее число звонков должно быть > 0.");
            if (firstCallResolved < 0 || firstCallResolved > totalCalls)
                throw new ArgumentException("Некорректное число решённых с первого звонка.");
            return (double)firstCallResolved / totalCalls * 100;
        }

        // Расчёт уровня эскалации
        public double EscalationRate(int totalCalls, int escalatedCalls)
        {
            if (totalCalls <= 0)
                throw new ArgumentException("Общее число звонков должно быть > 0.");
            if (escalatedCalls < 0 || escalatedCalls > totalCalls)
                throw new ArgumentException("Некорректное число эскалаций.");
            return (double)escalatedCalls / totalCalls * 100;
        }
    }
}