using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace students
{
    public partial class Form1 : Form
    {

           Stack<string> student_stack = new Stack<string>();
           Queue<string> student_queue = new Queue<string>();
           string student_name;


        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked && student_stack.Count > 0)
            {
                label1.Text = "Last extracted in stack: " + student_stack.Pop(); // Извлекает позицию из стека и возвращает ее в label
                label2.Text = "Student list: " + string.Join(", ", student_stack.ToArray()); // Показывает все позиции в стеке
            }
            else if (radioButton2.Checked && student_queue.Count > 0)
            {
                label1.Text = "Last extracted in queue: " + student_queue.Dequeue(); // Извлекает позицию из очереди и возвращает ее в label
                label2.Text = "Student list: " + string.Join(", ", student_queue.ToArray()); // Показывает все позиции в очереди
            }
            else if(radioButton1.Checked && student_stack.Count <= 0)
            {
                label1.Text = "No students in stack";
            }
            else if (radioButton2.Checked && student_queue.Count <= 0)
            {
                label1.Text = "No students in queue";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student_name = textBox1.Text;

            if (textBox1.TextLength > 0) {
                if (radioButton1.Checked)
                {
                    student_stack.Push(student_name); // Добавляет новую позицию в стек
                    label1.Text = "You add student " + student_stack.Peek(); // Показывает последнюю позицию
                    label2.Text = "Student list: " + string.Join(", ", student_stack.ToArray()); // Показывает все позиции в стеке
                }
                else if (radioButton2.Checked)
                {
                    student_queue.Enqueue(student_name); // Добавляет новую позицию в очередь
                    label2.Text = "Student list: " + string.Join(", ", student_queue.ToArray()); // Показывает все позиции в очереди
                }
                else
                {
                    label1.Text = "Choose stack or queue";
                }
            }
            else
            {
                label1.Text = "Enter student name";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool letter = char.IsLetter(e.KeyChar);
            bool control = Char.IsControl(e.KeyChar);

            if (!(letter || control))
            {
                e.Handled = true;
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

    }
}
