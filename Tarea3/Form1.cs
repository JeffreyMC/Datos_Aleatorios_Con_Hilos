using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; //nombre de espacios para manejar hilos

//Tarea 3
//Programación Avanzada
//Estudiante: Jeffrey Muñoz Castro
//Cédula: 1-1370-0324
namespace Tarea3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //se crea un arreglo int de 50 posiciones
        int[] arreglo = new int[50];

        //se crea un objeto random para generar los números aleatorios del arreglo
        //y para generar los numeros que recorre cada proceso
        //se le ingresa una semilla con el tiempo de la computadora
        Random rnd = new Random(DateTime.Now.Millisecond);

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //desabilita el botón que inicia los procesos
            btnInicProcesos.Enabled = false;
        }

        //Botón que al presionarse llena el arreglo con numeros
        private void button1_Click(object sender, EventArgs e)
        {
            //se llena el arreglo con numeros random del 1 al 256
            for (int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = rnd.Next(1, 256);
            }

            //habilita el botón que inicia los procesos
            btnInicProcesos.Enabled = true;
            //se desactiva el botón de llenar arreglo
            btnLlenaArray.Enabled = false;

            //limpia el texbox (en caso de que esté con información)
            campoTexto.Clear();
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            //se crean los 5 subprocesos
            Thread hilo1 = new Thread(new ParameterizedThreadStart(imprimir));
            hilo1.Name = "Proceso 1"; //se le asigna el nombre al hilo
            Thread hilo2 = new Thread(new ParameterizedThreadStart(imprimir));
            hilo2.Name = "Proceso 2"; //se le asigna el nombre al hilo
            Thread hilo3 = new Thread(new ParameterizedThreadStart(imprimir));
            hilo3.Name = "Proceso 3"; //se le asigna el nombre al hilo
            Thread hilo4 = new Thread(new ParameterizedThreadStart(imprimir));
            hilo4.Name = "Proceso 4"; //se le asigna el nombre al hilo
            Thread hilo5 = new Thread(new ParameterizedThreadStart(imprimir));
            hilo5.Name = "Proceso 5"; //se le asigna el nombre al hilo

            //se les asigna la prioridad a cada subproceso
            hilo1.Priority = ThreadPriority.Lowest;
            hilo2.Priority = ThreadPriority.Lowest;
            hilo3.Priority = ThreadPriority.Highest;
            hilo4.Priority = ThreadPriority.Highest;
            hilo5.Priority = ThreadPriority.Highest;


            //se inician los 5 subprocesos y se les pasa de argumento el nombre del hilo
            hilo1.Start(hilo1.Name);
            hilo2.Start(hilo2.Name);
            hilo3.Start(hilo3.Name);
            hilo4.Start(hilo4.Name);
            hilo5.Start(hilo5.Name);

            //desactiva el boton que inicia los procesos
            btnInicProcesos.Enabled = false;
            //habilita el botón que llena el arreglo
            btnLlenaArray.Enabled = true;
        }

        //se crea el delegado para manejar los subprocesos
        public delegate void delegadoImprimir(string name);

        //método que concatena la posicion, valor y nombre del subproceso
        public void imprimir(object name)
        {
            //si modificar el campoTexto es inseguro
            if (campoTexto.InvokeRequired)
            {
                  //se utiliza invoke para cambiar campoTexto por medio del delegado
                  Invoke(new delegadoImprimir(imprimir), new object[] { name });
             }
            //si se puede modificar
            else
            {
                //se recorren 10 posiciones del arreglo
                for (int i = 0; i < 10; i++)
                {
                    //genera un numero del 0-49 y lo almacena
                    int num = rnd.Next(0, 49);

                    //se concatena la información
                    campoTexto.AppendText(string.Format("{0}\t\t{1, 11}\t\t{2, 18}\n", num, arreglo[num], name ));
                    //Se 'duerme' el hilo por 100 milésimas de segundo
                    Thread.Sleep(100);

                }//fIN DEL FOR
            }//FIN DEL ELSE

        }//FIN DEL MÉTODO IMPRIMIR


    }// FIN DE LA CLASE


  }
    

