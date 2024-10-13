using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab2Bai3
{
    public partial class Lab2Bai3 : Form
    {
        public Lab2Bai3()
        {
            InitializeComponent();
        }
        private string filePath;
        private string outputFilePath;
        private void filedirection_TextChanged(object sender, EventArgs e)
        {

        }

        private void butopenfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;
                filedirection.Text = filePath; // Hiển thị đường dẫn file trong filedirection textbox
            }
        }

        private void butcalculator_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath) && !string.IsNullOrEmpty(outputFilePath))
            {
                try
                {
                    string[] inputLines = File.ReadAllLines(filePath);

                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        foreach (string line in inputLines)
                        {
                            // Bỏ qua dòng trống hoặc dòng chỉ chứa khoảng trắng
                            if (string.IsNullOrWhiteSpace(line))
                            {
                                continue;
                            }

                            try
                            {
                                // Bỏ qua các khoảng trắng giữa các ký tự trong biểu thức
                                string trimmedLine = line.Trim();

                                // Kiểm tra nếu biểu thức hợp lệ, nếu không thì hiện thông báo lỗi
                                if (!IsValidExpression(trimmedLine))
                                {
                                    MessageBox.Show("Nội dung trong tệp không đúng định dạng tính toán.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return; // Ngừng xử lý và thoát
                                }

                                double result = EvaluateExpression(trimmedLine);

                                // Kiểm tra nếu là số nguyên, chỉ in phần nguyên
                                if (result % 1 == 0)
                                {
                                    writer.WriteLine($"{trimmedLine} = {((int)result).ToString()}");
                                }
                                else
                                {
                                    writer.WriteLine($"{trimmedLine} = {result.ToString("0.####", System.Globalization.CultureInfo.InvariantCulture)}");
                                }
                            }
                            catch (Exception)
                            {
                                // Nếu có lỗi trong khi tính toán, chỉ bỏ qua mà không ghi gì vào file
                                continue;
                            }
                        }
                    }

                    MessageBox.Show($"Đã tính toán xong. Kết quả đã được ghi vào tệp {outputFilePath}.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng mở tệp input và chọn tệp output trước.");
            }
        }

        // Hàm kiểm tra xem biểu thức có hợp lệ không
        private bool IsValidExpression(string expression)
        {
            // Biểu thức hợp lệ bao gồm số và phép tính (+, -, *, /)
            // Phải có thứ tự đúng: số -> phép toán -> số, có thể có khoảng trắng
            string pattern = @"^(\d+(\.\d+)?\s*[\+\-\*/]\s*)+\d+(\.\d+)?$";
            return System.Text.RegularExpressions.Regex.IsMatch(expression, pattern);
        }



        private void butreadfile_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                try
                {
                    string content = File.ReadAllText(filePath);
                    readfile.Text = content; // Hiển thị nội dung file trong readtextbox
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi đọc tệp tin: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng mở tệp tin trước.");
            }
        }

        private void readfile_TextChanged(object sender, EventArgs e)
        {

        }


        // Hàm để tính toán biểu thức
       



        // Hàm mở file output3.txt và hiển thị đường dẫn
        private void butopenout_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                outputFilePath = openFileDialog.FileName;
                filedirectionout.Text = outputFilePath; // Hiển thị đường dẫn file output trong filedirectionout textbox

                // Xóa nội dung trong file để chuẩn bị ghi dữ liệu mới
                try
                {
                    File.WriteAllText(outputFilePath, string.Empty); // Xóa hết nội dung trong file
                    MessageBox.Show("File output đã được mở và nội dung đã bị xóa để ghi dữ liệu mới.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa nội dung file: " + ex.Message);
                }
            }
        }

        private void filedirectionout_TextChanged(object sender, EventArgs e)
        {

        }

        // Hàm tính toán biểu thức
        public double EvaluateExpression(string expression)
        {
            try
            {
                // Loại bỏ khoảng trắng trong biểu thức
                expression = expression.Replace(" ", "");

                // Ngăn xếp để lưu các toán hạng và toán tử
                Stack<double> operands = new Stack<double>();
                Stack<char> operators = new Stack<char>();

                for (int i = 0; i < expression.Length; i++)
                {
                    char current = expression[i];

                    // Nếu là số hoặc dấu chấm (phần thập phân), xử lý số nguyên hoặc số thập phân
                    if (char.IsDigit(current) || current == '.')
                    {
                        string numStr = "";
                        while (i < expression.Length && (char.IsDigit(expression[i]) || expression[i] == '.'))
                        {
                            numStr += expression[i];
                            i++;
                        }
                        i--; // Giảm i vì vòng lặp for sẽ tăng lên 1 lần nữa
                        operands.Push(double.Parse(numStr, System.Globalization.CultureInfo.InvariantCulture));
                    }
                    else if (current == '(')
                    {
                        // Nếu gặp dấu ngoặc mở, thêm vào ngăn xếp toán tử
                        operators.Push(current);
                    }
                    else if (current == ')')
                    {
                        // Nếu gặp dấu ngoặc đóng, tính toán cho đến khi gặp dấu ngoặc mở
                        while (operators.Peek() != '(')
                        {
                            ProcessStacks(operands, operators);
                        }
                        operators.Pop(); // Bỏ dấu ngoặc mở '('
                    }
                    else if (IsOperator(current))
                    {
                        // Nếu là toán tử, xử lý theo thứ tự ưu tiên
                        while (operators.Count > 0 && Precedence(operators.Peek()) >= Precedence(current))
                        {
                            ProcessStacks(operands, operators);
                        }
                        operators.Push(current);
                    }
                }

                // Xử lý các toán tử còn lại trong ngăn xếp
                while (operators.Count > 0)
                {
                    ProcessStacks(operands, operators);
                }

                // Kết quả cuối cùng nằm ở đỉnh ngăn xếp
                return operands.Pop();
            }
            catch (Exception ex)
            {
                throw new Exception("Biểu thức không hợp lệ: " + ex.Message);
            }
        }

        // Hàm kiểm tra toán tử
        private bool IsOperator(char c)
        {
            return c == '+' || c == '-' || c == '*' || c == '/';
        }

        // Hàm trả về độ ưu tiên của toán tử
        private int Precedence(char op)
        {
            if (op == '+' || op == '-')
                return 1;
            if (op == '*' || op == '/')
                return 2;
            return 0;
        }

        // Hàm thực hiện phép tính
        private void ProcessStacks(Stack<double> operands, Stack<char> operators)
        {
            double b = operands.Pop();
            double a = operands.Pop();
            char op = operators.Pop();

            switch (op)
            {
                case '+':
                    operands.Push(a + b);
                    break;
                case '-':
                    operands.Push(a - b);
                    break;
                case '*':
                    operands.Push(a * b);
                    break;
                case '/':
                    operands.Push(a / b);
                    break;
            }
        }
    }
}
