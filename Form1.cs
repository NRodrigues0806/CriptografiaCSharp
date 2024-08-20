namespace DesafioAsenjo
{
    public partial class Form1 : Form
    {
        private string key = "auidhuahduahduahd!$#¨@¨5";
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text.Length != 0)
            {
                int tam, aux, aux2, p = 0;
                char x;



                tam = textBox1.Text.Length;
                string result = "";

                for (int i = 0; i < tam; i++)
                {
                    aux = (int)Math.Pow(2, tam) + 15;
                    aux2 = (int)(Math.Pow(2, aux) + Math.PI);

                    // Pega o caractere correspondente da chave (looping se necessário)
                    char keyChar = key[i % key.Length];

                    // Aplica a lógica matemática e adiciona a chave
                    x = (char)(textBox1.Text[i] + aux + aux2 + keyChar);
                    result += x;

                    p++;
                    if (p == 20)
                    {
                        p = 0;
                    }
                }
                textBox2.Text = result;
            }
            else
            {
                MessageBox.Show("Erro, valor não encontrado para encriptografar. \nDigite o valor ou texto antes!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                int tam, aux, aux2, p = 0;
                char x;


                tam = textBox2.Text.Length; // O texto criptografado está em textBox2
                string result = "";

                for (int i = 0; i < tam; i++)
                {
                    aux = (int)Math.Pow(2, tam) + 15;
                    aux2 = (int)(Math.Pow(2, aux) + Math.PI);

                    // Pega o caractere correspondente da chave (looping se necessário)
                    char keyChar = key[i % key.Length];

                    // Reverte a lógica matemática e a adição da chave
                    x = (char)(textBox2.Text[i] - aux - aux2 - keyChar);

                    // Concatena o caractere decriptografado ao resultado
                    result += x;

                    p++;
                    if (p == 20)
                    {
                        p = 0;
                    }
                }

                // Exibe o resultado decriptografado em outro TextBox
                textBox3.Text = result;
            }
            else
            {
                MessageBox.Show("Erro, valor não encontrado para decriptar. \nDigite o valor ou texto antes!");
            }
        }
    }
}
