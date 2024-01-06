using System;
using static System.Math;

namespace Neiroseti.ModelNW
{
    class Neuron
    {
        //private double a = 1.7159;
        //private double b = 2 / 3;
        private double a = 1;
        private double b = 1;
        // поля
        //Перечисление
        private TypeNeuron type;
        //Входные данные нейронов
        private double[] inputs;
        //Синаптические веса нейронов
        private double[] weights;
        private double derivative;
        //Выходной сигнал нейрона
        private double output;

        // свойства 
        public double[] Inputs
        {
            get { return inputs; }
            set { inputs = value; }
        }

        public double[] Weights
        {
            get { return weights; }
            set { weights = value; }
        }

        public double Derivative
        {
            get { return derivative; }
        }

        public double Output
        {
            get { return output; }
        }

        // конструктор

        public Neuron(double[] ws, TypeNeuron t)
        {
            type = t;
            weights = ws;
        }

        public void Activator()
        {
            // первый элемент weights - b (порог)
            double sum = weights[0];
            for (int i = 0; i < inputs.Length; i++)
            {
                sum += inputs[i] * weights[i + 1];
            }

            switch (type)
            {
                case TypeNeuron.Output:
                    output = Exp(sum);
                    break;
                case TypeNeuron.Hidden:
                    output = Logistic(sum);
                    derivative = Logistic_Derevator(sum);
                    break;
                default:
                    break;
            }
        }

        // функция активации
        private double Logistic(double arg)
        {
            //Дописать функцию активации
            return 1.0 / (1.0 + Math.Exp(-arg));
        }

        //производная
        private double Logistic_Derevator(double arg)
        {
            //дописать первая производная функции активации
            return Math.Exp(-arg)/Math.Pow((1+Math.Exp(-arg)), 2);
        }
    }
}

