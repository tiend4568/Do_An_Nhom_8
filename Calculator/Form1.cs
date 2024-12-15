using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using static System.Windows.Forms.DataFormats;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private List<string> results = new List<string>(); // Danh sách để lưu trữ kết quả
        private ListBox historyListBox; // ListBox để hiển thị lịch sử
        private bool isFormExpanded = false; // Biến để theo dõi trạng thái mở rộng của form

        public Form1()
        {
            InitializeComponent();
            PowBtn.Text = "x\u207F"; // x^n vẽ PowBtn
            PowBtn.Refresh();
            ResBox.KeyPress += new KeyPressEventHandler(ResBox_KeyPress);
            // Khởi tạo và thêm ListBox cho lịch sử
            historyListBox = new ListBox();
            historyListBox.Visible = false; // Ban đầu ẩn
            historyListBox.Location = new System.Drawing.Point(this.ClientSize.Width, 0); // Điều chỉnh vị trí theo nhu cầu
            historyListBox.Size = new System.Drawing.Size(this.ClientSize.Width - 400, this.ClientSize.Height); // Điều chỉnh kích thước theo nhu cầu
            historyListBox.Font = new System.Drawing.Font("Arial", 14); // Thay đổi kích cỡ font chữ
            historyListBox.Click += new EventHandler(HistoryListBox_Click); // Thêm sự kiện Click
            this.Controls.Add(historyListBox);
            // Đăng ký sự kiện Resize
            this.Resize += new EventHandler(Form1_Resize);
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            // Điều chỉnh kích thước của ListBox khi form thay đổi kích thước
            historyListBox.Size = new Size(this.ClientSize.Width - 400, this.ClientSize.Height);
        }
        private void ResBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                // Đếm số lượng dấu chấm trong mỗi phần của biểu thức
                string[] parts = textBox.Text.Split(new char[] { '+', '-', 'x', '/', '%', '^', '(', ')' });
                bool valid = true;

                foreach (string part in parts)
                {
                    int dotCount = part.Count(c => c == '.');
                    if (dotCount > 1)
                    {
                        valid = false;
                        break;
                    }
                }

                if (!valid)
                {
                    // Loại bỏ dấu chấm thừa
                    int lastDotIndex = textBox.Text.LastIndexOf('.');
                    textBox.Text = textBox.Text.Remove(lastDotIndex, 1);
                    textBox.SelectionStart = lastDotIndex; // Đặt con trỏ tại vị trí dấu chấm cuối cùng
                }

                // Xóa số 0 ở đầu khi nhập số ban đầu
                if (textBox.Text.Length > 1 && textBox.Text[0] == '0' && textBox.Text[1] != '.')
                {
                    textBox.Text = textBox.Text.TrimStart('0');
                    textBox.SelectionStart = textBox.Text.Length; // Đặt con trỏ tại cuối chuỗi
                }
            }
        }
        private void ResBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                if (ResBox.Text.Length > 0)
                {
                    ResBox.Text = ResBox.Text.Substring(0, ResBox.Text.Length - 1);
                    ResBox.SelectionStart = ResBox.Text.Length;
                }
                e.Handled = true;
            }
            else if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Ngăn không cho ký tự này được nhập vào TextBox
            }
        }


        // Xử lý các sự kiện khi ấn các nút trên chương trình
        private void PowBtn_Click(object sender, EventArgs e)
        {
            ResBox.Text += "^";
        }
        private void button2_Click(object sender, EventArgs e) // Đây là phím căn bậc 2
        {
            ResBox.Text += "√";
        }
        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            ResBox.Text += "0";
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            ResBox.Text += "1";
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            ResBox.Text += "2";
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            ResBox.Text += "3";
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            ResBox.Text += "4";
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            ResBox.Text += "5";
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            ResBox.Text += "6";
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            ResBox.Text += "7";
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            ResBox.Text += "8";
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            ResBox.Text += "9";
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            ResBox.Text += ".";
        }
        private void DELBtn_Click(object sender, EventArgs e)
        {
            if (ResBox.Text.Length > 0)
            {
                // Xóa ký tự cuối cùng của ResBox
                ResBox.Text = ResBox.Text.Substring(0, ResBox.Text.Length - 1);

                // Đặt lại con trỏ sau khi xóa
                ResBox.SelectionStart = ResBox.Text.Length;
            }
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ResBox.Text = "0";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            ResBox.Text += "+";
            // Đặt lại trạng thái dấu chấm
            ResBox.Tag = false;
        }

        private void SubBtn_Click(object sender, EventArgs e)
        {
            ResBox.Text += "-";
            // Đặt lại trạng thái dấu chấm
            ResBox.Tag = false;
        }

        private void DivBtn_Click(object sender, EventArgs e)
        {
            ResBox.Text += "/";
            // Đặt lại trạng thái dấu chấm
            ResBox.Tag = false;
        }

        private void MultiBtn_Click(object sender, EventArgs e)
        {
            ResBox.Text += "x";
            // Đặt lại trạng thái dấu chấm
            ResBox.Tag = false;
        }

        private void PercentBtn_Click(object sender, EventArgs e)
        {
            ResBox.Text += "%";
            // Đặt lại trạng thái dấu chấm
            ResBox.Tag = false;
        }
        private void RightBtn_Click(object sender, EventArgs e)
        {
            ResBox.Text += "(";
        }

        private void LeftBtn_Click(object sender, EventArgs e)
        {
            ResBox.Text += ")";
        }
        private void AnsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = ResBox.Text.Replace("x", "*").Replace("%", "/100");
                string displayExpression = ResBox.Text;

                // Tách biểu thức trong ngoặc
                var regex = new Regex(@"\(([^()]+)\)");
                MatchCollection matches = regex.Matches(expression);

                // Tính toán biểu thức trong ngoặc
                foreach (Match match in matches)
                {
                    string innerExpression = match.Groups[1].Value;
                    DataTable innerTable = new DataTable();
                    var innerResult = innerTable.Compute(innerExpression, string.Empty);
                    expression = expression.Replace($"({innerExpression})", innerResult.ToString());
                }

                // Xử lý lũy thừa
                expression = ProcessPowerOperations(expression);

                // Xử lý căn bậc hai
                expression = ProcessSqrtOperations(expression);

                DataTable outerTable = new DataTable();
                var outerResult = outerTable.Compute(expression, string.Empty);

                decimal decimalResult = Convert.ToDecimal(outerResult);
                ResBox.Text = decimalResult.ToString("G17", CultureInfo.InvariantCulture);
                results.Add($"{displayExpression} = {ResBox.Text}");
                UpdateHistory();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Biểu thức không hợp lệ: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Phương thức xử lý phép lũy thừa
        private string ProcessPowerOperations(string expression)
        {
            var regex = new Regex(@"(\d+(?:\.\d+)?)\^(\d+(?:\.\d+)?)");
            return regex.Replace(expression, match =>
            {
                var baseNum = double.Parse(match.Groups[1].Value);
                var exponent = double.Parse(match.Groups[2].Value);
                return Math.Pow(baseNum, exponent).ToString();
            });
        }

        // Phương thức xử lý căn bậc hai
        private string ProcessSqrtOperations(string expression)
        {
            string pattern = @"√(\d+(\.\d+)?)";
            Regex regex = new Regex(pattern);

            while (regex.IsMatch(expression))
            {
                Match match = regex.Match(expression);
                if (match.Success)
                {
                    double number = Convert.ToDouble(match.Groups[1].Value, CultureInfo.InvariantCulture);
                    double sqrtResult = Math.Sqrt(number);
                    expression = expression.Replace(match.Value, sqrtResult.ToString("G17", CultureInfo.InvariantCulture));
                }
            }
            return expression;
        }
        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            // Chuyển đổi hiển thị của ListBox lịch sử
            historyListBox.Visible = !historyListBox.Visible;
            Form1 form1 = new Form1();
            // Mở rộng hoặc thu nhỏ form
            if (isFormExpanded)
            {
                HistoryBtn.Text = "Hiện lịch sử tính";

                this.Size = new System.Drawing.Size(form1.Size.Width, form1.Size.Height); // Kích thước ban đầu của form
            }
            else
            {
                HistoryBtn.Text = "Ẩn lịch sử tính";
                this.Size = new System.Drawing.Size(form1.Size.Width+300, form1.Size.Height); // Kích thước giảm của form
            }
            isFormExpanded = !isFormExpanded; // Đảo ngược trạng thái mở rộng
        }
        private void UpdateHistory()
        {
            // Cập nhật ListBox với các kết quả
            historyListBox.Items.Clear();
            foreach (var result in results)
            {
                historyListBox.Items.Add(result);
            }
        }

        private void HistoryListBox_Click(object sender, EventArgs e)
        {
            if (historyListBox.SelectedItem != null)
            {
                string selectedExpression = historyListBox.SelectedItem.ToString().Split('=')[0].Trim();
                ResBox.Text = $"({selectedExpression})";
            }
        }
    }
}
